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
            Me.LstUsers = New System.Windows.Forms.ListBox()
            Me.LblName = New System.Windows.Forms.Label()
            Me.LblLevel = New System.Windows.Forms.Label()
            Me.LblMaximumEndurance = New System.Windows.Forms.Label()
            Me.LblCurrentEndurance = New System.Windows.Forms.Label()
            Me.LblSkillPts = New System.Windows.Forms.Label()
            Me.LblExp = New System.Windows.Forms.Label()
            Me.LblAlive = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.LblHenchmenLevel1 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.LblLocation = New System.Windows.Forms.Label()
            Me.TxtName = New System.Windows.Forms.TextBox()
            Me.LblHenchmenLevel2 = New System.Windows.Forms.Label()
            Me.LblHenchmenLevel3 = New System.Windows.Forms.Label()
            Me.LblHenchmenLevel4 = New System.Windows.Forms.Label()
            Me.LblHenchmenLevel5 = New System.Windows.Forms.Label()
            Me.TxtSkillPts = New System.Windows.Forms.TextBox()
            Me.TxtGoldBank = New System.Windows.Forms.TextBox()
            Me.TxtGoldLoan = New System.Windows.Forms.TextBox()
            Me.TxtCurrentEndurance = New System.Windows.Forms.TextBox()
            Me.TxtMaximumEndurance = New System.Windows.Forms.TextBox()
            Me.TxtExp = New System.Windows.Forms.TextBox()
            Me.TxtLevel = New System.Windows.Forms.TextBox()
            Me.TxtTwoH = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.TxtGoldHand = New System.Windows.Forms.TextBox()
            Me.TxtHeavy = New System.Windows.Forms.TextBox()
            Me.TxtLight = New System.Windows.Forms.TextBox()
            Me.TxtBlocking = New System.Windows.Forms.TextBox()
            Me.TxtHenchmenLevel5 = New System.Windows.Forms.TextBox()
            Me.TxtHenchmenLevel4 = New System.Windows.Forms.TextBox()
            Me.TxtHenchmenLevel3 = New System.Windows.Forms.TextBox()
            Me.TxtHenchmenLevel2 = New System.Windows.Forms.TextBox()
            Me.TxtHenchmenLevel1 = New System.Windows.Forms.TextBox()
            Me.TxtStealth = New System.Windows.Forms.TextBox()
            Me.TxtSlipping = New System.Windows.Forms.TextBox()
            Me.BtnSave = New System.Windows.Forms.Button()
            Me.BtnExit = New System.Windows.Forms.Button()
            Me.BtnNewUser = New System.Windows.Forms.Button()
            Me.BtnDelete = New System.Windows.Forms.Button()
            Me.LblPass = New System.Windows.Forms.Label()
            Me.TxtChangePass = New System.Windows.Forms.TextBox()
            Me.Label14 = New System.Windows.Forms.Label()
            Me.Label15 = New System.Windows.Forms.Label()
            Me.Label16 = New System.Windows.Forms.Label()
            Me.BtnClear = New System.Windows.Forms.Button()
            Me.Label18 = New System.Windows.Forms.Label()
            Me.TxtLockpicks = New System.Windows.Forms.TextBox()
            Me.Label17 = New System.Windows.Forms.Label()
            Me.TxtConfPass = New System.Windows.Forms.TextBox()
            Me.Label19 = New System.Windows.Forms.Label()
            Me.Label20 = New System.Windows.Forms.Label()
            Me.Label21 = New System.Windows.Forms.Label()
            Me.Label22 = New System.Windows.Forms.Label()
            Me.Label23 = New System.Windows.Forms.Label()
            Me.TxtHunger = New System.Windows.Forms.TextBox()
            Me.Label24 = New System.Windows.Forms.Label()
            Me.TxtThirst = New System.Windows.Forms.TextBox()
            Me.Label25 = New System.Windows.Forms.Label()
            Me.chkAlive = New System.Windows.Forms.CheckBox()
            Me.CmbCurrWeapon = New System.Windows.Forms.ComboBox()
            Me.CmbLoc = New System.Windows.Forms.ComboBox()
            Me.CmbLightWeapon = New System.Windows.Forms.ComboBox()
            Me.CmbHeavyWeapon = New System.Windows.Forms.ComboBox()
            Me.CmbTwoHWeapon = New System.Windows.Forms.ComboBox()
            Me.CmbArmor = New System.Windows.Forms.ComboBox()
            Me.CmbPotion = New System.Windows.Forms.ComboBox()
            Me.chkShovel = New System.Windows.Forms.CheckBox()
            Me.LblShovel = New System.Windows.Forms.Label()
            Me.chkLantern = New System.Windows.Forms.CheckBox()
            Me.LblLantern = New System.Windows.Forms.Label()
            Me.chkAmulet = New System.Windows.Forms.CheckBox()
            Me.LblAmulet = New System.Windows.Forms.Label()
            Me.SuspendLayout()
            '
            'LstUsers
            '
            Me.LstUsers.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LstUsers.FormattingEnabled = True
            Me.LstUsers.ItemHeight = 18
            Me.LstUsers.Location = New System.Drawing.Point(13, 13)
            Me.LstUsers.Margin = New System.Windows.Forms.Padding(4)
            Me.LstUsers.Name = "LstUsers"
            Me.LstUsers.ScrollAlwaysVisible = True
            Me.LstUsers.Size = New System.Drawing.Size(225, 364)
            Me.LstUsers.Sorted = True
            Me.LstUsers.TabIndex = 0
            '
            'LblName
            '
            Me.LblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblName.Location = New System.Drawing.Point(251, 47)
            Me.LblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.LblName.Name = "LblName"
            Me.LblName.Size = New System.Drawing.Size(135, 24)
            Me.LblName.TabIndex = 2
            Me.LblName.Text = "Name:"
            Me.LblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'LblLevel
            '
            Me.LblLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblLevel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblLevel.Location = New System.Drawing.Point(251, 217)
            Me.LblLevel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.LblLevel.Name = "LblLevel"
            Me.LblLevel.Size = New System.Drawing.Size(135, 24)
            Me.LblLevel.TabIndex = 3
            Me.LblLevel.Text = "Level:"
            Me.LblLevel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'LblMaximumEndurance
            '
            Me.LblMaximumEndurance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblMaximumEndurance.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblMaximumEndurance.Location = New System.Drawing.Point(252, 421)
            Me.LblMaximumEndurance.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.LblMaximumEndurance.Name = "LblMaximumEndurance"
            Me.LblMaximumEndurance.Size = New System.Drawing.Size(135, 24)
            Me.LblMaximumEndurance.TabIndex = 4
            Me.LblMaximumEndurance.Text = "Max Endurance:"
            Me.LblMaximumEndurance.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'LblCurrentEndurance
            '
            Me.LblCurrentEndurance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblCurrentEndurance.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblCurrentEndurance.Location = New System.Drawing.Point(252, 387)
            Me.LblCurrentEndurance.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.LblCurrentEndurance.Name = "LblCurrentEndurance"
            Me.LblCurrentEndurance.Size = New System.Drawing.Size(135, 24)
            Me.LblCurrentEndurance.TabIndex = 5
            Me.LblCurrentEndurance.Text = "Curr Endurance:"
            Me.LblCurrentEndurance.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'LblSkillPts
            '
            Me.LblSkillPts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblSkillPts.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblSkillPts.Location = New System.Drawing.Point(251, 285)
            Me.LblSkillPts.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.LblSkillPts.Name = "LblSkillPts"
            Me.LblSkillPts.Size = New System.Drawing.Size(135, 24)
            Me.LblSkillPts.TabIndex = 6
            Me.LblSkillPts.Text = "Skill Points:"
            Me.LblSkillPts.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'LblExp
            '
            Me.LblExp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblExp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblExp.Location = New System.Drawing.Point(251, 251)
            Me.LblExp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.LblExp.Name = "LblExp"
            Me.LblExp.Size = New System.Drawing.Size(135, 24)
            Me.LblExp.TabIndex = 7
            Me.LblExp.Text = "Experience:"
            Me.LblExp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'LblAlive
            '
            Me.LblAlive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblAlive.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblAlive.Location = New System.Drawing.Point(252, 319)
            Me.LblAlive.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.LblAlive.Name = "LblAlive"
            Me.LblAlive.Size = New System.Drawing.Size(135, 24)
            Me.LblAlive.TabIndex = 8
            Me.LblAlive.Text = "Alive:"
            Me.LblAlive.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label1
            '
            Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(902, 183)
            Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(135, 24)
            Me.Label1.TabIndex = 9
            Me.Label1.Text = "Slipping:"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'LblHenchmenLevel1
            '
            Me.LblHenchmenLevel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblHenchmenLevel1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblHenchmenLevel1.Location = New System.Drawing.Point(901, 319)
            Me.LblHenchmenLevel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.LblHenchmenLevel1.Name = "LblHenchmenLevel1"
            Me.LblHenchmenLevel1.Size = New System.Drawing.Size(135, 24)
            Me.LblHenchmenLevel1.TabIndex = 10
            Me.LblHenchmenLevel1.Text = "Lvl 1 Henchmen:"
            Me.LblHenchmenLevel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label3
            '
            Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(902, 217)
            Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(135, 24)
            Me.Label3.TabIndex = 11
            Me.Label3.Text = "Stealth:"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label4
            '
            Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(577, 47)
            Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(135, 24)
            Me.Label4.TabIndex = 12
            Me.Label4.Text = "Current Weapon:"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'LblLocation
            '
            Me.LblLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblLocation.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblLocation.Location = New System.Drawing.Point(252, 353)
            Me.LblLocation.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.LblLocation.Name = "LblLocation"
            Me.LblLocation.Size = New System.Drawing.Size(135, 24)
            Me.LblLocation.TabIndex = 13
            Me.LblLocation.Text = "Location:"
            Me.LblLocation.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'TxtName
            '
            Me.TxtName.Enabled = False
            Me.TxtName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TxtName.Location = New System.Drawing.Point(394, 47)
            Me.TxtName.Margin = New System.Windows.Forms.Padding(4)
            Me.TxtName.MaxLength = 30
            Me.TxtName.Name = "TxtName"
            Me.TxtName.Size = New System.Drawing.Size(175, 26)
            Me.TxtName.TabIndex = 1
            Me.TxtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'LblHenchmenLevel2
            '
            Me.LblHenchmenLevel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblHenchmenLevel2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblHenchmenLevel2.Location = New System.Drawing.Point(901, 353)
            Me.LblHenchmenLevel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.LblHenchmenLevel2.Name = "LblHenchmenLevel2"
            Me.LblHenchmenLevel2.Size = New System.Drawing.Size(135, 24)
            Me.LblHenchmenLevel2.TabIndex = 15
            Me.LblHenchmenLevel2.Text = "Lvl 2 Henchmen:"
            Me.LblHenchmenLevel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'LblHenchmenLevel3
            '
            Me.LblHenchmenLevel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblHenchmenLevel3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblHenchmenLevel3.Location = New System.Drawing.Point(902, 387)
            Me.LblHenchmenLevel3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.LblHenchmenLevel3.Name = "LblHenchmenLevel3"
            Me.LblHenchmenLevel3.Size = New System.Drawing.Size(135, 24)
            Me.LblHenchmenLevel3.TabIndex = 16
            Me.LblHenchmenLevel3.Text = "Lvl 3 Henchmen:"
            Me.LblHenchmenLevel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'LblHenchmenLevel4
            '
            Me.LblHenchmenLevel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblHenchmenLevel4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblHenchmenLevel4.Location = New System.Drawing.Point(902, 421)
            Me.LblHenchmenLevel4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.LblHenchmenLevel4.Name = "LblHenchmenLevel4"
            Me.LblHenchmenLevel4.Size = New System.Drawing.Size(135, 24)
            Me.LblHenchmenLevel4.TabIndex = 17
            Me.LblHenchmenLevel4.Text = "Lvl 4 Henchmen:"
            Me.LblHenchmenLevel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'LblHenchmenLevel5
            '
            Me.LblHenchmenLevel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblHenchmenLevel5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblHenchmenLevel5.Location = New System.Drawing.Point(902, 455)
            Me.LblHenchmenLevel5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.LblHenchmenLevel5.Name = "LblHenchmenLevel5"
            Me.LblHenchmenLevel5.Size = New System.Drawing.Size(135, 24)
            Me.LblHenchmenLevel5.TabIndex = 18
            Me.LblHenchmenLevel5.Text = "Lvl 5 Henchmen:"
            Me.LblHenchmenLevel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'TxtSkillPts
            '
            Me.TxtSkillPts.Enabled = False
            Me.TxtSkillPts.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TxtSkillPts.Location = New System.Drawing.Point(394, 285)
            Me.TxtSkillPts.Margin = New System.Windows.Forms.Padding(4)
            Me.TxtSkillPts.MaxLength = 3
            Me.TxtSkillPts.Name = "TxtSkillPts"
            Me.TxtSkillPts.Size = New System.Drawing.Size(50, 26)
            Me.TxtSkillPts.TabIndex = 6
            Me.TxtSkillPts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'TxtGoldBank
            '
            Me.TxtGoldBank.Enabled = False
            Me.TxtGoldBank.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TxtGoldBank.Location = New System.Drawing.Point(720, 320)
            Me.TxtGoldBank.Margin = New System.Windows.Forms.Padding(4)
            Me.TxtGoldBank.MaxLength = 6
            Me.TxtGoldBank.Name = "TxtGoldBank"
            Me.TxtGoldBank.Size = New System.Drawing.Size(60, 26)
            Me.TxtGoldBank.TabIndex = 21
            Me.TxtGoldBank.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'TxtGoldLoan
            '
            Me.TxtGoldLoan.Enabled = False
            Me.TxtGoldLoan.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TxtGoldLoan.Location = New System.Drawing.Point(720, 354)
            Me.TxtGoldLoan.Margin = New System.Windows.Forms.Padding(4)
            Me.TxtGoldLoan.MaxLength = 6
            Me.TxtGoldLoan.Name = "TxtGoldLoan"
            Me.TxtGoldLoan.Size = New System.Drawing.Size(60, 26)
            Me.TxtGoldLoan.TabIndex = 22
            Me.TxtGoldLoan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'TxtCurrentEndurance
            '
            Me.TxtCurrentEndurance.Enabled = False
            Me.TxtCurrentEndurance.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TxtCurrentEndurance.Location = New System.Drawing.Point(395, 387)
            Me.TxtCurrentEndurance.Margin = New System.Windows.Forms.Padding(4)
            Me.TxtCurrentEndurance.MaxLength = 4
            Me.TxtCurrentEndurance.Name = "TxtCurrentEndurance"
            Me.TxtCurrentEndurance.Size = New System.Drawing.Size(50, 26)
            Me.TxtCurrentEndurance.TabIndex = 9
            Me.TxtCurrentEndurance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'TxtMaximumEndurance
            '
            Me.TxtMaximumEndurance.Enabled = False
            Me.TxtMaximumEndurance.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TxtMaximumEndurance.Location = New System.Drawing.Point(395, 421)
            Me.TxtMaximumEndurance.Margin = New System.Windows.Forms.Padding(4)
            Me.TxtMaximumEndurance.MaxLength = 4
            Me.TxtMaximumEndurance.Name = "TxtMaximumEndurance"
            Me.TxtMaximumEndurance.Size = New System.Drawing.Size(50, 26)
            Me.TxtMaximumEndurance.TabIndex = 10
            Me.TxtMaximumEndurance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'TxtExp
            '
            Me.TxtExp.Enabled = False
            Me.TxtExp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TxtExp.Location = New System.Drawing.Point(394, 251)
            Me.TxtExp.Margin = New System.Windows.Forms.Padding(4)
            Me.TxtExp.MaxLength = 3
            Me.TxtExp.Name = "TxtExp"
            Me.TxtExp.Size = New System.Drawing.Size(50, 26)
            Me.TxtExp.TabIndex = 5
            Me.TxtExp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'TxtLevel
            '
            Me.TxtLevel.Enabled = False
            Me.TxtLevel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TxtLevel.Location = New System.Drawing.Point(394, 217)
            Me.TxtLevel.Margin = New System.Windows.Forms.Padding(4)
            Me.TxtLevel.MaxLength = 2
            Me.TxtLevel.Name = "TxtLevel"
            Me.TxtLevel.Size = New System.Drawing.Size(50, 26)
            Me.TxtLevel.TabIndex = 4
            Me.TxtLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'TxtTwoH
            '
            Me.TxtTwoH.Enabled = False
            Me.TxtTwoH.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TxtTwoH.Location = New System.Drawing.Point(1045, 115)
            Me.TxtTwoH.Margin = New System.Windows.Forms.Padding(4)
            Me.TxtTwoH.MaxLength = 2
            Me.TxtTwoH.Name = "TxtTwoH"
            Me.TxtTwoH.Size = New System.Drawing.Size(50, 26)
            Me.TxtTwoH.TabIndex = 25
            Me.TxtTwoH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Label2
            '
            Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(577, 353)
            Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(135, 24)
            Me.Label2.TabIndex = 27
            Me.Label2.Text = "Gold on Loan:"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label5
            '
            Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.Location = New System.Drawing.Point(901, 47)
            Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(135, 24)
            Me.Label5.TabIndex = 28
            Me.Label5.Text = "Light Wpn Skill:"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label6
            '
            Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.Location = New System.Drawing.Point(902, 81)
            Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(135, 24)
            Me.Label6.TabIndex = 29
            Me.Label6.Text = "Heavy Wpn Skill:"
            Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label7
            '
            Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.Location = New System.Drawing.Point(902, 115)
            Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(135, 24)
            Me.Label7.TabIndex = 30
            Me.Label7.Text = "Two-H Wpn Skill:"
            Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label8
            '
            Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.Location = New System.Drawing.Point(901, 149)
            Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(135, 24)
            Me.Label8.TabIndex = 31
            Me.Label8.Text = "Blocking:"
            Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label9
            '
            Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label9.Location = New System.Drawing.Point(577, 319)
            Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(135, 24)
            Me.Label9.TabIndex = 32
            Me.Label9.Text = "Gold in Bank:"
            Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label10
            '
            Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label10.Location = New System.Drawing.Point(577, 285)
            Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(135, 24)
            Me.Label10.TabIndex = 33
            Me.Label10.Text = "Gold on Hand:"
            Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label11
            '
            Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label11.Location = New System.Drawing.Point(577, 217)
            Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(135, 24)
            Me.Label11.TabIndex = 34
            Me.Label11.Text = "Potion:"
            Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label12
            '
            Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label12.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label12.Location = New System.Drawing.Point(577, 183)
            Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(135, 24)
            Me.Label12.TabIndex = 35
            Me.Label12.Text = "Armor:"
            Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'TxtGoldHand
            '
            Me.TxtGoldHand.Enabled = False
            Me.TxtGoldHand.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TxtGoldHand.Location = New System.Drawing.Point(720, 285)
            Me.TxtGoldHand.Margin = New System.Windows.Forms.Padding(4)
            Me.TxtGoldHand.MaxLength = 6
            Me.TxtGoldHand.Name = "TxtGoldHand"
            Me.TxtGoldHand.Size = New System.Drawing.Size(60, 26)
            Me.TxtGoldHand.TabIndex = 20
            Me.TxtGoldHand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'TxtHeavy
            '
            Me.TxtHeavy.Enabled = False
            Me.TxtHeavy.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TxtHeavy.Location = New System.Drawing.Point(1045, 81)
            Me.TxtHeavy.Margin = New System.Windows.Forms.Padding(4)
            Me.TxtHeavy.MaxLength = 2
            Me.TxtHeavy.Name = "TxtHeavy"
            Me.TxtHeavy.Size = New System.Drawing.Size(50, 26)
            Me.TxtHeavy.TabIndex = 24
            Me.TxtHeavy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'TxtLight
            '
            Me.TxtLight.Enabled = False
            Me.TxtLight.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TxtLight.Location = New System.Drawing.Point(1045, 47)
            Me.TxtLight.Margin = New System.Windows.Forms.Padding(4)
            Me.TxtLight.MaxLength = 2
            Me.TxtLight.Name = "TxtLight"
            Me.TxtLight.Size = New System.Drawing.Size(50, 26)
            Me.TxtLight.TabIndex = 23
            Me.TxtLight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'TxtBlocking
            '
            Me.TxtBlocking.Enabled = False
            Me.TxtBlocking.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TxtBlocking.Location = New System.Drawing.Point(1045, 149)
            Me.TxtBlocking.Margin = New System.Windows.Forms.Padding(4)
            Me.TxtBlocking.MaxLength = 2
            Me.TxtBlocking.Name = "TxtBlocking"
            Me.TxtBlocking.Size = New System.Drawing.Size(50, 26)
            Me.TxtBlocking.TabIndex = 26
            Me.TxtBlocking.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'TxtHenchmenLevel5
            '
            Me.TxtHenchmenLevel5.Enabled = False
            Me.TxtHenchmenLevel5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TxtHenchmenLevel5.Location = New System.Drawing.Point(1044, 455)
            Me.TxtHenchmenLevel5.Margin = New System.Windows.Forms.Padding(4)
            Me.TxtHenchmenLevel5.MaxLength = 3
            Me.TxtHenchmenLevel5.Name = "TxtHenchmenLevel5"
            Me.TxtHenchmenLevel5.Size = New System.Drawing.Size(50, 26)
            Me.TxtHenchmenLevel5.TabIndex = 33
            Me.TxtHenchmenLevel5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'TxtHenchmenLevel4
            '
            Me.TxtHenchmenLevel4.Enabled = False
            Me.TxtHenchmenLevel4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TxtHenchmenLevel4.Location = New System.Drawing.Point(1044, 421)
            Me.TxtHenchmenLevel4.Margin = New System.Windows.Forms.Padding(4)
            Me.TxtHenchmenLevel4.MaxLength = 3
            Me.TxtHenchmenLevel4.Name = "TxtHenchmenLevel4"
            Me.TxtHenchmenLevel4.Size = New System.Drawing.Size(50, 26)
            Me.TxtHenchmenLevel4.TabIndex = 32
            Me.TxtHenchmenLevel4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'TxtHenchmenLevel3
            '
            Me.TxtHenchmenLevel3.Enabled = False
            Me.TxtHenchmenLevel3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TxtHenchmenLevel3.Location = New System.Drawing.Point(1044, 387)
            Me.TxtHenchmenLevel3.Margin = New System.Windows.Forms.Padding(4)
            Me.TxtHenchmenLevel3.MaxLength = 3
            Me.TxtHenchmenLevel3.Name = "TxtHenchmenLevel3"
            Me.TxtHenchmenLevel3.Size = New System.Drawing.Size(50, 26)
            Me.TxtHenchmenLevel3.TabIndex = 31
            Me.TxtHenchmenLevel3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'TxtHenchmenLevel2
            '
            Me.TxtHenchmenLevel2.Enabled = False
            Me.TxtHenchmenLevel2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TxtHenchmenLevel2.Location = New System.Drawing.Point(1044, 353)
            Me.TxtHenchmenLevel2.Margin = New System.Windows.Forms.Padding(4)
            Me.TxtHenchmenLevel2.MaxLength = 3
            Me.TxtHenchmenLevel2.Name = "TxtHenchmenLevel2"
            Me.TxtHenchmenLevel2.Size = New System.Drawing.Size(50, 26)
            Me.TxtHenchmenLevel2.TabIndex = 30
            Me.TxtHenchmenLevel2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'TxtHenchmenLevel1
            '
            Me.TxtHenchmenLevel1.Enabled = False
            Me.TxtHenchmenLevel1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TxtHenchmenLevel1.Location = New System.Drawing.Point(1044, 319)
            Me.TxtHenchmenLevel1.Margin = New System.Windows.Forms.Padding(4)
            Me.TxtHenchmenLevel1.MaxLength = 3
            Me.TxtHenchmenLevel1.Name = "TxtHenchmenLevel1"
            Me.TxtHenchmenLevel1.Size = New System.Drawing.Size(50, 26)
            Me.TxtHenchmenLevel1.TabIndex = 29
            Me.TxtHenchmenLevel1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'TxtStealth
            '
            Me.TxtStealth.Enabled = False
            Me.TxtStealth.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TxtStealth.Location = New System.Drawing.Point(1045, 217)
            Me.TxtStealth.Margin = New System.Windows.Forms.Padding(4)
            Me.TxtStealth.MaxLength = 2
            Me.TxtStealth.Name = "TxtStealth"
            Me.TxtStealth.Size = New System.Drawing.Size(50, 26)
            Me.TxtStealth.TabIndex = 28
            Me.TxtStealth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'TxtSlipping
            '
            Me.TxtSlipping.Enabled = False
            Me.TxtSlipping.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TxtSlipping.Location = New System.Drawing.Point(1045, 183)
            Me.TxtSlipping.Margin = New System.Windows.Forms.Padding(4)
            Me.TxtSlipping.MaxLength = 2
            Me.TxtSlipping.Name = "TxtSlipping"
            Me.TxtSlipping.Size = New System.Drawing.Size(50, 26)
            Me.TxtSlipping.TabIndex = 27
            Me.TxtSlipping.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'BtnSave
            '
            Me.BtnSave.Enabled = False
            Me.BtnSave.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnSave.Location = New System.Drawing.Point(61, 503)
            Me.BtnSave.Margin = New System.Windows.Forms.Padding(4)
            Me.BtnSave.Name = "BtnSave"
            Me.BtnSave.Size = New System.Drawing.Size(125, 30)
            Me.BtnSave.TabIndex = 37
            Me.BtnSave.Text = "&Save"
            Me.BtnSave.UseVisualStyleBackColor = True
            '
            'BtnExit
            '
            Me.BtnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.BtnExit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnExit.Location = New System.Drawing.Point(61, 541)
            Me.BtnExit.Margin = New System.Windows.Forms.Padding(4)
            Me.BtnExit.Name = "BtnExit"
            Me.BtnExit.Size = New System.Drawing.Size(125, 30)
            Me.BtnExit.TabIndex = 38
            Me.BtnExit.Text = "E&xit"
            Me.BtnExit.UseVisualStyleBackColor = True
            '
            'BtnNewUser
            '
            Me.BtnNewUser.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnNewUser.Location = New System.Drawing.Point(61, 389)
            Me.BtnNewUser.Margin = New System.Windows.Forms.Padding(4)
            Me.BtnNewUser.Name = "BtnNewUser"
            Me.BtnNewUser.Size = New System.Drawing.Size(125, 30)
            Me.BtnNewUser.TabIndex = 34
            Me.BtnNewUser.Text = "&New User"
            Me.BtnNewUser.UseVisualStyleBackColor = True
            '
            'BtnDelete
            '
            Me.BtnDelete.Enabled = False
            Me.BtnDelete.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnDelete.Location = New System.Drawing.Point(61, 427)
            Me.BtnDelete.Margin = New System.Windows.Forms.Padding(4)
            Me.BtnDelete.Name = "BtnDelete"
            Me.BtnDelete.Size = New System.Drawing.Size(125, 30)
            Me.BtnDelete.TabIndex = 35
            Me.BtnDelete.Text = "&Delete User"
            Me.BtnDelete.UseVisualStyleBackColor = True
            '
            'LblPass
            '
            Me.LblPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblPass.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblPass.Location = New System.Drawing.Point(251, 81)
            Me.LblPass.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.LblPass.Name = "LblPass"
            Me.LblPass.Size = New System.Drawing.Size(135, 24)
            Me.LblPass.TabIndex = 46
            Me.LblPass.Text = "Password:"
            Me.LblPass.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'TxtChangePass
            '
            Me.TxtChangePass.Enabled = False
            Me.TxtChangePass.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TxtChangePass.Location = New System.Drawing.Point(394, 81)
            Me.TxtChangePass.Margin = New System.Windows.Forms.Padding(4)
            Me.TxtChangePass.MaxLength = 16
            Me.TxtChangePass.Name = "TxtChangePass"
            Me.TxtChangePass.Size = New System.Drawing.Size(175, 26)
            Me.TxtChangePass.TabIndex = 2
            Me.TxtChangePass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.TxtChangePass.UseSystemPasswordChar = True
            '
            'Label14
            '
            Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label14.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label14.Location = New System.Drawing.Point(577, 81)
            Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(135, 24)
            Me.Label14.TabIndex = 47
            Me.Label14.Tag = ""
            Me.Label14.Text = "Light Weapon:"
            Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label15
            '
            Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label15.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label15.Location = New System.Drawing.Point(577, 115)
            Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(135, 24)
            Me.Label15.TabIndex = 49
            Me.Label15.Text = "Heavy Weapon:"
            Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label16
            '
            Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label16.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label16.Location = New System.Drawing.Point(577, 149)
            Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New System.Drawing.Size(135, 24)
            Me.Label16.TabIndex = 51
            Me.Label16.Text = "Two-H Weapon:"
            Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'BtnClear
            '
            Me.BtnClear.Enabled = False
            Me.BtnClear.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnClear.Location = New System.Drawing.Point(61, 465)
            Me.BtnClear.Margin = New System.Windows.Forms.Padding(4)
            Me.BtnClear.Name = "BtnClear"
            Me.BtnClear.Size = New System.Drawing.Size(125, 30)
            Me.BtnClear.TabIndex = 36
            Me.BtnClear.Text = "&Clear"
            Me.BtnClear.UseVisualStyleBackColor = True
            '
            'Label18
            '
            Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label18.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label18.Location = New System.Drawing.Point(577, 251)
            Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New System.Drawing.Size(135, 24)
            Me.Label18.TabIndex = 57
            Me.Label18.Text = "Lockpicks:"
            Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'TxtLockpicks
            '
            Me.TxtLockpicks.Enabled = False
            Me.TxtLockpicks.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TxtLockpicks.Location = New System.Drawing.Point(720, 251)
            Me.TxtLockpicks.Margin = New System.Windows.Forms.Padding(4)
            Me.TxtLockpicks.MaxLength = 2
            Me.TxtLockpicks.Name = "TxtLockpicks"
            Me.TxtLockpicks.Size = New System.Drawing.Size(60, 26)
            Me.TxtLockpicks.TabIndex = 19
            Me.TxtLockpicks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Label17
            '
            Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label17.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label17.Location = New System.Drawing.Point(251, 115)
            Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New System.Drawing.Size(135, 24)
            Me.Label17.TabIndex = 59
            Me.Label17.Text = "Confirm Pass:"
            Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'TxtConfPass
            '
            Me.TxtConfPass.Enabled = False
            Me.TxtConfPass.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TxtConfPass.Location = New System.Drawing.Point(394, 115)
            Me.TxtConfPass.Margin = New System.Windows.Forms.Padding(4)
            Me.TxtConfPass.MaxLength = 16
            Me.TxtConfPass.Name = "TxtConfPass"
            Me.TxtConfPass.Size = New System.Drawing.Size(175, 26)
            Me.TxtConfPass.TabIndex = 3
            Me.TxtConfPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.TxtConfPass.UseSystemPasswordChar = True
            '
            'Label19
            '
            Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label19.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label19.Location = New System.Drawing.Point(251, 13)
            Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.Label19.Name = "Label19"
            Me.Label19.Size = New System.Drawing.Size(318, 24)
            Me.Label19.TabIndex = 60
            Me.Label19.Text = "Login Information:"
            Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label20
            '
            Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label20.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label20.Location = New System.Drawing.Point(251, 183)
            Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New System.Drawing.Size(318, 24)
            Me.Label20.TabIndex = 61
            Me.Label20.Text = "Character:"
            Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label21
            '
            Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label21.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label21.Location = New System.Drawing.Point(577, 13)
            Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.Label21.Name = "Label21"
            Me.Label21.Size = New System.Drawing.Size(317, 24)
            Me.Label21.TabIndex = 62
            Me.Label21.Text = "Inventory:"
            Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label22
            '
            Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label22.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label22.Location = New System.Drawing.Point(902, 13)
            Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.Label22.Name = "Label22"
            Me.Label22.Size = New System.Drawing.Size(193, 24)
            Me.Label22.TabIndex = 63
            Me.Label22.Text = "Skills:"
            Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label23
            '
            Me.Label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label23.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label23.Location = New System.Drawing.Point(252, 455)
            Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.Label23.Name = "Label23"
            Me.Label23.Size = New System.Drawing.Size(135, 24)
            Me.Label23.TabIndex = 64
            Me.Label23.Text = "Hunger:"
            Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'TxtHunger
            '
            Me.TxtHunger.Enabled = False
            Me.TxtHunger.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TxtHunger.Location = New System.Drawing.Point(395, 455)
            Me.TxtHunger.Margin = New System.Windows.Forms.Padding(4)
            Me.TxtHunger.MaxLength = 2
            Me.TxtHunger.Name = "TxtHunger"
            Me.TxtHunger.Size = New System.Drawing.Size(50, 26)
            Me.TxtHunger.TabIndex = 11
            Me.TxtHunger.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Label24
            '
            Me.Label24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label24.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label24.Location = New System.Drawing.Point(252, 489)
            Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.Label24.Name = "Label24"
            Me.Label24.Size = New System.Drawing.Size(135, 24)
            Me.Label24.TabIndex = 66
            Me.Label24.Text = "Thirst:"
            Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'TxtThirst
            '
            Me.TxtThirst.Enabled = False
            Me.TxtThirst.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TxtThirst.Location = New System.Drawing.Point(395, 489)
            Me.TxtThirst.Margin = New System.Windows.Forms.Padding(4)
            Me.TxtThirst.MaxLength = 2
            Me.TxtThirst.Name = "TxtThirst"
            Me.TxtThirst.Size = New System.Drawing.Size(50, 26)
            Me.TxtThirst.TabIndex = 12
            Me.TxtThirst.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Label25
            '
            Me.Label25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label25.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label25.Location = New System.Drawing.Point(901, 285)
            Me.Label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.Label25.Name = "Label25"
            Me.Label25.Size = New System.Drawing.Size(183, 24)
            Me.Label25.TabIndex = 68
            Me.Label25.Text = "HenchmenLevel:"
            Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'chkAlive
            '
            Me.chkAlive.AutoSize = True
            Me.chkAlive.Enabled = False
            Me.chkAlive.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkAlive.Location = New System.Drawing.Point(406, 325)
            Me.chkAlive.Margin = New System.Windows.Forms.Padding(4)
            Me.chkAlive.Name = "chkAlive"
            Me.chkAlive.Size = New System.Drawing.Size(15, 14)
            Me.chkAlive.TabIndex = 7
            Me.chkAlive.UseVisualStyleBackColor = True
            '
            'CmbCurrWeapon
            '
            Me.CmbCurrWeapon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.CmbCurrWeapon.Enabled = False
            Me.CmbCurrWeapon.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CmbCurrWeapon.FormattingEnabled = True
            Me.CmbCurrWeapon.Items.AddRange(New Object() {"Light", "Heavy", "TwoHanded"})
            Me.CmbCurrWeapon.Location = New System.Drawing.Point(719, 48)
            Me.CmbCurrWeapon.Name = "CmbCurrWeapon"
            Me.CmbCurrWeapon.Size = New System.Drawing.Size(101, 26)
            Me.CmbCurrWeapon.TabIndex = 13
            '
            'CmbLoc
            '
            Me.CmbLoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.CmbLoc.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CmbLoc.FormattingEnabled = True
            Me.CmbLoc.Items.AddRange(New Object() {"Streets", "Inn", "Guild", "Jail"})
            Me.CmbLoc.Location = New System.Drawing.Point(395, 350)
            Me.CmbLoc.Name = "CmbLoc"
            Me.CmbLoc.Size = New System.Drawing.Size(101, 26)
            Me.CmbLoc.TabIndex = 8
            '
            'CmbLightWeapon
            '
            Me.CmbLightWeapon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.CmbLightWeapon.Enabled = False
            Me.CmbLightWeapon.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CmbLightWeapon.FormattingEnabled = True
            Me.CmbLightWeapon.Location = New System.Drawing.Point(719, 82)
            Me.CmbLightWeapon.Name = "CmbLightWeapon"
            Me.CmbLightWeapon.Size = New System.Drawing.Size(175, 26)
            Me.CmbLightWeapon.TabIndex = 14
            '
            'CmbHeavyWeapon
            '
            Me.CmbHeavyWeapon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.CmbHeavyWeapon.Enabled = False
            Me.CmbHeavyWeapon.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CmbHeavyWeapon.FormattingEnabled = True
            Me.CmbHeavyWeapon.Location = New System.Drawing.Point(719, 116)
            Me.CmbHeavyWeapon.Name = "CmbHeavyWeapon"
            Me.CmbHeavyWeapon.Size = New System.Drawing.Size(175, 26)
            Me.CmbHeavyWeapon.TabIndex = 15
            '
            'CmbTwoHWeapon
            '
            Me.CmbTwoHWeapon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.CmbTwoHWeapon.Enabled = False
            Me.CmbTwoHWeapon.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CmbTwoHWeapon.FormattingEnabled = True
            Me.CmbTwoHWeapon.Location = New System.Drawing.Point(719, 150)
            Me.CmbTwoHWeapon.Name = "CmbTwoHWeapon"
            Me.CmbTwoHWeapon.Size = New System.Drawing.Size(175, 26)
            Me.CmbTwoHWeapon.TabIndex = 16
            '
            'CmbArmor
            '
            Me.CmbArmor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.CmbArmor.Enabled = False
            Me.CmbArmor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CmbArmor.FormattingEnabled = True
            Me.CmbArmor.Location = New System.Drawing.Point(719, 184)
            Me.CmbArmor.Name = "CmbArmor"
            Me.CmbArmor.Size = New System.Drawing.Size(175, 26)
            Me.CmbArmor.TabIndex = 17
            '
            'CmbPotion
            '
            Me.CmbPotion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.CmbPotion.Enabled = False
            Me.CmbPotion.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CmbPotion.FormattingEnabled = True
            Me.CmbPotion.Location = New System.Drawing.Point(719, 218)
            Me.CmbPotion.Name = "CmbPotion"
            Me.CmbPotion.Size = New System.Drawing.Size(175, 26)
            Me.CmbPotion.TabIndex = 18
            '
            'chkShovel
            '
            Me.chkShovel.AutoSize = True
            Me.chkShovel.Enabled = False
            Me.chkShovel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkShovel.Location = New System.Drawing.Point(732, 393)
            Me.chkShovel.Margin = New System.Windows.Forms.Padding(4)
            Me.chkShovel.Name = "chkShovel"
            Me.chkShovel.Size = New System.Drawing.Size(15, 14)
            Me.chkShovel.TabIndex = 69
            Me.chkShovel.UseVisualStyleBackColor = True
            '
            'LblShovel
            '
            Me.LblShovel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblShovel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblShovel.Location = New System.Drawing.Point(577, 387)
            Me.LblShovel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.LblShovel.Name = "LblShovel"
            Me.LblShovel.Size = New System.Drawing.Size(135, 24)
            Me.LblShovel.TabIndex = 70
            Me.LblShovel.Text = "Shovel:"
            Me.LblShovel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'chkLantern
            '
            Me.chkLantern.AutoSize = True
            Me.chkLantern.Enabled = False
            Me.chkLantern.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkLantern.Location = New System.Drawing.Point(732, 427)
            Me.chkLantern.Margin = New System.Windows.Forms.Padding(4)
            Me.chkLantern.Name = "chkLantern"
            Me.chkLantern.Size = New System.Drawing.Size(15, 14)
            Me.chkLantern.TabIndex = 71
            Me.chkLantern.UseVisualStyleBackColor = True
            '
            'LblLantern
            '
            Me.LblLantern.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblLantern.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblLantern.Location = New System.Drawing.Point(577, 421)
            Me.LblLantern.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.LblLantern.Name = "LblLantern"
            Me.LblLantern.Size = New System.Drawing.Size(135, 24)
            Me.LblLantern.TabIndex = 72
            Me.LblLantern.Text = "Lantern:"
            Me.LblLantern.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'chkAmulet
            '
            Me.chkAmulet.AutoSize = True
            Me.chkAmulet.Enabled = False
            Me.chkAmulet.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkAmulet.Location = New System.Drawing.Point(732, 461)
            Me.chkAmulet.Margin = New System.Windows.Forms.Padding(4)
            Me.chkAmulet.Name = "chkAmulet"
            Me.chkAmulet.Size = New System.Drawing.Size(15, 14)
            Me.chkAmulet.TabIndex = 73
            Me.chkAmulet.UseVisualStyleBackColor = True
            '
            'LblAmulet
            '
            Me.LblAmulet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblAmulet.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblAmulet.Location = New System.Drawing.Point(577, 455)
            Me.LblAmulet.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.LblAmulet.Name = "LblAmulet"
            Me.LblAmulet.Size = New System.Drawing.Size(135, 24)
            Me.LblAmulet.TabIndex = 74
            Me.LblAmulet.Text = "Amulet:"
            Me.LblAmulet.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'FrmAdminUsers
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.BtnExit
            Me.ClientSize = New System.Drawing.Size(1133, 583)
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
            Me.Controls.Add(Me.TxtThirst)
            Me.Controls.Add(Me.Label24)
            Me.Controls.Add(Me.TxtHunger)
            Me.Controls.Add(Me.Label23)
            Me.Controls.Add(Me.Label22)
            Me.Controls.Add(Me.Label21)
            Me.Controls.Add(Me.Label20)
            Me.Controls.Add(Me.Label19)
            Me.Controls.Add(Me.TxtConfPass)
            Me.Controls.Add(Me.Label17)
            Me.Controls.Add(Me.TxtLockpicks)
            Me.Controls.Add(Me.Label18)
            Me.Controls.Add(Me.BtnClear)
            Me.Controls.Add(Me.Label16)
            Me.Controls.Add(Me.Label15)
            Me.Controls.Add(Me.Label14)
            Me.Controls.Add(Me.TxtChangePass)
            Me.Controls.Add(Me.LblPass)
            Me.Controls.Add(Me.BtnDelete)
            Me.Controls.Add(Me.BtnNewUser)
            Me.Controls.Add(Me.BtnExit)
            Me.Controls.Add(Me.BtnSave)
            Me.Controls.Add(Me.TxtSlipping)
            Me.Controls.Add(Me.TxtStealth)
            Me.Controls.Add(Me.TxtHenchmenLevel1)
            Me.Controls.Add(Me.TxtHenchmenLevel2)
            Me.Controls.Add(Me.TxtHenchmenLevel3)
            Me.Controls.Add(Me.TxtHenchmenLevel4)
            Me.Controls.Add(Me.TxtHenchmenLevel5)
            Me.Controls.Add(Me.TxtBlocking)
            Me.Controls.Add(Me.TxtLight)
            Me.Controls.Add(Me.TxtHeavy)
            Me.Controls.Add(Me.TxtGoldHand)
            Me.Controls.Add(Me.Label12)
            Me.Controls.Add(Me.Label11)
            Me.Controls.Add(Me.Label10)
            Me.Controls.Add(Me.Label9)
            Me.Controls.Add(Me.Label8)
            Me.Controls.Add(Me.Label7)
            Me.Controls.Add(Me.Label6)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.TxtTwoH)
            Me.Controls.Add(Me.TxtLevel)
            Me.Controls.Add(Me.TxtExp)
            Me.Controls.Add(Me.TxtMaximumEndurance)
            Me.Controls.Add(Me.TxtCurrentEndurance)
            Me.Controls.Add(Me.TxtGoldLoan)
            Me.Controls.Add(Me.TxtGoldBank)
            Me.Controls.Add(Me.TxtSkillPts)
            Me.Controls.Add(Me.LblHenchmenLevel5)
            Me.Controls.Add(Me.LblHenchmenLevel4)
            Me.Controls.Add(Me.LblHenchmenLevel3)
            Me.Controls.Add(Me.LblHenchmenLevel2)
            Me.Controls.Add(Me.TxtName)
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
            Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Margin = New System.Windows.Forms.Padding(4)
            Me.MaximizeBox = False
            Me.MinimumSize = New System.Drawing.Size(970, 622)
            Me.Name = "FrmAdminUsers"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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