Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

Namespace Forms
    <DesignerGenerated()> _
    Partial Class FrmNewUser
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
            Me.components = New Container()
            Me.lblName = New Label()
            Me.lblLightWeapons = New Label()
            Me.lblBlocking = New Label()
            Me.lblTwoHandedWeapons = New Label()
            Me.lblHeavyWeapons = New Label()
            Me.lblEndurance = New Label()
            Me.txtName = New TextBox()
            Me.lblSlipping = New Label()
            Me.lblStealth = New Label()
            Me.lblEndCurr = New Label()
            Me.lblLightCurr = New Label()
            Me.lblHeavyCurr = New Label()
            Me.lblTwoCurr = New Label()
            Me.lblBlockingCurr = New Label()
            Me.lblSlippingCurr = New Label()
            Me.lblStealthCurr = New Label()
            Me.btnEndMinus = New Button()
            Me.btnEndPlus = New Button()
            Me.btnLightPlus = New Button()
            Me.btnLightMinus = New Button()
            Me.btnHeavyPlus = New Button()
            Me.btnHeavyMinus = New Button()
            Me.btnTwoPlus = New Button()
            Me.btnTwoMinus = New Button()
            Me.btnBlockPlus = New Button()
            Me.btnBlockMinus = New Button()
            Me.btnSlippingPlus = New Button()
            Me.btnSlippingMinus = New Button()
            Me.btnStealthPlus = New Button()
            Me.btnStealthMinus = New Button()
            Me.lblSkillPts = New Label()
            Me.lblSkill = New Label()
            Me.btnCreate = New Button()
            Me.btnClear = New Button()
            Me.btnExit = New Button()
            Me.Timer1 = New Timer(Me.components)
            Me.Timer2 = New Timer(Me.components)
            Me.txtPass = New TextBox()
            Me.lblPass = New Label()
            Me.txtConfirm = New TextBox()
            Me.lblConfirm = New Label()
            Me.SuspendLayout()
            '
            'lblName
            '
            Me.lblName.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblName.Location = New Point(48, 9)
            Me.lblName.Margin = New Padding(4, 0, 4, 0)
            Me.lblName.Name = "lblName"
            Me.lblName.Size = New Size(100, 25)
            Me.lblName.TabIndex = 0
            Me.lblName.Text = "Name:"
            Me.lblName.TextAlign = ContentAlignment.MiddleRight
            '
            'lblLightWeapons
            '
            Me.lblLightWeapons.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblLightWeapons.Location = New Point(13, 159)
            Me.lblLightWeapons.Margin = New Padding(4, 0, 4, 0)
            Me.lblLightWeapons.Name = "lblLightWeapons"
            Me.lblLightWeapons.Size = New Size(135, 25)
            Me.lblLightWeapons.TabIndex = 1
            Me.lblLightWeapons.Text = "Light Weapons:"
            Me.lblLightWeapons.TextAlign = ContentAlignment.MiddleRight
            '
            'lblBlocking
            '
            Me.lblBlocking.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblBlocking.Location = New Point(13, 255)
            Me.lblBlocking.Margin = New Padding(4, 0, 4, 0)
            Me.lblBlocking.Name = "lblBlocking"
            Me.lblBlocking.Size = New Size(135, 25)
            Me.lblBlocking.TabIndex = 2
            Me.lblBlocking.Text = "Blocking:"
            Me.lblBlocking.TextAlign = ContentAlignment.MiddleRight
            '
            'lblTwoHandedWeapons
            '
            Me.lblTwoHandedWeapons.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblTwoHandedWeapons.Location = New Point(13, 223)
            Me.lblTwoHandedWeapons.Margin = New Padding(4, 0, 4, 0)
            Me.lblTwoHandedWeapons.Name = "lblTwoHandedWeapons"
            Me.lblTwoHandedWeapons.Size = New Size(135, 25)
            Me.lblTwoHandedWeapons.TabIndex = 3
            Me.lblTwoHandedWeapons.Text = "Two-H Weapons:"
            Me.lblTwoHandedWeapons.TextAlign = ContentAlignment.MiddleRight
            '
            'lblHeavyWeapons
            '
            Me.lblHeavyWeapons.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblHeavyWeapons.Location = New Point(13, 191)
            Me.lblHeavyWeapons.Margin = New Padding(4, 0, 4, 0)
            Me.lblHeavyWeapons.Name = "lblHeavyWeapons"
            Me.lblHeavyWeapons.Size = New Size(135, 25)
            Me.lblHeavyWeapons.TabIndex = 4
            Me.lblHeavyWeapons.Text = "Heavy Weapons:"
            Me.lblHeavyWeapons.TextAlign = ContentAlignment.MiddleRight
            '
            'lblEndurance
            '
            Me.lblEndurance.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblEndurance.Location = New Point(13, 127)
            Me.lblEndurance.Margin = New Padding(4, 0, 4, 0)
            Me.lblEndurance.Name = "lblEndurance"
            Me.lblEndurance.Size = New Size(135, 25)
            Me.lblEndurance.TabIndex = 5
            Me.lblEndurance.Text = "Endurance:"
            Me.lblEndurance.TextAlign = ContentAlignment.MiddleRight
            '
            'txtName
            '
            Me.txtName.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.txtName.Location = New Point(156, 9)
            Me.txtName.Margin = New Padding(4)
            Me.txtName.MaxLength = 30
            Me.txtName.Name = "txtName"
            Me.txtName.Size = New Size(126, 26)
            Me.txtName.TabIndex = 0
            Me.txtName.TextAlign = HorizontalAlignment.Center
            '
            'lblSlipping
            '
            Me.lblSlipping.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblSlipping.Location = New Point(13, 287)
            Me.lblSlipping.Margin = New Padding(4, 0, 4, 0)
            Me.lblSlipping.Name = "lblSlipping"
            Me.lblSlipping.Size = New Size(135, 25)
            Me.lblSlipping.TabIndex = 7
            Me.lblSlipping.Text = "Slipping:"
            Me.lblSlipping.TextAlign = ContentAlignment.MiddleRight
            '
            'lblStealth
            '
            Me.lblStealth.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblStealth.Location = New Point(13, 318)
            Me.lblStealth.Margin = New Padding(4, 0, 4, 0)
            Me.lblStealth.Name = "lblStealth"
            Me.lblStealth.Size = New Size(135, 25)
            Me.lblStealth.TabIndex = 8
            Me.lblStealth.Text = "Stealth:"
            Me.lblStealth.TextAlign = ContentAlignment.MiddleRight
            '
            'lblEndCurr
            '
            Me.lblEndCurr.BorderStyle = BorderStyle.FixedSingle
            Me.lblEndCurr.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblEndCurr.Location = New Point(156, 127)
            Me.lblEndCurr.Margin = New Padding(4, 0, 4, 0)
            Me.lblEndCurr.Name = "lblEndCurr"
            Me.lblEndCurr.Size = New Size(50, 25)
            Me.lblEndCurr.TabIndex = 9
            Me.lblEndCurr.Text = "100"
            Me.lblEndCurr.TextAlign = ContentAlignment.MiddleCenter
            '
            'lblLightCurr
            '
            Me.lblLightCurr.BorderStyle = BorderStyle.FixedSingle
            Me.lblLightCurr.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblLightCurr.Location = New Point(156, 159)
            Me.lblLightCurr.Margin = New Padding(4, 0, 4, 0)
            Me.lblLightCurr.Name = "lblLightCurr"
            Me.lblLightCurr.Size = New Size(50, 25)
            Me.lblLightCurr.TabIndex = 10
            Me.lblLightCurr.Text = "10%"
            Me.lblLightCurr.TextAlign = ContentAlignment.MiddleCenter
            '
            'lblHeavyCurr
            '
            Me.lblHeavyCurr.BorderStyle = BorderStyle.FixedSingle
            Me.lblHeavyCurr.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblHeavyCurr.Location = New Point(156, 191)
            Me.lblHeavyCurr.Margin = New Padding(4, 0, 4, 0)
            Me.lblHeavyCurr.Name = "lblHeavyCurr"
            Me.lblHeavyCurr.Size = New Size(50, 25)
            Me.lblHeavyCurr.TabIndex = 11
            Me.lblHeavyCurr.Text = "10%"
            Me.lblHeavyCurr.TextAlign = ContentAlignment.MiddleCenter
            '
            'lblTwoCurr
            '
            Me.lblTwoCurr.BorderStyle = BorderStyle.FixedSingle
            Me.lblTwoCurr.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblTwoCurr.Location = New Point(156, 223)
            Me.lblTwoCurr.Margin = New Padding(4, 0, 4, 0)
            Me.lblTwoCurr.Name = "lblTwoCurr"
            Me.lblTwoCurr.Size = New Size(50, 25)
            Me.lblTwoCurr.TabIndex = 12
            Me.lblTwoCurr.Text = "10%"
            Me.lblTwoCurr.TextAlign = ContentAlignment.MiddleCenter
            '
            'lblBlockingCurr
            '
            Me.lblBlockingCurr.BorderStyle = BorderStyle.FixedSingle
            Me.lblBlockingCurr.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblBlockingCurr.Location = New Point(156, 255)
            Me.lblBlockingCurr.Margin = New Padding(4, 0, 4, 0)
            Me.lblBlockingCurr.Name = "lblBlockingCurr"
            Me.lblBlockingCurr.Size = New Size(50, 25)
            Me.lblBlockingCurr.TabIndex = 13
            Me.lblBlockingCurr.Text = "10%"
            Me.lblBlockingCurr.TextAlign = ContentAlignment.MiddleCenter
            '
            'lblSlippingCurr
            '
            Me.lblSlippingCurr.BorderStyle = BorderStyle.FixedSingle
            Me.lblSlippingCurr.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblSlippingCurr.Location = New Point(156, 287)
            Me.lblSlippingCurr.Margin = New Padding(4, 0, 4, 0)
            Me.lblSlippingCurr.Name = "lblSlippingCurr"
            Me.lblSlippingCurr.Size = New Size(50, 25)
            Me.lblSlippingCurr.TabIndex = 14
            Me.lblSlippingCurr.Text = "10%"
            Me.lblSlippingCurr.TextAlign = ContentAlignment.MiddleCenter
            '
            'lblStealthCurr
            '
            Me.lblStealthCurr.BorderStyle = BorderStyle.FixedSingle
            Me.lblStealthCurr.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblStealthCurr.Location = New Point(156, 318)
            Me.lblStealthCurr.Margin = New Padding(4, 0, 4, 0)
            Me.lblStealthCurr.Name = "lblStealthCurr"
            Me.lblStealthCurr.Size = New Size(50, 25)
            Me.lblStealthCurr.TabIndex = 15
            Me.lblStealthCurr.Text = "10%"
            Me.lblStealthCurr.TextAlign = ContentAlignment.MiddleCenter
            '
            'btnEndMinus
            '
            Me.btnEndMinus.Enabled = False
            Me.btnEndMinus.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnEndMinus.Location = New Point(214, 127)
            Me.btnEndMinus.Margin = New Padding(4)
            Me.btnEndMinus.Name = "btnEndMinus"
            Me.btnEndMinus.Size = New Size(30, 25)
            Me.btnEndMinus.TabIndex = 3
            Me.btnEndMinus.Text = "-"
            Me.btnEndMinus.TextAlign = ContentAlignment.BottomCenter
            Me.btnEndMinus.UseVisualStyleBackColor = True
            '
            'btnEndPlus
            '
            Me.btnEndPlus.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnEndPlus.Location = New Point(252, 127)
            Me.btnEndPlus.Margin = New Padding(4)
            Me.btnEndPlus.Name = "btnEndPlus"
            Me.btnEndPlus.Size = New Size(30, 25)
            Me.btnEndPlus.TabIndex = 4
            Me.btnEndPlus.Text = "+"
            Me.btnEndPlus.TextAlign = ContentAlignment.BottomCenter
            Me.btnEndPlus.UseVisualStyleBackColor = True
            '
            'btnLightPlus
            '
            Me.btnLightPlus.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnLightPlus.Location = New Point(252, 159)
            Me.btnLightPlus.Margin = New Padding(4)
            Me.btnLightPlus.Name = "btnLightPlus"
            Me.btnLightPlus.Size = New Size(30, 25)
            Me.btnLightPlus.TabIndex = 6
            Me.btnLightPlus.Text = "+"
            Me.btnLightPlus.TextAlign = ContentAlignment.BottomCenter
            Me.btnLightPlus.UseVisualStyleBackColor = True
            '
            'btnLightMinus
            '
            Me.btnLightMinus.Enabled = False
            Me.btnLightMinus.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnLightMinus.Location = New Point(214, 159)
            Me.btnLightMinus.Margin = New Padding(4)
            Me.btnLightMinus.Name = "btnLightMinus"
            Me.btnLightMinus.Size = New Size(30, 25)
            Me.btnLightMinus.TabIndex = 5
            Me.btnLightMinus.Text = "-"
            Me.btnLightMinus.TextAlign = ContentAlignment.BottomCenter
            Me.btnLightMinus.UseVisualStyleBackColor = True
            '
            'btnHeavyPlus
            '
            Me.btnHeavyPlus.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnHeavyPlus.Location = New Point(252, 191)
            Me.btnHeavyPlus.Margin = New Padding(4)
            Me.btnHeavyPlus.Name = "btnHeavyPlus"
            Me.btnHeavyPlus.Size = New Size(30, 25)
            Me.btnHeavyPlus.TabIndex = 8
            Me.btnHeavyPlus.Text = "+"
            Me.btnHeavyPlus.TextAlign = ContentAlignment.BottomCenter
            Me.btnHeavyPlus.UseVisualStyleBackColor = True
            '
            'btnHeavyMinus
            '
            Me.btnHeavyMinus.Enabled = False
            Me.btnHeavyMinus.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnHeavyMinus.Location = New Point(214, 191)
            Me.btnHeavyMinus.Margin = New Padding(4)
            Me.btnHeavyMinus.Name = "btnHeavyMinus"
            Me.btnHeavyMinus.Size = New Size(30, 25)
            Me.btnHeavyMinus.TabIndex = 7
            Me.btnHeavyMinus.Text = "-"
            Me.btnHeavyMinus.TextAlign = ContentAlignment.BottomCenter
            Me.btnHeavyMinus.UseVisualStyleBackColor = True
            '
            'btnTwoPlus
            '
            Me.btnTwoPlus.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnTwoPlus.Location = New Point(252, 223)
            Me.btnTwoPlus.Margin = New Padding(4)
            Me.btnTwoPlus.Name = "btnTwoPlus"
            Me.btnTwoPlus.Size = New Size(30, 25)
            Me.btnTwoPlus.TabIndex = 10
            Me.btnTwoPlus.Text = "+"
            Me.btnTwoPlus.TextAlign = ContentAlignment.BottomCenter
            Me.btnTwoPlus.UseVisualStyleBackColor = True
            '
            'btnTwoMinus
            '
            Me.btnTwoMinus.Enabled = False
            Me.btnTwoMinus.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnTwoMinus.Location = New Point(214, 223)
            Me.btnTwoMinus.Margin = New Padding(4)
            Me.btnTwoMinus.Name = "btnTwoMinus"
            Me.btnTwoMinus.Size = New Size(30, 25)
            Me.btnTwoMinus.TabIndex = 9
            Me.btnTwoMinus.Text = "-"
            Me.btnTwoMinus.TextAlign = ContentAlignment.BottomCenter
            Me.btnTwoMinus.UseVisualStyleBackColor = True
            '
            'btnBlockPlus
            '
            Me.btnBlockPlus.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnBlockPlus.Location = New Point(252, 255)
            Me.btnBlockPlus.Margin = New Padding(4)
            Me.btnBlockPlus.Name = "btnBlockPlus"
            Me.btnBlockPlus.Size = New Size(30, 25)
            Me.btnBlockPlus.TabIndex = 12
            Me.btnBlockPlus.Text = "+"
            Me.btnBlockPlus.TextAlign = ContentAlignment.BottomCenter
            Me.btnBlockPlus.UseVisualStyleBackColor = True
            '
            'btnBlockMinus
            '
            Me.btnBlockMinus.Enabled = False
            Me.btnBlockMinus.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnBlockMinus.Location = New Point(214, 255)
            Me.btnBlockMinus.Margin = New Padding(4)
            Me.btnBlockMinus.Name = "btnBlockMinus"
            Me.btnBlockMinus.Size = New Size(30, 25)
            Me.btnBlockMinus.TabIndex = 11
            Me.btnBlockMinus.Text = "-"
            Me.btnBlockMinus.TextAlign = ContentAlignment.BottomCenter
            Me.btnBlockMinus.UseVisualStyleBackColor = True
            '
            'btnSlippingPlus
            '
            Me.btnSlippingPlus.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnSlippingPlus.Location = New Point(252, 287)
            Me.btnSlippingPlus.Margin = New Padding(4)
            Me.btnSlippingPlus.Name = "btnSlippingPlus"
            Me.btnSlippingPlus.Size = New Size(30, 25)
            Me.btnSlippingPlus.TabIndex = 14
            Me.btnSlippingPlus.Text = "+"
            Me.btnSlippingPlus.TextAlign = ContentAlignment.BottomCenter
            Me.btnSlippingPlus.UseVisualStyleBackColor = True
            '
            'btnSlippingMinus
            '
            Me.btnSlippingMinus.Enabled = False
            Me.btnSlippingMinus.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnSlippingMinus.Location = New Point(214, 287)
            Me.btnSlippingMinus.Margin = New Padding(4)
            Me.btnSlippingMinus.Name = "btnSlippingMinus"
            Me.btnSlippingMinus.Size = New Size(30, 25)
            Me.btnSlippingMinus.TabIndex = 13
            Me.btnSlippingMinus.Text = "-"
            Me.btnSlippingMinus.TextAlign = ContentAlignment.BottomCenter
            Me.btnSlippingMinus.UseVisualStyleBackColor = True
            '
            'btnStealthPlus
            '
            Me.btnStealthPlus.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnStealthPlus.Location = New Point(252, 318)
            Me.btnStealthPlus.Margin = New Padding(4)
            Me.btnStealthPlus.Name = "btnStealthPlus"
            Me.btnStealthPlus.Size = New Size(30, 25)
            Me.btnStealthPlus.TabIndex = 16
            Me.btnStealthPlus.Text = "+"
            Me.btnStealthPlus.TextAlign = ContentAlignment.BottomCenter
            Me.btnStealthPlus.UseVisualStyleBackColor = True
            '
            'btnStealthMinus
            '
            Me.btnStealthMinus.Enabled = False
            Me.btnStealthMinus.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnStealthMinus.Location = New Point(214, 318)
            Me.btnStealthMinus.Margin = New Padding(4)
            Me.btnStealthMinus.Name = "btnStealthMinus"
            Me.btnStealthMinus.Size = New Size(30, 25)
            Me.btnStealthMinus.TabIndex = 15
            Me.btnStealthMinus.Text = "-"
            Me.btnStealthMinus.TextAlign = ContentAlignment.BottomCenter
            Me.btnStealthMinus.UseVisualStyleBackColor = True
            '
            'lblSkillPts
            '
            Me.lblSkillPts.BorderStyle = BorderStyle.FixedSingle
            Me.lblSkillPts.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblSkillPts.Location = New Point(214, 367)
            Me.lblSkillPts.Margin = New Padding(4, 0, 4, 0)
            Me.lblSkillPts.Name = "lblSkillPts"
            Me.lblSkillPts.Size = New Size(68, 25)
            Me.lblSkillPts.TabIndex = 31
            Me.lblSkillPts.Text = "5"
            Me.lblSkillPts.TextAlign = ContentAlignment.MiddleCenter
            '
            'lblSkill
            '
            Me.lblSkill.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblSkill.Location = New Point(13, 367)
            Me.lblSkill.Margin = New Padding(4, 0, 4, 0)
            Me.lblSkill.Name = "lblSkill"
            Me.lblSkill.Size = New Size(193, 25)
            Me.lblSkill.TabIndex = 30
            Me.lblSkill.Text = "Skill Points:"
            Me.lblSkill.TextAlign = ContentAlignment.MiddleRight
            '
            'btnCreate
            '
            Me.btnCreate.Enabled = False
            Me.btnCreate.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnCreate.Location = New Point(13, 417)
            Me.btnCreate.Margin = New Padding(4)
            Me.btnCreate.Name = "btnCreate"
            Me.btnCreate.Size = New Size(80, 30)
            Me.btnCreate.TabIndex = 17
            Me.btnCreate.Text = "&Create"
            Me.btnCreate.UseVisualStyleBackColor = True
            '
            'btnClear
            '
            Me.btnClear.Enabled = False
            Me.btnClear.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnClear.Location = New Point(107, 417)
            Me.btnClear.Margin = New Padding(4)
            Me.btnClear.Name = "btnClear"
            Me.btnClear.Size = New Size(80, 30)
            Me.btnClear.TabIndex = 18
            Me.btnClear.Text = "C&lear"
            Me.btnClear.UseVisualStyleBackColor = True
            '
            'btnExit
            '
            Me.btnExit.DialogResult = DialogResult.Cancel
            Me.btnExit.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnExit.Location = New Point(202, 417)
            Me.btnExit.Margin = New Padding(4)
            Me.btnExit.Name = "btnExit"
            Me.btnExit.Size = New Size(80, 30)
            Me.btnExit.TabIndex = 19
            Me.btnExit.Text = "E&xit"
            Me.btnExit.UseVisualStyleBackColor = True
            '
            'Timer1
            '
            Me.Timer1.Interval = 1000
            '
            'Timer2
            '
            Me.Timer2.Interval = 1000
            '
            'txtPass
            '
            Me.txtPass.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.txtPass.Location = New Point(156, 43)
            Me.txtPass.Margin = New Padding(4)
            Me.txtPass.MaxLength = 16
            Me.txtPass.Name = "txtPass"
            Me.txtPass.Size = New Size(126, 26)
            Me.txtPass.TabIndex = 1
            Me.txtPass.TextAlign = HorizontalAlignment.Center
            Me.txtPass.UseSystemPasswordChar = True
            '
            'lblPass
            '
            Me.lblPass.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblPass.Location = New Point(48, 43)
            Me.lblPass.Margin = New Padding(4, 0, 4, 0)
            Me.lblPass.Name = "lblPass"
            Me.lblPass.Size = New Size(100, 25)
            Me.lblPass.TabIndex = 35
            Me.lblPass.Text = "Password:"
            Me.lblPass.TextAlign = ContentAlignment.MiddleRight
            '
            'txtConfirm
            '
            Me.txtConfirm.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.txtConfirm.Location = New Point(156, 77)
            Me.txtConfirm.Margin = New Padding(4)
            Me.txtConfirm.MaxLength = 16
            Me.txtConfirm.Name = "txtConfirm"
            Me.txtConfirm.Size = New Size(126, 26)
            Me.txtConfirm.TabIndex = 2
            Me.txtConfirm.TextAlign = HorizontalAlignment.Center
            Me.txtConfirm.UseSystemPasswordChar = True
            '
            'lblConfirm
            '
            Me.lblConfirm.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblConfirm.Location = New Point(48, 78)
            Me.lblConfirm.Margin = New Padding(4, 0, 4, 0)
            Me.lblConfirm.Name = "lblConfirm"
            Me.lblConfirm.Size = New Size(100, 25)
            Me.lblConfirm.TabIndex = 37
            Me.lblConfirm.Text = "Confirm:"
            Me.lblConfirm.TextAlign = ContentAlignment.MiddleRight
            '
            'frmNewUser
            '
            Me.AutoScaleDimensions = New SizeF(9.0!, 18.0!)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.CancelButton = Me.btnExit
            Me.ClientSize = New Size(295, 459)
            Me.Controls.Add(Me.txtConfirm)
            Me.Controls.Add(Me.lblConfirm)
            Me.Controls.Add(Me.txtPass)
            Me.Controls.Add(Me.lblPass)
            Me.Controls.Add(Me.btnExit)
            Me.Controls.Add(Me.btnClear)
            Me.Controls.Add(Me.btnCreate)
            Me.Controls.Add(Me.lblSkillPts)
            Me.Controls.Add(Me.lblSkill)
            Me.Controls.Add(Me.btnStealthPlus)
            Me.Controls.Add(Me.btnStealthMinus)
            Me.Controls.Add(Me.btnSlippingPlus)
            Me.Controls.Add(Me.btnSlippingMinus)
            Me.Controls.Add(Me.btnBlockPlus)
            Me.Controls.Add(Me.btnBlockMinus)
            Me.Controls.Add(Me.btnTwoPlus)
            Me.Controls.Add(Me.btnTwoMinus)
            Me.Controls.Add(Me.btnHeavyPlus)
            Me.Controls.Add(Me.btnHeavyMinus)
            Me.Controls.Add(Me.btnLightPlus)
            Me.Controls.Add(Me.btnLightMinus)
            Me.Controls.Add(Me.btnEndPlus)
            Me.Controls.Add(Me.btnEndMinus)
            Me.Controls.Add(Me.lblStealthCurr)
            Me.Controls.Add(Me.lblSlippingCurr)
            Me.Controls.Add(Me.lblBlockingCurr)
            Me.Controls.Add(Me.lblTwoCurr)
            Me.Controls.Add(Me.lblHeavyCurr)
            Me.Controls.Add(Me.lblLightCurr)
            Me.Controls.Add(Me.lblEndCurr)
            Me.Controls.Add(Me.lblStealth)
            Me.Controls.Add(Me.lblSlipping)
            Me.Controls.Add(Me.txtName)
            Me.Controls.Add(Me.lblEndurance)
            Me.Controls.Add(Me.lblHeavyWeapons)
            Me.Controls.Add(Me.lblTwoHandedWeapons)
            Me.Controls.Add(Me.lblBlocking)
            Me.Controls.Add(Me.lblLightWeapons)
            Me.Controls.Add(Me.lblName)
            Me.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Margin = New Padding(4)
            Me.MaximizeBox = False
            Me.MaximumSize = New Size(311, 498)
            Me.MinimumSize = New Size(311, 498)
            Me.Name = "frmNewUser"
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.Text = "New User"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents lblName As Label
        Friend WithEvents lblLightWeapons As Label
        Friend WithEvents lblBlocking As Label
        Friend WithEvents lblTwoHandedWeapons As Label
        Friend WithEvents lblHeavyWeapons As Label
        Friend WithEvents lblEndurance As Label
        Friend WithEvents TxtName As TextBox
        Friend WithEvents lblSlipping As Label
        Friend WithEvents lblStealth As Label
        Friend WithEvents lblEndCurr As Label
        Friend WithEvents lblLightCurr As Label
        Friend WithEvents lblHeavyCurr As Label
        Friend WithEvents lblTwoCurr As Label
        Friend WithEvents lblBlockingCurr As Label
        Friend WithEvents lblSlippingCurr As Label
        Friend WithEvents lblStealthCurr As Label
        Friend WithEvents BtnEndMinus As Button
        Friend WithEvents BtnEndPlus As Button
        Friend WithEvents BtnLightPlus As Button
        Friend WithEvents BtnLightMinus As Button
        Friend WithEvents BtnHeavyPlus As Button
        Friend WithEvents BtnHeavyMinus As Button
        Friend WithEvents BtnTwoPlus As Button
        Friend WithEvents BtnTwoMinus As Button
        Friend WithEvents BtnBlockPlus As Button
        Friend WithEvents BtnBlockMinus As Button
        Friend WithEvents BtnSlippingPlus As Button
        Friend WithEvents BtnSlippingMinus As Button
        Friend WithEvents BtnStealthPlus As Button
        Friend WithEvents BtnStealthMinus As Button
        Friend WithEvents lblSkillPts As Label
        Friend WithEvents lblSkill As Label
        Friend WithEvents BtnCreate As Button
        Friend WithEvents BtnClear As Button
        Friend WithEvents BtnExit As Button
        Friend WithEvents Timer1 As Timer
        Friend WithEvents Timer2 As Timer
        Friend WithEvents TxtPass As TextBox
        Friend WithEvents lblPass As Label
        Friend WithEvents TxtConfirm As TextBox
        Friend WithEvents lblConfirm As Label
    End Class
End NameSpace