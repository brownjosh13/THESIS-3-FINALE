Public Class Restore_Data_Selection
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Admin_BackupPatient.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Admin_BackupStaff.Show()
    End Sub

    Private Sub Restore_Data_Selection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Admin_Settings.Show()

    End Sub
End Class