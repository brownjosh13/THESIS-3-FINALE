Imports System
Imports System.IO.Ports
Imports MySql.Data.MySqlClient

Public Class Arduino
    Dim comPORT As String
    Dim receivedData As String = ""
    Dim conn As New MySqlConnection


    Private Sub Arduino_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Text = "Normal"
        refreshdatagrid()
        Label8.Hide()
        lblID.Hide()
        TextBox8.ReadOnly = True
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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        receivedData = ReceiveSerialData()
        lblID.Text = receivedData
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

    Private Sub ButtonUserData_Click(sender As Object, e As EventArgs) Handles ButtonUserData.Click
        UserView.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblID_Click(sender As Object, e As EventArgs) Handles lblID.Click

    End Sub

    Private Sub lblID_TextChanged(sender As Object, e As EventArgs) Handles lblID.TextChanged
        If lblID.Text = "" Then

        ElseIf lblID.Text <> "" Then
            TextBox8.Text = lblID.Text
        End If

    End Sub

    Private Sub refreshdatagrid()

        Dim str As String
        str = "SELECT * FROM patient"
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim insertString As String
        Dim conn As MySqlConnection
        Dim mycmd As MySqlCommand
        Dim reader As MySqlDataReader
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost; user=root; password=; database=healthmonitoring"

        Try
            conn.Open()

            insertString = "Insert into patient(Fullname,Address,Status,Temperature,BPM,Date,Time,PatientID) VALUES ('" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & ComboBox1.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox8.Text & "' );"
            mycmd = New MySqlCommand(insertString, conn)
            reader = mycmd.ExecuteReader


            conn.Close()
            refreshdatagrid()


            TextBox1.Clear()
            TextBox2.Clear()
            ComboBox1.Text = "Normal"
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
            TextBox6.Clear()
            TextBox8.Clear()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost; user=root; password=; database=healthmonitoring"

        Try
            conn.Open()
            Dim dr As MySqlDataReader
            Dim query As String = "select * from patient where PatientID='" & TextBox8.Text & "';"
            Dim cmd As MySqlCommand = New MySqlCommand(query, conn)
            dr = cmd.ExecuteReader
            If dr.Read Then
                TextBox1.Text = dr.GetString(0)
                TextBox2.Text = dr.GetString(1)
                TextBox1.Enabled = False
                TextBox2.Enabled = False
                dr.Close()
            Else

            End If

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub
End Class