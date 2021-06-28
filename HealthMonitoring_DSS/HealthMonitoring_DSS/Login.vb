Imports MySql.Data.MySqlClient

Imports System.Data
Public Class Login
    Dim conn As MySqlConnection
    Dim mycmd As MySqlCommand
    Dim reader As MySqlDataReader
    Dim insertString As String
    Dim count As Integer
    Dim checkUsername As String
    Dim username As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost; user=root; password=; database=healthmonitoring"


        Try
            conn.Open()
            Dim query As String
            query = "select * from accounts where Uname='" & TextBox1.Text & "' and Pword='" & TextBox2.Text & "'"
            mycmd = New MySqlCommand(query, conn)
            reader = mycmd.ExecuteReader
            count = 0
            While reader.Read
                count = count + 1
            End While

            If count = 1 Then

                UserView.Show()
                Me.Hide()
            ElseIf count > 1 Then
                MessageBox.Show("Duplicated data")
            Else
                reader.Close()
                Dim mycmd1 As MySqlCommand
                Dim query1 As String
                Dim reader1 As MySqlDataReader
                query1 = "select * from admin where Uname='" & TextBox1.Text & "' and Pword='" & TextBox2.Text & "'"
                mycmd1 = New MySqlCommand(query1, conn)
                reader1 = mycmd1.ExecuteReader
                count = 0

                While reader1.Read
                    count = count + 1
                End While
                If count = 1 Then

                    Admin_Settings.Show()
                    Me.Hide()
                ElseIf count > 1 Then
                    MessageBox.Show("Duplicated data")
                End If
            End If
            conn.Close()



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Backup_Database.Show()
        Me.Hide()

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) 
        If Not username.Length > 5 Then
            Label1.Text = "The username must be more than 5 charcharacters"
            TextBox1.Clear()
        Else
            Label1.Text = "Username accepted"
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub PHMS_Click(sender As Object, e As EventArgs) Handles PHMS.Click, Label3.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Admin_ViewData.Show()

    End Sub
End Class
