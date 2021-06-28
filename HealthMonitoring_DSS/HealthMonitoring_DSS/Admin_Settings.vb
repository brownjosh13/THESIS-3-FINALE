Imports MySql.Data.MySqlClient
Imports System.IO.Ports
Imports System.Data
Public Class Admin_Settings

    Dim conn As MySqlConnection
    Dim mycmd As MySqlCommand
    Dim reader As MySqlDataReader
    Dim insertString As String
    Dim deleteStringer As String
    Dim receivedData As String = ""
    Dim comPORT As String

    Private Sub getdata()
        Dim str As String
        str = "SELECT Availability,Fullname,Civil_Status,Address,Status,Note,Room_No,Height,Weight,Temperature,BPM,Month,Day,Year,Timess,PatientID FROM patient where PatientID = '" & TextBox2.Text & "' ORDER by Month Desc, Day Desc, Year Desc"
        Dim dbconn As New MySqlConnection
        dbconn.ConnectionString = "server=localhost; user=root; password=; database=healthmonitoring"
        Try
            dbconn.Open()
            Dim search As New MySqlDataAdapter(str, dbconn)
            Dim ds As New DataSet
            search.Fill(ds, "patient")
            DataGridView2.DataSource = ds.Tables("patient")
            dbconn.Close()


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub barronlangmalakas()
        Dim str As String
        str = "SELECT * FROM patient ORDER by Year Desc, Day Desc, Month Desc"
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost; user=root; password=; database=healthmonitoring"
        Try
            conn.Open()
            Dim search As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            search.Fill(ds, "patient")
            DataGridView1.DataSource = ds.Tables("patient")
            conn.Close()


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub vaccination()
        Dim str As String
        str = "SELECT * FROM kidsvaccination ORDER by Year Desc, Day Desc, Month Desc"
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost; user=root; password=; database=healthmonitoring"

        Try
            conn.Open()
            Dim search As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            search.Fill(ds, "kidsvaccination")
            DataGridView3.DataSource = ds.Tables("kidsvaccination")
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        ButtonRegistration.Enabled = False
        barronlangmalakas()
        vaccination()

        Me.CenterToScreen()
        GroupBox4.Hide()
        TextBox2.ReadOnly = True
        Label8.Hide()
        lblID.Hide()
        Timer1.Enabled = False
        TextBox2.Hide()
        Label56.Hide()
        DataGridView1.Show()
        DataGridView3.Hide()
        DataGridView2.Hide()

        Panel2.Hide()


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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost; user=root; password=; database=healthmonitoring"

        Try
            conn.Open()

            insertString = "Insert into patient(Availability,Fullname,Age,Civil_Status,Address,Status,Note,Room_No,Height,Weight,Temperature,BPM,Month,Day,Year,Timess,PatientID) VALUES ('" & txtavail.Text & "','" & txtName.Text & "','" & txtAge.Text & "', '" & txtCivilStatus.Text & "', '" & txtAddress.Text & "',   '" & ComboBox1.Text & "', '" & txtNote.Text & "', '" & txtRoomNo.Text & "', '" & txtHeight.Text & "', '" & txtWeight.Text & "',  '" & txtTemp.Text & "','" & txtBPM.Text & "','" & comboMonth1.Text & "','" & comboDay1.Text & "','" & comboYear1.Text & "','" & txtTime.Text & "','" & txtrf.Text & "' );"
            mycmd = New MySqlCommand(insertString, conn)
            reader = mycmd.ExecuteReader


            conn.Close()
            barronlangmalakas()

            txtavail.Clear()
            txtName.Clear()
            txtAddress.Clear()
            ComboBox1.Text = "Normal"
            txtTemp.Clear()
            txtBPM.Clear()
            comboMonth1.Text = ""
            comboDay1.Text = ""
            comboYear1.Text = ""
            txtTime.Clear()
            TextBox7.Clear()
            txtrf.Clear()
            txtCivilStatus.Clear()
            txtHeight.Clear()
            txtWeight.Clear()
            txtRoomNo.Clear()
            txtNote.Clear()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost; user=root; password=; database=healthmonitoring"

        Try
            conn.Open()

            insertString = "update patient set Availability ='" & txtavail.Text & "', Fullname='" & txtName.Text & "', age='" & txtAge.Text & "', Civil_Status ='" & txtCivilStatus.Text & "'    ,Address='" & txtAddress.Text & "',Status='" & ComboBox1.Text & "', Note='" & txtNote.Text & "', Room_No='" & txtRoomNo.Text & "', Height='" & txtHeight.Text & "', Weight ='" & txtWeight.Text & "',Month='" & comboMonth1.Text & "',day='" & comboDay1.Text & "',year='" & comboYear1.Text & "',Timess='" & txtTime.Text & "',PatientID='" & txtrf.Text & "' where PatientID = '" & txtrf.Text & "'"
            mycmd = New MySqlCommand(insertString, conn)
            reader = mycmd.ExecuteReader


            conn.Close()
            barronlangmalakas()

            txtavail.Clear()
            txtName.Clear()
            txtAddress.Clear()
            ComboBox1.Text = "Normal"
            txtTemp.Clear()
            txtBPM.Clear()
            comboMonth1.Text = ""
            comboDay1.Text = ""
            comboYear1.Text = ""
            txtTime.Clear()
            TextBox7.Clear()
            txtrf.Clear()
            txtCivilStatus.Clear()
            txtHeight.Clear()
            txtWeight.Clear()
            txtRoomNo.Clear()
            txtNote.Clear()
            txtrf.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub DataGridView1_CellContextMenuStripChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContextMenuStripChanged


    End Sub

    Private Sub DataGridView1_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseClick
        Dim i As Integer

        i = DataGridView1.CurrentRow.Index
        Try
            txtavail.Text = DataGridView1.Item(0, i).Value
            txtName.Text = DataGridView1.Item(1, i).Value
            txtAge.Text = DataGridView1.Item(2, i).Value
            txtCivilStatus.Text = DataGridView1.Item(3, i).Value
            txtAddress.Text = DataGridView1.Item(4, i).Value
            ComboBox1.Text = DataGridView1.Item(5, i).Value
            txtNote.Text = DataGridView1.Item(7, i).Value
            txtRoomNo.Text = DataGridView1.Item(8, i).Value
            txtHeight.Text = DataGridView1.Item(9, i).Value
            txtWeight.Text = DataGridView1.Item(10, i).Value
            txtTemp.Text = DataGridView1.Item(11, i).Value
            txtBPM.Text = DataGridView1.Item(12, i).Value
            comboMonth1.Text = DataGridView1.Item(14, i).Value
            comboDay1.Text = DataGridView1.Item(15, i).Value
            comboYear1.Text = DataGridView1.Item(16, i).Value
            txtTime.Text = DataGridView1.Item(17, i).Value
            txtrf.Text = DataGridView1.Item(18, i).Value

            lblunique.Text = DataGridView1.Item(23, i).Value



            lblrfid1.Text = DataGridView1.Item(18, i).Value
            lblname1.Text = DataGridView1.Item(1, i).Value
            lblage1.Text = DataGridView1.Item(2, i).Value
            lblbrgy1.Text = DataGridView1.Item(4, i).Value
            lblcivil1.Text = DataGridView1.Item(3, i).Value
            lblheight1.Text = DataGridView1.Item(9, i).Value
            lblweight1.Text = DataGridView1.Item(10, i).Value
            lbltemp1.Text = DataGridView1.Item(11, i).Value
            lblbpm1.Text = DataGridView1.Item(12, i).Value
            txtboxnotes1.Text = DataGridView1.Item(7, i).Value






        Catch ex As Exception

        End Try
    End Sub

    Private Sub reload()
        Dim backup As String
        backup = "select * from patient"
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost; user=root; password=; database=healthmonitoring; integrated security = true"

        Try
            conn.Open()
            insertString = insertString = "Insert into backup_patient(Availability,Fullname,Age,Civil_Status,Address,Status,Note,Room_No,Height,Weight,Temperature,BPM,Month,Day,Year,Timess,PatientRFID) VALUES ('" & txtavail.Text & "', '" & txtName.Text & "', '" & txtAge.Text & "', '" & txtCivilStatus.Text & "', '" & txtAddress.Text & "', '" & ComboBox1.Text & "','" & txtNote.Text & "','" & txtRoomNo.Text & "', '" & txtHeight.Text & "', '" & txtWeight.Text & "','" & txtTemp.Text & "','" & txtBPM.Text & "', '" & comboMonth1.Text & "',  '" & comboDay1.Text & "',  '" & comboYear1.Text & "','" & txtTime.Text & "','" & txtrf.Text & "') ;"
            mycmd = New MySqlCommand(insertString, conn)
            reader = mycmd.ExecuteReader

            reader.Close()
            conn.Close()
            barronlangmalakas()

        Catch ex As Exception

        End Try
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click


        txtavail.Clear()
        txtName.Text = ""
        txtAddress.Clear()
        txtTemp.Clear()
        txtBPM.Clear()
        comboMonth1.Text = ""
        comboDay1.Text = ""
        comboYear1.Text = ""
        txtTime.Clear()
        txtCivilStatus.Clear()
        txtHeight.Clear()
        txtWeight.Clear()
        txtRoomNo.Clear()
        txtNote.Clear()
        ComboBox1.Text = "Normal"
        txtrf.Text = "N/A"


        txtAge.Clear()

        txtrf.Enabled = True
        txtName.Enabled = True
        txtAddress.Enabled = True




    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        Dim str As String
        str = "SELECT * FROM patient where PatientID like '%" + TextBox7.Text + "%'  or Fullname like '%" + TextBox7.Text + "%'or Address like '%" + TextBox7.Text + "%' "
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost; user=root; password=; database=healthmonitoring"
        Try
            conn.Open()
            Dim search As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            search.Fill(ds, "patient")
            DataGridView2.DataSource = ds.Tables("patient")
            conn.Close()


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub TextBox7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox7.KeyPress

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        txtTime.Text = Date.Now.ToString("hh:mm tt")
        receivedData = ReceiveSerialData()
        lblID.Text = receivedData
        TextBox2.Text = receivedData

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


    Private Sub lblID_TextChanged(sender As Object, e As EventArgs) Handles lblID.TextChanged
        If lblID.Text = "" Then

        ElseIf lblID.Text <> "" Then
            txtrf.Text = lblID.Text

        End If

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Admin_Staff.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonUserData_Click(sender As Object, e As EventArgs)
        Admin_ViewData.Show()
        Me.Hide()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        Admin_Reports.Show()
        Me.Hide()

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)
        Admin_BackupStaff.Show()
        Me.Hide()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)
        Admin_BackupPatient.Show()
        Admin_BackupPatient.Button9.PerformClick()
        Me.Hide()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        barronlangmalakas()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Admin_Inbox.Show()
        Me.Hide()
    End Sub

    Private Sub GroupBox5_Enter(sender As Object, e As EventArgs) Handles GroupBox5.Enter

    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles txtrf.TextChanged
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost; user=root; password=; database=healthmonitoring"

        Try
            conn.Open()
            Dim dr As MySqlDataReader
            Dim query As String = "select * from patient where PatientID='" & txtrf.Text & "';"
            Dim cmd As MySqlCommand = New MySqlCommand(query, conn)
            dr = cmd.ExecuteReader
            If dr.Read Then


                txtName.Enabled = False
                txtAddress.Enabled = False


                txtavail.Text = dr.GetString(0)
                txtName.Text = dr.GetString(1)
                txtAge.Text = dr.GetString(2)
                txtCivilStatus.Text = dr.GetString(3)
                txtAddress.Text = dr.GetString(4)
                ComboBox1.Text = dr.GetString(5)
                txtNote.Text = dr.GetString(7)
                txtRoomNo.Text = dr.GetString(8)
                txtHeight.Text = dr.GetString(9)
                txtWeight.Text = dr.GetString(10)
                txtTemp.Text = dr.GetString(11)
                txtBPM.Text = dr.GetString(12)
                comboMonth1.Text = dr.GetString(14)
                comboDay1.Text = dr.GetString(15)
                comboYear1.Text = dr.GetString(16)
                txtTime.Text = dr.GetString(17)
                txtrf.Text = dr.GetString(18)

                lblunique.Text = dr.GetString(23)

                lblRFID.Text = dr.GetString(18)
                lblName.Text = dr.GetString(1)
                lblCivil.Text = dr.GetString(3)
                lblAddress.Text = dr.GetString(4)
                lblHeight.Text = dr.GetString(9)
                lblWeight.Text = dr.GetString(10)
                lblRoom.Text = dr.GetString(8)
                lblTemp.Text = dr.GetString(11)
                lblBPM.Text = dr.GetString(12)
                lblStatus.Text = dr.GetString(5)
                lblMonth.Text = dr.GetString(14)
                lblDay.Text = dr.GetString(15)
                lblYear.Text = dr.GetString(16)
                lblTime.Text = dr.GetString(17)
                lblavail.Text = dr.GetString(0)
                txtNote.Text = dr.GetString(7)


                dr.Close()
            Else

            End If

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtavail_TextChanged(sender As Object, e As EventArgs) Handles txtavail.TextChanged

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Admin_Receipt.Show()
        Me.Hide()

    End Sub

    Private Sub txtRefresh_Click(sender As Object, e As EventArgs) Handles txtRefresh.Click
        barronlangmalakas()
        Me.DataGridView1.Refresh()
        Me.DataGridView2.Refresh()
        Me.DataGridView3.Refresh()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs)
        getdata()

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Panel2.Show()
        GroupBox5.Hide()
        DataGridView2.Show()
        DataGridView1.Hide()

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        GroupBox5.Show()
        Panel2.Hide()
        DataGridView1.Show()
        DataGridView2.Hide()
        DataGridView3.Hide()

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub


    Private Sub Button14_Click_1(sender As Object, e As EventArgs)
        getdata()

    End Sub

    Private Sub DataGridView2_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridView2.MouseClick
        Dim b As Integer

        b = DataGridView2.CurrentRow.Index

        lblavail.Text = DataGridView2.Item(0, b).Value
        lblName.Text = DataGridView2.Item(1, b).Value
        lblCivil.Text = DataGridView2.Item(3, b).Value
        lblAddress.Text = DataGridView2.Item(4, b).Value
        lblStatus.Text = DataGridView2.Item(5, b).Value
        txtNote.Text = DataGridView2.Item(7, b).Value
        lblRoom.Text = DataGridView2.Item(8, b).Value
        lblHeight.Text = DataGridView2.Item(9, b).Value
        lblWeight.Text = DataGridView2.Item(10, b).Value
        lblTemp.Text = DataGridView2.Item(11, b).Value
        lblBPM.Text = DataGridView2.Item(12, b).Value
        lblMonth.Text = DataGridView2.Item(13, b).Value
        lblTime.Text = DataGridView2.Item(17, b).Value
        lblRFID.Text = DataGridView2.Item(18, b).Value
    End Sub



    Private Sub PictureBox4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnOpenPort_Click(sender As Object, e As EventArgs) Handles btnOpenPort.Click
        GroupBox4.Show()
        GroupBox7.Hide()

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        GroupBox4.Hide()
        GroupBox7.Show()

    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        GroupBox5.Hide()
        Panel2.Show()


        DataGridView1.Hide()
        DataGridView2.Show()
        DataGridView3.Hide()


    End Sub

    Private Sub Label56_Click(sender As Object, e As EventArgs) Handles Label56.Click

    End Sub

    Private Sub Label56_TextChanged(sender As Object, e As EventArgs) Handles Label56.TextChanged
        If Label56.Text = "" Then

        ElseIf Label56.Text <> "" Then
            TextBox2.Text = Label56.Text
            TextBox7.Text = Label56.Text
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If TextBox2.Text = "" Then

        ElseIf TextBox2.Text <> "" Then
            Label56.Text = TextBox2.Text

        End If
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub GroupBox6_Enter(sender As Object, e As EventArgs) Handles GroupBox6.Enter

    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        DataGridView1.Show()
        DataGridView2.Hide()
        DataGridView3.Hide()

        Panel2.Hide()


    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        GroupBox5.Show()
        GroupBox9.Hide()
        DataGridView1.Show()
        DataGridView2.Hide()
        DataGridView3.Hide()


    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        GroupBox9.Hide()
        Panel2.Show()
        DataGridView2.Show()
        DataGridView1.Hide()
        DataGridView3.Hide()


    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        Panel2.Hide()
        GroupBox9.Show()
        DataGridView3.Show()
        DataGridView1.Hide()
        DataGridView2.Hide()


    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        DataGridView3.Show()
        DataGridView2.Hide()
        DataGridView1.Hide()

        GroupBox9.Show()



    End Sub

    Private Sub Button14_Click_2(sender As Object, e As EventArgs) Handles Button14.Click

    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost; user=root; password=; database=healthmonitoring"

        Try
            conn.Open()

            insertString = "Insert into kidsvaccination(name,age,birthday,birthplace,address,weight,height,mothersname,fathersname,contact,typeofvaccine,month,day,year,nextMonth,nextDay,nextYear) VALUES ('" & txtkidname.Text & "','" & combokidage.Text & "','" & txtkidbday.Text & "','" & txtkidbplace.Text & "','" & txtkidaddress.Text & "','" & txtkidWeight.Text & "','" & txtkidheight.Text & "','" & txtkidmother.Text & "','" & txtkidfather.Text & "','" & txtkidcontact.Text & "','" & comboVaccine.Text & "','" & comboCurrentMonth.Text & "','" & comboCurrentDay.Text & "','" & comboCurrentYear.Text & "','" & comboMonth.Text & "','" & comboDay.Text & "','" & combotaon.Text & "');"
            mycmd = New MySqlCommand(insertString, conn)
            reader = mycmd.ExecuteReader


            conn.Close()
            vaccination()
            txtavail.Clear()
            txtName.Clear()
            txtAddress.Clear()
            ComboBox1.Text = "Normal"
            txtTemp.Clear()
            txtBPM.Clear()
            comboMonth1.Text = ""
            comboDay1.Text = ""
            comboYear1.Text = ""
            txtTime.Clear()
            TextBox7.Clear()
            txtrf.Clear()
            txtCivilStatus.Clear()
            txtHeight.Clear()
            txtWeight.Clear()
            txtRoomNo.Clear()
            txtNote.Clear()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView3_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridView3.MouseClick
        Dim c As Integer

        c = DataGridView3.CurrentRow.Index


        txtkidname.Text = DataGridView3.Item(0, c).Value
        combokidage.Text = DataGridView3.Item(1, c).Value
        txtkidbday.Text = DataGridView3.Item(2, c).Value
        txtkidbplace.Text = DataGridView3.Item(3, c).Value
        txtkidaddress.Text = DataGridView3.Item(4, c).Value
        txtkidWeight.Text = DataGridView3.Item(5, c).Value
        txtkidheight.Text = DataGridView3.Item(6, c).Value
        txtkidmother.Text = DataGridView3.Item(7, c).Value
        txtkidfather.Text = DataGridView3.Item(8, c).Value
        txtkidcontact.Text = DataGridView3.Item(9, c).Value
        comboVaccine.Text = DataGridView3.Item(10, c).Value
        comboCurrentMonth.Text = DataGridView3.Item(11, c).Value
        comboCurrentDay.Text = DataGridView3.Item(12, c).Value
        comboCurrentYear.Text = DataGridView3.Item(13, c).Value
        comboMonth.Text = DataGridView3.Item(16, c).Value
        comboDay.Text = DataGridView3.Item(17, c).Value
        combotaon.Text = DataGridView3.Item(18, c).Value

    End Sub

    Private Sub Label23_Click(sender As Object, e As EventArgs) Handles Label23.Click

    End Sub

    Private Sub lblavail_Click(sender As Object, e As EventArgs) Handles lblavail.Click

    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        Admin_Reports.Show()
        Me.Hide()

    End Sub

    Private Sub DataGridView2_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost; user=root; password=; database=healthmonitoring"

        Me.DataGridView1.Refresh()
        Try

            conn.Open()

            insertString = "Insert into backup_patient(Availability,Fullname,Age,Civil_Status,Address,Status,Note,Room_No,Height,Weight,Temperature,BPM,Month,Day,Year,Timess,PatientRFID) VALUES ('" & txtavail.Text & "', '" & txtName.Text & "', '" & txtAge.Text & "', '" & txtCivilStatus.Text & "', '" & txtAddress.Text & "', '" & ComboBox1.Text & "','" & txtNote.Text & "','" & txtRoomNo.Text & "', '" & txtHeight.Text & "', '" & txtWeight.Text & "','" & txtTemp.Text & "','" & txtBPM.Text & "', '" & comboMonth1.Text & "',  '" & comboDay1.Text & "',  '" & comboYear1.Text & "','" & txtTime.Text & "','" & txtrf.Text & "') ;"
            mycmd = New MySqlCommand(insertString, conn)
            reader = mycmd.ExecuteReader

            reader.Close()


            insertString = "delete from patient where PatientID='" & lblID.Text & "'"
            mycmd = New MySqlCommand(insertString, conn)
            reader = mycmd.ExecuteReader

            conn.Close()
            reload()
            barronlangmalakas()





        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click

    End Sub

    Private Sub Label79_Click(sender As Object, e As EventArgs) Handles lblDay.Click

    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click


        txtkidname.Clear()
        txtkidaddress.Clear()
        txtkidbday.Clear()
        txtkidbplace.Clear()
        txtkidcontact.Clear()
        txtkidfather.Clear()
        txtkidmother.Clear()
        txtkidheight.Clear()
        txtkidWeight.Clear()
        combotaon.Text = ""
        comboMonth.Text = ""
        comboDay.Text = ""
        comboCurrentDay.Text = ""
        comboCurrentMonth.Text = ""
        comboCurrentYear.Text = ""
        combokidage.Text = ""
        comboVaccine.Text = ""
    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click

        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost; user=root; password=; database=healthmonitoring"

        Try
            conn.Open()

            insertString = "update patient set service ='" & comboService1.Text & "' where PatientID = '" & lblrfid1.Text & "'"
            mycmd = New MySqlCommand(insertString, conn)
            reader = mycmd.ExecuteReader


            conn.Close()
            barronlangmalakas()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        Me.Hide()
        Print.Show()
    End Sub

    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        GroupBox9.Hide()
        PanelMedical.Show()

    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        PanelMedical.Hide()
        GroupBox5.Show()
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        PanelMedical.Hide()
        GroupBox9.Show()

    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        PanelMedical.Hide()
        Panel2.Show()

    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        GroupBox5.Hide()
        PanelMedical.Show()
    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        Panel2.Hide()
        PanelMedical.Show()

    End Sub

    Private Sub Button36_Click(sender As Object, e As EventArgs) Handles Button36.Click
        Me.Hide()
        Restore_Data_Selection.Show()

    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost; user=root; password=; database=healthmonitoring"

        Try
            conn.Open()

            insertString = "update patient set Availability ='" & txtavail.Text & "', Status='" & ComboBox1.Text & "', Note='" & txtNote.Text & "' , Room_No='" & txtRoomNo.Text & "' , Month='" & comboMonth1.Text & "', Day='" & comboDay1.Text & "', Year='" & comboYear1.Text & "' WHERE Fullname = '" & txtName.Text & "'"
            mycmd = New MySqlCommand(insertString, conn)
            reader = mycmd.ExecuteReader

            MessageBox.Show("Receipt updated!")
            conn.Close()
            barronlangmalakas()



            txtkidname.Clear()
            txtkidaddress.Clear()
            txtkidbday.Clear()
            txtkidbplace.Clear()
            txtkidcontact.Clear()
            txtkidfather.Clear()
            txtkidmother.Clear()
            txtkidheight.Clear()
            txtkidWeight.Clear()
            combotaon.Text = ""
            comboMonth.Text = ""
            comboDay.Text = ""
            comboCurrentDay.Text = ""
            comboCurrentMonth.Text = ""
            comboCurrentYear.Text = ""
            combokidage.Text = ""
            comboVaccine.Text = ""

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles Button8.Click
        Backup_Database.Show()
        Me.Hide()

    End Sub
End Class