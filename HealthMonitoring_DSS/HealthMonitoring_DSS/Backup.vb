Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data
Public Class Backup_Database
    Dim SqlConnection As MySqlConnection
    Dim cmd As String
    Dim dtseCt As Integer
    Dim da As MySqlDataAdapter
    Dim dt As New DataTable

    Private Sub Backup_Database_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub koneksyon()
        Try

            SqlConnection = New MySqlConnection("Server=" & txtServer.Text & ";user Id=" & txtUser.Text & ";password=" & txtPass.Text & ";")
            If SqlConnection.State = ConnectionState.Closed Then

                SqlConnection.Open()
            End If


        Catch ex As Exception
            MsgBox("Connection failed.")
        End Try
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        Try

            koneksyon()

            cmd = "SELECT DISTINCT TABLE_SCHEMA FROM information_schema.TABLES"
            da = New MySqlDataAdapter(cmd, SqlConnection)
            da.Fill(dt)
            dtseCt = 0

            comboDb.Enabled = True
            comboDb.Items.Clear()
            comboDb.Items.Add(" == Select Database == ")

            While dtseCt < dt.Rows.Count

                comboDb.Items.Add(dt.Rows(dtseCt)(0).ToString())
                dtseCt = dtseCt + 1
            End While

            comboDb.SelectedIndex = 0
            btnConnect.Enabled = False
            btnBackup.Enabled = True
            btnRestore.Enabled = True

            SqlConnection.Close()
            dt.Dispose()
            da.Dispose()

        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnBackup_Click(sender As Object, ByVal e As EventArgs) Handles btnBackup.Click
        Dim dbfile As String
        Try
            SaveFileDialog1.Filter = "SQL Dump File(*.sql)|*.sql|All files(*.*)|*.*"
            SaveFileDialog1.FileName = "Database Backup" + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss" + ".sql")

            If SaveFileDialog1.ShowDialog = DialogResult.OK Then

                koneksyon()
                dbfile = SaveFileDialog1.FileName
                Dim backupprocess As New Process
                backupprocess.StartInfo.FileName = "cmd.exe"
                backupprocess.StartInfo.UseShellExecute = False
                backupprocess.StartInfo.WorkingDirectory = "C:\xampp\mysql\bin\"
                backupprocess.StartInfo.RedirectStandardInput = True
                backupprocess.StartInfo.RedirectStandardOutput = True
                backupprocess.Start()

                Dim backupstream As StreamWriter = backupprocess.StandardInput
                Dim myStreamReader As StreamReader = backupprocess.StandardOutput
                backupstream.WriteLine("mysqldump --user=" & txtUser.Text & " --password=" & txtPass.Text & " -h  " & txtServer.Text & " " & comboDb.Text & " > """ + dbfile + """")

                backupstream.Close()
                backupprocess.WaitForExit()
                backupprocess.Close()
                SqlConnection.Close()

                MsgBox("Backup your MySQL database created successfully!", MsgBoxStyle.Information, "Backup MySQL Database")

            End If
        Catch ex As Exception
            MsgBox("Nothing to do...")
        End Try
    End Sub
    Private Sub btnRestore_Click(sender As Object, e As EventArgs) Handles btnRestore.Click
        Dim dbfile As String
        Try
            OpenFileDialog1.Filter = "SQL Dump File(*.sql)|*.sql|All files(*.*)|*.*"


            If SaveFileDialog1.ShowDialog = DialogResult.OK Then

                koneksyon()
                dbfile = OpenFileDialog1.FileName
                Dim backupprocess As New Process
                backupprocess.StartInfo.FileName = "cmd.exe"
                backupprocess.StartInfo.UseShellExecute = False
                backupprocess.StartInfo.WorkingDirectory = "C:\xampp\mysql\bin\"
                backupprocess.StartInfo.RedirectStandardInput = True
                backupprocess.StartInfo.RedirectStandardOutput = True
                backupprocess.Start()

                Dim backupstream As StreamWriter = backupprocess.StandardInput
                Dim myStreamReader As StreamReader = backupprocess.StandardOutput
                backupstream.WriteLine("mysqldump --user=" & txtUser.Text & " --password=" & txtPass.Text & " -h  " & txtServer.Text & " " & comboDb.Text & " > """ + dbfile + """")

                backupstream.Close()
                backupprocess.WaitForExit()
                backupprocess.Close()
                SqlConnection.Close()

                MsgBox("Restore database succesfully!", MsgBoxStyle.Information, "Restore MySQL Database")

            End If
        Catch ex As Exception
            MsgBox("Nothing to do...")
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Admin_Settings.Show()
        Me.Hide()

    End Sub
End Class