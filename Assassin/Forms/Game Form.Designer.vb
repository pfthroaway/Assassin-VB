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
            Me.components = New System.ComponentModel.Container()
            Me.TxtGame = New System.Windows.Forms.TextBox()
            Me.BtnAssassinate = New System.Windows.Forms.Button()
            Me.BtnBank = New System.Windows.Forms.Button()
            Me.BtnInn = New System.Windows.Forms.Button()
            Me.BtnChapel = New System.Windows.Forms.Button()
            Me.BtnGuild = New System.Windows.Forms.Button()
            Me.BtnJail = New System.Windows.Forms.Button()
            Me.BtnShops = New System.Windows.Forms.Button()
            Me.BtnInventory = New System.Windows.Forms.Button()
            Me.BtnTrain = New System.Windows.Forms.Button()
            Me.BtnMystic = New System.Windows.Forms.Button()
            Me.BtnOthers = New System.Windows.Forms.Button()
            Me.BtnPub = New System.Windows.Forms.Button()
            Me.BtnRob = New System.Windows.Forms.Button()
            Me.BtnExit = New System.Windows.Forms.Button()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.lblArmor = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.lblWeapon = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.lblWeaponName = New System.Windows.Forms.Label()
            Me.lblInventory = New System.Windows.Forms.Label()
            Me.lblArmorName = New System.Windows.Forms.Label()
            Me.lblSpecial = New System.Windows.Forms.Label()
            Me.lblEndAmt = New System.Windows.Forms.Label()
            Me.lblPotion = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.lblGoldLoanAmt = New System.Windows.Forms.Label()
            Me.lblTwoAmt = New System.Windows.Forms.Label()
            Me.lblGoldBankAmt = New System.Windows.Forms.Label()
            Me.lblBlockingAmt = New System.Windows.Forms.Label()
            Me.lblGoldLoan = New System.Windows.Forms.Label()
            Me.lblHeavyAmt = New System.Windows.Forms.Label()
            Me.lblRank = New System.Windows.Forms.Label()
            Me.lblSlippingAmt = New System.Windows.Forms.Label()
            Me.lblGoldHandAmt = New System.Windows.Forms.Label()
            Me.lblWeaponSkills = New System.Windows.Forms.Label()
            Me.lblExp = New System.Windows.Forms.Label()
            Me.lblStealthAmt = New System.Windows.Forms.Label()
            Me.lblExpAmt = New System.Windows.Forms.Label()
            Me.lblLightAmt = New System.Windows.Forms.Label()
            Me.lblSkillPts = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.lblGoldHand = New System.Windows.Forms.Label()
            Me.lblHunger = New System.Windows.Forms.Label()
            Me.lblSkillPtsAmt = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.lblName = New System.Windows.Forms.Label()
            Me.lblThirst = New System.Windows.Forms.Label()
            Me.lblGoldBank = New System.Windows.Forms.Label()
            Me.pnlStats = New System.Windows.Forms.Panel()
            Me.BtnOptions = New System.Windows.Forms.Button()
            Me.BtnMessages = New System.Windows.Forms.Button()
            Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.pnlStats.SuspendLayout()
            Me.SuspendLayout()
            '
            'TxtGame
            '
            Me.TxtGame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.TxtGame.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TxtGame.Location = New System.Drawing.Point(12, 12)
            Me.TxtGame.Multiline = True
            Me.TxtGame.Name = "TxtGame"
            Me.TxtGame.ReadOnly = True
            Me.TxtGame.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.TxtGame.Size = New System.Drawing.Size(400, 286)
            Me.TxtGame.TabIndex = 0
            '
            'BtnAssassinate
            '
            Me.BtnAssassinate.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnAssassinate.Location = New System.Drawing.Point(12, 307)
            Me.BtnAssassinate.Name = "BtnAssassinate"
            Me.BtnAssassinate.Size = New System.Drawing.Size(197, 30)
            Me.BtnAssassinate.TabIndex = 1
            Me.BtnAssassinate.Text = "&Assassinate"
            Me.BtnAssassinate.UseVisualStyleBackColor = True
            '
            'BtnBank
            '
            Me.BtnBank.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnBank.Location = New System.Drawing.Point(12, 343)
            Me.BtnBank.Name = "BtnBank"
            Me.BtnBank.Size = New System.Drawing.Size(95, 30)
            Me.BtnBank.TabIndex = 2
            Me.BtnBank.Text = "&Bank"
            Me.BtnBank.UseVisualStyleBackColor = True
            '
            'BtnInn
            '
            Me.BtnInn.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnInn.Location = New System.Drawing.Point(12, 451)
            Me.BtnInn.Name = "BtnInn"
            Me.BtnInn.Size = New System.Drawing.Size(95, 30)
            Me.BtnInn.TabIndex = 5
            Me.BtnInn.Text = "&Inn"
            Me.BtnInn.UseVisualStyleBackColor = True
            '
            'BtnChapel
            '
            Me.BtnChapel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnChapel.Location = New System.Drawing.Point(12, 379)
            Me.BtnChapel.Name = "BtnChapel"
            Me.BtnChapel.Size = New System.Drawing.Size(95, 30)
            Me.BtnChapel.TabIndex = 3
            Me.BtnChapel.Text = "&Chapel"
            Me.BtnChapel.UseVisualStyleBackColor = True
            '
            'BtnGuild
            '
            Me.BtnGuild.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnGuild.Location = New System.Drawing.Point(12, 415)
            Me.BtnGuild.Name = "BtnGuild"
            Me.BtnGuild.Size = New System.Drawing.Size(95, 30)
            Me.BtnGuild.TabIndex = 4
            Me.BtnGuild.Text = "&Guild"
            Me.BtnGuild.UseVisualStyleBackColor = True
            '
            'BtnJail
            '
            Me.BtnJail.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnJail.Location = New System.Drawing.Point(114, 343)
            Me.BtnJail.Name = "BtnJail"
            Me.BtnJail.Size = New System.Drawing.Size(95, 30)
            Me.BtnJail.TabIndex = 6
            Me.BtnJail.Text = "&Jail"
            Me.BtnJail.UseVisualStyleBackColor = True
            '
            'BtnShops
            '
            Me.BtnShops.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnShops.Location = New System.Drawing.Point(215, 379)
            Me.BtnShops.Name = "BtnShops"
            Me.BtnShops.Size = New System.Drawing.Size(95, 30)
            Me.BtnShops.TabIndex = 14
            Me.BtnShops.Text = "&Shops"
            Me.BtnShops.UseVisualStyleBackColor = True
            '
            'BtnInventory
            '
            Me.BtnInventory.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnInventory.Location = New System.Drawing.Point(215, 307)
            Me.BtnInventory.Name = "BtnInventory"
            Me.BtnInventory.Size = New System.Drawing.Size(196, 30)
            Me.BtnInventory.TabIndex = 10
            Me.BtnInventory.Text = "In&ventory"
            Me.BtnInventory.UseVisualStyleBackColor = True
            '
            'BtnTrain
            '
            Me.BtnTrain.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnTrain.Location = New System.Drawing.Point(215, 415)
            Me.BtnTrain.Name = "BtnTrain"
            Me.BtnTrain.Size = New System.Drawing.Size(95, 30)
            Me.BtnTrain.TabIndex = 15
            Me.BtnTrain.Text = "&Train"
            Me.BtnTrain.UseVisualStyleBackColor = True
            '
            'BtnMystic
            '
            Me.BtnMystic.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnMystic.Location = New System.Drawing.Point(115, 379)
            Me.BtnMystic.Name = "BtnMystic"
            Me.BtnMystic.Size = New System.Drawing.Size(95, 30)
            Me.BtnMystic.TabIndex = 8
            Me.BtnMystic.Text = "M&ystic"
            Me.BtnMystic.UseVisualStyleBackColor = True
            '
            'BtnOthers
            '
            Me.BtnOthers.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnOthers.Location = New System.Drawing.Point(115, 415)
            Me.BtnOthers.Name = "BtnOthers"
            Me.BtnOthers.Size = New System.Drawing.Size(95, 30)
            Me.BtnOthers.TabIndex = 11
            Me.BtnOthers.Text = "Ot&hers"
            Me.BtnOthers.UseVisualStyleBackColor = True
            '
            'BtnPub
            '
            Me.BtnPub.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnPub.Location = New System.Drawing.Point(115, 451)
            Me.BtnPub.Name = "BtnPub"
            Me.BtnPub.Size = New System.Drawing.Size(95, 30)
            Me.BtnPub.TabIndex = 12
            Me.BtnPub.Text = "&Pub"
            Me.BtnPub.UseVisualStyleBackColor = True
            '
            'BtnRob
            '
            Me.BtnRob.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnRob.Location = New System.Drawing.Point(215, 343)
            Me.BtnRob.Name = "BtnRob"
            Me.BtnRob.Size = New System.Drawing.Size(95, 30)
            Me.BtnRob.TabIndex = 13
            Me.BtnRob.Text = "&Rob"
            Me.BtnRob.UseVisualStyleBackColor = True
            '
            'BtnExit
            '
            Me.BtnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.BtnExit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnExit.Location = New System.Drawing.Point(317, 451)
            Me.BtnExit.Name = "BtnExit"
            Me.BtnExit.Size = New System.Drawing.Size(95, 30)
            Me.BtnExit.TabIndex = 16
            Me.BtnExit.Text = "E&xit"
            Me.BtnExit.UseVisualStyleBackColor = True
            '
            'Label12
            '
            Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label12.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label12.Location = New System.Drawing.Point(0, 395)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(115, 23)
            Me.Label12.TabIndex = 81
            Me.Label12.Text = "Blocking:"
            Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label11
            '
            Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label11.Location = New System.Drawing.Point(0, 373)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(115, 23)
            Me.Label11.TabIndex = 71
            Me.Label11.Text = "Two-H Weapon:"
            Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label9
            '
            Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label9.Location = New System.Drawing.Point(0, 351)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(115, 23)
            Me.Label9.TabIndex = 76
            Me.Label9.Text = "Heavy Weapon:"
            Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblArmor
            '
            Me.lblArmor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblArmor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblArmor.Location = New System.Drawing.Point(0, 197)
            Me.lblArmor.Name = "lblArmor"
            Me.lblArmor.Size = New System.Drawing.Size(115, 23)
            Me.lblArmor.TabIndex = 96
            Me.lblArmor.Text = "Armor:"
            Me.lblArmor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label5
            '
            Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.Location = New System.Drawing.Point(0, 329)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(115, 23)
            Me.Label5.TabIndex = 70
            Me.Label5.Text = "Light Weapon:"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblWeapon
            '
            Me.lblWeapon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblWeapon.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblWeapon.Location = New System.Drawing.Point(0, 175)
            Me.lblWeapon.Name = "lblWeapon"
            Me.lblWeapon.Size = New System.Drawing.Size(115, 23)
            Me.lblWeapon.TabIndex = 95
            Me.lblWeapon.Text = "Current Weapon:"
            Me.lblWeapon.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label8
            '
            Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.Location = New System.Drawing.Point(0, 417)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(115, 23)
            Me.Label8.TabIndex = 83
            Me.Label8.Text = "Slipping:"
            Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblWeaponName
            '
            Me.lblWeaponName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblWeaponName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblWeaponName.Location = New System.Drawing.Point(114, 175)
            Me.lblWeaponName.Name = "lblWeaponName"
            Me.lblWeaponName.Size = New System.Drawing.Size(114, 23)
            Me.lblWeaponName.TabIndex = 94
            Me.lblWeaponName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblInventory
            '
            Me.lblInventory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblInventory.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblInventory.Location = New System.Drawing.Point(0, 153)
            Me.lblInventory.Name = "lblInventory"
            Me.lblInventory.Size = New System.Drawing.Size(228, 23)
            Me.lblInventory.TabIndex = 97
            Me.lblInventory.Text = "Inventory:"
            Me.lblInventory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblArmorName
            '
            Me.lblArmorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblArmorName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblArmorName.Location = New System.Drawing.Point(114, 197)
            Me.lblArmorName.Name = "lblArmorName"
            Me.lblArmorName.Size = New System.Drawing.Size(114, 23)
            Me.lblArmorName.TabIndex = 93
            Me.lblArmorName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblSpecial
            '
            Me.lblSpecial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblSpecial.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSpecial.Location = New System.Drawing.Point(0, 219)
            Me.lblSpecial.Name = "lblSpecial"
            Me.lblSpecial.Size = New System.Drawing.Size(115, 23)
            Me.lblSpecial.TabIndex = 98
            Me.lblSpecial.Text = "Potion:"
            Me.lblSpecial.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblEndAmt
            '
            Me.lblEndAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblEndAmt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblEndAmt.Location = New System.Drawing.Point(114, 88)
            Me.lblEndAmt.Name = "lblEndAmt"
            Me.lblEndAmt.Size = New System.Drawing.Size(114, 23)
            Me.lblEndAmt.TabIndex = 91
            Me.lblEndAmt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblPotion
            '
            Me.lblPotion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblPotion.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblPotion.Location = New System.Drawing.Point(114, 219)
            Me.lblPotion.Name = "lblPotion"
            Me.lblPotion.Size = New System.Drawing.Size(114, 23)
            Me.lblPotion.TabIndex = 99
            Me.lblPotion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label1
            '
            Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(0, 88)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(115, 23)
            Me.Label1.TabIndex = 68
            Me.Label1.Text = "Endurance:"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label4
            '
            Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(0, 439)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(115, 23)
            Me.Label4.TabIndex = 84
            Me.Label4.Text = "Stealth:"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblGoldLoanAmt
            '
            Me.lblGoldLoanAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblGoldLoanAmt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblGoldLoanAmt.Location = New System.Drawing.Point(114, 285)
            Me.lblGoldLoanAmt.Name = "lblGoldLoanAmt"
            Me.lblGoldLoanAmt.Size = New System.Drawing.Size(114, 23)
            Me.lblGoldLoanAmt.TabIndex = 88
            Me.lblGoldLoanAmt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblTwoAmt
            '
            Me.lblTwoAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblTwoAmt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTwoAmt.Location = New System.Drawing.Point(114, 373)
            Me.lblTwoAmt.Name = "lblTwoAmt"
            Me.lblTwoAmt.Size = New System.Drawing.Size(114, 23)
            Me.lblTwoAmt.TabIndex = 77
            Me.lblTwoAmt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblGoldBankAmt
            '
            Me.lblGoldBankAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblGoldBankAmt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblGoldBankAmt.Location = New System.Drawing.Point(114, 263)
            Me.lblGoldBankAmt.Name = "lblGoldBankAmt"
            Me.lblGoldBankAmt.Size = New System.Drawing.Size(114, 23)
            Me.lblGoldBankAmt.TabIndex = 89
            Me.lblGoldBankAmt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblBlockingAmt
            '
            Me.lblBlockingAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblBlockingAmt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblBlockingAmt.Location = New System.Drawing.Point(114, 395)
            Me.lblBlockingAmt.Name = "lblBlockingAmt"
            Me.lblBlockingAmt.Size = New System.Drawing.Size(114, 23)
            Me.lblBlockingAmt.TabIndex = 80
            Me.lblBlockingAmt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblGoldLoan
            '
            Me.lblGoldLoan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblGoldLoan.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblGoldLoan.Location = New System.Drawing.Point(0, 285)
            Me.lblGoldLoan.Name = "lblGoldLoan"
            Me.lblGoldLoan.Size = New System.Drawing.Size(115, 23)
            Me.lblGoldLoan.TabIndex = 85
            Me.lblGoldLoan.Text = "Gold on Loan:"
            Me.lblGoldLoan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblHeavyAmt
            '
            Me.lblHeavyAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblHeavyAmt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblHeavyAmt.Location = New System.Drawing.Point(114, 351)
            Me.lblHeavyAmt.Name = "lblHeavyAmt"
            Me.lblHeavyAmt.Size = New System.Drawing.Size(114, 23)
            Me.lblHeavyAmt.TabIndex = 73
            Me.lblHeavyAmt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblRank
            '
            Me.lblRank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblRank.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblRank.Location = New System.Drawing.Point(0, 22)
            Me.lblRank.Name = "lblRank"
            Me.lblRank.Size = New System.Drawing.Size(228, 23)
            Me.lblRank.TabIndex = 74
            Me.lblRank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblSlippingAmt
            '
            Me.lblSlippingAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblSlippingAmt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSlippingAmt.Location = New System.Drawing.Point(114, 417)
            Me.lblSlippingAmt.Name = "lblSlippingAmt"
            Me.lblSlippingAmt.Size = New System.Drawing.Size(114, 23)
            Me.lblSlippingAmt.TabIndex = 87
            Me.lblSlippingAmt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblGoldHandAmt
            '
            Me.lblGoldHandAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblGoldHandAmt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblGoldHandAmt.Location = New System.Drawing.Point(114, 241)
            Me.lblGoldHandAmt.Name = "lblGoldHandAmt"
            Me.lblGoldHandAmt.Size = New System.Drawing.Size(114, 23)
            Me.lblGoldHandAmt.TabIndex = 86
            Me.lblGoldHandAmt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblWeaponSkills
            '
            Me.lblWeaponSkills.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblWeaponSkills.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblWeaponSkills.Location = New System.Drawing.Point(0, 307)
            Me.lblWeaponSkills.Name = "lblWeaponSkills"
            Me.lblWeaponSkills.Size = New System.Drawing.Size(228, 23)
            Me.lblWeaponSkills.TabIndex = 100
            Me.lblWeaponSkills.Text = "Skills:"
            Me.lblWeaponSkills.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblExp
            '
            Me.lblExp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblExp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblExp.Location = New System.Drawing.Point(0, 44)
            Me.lblExp.Name = "lblExp"
            Me.lblExp.Size = New System.Drawing.Size(115, 23)
            Me.lblExp.TabIndex = 75
            Me.lblExp.Text = "Experience:"
            Me.lblExp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblStealthAmt
            '
            Me.lblStealthAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblStealthAmt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblStealthAmt.Location = New System.Drawing.Point(114, 439)
            Me.lblStealthAmt.Name = "lblStealthAmt"
            Me.lblStealthAmt.Size = New System.Drawing.Size(114, 23)
            Me.lblStealthAmt.TabIndex = 90
            Me.lblStealthAmt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblExpAmt
            '
            Me.lblExpAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblExpAmt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblExpAmt.Location = New System.Drawing.Point(114, 44)
            Me.lblExpAmt.Name = "lblExpAmt"
            Me.lblExpAmt.Size = New System.Drawing.Size(114, 23)
            Me.lblExpAmt.TabIndex = 78
            Me.lblExpAmt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblLightAmt
            '
            Me.lblLightAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblLightAmt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblLightAmt.Location = New System.Drawing.Point(114, 329)
            Me.lblLightAmt.Name = "lblLightAmt"
            Me.lblLightAmt.Size = New System.Drawing.Size(114, 23)
            Me.lblLightAmt.TabIndex = 92
            Me.lblLightAmt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblSkillPts
            '
            Me.lblSkillPts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblSkillPts.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSkillPts.Location = New System.Drawing.Point(0, 66)
            Me.lblSkillPts.Name = "lblSkillPts"
            Me.lblSkillPts.Size = New System.Drawing.Size(115, 23)
            Me.lblSkillPts.TabIndex = 72
            Me.lblSkillPts.Text = "Skill Points:"
            Me.lblSkillPts.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label3
            '
            Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(0, 110)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(115, 23)
            Me.Label3.TabIndex = 101
            Me.Label3.Text = "Hunger:"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblGoldHand
            '
            Me.lblGoldHand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblGoldHand.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblGoldHand.Location = New System.Drawing.Point(0, 241)
            Me.lblGoldHand.Name = "lblGoldHand"
            Me.lblGoldHand.Size = New System.Drawing.Size(115, 23)
            Me.lblGoldHand.TabIndex = 82
            Me.lblGoldHand.Text = "Gold on Hand:"
            Me.lblGoldHand.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblHunger
            '
            Me.lblHunger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblHunger.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblHunger.Location = New System.Drawing.Point(114, 110)
            Me.lblHunger.Name = "lblHunger"
            Me.lblHunger.Size = New System.Drawing.Size(114, 23)
            Me.lblHunger.TabIndex = 102
            Me.lblHunger.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblSkillPtsAmt
            '
            Me.lblSkillPtsAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblSkillPtsAmt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSkillPtsAmt.Location = New System.Drawing.Point(114, 66)
            Me.lblSkillPtsAmt.Name = "lblSkillPtsAmt"
            Me.lblSkillPtsAmt.Size = New System.Drawing.Size(114, 23)
            Me.lblSkillPtsAmt.TabIndex = 79
            Me.lblSkillPtsAmt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label7
            '
            Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.Location = New System.Drawing.Point(0, 131)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(115, 23)
            Me.Label7.TabIndex = 103
            Me.Label7.Text = "Thirst:"
            Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblName
            '
            Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblName.Location = New System.Drawing.Point(0, 0)
            Me.lblName.Name = "lblName"
            Me.lblName.Size = New System.Drawing.Size(228, 23)
            Me.lblName.TabIndex = 69
            Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblThirst
            '
            Me.lblThirst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblThirst.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblThirst.Location = New System.Drawing.Point(114, 131)
            Me.lblThirst.Name = "lblThirst"
            Me.lblThirst.Size = New System.Drawing.Size(114, 23)
            Me.lblThirst.TabIndex = 104
            Me.lblThirst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblGoldBank
            '
            Me.lblGoldBank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblGoldBank.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblGoldBank.Location = New System.Drawing.Point(0, 263)
            Me.lblGoldBank.Name = "lblGoldBank"
            Me.lblGoldBank.Size = New System.Drawing.Size(115, 23)
            Me.lblGoldBank.TabIndex = 105
            Me.lblGoldBank.Text = "Gold in Bank:"
            Me.lblGoldBank.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
            Me.pnlStats.Location = New System.Drawing.Point(418, 12)
            Me.pnlStats.Name = "pnlStats"
            Me.pnlStats.Size = New System.Drawing.Size(234, 467)
            Me.pnlStats.TabIndex = 20
            '
            'BtnOptions
            '
            Me.BtnOptions.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnOptions.Location = New System.Drawing.Point(317, 416)
            Me.BtnOptions.Name = "BtnOptions"
            Me.BtnOptions.Size = New System.Drawing.Size(95, 30)
            Me.BtnOptions.TabIndex = 9
            Me.BtnOptions.Text = "&Options"
            Me.BtnOptions.UseVisualStyleBackColor = True
            '
            'BtnMessages
            '
            Me.BtnMessages.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnMessages.Location = New System.Drawing.Point(316, 379)
            Me.BtnMessages.Name = "BtnMessages"
            Me.BtnMessages.Size = New System.Drawing.Size(95, 30)
            Me.BtnMessages.TabIndex = 7
            Me.BtnMessages.Text = "&Messages"
            Me.BtnMessages.UseVisualStyleBackColor = True
            '
            'Timer1
            '
            '
            'FrmGame
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.BtnExit
            Me.ClientSize = New System.Drawing.Size(658, 486)
            Me.Controls.Add(Me.BtnMessages)
            Me.Controls.Add(Me.BtnOptions)
            Me.Controls.Add(Me.BtnExit)
            Me.Controls.Add(Me.BtnRob)
            Me.Controls.Add(Me.BtnPub)
            Me.Controls.Add(Me.BtnOthers)
            Me.Controls.Add(Me.BtnMystic)
            Me.Controls.Add(Me.BtnTrain)
            Me.Controls.Add(Me.BtnInventory)
            Me.Controls.Add(Me.BtnShops)
            Me.Controls.Add(Me.BtnJail)
            Me.Controls.Add(Me.BtnGuild)
            Me.Controls.Add(Me.BtnChapel)
            Me.Controls.Add(Me.BtnInn)
            Me.Controls.Add(Me.BtnBank)
            Me.Controls.Add(Me.BtnAssassinate)
            Me.Controls.Add(Me.pnlStats)
            Me.Controls.Add(Me.TxtGame)
            Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Margin = New System.Windows.Forms.Padding(4)
            Me.MaximizeBox = False
            Me.MaximumSize = New System.Drawing.Size(674, 525)
            Me.MinimumSize = New System.Drawing.Size(674, 525)
            Me.Name = "FrmGame"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
        Friend WithEvents Timer1 As Timer
    End Class
End NameSpace