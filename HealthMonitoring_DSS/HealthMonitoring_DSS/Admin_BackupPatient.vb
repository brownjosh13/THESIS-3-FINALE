Imports MySql.Data.MySqlClient

Imports System.Data

Public Class Admin_BackupPatient
    Dim conn As MySqlConnection
    Dim mycmd As MySqlCommand
    Dim reader As MySqlDataReader
    Dim insertString As String
    Dim gender As String

    Private Sub reload()
        Dim str As String
        str = "SELECT * FROM backup_patient"
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost; user=root; password=; database=healthmonitoring"
        Try
            conn.Open()
            Dim search As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            search.Fill(ds, "backup_patient")
            DataGridView1.DataSource = ds.Tables("backup_patient")
            conn.Close()


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub restoredata()

        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost; user=root; password=; database=healthmonitoring; integrated security = true"

        Try
            conn.Open()
            insertString = "Insert into patient(Availability,Fullname,Age,Civil_Status,Address,Status,Note,Room_No,Height,Weight,Temperature,BPM,Date,Timess,PatientRFID,service) VALUES ('" & txtavail.Text & "','" & txtName.Text & "', '" & txtAge.Text & "','" & txtCivilStatus.Text & "', '" & txtAddress.Text & "', '" & ComboBox1.Text & "', '" & txtNote.Text & "', '" & txtRoomNo.Text & "', '" & txtHeight.Text & "','" & txtWeight.Text & "','" & txtTemp.Text & "','" & txtBPM.Text & "','" & comboMonth1.Text & "','" & comboDay1.Text & "', '" & comboYear1.Text & "', '" & txtTime.Text & "', '" & txtRfid.Text & "', '" & comboService.Text & "'  );"
            mycmd = New MySqlCommand(insertString, conn)
            reader = mycmd.ExecuteReader

            reader.Close()
            conn.Close()
            reload()

        Catch ex As Exception

        End Try
    End Sub
    Private Sub Admin_BackupPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer1.Enabled = True
        reload()
        Me.CenterToScreen()
    End Sub

    Private Sub DataGridView1_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseClick
        Dim i As Integer

        i = DataGridView1.CurrentRow.Index
        Try
            txtAvail.Text = DataGridView1.Item(0, i).Value
            txtRfid.Text = DataGridView1.Item(17, i).Value
            txtName.Text = DataGridView1.Item(1, i).Value
            txtAge.Text = DataGridView1.Item(2, i).Value
            txtCivilStatus.Text = DataGridView1.Item(3, i).Value
            txtAddress.Text = DataGridView1.Item(4, i).Value
            ComboBox1.Text = DataGridView1.Item(5, i).Value
            txtNote.Text = DataGridView1.Item(6, i).Value
            txtRoomNo.Text = DataGridView1.Item(7, i).Value
            txtHeight.Text = DataGridView1.Item(8, i).Value
            txtWeight.Text = DataGridView1.Item(9, i).Value
            txtTemp.Text = DataGridView1.Item(10, i).Value
            txtBPM.Text = DataGridView1.Item(11, i).Value
            comboMonth1.Text = DataGridView1.Item(13, i).Value
            comboDay1.Text = DataGridView1.Item(14, i).Value
            comboYear1.Text = DataGridView1.Item(15, i).Value
            txtTime.Text = DataGridView1.Item(16, i).Value
            comboService.Text = DataGridView1.Item(19, i).Value
            lblid.Text = DataGridView1.Item(18, i).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        Admin_BackupStaff.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Admin_Reports.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Admin_Staff.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Admin_Settings.Show()
        Admin_Settings.Button10.PerformClick()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Admin_ViewData.Show()
        Me.Hide()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        reload()
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        Dim str As String


        str = "SELECT * FROM backup_patient where Address like '%" + TextBox7.Text + "%' or Fullname like '%" + TextBox7.Text + "%'or Status like '%" + TextBox7.Text + "%'"
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost; user=root; password=; database=healthmonitoring"
        Try
            conn.Open()
            Dim search As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            search.Fill(ds, "backup_patient")
            DataGridView1.DataSource = ds.Tables("backup_patient")
            conn.Close()


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
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




    Private Sub Button10_MouseHover(sender As Object, e As EventArgs) Handles Button10.MouseHover
        Button10.ForeColor = Color.MidnightBlue
    End Sub

    Private Sub Button10_MouseLeave(sender As Object, e As EventArgs) Handles Button10.MouseLeave
        Button10.ForeColor = Color.FromArgb(21, 67, 96)
    End Sub



    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Me.Hide()
        Login.Show()

    End Sub


    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost; user=root; password=; database=healthmonitoring"

        Dim answer = MsgBox("Do you want to delete this data?", vbExclamation + vbYesNo, "Add Confirm")
        If answer = vbYes Then
            Try

                conn.Open()

                insertString = "delete from backup_patient where Fullname='" & txtName.Text & "'"
                mycmd = New MySqlCommand(insertString, conn)
                reader = mycmd.ExecuteReader

                conn.Close()
                reload()



            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost; user=root; password=; database=healthmonitoring"

        Dim answer = MsgBox("Do you want To restore this data?", vbExclamation + vbYesNo, "Add Confirm")
        If answer = vbYes Then
            Try

                conn.Open()

                insertString = "Insert into patient(Availability,Fullname,Age,Civil_Status,Address,Status,Note,Room_No,Height,Weight,Temperature,BPM,Month,Day,Year,Timess,PatientID,service) VALUES ('" & txtavail.Text & "','" & txtName.Text & "', '" & txtAge.Text & "','" & txtCivilStatus.Text & "', '" & txtAddress.Text & "', '" & ComboBox1.Text & "', '" & txtNote.Text & "', '" & txtRoomNo.Text & "', '" & txtHeight.Text & "','" & txtWeight.Text & "','" & txtTemp.Text & "','" & txtBPM.Text & "','" & comboMonth1.Text & "','" & comboDay1.Text & "', '" & comboYear1.Text & "', '" & txtTime.Text & "', '" & txtRfid.Text & "', '" & comboService.Text & "'  );"
                mycmd = New MySqlCommand(insertString, conn)
                reader = mycmd.ExecuteReader

                reader.Close()


                insertString = "delete from backup_patient where Fullname='" & txtName.Text & "'"
                mycmd = New MySqlCommand(insertString, conn)
                reader = mycmd.ExecuteReader

                conn.Close()
                reload()



            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try
        End If
    End Sub

    Private Sub GroupBox5_Enter(sender As Object, e As EventArgs) Handles GroupBox5.Enter

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