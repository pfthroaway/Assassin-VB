Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

Namespace Forms.Admin
    <DesignerGenerated()> _
    Partial Class FrmAdminUsers
        Inherits Form

        'Form overrides dispose to clean up the component list.
        <DebuggerNonUserCode()> _
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
        Private components As IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.lstUsers = New ListBox()
            Me.lblName = New Label()
            Me.lblLevel = New Label()
            Me.lblMaximumEndurance = New Label()
            Me.lblCurrentEndurance = New Label()
            Me.lblSkillPts = New Label()
            Me.lblExp = New Label()
            Me.lblAlive = New Label()
            Me.Label1 = New Label()
            Me.lblHenchmenLevel1 = New Label()
            Me.Label3 = New Label()
            Me.Label4 = New Label()
            Me.lblLocation = New Label()
            Me.txtName = New TextBox()
            Me.lblHenchmenLevel2 = New Label()
            Me.lblHenchmenLevel3 = New Label()
            Me.lblHenchmenLevel4 = New Label()
            Me.lblHenchmenLevel5 = New Label()
            Me.txtSkillPts = New TextBox()
            Me.txtGoldBank = New TextBox()
            Me.txtGoldLoan = New TextBox()
            Me.txtCurrentEndurance = New TextBox()
            Me.txtMaximumEndurance = New TextBox()
            Me.txtExp = New TextBox()
            Me.txtLevel = New TextBox()
            Me.txtTwoH = New TextBox()
            Me.Label2 = New Label()
            Me.Label5 = New Label()
            Me.Label6 = New Label()
            Me.Label7 = New Label()
            Me.Label8 = New Label()
            Me.Label9 = New Label()
            Me.Label10 = New Label()
            Me.Label11 = New Label()
            Me.Label12 = New Label()
            Me.txtGoldHand = New TextBox()
            Me.txtHeavy = New TextBox()
            Me.txtLight = New TextBox()
            Me.txtBlocking = New TextBox()
            Me.txtHenchmenLevel5 = New TextBox()
            Me.txtHenchmenLevel4 = New TextBox()
            Me.txtHenchmenLevel3 = New TextBox()
            Me.txtHenchmenLevel2 = New TextBox()
            Me.txtHenchmenLevel1 = New TextBox()
            Me.txtStealth = New TextBox()
            Me.txtSlipping = New TextBox()
            Me.btnSave = New Button()
            Me.btnExit = New Button()
            Me.btnNewUser = New Button()
            Me.btnDelete = New Button()
            Me.lblPass = New Label()
            Me.txtChangePass = New TextBox()
            Me.Label14 = New Label()
            Me.Label15 = New Label()
            Me.Label16 = New Label()
            Me.btnClear = New Button()
            Me.Label18 = New Label()
            Me.txtLockpicks = New TextBox()
            Me.Label17 = New Label()
            Me.txtConfPass = New TextBox()
            Me.Label19 = New Label()
            Me.Label20 = New Label()
            Me.Label21 = New Label()
            Me.Label22 = New Label()
            Me.Label23 = New Label()
            Me.txtHunger = New TextBox()
            Me.Label24 = New Label()
            Me.txtThirst = New TextBox()
            Me.Label25 = New Label()
            Me.chkAlive = New CheckBox()
            Me.cmbCurrWeapon = New ComboBox()
            Me.cmbLoc = New ComboBox()
            Me.cmbLightWeapon = New ComboBox()
            Me.cmbHeavyWeapon = New ComboBox()
            Me.cmbTwoHWeapon = New ComboBox()
            Me.cmbArmor = New ComboBox()
            Me.cmbPotion = New ComboBox()
            Me.chkShovel = New CheckBox()
            Me.lblShovel = New Label()
            Me.chkLantern = New CheckBox()
            Me.lblLantern = New Label()
            Me.chkAmulet = New CheckBox()
            Me.lblAmulet = New Label()
            Me.SuspendLayout()
            '
            'lstUsers
            '
            Me.lstUsers.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lstUsers.FormattingEnabled = True
            Me.lstUsers.ItemHeight = 18
            Me.lstUsers.Location = New Point(18, 17)
            Me.lstUsers.Margin = New Padding(4)
            Me.lstUsers.Name = "lstUsers"
            Me.lstUsers.ScrollAlwaysVisible = True
            Me.lstUsers.Size = New Size(225, 364)
            Me.lstUsers.Sorted = True
            Me.lstUsers.TabIndex = 0
            '
            'lblName
            '
            Me.lblName.BorderStyle = BorderStyle.FixedSingle
            Me.lblName.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblName.Location = New Point(251, 47)
            Me.lblName.Margin = New Padding(4, 0, 4, 0)
            Me.lblName.Name = "lblName"
            Me.lblName.Size = New Size(125, 24)
            Me.lblName.TabIndex = 2
            Me.lblName.Text = "Name:"
            Me.lblName.TextAlign = ContentAlignment.MiddleRight
            '
            'lblLevel
            '
            Me.lblLevel.BorderStyle = BorderStyle.FixedSingle
            Me.lblLevel.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblLevel.Location = New Point(251, 305)
            Me.lblLevel.Margin = New Padding(4, 0, 4, 0)
            Me.lblLevel.Name = "lblLevel"
            Me.lblLevel.Size = New Size(125, 24)
            Me.lblLevel.TabIndex = 3
            Me.lblLevel.Text = "Level:"
            Me.lblLevel.TextAlign = ContentAlignment.MiddleRight
            '
            'lblMaximumEndurance
            '
            Me.lblMaximumEndurance.BorderStyle = BorderStyle.FixedSingle
            Me.lblMaximumEndurance.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblMaximumEndurance.Location = New Point(251, 485)
            Me.lblMaximumEndurance.Margin = New Padding(4, 0, 4, 0)
            Me.lblMaximumEndurance.Name = "lblMaximumEndurance"
            Me.lblMaximumEndurance.Size = New Size(125, 24)
            Me.lblMaximumEndurance.TabIndex = 4
            Me.lblMaximumEndurance.Text = "Max Endurance:"
            Me.lblMaximumEndurance.TextAlign = ContentAlignment.MiddleRight
            '
            'lblCurrentEndurance
            '
            Me.lblCurrentEndurance.BorderStyle = BorderStyle.FixedSingle
            Me.lblCurrentEndurance.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblCurrentEndurance.Location = New Point(251, 455)
            Me.lblCurrentEndurance.Margin = New Padding(4, 0, 4, 0)
            Me.lblCurrentEndurance.Name = "lblCurrentEndurance"
            Me.lblCurrentEndurance.Size = New Size(125, 24)
            Me.lblCurrentEndurance.TabIndex = 5
            Me.lblCurrentEndurance.Text = "Curr Endurance:"
            Me.lblCurrentEndurance.TextAlign = ContentAlignment.MiddleRight
            '
            'lblSkillPts
            '
            Me.lblSkillPts.BorderStyle = BorderStyle.FixedSingle
            Me.lblSkillPts.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblSkillPts.Location = New Point(251, 365)
            Me.lblSkillPts.Margin = New Padding(4, 0, 4, 0)
            Me.lblSkillPts.Name = "lblSkillPts"
            Me.lblSkillPts.Size = New Size(125, 24)
            Me.lblSkillPts.TabIndex = 6
            Me.lblSkillPts.Text = "Skill Points:"
            Me.lblSkillPts.TextAlign = ContentAlignment.MiddleRight
            '
            'lblExp
            '
            Me.lblExp.BorderStyle = BorderStyle.FixedSingle
            Me.lblExp.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblExp.Location = New Point(251, 335)
            Me.lblExp.Margin = New Padding(4, 0, 4, 0)
            Me.lblExp.Name = "lblExp"
            Me.lblExp.Size = New Size(125, 24)
            Me.lblExp.TabIndex = 7
            Me.lblExp.Text = "Experience:"
            Me.lblExp.TextAlign = ContentAlignment.MiddleRight
            '
            'lblAlive
            '
            Me.lblAlive.BorderStyle = BorderStyle.FixedSingle
            Me.lblAlive.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblAlive.Location = New Point(251, 395)
            Me.lblAlive.Margin = New Padding(4, 0, 4, 0)
            Me.lblAlive.Name = "lblAlive"
            Me.lblAlive.Size = New Size(125, 24)
            Me.lblAlive.TabIndex = 8
            Me.lblAlive.Text = "Alive:"
            Me.lblAlive.TextAlign = ContentAlignment.MiddleRight
            '
            'Label1
            '
            Me.Label1.BorderStyle = BorderStyle.FixedSingle
            Me.Label1.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New Point(882, 167)
            Me.Label1.Margin = New Padding(4, 0, 4, 0)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New Size(125, 24)
            Me.Label1.TabIndex = 9
            Me.Label1.Text = "Slipping:"
            Me.Label1.TextAlign = ContentAlignment.MiddleRight
            '
            'lblHenchmenLevel1
            '
            Me.lblHenchmenLevel1.BorderStyle = BorderStyle.FixedSingle
            Me.lblHenchmenLevel1.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblHenchmenLevel1.Location = New Point(882, 424)
            Me.lblHenchmenLevel1.Margin = New Padding(4, 0, 4, 0)
            Me.lblHenchmenLevel1.Name = "lblHenchmenLevel1"
            Me.lblHenchmenLevel1.Size = New Size(125, 24)
            Me.lblHenchmenLevel1.TabIndex = 10
            Me.lblHenchmenLevel1.Text = "Lvl 1 Henchmen:"
            Me.lblHenchmenLevel1.TextAlign = ContentAlignment.MiddleRight
            '
            'Label3
            '
            Me.Label3.BorderStyle = BorderStyle.FixedSingle
            Me.Label3.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New Point(882, 197)
            Me.Label3.Margin = New Padding(4, 0, 4, 0)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New Size(125, 24)
            Me.Label3.TabIndex = 11
            Me.Label3.Text = "Stealth:"
            Me.Label3.TextAlign = ContentAlignment.MiddleRight
            '
            'Label4
            '
            Me.Label4.BorderStyle = BorderStyle.FixedSingle
            Me.Label4.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New Point(567, 47)
            Me.Label4.Margin = New Padding(4, 0, 4, 0)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New Size(125, 24)
            Me.Label4.TabIndex = 12
            Me.Label4.Text = "Current Weapon:"
            Me.Label4.TextAlign = ContentAlignment.MiddleRight
            '
            'lblLocation
            '
            Me.lblLocation.BorderStyle = BorderStyle.FixedSingle
            Me.lblLocation.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblLocation.Location = New Point(251, 425)
            Me.lblLocation.Margin = New Padding(4, 0, 4, 0)
            Me.lblLocation.Name = "lblLocation"
            Me.lblLocation.Size = New Size(125, 24)
            Me.lblLocation.TabIndex = 13
            Me.lblLocation.Text = "Location:"
            Me.lblLocation.TextAlign = ContentAlignment.MiddleRight
            '
            'txtName
            '
            Me.txtName.Enabled = False
            Me.txtName.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.txtName.Location = New Point(384, 48)
            Me.txtName.Margin = New Padding(4)
            Me.txtName.MaxLength = 30
            Me.txtName.Name = "txtName"
            Me.txtName.Size = New Size(175, 22)
            Me.txtName.TabIndex = 1
            Me.txtName.TextAlign = HorizontalAlignment.Center
            '
            'lblHenchmenLevel2
            '
            Me.lblHenchmenLevel2.BorderStyle = BorderStyle.FixedSingle
            Me.lblHenchmenLevel2.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblHenchmenLevel2.Location = New Point(882, 454)
            Me.lblHenchmenLevel2.Margin = New Padding(4, 0, 4, 0)
            Me.lblHenchmenLevel2.Name = "lblHenchmenLevel2"
            Me.lblHenchmenLevel2.Size = New Size(125, 24)
            Me.lblHenchmenLevel2.TabIndex = 15
            Me.lblHenchmenLevel2.Text = "Lvl 2 Henchmen:"
            Me.lblHenchmenLevel2.TextAlign = ContentAlignment.MiddleRight
            '
            'lblHenchmenLevel3
            '
            Me.lblHenchmenLevel3.BorderStyle = BorderStyle.FixedSingle
            Me.lblHenchmenLevel3.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblHenchmenLevel3.Location = New Point(882, 484)
            Me.lblHenchmenLevel3.Margin = New Padding(4, 0, 4, 0)
            Me.lblHenchmenLevel3.Name = "lblHenchmenLevel3"
            Me.lblHenchmenLevel3.Size = New Size(125, 24)
            Me.lblHenchmenLevel3.TabIndex = 16
            Me.lblHenchmenLevel3.Text = "Lvl 3 Henchmen:"
            Me.lblHenchmenLevel3.TextAlign = ContentAlignment.MiddleRight
            '
            'lblHenchmenLevel4
            '
            Me.lblHenchmenLevel4.BorderStyle = BorderStyle.FixedSingle
            Me.lblHenchmenLevel4.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblHenchmenLevel4.Location = New Point(882, 515)
            Me.lblHenchmenLevel4.Margin = New Padding(4, 0, 4, 0)
            Me.lblHenchmenLevel4.Name = "lblHenchmenLevel4"
            Me.lblHenchmenLevel4.Size = New Size(125, 24)
            Me.lblHenchmenLevel4.TabIndex = 17
            Me.lblHenchmenLevel4.Text = "Lvl 4 Henchmen:"
            Me.lblHenchmenLevel4.TextAlign = ContentAlignment.MiddleRight
            '
            'lblHenchmenLevel5
            '
            Me.lblHenchmenLevel5.BorderStyle = BorderStyle.FixedSingle
            Me.lblHenchmenLevel5.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblHenchmenLevel5.Location = New Point(882, 545)
            Me.lblHenchmenLevel5.Margin = New Padding(4, 0, 4, 0)
            Me.lblHenchmenLevel5.Name = "lblHenchmenLevel5"
            Me.lblHenchmenLevel5.Size = New Size(125, 24)
            Me.lblHenchmenLevel5.TabIndex = 18
            Me.lblHenchmenLevel5.Text = "Lvl 5 Henchmen:"
            Me.lblHenchmenLevel5.TextAlign = ContentAlignment.MiddleRight
            '
            'txtSkillPts
            '
            Me.txtSkillPts.Enabled = False
            Me.txtSkillPts.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.txtSkillPts.Location = New Point(384, 366)
            Me.txtSkillPts.Margin = New Padding(4)
            Me.txtSkillPts.MaxLength = 3
            Me.txtSkillPts.Name = "txtSkillPts"
            Me.txtSkillPts.Size = New Size(50, 22)
            Me.txtSkillPts.TabIndex = 6
            Me.txtSkillPts.TextAlign = HorizontalAlignment.Center
            '
            'txtGoldBank
            '
            Me.txtGoldBank.Enabled = False
            Me.txtGoldBank.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.txtGoldBank.Location = New Point(699, 288)
            Me.txtGoldBank.Margin = New Padding(4)
            Me.txtGoldBank.MaxLength = 6
            Me.txtGoldBank.Name = "txtGoldBank"
            Me.txtGoldBank.Size = New Size(60, 22)
            Me.txtGoldBank.TabIndex = 21
            Me.txtGoldBank.TextAlign = HorizontalAlignment.Center
            '
            'txtGoldLoan
            '
            Me.txtGoldLoan.Enabled = False
            Me.txtGoldLoan.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.txtGoldLoan.Location = New Point(699, 318)
            Me.txtGoldLoan.Margin = New Padding(4)
            Me.txtGoldLoan.MaxLength = 6
            Me.txtGoldLoan.Name = "txtGoldLoan"
            Me.txtGoldLoan.Size = New Size(60, 22)
            Me.txtGoldLoan.TabIndex = 22
            Me.txtGoldLoan.TextAlign = HorizontalAlignment.Center
            '
            'txtCurrentEndurance
            '
            Me.txtCurrentEndurance.Enabled = False
            Me.txtCurrentEndurance.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.txtCurrentEndurance.Location = New Point(384, 456)
            Me.txtCurrentEndurance.Margin = New Padding(4)
            Me.txtCurrentEndurance.MaxLength = 4
            Me.txtCurrentEndurance.Name = "txtCurrentEndurance"
            Me.txtCurrentEndurance.Size = New Size(50, 22)
            Me.txtCurrentEndurance.TabIndex = 9
            Me.txtCurrentEndurance.TextAlign = HorizontalAlignment.Center
            '
            'txtMaximumEndurance
            '
            Me.txtMaximumEndurance.Enabled = False
            Me.txtMaximumEndurance.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.txtMaximumEndurance.Location = New Point(384, 486)
            Me.txtMaximumEndurance.Margin = New Padding(4)
            Me.txtMaximumEndurance.MaxLength = 4
            Me.txtMaximumEndurance.Name = "txtMaximumEndurance"
            Me.txtMaximumEndurance.Size = New Size(50, 22)
            Me.txtMaximumEndurance.TabIndex = 10
            Me.txtMaximumEndurance.TextAlign = HorizontalAlignment.Center
            '
            'txtExp
            '
            Me.txtExp.Enabled = False
            Me.txtExp.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.txtExp.Location = New Point(384, 336)
            Me.txtExp.Margin = New Padding(4)
            Me.txtExp.MaxLength = 3
            Me.txtExp.Name = "txtExp"
            Me.txtExp.Size = New Size(50, 22)
            Me.txtExp.TabIndex = 5
            Me.txtExp.TextAlign = HorizontalAlignment.Center
            '
            'txtLevel
            '
            Me.txtLevel.Enabled = False
            Me.txtLevel.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.txtLevel.Location = New Point(384, 306)
            Me.txtLevel.Margin = New Padding(4)
            Me.txtLevel.MaxLength = 2
            Me.txtLevel.Name = "txtLevel"
            Me.txtLevel.Size = New Size(50, 22)
            Me.txtLevel.TabIndex = 4
            Me.txtLevel.TextAlign = HorizontalAlignment.Center
            '
            'txtTwoH
            '
            Me.txtTwoH.Enabled = False
            Me.txtTwoH.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.txtTwoH.Location = New Point(1015, 108)
            Me.txtTwoH.Margin = New Padding(4)
            Me.txtTwoH.MaxLength = 2
            Me.txtTwoH.Name = "txtTwoH"
            Me.txtTwoH.Size = New Size(50, 22)
            Me.txtTwoH.TabIndex = 25
            Me.txtTwoH.TextAlign = HorizontalAlignment.Center
            '
            'Label2
            '
            Me.Label2.BorderStyle = BorderStyle.FixedSingle
            Me.Label2.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New Point(567, 317)
            Me.Label2.Margin = New Padding(4, 0, 4, 0)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New Size(125, 24)
            Me.Label2.TabIndex = 27
            Me.Label2.Text = "Gold on Loan:"
            Me.Label2.TextAlign = ContentAlignment.MiddleRight
            '
            'Label5
            '
            Me.Label5.BorderStyle = BorderStyle.FixedSingle
            Me.Label5.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.Location = New Point(882, 47)
            Me.Label5.Margin = New Padding(4, 0, 4, 0)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New Size(125, 24)
            Me.Label5.TabIndex = 28
            Me.Label5.Text = "Light Wpn Skill:"
            Me.Label5.TextAlign = ContentAlignment.MiddleRight
            '
            'Label6
            '
            Me.Label6.BorderStyle = BorderStyle.FixedSingle
            Me.Label6.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.Location = New Point(882, 77)
            Me.Label6.Margin = New Padding(4, 0, 4, 0)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New Size(125, 24)
            Me.Label6.TabIndex = 29
            Me.Label6.Text = "Heavy Wpn Skill:"
            Me.Label6.TextAlign = ContentAlignment.MiddleRight
            '
            'Label7
            '
            Me.Label7.BorderStyle = BorderStyle.FixedSingle
            Me.Label7.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.Location = New Point(882, 107)
            Me.Label7.Margin = New Padding(4, 0, 4, 0)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New Size(125, 24)
            Me.Label7.TabIndex = 30
            Me.Label7.Text = "Two-H Wpn Skill:"
            Me.Label7.TextAlign = ContentAlignment.MiddleRight
            '
            'Label8
            '
            Me.Label8.BorderStyle = BorderStyle.FixedSingle
            Me.Label8.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.Location = New Point(882, 137)
            Me.Label8.Margin = New Padding(4, 0, 4, 0)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New Size(125, 24)
            Me.Label8.TabIndex = 31
            Me.Label8.Text = "Blocking:"
            Me.Label8.TextAlign = ContentAlignment.MiddleRight
            '
            'Label9
            '
            Me.Label9.BorderStyle = BorderStyle.FixedSingle
            Me.Label9.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Label9.Location = New Point(567, 287)
            Me.Label9.Margin = New Padding(4, 0, 4, 0)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New Size(125, 24)
            Me.Label9.TabIndex = 32
            Me.Label9.Text = "Gold in Bank:"
            Me.Label9.TextAlign = ContentAlignment.MiddleRight
            '
            'Label10
            '
            Me.Label10.BorderStyle = BorderStyle.FixedSingle
            Me.Label10.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Label10.Location = New Point(567, 257)
            Me.Label10.Margin = New Padding(4, 0, 4, 0)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New Size(125, 24)
            Me.Label10.TabIndex = 33
            Me.Label10.Text = "Gold on Hand:"
            Me.Label10.TextAlign = ContentAlignment.MiddleRight
            '
            'Label11
            '
            Me.Label11.BorderStyle = BorderStyle.FixedSingle
            Me.Label11.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Label11.Location = New Point(567, 197)
            Me.Label11.Margin = New Padding(4, 0, 4, 0)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New Size(125, 24)
            Me.Label11.TabIndex = 34
            Me.Label11.Text = "Potion:"
            Me.Label11.TextAlign = ContentAlignment.MiddleRight
            '
            'Label12
            '
            Me.Label12.BorderStyle = BorderStyle.FixedSingle
            Me.Label12.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Label12.Location = New Point(567, 167)
            Me.Label12.Margin = New Padding(4, 0, 4, 0)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New Size(125, 24)
            Me.Label12.TabIndex = 35
            Me.Label12.Text = "Armor:"
            Me.Label12.TextAlign = ContentAlignment.MiddleRight
            '
            'txtGoldHand
            '
            Me.txtGoldHand.Enabled = False
            Me.txtGoldHand.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.txtGoldHand.Location = New Point(700, 258)
            Me.txtGoldHand.Margin = New Padding(4)
            Me.txtGoldHand.MaxLength = 6
            Me.txtGoldHand.Name = "txtGoldHand"
            Me.txtGoldHand.Size = New Size(60, 22)
            Me.txtGoldHand.TabIndex = 20
            Me.txtGoldHand.TextAlign = HorizontalAlignment.Center
            '
            'txtHeavy
            '
            Me.txtHeavy.Enabled = False
            Me.txtHeavy.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.txtHeavy.Location = New Point(1015, 78)
            Me.txtHeavy.Margin = New Padding(4)
            Me.txtHeavy.MaxLength = 2
            Me.txtHeavy.Name = "txtHeavy"
            Me.txtHeavy.Size = New Size(50, 22)
            Me.txtHeavy.TabIndex = 24
            Me.txtHeavy.TextAlign = HorizontalAlignment.Center
            '
            'txtLight
            '
            Me.txtLight.Enabled = False
            Me.txtLight.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.txtLight.Location = New Point(1015, 48)
            Me.txtLight.Margin = New Padding(4)
            Me.txtLight.MaxLength = 2
            Me.txtLight.Name = "txtLight"
            Me.txtLight.Size = New Size(50, 22)
            Me.txtLight.TabIndex = 23
            Me.txtLight.TextAlign = HorizontalAlignment.Center
            '
            'txtBlocking
            '
            Me.txtBlocking.Enabled = False
            Me.txtBlocking.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.txtBlocking.Location = New Point(1015, 138)
            Me.txtBlocking.Margin = New Padding(4)
            Me.txtBlocking.MaxLength = 2
            Me.txtBlocking.Name = "txtBlocking"
            Me.txtBlocking.Size = New Size(50, 22)
            Me.txtBlocking.TabIndex = 26
            Me.txtBlocking.TextAlign = HorizontalAlignment.Center
            '
            'txtHenchmenLevel5
            '
            Me.txtHenchmenLevel5.Enabled = False
            Me.txtHenchmenLevel5.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.txtHenchmenLevel5.Location = New Point(1015, 546)
            Me.txtHenchmenLevel5.Margin = New Padding(4)
            Me.txtHenchmenLevel5.MaxLength = 3
            Me.txtHenchmenLevel5.Name = "txtHenchmenLevel5"
            Me.txtHenchmenLevel5.Size = New Size(50, 22)
            Me.txtHenchmenLevel5.TabIndex = 33
            Me.txtHenchmenLevel5.TextAlign = HorizontalAlignment.Center
            '
            'txtHenchmenLevel4
            '
            Me.txtHenchmenLevel4.Enabled = False
            Me.txtHenchmenLevel4.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.txtHenchmenLevel4.Location = New Point(1015, 516)
            Me.txtHenchmenLevel4.Margin = New Padding(4)
            Me.txtHenchmenLevel4.MaxLength = 3
            Me.txtHenchmenLevel4.Name = "txtHenchmenLevel4"
            Me.txtHenchmenLevel4.Size = New Size(50, 22)
            Me.txtHenchmenLevel4.TabIndex = 32
            Me.txtHenchmenLevel4.TextAlign = HorizontalAlignment.Center
            '
            'txtHenchmenLevel3
            '
            Me.txtHenchmenLevel3.Enabled = False
            Me.txtHenchmenLevel3.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.txtHenchmenLevel3.Location = New Point(1015, 485)
            Me.txtHenchmenLevel3.Margin = New Padding(4)
            Me.txtHenchmenLevel3.MaxLength = 3
            Me.txtHenchmenLevel3.Name = "txtHenchmenLevel3"
            Me.txtHenchmenLevel3.Size = New Size(50, 22)
            Me.txtHenchmenLevel3.TabIndex = 31
            Me.txtHenchmenLevel3.TextAlign = HorizontalAlignment.Center
            '
            'txtHenchmenLevel2
            '
            Me.txtHenchmenLevel2.Enabled = False
            Me.txtHenchmenLevel2.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.txtHenchmenLevel2.Location = New Point(1015, 455)
            Me.txtHenchmenLevel2.Margin = New Padding(4)
            Me.txtHenchmenLevel2.MaxLength = 3
            Me.txtHenchmenLevel2.Name = "txtHenchmenLevel2"
            Me.txtHenchmenLevel2.Size = New Size(50, 22)
            Me.txtHenchmenLevel2.TabIndex = 30
            Me.txtHenchmenLevel2.TextAlign = HorizontalAlignment.Center
            '
            'txtHenchmenLevel1
            '
            Me.txtHenchmenLevel1.Enabled = False
            Me.txtHenchmenLevel1.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.txtHenchmenLevel1.Location = New Point(1015, 425)
            Me.txtHenchmenLevel1.Margin = New Padding(4)
            Me.txtHenchmenLevel1.MaxLength = 3
            Me.txtHenchmenLevel1.Name = "txtHenchmenLevel1"
            Me.txtHenchmenLevel1.Size = New Size(50, 22)
            Me.txtHenchmenLevel1.TabIndex = 29
            Me.txtHenchmenLevel1.TextAlign = HorizontalAlignment.Center
            '
            'txtStealth
            '
            Me.txtStealth.Enabled = False
            Me.txtStealth.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.txtStealth.Location = New Point(1015, 198)
            Me.txtStealth.Margin = New Padding(4)
            Me.txtStealth.MaxLength = 2
            Me.txtStealth.Name = "txtStealth"
            Me.txtStealth.Size = New Size(50, 22)
            Me.txtStealth.TabIndex = 28
            Me.txtStealth.TextAlign = HorizontalAlignment.Center
            '
            'txtSlipping
            '
            Me.txtSlipping.Enabled = False
            Me.txtSlipping.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.txtSlipping.Location = New Point(1015, 168)
            Me.txtSlipping.Margin = New Padding(4)
            Me.txtSlipping.MaxLength = 2
            Me.txtSlipping.Name = "txtSlipping"
            Me.txtSlipping.Size = New Size(50, 22)
            Me.txtSlipping.TabIndex = 27
            Me.txtSlipping.TextAlign = HorizontalAlignment.Center
            '
            'btnSave
            '
            Me.btnSave.Enabled = False
            Me.btnSave.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnSave.Location = New Point(61, 503)
            Me.btnSave.Margin = New Padding(4)
            Me.btnSave.Name = "btnSave"
            Me.btnSave.Size = New Size(125, 30)
            Me.btnSave.TabIndex = 37
            Me.btnSave.Text = "&Save"
            Me.btnSave.UseVisualStyleBackColor = True
            '
            'btnExit
            '
            Me.btnExit.DialogResult = DialogResult.Cancel
            Me.btnExit.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnExit.Location = New Point(61, 541)
            Me.btnExit.Margin = New Padding(4)
            Me.btnExit.Name = "btnExit"
            Me.btnExit.Size = New Size(125, 30)
            Me.btnExit.TabIndex = 38
            Me.btnExit.Text = "E&xit"
            Me.btnExit.UseVisualStyleBackColor = True
            '
            'btnNewUser
            '
            Me.btnNewUser.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnNewUser.Location = New Point(61, 389)
            Me.btnNewUser.Margin = New Padding(4)
            Me.btnNewUser.Name = "btnNewUser"
            Me.btnNewUser.Size = New Size(125, 30)
            Me.btnNewUser.TabIndex = 34
            Me.btnNewUser.Text = "&New User"
            Me.btnNewUser.UseVisualStyleBackColor = True
            '
            'btnDelete
            '
            Me.btnDelete.Enabled = False
            Me.btnDelete.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnDelete.Location = New Point(61, 427)
            Me.btnDelete.Margin = New Padding(4)
            Me.btnDelete.Name = "btnDelete"
            Me.btnDelete.Size = New Size(125, 30)
            Me.btnDelete.TabIndex = 35
            Me.btnDelete.Text = "&Delete User"
            Me.btnDelete.UseVisualStyleBackColor = True
            '
            'lblPass
            '
            Me.lblPass.BorderStyle = BorderStyle.FixedSingle
            Me.lblPass.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblPass.Location = New Point(251, 77)
            Me.lblPass.Margin = New Padding(4, 0, 4, 0)
            Me.lblPass.Name = "lblPass"
            Me.lblPass.Size = New Size(125, 24)
            Me.lblPass.TabIndex = 46
            Me.lblPass.Text = "Password:"
            Me.lblPass.TextAlign = ContentAlignment.MiddleRight
            '
            'txtChangePass
            '
            Me.txtChangePass.Enabled = False
            Me.txtChangePass.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.txtChangePass.Location = New Point(384, 78)
            Me.txtChangePass.Margin = New Padding(4)
            Me.txtChangePass.MaxLength = 16
            Me.txtChangePass.Name = "txtChangePass"
            Me.txtChangePass.Size = New Size(100, 22)
            Me.txtChangePass.TabIndex = 2
            Me.txtChangePass.TextAlign = HorizontalAlignment.Center
            Me.txtChangePass.UseSystemPasswordChar = True
            '
            'Label14
            '
            Me.Label14.BorderStyle = BorderStyle.FixedSingle
            Me.Label14.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Label14.Location = New Point(567, 77)
            Me.Label14.Margin = New Padding(4, 0, 4, 0)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New Size(125, 24)
            Me.Label14.TabIndex = 47
            Me.Label14.Tag = ""
            Me.Label14.Text = "Light Weapon:"
            Me.Label14.TextAlign = ContentAlignment.MiddleRight
            '
            'Label15
            '
            Me.Label15.BorderStyle = BorderStyle.FixedSingle
            Me.Label15.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Label15.Location = New Point(567, 107)
            Me.Label15.Margin = New Padding(4, 0, 4, 0)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New Size(125, 24)
            Me.Label15.TabIndex = 49
            Me.Label15.Text = "Heavy Weapon:"
            Me.Label15.TextAlign = ContentAlignment.MiddleRight
            '
            'Label16
            '
            Me.Label16.BorderStyle = BorderStyle.FixedSingle
            Me.Label16.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Label16.Location = New Point(567, 137)
            Me.Label16.Margin = New Padding(4, 0, 4, 0)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New Size(125, 24)
            Me.Label16.TabIndex = 51
            Me.Label16.Text = "Two-H Weapon:"
            Me.Label16.TextAlign = ContentAlignment.MiddleRight
            '
            'btnClear
            '
            Me.btnClear.Enabled = False
            Me.btnClear.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnClear.Location = New Point(61, 465)
            Me.btnClear.Margin = New Padding(4)
            Me.btnClear.Name = "btnClear"
            Me.btnClear.Size = New Size(125, 30)
            Me.btnClear.TabIndex = 36
            Me.btnClear.Text = "&Clear"
            Me.btnClear.UseVisualStyleBackColor = True
            '
            'Label18
            '
            Me.Label18.BorderStyle = BorderStyle.FixedSingle
            Me.Label18.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Label18.Location = New Point(567, 227)
            Me.Label18.Margin = New Padding(4, 0, 4, 0)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New Size(125, 24)
            Me.Label18.TabIndex = 57
            Me.Label18.Text = "Lockpicks:"
            Me.Label18.TextAlign = ContentAlignment.MiddleRight
            '
            'txtLockpicks
            '
            Me.txtLockpicks.Enabled = False
            Me.txtLockpicks.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.txtLockpicks.Location = New Point(700, 228)
            Me.txtLockpicks.Margin = New Padding(4)
            Me.txtLockpicks.MaxLength = 2
            Me.txtLockpicks.Name = "txtLockpicks"
            Me.txtLockpicks.Size = New Size(60, 22)
            Me.txtLockpicks.TabIndex = 19
            Me.txtLockpicks.TextAlign = HorizontalAlignment.Center
            '
            'Label17
            '
            Me.Label17.BorderStyle = BorderStyle.FixedSingle
            Me.Label17.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Label17.Location = New Point(251, 107)
            Me.Label17.Margin = New Padding(4, 0, 4, 0)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New Size(125, 24)
            Me.Label17.TabIndex = 59
            Me.Label17.Text = "Confirm Pass:"
            Me.Label17.TextAlign = ContentAlignment.MiddleRight
            '
            'txtConfPass
            '
            Me.txtConfPass.Enabled = False
            Me.txtConfPass.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.txtConfPass.Location = New Point(384, 108)
            Me.txtConfPass.Margin = New Padding(4)
            Me.txtConfPass.MaxLength = 16
            Me.txtConfPass.Name = "txtConfPass"
            Me.txtConfPass.Size = New Size(100, 22)
            Me.txtConfPass.TabIndex = 3
            Me.txtConfPass.TextAlign = HorizontalAlignment.Center
            Me.txtConfPass.UseSystemPasswordChar = True
            '
            'Label19
            '
            Me.Label19.BorderStyle = BorderStyle.FixedSingle
            Me.Label19.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.Label19.Location = New Point(251, 17)
            Me.Label19.Margin = New Padding(4, 0, 4, 0)
            Me.Label19.Name = "Label19"
            Me.Label19.Size = New Size(308, 24)
            Me.Label19.TabIndex = 60
            Me.Label19.Text = "Login Information:"
            Me.Label19.TextAlign = ContentAlignment.MiddleCenter
            '
            'Label20
            '
            Me.Label20.BorderStyle = BorderStyle.FixedSingle
            Me.Label20.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.Label20.Location = New Point(251, 275)
            Me.Label20.Margin = New Padding(4, 0, 4, 0)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New Size(308, 24)
            Me.Label20.TabIndex = 61
            Me.Label20.Text = "Character:"
            Me.Label20.TextAlign = ContentAlignment.MiddleCenter
            '
            'Label21
            '
            Me.Label21.BorderStyle = BorderStyle.FixedSingle
            Me.Label21.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.Label21.Location = New Point(567, 17)
            Me.Label21.Margin = New Padding(4, 0, 4, 0)
            Me.Label21.Name = "Label21"
            Me.Label21.Size = New Size(307, 24)
            Me.Label21.TabIndex = 62
            Me.Label21.Text = "Inventory:"
            Me.Label21.TextAlign = ContentAlignment.MiddleCenter
            '
            'Label22
            '
            Me.Label22.BorderStyle = BorderStyle.FixedSingle
            Me.Label22.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.Label22.Location = New Point(882, 17)
            Me.Label22.Margin = New Padding(4, 0, 4, 0)
            Me.Label22.Name = "Label22"
            Me.Label22.Size = New Size(183, 24)
            Me.Label22.TabIndex = 63
            Me.Label22.Text = "Skills:"
            Me.Label22.TextAlign = ContentAlignment.MiddleCenter
            '
            'Label23
            '
            Me.Label23.BorderStyle = BorderStyle.FixedSingle
            Me.Label23.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Label23.Location = New Point(251, 515)
            Me.Label23.Margin = New Padding(4, 0, 4, 0)
            Me.Label23.Name = "Label23"
            Me.Label23.Size = New Size(125, 24)
            Me.Label23.TabIndex = 64
            Me.Label23.Text = "Hunger:"
            Me.Label23.TextAlign = ContentAlignment.MiddleRight
            '
            'txtHunger
            '
            Me.txtHunger.Enabled = False
            Me.txtHunger.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.txtHunger.Location = New Point(384, 516)
            Me.txtHunger.Margin = New Padding(4)
            Me.txtHunger.MaxLength = 2
            Me.txtHunger.Name = "txtHunger"
            Me.txtHunger.Size = New Size(50, 22)
            Me.txtHunger.TabIndex = 11
            Me.txtHunger.TextAlign = HorizontalAlignment.Center
            '
            'Label24
            '
            Me.Label24.BorderStyle = BorderStyle.FixedSingle
            Me.Label24.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Label24.Location = New Point(251, 545)
            Me.Label24.Margin = New Padding(4, 0, 4, 0)
            Me.Label24.Name = "Label24"
            Me.Label24.Size = New Size(125, 24)
            Me.Label24.TabIndex = 66
            Me.Label24.Text = "Thirst:"
            Me.Label24.TextAlign = ContentAlignment.MiddleRight
            '
            'txtThirst
            '
            Me.txtThirst.Enabled = False
            Me.txtThirst.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.txtThirst.Location = New Point(384, 546)
            Me.txtThirst.Margin = New Padding(4)
            Me.txtThirst.MaxLength = 2
            Me.txtThirst.Name = "txtThirst"
            Me.txtThirst.Size = New Size(50, 22)
            Me.txtThirst.TabIndex = 12
            Me.txtThirst.TextAlign = HorizontalAlignment.Center
            '
            'Label25
            '
            Me.Label25.BorderStyle = BorderStyle.FixedSingle
            Me.Label25.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.Label25.Location = New Point(882, 394)
            Me.Label25.Margin = New Padding(4, 0, 4, 0)
            Me.Label25.Name = "Label25"
            Me.Label25.Size = New Size(183, 24)
            Me.Label25.TabIndex = 68
            Me.Label25.Text = "HenchmenLevel:"
            Me.Label25.TextAlign = ContentAlignment.MiddleCenter
            '
            'chkAlive
            '
            Me.chkAlive.AutoSize = True
            Me.chkAlive.Enabled = False
            Me.chkAlive.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.chkAlive.Location = New Point(403, 401)
            Me.chkAlive.Margin = New Padding(4)
            Me.chkAlive.Name = "chkAlive"
            Me.chkAlive.Size = New Size(15, 14)
            Me.chkAlive.TabIndex = 7
            Me.chkAlive.UseVisualStyleBackColor = True
            '
            'cmbCurrWeapon
            '
            Me.cmbCurrWeapon.DropDownStyle = ComboBoxStyle.DropDownList
            Me.cmbCurrWeapon.Enabled = False
            Me.cmbCurrWeapon.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.cmbCurrWeapon.FormattingEnabled = True
            Me.cmbCurrWeapon.Items.AddRange(New Object() {"Light", "Heavy", "Two-H"})
            Me.cmbCurrWeapon.Location = New Point(699, 47)
            Me.cmbCurrWeapon.Name = "cmbCurrWeapon"
            Me.cmbCurrWeapon.Size = New Size(101, 24)
            Me.cmbCurrWeapon.TabIndex = 13
            '
            'cmbLoc
            '
            Me.cmbLoc.DropDownStyle = ComboBoxStyle.DropDownList
            Me.cmbLoc.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.cmbLoc.FormattingEnabled = True
            Me.cmbLoc.Items.AddRange(New Object() {"Streets", "Inn", "Guild", "Jail"})
            Me.cmbLoc.Location = New Point(383, 425)
            Me.cmbLoc.Name = "cmbLoc"
            Me.cmbLoc.Size = New Size(101, 24)
            Me.cmbLoc.TabIndex = 8
            '
            'cmbLightWeapon
            '
            Me.cmbLightWeapon.DropDownStyle = ComboBoxStyle.DropDownList
            Me.cmbLightWeapon.Enabled = False
            Me.cmbLightWeapon.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.cmbLightWeapon.FormattingEnabled = True
            Me.cmbLightWeapon.Location = New Point(699, 77)
            Me.cmbLightWeapon.Name = "cmbLightWeapon"
            Me.cmbLightWeapon.Size = New Size(175, 24)
            Me.cmbLightWeapon.TabIndex = 14
            '
            'cmbHeavyWeapon
            '
            Me.cmbHeavyWeapon.DropDownStyle = ComboBoxStyle.DropDownList
            Me.cmbHeavyWeapon.Enabled = False
            Me.cmbHeavyWeapon.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.cmbHeavyWeapon.FormattingEnabled = True
            Me.cmbHeavyWeapon.Location = New Point(699, 108)
            Me.cmbHeavyWeapon.Name = "cmbHeavyWeapon"
            Me.cmbHeavyWeapon.Size = New Size(175, 24)
            Me.cmbHeavyWeapon.TabIndex = 15
            '
            'cmbTwoHWeapon
            '
            Me.cmbTwoHWeapon.DropDownStyle = ComboBoxStyle.DropDownList
            Me.cmbTwoHWeapon.Enabled = False
            Me.cmbTwoHWeapon.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.cmbTwoHWeapon.FormattingEnabled = True
            Me.cmbTwoHWeapon.Location = New Point(699, 138)
            Me.cmbTwoHWeapon.Name = "cmbTwoHWeapon"
            Me.cmbTwoHWeapon.Size = New Size(175, 24)
            Me.cmbTwoHWeapon.TabIndex = 16
            '
            'cmbArmor
            '
            Me.cmbArmor.DropDownStyle = ComboBoxStyle.DropDownList
            Me.cmbArmor.Enabled = False
            Me.cmbArmor.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.cmbArmor.FormattingEnabled = True
            Me.cmbArmor.Location = New Point(699, 168)
            Me.cmbArmor.Name = "cmbArmor"
            Me.cmbArmor.Size = New Size(175, 24)
            Me.cmbArmor.TabIndex = 17
            '
            'cmbPotion
            '
            Me.cmbPotion.DropDownStyle = ComboBoxStyle.DropDownList
            Me.cmbPotion.Enabled = False
            Me.cmbPotion.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.cmbPotion.FormattingEnabled = True
            Me.cmbPotion.Location = New Point(699, 198)
            Me.cmbPotion.Name = "cmbPotion"
            Me.cmbPotion.Size = New Size(175, 24)
            Me.cmbPotion.TabIndex = 18
            '
            'chkShovel
            '
            Me.chkShovel.AutoSize = True
            Me.chkShovel.Enabled = False
            Me.chkShovel.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.chkShovel.Location = New Point(722, 353)
            Me.chkShovel.Margin = New Padding(4)
            Me.chkShovel.Name = "chkShovel"
            Me.chkShovel.Size = New Size(15, 14)
            Me.chkShovel.TabIndex = 69
            Me.chkShovel.UseVisualStyleBackColor = True
            '
            'lblShovel
            '
            Me.lblShovel.BorderStyle = BorderStyle.FixedSingle
            Me.lblShovel.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblShovel.Location = New Point(567, 347)
            Me.lblShovel.Margin = New Padding(4, 0, 4, 0)
            Me.lblShovel.Name = "lblShovel"
            Me.lblShovel.Size = New Size(125, 24)
            Me.lblShovel.TabIndex = 70
            Me.lblShovel.Text = "Shovel:"
            Me.lblShovel.TextAlign = ContentAlignment.MiddleRight
            '
            'chkLantern
            '
            Me.chkLantern.AutoSize = True
            Me.chkLantern.Enabled = False
            Me.chkLantern.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.chkLantern.Location = New Point(722, 383)
            Me.chkLantern.Margin = New Padding(4)
            Me.chkLantern.Name = "chkLantern"
            Me.chkLantern.Size = New Size(15, 14)
            Me.chkLantern.TabIndex = 71
            Me.chkLantern.UseVisualStyleBackColor = True
            '
            'lblLantern
            '
            Me.lblLantern.BorderStyle = BorderStyle.FixedSingle
            Me.lblLantern.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblLantern.Location = New Point(567, 377)
            Me.lblLantern.Margin = New Padding(4, 0, 4, 0)
            Me.lblLantern.Name = "lblLantern"
            Me.lblLantern.Size = New Size(125, 24)
            Me.lblLantern.TabIndex = 72
            Me.lblLantern.Text = "Lantern:"
            Me.lblLantern.TextAlign = ContentAlignment.MiddleRight
            '
            'chkAmulet
            '
            Me.chkAmulet.AutoSize = True
            Me.chkAmulet.Enabled = False
            Me.chkAmulet.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.chkAmulet.Location = New Point(722, 413)
            Me.chkAmulet.Margin = New Padding(4)
            Me.chkAmulet.Name = "chkAmulet"
            Me.chkAmulet.Size = New Size(15, 14)
            Me.chkAmulet.TabIndex = 73
            Me.chkAmulet.UseVisualStyleBackColor = True
            '
            'lblAmulet
            '
            Me.lblAmulet.BorderStyle = BorderStyle.FixedSingle
            Me.lblAmulet.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblAmulet.Location = New Point(567, 407)
            Me.lblAmulet.Margin = New Padding(4, 0, 4, 0)
            Me.lblAmulet.Name = "lblAmulet"
            Me.lblAmulet.Size = New Size(125, 24)
            Me.lblAmulet.TabIndex = 74
            Me.lblAmulet.Text = "Amulet:"
            Me.lblAmulet.TextAlign = ContentAlignment.MiddleRight
            '
            'frmAdminUsers
            '
            Me.AutoScaleDimensions = New SizeF(9.0!, 18.0!)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.CancelButton = Me.btnExit
            Me.ClientSize = New Size(1141, 583)
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
            Me.Controls.Add(Me.txtHenchmenLevel1)
            Me.Controls.Add(Me.txtHenchmenLevel2)
            Me.Controls.Add(Me.txtHenchmenLevel3)
            Me.Controls.Add(Me.txtHenchmenLevel4)
            Me.Controls.Add(Me.txtHenchmenLevel5)
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
            Me.Controls.Add(Me.txtMaximumEndurance)
            Me.Controls.Add(Me.txtCurrentEndurance)
            Me.Controls.Add(Me.txtGoldLoan)
            Me.Controls.Add(Me.txtGoldBank)
            Me.Controls.Add(Me.txtSkillPts)
            Me.Controls.Add(Me.lblHenchmenLevel5)
            Me.Controls.Add(Me.lblHenchmenLevel4)
            Me.Controls.Add(Me.lblHenchmenLevel3)
            Me.Controls.Add(Me.lblHenchmenLevel2)
            Me.Controls.Add(Me.txtName)
            Me.Controls.Add(Me.lblLocation)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.lblHenchmenLevel1)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.lblAlive)
            Me.Controls.Add(Me.lblExp)
            Me.Controls.Add(Me.lblSkillPts)
            Me.Controls.Add(Me.lblCurrentEndurance)
            Me.Controls.Add(Me.lblMaximumEndurance)
            Me.Controls.Add(Me.lblLevel)
            Me.Controls.Add(Me.lblName)
            Me.Controls.Add(Me.lstUsers)
            Me.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Margin = New Padding(4)
            Me.MaximizeBox = False
            Me.MinimumSize = New Size(970, 622)
            Me.Name = "frmAdminUsers"
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.Text = "Admin Users"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents LstUsers As ListBox
        Friend WithEvents lblName As Label
        Friend WithEvents lblLevel As Label
        Friend WithEvents lblMaximumEndurance As Label
        Friend WithEvents lblCurrentEndurance As Label
        Friend WithEvents lblSkillPts As Label
        Friend WithEvents lblExp As Label
        Friend WithEvents lblAlive As Label
        Friend WithEvents Label1 As Label
        Friend WithEvents lblHenchmenLevel1 As Label
        Friend WithEvents Label3 As Label
        Friend WithEvents Label4 As Label
        Friend WithEvents lblLocation As Label
        Friend WithEvents TxtName As TextBox
        Friend WithEvents lblHenchmenLevel2 As Label
        Friend WithEvents lblHenchmenLevel3 As Label
        Friend WithEvents lblHenchmenLevel4 As Label
        Friend WithEvents lblHenchmenLevel5 As Label
        Friend WithEvents TxtSkillPts As TextBox
        Friend WithEvents TxtGoldBank As TextBox
        Friend WithEvents TxtGoldLoan As TextBox
        Friend WithEvents TxtCurrentEndurance As TextBox
        Friend WithEvents TxtMaximumEndurance As TextBox
        Friend WithEvents TxtExp As TextBox
        Friend WithEvents TxtLevel As TextBox
        Friend WithEvents TxtTwoH As TextBox
        Friend WithEvents Label2 As Label
        Friend WithEvents Label5 As Label
        Friend WithEvents Label6 As Label
        Friend WithEvents Label7 As Label
        Friend WithEvents Label8 As Label
        Friend WithEvents Label9 As Label
        Friend WithEvents Label10 As Label
        Friend WithEvents Label11 As Label
        Friend WithEvents Label12 As Label
        Friend WithEvents TxtGoldHand As TextBox
        Friend WithEvents TxtHeavy As TextBox
        Friend WithEvents TxtLight As TextBox
        Friend WithEvents TxtBlocking As TextBox
        Friend WithEvents TxtHenchmenLevel5 As TextBox
        Friend WithEvents TxtHenchmenLevel4 As TextBox
        Friend WithEvents TxtHenchmenLevel3 As TextBox
        Friend WithEvents TxtHenchmenLevel2 As TextBox
        Friend WithEvents TxtHenchmenLevel1 As TextBox
        Friend WithEvents TxtStealth As TextBox
        Friend WithEvents TxtSlipping As TextBox
        Friend WithEvents BtnSave As Button
        Friend WithEvents BtnExit As Button
        Friend WithEvents BtnNewUser As Button
        Friend WithEvents BtnDelete As Button
        Friend WithEvents lblPass As Label
        Friend WithEvents TxtChangePass As TextBox
        Friend WithEvents Label14 As Label
        Friend WithEvents Label15 As Label
        Friend WithEvents Label16 As Label
        Friend WithEvents BtnClear As Button
        Friend WithEvents Label18 As Label
        Friend WithEvents TxtLockpicks As TextBox
        Friend WithEvents Label17 As Label
        Friend WithEvents TxtConfPass As TextBox
        Friend WithEvents Label19 As Label
        Friend WithEvents Label20 As Label
        Friend WithEvents Label21 As Label
        Friend WithEvents Label22 As Label
        Friend WithEvents Label23 As Label
        Friend WithEvents TxtHunger As TextBox
        Friend WithEvents Label24 As Label
        Friend WithEvents TxtThirst As TextBox
        Friend WithEvents Label25 As Label
        Friend WithEvents chkAlive As CheckBox
        Friend WithEvents CmbCurrWeapon As ComboBox
        Friend WithEvents CmbLoc As ComboBox
        Friend WithEvents CmbLightWeapon As ComboBox
        Friend WithEvents CmbHeavyWeapon As ComboBox
        Friend WithEvents CmbTwoHWeapon As ComboBox
        Friend WithEvents CmbArmor As ComboBox
        Friend WithEvents CmbPotion As ComboBox
        Friend WithEvents chkShovel As CheckBox
        Friend WithEvents lblShovel As Label
        Friend WithEvents chkLantern As CheckBox
        Friend WithEvents lblLantern As Label
        Friend WithEvents chkAmulet As CheckBox
        Friend WithEvents lblAmulet As Label
    End Class
End NameSpace