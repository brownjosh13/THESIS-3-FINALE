
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Drawing.Printing
Imports MySql.Data.MySqlClient
Imports System.IO.Ports
Imports System.Data

Public Class Admin_Receipt


    Dim conn As MySqlConnection
    Dim mycmd As MySqlCommand
    Dim reader As MySqlDataReader
    Dim insertString As String
    Dim receivedData As String = ""
    Dim comPORT As String
    Private Sub barronlangmalakas()
        Dim str As String
        str = "SELECT * FROM patient "
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


    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage


        Dim dm As New Bitmap(Me.Panel1.Width, Me.Panel1.Height)
        Panel1.DrawToBitmap(dm, New Rectangle(5, 5, Me.Panel1.Width, Me.Panel1.Height))
        e.Graphics.DrawImage(dm, 0, 0)

        Dim aPS As New PageSetupDialog
        aPS.Document = PrintDocument1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        PrintDialog1.Document = PrintDocument1
        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PrintDocument1.DefaultPageSettings.Landscape = True
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PageSetupDialog1.Document = PrintDocument1
        PageSetupDialog1.Document.DefaultPageSettings.Color = False
        PageSetupDialog1.ShowDialog()

    End Sub

    Private Sub Admin_Receipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button12.Enabled = False


        barronlangmalakas()
        Me.CenterToScreen()

        Timer1.Enabled = False
        txtDateToday.Text = Date.Today.ToString("M-dd-yyyy")
        Panel4.Hide()



    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Panel1.Visible = False

        Panel2.Visible = False
    End Sub

    Private Sub Panel11_Paint(sender As Object, e As PaintEventArgs) 

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs)

        Panel1.Visible = True
        Panel2.Visible = True
    End Sub



    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim str As String


        str = "SELECT * FROM patient where PatientID like '%" + txtSearch.Text + "%' or Fullname like '%" + txtSearch.Text + "%'or service like '%" + txtSearch.Text + "%'"
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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


    End Sub

    Private Sub DataGridView1_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseClick
        Dim i As Integer

        i = DataGridView1.CurrentRow.Index
        Try
            lblname1.Text = DataGridView1.Item(1, i).Value
            lblage1.Text = DataGridView1.Item(2, i).Value
            lblcivilstatus1.Text = DataGridView1.Item(3, i).Value
            lblbrgy1.Text = DataGridView1.Item(4, i).Value
            lblroom1.Text = DataGridView1.Item(8, i).Value
            lblcondition1.Text = DataGridView1.Item(5, i).Value
            lblheight1.Text = DataGridView1.Item(9, i).Value
            lblweight1.Text = DataGridView1.Item(10, i).Value
            lbltemp1.Text = DataGridView1.Item(11, i).Value
            lblbpm1.Text = DataGridView1.Item(12, i).Value
            lblservice1.Text = DataGridView1.Item(19, i).Value
            lbladmit1.Text = DataGridView1.Item(22, i).Value
            lblRFID1.Text = DataGridView1.Item(18, i).Value
            lblreceipt1.Text = DataGridView1.Item(21, i).Value
            txtprimaryid.Text = DataGridView1.Item(23, i).Value



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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Admin_Inbox.Show()
        Me.Hide()

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)
        Admin_BackupStaff.Show()
        Me.Hide()

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)
        Admin_BackupPatient.Show()
        Me.Hide()

    End Sub



    Private Sub GroupBox5_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Print.Show()
        Me.Hide()

    End Sub

    Private Sub Button13_Click_1(sender As Object, e As EventArgs) Handles Button13.Click
        Me.Hide()
        Barangay_Cert.Show()
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs)
        Panel1.Hide()
        Panel4.Show()

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Panel4.Hide()


    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost; user=root; password=; database=healthmonitoring"

        Try
            conn.Open()

            insertString = "update patient set receiptid ='" & txtReceipt.Text & "', admission='" & DateTimePicker1.Text & "' WHERE id = '" & txtprimaryid.Text & "'"
            mycmd = New MySqlCommand(insertString, conn)
            reader = mycmd.ExecuteReader

            MessageBox.Show("Receipt updated!")
            conn.Close()
            barronlangmalakas()
            Me.DataGridView1.Refresh()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs)


    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label40_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label24_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label39_Click(sender As Object, e As EventArgs) Handles lblroom1.Click

    End Sub

    Private Sub Label53_Click(sender As Object, e As EventArgs) Handles lbltemp1.Click

    End Sub

    Private Sub Button5_Click_2(sender As Object, e As EventArgs) Handles Button5.Click
        Panel4.Show()



    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click

    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
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