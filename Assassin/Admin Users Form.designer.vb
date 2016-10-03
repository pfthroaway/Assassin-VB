<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminUsers
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
        Me.lstUsers = New System.Windows.Forms.ListBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblLevel = New System.Windows.Forms.Label()
        Me.lblMaxEnd = New System.Windows.Forms.Label()
        Me.lblCurrEnd = New System.Windows.Forms.Label()
        Me.lblSkillPts = New System.Windows.Forms.Label()
        Me.lblExp = New System.Windows.Forms.Label()
        Me.lblAlive = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblHench1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblHench2 = New System.Windows.Forms.Label()
        Me.lblHench3 = New System.Windows.Forms.Label()
        Me.lblHench4 = New System.Windows.Forms.Label()
        Me.lblHench5 = New System.Windows.Forms.Label()
        Me.txtSkillPts = New System.Windows.Forms.TextBox()
        Me.txtGoldBank = New System.Windows.Forms.TextBox()
        Me.txtGoldLoan = New System.Windows.Forms.TextBox()
        Me.txtCurrEnd = New System.Windows.Forms.TextBox()
        Me.txtMaxEnd = New System.Windows.Forms.TextBox()
        Me.txtExp = New System.Windows.Forms.TextBox()
        Me.txtLevel = New System.Windows.Forms.TextBox()
        Me.txtTwoH = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtGoldHand = New System.Windows.Forms.TextBox()
        Me.txtHeavy = New System.Windows.Forms.TextBox()
        Me.txtLight = New System.Windows.Forms.TextBox()
        Me.txtBlocking = New System.Windows.Forms.TextBox()
        Me.txtHench5 = New System.Windows.Forms.TextBox()
        Me.txtHench4 = New System.Windows.Forms.TextBox()
        Me.txtHench3 = New System.Windows.Forms.TextBox()
        Me.txtHench2 = New System.Windows.Forms.TextBox()
        Me.txtHench1 = New System.Windows.Forms.TextBox()
        Me.txtStealth = New System.Windows.Forms.TextBox()
        Me.txtSlipping = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnNewUser = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.txtChangePass = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtLockpicks = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtConfPass = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtHunger = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtThirst = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.chkAlive = New System.Windows.Forms.CheckBox()
        Me.cmbCurrWeapon = New System.Windows.Forms.ComboBox()
        Me.cmbLoc = New System.Windows.Forms.ComboBox()
        Me.cmbLightWeapon = New System.Windows.Forms.ComboBox()
        Me.cmbHeavyWeapon = New System.Windows.Forms.ComboBox()
        Me.cmbTwoHWeapon = New System.Windows.Forms.ComboBox()
        Me.cmbArmor = New System.Windows.Forms.ComboBox()
        Me.cmbPotion = New System.Windows.Forms.ComboBox()
        Me.chkShovel = New System.Windows.Forms.CheckBox()
        Me.lblShovel = New System.Windows.Forms.Label()
        Me.chkLantern = New System.Windows.Forms.CheckBox()
        Me.lblLantern = New System.Windows.Forms.Label()
        Me.chkAmulet = New System.Windows.Forms.CheckBox()
        Me.lblAmulet = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstUsers
        '
        Me.lstUsers.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstUsers.FormattingEnabled = True
        Me.lstUsers.ItemHeight = 18
        Me.lstUsers.Location = New System.Drawing.Point(18, 17)
        Me.lstUsers.Margin = New System.Windows.Forms.Padding(4)
        Me.lstUsers.Name = "lstUsers"
        Me.lstUsers.ScrollAlwaysVisible = True
        Me.lstUsers.Size = New System.Drawing.Size(225, 364)
        Me.lstUsers.Sorted = True
        Me.lstUsers.TabIndex = 0
        '
        'lblName
        '
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(251, 47)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(125, 24)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Name:"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblLevel
        '
        Me.lblLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLevel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLevel.Location = New System.Drawing.Point(251, 305)
        Me.lblLevel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLevel.Name = "lblLevel"
        Me.lblLevel.Size = New System.Drawing.Size(125, 24)
        Me.lblLevel.TabIndex = 3
        Me.lblLevel.Text = "Level:"
        Me.lblLevel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMaxEnd
        '
        Me.lblMaxEnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMaxEnd.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaxEnd.Location = New System.Drawing.Point(251, 485)
        Me.lblMaxEnd.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMaxEnd.Name = "lblMaxEnd"
        Me.lblMaxEnd.Size = New System.Drawing.Size(125, 24)
        Me.lblMaxEnd.TabIndex = 4
        Me.lblMaxEnd.Text = "Max Endurance:"
        Me.lblMaxEnd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCurrEnd
        '
        Me.lblCurrEnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCurrEnd.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrEnd.Location = New System.Drawing.Point(251, 455)
        Me.lblCurrEnd.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCurrEnd.Name = "lblCurrEnd"
        Me.lblCurrEnd.Size = New System.Drawing.Size(125, 24)
        Me.lblCurrEnd.TabIndex = 5
        Me.lblCurrEnd.Text = "Curr Endurance:"
        Me.lblCurrEnd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSkillPts
        '
        Me.lblSkillPts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSkillPts.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSkillPts.Location = New System.Drawing.Point(251, 365)
        Me.lblSkillPts.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSkillPts.Name = "lblSkillPts"
        Me.lblSkillPts.Size = New System.Drawing.Size(125, 24)
        Me.lblSkillPts.TabIndex = 6
        Me.lblSkillPts.Text = "Skill Points:"
        Me.lblSkillPts.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblExp
        '
        Me.lblExp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblExp.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExp.Location = New System.Drawing.Point(251, 335)
        Me.lblExp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblExp.Name = "lblExp"
        Me.lblExp.Size = New System.Drawing.Size(125, 24)
        Me.lblExp.TabIndex = 7
        Me.lblExp.Text = "Experience:"
        Me.lblExp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAlive
        '
        Me.lblAlive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAlive.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlive.Location = New System.Drawing.Point(251, 395)
        Me.lblAlive.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAlive.Name = "lblAlive"
        Me.lblAlive.Size = New System.Drawing.Size(125, 24)
        Me.lblAlive.TabIndex = 8
        Me.lblAlive.Text = "Alive:"
        Me.lblAlive.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(882, 167)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 24)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Slipping:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblHench1
        '
        Me.lblHench1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHench1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHench1.Location = New System.Drawing.Point(882, 424)
        Me.lblHench1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHench1.Name = "lblHench1"
        Me.lblHench1.Size = New System.Drawing.Size(125, 24)
        Me.lblHench1.TabIndex = 10
        Me.lblHench1.Text = "Lvl 1 Henchmen:"
        Me.lblHench1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(882, 197)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 24)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Stealth:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(567, 47)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 24)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Current Weapon:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblLocation
        '
        Me.lblLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLocation.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocation.Location = New System.Drawing.Point(251, 425)
        Me.lblLocation.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(125, 24)
        Me.lblLocation.TabIndex = 13
        Me.lblLocation.Text = "Location:"
        Me.lblLocation.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtName
        '
        Me.txtName.Enabled = False
        Me.txtName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(384, 48)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtName.MaxLength = 30
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(175, 22)
        Me.txtName.TabIndex = 1
        Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblHench2
        '
        Me.lblHench2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHench2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHench2.Location = New System.Drawing.Point(882, 454)
        Me.lblHench2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHench2.Name = "lblHench2"
        Me.lblHench2.Size = New System.Drawing.Size(125, 24)
        Me.lblHench2.TabIndex = 15
        Me.lblHench2.Text = "Lvl 2 Henchmen:"
        Me.lblHench2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblHench3
        '
        Me.lblHench3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHench3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHench3.Location = New System.Drawing.Point(882, 484)
        Me.lblHench3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHench3.Name = "lblHench3"
        Me.lblHench3.Size = New System.Drawing.Size(125, 24)
        Me.lblHench3.TabIndex = 16
        Me.lblHench3.Text = "Lvl 3 Henchmen:"
        Me.lblHench3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblHench4
        '
        Me.lblHench4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHench4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHench4.Location = New System.Drawing.Point(882, 515)
        Me.lblHench4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHench4.Name = "lblHench4"
        Me.lblHench4.Size = New System.Drawing.Size(125, 24)
        Me.lblHench4.TabIndex = 17
        Me.lblHench4.Text = "Lvl 4 Henchmen:"
        Me.lblHench4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblHench5
        '
        Me.lblHench5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHench5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHench5.Location = New System.Drawing.Point(882, 545)
        Me.lblHench5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHench5.Name = "lblHench5"
        Me.lblHench5.Size = New System.Drawing.Size(125, 24)
        Me.lblHench5.TabIndex = 18
        Me.lblHench5.Text = "Lvl 5 Henchmen:"
        Me.lblHench5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSkillPts
        '
        Me.txtSkillPts.Enabled = False
        Me.txtSkillPts.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSkillPts.Location = New System.Drawing.Point(384, 366)
        Me.txtSkillPts.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSkillPts.MaxLength = 3
        Me.txtSkillPts.Name = "txtSkillPts"
        Me.txtSkillPts.Size = New System.Drawing.Size(50, 22)
        Me.txtSkillPts.TabIndex = 6
        Me.txtSkillPts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtGoldBank
        '
        Me.txtGoldBank.Enabled = False
        Me.txtGoldBank.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGoldBank.Location = New System.Drawing.Point(699, 288)
        Me.txtGoldBank.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGoldBank.MaxLength = 6
        Me.txtGoldBank.Name = "txtGoldBank"
        Me.txtGoldBank.Size = New System.Drawing.Size(60, 22)
        Me.txtGoldBank.TabIndex = 21
        Me.txtGoldBank.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtGoldLoan
        '
        Me.txtGoldLoan.Enabled = False
        Me.txtGoldLoan.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGoldLoan.Location = New System.Drawing.Point(699, 318)
        Me.txtGoldLoan.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGoldLoan.MaxLength = 6
        Me.txtGoldLoan.Name = "txtGoldLoan"
        Me.txtGoldLoan.Size = New System.Drawing.Size(60, 22)
        Me.txtGoldLoan.TabIndex = 22
        Me.txtGoldLoan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCurrEnd
        '
        Me.txtCurrEnd.Enabled = False
        Me.txtCurrEnd.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrEnd.Location = New System.Drawing.Point(384, 456)
        Me.txtCurrEnd.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCurrEnd.MaxLength = 4
        Me.txtCurrEnd.Name = "txtCurrEnd"
        Me.txtCurrEnd.Size = New System.Drawing.Size(50, 22)
        Me.txtCurrEnd.TabIndex = 9
        Me.txtCurrEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMaxEnd
        '
        Me.txtMaxEnd.Enabled = False
        Me.txtMaxEnd.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaxEnd.Location = New System.Drawing.Point(384, 486)
        Me.txtMaxEnd.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMaxEnd.MaxLength = 4
        Me.txtMaxEnd.Name = "txtMaxEnd"
        Me.txtMaxEnd.Size = New System.Drawing.Size(50, 22)
        Me.txtMaxEnd.TabIndex = 10
        Me.txtMaxEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtExp
        '
        Me.txtExp.Enabled = False
        Me.txtExp.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExp.Location = New System.Drawing.Point(384, 336)
        Me.txtExp.Margin = New System.Windows.Forms.Padding(4)
        Me.txtExp.MaxLength = 3
        Me.txtExp.Name = "txtExp"
        Me.txtExp.Size = New System.Drawing.Size(50, 22)
        Me.txtExp.TabIndex = 5
        Me.txtExp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtLevel
        '
        Me.txtLevel.Enabled = False
        Me.txtLevel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLevel.Location = New System.Drawing.Point(384, 306)
        Me.txtLevel.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLevel.MaxLength = 2
        Me.txtLevel.Name = "txtLevel"
        Me.txtLevel.Size = New System.Drawing.Size(50, 22)
        Me.txtLevel.TabIndex = 4
        Me.txtLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTwoH
        '
        Me.txtTwoH.Enabled = False
        Me.txtTwoH.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTwoH.Location = New System.Drawing.Point(1015, 108)
        Me.txtTwoH.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTwoH.MaxLength = 2
        Me.txtTwoH.Name = "txtTwoH"
        Me.txtTwoH.Size = New System.Drawing.Size(50, 22)
        Me.txtTwoH.TabIndex = 25
        Me.txtTwoH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(567, 317)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 24)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Gold on Loan:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(882, 47)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 24)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Light Wpn Skill:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(882, 77)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 24)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Heavy Wpn Skill:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(882, 107)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 24)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Two-H Wpn Skill:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(882, 137)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(125, 24)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Blocking:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(567, 287)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(125, 24)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Gold in Bank:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(567, 257)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(125, 24)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Gold on Hand:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(567, 197)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(125, 24)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "Potion:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(567, 167)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(125, 24)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "Armor:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGoldHand
        '
        Me.txtGoldHand.Enabled = False
        Me.txtGoldHand.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGoldHand.Location = New System.Drawing.Point(700, 258)
        Me.txtGoldHand.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGoldHand.MaxLength = 6
        Me.txtGoldHand.Name = "txtGoldHand"
        Me.txtGoldHand.Size = New System.Drawing.Size(60, 22)
        Me.txtGoldHand.TabIndex = 20
        Me.txtGoldHand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtHeavy
        '
        Me.txtHeavy.Enabled = False
        Me.txtHeavy.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHeavy.Location = New System.Drawing.Point(1015, 78)
        Me.txtHeavy.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHeavy.MaxLength = 2
        Me.txtHeavy.Name = "txtHeavy"
        Me.txtHeavy.Size = New System.Drawing.Size(50, 22)
        Me.txtHeavy.TabIndex = 24
        Me.txtHeavy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtLight
        '
        Me.txtLight.Enabled = False
        Me.txtLight.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLight.Location = New System.Drawing.Point(1015, 48)
        Me.txtLight.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLight.MaxLength = 2
        Me.txtLight.Name = "txtLight"
        Me.txtLight.Size = New System.Drawing.Size(50, 22)
        Me.txtLight.TabIndex = 23
        Me.txtLight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBlocking
        '
        Me.txtBlocking.Enabled = False
        Me.txtBlocking.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBlocking.Location = New System.Drawing.Point(1015, 138)
        Me.txtBlocking.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBlocking.MaxLength = 2
        Me.txtBlocking.Name = "txtBlocking"
        Me.txtBlocking.Size = New System.Drawing.Size(50, 22)
        Me.txtBlocking.TabIndex = 26
        Me.txtBlocking.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtHench5
        '
        Me.txtHench5.Enabled = False
        Me.txtHench5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHench5.Location = New System.Drawing.Point(1015, 546)
        Me.txtHench5.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHench5.MaxLength = 3
        Me.txtHench5.Name = "txtHench5"
        Me.txtHench5.Size = New System.Drawing.Size(50, 22)
        Me.txtHench5.TabIndex = 33
        Me.txtHench5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtHench4
        '
        Me.txtHench4.Enabled = False
        Me.txtHench4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHench4.Location = New System.Drawing.Point(1015, 516)
        Me.txtHench4.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHench4.MaxLength = 3
        Me.txtHench4.Name = "txtHench4"
        Me.txtHench4.Size = New System.Drawing.Size(50, 22)
        Me.txtHench4.TabIndex = 32
        Me.txtHench4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtHench3
        '
        Me.txtHench3.Enabled = False
        Me.txtHench3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHench3.Location = New System.Drawing.Point(1015, 485)
        Me.txtHench3.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHench3.MaxLength = 3
        Me.txtHench3.Name = "txtHench3"
        Me.txtHench3.Size = New System.Drawing.Size(50, 22)
        Me.txtHench3.TabIndex = 31
        Me.txtHench3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtHench2
        '
        Me.txtHench2.Enabled = False
        Me.txtHench2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHench2.Location = New System.Drawing.Point(1015, 455)
        Me.txtHench2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHench2.MaxLength = 3
        Me.txtHench2.Name = "txtHench2"
        Me.txtHench2.Size = New System.Drawing.Size(50, 22)
        Me.txtHench2.TabIndex = 30
        Me.txtHench2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtHench1
        '
        Me.txtHench1.Enabled = False
        Me.txtHench1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHench1.Location = New System.Drawing.Point(1015, 425)
        Me.txtHench1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHench1.MaxLength = 3
        Me.txtHench1.Name = "txtHench1"
        Me.txtHench1.Size = New System.Drawing.Size(50, 22)
        Me.txtHench1.TabIndex = 29
        Me.txtHench1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtStealth
        '
        Me.txtStealth.Enabled = False
        Me.txtStealth.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStealth.Location = New System.Drawing.Point(1015, 198)
        Me.txtStealth.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStealth.MaxLength = 2
        Me.txtStealth.Name = "txtStealth"
        Me.txtStealth.Size = New System.Drawing.Size(50, 22)
        Me.txtStealth.TabIndex = 28
        Me.txtStealth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSlipping
        '
        Me.txtSlipping.Enabled = False
        Me.txtSlipping.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSlipping.Location = New System.Drawing.Point(1015, 168)
        Me.txtSlipping.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSlipping.MaxLength = 2
        Me.txtSlipping.Name = "txtSlipping"
        Me.txtSlipping.Size = New System.Drawing.Size(50, 22)
        Me.txtSlipping.TabIndex = 27
        Me.txtSlipping.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(61, 503)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(125, 30)
        Me.btnSave.TabIndex = 37
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(61, 541)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(125, 30)
        Me.btnExit.TabIndex = 38
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnNewUser
        '
        Me.btnNewUser.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewUser.Location = New System.Drawing.Point(61, 389)
        Me.btnNewUser.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNewUser.Name = "btnNewUser"
        Me.btnNewUser.Size = New System.Drawing.Size(125, 30)
        Me.btnNewUser.TabIndex = 34
        Me.btnNewUser.Text = "&New User"
        Me.btnNewUser.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Enabled = False
        Me.btnDelete.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(61, 427)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(125, 30)
        Me.btnDelete.TabIndex = 35
        Me.btnDelete.Text = "&Delete User"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'lblPass
        '
        Me.lblPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPass.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPass.Location = New System.Drawing.Point(251, 77)
        Me.lblPass.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(125, 24)
        Me.lblPass.TabIndex = 46
        Me.lblPass.Text = "Password:"
        Me.lblPass.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtChangePass
        '
        Me.txtChangePass.Enabled = False
        Me.txtChangePass.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChangePass.Location = New System.Drawing.Point(384, 78)
        Me.txtChangePass.Margin = New System.Windows.Forms.Padding(4)
        Me.txtChangePass.MaxLength = 16
        Me.txtChangePass.Name = "txtChangePass"
        Me.txtChangePass.Size = New System.Drawing.Size(100, 22)
        Me.txtChangePass.TabIndex = 2
        Me.txtChangePass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtChangePass.UseSystemPasswordChar = True
        '
        'Label14
        '
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(567, 77)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(125, 24)
        Me.Label14.TabIndex = 47
        Me.Label14.Tag = ""
        Me.Label14.Text = "Light Weapon:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(567, 107)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(125, 24)
        Me.Label15.TabIndex = 49
        Me.Label15.Text = "Heavy Weapon:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label16.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(567, 137)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(125, 24)
        Me.Label16.TabIndex = 51
        Me.Label16.Text = "Two-H Weapon:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnClear
        '
        Me.btnClear.Enabled = False
        Me.btnClear.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(61, 465)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(125, 30)
        Me.btnClear.TabIndex = 36
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label18.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(567, 227)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(125, 24)
        Me.Label18.TabIndex = 57
        Me.Label18.Text = "Lockpicks:"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtLockpicks
        '
        Me.txtLockpicks.Enabled = False
        Me.txtLockpicks.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLockpicks.Location = New System.Drawing.Point(700, 228)
        Me.txtLockpicks.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLockpicks.MaxLength = 2
        Me.txtLockpicks.Name = "txtLockpicks"
        Me.txtLockpicks.Size = New System.Drawing.Size(60, 22)
        Me.txtLockpicks.TabIndex = 19
        Me.txtLockpicks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label17.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(251, 107)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(125, 24)
        Me.Label17.TabIndex = 59
        Me.Label17.Text = "Confirm Pass:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtConfPass
        '
        Me.txtConfPass.Enabled = False
        Me.txtConfPass.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfPass.Location = New System.Drawing.Point(384, 108)
        Me.txtConfPass.Margin = New System.Windows.Forms.Padding(4)
        Me.txtConfPass.MaxLength = 16
        Me.txtConfPass.Name = "txtConfPass"
        Me.txtConfPass.Size = New System.Drawing.Size(100, 22)
        Me.txtConfPass.TabIndex = 3
        Me.txtConfPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtConfPass.UseSystemPasswordChar = True
        '
        'Label19
        '
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label19.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(251, 17)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(308, 24)
        Me.Label19.TabIndex = 60
        Me.Label19.Text = "Login Information:"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label20
        '
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label20.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(251, 275)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(308, 24)
        Me.Label20.TabIndex = 61
        Me.Label20.Text = "Character:"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label21
        '
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label21.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(567, 17)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(307, 24)
        Me.Label21.TabIndex = 62
        Me.Label21.Text = "Inventory:"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label22
        '
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label22.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(882, 17)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(183, 24)
        Me.Label22.TabIndex = 63
        Me.Label22.Text = "Skills:"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label23
        '
        Me.Label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label23.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(251, 515)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(125, 24)
        Me.Label23.TabIndex = 64
        Me.Label23.Text = "Hunger:"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtHunger
        '
        Me.txtHunger.Enabled = False
        Me.txtHunger.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHunger.Location = New System.Drawing.Point(384, 516)
        Me.txtHunger.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHunger.MaxLength = 2
        Me.txtHunger.Name = "txtHunger"
        Me.txtHunger.Size = New System.Drawing.Size(50, 22)
        Me.txtHunger.TabIndex = 11
        Me.txtHunger.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label24
        '
        Me.Label24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label24.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(251, 545)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(125, 24)
        Me.Label24.TabIndex = 66
        Me.Label24.Text = "Thirst:"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtThirst
        '
        Me.txtThirst.Enabled = False
        Me.txtThirst.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtThirst.Location = New System.Drawing.Point(384, 546)
        Me.txtThirst.Margin = New System.Windows.Forms.Padding(4)
        Me.txtThirst.MaxLength = 2
        Me.txtThirst.Name = "txtThirst"
        Me.txtThirst.Size = New System.Drawing.Size(50, 22)
        Me.txtThirst.TabIndex = 12
        Me.txtThirst.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label25
        '
        Me.Label25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label25.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(882, 394)
        Me.Label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(183, 24)
        Me.Label25.TabIndex = 68
        Me.Label25.Text = "Henchmen:"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chkAlive
        '
        Me.chkAlive.AutoSize = True
        Me.chkAlive.Enabled = False
        Me.chkAlive.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAlive.Location = New System.Drawing.Point(403, 401)
        Me.chkAlive.Margin = New System.Windows.Forms.Padding(4)
        Me.chkAlive.Name = "chkAlive"
        Me.chkAlive.Size = New System.Drawing.Size(15, 14)
        Me.chkAlive.TabIndex = 7
        Me.chkAlive.UseVisualStyleBackColor = True
        '
        'cmbCurrWeapon
        '
        Me.cmbCurrWeapon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCurrWeapon.Enabled = False
        Me.cmbCurrWeapon.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCurrWeapon.FormattingEnabled = True
        Me.cmbCurrWeapon.Items.AddRange(New Object() {"Light", "Heavy", "Two-H"})
        Me.cmbCurrWeapon.Location = New System.Drawing.Point(699, 47)
        Me.cmbCurrWeapon.Name = "cmbCurrWeapon"
        Me.cmbCurrWeapon.Size = New System.Drawing.Size(101, 24)
        Me.cmbCurrWeapon.TabIndex = 13
        '
        'cmbLoc
        '
        Me.cmbLoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLoc.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLoc.FormattingEnabled = True
        Me.cmbLoc.Items.AddRange(New Object() {"Streets", "Inn", "Guild", "Jail"})
        Me.cmbLoc.Location = New System.Drawing.Point(383, 425)
        Me.cmbLoc.Name = "cmbLoc"
        Me.cmbLoc.Size = New System.Drawing.Size(101, 24)
        Me.cmbLoc.TabIndex = 8
        '
        'cmbLightWeapon
        '
        Me.cmbLightWeapon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLightWeapon.Enabled = False
        Me.cmbLightWeapon.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLightWeapon.FormattingEnabled = True
        Me.cmbLightWeapon.Location = New System.Drawing.Point(699, 77)
        Me.cmbLightWeapon.Name = "cmbLightWeapon"
        Me.cmbLightWeapon.Size = New System.Drawing.Size(175, 24)
        Me.cmbLightWeapon.TabIndex = 14
        '
        'cmbHeavyWeapon
        '
        Me.cmbHeavyWeapon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHeavyWeapon.Enabled = False
        Me.cmbHeavyWeapon.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbHeavyWeapon.FormattingEnabled = True
        Me.cmbHeavyWeapon.Location = New System.Drawing.Point(699, 108)
        Me.cmbHeavyWeapon.Name = "cmbHeavyWeapon"
        Me.cmbHeavyWeapon.Size = New System.Drawing.Size(175, 24)
        Me.cmbHeavyWeapon.TabIndex = 15
        '
        'cmbTwoHWeapon
        '
        Me.cmbTwoHWeapon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTwoHWeapon.Enabled = False
        Me.cmbTwoHWeapon.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTwoHWeapon.FormattingEnabled = True
        Me.cmbTwoHWeapon.Location = New System.Drawing.Point(699, 138)
        Me.cmbTwoHWeapon.Name = "cmbTwoHWeapon"
        Me.cmbTwoHWeapon.Size = New System.Drawing.Size(175, 24)
        Me.cmbTwoHWeapon.TabIndex = 16
        '
        'cmbArmor
        '
        Me.cmbArmor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbArmor.Enabled = False
        Me.cmbArmor.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbArmor.FormattingEnabled = True
        Me.cmbArmor.Location = New System.Drawing.Point(699, 168)
        Me.cmbArmor.Name = "cmbArmor"
        Me.cmbArmor.Size = New System.Drawing.Size(175, 24)
        Me.cmbArmor.TabIndex = 17
        '
        'cmbPotion
        '
        Me.cmbPotion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPotion.Enabled = False
        Me.cmbPotion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPotion.FormattingEnabled = True
        Me.cmbPotion.Location = New System.Drawing.Point(699, 198)
        Me.cmbPotion.Name = "cmbPotion"
        Me.cmbPotion.Size = New System.Drawing.Size(175, 24)
        Me.cmbPotion.TabIndex = 18
        '
        'chkShovel
        '
        Me.chkShovel.AutoSize = True
        Me.chkShovel.Enabled = False
        Me.chkShovel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShovel.Location = New System.Drawing.Point(722, 353)
        Me.chkShovel.Margin = New System.Windows.Forms.Padding(4)
        Me.chkShovel.Name = "chkShovel"
        Me.chkShovel.Size = New System.Drawing.Size(15, 14)
        Me.chkShovel.TabIndex = 69
        Me.chkShovel.UseVisualStyleBackColor = True
        '
        'lblShovel
        '
        Me.lblShovel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblShovel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShovel.Location = New System.Drawing.Point(567, 347)
        Me.lblShovel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblShovel.Name = "lblShovel"
        Me.lblShovel.Size = New System.Drawing.Size(125, 24)
        Me.lblShovel.TabIndex = 70
        Me.lblShovel.Text = "Shovel:"
        Me.lblShovel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkLantern
        '
        Me.chkLantern.AutoSize = True
        Me.chkLantern.Enabled = False
        Me.chkLantern.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLantern.Location = New System.Drawing.Point(722, 383)
        Me.chkLantern.Margin = New System.Windows.Forms.Padding(4)
        Me.chkLantern.Name = "chkLantern"
        Me.chkLantern.Size = New System.Drawing.Size(15, 14)
        Me.chkLantern.TabIndex = 71
        Me.chkLantern.UseVisualStyleBackColor = True
        '
        'lblLantern
        '
        Me.lblLantern.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLantern.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLantern.Location = New System.Drawing.Point(567, 377)
        Me.lblLantern.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLantern.Name = "lblLantern"
        Me.lblLantern.Size = New System.Drawing.Size(125, 24)
        Me.lblLantern.TabIndex = 72
        Me.lblLantern.Text = "Lantern:"
        Me.lblLantern.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkAmulet
        '
        Me.chkAmulet.AutoSize = True
        Me.chkAmulet.Enabled = False
        Me.chkAmulet.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAmulet.Location = New System.Drawing.Point(722, 413)
        Me.chkAmulet.Margin = New System.Windows.Forms.Padding(4)
        Me.chkAmulet.Name = "chkAmulet"
        Me.chkAmulet.Size = New System.Drawing.Size(15, 14)
        Me.chkAmulet.TabIndex = 73
        Me.chkAmulet.UseVisualStyleBackColor = True
        '
        'lblAmulet
        '
        Me.lblAmulet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAmulet.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmulet.Location = New System.Drawing.Point(567, 407)
        Me.lblAmulet.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAmulet.Name = "lblAmulet"
        Me.lblAmulet.Size = New System.Drawing.Size(125, 24)
        Me.lblAmulet.TabIndex = 74
        Me.lblAmulet.Text = "Amulet:"
        Me.lblAmulet.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmAdminUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(1141, 583)
        Me.Controls.Add(Me.chkAmulet)
        Me.Controls.Add(Me.lblAmulet)
        Me.Controls.Add(Me.chkLantern)
        Me.Controls.Add(Me.lblLantern)
        Me.Controls.Add(Me.chkShovel)
        Me.Controls.Add(Me.lblShovel)
        Me.Controls.Add(Me.cmbPotion)
        Me.Controls.Add(Me.cmbArmor)
        Me.Controls.Add(Me.cmbTwoHWeapon)
        Me.Controls.Add(Me.cmbHeavyWeapon)
        Me.Controls.Add(Me.cmbLightWeapon)
        Me.Controls.Add(Me.cmbLoc)
        Me.Controls.Add(Me.cmbCurrWeapon)
        Me.Controls.Add(Me.chkAlive)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.txtThirst)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.txtHunger)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtConfPass)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtLockpicks)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtChangePass)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnNewUser)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtSlipping)
        Me.Controls.Add(Me.txtStealth)
        Me.Controls.Add(Me.txtHench1)
        Me.Controls.Add(Me.txtHench2)
        Me.Controls.Add(Me.txtHench3)
        Me.Controls.Add(Me.txtHench4)
        Me.Controls.Add(Me.txtHench5)
        Me.Controls.Add(Me.txtBlocking)
        Me.Controls.Add(Me.txtLight)
        Me.Controls.Add(Me.txtHeavy)
        Me.Controls.Add(Me.txtGoldHand)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTwoH)
        Me.Controls.Add(Me.txtLevel)
        Me.Controls.Add(Me.txtExp)
        Me.Controls.Add(Me.txtMaxEnd)
        Me.Controls.Add(Me.txtCurrEnd)
        Me.Controls.Add(Me.txtGoldLoan)
        Me.Controls.Add(Me.txtGoldBank)
        Me.Controls.Add(Me.txtSkillPts)
        Me.Controls.Add(Me.lblHench5)
        Me.Controls.Add(Me.lblHench4)
        Me.Controls.Add(Me.lblHench3)
        Me.Controls.Add(Me.lblHench2)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblLocation)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblHench1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblAlive)
        Me.Controls.Add(Me.lblExp)
        Me.Controls.Add(Me.lblSkillPts)
        Me.Controls.Add(Me.lblCurrEnd)
        Me.Controls.Add(Me.lblMaxEnd)
        Me.Controls.Add(Me.lblLevel)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lstUsers)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(970, 622)
        Me.Name = "frmAdminUsers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin Users"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstUsers As System.Windows.Forms.ListBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblLevel As System.Windows.Forms.Label
    Friend WithEvents lblMaxEnd As System.Windows.Forms.Label
    Friend WithEvents lblCurrEnd As System.Windows.Forms.Label
    Friend WithEvents lblSkillPts As System.Windows.Forms.Label
    Friend WithEvents lblExp As System.Windows.Forms.Label
    Friend WithEvents lblAlive As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblHench1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblLocation As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblHench2 As System.Windows.Forms.Label
    Friend WithEvents lblHench3 As System.Windows.Forms.Label
    Friend WithEvents lblHench4 As System.Windows.Forms.Label
    Friend WithEvents lblHench5 As System.Windows.Forms.Label
    Friend WithEvents txtSkillPts As System.Windows.Forms.TextBox
    Friend WithEvents txtGoldBank As System.Windows.Forms.TextBox
    Friend WithEvents txtGoldLoan As System.Windows.Forms.TextBox
    Friend WithEvents txtCurrEnd As System.Windows.Forms.TextBox
    Friend WithEvents txtMaxEnd As System.Windows.Forms.TextBox
    Friend WithEvents txtExp As System.Windows.Forms.TextBox
    Friend WithEvents txtLevel As System.Windows.Forms.TextBox
    Friend WithEvents txtTwoH As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtGoldHand As System.Windows.Forms.TextBox
    Friend WithEvents txtHeavy As System.Windows.Forms.TextBox
    Friend WithEvents txtLight As System.Windows.Forms.TextBox
    Friend WithEvents txtBlocking As System.Windows.Forms.TextBox
    Friend WithEvents txtHench5 As System.Windows.Forms.TextBox
    Friend WithEvents txtHench4 As System.Windows.Forms.TextBox
    Friend WithEvents txtHench3 As System.Windows.Forms.TextBox
    Friend WithEvents txtHench2 As System.Windows.Forms.TextBox
    Friend WithEvents txtHench1 As System.Windows.Forms.TextBox
    Friend WithEvents txtStealth As System.Windows.Forms.TextBox
    Friend WithEvents txtSlipping As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnNewUser As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents lblPass As System.Windows.Forms.Label
    Friend WithEvents txtChangePass As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtLockpicks As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtConfPass As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtHunger As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtThirst As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents chkAlive As System.Windows.Forms.CheckBox
    Friend WithEvents cmbCurrWeapon As System.Windows.Forms.ComboBox
    Friend WithEvents cmbLoc As System.Windows.Forms.ComboBox
    Friend WithEvents cmbLightWeapon As System.Windows.Forms.ComboBox
    Friend WithEvents cmbHeavyWeapon As System.Windows.Forms.ComboBox
    Friend WithEvents cmbTwoHWeapon As System.Windows.Forms.ComboBox
    Friend WithEvents cmbArmor As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPotion As System.Windows.Forms.ComboBox
    Friend WithEvents chkShovel As System.Windows.Forms.CheckBox
    Friend WithEvents lblShovel As System.Windows.Forms.Label
    Friend WithEvents chkLantern As System.Windows.Forms.CheckBox
    Friend WithEvents lblLantern As System.Windows.Forms.Label
    Friend WithEvents chkAmulet As System.Windows.Forms.CheckBox
    Friend WithEvents lblAmulet As System.Windows.Forms.Label
End Class
