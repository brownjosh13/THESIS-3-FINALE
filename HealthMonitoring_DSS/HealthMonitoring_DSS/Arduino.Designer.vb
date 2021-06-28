<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Arduino
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ButtonRegistration = New System.Windows.Forms.Button()
        Me.ButtonUserData = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblID = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.comPort_ComboBox = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Timer_LBL = New System.Windows.Forms.Label()
        Me.connect_BTN = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.ButtonRegistration)
        Me.GroupBox1.Controls.Add(Me.ButtonUserData)
        Me.GroupBox1.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(-1, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(296, 1060)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Side-bar"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.HealthMonitoring_DSS.My.Resources.Resources.nurse_female
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(43, 56)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(181, 164)
        Me.PictureBox2.TabIndex = 48
        Me.PictureBox2.TabStop = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Lucida Console", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(22, 388)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(246, 42)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "Inbox"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.UseWaitCursor = True
        '
        'ButtonRegistration
        '
        Me.ButtonRegistration.Font = New System.Drawing.Font("Lucida Console", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRegistration.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.ButtonRegistration.Location = New System.Drawing.Point(22, 322)
        Me.ButtonRegistration.Name = "ButtonRegistration"
        Me.ButtonRegistration.Size = New System.Drawing.Size(246, 42)
        Me.ButtonRegistration.TabIndex = 19
        Me.ButtonRegistration.Text = "Insert New Patient Data"
        Me.ButtonRegistration.UseVisualStyleBackColor = True
        '
        'ButtonUserData
        '
        Me.ButtonUserData.Font = New System.Drawing.Font("Lucida Console", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonUserData.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.ButtonUserData.Location = New System.Drawing.Point(22, 254)
        Me.ButtonUserData.Name = "ButtonUserData"
        Me.ButtonUserData.Size = New System.Drawing.Size(246, 42)
        Me.ButtonUserData.TabIndex = 19
        Me.ButtonUserData.Text = "User Data"
        Me.ButtonUserData.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(324, 42)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(869, 196)
        Me.DataGridView1.TabIndex = 19
        '
        'TextBox8
        '
        Me.TextBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(141, 362)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(196, 23)
        Me.TextBox8.TabIndex = 37
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = Global.HealthMonitoring_DSS.My.Resources.Resources.CLEAR1
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.Transparent
        Me.Button3.Location = New System.Drawing.Point(200, 17)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(121, 55)
        Me.Button3.TabIndex = 36
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(10, 365)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(81, 18)
        Me.Label13.TabIndex = 35
        Me.Label13.Text = "Patient ID"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Normal", "Sick"})
        Me.ComboBox1.Location = New System.Drawing.Point(141, 116)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(196, 25)
        Me.ComboBox1.TabIndex = 34
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(9, 316)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 18)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Time"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(10, 269)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 18)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(10, 219)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 18)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "BpM"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(9, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 18)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Temperature"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(10, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 18)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Status"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(10, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 18)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Address"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(10, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 18)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Fullname"
        '
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(141, 314)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(196, 23)
        Me.TextBox6.TabIndex = 26
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(141, 266)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(196, 23)
        Me.TextBox5.TabIndex = 25
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(141, 216)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(196, 23)
        Me.TextBox4.TabIndex = 24
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(141, 168)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(196, 23)
        Me.TextBox3.TabIndex = 23
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(141, 69)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(196, 23)
        Me.TextBox2.TabIndex = 22
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(141, 20)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(196, 23)
        Me.TextBox1.TabIndex = 21
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.HealthMonitoring_DSS.My.Resources.Resources.ADD_PATIENT1
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(35, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 55)
        Me.Button1.TabIndex = 20
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lblID
        '
        Me.lblID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblID.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(106, 24)
        Me.lblID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(312, 36)
        Me.lblID.TabIndex = 38
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label8.Location = New System.Drawing.Point(14, 27)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 33)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Card No :"
        '
        'comPort_ComboBox
        '
        Me.comPort_ComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.comPort_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comPort_ComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comPort_ComboBox.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.comPort_ComboBox.FormattingEnabled = True
        Me.comPort_ComboBox.Location = New System.Drawing.Point(167, 37)
        Me.comPort_ComboBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.comPort_ComboBox.Name = "comPort_ComboBox"
        Me.comPort_ComboBox.Size = New System.Drawing.Size(78, 32)
        Me.comPort_ComboBox.TabIndex = 41
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label9.Location = New System.Drawing.Point(51, 44)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 24)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "COM PORT:"
        '
        'Timer_LBL
        '
        Me.Timer_LBL.AutoSize = True
        Me.Timer_LBL.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Timer_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Timer_LBL.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Timer_LBL.Location = New System.Drawing.Point(338, 41)
        Me.Timer_LBL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Timer_LBL.Name = "Timer_LBL"
        Me.Timer_LBL.Size = New System.Drawing.Size(128, 24)
        Me.Timer_LBL.TabIndex = 43
        Me.Timer_LBL.Text = "Device: OFF"
        '
        'connect_BTN
        '
        Me.connect_BTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.connect_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.connect_BTN.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.connect_BTN.Location = New System.Drawing.Point(256, 36)
        Me.connect_BTN.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.connect_BTN.Name = "connect_BTN"
        Me.connect_BTN.Size = New System.Drawing.Size(74, 33)
        Me.connect_BTN.TabIndex = 42
        Me.connect_BTN.Text = "OPEN"
        Me.connect_BTN.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.lblID)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox2.Location = New System.Drawing.Point(36, 78)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(434, 81)
        Me.GroupBox2.TabIndex = 44
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Card ID"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Location = New System.Drawing.Point(329, 266)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(354, 81)
        Me.GroupBox3.TabIndex = 45
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Panel"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TextBox5)
        Me.Panel1.Controls.Add(Me.TextBox6)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.TextBox8)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.TextBox4)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(329, 372)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(354, 394)
        Me.Panel1.TabIndex = 46
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Cornsilk
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.connect_BTN)
        Me.GroupBox4.Controls.Add(Me.Timer_LBL)
        Me.GroupBox4.Controls.Add(Me.GroupBox2)
        Me.GroupBox4.Controls.Add(Me.comPort_ComboBox)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(720, 280)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox4.Size = New System.Drawing.Size(499, 184)
        Me.GroupBox4.TabIndex = 47
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Arduino Port"
        '
        'Arduino
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.HealthMonitoring_DSS.My.Resources.Resources.bg2flip
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1239, 857)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Arduino"
        Me.Text = "Add Patient"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ButtonRegistration As Button
    Friend WithEvents ButtonUserData As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents lblID As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents comPort_ComboBox As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Timer_LBL As Label
    Friend WithEvents connect_BTN As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
