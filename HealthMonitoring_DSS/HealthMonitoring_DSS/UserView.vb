
Imports System.IO.Ports
Imports MySql.Data.MySqlClient
Public Class UserView
    Dim comPORT As String
    Dim receivedData As String = ""
    Dim conn As New MySqlConnection
    Private Sub Button3_Click(sender As Object, e As EventArgs)


        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Arduino.Show()
        Me.Hide()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Me.CenterToScreen()
        Button4.Enabled = False
        TextBox1.ReadOnly = True

        Label17.Hide()
        lblID.Hide()
        Timer1.Enabled = False
        comPORT = ""
        For Each sp As String In My.Computer.Ports.SerialPortNames
            comPort_ComboBox.Items.Add(sp)
        Next

        connect()
        Try
            conn.Open()
        Catch ex As Exception
            End
        End Try

    End Sub
    Public Sub connect()

        Dim DatabaseName As String = "healthmonitoring"
        Dim server As String = "localhost"
        Dim userName As String = "root"
        Dim password As String = ""
        If Not conn Is Nothing Then conn.Close()
        conn.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false;SslMode=none", server, userName, password, DatabaseName)
        Try
            conn.Open()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub comPort_ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comPort_ComboBox.SelectedIndexChanged
        If (comPort_ComboBox.SelectedItem <> "") Then
            comPORT = comPort_ComboBox.SelectedItem
        End If
    End Sub
    Private Sub connect_BTN_Click(sender As Object, e As EventArgs) Handles connect_BTN.Click
        If (connect_BTN.Text = "Connect") Then
            If (comPORT <> "") Then
                SerialPort1.Close()
                SerialPort1.PortName = comPORT
                SerialPort1.BaudRate = 9600
                SerialPort1.DataBits = 8
                SerialPort1.Parity = Parity.None
                SerialPort1.StopBits = StopBits.One
                SerialPort1.Handshake = Handshake.None
                SerialPort1.Encoding = System.Text.Encoding.Default
                SerialPort1.ReadTimeout = 10000

                SerialPort1.Open()
                connect_BTN.Text = "Dis-connect"
                Timer1.Enabled = True
                Timer_LBL.Text = "Device: ON"
            Else
                MsgBox("Select a COM port first")
            End If
        Else
            SerialPort1.Close()
            connect_BTN.Text = "Connect"
            Timer1.Enabled = False
            Timer_LBL.Text = "Device: OFF"
        End If
    End Sub
    Function ReceiveSerialData() As String
        Dim Incoming As String
        Try
            Incoming = SerialPort1.ReadExisting()
            If Incoming Is Nothing Then
                Return "nothing" & vbCrLf
            Else
                Return Incoming
            End If
        Catch ex As TimeoutException
            Return "Error: Serial Port read timed out."
        End Try

    End Function
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        receivedData = ReceiveSerialData()
        lblID.Text = receivedData

    End Sub
    Private Sub lblID_TextChanged(sender As Object, e As EventArgs) Handles lblID.TextChanged
        If lblID.Text = "" Then

        ElseIf lblID.Text <> "" Then
            TextBox1.Text = lblID.Text
        End If

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        refreshdatagrid()

    End Sub

    Private Sub refreshdatagrid()

        Dim str As String
        str = "SELECT Fullname,Address,Status,Temperature,BPM,Date,Time,PatientID FROM patient where PatientID = '" & TextBox1.Text & "'"
        Dim dbconn As New MySqlConnection
        dbconn.ConnectionString = "server=localhost; user=root; password=; database=healthmonitoring"
        Try
            dbconn.Open()
            Dim search As New MySqlDataAdapter(str, dbconn)
            Dim ds As New DataSet
            search.Fill(ds, "patient")
            DataGridView1.DataSource = ds.Tables("patient")
            dbconn.Close()


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Message.Show()
        Me.Hide()
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub
End Class