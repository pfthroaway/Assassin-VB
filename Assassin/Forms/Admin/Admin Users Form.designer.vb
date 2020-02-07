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
            Me.LstUsers = New ListBox()
            Me.LblName = New Label()
            Me.LblLevel = New Label()
            Me.LblMaximumEndurance = New Label()
            Me.LblCurrentEndurance = New Label()
            Me.LblSkillPts = New Label()
            Me.LblExp = New Label()
            Me.LblAlive = New Label()
            Me.Label1 = New Label()
            Me.LblHenchmenLevel1 = New Label()
            Me.Label3 = New Label()
            Me.Label4 = New Label()
            Me.LblLocation = New Label()
            Me.txtName = New TextBox()
            Me.LblHenchmenLevel2 = New Label()
            Me.LblHenchmenLevel3 = New Label()
            Me.LblHenchmenLevel4 = New Label()
            Me.LblHenchmenLevel5 = New Label()
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
            Me.BtnSave = New Button()
            Me.BtnExit = New Button()
            Me.BtnNewUser = New Button()
            Me.BtnDelete = New Button()
            Me.LblPass = New Label()
            Me.txtChangePass = New TextBox()
            Me.Label14 = New Label()
            Me.Label15 = New Label()
            Me.Label16 = New Label()
            Me.BtnClear = New Button()
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
            Me.CmbCurrWeapon = New ComboBox()
            Me.CmbLoc = New ComboBox()
            Me.CmbLightWeapon = New ComboBox()
            Me.CmbHeavyWeapon = New ComboBox()
            Me.CmbTwoHWeapon = New ComboBox()
            Me.CmbArmor = New ComboBox()
            Me.CmbPotion = New ComboBox()
            Me.chkShovel = New CheckBox()
            Me.LblShovel = New Label()
            Me.chkLantern = New CheckBox()
            Me.LblLantern = New Label()
            Me.chkAmulet = New CheckBox()
            Me.LblAmulet = New Label()
            Me.SuspendLayout()
            '
            'LstUsers
            '
            Me.LstUsers.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.LstUsers.FormattingEnabled = True
            Me.LstUsers.ItemHeight = 18
            Me.LstUsers.Location = New Point(18, 17)
            Me.LstUsers.Margin = New Padding(4)
            Me.LstUsers.Name = "LstUsers"
            Me.LstUsers.ScrollAlwaysVisible = True
            Me.LstUsers.Size = New Size(225, 364)
            Me.LstUsers.Sorted = True
            Me.LstUsers.TabIndex = 0
            '
            'LblName
            '
            Me.LblName.BorderStyle = BorderStyle.FixedSingle
            Me.LblName.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.LblName.Location = New Point(251, 47)
            Me.LblName.Margin = New Padding(4, 0, 4, 0)
            Me.LblName.Name = "LblName"
            Me.LblName.Size = New Size(125, 24)
            Me.LblName.TabIndex = 2
            Me.LblName.Text = "Name:"
            Me.LblName.TextAlign = ContentAlignment.MiddleRight
            '
            'LblLevel
            '
            Me.LblLevel.BorderStyle = BorderStyle.FixedSingle
            Me.LblLevel.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.LblLevel.Location = New Point(251, 305)
            Me.LblLevel.Margin = New Padding(4, 0, 4, 0)
            Me.LblLevel.Name = "LblLevel"
            Me.LblLevel.Size = New Size(125, 24)
            Me.LblLevel.TabIndex = 3
            Me.LblLevel.Text = "Level:"
            Me.LblLevel.TextAlign = ContentAlignment.MiddleRight
            '
            'LblMaximumEndurance
            '
            Me.LblMaximumEndurance.BorderStyle = BorderStyle.FixedSingle
            Me.LblMaximumEndurance.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.LblMaximumEndurance.Location = New Point(251, 485)
            Me.LblMaximumEndurance.Margin = New Padding(4, 0, 4, 0)
            Me.LblMaximumEndurance.Name = "LblMaximumEndurance"
            Me.LblMaximumEndurance.Size = New Size(125, 24)
            Me.LblMaximumEndurance.TabIndex = 4
            Me.LblMaximumEndurance.Text = "Max Endurance:"
            Me.LblMaximumEndurance.TextAlign = ContentAlignment.MiddleRight
            '
            'LblCurrentEndurance
            '
            Me.LblCurrentEndurance.BorderStyle = BorderStyle.FixedSingle
            Me.LblCurrentEndurance.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.LblCurrentEndurance.Location = New Point(251, 455)
            Me.LblCurrentEndurance.Margin = New Padding(4, 0, 4, 0)
            Me.LblCurrentEndurance.Name = "LblCurrentEndurance"
            Me.LblCurrentEndurance.Size = New Size(125, 24)
            Me.LblCurrentEndurance.TabIndex = 5
            Me.LblCurrentEndurance.Text = "Curr Endurance:"
            Me.LblCurrentEndurance.TextAlign = ContentAlignment.MiddleRight
            '
            'LblSkillPts
            '
            Me.LblSkillPts.BorderStyle = BorderStyle.FixedSingle
            Me.LblSkillPts.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.LblSkillPts.Location = New Point(251, 365)
            Me.LblSkillPts.Margin = New Padding(4, 0, 4, 0)
            Me.LblSkillPts.Name = "LblSkillPts"
            Me.LblSkillPts.Size = New Size(125, 24)
            Me.LblSkillPts.TabIndex = 6
            Me.LblSkillPts.Text = "Skill Points:"
            Me.LblSkillPts.TextAlign = ContentAlignment.MiddleRight
            '
            'LblExp
            '
            Me.LblExp.BorderStyle = BorderStyle.FixedSingle
            Me.LblExp.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.LblExp.Location = New Point(251, 335)
            Me.LblExp.Margin = New Padding(4, 0, 4, 0)
            Me.LblExp.Name = "LblExp"
            Me.LblExp.Size = New Size(125, 24)
            Me.LblExp.TabIndex = 7
            Me.LblExp.Text = "Experience:"
            Me.LblExp.TextAlign = ContentAlignment.MiddleRight
            '
            'LblAlive
            '
            Me.LblAlive.BorderStyle = BorderStyle.FixedSingle
            Me.LblAlive.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.LblAlive.Location = New Point(251, 395)
            Me.LblAlive.Margin = New Padding(4, 0, 4, 0)
            Me.LblAlive.Name = "LblAlive"
            Me.LblAlive.Size = New Size(125, 24)
            Me.LblAlive.TabIndex = 8
            Me.LblAlive.Text = "Alive:"
            Me.LblAlive.TextAlign = ContentAlignment.MiddleRight
            '
            'Label1
            '
            Me.Label1.BorderStyle = BorderStyle.FixedSingle
            Me.Label1.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New Point(882, 167)
            Me.Label1.Margin = New Padding(4, 0, 4, 0)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New Size(125, 24)
            Me.Label1.TabIndex = 9
            Me.Label1.Text = "Slipping:"
            Me.Label1.TextAlign = ContentAlignment.MiddleRight
            '
            'LblHenchmenLevel1
            '
            Me.LblHenchmenLevel1.BorderStyle = BorderStyle.FixedSingle
            Me.LblHenchmenLevel1.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.LblHenchmenLevel1.Location = New Point(882, 424)
            Me.LblHenchmenLevel1.Margin = New Padding(4, 0, 4, 0)
            Me.LblHenchmenLevel1.Name = "LblHenchmenLevel1"
            Me.LblHenchmenLevel1.Size = New Size(125, 24)
            Me.LblHenchmenLevel1.TabIndex = 10
            Me.LblHenchmenLevel1.Text = "Lvl 1 Henchmen:"
            Me.LblHenchmenLevel1.TextAlign = ContentAlignment.MiddleRight
            '
            'Label3
            '
            Me.Label3.BorderStyle = BorderStyle.FixedSingle
            Me.Label3.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
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
            Me.Label4.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New Point(567, 47)
            Me.Label4.Margin = New Padding(4, 0, 4, 0)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New Size(125, 24)
            Me.Label4.TabIndex = 12
            Me.Label4.Text = "Current Weapon:"
            Me.Label4.TextAlign = ContentAlignment.MiddleRight
            '
            'LblLocation
            '
            Me.LblLocation.BorderStyle = BorderStyle.FixedSingle
            Me.LblLocation.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.LblLocation.Location = New Point(251, 425)
            Me.LblLocation.Margin = New Padding(4, 0, 4, 0)
            Me.LblLocation.Name = "LblLocation"
            Me.LblLocation.Size = New Size(125, 24)
            Me.LblLocation.TabIndex = 13
            Me.LblLocation.Text = "Location:"
            Me.LblLocation.TextAlign = ContentAlignment.MiddleRight
            '
            'txtName
            '
            Me.txtName.Enabled = False
            Me.txtName.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.txtName.Location = New Point(384, 48)
            Me.txtName.Margin = New Padding(4)
            Me.txtName.MaxLength = 30
            Me.txtName.Name = "txtName"
            Me.txtName.Size = New Size(175, 22)
            Me.txtName.TabIndex = 1
            Me.txtName.TextAlign = HorizontalAlignment.Center
            '
            'LblHenchmenLevel2
            '
            Me.LblHenchmenLevel2.BorderStyle = BorderStyle.FixedSingle
            Me.LblHenchmenLevel2.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.LblHenchmenLevel2.Location = New Point(882, 454)
            Me.LblHenchmenLevel2.Margin = New Padding(4, 0, 4, 0)
            Me.LblHenchmenLevel2.Name = "LblHenchmenLevel2"
            Me.LblHenchmenLevel2.Size = New Size(125, 24)
            Me.LblHenchmenLevel2.TabIndex = 15
            Me.LblHenchmenLevel2.Text = "Lvl 2 Henchmen:"
            Me.LblHenchmenLevel2.TextAlign = ContentAlignment.MiddleRight
            '
            'LblHenchmenLevel3
            '
            Me.LblHenchmenLevel3.BorderStyle = BorderStyle.FixedSingle
            Me.LblHenchmenLevel3.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.LblHenchmenLevel3.Location = New Point(882, 484)
            Me.LblHenchmenLevel3.Margin = New Padding(4, 0, 4, 0)
            Me.LblHenchmenLevel3.Name = "LblHenchmenLevel3"
            Me.LblHenchmenLevel3.Size = New Size(125, 24)
            Me.LblHenchmenLevel3.TabIndex = 16
            Me.LblHenchmenLevel3.Text = "Lvl 3 Henchmen:"
            Me.LblHenchmenLevel3.TextAlign = ContentAlignment.MiddleRight
            '
            'LblHenchmenLevel4
            '
            Me.LblHenchmenLevel4.BorderStyle = BorderStyle.FixedSingle
            Me.LblHenchmenLevel4.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.LblHenchmenLevel4.Location = New Point(882, 515)
            Me.LblHenchmenLevel4.Margin = New Padding(4, 0, 4, 0)
            Me.LblHenchmenLevel4.Name = "LblHenchmenLevel4"
            Me.LblHenchmenLevel4.Size = New Size(125, 24)
            Me.LblHenchmenLevel4.TabIndex = 17
            Me.LblHenchmenLevel4.Text = "Lvl 4 Henchmen:"
            Me.LblHenchmenLevel4.TextAlign = ContentAlignment.MiddleRight
            '
            'LblHenchmenLevel5
            '
            Me.LblHenchmenLevel5.BorderStyle = BorderStyle.FixedSingle
            Me.LblHenchmenLevel5.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.LblHenchmenLevel5.Location = New Point(882, 545)
            Me.LblHenchmenLevel5.Margin = New Padding(4, 0, 4, 0)
            Me.LblHenchmenLevel5.Name = "LblHenchmenLevel5"
            Me.LblHenchmenLevel5.Size = New Size(125, 24)
            Me.LblHenchmenLevel5.TabIndex = 18
            Me.LblHenchmenLevel5.Text = "Lvl 5 Henchmen:"
            Me.LblHenchmenLevel5.TextAlign = ContentAlignment.MiddleRight
            '
            'txtSkillPts
            '
            Me.txtSkillPts.Enabled = False
            Me.txtSkillPts.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
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
            Me.txtGoldBank.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
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
            Me.txtGoldLoan.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
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
            Me.txtCurrentEndurance.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
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
            Me.txtMaximumEndurance.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
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
            Me.txtExp.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
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
            Me.txtLevel.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
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
            Me.txtTwoH.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
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
            Me.Label2.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
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
            Me.Label5.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
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
            Me.Label6.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
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
            Me.Label7.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
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
            Me.Label8.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
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
            Me.Label9.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
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
            Me.Label10.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
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
            Me.Label11.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
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
            Me.Label12.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
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
            Me.txtGoldHand.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
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
            Me.txtHeavy.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
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
            Me.txtLight.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
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
            Me.txtBlocking.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
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
            Me.txtHenchmenLevel5.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
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
            Me.txtHenchmenLevel4.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
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
            Me.txtHenchmenLevel3.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
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
            Me.txtHenchmenLevel2.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
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
            Me.txtHenchmenLevel1.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
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
            Me.txtStealth.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
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
            Me.txtSlipping.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.txtSlipping.Location = New Point(1015, 168)
            Me.txtSlipping.Margin = New Padding(4)
            Me.txtSlipping.MaxLength = 2
            Me.txtSlipping.Name = "txtSlipping"
            Me.txtSlipping.Size = New Size(50, 22)
            Me.txtSlipping.TabIndex = 27
            Me.txtSlipping.TextAlign = HorizontalAlignment.Center
            '
            'BtnSave
            '
            Me.BtnSave.Enabled = False
            Me.BtnSave.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnSave.Location = New Point(61, 503)
            Me.BtnSave.Margin = New Padding(4)
            Me.BtnSave.Name = "BtnSave"
            Me.BtnSave.Size = New Size(125, 30)
            Me.BtnSave.TabIndex = 37
            Me.BtnSave.Text = "&Save"
            Me.BtnSave.UseVisualStyleBackColor = True
            '
            'BtnExit
            '
            Me.BtnExit.DialogResult = DialogResult.Cancel
            Me.BtnExit.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnExit.Location = New Point(61, 541)
            Me.BtnExit.Margin = New Padding(4)
            Me.BtnExit.Name = "BtnExit"
            Me.BtnExit.Size = New Size(125, 30)
            Me.BtnExit.TabIndex = 38
            Me.BtnExit.Text = "E&xit"
            Me.BtnExit.UseVisualStyleBackColor = True
            '
            'BtnNewUser
            '
            Me.BtnNewUser.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnNewUser.Location = New Point(61, 389)
            Me.BtnNewUser.Margin = New Padding(4)
            Me.BtnNewUser.Name = "BtnNewUser"
            Me.BtnNewUser.Size = New Size(125, 30)
            Me.BtnNewUser.TabIndex = 34
            Me.BtnNewUser.Text = "&New User"
            Me.BtnNewUser.UseVisualStyleBackColor = True
            '
            'BtnDelete
            '
            Me.BtnDelete.Enabled = False
            Me.BtnDelete.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnDelete.Location = New Point(61, 427)
            Me.BtnDelete.Margin = New Padding(4)
            Me.BtnDelete.Name = "BtnDelete"
            Me.BtnDelete.Size = New Size(125, 30)
            Me.BtnDelete.TabIndex = 35
            Me.BtnDelete.Text = "&Delete User"
            Me.BtnDelete.UseVisualStyleBackColor = True
            '
            'LblPass
            '
            Me.LblPass.BorderStyle = BorderStyle.FixedSingle
            Me.LblPass.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.LblPass.Location = New Point(251, 77)
            Me.LblPass.Margin = New Padding(4, 0, 4, 0)
            Me.LblPass.Name = "LblPass"
            Me.LblPass.Size = New Size(125, 24)
            Me.LblPass.TabIndex = 46
            Me.LblPass.Text = "Password:"
            Me.LblPass.TextAlign = ContentAlignment.MiddleRight
            '
            'txtChangePass
            '
            Me.txtChangePass.Enabled = False
            Me.txtChangePass.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
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
            Me.Label14.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
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
            Me.Label15.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
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
            Me.Label16.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Label16.Location = New Point(567, 137)
            Me.Label16.Margin = New Padding(4, 0, 4, 0)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New Size(125, 24)
            Me.Label16.TabIndex = 51
            Me.Label16.Text = "Two-H Weapon:"
            Me.Label16.TextAlign = ContentAlignment.MiddleRight
            '
            'BtnClear
            '
            Me.BtnClear.Enabled = False
            Me.BtnClear.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnClear.Location = New Point(61, 465)
            Me.BtnClear.Margin = New Padding(4)
            Me.BtnClear.Name = "BtnClear"
            Me.BtnClear.Size = New Size(125, 30)
            Me.BtnClear.TabIndex = 36
            Me.BtnClear.Text = "&Clear"
            Me.BtnClear.UseVisualStyleBackColor = True
            '
            'Label18
            '
            Me.Label18.BorderStyle = BorderStyle.FixedSingle
            Me.Label18.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
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
            Me.txtLockpicks.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
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
            Me.Label17.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
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
            Me.txtConfPass.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
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
            Me.Label23.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
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
            Me.txtHunger.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
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
            Me.Label24.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
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
            Me.txtThirst.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
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
            'CmbCurrWeapon
            '
            Me.CmbCurrWeapon.DropDownStyle = ComboBoxStyle.DropDownList
            Me.CmbCurrWeapon.Enabled = False
            Me.CmbCurrWeapon.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.CmbCurrWeapon.FormattingEnabled = True
            Me.CmbCurrWeapon.Items.AddRange(New Object() {"Light", "Heavy", "Two-H"})
            Me.CmbCurrWeapon.Location = New Point(699, 47)
            Me.CmbCurrWeapon.Name = "CmbCurrWeapon"
            Me.CmbCurrWeapon.Size = New Size(101, 24)
            Me.CmbCurrWeapon.TabIndex = 13
            '
            'CmbLoc
            '
            Me.CmbLoc.DropDownStyle = ComboBoxStyle.DropDownList
            Me.CmbLoc.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.CmbLoc.FormattingEnabled = True
            Me.CmbLoc.Items.AddRange(New Object() {"Streets", "Inn", "Guild", "Jail"})
            Me.CmbLoc.Location = New Point(383, 425)
            Me.CmbLoc.Name = "CmbLoc"
            Me.CmbLoc.Size = New Size(101, 24)
            Me.CmbLoc.TabIndex = 8
            '
            'CmbLightWeapon
            '
            Me.CmbLightWeapon.DropDownStyle = ComboBoxStyle.DropDownList
            Me.CmbLightWeapon.Enabled = False
            Me.CmbLightWeapon.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.CmbLightWeapon.FormattingEnabled = True
            Me.CmbLightWeapon.Location = New Point(699, 77)
            Me.CmbLightWeapon.Name = "CmbLightWeapon"
            Me.CmbLightWeapon.Size = New Size(175, 24)
            Me.CmbLightWeapon.TabIndex = 14
            '
            'CmbHeavyWeapon
            '
            Me.CmbHeavyWeapon.DropDownStyle = ComboBoxStyle.DropDownList
            Me.CmbHeavyWeapon.Enabled = False
            Me.CmbHeavyWeapon.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.CmbHeavyWeapon.FormattingEnabled = True
            Me.CmbHeavyWeapon.Location = New Point(699, 108)
            Me.CmbHeavyWeapon.Name = "CmbHeavyWeapon"
            Me.CmbHeavyWeapon.Size = New Size(175, 24)
            Me.CmbHeavyWeapon.TabIndex = 15
            '
            'CmbTwoHWeapon
            '
            Me.CmbTwoHWeapon.DropDownStyle = ComboBoxStyle.DropDownList
            Me.CmbTwoHWeapon.Enabled = False
            Me.CmbTwoHWeapon.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.CmbTwoHWeapon.FormattingEnabled = True
            Me.CmbTwoHWeapon.Location = New Point(699, 138)
            Me.CmbTwoHWeapon.Name = "CmbTwoHWeapon"
            Me.CmbTwoHWeapon.Size = New Size(175, 24)
            Me.CmbTwoHWeapon.TabIndex = 16
            '
            'CmbArmor
            '
            Me.CmbArmor.DropDownStyle = ComboBoxStyle.DropDownList
            Me.CmbArmor.Enabled = False
            Me.CmbArmor.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.CmbArmor.FormattingEnabled = True
            Me.CmbArmor.Location = New Point(699, 168)
            Me.CmbArmor.Name = "CmbArmor"
            Me.CmbArmor.Size = New Size(175, 24)
            Me.CmbArmor.TabIndex = 17
            '
            'CmbPotion
            '
            Me.CmbPotion.DropDownStyle = ComboBoxStyle.DropDownList
            Me.CmbPotion.Enabled = False
            Me.CmbPotion.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.CmbPotion.FormattingEnabled = True
            Me.CmbPotion.Location = New Point(699, 198)
            Me.CmbPotion.Name = "CmbPotion"
            Me.CmbPotion.Size = New Size(175, 24)
            Me.CmbPotion.TabIndex = 18
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
            'LblShovel
            '
            Me.LblShovel.BorderStyle = BorderStyle.FixedSingle
            Me.LblShovel.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.LblShovel.Location = New Point(567, 347)
            Me.LblShovel.Margin = New Padding(4, 0, 4, 0)
            Me.LblShovel.Name = "LblShovel"
            Me.LblShovel.Size = New Size(125, 24)
            Me.LblShovel.TabIndex = 70
            Me.LblShovel.Text = "Shovel:"
            Me.LblShovel.TextAlign = ContentAlignment.MiddleRight
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
            'LblLantern
            '
            Me.LblLantern.BorderStyle = BorderStyle.FixedSingle
            Me.LblLantern.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.LblLantern.Location = New Point(567, 377)
            Me.LblLantern.Margin = New Padding(4, 0, 4, 0)
            Me.LblLantern.Name = "LblLantern"
            Me.LblLantern.Size = New Size(125, 24)
            Me.LblLantern.TabIndex = 72
            Me.LblLantern.Text = "Lantern:"
            Me.LblLantern.TextAlign = ContentAlignment.MiddleRight
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
            'LblAmulet
            '
            Me.LblAmulet.BorderStyle = BorderStyle.FixedSingle
            Me.LblAmulet.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.LblAmulet.Location = New Point(567, 407)
            Me.LblAmulet.Margin = New Padding(4, 0, 4, 0)
            Me.LblAmulet.Name = "LblAmulet"
            Me.LblAmulet.Size = New Size(125, 24)
            Me.LblAmulet.TabIndex = 74
            Me.LblAmulet.Text = "Amulet:"
            Me.LblAmulet.TextAlign = ContentAlignment.MiddleRight
            '
            'frmAdminUsers
            '
            Me.AutoScaleDimensions = New SizeF(9.0!, 18.0!)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.CancelButton = Me.BtnExit
            Me.ClientSize = New Size(1141, 583)
            Me.Controls.Add(Me.chkAmulet)
            Me.Controls.Add(Me.LblAmulet)
            Me.Controls.Add(Me.chkLantern)
            Me.Controls.Add(Me.LblLantern)
            Me.Controls.Add(Me.chkShovel)
            Me.Controls.Add(Me.LblShovel)
            Me.Controls.Add(Me.CmbPotion)
            Me.Controls.Add(Me.CmbArmor)
            Me.Controls.Add(Me.CmbTwoHWeapon)
            Me.Controls.Add(Me.CmbHeavyWeapon)
            Me.Controls.Add(Me.CmbLightWeapon)
            Me.Controls.Add(Me.CmbLoc)
            Me.Controls.Add(Me.CmbCurrWeapon)
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
            Me.Controls.Add(Me.BtnClear)
            Me.Controls.Add(Me.Label16)
            Me.Controls.Add(Me.Label15)
            Me.Controls.Add(Me.Label14)
            Me.Controls.Add(Me.txtChangePass)
            Me.Controls.Add(Me.LblPass)
            Me.Controls.Add(Me.BtnDelete)
            Me.Controls.Add(Me.BtnNewUser)
            Me.Controls.Add(Me.BtnExit)
            Me.Controls.Add(Me.BtnSave)
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
            Me.Controls.Add(Me.LblHenchmenLevel5)
            Me.Controls.Add(Me.LblHenchmenLevel4)
            Me.Controls.Add(Me.LblHenchmenLevel3)
            Me.Controls.Add(Me.LblHenchmenLevel2)
            Me.Controls.Add(Me.txtName)
            Me.Controls.Add(Me.LblLocation)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.LblHenchmenLevel1)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.LblAlive)
            Me.Controls.Add(Me.LblExp)
            Me.Controls.Add(Me.LblSkillPts)
            Me.Controls.Add(Me.LblCurrentEndurance)
            Me.Controls.Add(Me.LblMaximumEndurance)
            Me.Controls.Add(Me.LblLevel)
            Me.Controls.Add(Me.LblName)
            Me.Controls.Add(Me.LstUsers)
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
        Friend WithEvents LblName As Label
        Friend WithEvents LblLevel As Label
        Friend WithEvents LblMaximumEndurance As Label
        Friend WithEvents LblCurrentEndurance As Label
        Friend WithEvents LblSkillPts As Label
        Friend WithEvents LblExp As Label
        Friend WithEvents LblAlive As Label
        Friend WithEvents Label1 As Label
        Friend WithEvents LblHenchmenLevel1 As Label
        Friend WithEvents Label3 As Label
        Friend WithEvents Label4 As Label
        Friend WithEvents LblLocation As Label
        Friend WithEvents TxtName As TextBox
        Friend WithEvents LblHenchmenLevel2 As Label
        Friend WithEvents LblHenchmenLevel3 As Label
        Friend WithEvents LblHenchmenLevel4 As Label
        Friend WithEvents LblHenchmenLevel5 As Label
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
        Friend WithEvents LblPass As Label
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
        Friend WithEvents LblShovel As Label
        Friend WithEvents chkLantern As CheckBox
        Friend WithEvents LblLantern As Label
        Friend WithEvents chkAmulet As CheckBox
        Friend WithEvents LblAmulet As Label
    End Class
End NameSpace