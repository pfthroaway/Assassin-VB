Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

Namespace Forms
    <DesignerGenerated()> _
    Partial Class FrmGame
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
            Me.txtGame = New TextBox()
            Me.btnAssassinate = New Button()
            Me.btnBank = New Button()
            Me.btnInn = New Button()
            Me.btnChapel = New Button()
            Me.btnGuild = New Button()
            Me.btnJail = New Button()
            Me.btnShops = New Button()
            Me.btnInventory = New Button()
            Me.btnTrain = New Button()
            Me.btnMystic = New Button()
            Me.btnOthers = New Button()
            Me.btnPub = New Button()
            Me.btnRob = New Button()
            Me.btnExit = New Button()
            Me.Label12 = New Label()
            Me.Label11 = New Label()
            Me.Label9 = New Label()
            Me.lblArmor = New Label()
            Me.Label5 = New Label()
            Me.lblWeapon = New Label()
            Me.Label8 = New Label()
            Me.lblWeaponName = New Label()
            Me.lblInventory = New Label()
            Me.lblArmorName = New Label()
            Me.lblSpecial = New Label()
            Me.lblEndAmt = New Label()
            Me.lblPotion = New Label()
            Me.Label1 = New Label()
            Me.Label4 = New Label()
            Me.lblGoldLoanAmt = New Label()
            Me.lblTwoAmt = New Label()
            Me.lblGoldBankAmt = New Label()
            Me.lblBlockingAmt = New Label()
            Me.lblGoldLoan = New Label()
            Me.lblHeavyAmt = New Label()
            Me.lblRank = New Label()
            Me.lblSlippingAmt = New Label()
            Me.lblGoldHandAmt = New Label()
            Me.lblWeaponSkills = New Label()
            Me.lblExp = New Label()
            Me.lblStealthAmt = New Label()
            Me.lblExpAmt = New Label()
            Me.lblLightAmt = New Label()
            Me.lblSkillPts = New Label()
            Me.Label3 = New Label()
            Me.lblGoldHand = New Label()
            Me.lblHunger = New Label()
            Me.lblSkillPtsAmt = New Label()
            Me.Label7 = New Label()
            Me.lblName = New Label()
            Me.lblThirst = New Label()
            Me.lblGoldBank = New Label()
            Me.pnlStats = New Panel()
            Me.btnOptions = New Button()
            Me.btnMessages = New Button()
            Me.pnlStats.SuspendLayout()
            Me.SuspendLayout()
            '
            'txtGame
            '
            Me.txtGame.BorderStyle = BorderStyle.FixedSingle
            Me.txtGame.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.txtGame.Location = New Point(12, 12)
            Me.txtGame.Multiline = True
            Me.txtGame.Name = "txtGame"
            Me.txtGame.ReadOnly = True
            Me.txtGame.ScrollBars = ScrollBars.Vertical
            Me.txtGame.Size = New Size(400, 286)
            Me.txtGame.TabIndex = 0
            '
            'btnAssassinate
            '
            Me.btnAssassinate.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnAssassinate.Location = New Point(12, 307)
            Me.btnAssassinate.Name = "btnAssassinate"
            Me.btnAssassinate.Size = New Size(197, 30)
            Me.btnAssassinate.TabIndex = 1
            Me.btnAssassinate.Text = "&Assassinate"
            Me.btnAssassinate.UseVisualStyleBackColor = True
            '
            'btnBank
            '
            Me.btnBank.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnBank.Location = New Point(12, 343)
            Me.btnBank.Name = "btnBank"
            Me.btnBank.Size = New Size(95, 30)
            Me.btnBank.TabIndex = 2
            Me.btnBank.Text = "&Bank"
            Me.btnBank.UseVisualStyleBackColor = True
            '
            'btnInn
            '
            Me.btnInn.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnInn.Location = New Point(12, 451)
            Me.btnInn.Name = "btnInn"
            Me.btnInn.Size = New Size(95, 30)
            Me.btnInn.TabIndex = 5
            Me.btnInn.Text = "&Inn"
            Me.btnInn.UseVisualStyleBackColor = True
            '
            'btnChapel
            '
            Me.btnChapel.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnChapel.Location = New Point(12, 379)
            Me.btnChapel.Name = "btnChapel"
            Me.btnChapel.Size = New Size(95, 30)
            Me.btnChapel.TabIndex = 3
            Me.btnChapel.Text = "&Chapel"
            Me.btnChapel.UseVisualStyleBackColor = True
            '
            'btnGuild
            '
            Me.btnGuild.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuild.Location = New Point(12, 415)
            Me.btnGuild.Name = "btnGuild"
            Me.btnGuild.Size = New Size(95, 30)
            Me.btnGuild.TabIndex = 4
            Me.btnGuild.Text = "&Guild"
            Me.btnGuild.UseVisualStyleBackColor = True
            '
            'btnJail
            '
            Me.btnJail.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnJail.Location = New Point(114, 343)
            Me.btnJail.Name = "btnJail"
            Me.btnJail.Size = New Size(95, 30)
            Me.btnJail.TabIndex = 6
            Me.btnJail.Text = "&Jail"
            Me.btnJail.UseVisualStyleBackColor = True
            '
            'btnShops
            '
            Me.btnShops.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnShops.Location = New Point(215, 379)
            Me.btnShops.Name = "btnShops"
            Me.btnShops.Size = New Size(95, 30)
            Me.btnShops.TabIndex = 14
            Me.btnShops.Text = "&Shops"
            Me.btnShops.UseVisualStyleBackColor = True
            '
            'btnInventory
            '
            Me.btnInventory.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnInventory.Location = New Point(215, 307)
            Me.btnInventory.Name = "btnInventory"
            Me.btnInventory.Size = New Size(196, 30)
            Me.btnInventory.TabIndex = 10
            Me.btnInventory.Text = "In&ventory"
            Me.btnInventory.UseVisualStyleBackColor = True
            '
            'btnTrain
            '
            Me.btnTrain.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnTrain.Location = New Point(215, 415)
            Me.btnTrain.Name = "btnTrain"
            Me.btnTrain.Size = New Size(95, 30)
            Me.btnTrain.TabIndex = 15
            Me.btnTrain.Text = "&Train"
            Me.btnTrain.UseVisualStyleBackColor = True
            '
            'btnMystic
            '
            Me.btnMystic.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnMystic.Location = New Point(115, 379)
            Me.btnMystic.Name = "btnMystic"
            Me.btnMystic.Size = New Size(95, 30)
            Me.btnMystic.TabIndex = 8
            Me.btnMystic.Text = "M&ystic"
            Me.btnMystic.UseVisualStyleBackColor = True
            '
            'btnOthers
            '
            Me.btnOthers.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnOthers.Location = New Point(115, 415)
            Me.btnOthers.Name = "btnOthers"
            Me.btnOthers.Size = New Size(95, 30)
            Me.btnOthers.TabIndex = 11
            Me.btnOthers.Text = "Ot&hers"
            Me.btnOthers.UseVisualStyleBackColor = True
            '
            'btnPub
            '
            Me.btnPub.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnPub.Location = New Point(115, 451)
            Me.btnPub.Name = "btnPub"
            Me.btnPub.Size = New Size(95, 30)
            Me.btnPub.TabIndex = 12
            Me.btnPub.Text = "&Pub"
            Me.btnPub.UseVisualStyleBackColor = True
            '
            'btnRob
            '
            Me.btnRob.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnRob.Location = New Point(215, 343)
            Me.btnRob.Name = "btnRob"
            Me.btnRob.Size = New Size(95, 30)
            Me.btnRob.TabIndex = 13
            Me.btnRob.Text = "&Rob"
            Me.btnRob.UseVisualStyleBackColor = True
            '
            'btnExit
            '
            Me.btnExit.DialogResult = DialogResult.Cancel
            Me.btnExit.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnExit.Location = New Point(317, 451)
            Me.btnExit.Name = "btnExit"
            Me.btnExit.Size = New Size(95, 30)
            Me.btnExit.TabIndex = 16
            Me.btnExit.Text = "E&xit"
            Me.btnExit.UseVisualStyleBackColor = True
            '
            'Label12
            '
            Me.Label12.BorderStyle = BorderStyle.FixedSingle
            Me.Label12.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Label12.Location = New Point(0, 395)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New Size(115, 23)
            Me.Label12.TabIndex = 81
            Me.Label12.Text = "Blocking:"
            Me.Label12.TextAlign = ContentAlignment.MiddleRight
            '
            'Label11
            '
            Me.Label11.BorderStyle = BorderStyle.FixedSingle
            Me.Label11.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Label11.Location = New Point(0, 373)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New Size(115, 23)
            Me.Label11.TabIndex = 71
            Me.Label11.Text = "Two-H Weapon:"
            Me.Label11.TextAlign = ContentAlignment.MiddleRight
            '
            'Label9
            '
            Me.Label9.BorderStyle = BorderStyle.FixedSingle
            Me.Label9.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Label9.Location = New Point(0, 351)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New Size(115, 23)
            Me.Label9.TabIndex = 76
            Me.Label9.Text = "Heavy Weapon:"
            Me.Label9.TextAlign = ContentAlignment.MiddleRight
            '
            'lblArmor
            '
            Me.lblArmor.BorderStyle = BorderStyle.FixedSingle
            Me.lblArmor.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblArmor.Location = New Point(0, 197)
            Me.lblArmor.Name = "lblArmor"
            Me.lblArmor.Size = New Size(115, 23)
            Me.lblArmor.TabIndex = 96
            Me.lblArmor.Text = "Armor:"
            Me.lblArmor.TextAlign = ContentAlignment.MiddleRight
            '
            'Label5
            '
            Me.Label5.BorderStyle = BorderStyle.FixedSingle
            Me.Label5.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.Location = New Point(0, 329)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New Size(115, 23)
            Me.Label5.TabIndex = 70
            Me.Label5.Text = "Light Weapon:"
            Me.Label5.TextAlign = ContentAlignment.MiddleRight
            '
            'lblWeapon
            '
            Me.lblWeapon.BorderStyle = BorderStyle.FixedSingle
            Me.lblWeapon.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblWeapon.Location = New Point(0, 175)
            Me.lblWeapon.Name = "lblWeapon"
            Me.lblWeapon.Size = New Size(115, 23)
            Me.lblWeapon.TabIndex = 95
            Me.lblWeapon.Text = "Current Weapon:"
            Me.lblWeapon.TextAlign = ContentAlignment.MiddleRight
            '
            'Label8
            '
            Me.Label8.BorderStyle = BorderStyle.FixedSingle
            Me.Label8.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.Location = New Point(0, 417)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New Size(115, 23)
            Me.Label8.TabIndex = 83
            Me.Label8.Text = "Slipping:"
            Me.Label8.TextAlign = ContentAlignment.MiddleRight
            '
            'lblWeaponName
            '
            Me.lblWeaponName.BorderStyle = BorderStyle.FixedSingle
            Me.lblWeaponName.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblWeaponName.Location = New Point(114, 175)
            Me.lblWeaponName.Name = "lblWeaponName"
            Me.lblWeaponName.Size = New Size(114, 23)
            Me.lblWeaponName.TabIndex = 94
            Me.lblWeaponName.TextAlign = ContentAlignment.MiddleCenter
            '
            'lblInventory
            '
            Me.lblInventory.BorderStyle = BorderStyle.FixedSingle
            Me.lblInventory.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.lblInventory.Location = New Point(0, 153)
            Me.lblInventory.Name = "lblInventory"
            Me.lblInventory.Size = New Size(228, 23)
            Me.lblInventory.TabIndex = 97
            Me.lblInventory.Text = "Inventory:"
            Me.lblInventory.TextAlign = ContentAlignment.MiddleCenter
            '
            'lblArmorName
            '
            Me.lblArmorName.BorderStyle = BorderStyle.FixedSingle
            Me.lblArmorName.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblArmorName.Location = New Point(114, 197)
            Me.lblArmorName.Name = "lblArmorName"
            Me.lblArmorName.Size = New Size(114, 23)
            Me.lblArmorName.TabIndex = 93
            Me.lblArmorName.TextAlign = ContentAlignment.MiddleCenter
            '
            'lblSpecial
            '
            Me.lblSpecial.BorderStyle = BorderStyle.FixedSingle
            Me.lblSpecial.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblSpecial.Location = New Point(0, 219)
            Me.lblSpecial.Name = "lblSpecial"
            Me.lblSpecial.Size = New Size(115, 23)
            Me.lblSpecial.TabIndex = 98
            Me.lblSpecial.Text = "Potion:"
            Me.lblSpecial.TextAlign = ContentAlignment.MiddleRight
            '
            'lblEndAmt
            '
            Me.lblEndAmt.BorderStyle = BorderStyle.FixedSingle
            Me.lblEndAmt.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblEndAmt.Location = New Point(114, 88)
            Me.lblEndAmt.Name = "lblEndAmt"
            Me.lblEndAmt.Size = New Size(114, 23)
            Me.lblEndAmt.TabIndex = 91
            Me.lblEndAmt.TextAlign = ContentAlignment.MiddleCenter
            '
            'lblPotion
            '
            Me.lblPotion.BorderStyle = BorderStyle.FixedSingle
            Me.lblPotion.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblPotion.Location = New Point(114, 219)
            Me.lblPotion.Name = "lblPotion"
            Me.lblPotion.Size = New Size(114, 23)
            Me.lblPotion.TabIndex = 99
            Me.lblPotion.TextAlign = ContentAlignment.MiddleCenter
            '
            'Label1
            '
            Me.Label1.BorderStyle = BorderStyle.FixedSingle
            Me.Label1.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New Point(0, 88)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New Size(115, 23)
            Me.Label1.TabIndex = 68
            Me.Label1.Text = "Endurance:"
            Me.Label1.TextAlign = ContentAlignment.MiddleRight
            '
            'Label4
            '
            Me.Label4.BorderStyle = BorderStyle.FixedSingle
            Me.Label4.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New Point(0, 439)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New Size(115, 23)
            Me.Label4.TabIndex = 84
            Me.Label4.Text = "Stealth:"
            Me.Label4.TextAlign = ContentAlignment.MiddleRight
            '
            'lblGoldLoanAmt
            '
            Me.lblGoldLoanAmt.BorderStyle = BorderStyle.FixedSingle
            Me.lblGoldLoanAmt.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblGoldLoanAmt.Location = New Point(114, 285)
            Me.lblGoldLoanAmt.Name = "lblGoldLoanAmt"
            Me.lblGoldLoanAmt.Size = New Size(114, 23)
            Me.lblGoldLoanAmt.TabIndex = 88
            Me.lblGoldLoanAmt.TextAlign = ContentAlignment.MiddleCenter
            '
            'lblTwoAmt
            '
            Me.lblTwoAmt.BorderStyle = BorderStyle.FixedSingle
            Me.lblTwoAmt.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblTwoAmt.Location = New Point(114, 373)
            Me.lblTwoAmt.Name = "lblTwoAmt"
            Me.lblTwoAmt.Size = New Size(114, 23)
            Me.lblTwoAmt.TabIndex = 77
            Me.lblTwoAmt.TextAlign = ContentAlignment.MiddleCenter
            '
            'lblGoldBankAmt
            '
            Me.lblGoldBankAmt.BorderStyle = BorderStyle.FixedSingle
            Me.lblGoldBankAmt.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblGoldBankAmt.Location = New Point(114, 263)
            Me.lblGoldBankAmt.Name = "lblGoldBankAmt"
            Me.lblGoldBankAmt.Size = New Size(114, 23)
            Me.lblGoldBankAmt.TabIndex = 89
            Me.lblGoldBankAmt.TextAlign = ContentAlignment.MiddleCenter
            '
            'lblBlockingAmt
            '
            Me.lblBlockingAmt.BorderStyle = BorderStyle.FixedSingle
            Me.lblBlockingAmt.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblBlockingAmt.Location = New Point(114, 395)
            Me.lblBlockingAmt.Name = "lblBlockingAmt"
            Me.lblBlockingAmt.Size = New Size(114, 23)
            Me.lblBlockingAmt.TabIndex = 80
            Me.lblBlockingAmt.TextAlign = ContentAlignment.MiddleCenter
            '
            'lblGoldLoan
            '
            Me.lblGoldLoan.BorderStyle = BorderStyle.FixedSingle
            Me.lblGoldLoan.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblGoldLoan.Location = New Point(0, 285)
            Me.lblGoldLoan.Name = "lblGoldLoan"
            Me.lblGoldLoan.Size = New Size(115, 23)
            Me.lblGoldLoan.TabIndex = 85
            Me.lblGoldLoan.Text = "Gold on Loan:"
            Me.lblGoldLoan.TextAlign = ContentAlignment.MiddleRight
            '
            'lblHeavyAmt
            '
            Me.lblHeavyAmt.BorderStyle = BorderStyle.FixedSingle
            Me.lblHeavyAmt.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblHeavyAmt.Location = New Point(114, 351)
            Me.lblHeavyAmt.Name = "lblHeavyAmt"
            Me.lblHeavyAmt.Size = New Size(114, 23)
            Me.lblHeavyAmt.TabIndex = 73
            Me.lblHeavyAmt.TextAlign = ContentAlignment.MiddleCenter
            '
            'lblRank
            '
            Me.lblRank.BorderStyle = BorderStyle.FixedSingle
            Me.lblRank.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblRank.Location = New Point(0, 22)
            Me.lblRank.Name = "lblRank"
            Me.lblRank.Size = New Size(228, 23)
            Me.lblRank.TabIndex = 74
            Me.lblRank.TextAlign = ContentAlignment.MiddleCenter
            '
            'lblSlippingAmt
            '
            Me.lblSlippingAmt.BorderStyle = BorderStyle.FixedSingle
            Me.lblSlippingAmt.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblSlippingAmt.Location = New Point(114, 417)
            Me.lblSlippingAmt.Name = "lblSlippingAmt"
            Me.lblSlippingAmt.Size = New Size(114, 23)
            Me.lblSlippingAmt.TabIndex = 87
            Me.lblSlippingAmt.TextAlign = ContentAlignment.MiddleCenter
            '
            'lblGoldHandAmt
            '
            Me.lblGoldHandAmt.BorderStyle = BorderStyle.FixedSingle
            Me.lblGoldHandAmt.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblGoldHandAmt.Location = New Point(114, 241)
            Me.lblGoldHandAmt.Name = "lblGoldHandAmt"
            Me.lblGoldHandAmt.Size = New Size(114, 23)
            Me.lblGoldHandAmt.TabIndex = 86
            Me.lblGoldHandAmt.TextAlign = ContentAlignment.MiddleCenter
            '
            'lblWeaponSkills
            '
            Me.lblWeaponSkills.BorderStyle = BorderStyle.FixedSingle
            Me.lblWeaponSkills.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.lblWeaponSkills.Location = New Point(0, 307)
            Me.lblWeaponSkills.Name = "lblWeaponSkills"
            Me.lblWeaponSkills.Size = New Size(228, 23)
            Me.lblWeaponSkills.TabIndex = 100
            Me.lblWeaponSkills.Text = "Skills:"
            Me.lblWeaponSkills.TextAlign = ContentAlignment.MiddleCenter
            '
            'lblExp
            '
            Me.lblExp.BorderStyle = BorderStyle.FixedSingle
            Me.lblExp.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblExp.Location = New Point(0, 44)
            Me.lblExp.Name = "lblExp"
            Me.lblExp.Size = New Size(115, 23)
            Me.lblExp.TabIndex = 75
            Me.lblExp.Text = "Experience:"
            Me.lblExp.TextAlign = ContentAlignment.MiddleRight
            '
            'lblStealthAmt
            '
            Me.lblStealthAmt.BorderStyle = BorderStyle.FixedSingle
            Me.lblStealthAmt.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblStealthAmt.Location = New Point(114, 439)
            Me.lblStealthAmt.Name = "lblStealthAmt"
            Me.lblStealthAmt.Size = New Size(114, 23)
            Me.lblStealthAmt.TabIndex = 90
            Me.lblStealthAmt.TextAlign = ContentAlignment.MiddleCenter
            '
            'lblExpAmt
            '
            Me.lblExpAmt.BorderStyle = BorderStyle.FixedSingle
            Me.lblExpAmt.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblExpAmt.Location = New Point(114, 44)
            Me.lblExpAmt.Name = "lblExpAmt"
            Me.lblExpAmt.Size = New Size(114, 23)
            Me.lblExpAmt.TabIndex = 78
            Me.lblExpAmt.TextAlign = ContentAlignment.MiddleCenter
            '
            'lblLightAmt
            '
            Me.lblLightAmt.BorderStyle = BorderStyle.FixedSingle
            Me.lblLightAmt.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblLightAmt.Location = New Point(114, 329)
            Me.lblLightAmt.Name = "lblLightAmt"
            Me.lblLightAmt.Size = New Size(114, 23)
            Me.lblLightAmt.TabIndex = 92
            Me.lblLightAmt.TextAlign = ContentAlignment.MiddleCenter
            '
            'lblSkillPts
            '
            Me.lblSkillPts.BorderStyle = BorderStyle.FixedSingle
            Me.lblSkillPts.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblSkillPts.Location = New Point(0, 66)
            Me.lblSkillPts.Name = "lblSkillPts"
            Me.lblSkillPts.Size = New Size(115, 23)
            Me.lblSkillPts.TabIndex = 72
            Me.lblSkillPts.Text = "Skill Points:"
            Me.lblSkillPts.TextAlign = ContentAlignment.MiddleRight
            '
            'Label3
            '
            Me.Label3.BorderStyle = BorderStyle.FixedSingle
            Me.Label3.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New Point(0, 110)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New Size(115, 23)
            Me.Label3.TabIndex = 101
            Me.Label3.Text = "Hunger:"
            Me.Label3.TextAlign = ContentAlignment.MiddleRight
            '
            'lblGoldHand
            '
            Me.lblGoldHand.BorderStyle = BorderStyle.FixedSingle
            Me.lblGoldHand.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblGoldHand.Location = New Point(0, 241)
            Me.lblGoldHand.Name = "lblGoldHand"
            Me.lblGoldHand.Size = New Size(115, 23)
            Me.lblGoldHand.TabIndex = 82
            Me.lblGoldHand.Text = "Gold on Hand:"
            Me.lblGoldHand.TextAlign = ContentAlignment.MiddleRight
            '
            'lblHunger
            '
            Me.lblHunger.BorderStyle = BorderStyle.FixedSingle
            Me.lblHunger.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblHunger.Location = New Point(114, 110)
            Me.lblHunger.Name = "lblHunger"
            Me.lblHunger.Size = New Size(114, 23)
            Me.lblHunger.TabIndex = 102
            Me.lblHunger.TextAlign = ContentAlignment.MiddleCenter
            '
            'lblSkillPtsAmt
            '
            Me.lblSkillPtsAmt.BorderStyle = BorderStyle.FixedSingle
            Me.lblSkillPtsAmt.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblSkillPtsAmt.Location = New Point(114, 66)
            Me.lblSkillPtsAmt.Name = "lblSkillPtsAmt"
            Me.lblSkillPtsAmt.Size = New Size(114, 23)
            Me.lblSkillPtsAmt.TabIndex = 79
            Me.lblSkillPtsAmt.TextAlign = ContentAlignment.MiddleCenter
            '
            'Label7
            '
            Me.Label7.BorderStyle = BorderStyle.FixedSingle
            Me.Label7.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.Location = New Point(0, 131)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New Size(115, 23)
            Me.Label7.TabIndex = 103
            Me.Label7.Text = "Thirst:"
            Me.Label7.TextAlign = ContentAlignment.MiddleRight
            '
            'lblName
            '
            Me.lblName.BorderStyle = BorderStyle.FixedSingle
            Me.lblName.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.lblName.Location = New Point(0, 0)
            Me.lblName.Name = "lblName"
            Me.lblName.Size = New Size(228, 23)
            Me.lblName.TabIndex = 69
            Me.lblName.TextAlign = ContentAlignment.MiddleCenter
            '
            'lblThirst
            '
            Me.lblThirst.BorderStyle = BorderStyle.FixedSingle
            Me.lblThirst.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblThirst.Location = New Point(114, 131)
            Me.lblThirst.Name = "lblThirst"
            Me.lblThirst.Size = New Size(114, 23)
            Me.lblThirst.TabIndex = 104
            Me.lblThirst.TextAlign = ContentAlignment.MiddleCenter
            '
            'lblGoldBank
            '
            Me.lblGoldBank.BorderStyle = BorderStyle.FixedSingle
            Me.lblGoldBank.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblGoldBank.Location = New Point(0, 263)
            Me.lblGoldBank.Name = "lblGoldBank"
            Me.lblGoldBank.Size = New Size(115, 23)
            Me.lblGoldBank.TabIndex = 105
            Me.lblGoldBank.Text = "Gold in Bank:"
            Me.lblGoldBank.TextAlign = ContentAlignment.MiddleRight
            '
            'pnlStats
            '
            Me.pnlStats.Controls.Add(Me.lblGoldBank)
            Me.pnlStats.Controls.Add(Me.lblThirst)
            Me.pnlStats.Controls.Add(Me.lblName)
            Me.pnlStats.Controls.Add(Me.Label7)
            Me.pnlStats.Controls.Add(Me.lblSkillPtsAmt)
            Me.pnlStats.Controls.Add(Me.lblHunger)
            Me.pnlStats.Controls.Add(Me.lblGoldHand)
            Me.pnlStats.Controls.Add(Me.Label3)
            Me.pnlStats.Controls.Add(Me.lblSkillPts)
            Me.pnlStats.Controls.Add(Me.lblLightAmt)
            Me.pnlStats.Controls.Add(Me.lblExpAmt)
            Me.pnlStats.Controls.Add(Me.lblStealthAmt)
            Me.pnlStats.Controls.Add(Me.lblExp)
            Me.pnlStats.Controls.Add(Me.lblWeaponSkills)
            Me.pnlStats.Controls.Add(Me.lblGoldHandAmt)
            Me.pnlStats.Controls.Add(Me.lblSlippingAmt)
            Me.pnlStats.Controls.Add(Me.lblRank)
            Me.pnlStats.Controls.Add(Me.lblHeavyAmt)
            Me.pnlStats.Controls.Add(Me.lblGoldLoan)
            Me.pnlStats.Controls.Add(Me.lblBlockingAmt)
            Me.pnlStats.Controls.Add(Me.lblGoldBankAmt)
            Me.pnlStats.Controls.Add(Me.lblTwoAmt)
            Me.pnlStats.Controls.Add(Me.lblGoldLoanAmt)
            Me.pnlStats.Controls.Add(Me.Label4)
            Me.pnlStats.Controls.Add(Me.Label1)
            Me.pnlStats.Controls.Add(Me.lblPotion)
            Me.pnlStats.Controls.Add(Me.lblEndAmt)
            Me.pnlStats.Controls.Add(Me.lblSpecial)
            Me.pnlStats.Controls.Add(Me.lblArmorName)
            Me.pnlStats.Controls.Add(Me.lblInventory)
            Me.pnlStats.Controls.Add(Me.lblWeaponName)
            Me.pnlStats.Controls.Add(Me.Label8)
            Me.pnlStats.Controls.Add(Me.lblWeapon)
            Me.pnlStats.Controls.Add(Me.Label5)
            Me.pnlStats.Controls.Add(Me.lblArmor)
            Me.pnlStats.Controls.Add(Me.Label9)
            Me.pnlStats.Controls.Add(Me.Label11)
            Me.pnlStats.Controls.Add(Me.Label12)
            Me.pnlStats.Location = New Point(418, 12)
            Me.pnlStats.Name = "pnlStats"
            Me.pnlStats.Size = New Size(234, 467)
            Me.pnlStats.TabIndex = 20
            '
            'btnOptions
            '
            Me.btnOptions.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnOptions.Location = New Point(317, 416)
            Me.btnOptions.Name = "btnOptions"
            Me.btnOptions.Size = New Size(95, 30)
            Me.btnOptions.TabIndex = 9
            Me.btnOptions.Text = "&Options"
            Me.btnOptions.UseVisualStyleBackColor = True
            '
            'btnMessages
            '
            Me.btnMessages.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnMessages.Location = New Point(316, 379)
            Me.btnMessages.Name = "btnMessages"
            Me.btnMessages.Size = New Size(95, 30)
            Me.btnMessages.TabIndex = 7
            Me.btnMessages.Text = "&Messages"
            Me.btnMessages.UseVisualStyleBackColor = True
            '
            'frmGame
            '
            Me.AutoScaleDimensions = New SizeF(9.0!, 18.0!)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.CancelButton = Me.btnExit
            Me.ClientSize = New Size(658, 486)
            Me.Controls.Add(Me.btnMessages)
            Me.Controls.Add(Me.btnOptions)
            Me.Controls.Add(Me.btnExit)
            Me.Controls.Add(Me.btnRob)
            Me.Controls.Add(Me.btnPub)
            Me.Controls.Add(Me.btnOthers)
            Me.Controls.Add(Me.btnMystic)
            Me.Controls.Add(Me.btnTrain)
            Me.Controls.Add(Me.btnInventory)
            Me.Controls.Add(Me.btnShops)
            Me.Controls.Add(Me.btnJail)
            Me.Controls.Add(Me.btnGuild)
            Me.Controls.Add(Me.btnChapel)
            Me.Controls.Add(Me.btnInn)
            Me.Controls.Add(Me.btnBank)
            Me.Controls.Add(Me.btnAssassinate)
            Me.Controls.Add(Me.pnlStats)
            Me.Controls.Add(Me.txtGame)
            Me.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Margin = New Padding(4)
            Me.MaximizeBox = False
            Me.MaximumSize = New Size(674, 525)
            Me.MinimumSize = New Size(674, 525)
            Me.Name = "frmGame"
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.Text = "Assassin"
            Me.pnlStats.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents TxtGame As TextBox
        Friend WithEvents BtnAssassinate As Button
        Friend WithEvents BtnBank As Button
        Friend WithEvents BtnInn As Button
        Friend WithEvents BtnChapel As Button
        Friend WithEvents BtnGuild As Button
        Friend WithEvents BtnJail As Button
        Friend WithEvents BtnShops As Button
        Friend WithEvents BtnInventory As Button
        Friend WithEvents BtnTrain As Button
        Friend WithEvents BtnMystic As Button
        Friend WithEvents BtnOthers As Button
        Friend WithEvents BtnPub As Button
        Friend WithEvents BtnRob As Button
        Friend WithEvents BtnExit As Button
        Friend WithEvents Label12 As Label
        Friend WithEvents Label11 As Label
        Friend WithEvents Label9 As Label
        Friend WithEvents lblArmor As Label
        Friend WithEvents Label5 As Label
        Friend WithEvents lblWeapon As Label
        Friend WithEvents Label8 As Label
        Friend WithEvents lblWeaponName As Label
        Friend WithEvents lblInventory As Label
        Friend WithEvents lblArmorName As Label
        Friend WithEvents lblSpecial As Label
        Friend WithEvents lblEndAmt As Label
        Friend WithEvents lblPotion As Label
        Friend WithEvents Label1 As Label
        Friend WithEvents Label4 As Label
        Friend WithEvents lblGoldLoanAmt As Label
        Friend WithEvents lblTwoAmt As Label
        Friend WithEvents lblGoldBankAmt As Label
        Friend WithEvents lblBlockingAmt As Label
        Friend WithEvents lblGoldLoan As Label
        Friend WithEvents lblHeavyAmt As Label
        Friend WithEvents lblRank As Label
        Friend WithEvents lblSlippingAmt As Label
        Friend WithEvents lblGoldHandAmt As Label
        Friend WithEvents lblWeaponSkills As Label
        Friend WithEvents lblExp As Label
        Friend WithEvents lblStealthAmt As Label
        Friend WithEvents lblExpAmt As Label
        Friend WithEvents lblLightAmt As Label
        Friend WithEvents lblSkillPts As Label
        Friend WithEvents Label3 As Label
        Friend WithEvents lblGoldHand As Label
        Friend WithEvents lblHunger As Label
        Friend WithEvents lblSkillPtsAmt As Label
        Friend WithEvents Label7 As Label
        Friend WithEvents lblName As Label
        Friend WithEvents lblThirst As Label
        Friend WithEvents lblGoldBank As Label
        Friend WithEvents pnlStats As Panel
        Friend WithEvents BtnOptions As Button
        Friend WithEvents BtnMessages As Button
    End Class
End NameSpace