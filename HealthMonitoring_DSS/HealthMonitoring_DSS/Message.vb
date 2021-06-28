Imports MySql.Data.MySqlClient
Imports System.Data

Public Class Message

    Dim conn As MySqlConnection
    Dim mycmd As MySqlCommand
    Dim reader As MySqlDataReader
    Dim insertString As String


    Private Sub Message_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = Date.Now.ToString("MM-dd-yyyy")
        TextBox5.Text = Format(DateTimePicker1.Value, "hh:mm tt")

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost; user=root; password=; database=healthmonitoring"

        Try
            conn.Open()
            insertString = "Insert into tbl_message(Receive,Sender,date,time,subject,message) VALUES ('" & TextBox3.Text & "', '" & TextBox1.Text & "' , '" & DateTimePicker1.Value & "' , '" & TextBox5.Text & "', '" & TextBox2.Text & "','" & TextBox4.Text & "');"
            mycmd = New MySqlCommand(insertString, conn)
            reader = mycmd.ExecuteReader

            conn.Close()
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub
End Class