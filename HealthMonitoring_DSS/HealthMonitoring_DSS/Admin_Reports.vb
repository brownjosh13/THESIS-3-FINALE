Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Drawing.Printing
Imports System.Data

Public Class Admin_Reports

    Dim conn As MySqlConnection
    Dim mycmd As MySqlCommand
    Dim reader As MySqlDataReader
    Dim countString As String


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Admin_Staff.Show()
        Me.Hide()

    End Sub

    Private Sub ButtonUserData_Click(sender As Object, e As EventArgs) Handles ButtonUserData.Click
        Admin_Settings.Show()
        Me.Hide()

    End Sub

    Private Sub ButtonConnection_Click(sender As Object, e As EventArgs)
        Admin_ViewData.Show()
        Me.Hide()

    End Sub

    Private Sub Admin_Reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ButtonReports.Enabled = False
        Me.CenterToScreen()
        Panelnext.Hide()
        GroupBox1.Show()

        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost; user=root; password=; database=healthmonitoring"

        Try

            Dim command As New MySqlCommand("SELECT COUNT(id) from patient", conn)
            Dim command1 As New MySqlCommand("SELECT count(kidID) from kidsvaccination", conn)
            Dim command2 As New MySqlCommand("SELECT count(Status) from patient WHERE Status = 'Normal'", conn)
            Dim command3 As New MySqlCommand("SELECT count(Availability) from patient WHERE Availability = 'Dismiss'", conn)
            Dim commandadmit As New MySqlCommand("SELECT count(Availability) from patient WHERE Availability = 'Monitoring' or Availability='Admitted'", conn)
            Dim commandcount1 As New MySqlCommand("SELECT count(Year)from patient where Year = '2015'", conn)
            Dim commandcount2 As New MySqlCommand("SELECT count(Year)from patient where Year = '2016'", conn)
            Dim commandcount3 As New MySqlCommand("SELECT count(Year)from patient where Year = '2017'", conn)
            Dim commandcount4 As New MySqlCommand("SELECT count(Year)from patient where Year = '2018'", conn)
            Dim commandcount5 As New MySqlCommand("SELECT count(Year)from patient where Year = '2019'", conn)
            Dim commandcount6 As New MySqlCommand("SELECT count(Year)from patient where Year = '2020'", conn)
            Dim commandcount7 As New MySqlCommand("SELECT count(Year)from patient where Year = '2021'", conn)
            Dim commandbcg As New MySqlCommand("SELECT COUNT(kidID) from kidsvaccination where typeofvaccine='BCG'", conn)
            Dim commandbcg1 As New MySqlCommand("SELECT COUNT(kidID) from kidsvaccination where typeofvaccine='HEPATITIS B'", conn)
            Dim commandbcg2 As New MySqlCommand("SELECT COUNT(kidID) from kidsvaccination where typeofvaccine='DPT-Hep B-HiB'", conn)
            Dim commandbcg3 As New MySqlCommand("SELECT COUNT(kidID) from kidsvaccination where typeofvaccine='OPV'", conn)
            Dim commandbcg4 As New MySqlCommand("SELECT COUNT(kidID) from kidsvaccination where typeofvaccine='PCV'", conn)
            Dim commandbcg5 As New MySqlCommand("SELECT COUNT(kidID) from kidsvaccination where typeofvaccine='MMR'", conn)
            Dim commandcountkid As New MySqlCommand("SELECT count(Year)from kidsvaccination where Year = '2015'", conn)
            Dim commandcountkid1 As New MySqlCommand("SELECT count(Year)from kidsvaccination where Year = '2016'", conn)
            Dim commandcountkid2 As New MySqlCommand("SELECT count(Year)from kidsvaccination where Year = '2017'", conn)
            Dim commandcountkid3 As New MySqlCommand("SELECT count(Year)from kidsvaccination where Year = '2018'", conn)
            Dim commandcountkid4 As New MySqlCommand("SELECT count(Year)from kidsvaccination where Year = '2019'", conn)
            Dim commandcountkid5 As New MySqlCommand("SELECT count(Year)from kidsvaccination where Year = '2020'", conn)
            Dim commandcountkid6 As New MySqlCommand("SELECT count(Year)from kidsvaccination where Year = '2021'", conn)
            Dim commandnext1 As New MySqlCommand("SELECT COUNT(kidID) from kidsvaccination where Month='01'", conn)
            Dim commandnext2 As New MySqlCommand("SELECT COUNT(kidID) from kidsvaccination where Month='02'", conn)
            Dim commandnext3 As New MySqlCommand("SELECT COUNT(kidID) from kidsvaccination where Month='03'", conn)
            Dim commandnext4 As New MySqlCommand("SELECT COUNT(kidID) from kidsvaccination where Month='04'", conn)
            Dim commandnext5 As New MySqlCommand("SELECT COUNT(kidID) from kidsvaccination where Month='05'", conn)
            Dim commandnext6 As New MySqlCommand("SELECT COUNT(kidID) from kidsvaccination where Month='06'", conn)
            Dim commandnext7 As New MySqlCommand("SELECT COUNT(kidID) from kidsvaccination where Month='07'", conn)
            Dim commandnext8 As New MySqlCommand("SELECT COUNT(kidID) from kidsvaccination where Month='08'", conn)
            Dim commandnext9 As New MySqlCommand("SELECT COUNT(kidID) from kidsvaccination where Month='09'", conn)
            Dim commandnext10 As New MySqlCommand("SELECT COUNT(kidID) from kidsvaccination where Month='10'", conn)
            Dim commandnext11 As New MySqlCommand("SELECT COUNT(kidID) from kidsvaccination where Month='11'", conn)
            Dim commandnext12 As New MySqlCommand("SELECT COUNT(kidID) from kidsvaccination where Month='12'", conn)
            conn.Open()

            lblcountnormal.Text = command.ExecuteScalar().ToString
            lblcounttods.Text = command1.ExecuteScalar().ToString
            lblcountcheckup.Text = command2.ExecuteScalar().ToString
            lblcountadmit.Text = commandadmit.ExecuteScalar().ToString
            lbl2015.Text = commandcount1.ExecuteScalar().ToString
            lbl2016.Text = commandcount2.ExecuteScalar().ToString
            lbl2017.Text = commandcount3.ExecuteScalar().ToString
            lbl2018.Text = commandcount4.ExecuteScalar().ToString
            lbl2019.Text = commandcount5.ExecuteScalar().ToString
            lbl2020.Text = commandcount6.ExecuteScalar().ToString
            lbl2021.Text = commandcount7.ExecuteScalar().ToString
            lblcountdismiss.Text = command3.ExecuteScalar().ToString
            lblbcg.Text = commandbcg.ExecuteScalar().ToString
            lblhepa.Text = commandbcg1.ExecuteScalar().ToString
            lbldpt.Text = commandbcg2.ExecuteScalar().ToString
            lblopv.Text = commandbcg3.ExecuteScalar().ToString
            lblpcv.Text = commandbcg4.ExecuteScalar().ToString
            lblmmr.Text = commandbcg5.ExecuteScalar().ToString
            lbl20151.Text = commandcountkid.ExecuteScalar().ToString
            lbl20161.Text = commandcountkid1.ExecuteScalar().ToString
            lbl20171.Text = commandcountkid2.ExecuteScalar().ToString
            lbl20181.Text = commandcountkid3.ExecuteScalar().ToString
            lbl20191.Text = commandcountkid4.ExecuteScalar().ToString
            lbl20201.Text = commandcountkid5.ExecuteScalar().ToString
            lbl20211.Text = commandcountkid6.ExecuteScalar().ToString

            lblnextjan.Text = commandnext1.ExecuteScalar().ToString
            lblnextfeb.Text = commandnext2.ExecuteScalar().ToString
            lblnextmarch.Text = commandnext3.ExecuteScalar().ToString
            lblnextapril.Text = commandnext4.ExecuteScalar().ToString
            lblnextmay.Text = commandnext5.ExecuteScalar().ToString
            lblnextjune.Text = commandnext6.ExecuteScalar().ToString
            lblnextjuly.Text = commandnext7.ExecuteScalar().ToString
            lblnextaug.Text = commandnext8.ExecuteScalar().ToString
            lblnextsept.Text = commandnext9.ExecuteScalar().ToString
            lblnextoct.Text = commandnext10.ExecuteScalar().ToString
            lblnextnov.Text = commandnext11.ExecuteScalar().ToString
            lblnextdec.Text = commandnext12.ExecuteScalar().ToString
            conn.Close()
        Catch ex As Exception

        End Try


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        Admin_BackupStaff.Show()
        Me.Hide()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)
        Admin_BackupPatient.Show()
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Admin_Inbox.Show()
        Me.Hide()
    End Sub


    Private Sub Chart1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PrintDocument2_PrintPage(sender As Object, e As Printing.PrintPageEventArgs)

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblcounttods_Click(sender As Object, e As EventArgs) Handles lblcounttods.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GroupBox1.Hide()
        Panelnext.Show()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Panelnext.Hide()
        GroupBox1.Show()
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