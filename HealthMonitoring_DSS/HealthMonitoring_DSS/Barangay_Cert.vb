Imports MySql.Data.MySqlClient
Imports System.IO.Ports
Imports System.Data
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Drawing.Printing
Public Class Barangay_Cert
    Dim conn As MySqlConnection
    Dim mycmd As MySqlCommand
    Dim reader As MySqlDataReader
    Dim insertString As String
    Private Sub Barangay_Cert_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshing()
        Me.CenterToScreen()
        Timer1.Enabled = True
        Panel3.Hide()
    End Sub
    Private Sub refreshing()
        Dim str As String
        str = "SELECT brgyid,name,civilstatus,citizenship, address, purpose,date from barangaycert ORDER by date DESC"
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

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost; user=root; password=; database=healthmonitoring"

        Try
            conn.Open()

            insertString = "Insert into barangaycert(name,civilstatus,citizenship,address,purpose,date) VALUES ('" & txtname.Text & "','" & ComboBox1.Text & "', '" & txtcitizenship.Text & "', '" & txtaddress.Text & "',   '" & txtpurpose.Text & "',   '" & txtdate.Text & "');"
            mycmd = New MySqlCommand(insertString, conn)
            reader = mycmd.ExecuteReader

            txtname.Clear()
            ComboBox1.Text = ""
            txtcitizenship.Clear()
            txtaddress.Clear()
            txtpurpose.Clear()

            refreshing()


            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Panel3.Hide()

    End Sub
    Private Sub DataGridView1_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseClick
        Dim b As Integer

        b = DataGridView1.CurrentRow.Index

        lblName.Text = DataGridView1.Item(1, b).Value
        lblCivil.Text = DataGridView1.Item(2, b).Value
        lblCitizen.Text = DataGridView1.Item(3, b).Value
        lblAddress.Text = DataGridView1.Item(4, b).Value
        lblPurpose.Text = DataGridView1.Item(5, b).Value
        lblDate.Text = DataGridView1.Item(6, b).Value
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PrintDocument1.DefaultPageSettings.Landscape = True
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Panel3.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Admin_Receipt.Show()
    End Sub

    Private Sub txtdate_TextChanged(sender As Object, e As EventArgs) Handles txtdate.TextChanged

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtdate.Text = Date.Today.ToString("MMMM, dd, yyyy")
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class