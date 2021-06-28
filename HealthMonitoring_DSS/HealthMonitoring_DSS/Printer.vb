Public Class Printer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        End If
        TextBox1.Text = PrintDialog1.PrinterSettings.PrinterName
    End Sub

    Private Sub Printer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Settings.printer
    End Sub

    Private Sub Printer_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.printer = TextBox1.Text
    End Sub
End Class