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
            Me.LblArmor = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.LblWeapon = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.LblWeaponName = New System.Windows.Forms.Label()
            Me.LblInventory = New System.Windows.Forms.Label()
            Me.LblArmorName = New System.Windows.Forms.Label()
            Me.LblSpecial = New System.Windows.Forms.Label()
            Me.LblEndAmt = New System.Windows.Forms.Label()
            Me.LblPotion = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.LblGoldLoanAmt = New System.Windows.Forms.Label()
            Me.LblTwoAmt = New System.Windows.Forms.Label()
            Me.LblGoldBankAmt = New System.Windows.Forms.Label()
            Me.LblBlockingAmt = New System.Windows.Forms.Label()
            Me.LblGoldLoan = New System.Windows.Forms.Label()
            Me.LblHeavyAmt = New System.Windows.Forms.Label()
            Me.LblRank = New System.Windows.Forms.Label()
            Me.LblSlippingAmt = New System.Windows.Forms.Label()
            Me.LblGoldHandAmt = New System.Windows.Forms.Label()
            Me.LblWeaponSkills = New System.Windows.Forms.Label()
            Me.LblExp = New System.Windows.Forms.Label()
            Me.LblStealthAmt = New System.Windows.Forms.Label()
            Me.LblExpAmt = New System.Windows.Forms.Label()
            Me.LblLightAmt = New System.Windows.Forms.Label()
            Me.LblSkillPts = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.LblGoldHand = New System.Windows.Forms.Label()
            Me.LblHunger = New System.Windows.Forms.Label()
            Me.LblSkillPtsAmt = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.LblName = New System.Windows.Forms.Label()
            Me.LblThirst = New System.Windows.Forms.Label()
            Me.LblGoldBank = New System.Windows.Forms.Label()
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
            'LblArmor
            '
            Me.LblArmor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblArmor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblArmor.Location = New System.Drawing.Point(0, 197)
            Me.LblArmor.Name = "LblArmor"
            Me.LblArmor.Size = New System.Drawing.Size(115, 23)
            Me.LblArmor.TabIndex = 96
            Me.LblArmor.Text = "Armor:"
            Me.LblArmor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
            'LblWeapon
            '
            Me.LblWeapon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblWeapon.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblWeapon.Location = New System.Drawing.Point(0, 175)
            Me.LblWeapon.Name = "LblWeapon"
            Me.LblWeapon.Size = New System.Drawing.Size(115, 23)
            Me.LblWeapon.TabIndex = 95
            Me.LblWeapon.Text = "Current Weapon:"
            Me.LblWeapon.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
            'LblWeaponName
            '
            Me.LblWeaponName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblWeaponName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblWeaponName.Location = New System.Drawing.Point(114, 175)
            Me.LblWeaponName.Name = "LblWeaponName"
            Me.LblWeaponName.Size = New System.Drawing.Size(114, 23)
            Me.LblWeaponName.TabIndex = 94
            Me.LblWeaponName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'LblInventory
            '
            Me.LblInventory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblInventory.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblInventory.Location = New System.Drawing.Point(0, 153)
            Me.LblInventory.Name = "LblInventory"
            Me.LblInventory.Size = New System.Drawing.Size(228, 23)
            Me.LblInventory.TabIndex = 97
            Me.LblInventory.Text = "Inventory:"
            Me.LblInventory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'LblArmorName
            '
            Me.LblArmorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblArmorName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblArmorName.Location = New System.Drawing.Point(114, 197)
            Me.LblArmorName.Name = "LblArmorName"
            Me.LblArmorName.Size = New System.Drawing.Size(114, 23)
            Me.LblArmorName.TabIndex = 93
            Me.LblArmorName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'LblSpecial
            '
            Me.LblSpecial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblSpecial.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblSpecial.Location = New System.Drawing.Point(0, 219)
            Me.LblSpecial.Name = "LblSpecial"
            Me.LblSpecial.Size = New System.Drawing.Size(115, 23)
            Me.LblSpecial.TabIndex = 98
            Me.LblSpecial.Text = "Potion:"
            Me.LblSpecial.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'LblEndAmt
            '
            Me.LblEndAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblEndAmt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblEndAmt.Location = New System.Drawing.Point(114, 88)
            Me.LblEndAmt.Name = "LblEndAmt"
            Me.LblEndAmt.Size = New System.Drawing.Size(114, 23)
            Me.LblEndAmt.TabIndex = 91
            Me.LblEndAmt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'LblPotion
            '
            Me.LblPotion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblPotion.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblPotion.Location = New System.Drawing.Point(114, 219)
            Me.LblPotion.Name = "LblPotion"
            Me.LblPotion.Size = New System.Drawing.Size(114, 23)
            Me.LblPotion.TabIndex = 99
            Me.LblPotion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
            'LblGoldLoanAmt
            '
            Me.LblGoldLoanAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblGoldLoanAmt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblGoldLoanAmt.Location = New System.Drawing.Point(114, 285)
            Me.LblGoldLoanAmt.Name = "LblGoldLoanAmt"
            Me.LblGoldLoanAmt.Size = New System.Drawing.Size(114, 23)
            Me.LblGoldLoanAmt.TabIndex = 88
            Me.LblGoldLoanAmt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'LblTwoAmt
            '
            Me.LblTwoAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblTwoAmt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblTwoAmt.Location = New System.Drawing.Point(114, 373)
            Me.LblTwoAmt.Name = "LblTwoAmt"
            Me.LblTwoAmt.Size = New System.Drawing.Size(114, 23)
            Me.LblTwoAmt.TabIndex = 77
            Me.LblTwoAmt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'LblGoldBankAmt
            '
            Me.LblGoldBankAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblGoldBankAmt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblGoldBankAmt.Location = New System.Drawing.Point(114, 263)
            Me.LblGoldBankAmt.Name = "LblGoldBankAmt"
            Me.LblGoldBankAmt.Size = New System.Drawing.Size(114, 23)
            Me.LblGoldBankAmt.TabIndex = 89
            Me.LblGoldBankAmt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'LblBlockingAmt
            '
            Me.LblBlockingAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblBlockingAmt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblBlockingAmt.Location = New System.Drawing.Point(114, 395)
            Me.LblBlockingAmt.Name = "LblBlockingAmt"
            Me.LblBlockingAmt.Size = New System.Drawing.Size(114, 23)
            Me.LblBlockingAmt.TabIndex = 80
            Me.LblBlockingAmt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'LblGoldLoan
            '
            Me.LblGoldLoan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblGoldLoan.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblGoldLoan.Location = New System.Drawing.Point(0, 285)
            Me.LblGoldLoan.Name = "LblGoldLoan"
            Me.LblGoldLoan.Size = New System.Drawing.Size(115, 23)
            Me.LblGoldLoan.TabIndex = 85
            Me.LblGoldLoan.Text = "Gold on Loan:"
            Me.LblGoldLoan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'LblHeavyAmt
            '
            Me.LblHeavyAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblHeavyAmt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblHeavyAmt.Location = New System.Drawing.Point(114, 351)
            Me.LblHeavyAmt.Name = "LblHeavyAmt"
            Me.LblHeavyAmt.Size = New System.Drawing.Size(114, 23)
            Me.LblHeavyAmt.TabIndex = 73
            Me.LblHeavyAmt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'LblRank
            '
            Me.LblRank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblRank.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblRank.Location = New System.Drawing.Point(0, 22)
            Me.LblRank.Name = "LblRank"
            Me.LblRank.Size = New System.Drawing.Size(228, 23)
            Me.LblRank.TabIndex = 74
            Me.LblRank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'LblSlippingAmt
            '
            Me.LblSlippingAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblSlippingAmt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblSlippingAmt.Location = New System.Drawing.Point(114, 417)
            Me.LblSlippingAmt.Name = "LblSlippingAmt"
            Me.LblSlippingAmt.Size = New System.Drawing.Size(114, 23)
            Me.LblSlippingAmt.TabIndex = 87
            Me.LblSlippingAmt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'LblGoldHandAmt
            '
            Me.LblGoldHandAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblGoldHandAmt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblGoldHandAmt.Location = New System.Drawing.Point(114, 241)
            Me.LblGoldHandAmt.Name = "LblGoldHandAmt"
            Me.LblGoldHandAmt.Size = New System.Drawing.Size(114, 23)
            Me.LblGoldHandAmt.TabIndex = 86
            Me.LblGoldHandAmt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'LblWeaponSkills
            '
            Me.LblWeaponSkills.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblWeaponSkills.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblWeaponSkills.Location = New System.Drawing.Point(0, 307)
            Me.LblWeaponSkills.Name = "LblWeaponSkills"
            Me.LblWeaponSkills.Size = New System.Drawing.Size(228, 23)
            Me.LblWeaponSkills.TabIndex = 100
            Me.LblWeaponSkills.Text = "Skills:"
            Me.LblWeaponSkills.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'LblExp
            '
            Me.LblExp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblExp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblExp.Location = New System.Drawing.Point(0, 44)
            Me.LblExp.Name = "LblExp"
            Me.LblExp.Size = New System.Drawing.Size(115, 23)
            Me.LblExp.TabIndex = 75
            Me.LblExp.Text = "Experience:"
            Me.LblExp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'LblStealthAmt
            '
            Me.LblStealthAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblStealthAmt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblStealthAmt.Location = New System.Drawing.Point(114, 439)
            Me.LblStealthAmt.Name = "LblStealthAmt"
            Me.LblStealthAmt.Size = New System.Drawing.Size(114, 23)
            Me.LblStealthAmt.TabIndex = 90
            Me.LblStealthAmt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'LblExpAmt
            '
            Me.LblExpAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblExpAmt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblExpAmt.Location = New System.Drawing.Point(114, 44)
            Me.LblExpAmt.Name = "LblExpAmt"
            Me.LblExpAmt.Size = New System.Drawing.Size(114, 23)
            Me.LblExpAmt.TabIndex = 78
            Me.LblExpAmt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'LblLightAmt
            '
            Me.LblLightAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblLightAmt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblLightAmt.Location = New System.Drawing.Point(114, 329)
            Me.LblLightAmt.Name = "LblLightAmt"
            Me.LblLightAmt.Size = New System.Drawing.Size(114, 23)
            Me.LblLightAmt.TabIndex = 92
            Me.LblLightAmt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'LblSkillPts
            '
            Me.LblSkillPts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblSkillPts.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblSkillPts.Location = New System.Drawing.Point(0, 66)
            Me.LblSkillPts.Name = "LblSkillPts"
            Me.LblSkillPts.Size = New System.Drawing.Size(115, 23)
            Me.LblSkillPts.TabIndex = 72
            Me.LblSkillPts.Text = "Skill Points:"
            Me.LblSkillPts.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
            'LblGoldHand
            '
            Me.LblGoldHand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblGoldHand.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblGoldHand.Location = New System.Drawing.Point(0, 241)
            Me.LblGoldHand.Name = "LblGoldHand"
            Me.LblGoldHand.Size = New System.Drawing.Size(115, 23)
            Me.LblGoldHand.TabIndex = 82
            Me.LblGoldHand.Text = "Gold on Hand:"
            Me.LblGoldHand.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'LblHunger
            '
            Me.LblHunger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblHunger.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblHunger.Location = New System.Drawing.Point(114, 110)
            Me.LblHunger.Name = "LblHunger"
            Me.LblHunger.Size = New System.Drawing.Size(114, 23)
            Me.LblHunger.TabIndex = 102
            Me.LblHunger.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'LblSkillPtsAmt
            '
            Me.LblSkillPtsAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblSkillPtsAmt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblSkillPtsAmt.Location = New System.Drawing.Point(114, 66)
            Me.LblSkillPtsAmt.Name = "LblSkillPtsAmt"
            Me.LblSkillPtsAmt.Size = New System.Drawing.Size(114, 23)
            Me.LblSkillPtsAmt.TabIndex = 79
            Me.LblSkillPtsAmt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
            'LblName
            '
            Me.LblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblName.Location = New System.Drawing.Point(0, 0)
            Me.LblName.Name = "LblName"
            Me.LblName.Size = New System.Drawing.Size(228, 23)
            Me.LblName.TabIndex = 69
            Me.LblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'LblThirst
            '
            Me.LblThirst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblThirst.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblThirst.Location = New System.Drawing.Point(114, 131)
            Me.LblThirst.Name = "LblThirst"
            Me.LblThirst.Size = New System.Drawing.Size(114, 23)
            Me.LblThirst.TabIndex = 104
            Me.LblThirst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'LblGoldBank
            '
            Me.LblGoldBank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblGoldBank.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblGoldBank.Location = New System.Drawing.Point(0, 263)
            Me.LblGoldBank.Name = "LblGoldBank"
            Me.LblGoldBank.Size = New System.Drawing.Size(115, 23)
            Me.LblGoldBank.TabIndex = 105
            Me.LblGoldBank.Text = "Gold in Bank:"
            Me.LblGoldBank.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'pnlStats
            '
            Me.pnlStats.Controls.Add(Me.LblGoldBank)
            Me.pnlStats.Controls.Add(Me.LblThirst)
            Me.pnlStats.Controls.Add(Me.LblName)
            Me.pnlStats.Controls.Add(Me.Label7)
            Me.pnlStats.Controls.Add(Me.LblSkillPtsAmt)
            Me.pnlStats.Controls.Add(Me.LblHunger)
            Me.pnlStats.Controls.Add(Me.LblGoldHand)
            Me.pnlStats.Controls.Add(Me.Label3)
            Me.pnlStats.Controls.Add(Me.LblSkillPts)
            Me.pnlStats.Controls.Add(Me.LblLightAmt)
            Me.pnlStats.Controls.Add(Me.LblExpAmt)
            Me.pnlStats.Controls.Add(Me.LblStealthAmt)
            Me.pnlStats.Controls.Add(Me.LblExp)
            Me.pnlStats.Controls.Add(Me.LblWeaponSkills)
            Me.pnlStats.Controls.Add(Me.LblGoldHandAmt)
            Me.pnlStats.Controls.Add(Me.LblSlippingAmt)
            Me.pnlStats.Controls.Add(Me.LblRank)
            Me.pnlStats.Controls.Add(Me.LblHeavyAmt)
            Me.pnlStats.Controls.Add(Me.LblGoldLoan)
            Me.pnlStats.Controls.Add(Me.LblBlockingAmt)
            Me.pnlStats.Controls.Add(Me.LblGoldBankAmt)
            Me.pnlStats.Controls.Add(Me.LblTwoAmt)
            Me.pnlStats.Controls.Add(Me.LblGoldLoanAmt)
            Me.pnlStats.Controls.Add(Me.Label4)
            Me.pnlStats.Controls.Add(Me.Label1)
            Me.pnlStats.Controls.Add(Me.LblPotion)
            Me.pnlStats.Controls.Add(Me.LblEndAmt)
            Me.pnlStats.Controls.Add(Me.LblSpecial)
            Me.pnlStats.Controls.Add(Me.LblArmorName)
            Me.pnlStats.Controls.Add(Me.LblInventory)
            Me.pnlStats.Controls.Add(Me.LblWeaponName)
            Me.pnlStats.Controls.Add(Me.Label8)
            Me.pnlStats.Controls.Add(Me.LblWeapon)
            Me.pnlStats.Controls.Add(Me.Label5)
            Me.pnlStats.Controls.Add(Me.LblArmor)
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
        Friend WithEvents LblArmor As Label
        Friend WithEvents Label5 As Label
        Friend WithEvents LblWeapon As Label
        Friend WithEvents Label8 As Label
        Friend WithEvents LblWeaponName As Label
        Friend WithEvents LblInventory As Label
        Friend WithEvents LblArmorName As Label
        Friend WithEvents LblSpecial As Label
        Friend WithEvents LblEndAmt As Label
        Friend WithEvents LblPotion As Label
        Friend WithEvents Label1 As Label
        Friend WithEvents Label4 As Label
        Friend WithEvents LblGoldLoanAmt As Label
        Friend WithEvents LblTwoAmt As Label
        Friend WithEvents LblGoldBankAmt As Label
        Friend WithEvents LblBlockingAmt As Label
        Friend WithEvents LblGoldLoan As Label
        Friend WithEvents LblHeavyAmt As Label
        Friend WithEvents LblRank As Label
        Friend WithEvents LblSlippingAmt As Label
        Friend WithEvents LblGoldHandAmt As Label
        Friend WithEvents LblWeaponSkills As Label
        Friend WithEvents LblExp As Label
        Friend WithEvents LblStealthAmt As Label
        Friend WithEvents LblExpAmt As Label
        Friend WithEvents LblLightAmt As Label
        Friend WithEvents LblSkillPts As Label
        Friend WithEvents Label3 As Label
        Friend WithEvents LblGoldHand As Label
        Friend WithEvents LblHunger As Label
        Friend WithEvents LblSkillPtsAmt As Label
        Friend WithEvents Label7 As Label
        Friend WithEvents LblName As Label
        Friend WithEvents LblThirst As Label
        Friend WithEvents LblGoldBank As Label
        Friend WithEvents pnlStats As Panel
        Friend WithEvents BtnOptions As Button
        Friend WithEvents BtnMessages As Button
        Friend WithEvents Timer1 As Timer
    End Class
End NameSpace