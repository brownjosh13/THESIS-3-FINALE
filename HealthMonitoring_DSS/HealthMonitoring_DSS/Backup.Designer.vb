<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Backup_Database
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Backup_Database))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnRestore = New System.Windows.Forms.Button()
        Me.comboDb = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnBackup = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.txtServer = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PHMS = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnBack)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.PictureBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GroupBox1.Location = New System.Drawing.Point(285, 265)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(896, 570)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Franklin Gothic Demi", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.btnBack.Location = New System.Drawing.Point(24, 477)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(145, 42)
        Me.btnBack.TabIndex = 93
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnRestore)
        Me.GroupBox3.Controls.Add(Me.comboDb)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.btnBackup)
        Me.GroupBox3.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(222, 274)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(513, 233)
        Me.GroupBox3.TabIndex = 20
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Database Information"
        '
        'btnRestore
        '
        Me.btnRestore.Font = New System.Drawing.Font("Franklin Gothic Demi", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestore.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.btnRestore.Location = New System.Drawing.Point(173, 173)
        Me.btnRestore.Name = "btnRestore"
        Me.btnRestore.Size = New System.Drawing.Size(252, 42)
        Me.btnRestore.TabIndex = 19
        Me.btnRestore.Text = "Restore Database"
        Me.btnRestore.UseVisualStyleBackColor = True
        '
        'comboDb
        '
        Me.comboDb.Font = New System.Drawing.Font("Franklin Gothic Demi", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboDb.FormattingEnabled = True
        Me.comboDb.Location = New System.Drawing.Point(173, 71)
        Me.comboDb.Name = "comboDb"
        Me.comboDb.Size = New System.Drawing.Size(252, 32)
        Me.comboDb.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(58, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 24)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Database"
        '
        'btnBackup
        '
        Me.btnBackup.Font = New System.Drawing.Font("Franklin Gothic Demi", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackup.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.btnBackup.Location = New System.Drawing.Point(173, 125)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(252, 42)
        Me.btnBackup.TabIndex = 17
        Me.btnBackup.Text = "Backup Database"
        Me.btnBackup.UseVisualStyleBackColor = True
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(15, 189)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(177, 135)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 92
        Me.PictureBox4.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.btnConnect)
        Me.GroupBox2.Controls.Add(Me.txtServer)
        Me.GroupBox2.Controls.Add(Me.txtPass)
        Me.GroupBox2.Controls.Add(Me.txtUser)
        Me.GroupBox2.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(222, 35)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(513, 233)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Server Information"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(59, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Server"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(59, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "User ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(59, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 24)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Password"
        '
        'btnConnect
        '
        Me.btnConnect.Font = New System.Drawing.Font("Franklin Gothic Demi", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConnect.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.btnConnect.Location = New System.Drawing.Point(173, 154)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(252, 42)
        Me.btnConnect.TabIndex = 17
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'txtServer
        '
        Me.txtServer.Location = New System.Drawing.Point(173, 22)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(252, 29)
        Me.txtServer.TabIndex = 8
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(173, 109)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(252, 29)
        Me.txtPass.TabIndex = 10
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(173, 67)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(252, 29)
        Me.txtUser.TabIndex = 9
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, 533)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(896, 37)
        Me.Panel1.TabIndex = 18
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Location = New System.Drawing.Point(282, 219)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(899, 51)
        Me.Panel2.TabIndex = 21
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Franklin Gothic Medium", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label10.Location = New System.Drawing.Point(308, 6)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(239, 37)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Backup Database"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(137, 116)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(290, 27)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Talaba VII, Bacoor, Cavite"
        '
        'PHMS
        '
        Me.PHMS.AutoSize = True
        Me.PHMS.BackColor = System.Drawing.Color.Transparent
        Me.PHMS.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PHMS.ForeColor = System.Drawing.Color.White
        Me.PHMS.Location = New System.Drawing.Point(26, 75)
        Me.PHMS.Name = "PHMS"
        Me.PHMS.Size = New System.Drawing.Size(565, 41)
        Me.PHMS.TabIndex = 15
        Me.PHMS.Text = "Patient Health Monitoring System"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Backup_Database
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.HealthMonitoring_DSS.My.Resources.Resources.bg2flip
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1384, 923)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PHMS)
        Me.Name = "Backup_Database"
        Me.Text = "Backup Database"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtServer As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnConnect As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents PHMS As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents comboDb As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnBackup As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnRestore As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
