Imports MySql.Data.MySqlClient

Imports System.Data.SqlClient



Public Class Admin_Staff

    Dim conn As MySqlConnection
    Dim mycmd As MySqlCommand
    Dim reader As MySqlDataReader
    Dim insertString As String
    Dim gender As String



    Private Sub reload()
        Dim backup As String
        backup = "select * from patient"
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost; user=root; password=; database=healthmonitoring; integrated security = true"

        Try
            conn.Open()
            insertString = insertString = "Insert into backup_user(Uname,Pword,name,position,email,address) VALUES ('" & txtuser.Text & "', '" & txtpass.Text & "', '" & txtname.Text & "', '" & txtposition.Text & "', '" & txtemail.Text & "', '" & txtaddress.Text & "') ;"
            mycmd = New MySqlCommand(insertString, conn)
            reader = mycmd.ExecuteReader

            reader.Close()
            conn.Close()
            charicewoop()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub charicewoop()
        Dim str As String
        str = "SELECT * FROM accounts"
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost; user=root; password=; database=healthmonitoring"
        Try
            conn.Open()
            Dim search As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            search.Fill(ds, "accounts")
            DataGridView1.DataSource = ds.Tables("accounts")
            conn.Close()


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try


    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Button2.Enabled = False
        charicewoop()
        Me.CenterToScreen()

        lblid.Hide()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost; user=root; password=; database=healthmonitoring"


        Try
            conn.Open()

            insertString = "Insert into accounts(Uname,Pword,name,Position,Email,Address) VALUES ('" & txtuser.Text & "', '" & txtpass.Text & "', '" & txtname.Text & "','" & txtposition.Text & "','" & txtemail.Text & "','" & txtaddress.Text & "');"
            mycmd = New MySqlCommand(insertString, conn)
            reader = mycmd.ExecuteReader


            conn.Close()
            charicewoop()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click



        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost; user=root; password=; database=healthmonitoring"

        Try
            conn.Open()

            insertString = "update accounts set Uname='" & txtuser.Text & "',Pword='" & txtpass.Text & "',name='" & txtname.Text & "',Position='" & txtposition.Text & "',Email='" & txtemail.Text & "', Address='" & txtaddress.Text & "'  where accountid= '" & lblid.Text & "'"
            mycmd = New MySqlCommand(insertString, conn)
            reader = mycmd.ExecuteReader


            conn.Close()
            charicewoop()


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost; user=root; password=; database=healthmonitoring"

        Me.DataGridView1.Refresh()
        Try

            conn.Open()

            insertString = "Insert into backup_user(Uname,Pword,name,position,email,address) VALUES ('" & txtuser.Text & "', '" & txtpass.Text & "', '" & txtname.Text & "', '" & txtposition.Text & "', '" & txtemail.Text & "', '" & txtaddress.Text & "') ;"
            mycmd = New MySqlCommand(insertString, conn)
            reader = mycmd.ExecuteReader

            reader.Close()


            insertString = "delete from accounts where name='" & txtname.Text & "'"
            mycmd = New MySqlCommand(insertString, conn)
            reader = mycmd.ExecuteReader

            conn.Close()
            reload()
            charicewoop()



            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try

    End Sub
    Private Sub updaterefresh()

        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost; user=root; password=; database=healthmonitoring; integrated security = true"

        Try
            conn.Open()
            insertString = "Insert into backup_user(Uname,Pword,name,Position,Email,Address) VALUES ('" & txtuser.Text & "', '" & txtpass.Text & "', '" & txtname.Text & "','" & txtposition.Text & "','" & txtemail.Text & "','" & txtaddress.Text & "' );"
            mycmd = New MySqlCommand(insertString, conn)
            reader = mycmd.ExecuteReader

            reader.Close()
            conn.Close()
            reload()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        txtname.Clear()
        txtuser.Clear()
        txtpass.Clear()
        txtposition.Clear()
        txtemail.Clear()

        txtaddress.Clear()


    End Sub

    Private Sub DataGridView1_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseClick
        Dim i As Integer

        i = DataGridView1.CurrentRow.Index
        Try
            lblid.Text = DataGridView1.Item(3, i).Value
            txtname.Text = DataGridView1.Item(2, i).Value
            txtuser.Text = DataGridView1.Item(0, i).Value
            txtpass.Text = DataGridView1.Item(1, i).Value
            txtposition.Text = DataGridView1.Item(4, i).Value
            txtemail.Text = DataGridView1.Item(5, i).Value
            txtaddress.Text = DataGridView1.Item(6, i).Value

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub ButtonConnection_Click(sender As Object, e As EventArgs)
        Admin_ViewData.Show()
        Me.Hide()

    End Sub

    Private Sub ButtonUserData_Click(sender As Object, e As EventArgs) Handles ButtonUserData.Click
        Admin_Settings.Show()
        Me.Hide()

    End Sub

    Private Sub ButtonRegistration_Click(sender As Object, e As EventArgs)
        Admin_Reports.Show()
        Me.Hide()


    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        Dim str As String


        str = "SELECT * FROM accounts where accountid like '%" + TextBox6.Text + "%' or Username like '%" + TextBox6.Text + "%'or Position like '%" + TextBox6.Text + "%'"
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost; user=root; password=; database=healthmonitoring"
        Try
            conn.Open()
            Dim search As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            search.Fill(ds, "accounts")
            DataGridView1.DataSource = ds.Tables("accounts")
            conn.Close()


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub



    Private Sub Button6_Click(sender As Object, e As EventArgs)
        Admin_BackupStaff.Show()
        Admin_BackupStaff.Button9.PerformClick()
        Me.Hide()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)
        Admin_BackupPatient.Show()
        Me.Close()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        charicewoop()

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Admin_Inbox.Show()
        Me.Hide()
    End Sub

    Private Sub Label28_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Admin_Reports.Show()
        Me.Hide()

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles txtaddress.TextChanged

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