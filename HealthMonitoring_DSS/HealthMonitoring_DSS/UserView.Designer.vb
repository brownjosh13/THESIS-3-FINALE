<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserView
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.comPort_ComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer_LBL = New System.Windows.Forms.Label()
        Me.connect_BTN = New System.Windows.Forms.Button()
        Me.lblID = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(-3, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(296, 1060)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Side-bar"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Lucida Console", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(23, 410)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(246, 42)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Inbox"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Lucida Console", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Button5.Location = New System.Drawing.Point(23, 335)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(246, 42)
        Me.Button5.TabIndex = 20
        Me.Button5.Text = "Insert New Patient Data"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Lucida Console", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Button4.Location = New System.Drawing.Point(23, 259)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(246, 42)
        Me.Button4.TabIndex = 21
        Me.Button4.Text = "User Data"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.HealthMonitoring_DSS.My.Resources.Resources.nurse_female
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(49, 53)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(181, 164)
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label13.Location = New System.Drawing.Point(364, 204)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(90, 20)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "Patient ID"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(458, 201)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(161, 24)
        Me.TextBox1.TabIndex = 27
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Lucida Console", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.DarkBlue
        Me.Button3.Location = New System.Drawing.Point(629, 196)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(137, 35)
        Me.Button3.TabIndex = 28
        Me.Button3.Text = "Search"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'comPort_ComboBox
        '
        Me.comPort_ComboBox.BackColor = System.Drawing.Color.White
        Me.comPort_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comPort_ComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comPort_ComboBox.FormattingEnabled = True
        Me.comPort_ComboBox.Location = New System.Drawing.Point(130, 32)
        Me.comPort_ComboBox.Margin = New System.Windows.Forms.Padding(2)
        Me.comPort_ComboBox.Name = "comPort_ComboBox"
        Me.comPort_ComboBox.Size = New System.Drawing.Size(78, 32)
        Me.comPort_ComboBox.TabIndex = 45
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 24)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "COM PORT:"
        '
        'Timer_LBL
        '
        Me.Timer_LBL.AutoSize = True
        Me.Timer_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Timer_LBL.Location = New System.Drawing.Point(293, 35)
        Me.Timer_LBL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Timer_LBL.Name = "Timer_LBL"
        Me.Timer_LBL.Size = New System.Drawing.Size(128, 24)
        Me.Timer_LBL.TabIndex = 47
        Me.Timer_LBL.Text = "Device: OFF"
        '
        'connect_BTN
        '
        Me.connect_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.connect_BTN.ForeColor = System.Drawing.SystemColors.Desktop
        Me.connect_BTN.Location = New System.Drawing.Point(215, 31)
        Me.connect_BTN.Margin = New System.Windows.Forms.Padding(2)
        Me.connect_BTN.Name = "connect_BTN"
        Me.connect_BTN.Size = New System.Drawing.Size(74, 33)
        Me.connect_BTN.TabIndex = 46
        Me.connect_BTN.Text = "OPEN"
        Me.connect_BTN.UseVisualStyleBackColor = True
        '
        'lblID
        '
        Me.lblID.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblID.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblID.Location = New System.Drawing.Point(101, 82)
        Me.lblID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(312, 36)
        Me.lblID.TabIndex = 48
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(16, 82)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(81, 33)
        Me.Label17.TabIndex = 49
        Me.Label17.Text = "Card No :"
        '
        'Timer1
        '
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(311, 259)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(815, 338)
        Me.DataGridView1.TabIndex = 50
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.DarkBlue
        Me.GroupBox3.Controls.Add(Me.connect_BTN)
        Me.GroupBox3.Controls.Add(Me.Timer_LBL)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.comPort_ComboBox)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.lblID)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Moccasin
        Me.GroupBox3.Location = New System.Drawing.Point(326, 60)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(440, 131)
        Me.GroupBox3.TabIndex = 70
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Arduino Port"
        '
        'UserView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.HealthMonitoring_DSS.My.Resources.Resources.bg2flip
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1155, 687)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "UserView"
        Me.Text = "View Patient Data"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents comPort_ComboBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer_LBL As Label
    Friend WithEvents connect_BTN As Button
    Friend WithEvents lblID As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox3 As GroupBox
End Class
