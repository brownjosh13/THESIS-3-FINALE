Imports MySql.Data.MySqlClient

Imports System.Data

Public Class Admin_BackupStaff
    Dim conn As MySqlConnection
    Dim mycmd As MySqlCommand
    Dim reader As MySqlDataReader
    Dim insertString As String
    Dim gender As String

    Private Sub reload()
        Dim str As String
        str = "SELECT * FROM backup_user"
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost; user=root; password=; database=healthmonitoring"
        Try
            conn.Open()
            Dim search As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            search.Fill(ds, "backup_user")
            DataGridView1.DataSource = ds.Tables("backup_user")
            conn.Close()


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub updaterefresher()
        Dim backup As String
        backup = "select * from accounts"
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost; user=root; password=; database=healthmonitoring; integrated security = true"

        Try
            conn.Open()
            insertString = "Insert into backup_user(Uname,Pword,name,Position,Email,Address) VALUES ('" & txtuser.Text & "', '" & txtpass.Text & "', '" & txtname.Text & "','" & txtpos.Text & "','" & txtems.Text & "','" & txtaddr.Text & "' );"
            mycmd = New MySqlCommand(insertString, conn)
            reader = mycmd.ExecuteReader

            reader.Close()
            conn.Close()
            reload()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Admin_Backup_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer1.Enabled = True
        reload()
        Me.CenterToScreen()
    End Sub

    Private Sub DataGridView1_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseClick
        Dim i As Integer

        i = DataGridView1.CurrentRow.Index
        Try
            txtname.Text = DataGridView1.Item(0, i).Value
            txtuser.Text = DataGridView1.Item(1, i).Value
            txtpass.Text = DataGridView1.Item(2, i).Value
            txtpos.Text = DataGridView1.Item(3, i).Value
            txtems.Text = DataGridView1.Item(4, i).Value
            txtaddr.Text = DataGridView1.Item(6, i).Value

        Catch ex As Exception

        End Try
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost; user=root; password=; database=healthmonitoring"

        Dim answer = MsgBox("Do you want To restore this data?", vbExclamation + vbYesNo, "Add Confirm")
        If answer = vbYes Then
            Try

                conn.Open()

                insertString = "Insert into accounts(Uname,Pword,name,Position,Email,Address) VALUES ('" & txtuser.Text & "',  '" & txtpass.Text & "', '" & txtname.Text & "', '" & txtpos.Text & "', '" & txtems.Text & "', '" & txtaddr.Text & "'  );"
                mycmd = New MySqlCommand(insertString, conn)
                reader = mycmd.ExecuteReader

                reader.Close()


                insertString = "delete from backup_user where name='" & txtname.Text & "'"
                mycmd = New MySqlCommand(insertString, conn)
                reader = mycmd.ExecuteReader

                conn.Close()
                reload()



            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try
        End If

    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Admin_ViewData.Show()
        Me.Hide()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Admin_Settings.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Admin_Staff.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Admin_Reports.Show()
        Me.Hide()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)
        Admin_BackupPatient.Show()
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        Dim str As String


        str = "SELECT * FROM user where staffID like '%" + TextBox6.Text + "%' or Username like '%" + TextBox6.Text + "%'or Position like '%" + TextBox6.Text + "%' or Name like '%" + TextBox6.Text + "%'"
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost; user=root; password=; database=healthmonitoring"
        Try
            conn.Open()
            Dim search As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            search.Fill(ds, "user")
            DataGridView1.DataSource = ds.Tables("user")
            conn.Close()


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        reload()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost; user=root; password=; database=healthmonitoring"

        Dim answer = MsgBox("Do you want to delete this data?", vbExclamation + vbYesNo, "Add Confirm")
        If answer = vbYes Then
            Try

                conn.Open()


                insertString = "delete from backup_user where name='" & txtname.Text & "'"
                mycmd = New MySqlCommand(insertString, conn)
                reader = mycmd.ExecuteReader


                conn.Close()

                reload()

                txtname.Clear()
                txtuser.Clear()
                txtpass.Clear()
                txtpass.Clear()
                txtpos.Clear()
                txtems.Clear()
                txtaddr.Clear()



            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Admin_Inbox.Show()
        Me.Hide()

    End Sub



    Private Sub Button5_MouseHover(sender As Object, e As EventArgs) Handles Button5.MouseHover
        Button5.ForeColor = Color.MidnightBlue
    End Sub
    Private Sub Button5_MouseLeave(sender As Object, e As EventArgs) Handles Button5.MouseLeave
        Button5.ForeColor = Color.FromArgb(21, 67, 96)
    End Sub

    Private Sub Button2_MouseHover(sender As Object, e As EventArgs) Handles Button2.MouseHover
        Button2.ForeColor = Color.MidnightBlue
    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Button2.ForeColor = Color.FromArgb(21, 67, 96)
    End Sub



    Private Sub Button11_MouseLeave(sender As Object, e As EventArgs) Handles Button11.MouseLeave
        Button11.ForeColor = Color.FromArgb(21, 67, 96)
    End Sub

    Private Sub Button11_MouseHover(sender As Object, e As EventArgs) Handles Button11.MouseHover
        Button11.ForeColor = Color.MidnightBlue
    End Sub



    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Me.Hide()
        Login.Show()

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
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