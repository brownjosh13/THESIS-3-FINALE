Imports MySql.Data.MySqlClient
Imports System.Data

Public Class Admin_Inbox
    Dim conn As MySqlConnection
    Dim mycmd As MySqlCommand
    Dim reader As MySqlDataReader
    Dim insertString As String
    Dim query1 As String

    Private Sub messagerefresh()

        Dim str As String
        str = "SELECT * FROM messages order by Sender DESC"
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost; user=root; password=; database=healthmonitoring"
        Try
            conn.Open()
            Dim search As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            search.Fill(ds, "messages")
            DataGridView1.DataSource = ds.Tables("messages")
            conn.Close()


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try


    End Sub
    Private Sub Admin_Inbox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button2.Enabled = False
        Panel1.Visible = True
        Panel2.Visible = False
        messagerefresh()
        Me.CenterToScreen()
        Timer1.Enabled = True
        txtSender.Text = "Admin"
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Panel1.Visible = False
        Panel2.Visible = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        messagerefresh()
        Panel2.Visible = False
        Panel1.Visible = True
    End Sub

    Private Sub DataGridView1_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseClick
        Dim i As Integer

        i = DataGridView1.CurrentRow.Index
        Try
            Label6.Text = DataGridView1.Item(1, i).Value
            Label7.Text = DataGridView1.Item(3, i).Value
            TextBox2.Text = DataGridView1.Item(2, i).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ButtonUserData_Click(sender As Object, e As EventArgs)
        Admin_ViewData.Show()
        Me.Hide()

    End Sub

    Private Sub ButtonRegistration_Click(sender As Object, e As EventArgs) Handles ButtonRegistration.Click
        Admin_Settings.Show()
        Me.Hide()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Admin_Staff.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        Admin_Reports.Show()
        Me.Hide()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)
        Admin_BackupPatient.Show()
        Me.Hide()

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)
        Admin_BackupStaff.Show()
        Me.Hide()
    End Sub



    Private Sub ButtonRegistration_MouseHover(sender As Object, e As EventArgs) Handles ButtonRegistration.MouseHover
        ButtonRegistration.ForeColor = Color.MidnightBlue
    End Sub

    Private Sub ButtonRegistration_Leave(sender As Object, e As EventArgs) Handles ButtonRegistration.Leave
        ButtonRegistration.ForeColor = Color.FromArgb(21, 67, 96)
    End Sub

    Private Sub Button7_MouseHover(sender As Object, e As EventArgs) Handles Button7.MouseHover
        Button7.ForeColor = Color.MidnightBlue
    End Sub

    Private Sub Button7_MouseLeave(sender As Object, e As EventArgs) Handles Button7.MouseLeave
        Button7.ForeColor = Color.FromArgb(21, 67, 96)
    End Sub

    Private Sub Button6_MouseLeave(sender As Object, e As EventArgs)
        Button7.ForeColor = Color.FromArgb(21, 67, 96)
    End Sub

    Private Sub Button2_MouseHover(sender As Object, e As EventArgs) Handles Button2.MouseHover
        Button2.ForeColor = Color.MidnightBlue
    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Button2.ForeColor = Color.FromArgb(21, 67, 96)
    End Sub

    Private Sub Button8_MouseHover(sender As Object, e As EventArgs)
        Button2.ForeColor = Color.MidnightBlue
    End Sub

    Private Sub Button8_MouseLeave(sender As Object, e As EventArgs)
        Button2.ForeColor = Color.FromArgb(21, 67, 96)
    End Sub



    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        query1 = "SELECT Uname from admin where Uname='Sender'"

        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost; user=root; password=; database=healthmonitoring"

        Try
            conn.Open()

            insertString = "Insert into messages(Sender,Message, Receiver, Dates, Timess) VALUES ('" & txtSender.Text & "','" & txtmessage.Text & "', '" & txtreceiver.Text & "','" & lbldate.Text & "','" & lbltime.Text & "');"
            mycmd = New MySqlCommand(insertString, conn)
            reader = mycmd.ExecuteReader


            conn.Close()

            txtmessage.Clear()
            txtreceiver.Clear()

            MsgBox("Message sent!", MsgBoxStyle.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbldate.Text = Date.Now.ToString("MMM dd, yyyy")
        lbltime.Text = Date.Now.ToString("hh:mm:ss")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Admin_Reports.Show()
        Me.Hide()

    End Sub

    Private Sub Button36_Click(sender As Object, e As EventArgs) Handles Button36.Click
        Me.Hide()
        Restore_Data_Selection.Show()


    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles Button8.Click
        Backup_Database.Show()
        Me.Hide()

    End Sub
End Class