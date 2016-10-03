<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrain
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
        Me.lblLightWeapons = New System.Windows.Forms.Label()
        Me.lblBlocking = New System.Windows.Forms.Label()
        Me.lblTwoHandedWeapons = New System.Windows.Forms.Label()
        Me.lblHeavyWeapons = New System.Windows.Forms.Label()
        Me.lblEndurance = New System.Windows.Forms.Label()
        Me.lblSlipping = New System.Windows.Forms.Label()
        Me.lblStealth = New System.Windows.Forms.Label()
        Me.lblEndCurr = New System.Windows.Forms.Label()
        Me.lblLightCurr = New System.Windows.Forms.Label()
        Me.lblHeavyCurr = New System.Windows.Forms.Label()
        Me.lblTwoCurr = New System.Windows.Forms.Label()
        Me.lblBlockingCurr = New System.Windows.Forms.Label()
        Me.lblSlippingCurr = New System.Windows.Forms.Label()
        Me.lblStealthCurr = New System.Windows.Forms.Label()
        Me.btnEndMinus = New System.Windows.Forms.Button()
        Me.btnEndPlus = New System.Windows.Forms.Button()
        Me.btnLightPlus = New System.Windows.Forms.Button()
        Me.btnLightMinus = New System.Windows.Forms.Button()
        Me.btnHeavyPlus = New System.Windows.Forms.Button()
        Me.btnHeavyMinus = New System.Windows.Forms.Button()
        Me.btnTwoPlus = New System.Windows.Forms.Button()
        Me.btnTwoMinus = New System.Windows.Forms.Button()
        Me.btnBlockPlus = New System.Windows.Forms.Button()
        Me.btnBlockMinus = New System.Windows.Forms.Button()
        Me.btnSlippingPlus = New System.Windows.Forms.Button()
        Me.btnSlippingMinus = New System.Windows.Forms.Button()
        Me.btnStealthPlus = New System.Windows.Forms.Button()
        Me.btnStealthMinus = New System.Windows.Forms.Button()
        Me.lblSkillPts = New System.Windows.Forms.Label()
        Me.lblSkill = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblLightWeapons
        '
        Me.lblLightWeapons.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLightWeapons.Location = New System.Drawing.Point(13, 41)
        Me.lblLightWeapons.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLightWeapons.Name = "lblLightWeapons"
        Me.lblLightWeapons.Size = New System.Drawing.Size(135, 25)
        Me.lblLightWeapons.TabIndex = 1
        Me.lblLightWeapons.Text = "Light Weapons:"
        Me.lblLightWeapons.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblBlocking
        '
        Me.lblBlocking.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBlocking.Location = New System.Drawing.Point(13, 137)
        Me.lblBlocking.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBlocking.Name = "lblBlocking"
        Me.lblBlocking.Size = New System.Drawing.Size(135, 25)
        Me.lblBlocking.TabIndex = 2
        Me.lblBlocking.Text = "Blocking:"
        Me.lblBlocking.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTwoHandedWeapons
        '
        Me.lblTwoHandedWeapons.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTwoHandedWeapons.Location = New System.Drawing.Point(13, 105)
        Me.lblTwoHandedWeapons.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTwoHandedWeapons.Name = "lblTwoHandedWeapons"
        Me.lblTwoHandedWeapons.Size = New System.Drawing.Size(135, 25)
        Me.lblTwoHandedWeapons.TabIndex = 3
        Me.lblTwoHandedWeapons.Text = "Two-H Weapons:"
        Me.lblTwoHandedWeapons.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblHeavyWeapons
        '
        Me.lblHeavyWeapons.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeavyWeapons.Location = New System.Drawing.Point(13, 73)
        Me.lblHeavyWeapons.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHeavyWeapons.Name = "lblHeavyWeapons"
        Me.lblHeavyWeapons.Size = New System.Drawing.Size(135, 25)
        Me.lblHeavyWeapons.TabIndex = 4
        Me.lblHeavyWeapons.Text = "Heavy Weapons:"
        Me.lblHeavyWeapons.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEndurance
        '
        Me.lblEndurance.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndurance.Location = New System.Drawing.Point(13, 9)
        Me.lblEndurance.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEndurance.Name = "lblEndurance"
        Me.lblEndurance.Size = New System.Drawing.Size(135, 25)
        Me.lblEndurance.TabIndex = 5
        Me.lblEndurance.Text = "Endurance:"
        Me.lblEndurance.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSlipping
        '
        Me.lblSlipping.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSlipping.Location = New System.Drawing.Point(13, 169)
        Me.lblSlipping.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSlipping.Name = "lblSlipping"
        Me.lblSlipping.Size = New System.Drawing.Size(135, 25)
        Me.lblSlipping.TabIndex = 7
        Me.lblSlipping.Text = "Slipping:"
        Me.lblSlipping.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblStealth
        '
        Me.lblStealth.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStealth.Location = New System.Drawing.Point(13, 200)
        Me.lblStealth.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStealth.Name = "lblStealth"
        Me.lblStealth.Size = New System.Drawing.Size(135, 25)
        Me.lblStealth.TabIndex = 8
        Me.lblStealth.Text = "Stealth:"
        Me.lblStealth.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEndCurr
        '
        Me.lblEndCurr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEndCurr.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndCurr.Location = New System.Drawing.Point(156, 9)
        Me.lblEndCurr.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEndCurr.Name = "lblEndCurr"
        Me.lblEndCurr.Size = New System.Drawing.Size(50, 25)
        Me.lblEndCurr.TabIndex = 9
        Me.lblEndCurr.Text = "100"
        Me.lblEndCurr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLightCurr
        '
        Me.lblLightCurr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLightCurr.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLightCurr.Location = New System.Drawing.Point(156, 41)
        Me.lblLightCurr.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLightCurr.Name = "lblLightCurr"
        Me.lblLightCurr.Size = New System.Drawing.Size(50, 25)
        Me.lblLightCurr.TabIndex = 10
        Me.lblLightCurr.Text = "10%"
        Me.lblLightCurr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHeavyCurr
        '
        Me.lblHeavyCurr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHeavyCurr.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeavyCurr.Location = New System.Drawing.Point(156, 73)
        Me.lblHeavyCurr.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHeavyCurr.Name = "lblHeavyCurr"
        Me.lblHeavyCurr.Size = New System.Drawing.Size(50, 25)
        Me.lblHeavyCurr.TabIndex = 11
        Me.lblHeavyCurr.Text = "10%"
        Me.lblHeavyCurr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTwoCurr
        '
        Me.lblTwoCurr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTwoCurr.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTwoCurr.Location = New System.Drawing.Point(156, 105)
        Me.lblTwoCurr.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTwoCurr.Name = "lblTwoCurr"
        Me.lblTwoCurr.Size = New System.Drawing.Size(50, 25)
        Me.lblTwoCurr.TabIndex = 12
        Me.lblTwoCurr.Text = "10%"
        Me.lblTwoCurr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBlockingCurr
        '
        Me.lblBlockingCurr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBlockingCurr.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBlockingCurr.Location = New System.Drawing.Point(156, 137)
        Me.lblBlockingCurr.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBlockingCurr.Name = "lblBlockingCurr"
        Me.lblBlockingCurr.Size = New System.Drawing.Size(50, 25)
        Me.lblBlockingCurr.TabIndex = 13
        Me.lblBlockingCurr.Text = "10%"
        Me.lblBlockingCurr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSlippingCurr
        '
        Me.lblSlippingCurr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSlippingCurr.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSlippingCurr.Location = New System.Drawing.Point(156, 169)
        Me.lblSlippingCurr.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSlippingCurr.Name = "lblSlippingCurr"
        Me.lblSlippingCurr.Size = New System.Drawing.Size(50, 25)
        Me.lblSlippingCurr.TabIndex = 14
        Me.lblSlippingCurr.Text = "10%"
        Me.lblSlippingCurr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStealthCurr
        '
        Me.lblStealthCurr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStealthCurr.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStealthCurr.Location = New System.Drawing.Point(156, 200)
        Me.lblStealthCurr.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStealthCurr.Name = "lblStealthCurr"
        Me.lblStealthCurr.Size = New System.Drawing.Size(50, 25)
        Me.lblStealthCurr.TabIndex = 15
        Me.lblStealthCurr.Text = "10%"
        Me.lblStealthCurr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnEndMinus
        '
        Me.btnEndMinus.Enabled = False
        Me.btnEndMinus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEndMinus.Location = New System.Drawing.Point(214, 9)
        Me.btnEndMinus.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEndMinus.Name = "btnEndMinus"
        Me.btnEndMinus.Size = New System.Drawing.Size(30, 25)
        Me.btnEndMinus.TabIndex = 3
        Me.btnEndMinus.Text = "-"
        Me.btnEndMinus.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEndMinus.UseVisualStyleBackColor = True
        '
        'btnEndPlus
        '
        Me.btnEndPlus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEndPlus.Location = New System.Drawing.Point(252, 9)
        Me.btnEndPlus.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEndPlus.Name = "btnEndPlus"
        Me.btnEndPlus.Size = New System.Drawing.Size(30, 25)
        Me.btnEndPlus.TabIndex = 4
        Me.btnEndPlus.Text = "+"
        Me.btnEndPlus.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEndPlus.UseVisualStyleBackColor = True
        '
        'btnLightPlus
        '
        Me.btnLightPlus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLightPlus.Location = New System.Drawing.Point(252, 41)
        Me.btnLightPlus.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLightPlus.Name = "btnLightPlus"
        Me.btnLightPlus.Size = New System.Drawing.Size(30, 25)
        Me.btnLightPlus.TabIndex = 6
        Me.btnLightPlus.Text = "+"
        Me.btnLightPlus.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLightPlus.UseVisualStyleBackColor = True
        '
        'btnLightMinus
        '
        Me.btnLightMinus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLightMinus.Location = New System.Drawing.Point(214, 41)
        Me.btnLightMinus.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLightMinus.Name = "btnLightMinus"
        Me.btnLightMinus.Size = New System.Drawing.Size(30, 25)
        Me.btnLightMinus.TabIndex = 5
        Me.btnLightMinus.Text = "-"
        Me.btnLightMinus.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLightMinus.UseVisualStyleBackColor = True
        '
        'btnHeavyPlus
        '
        Me.btnHeavyPlus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHeavyPlus.Location = New System.Drawing.Point(252, 73)
        Me.btnHeavyPlus.Margin = New System.Windows.Forms.Padding(4)
        Me.btnHeavyPlus.Name = "btnHeavyPlus"
        Me.btnHeavyPlus.Size = New System.Drawing.Size(30, 25)
        Me.btnHeavyPlus.TabIndex = 8
        Me.btnHeavyPlus.Text = "+"
        Me.btnHeavyPlus.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnHeavyPlus.UseVisualStyleBackColor = True
        '
        'btnHeavyMinus
        '
        Me.btnHeavyMinus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHeavyMinus.Location = New System.Drawing.Point(214, 73)
        Me.btnHeavyMinus.Margin = New System.Windows.Forms.Padding(4)
        Me.btnHeavyMinus.Name = "btnHeavyMinus"
        Me.btnHeavyMinus.Size = New System.Drawing.Size(30, 25)
        Me.btnHeavyMinus.TabIndex = 7
        Me.btnHeavyMinus.Text = "-"
        Me.btnHeavyMinus.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnHeavyMinus.UseVisualStyleBackColor = True
        '
        'btnTwoPlus
        '
        Me.btnTwoPlus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTwoPlus.Location = New System.Drawing.Point(252, 105)
        Me.btnTwoPlus.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTwoPlus.Name = "btnTwoPlus"
        Me.btnTwoPlus.Size = New System.Drawing.Size(30, 25)
        Me.btnTwoPlus.TabIndex = 10
        Me.btnTwoPlus.Text = "+"
        Me.btnTwoPlus.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnTwoPlus.UseVisualStyleBackColor = True
        '
        'btnTwoMinus
        '
        Me.btnTwoMinus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTwoMinus.Location = New System.Drawing.Point(214, 105)
        Me.btnTwoMinus.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTwoMinus.Name = "btnTwoMinus"
        Me.btnTwoMinus.Size = New System.Drawing.Size(30, 25)
        Me.btnTwoMinus.TabIndex = 9
        Me.btnTwoMinus.Text = "-"
        Me.btnTwoMinus.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnTwoMinus.UseVisualStyleBackColor = True
        '
        'btnBlockPlus
        '
        Me.btnBlockPlus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBlockPlus.Location = New System.Drawing.Point(252, 137)
        Me.btnBlockPlus.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBlockPlus.Name = "btnBlockPlus"
        Me.btnBlockPlus.Size = New System.Drawing.Size(30, 25)
        Me.btnBlockPlus.TabIndex = 12
        Me.btnBlockPlus.Text = "+"
        Me.btnBlockPlus.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBlockPlus.UseVisualStyleBackColor = True
        '
        'btnBlockMinus
        '
        Me.btnBlockMinus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBlockMinus.Location = New System.Drawing.Point(214, 137)
        Me.btnBlockMinus.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBlockMinus.Name = "btnBlockMinus"
        Me.btnBlockMinus.Size = New System.Drawing.Size(30, 25)
        Me.btnBlockMinus.TabIndex = 11
        Me.btnBlockMinus.Text = "-"
        Me.btnBlockMinus.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBlockMinus.UseVisualStyleBackColor = True
        '
        'btnSlippingPlus
        '
        Me.btnSlippingPlus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSlippingPlus.Location = New System.Drawing.Point(252, 169)
        Me.btnSlippingPlus.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSlippingPlus.Name = "btnSlippingPlus"
        Me.btnSlippingPlus.Size = New System.Drawing.Size(30, 25)
        Me.btnSlippingPlus.TabIndex = 14
        Me.btnSlippingPlus.Text = "+"
        Me.btnSlippingPlus.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSlippingPlus.UseVisualStyleBackColor = True
        '
        'btnSlippingMinus
        '
        Me.btnSlippingMinus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSlippingMinus.Location = New System.Drawing.Point(214, 169)
        Me.btnSlippingMinus.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSlippingMinus.Name = "btnSlippingMinus"
        Me.btnSlippingMinus.Size = New System.Drawing.Size(30, 25)
        Me.btnSlippingMinus.TabIndex = 13
        Me.btnSlippingMinus.Text = "-"
        Me.btnSlippingMinus.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSlippingMinus.UseVisualStyleBackColor = True
        '
        'btnStealthPlus
        '
        Me.btnStealthPlus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStealthPlus.Location = New System.Drawing.Point(252, 200)
        Me.btnStealthPlus.Margin = New System.Windows.Forms.Padding(4)
        Me.btnStealthPlus.Name = "btnStealthPlus"
        Me.btnStealthPlus.Size = New System.Drawing.Size(30, 25)
        Me.btnStealthPlus.TabIndex = 16
        Me.btnStealthPlus.Text = "+"
        Me.btnStealthPlus.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnStealthPlus.UseVisualStyleBackColor = True
        '
        'btnStealthMinus
        '
        Me.btnStealthMinus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStealthMinus.Location = New System.Drawing.Point(214, 200)
        Me.btnStealthMinus.Margin = New System.Windows.Forms.Padding(4)
        Me.btnStealthMinus.Name = "btnStealthMinus"
        Me.btnStealthMinus.Size = New System.Drawing.Size(30, 25)
        Me.btnStealthMinus.TabIndex = 15
        Me.btnStealthMinus.Text = "-"
        Me.btnStealthMinus.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnStealthMinus.UseVisualStyleBackColor = True
        '
        'lblSkillPts
        '
        Me.lblSkillPts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSkillPts.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSkillPts.Location = New System.Drawing.Point(214, 249)
        Me.lblSkillPts.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSkillPts.Name = "lblSkillPts"
        Me.lblSkillPts.Size = New System.Drawing.Size(68, 25)
        Me.lblSkillPts.TabIndex = 31
        Me.lblSkillPts.Text = "0"
        Me.lblSkillPts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSkill
        '
        Me.lblSkill.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSkill.Location = New System.Drawing.Point(13, 249)
        Me.lblSkill.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSkill.Name = "lblSkill"
        Me.lblSkill.Size = New System.Drawing.Size(193, 25)
        Me.lblSkill.TabIndex = 30
        Me.lblSkill.Text = "Skill Points:"
        Me.lblSkill.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(13, 299)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 30)
        Me.btnSave.TabIndex = 17
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Enabled = False
        Me.btnClear.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(107, 299)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(80, 30)
        Me.btnClear.TabIndex = 18
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(202, 299)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(80, 30)
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
        'frmTrain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(295, 341)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSave)
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
        Me.Controls.Add(Me.lblEndurance)
        Me.Controls.Add(Me.lblHeavyWeapons)
        Me.Controls.Add(Me.lblTwoHandedWeapons)
        Me.Controls.Add(Me.lblBlocking)
        Me.Controls.Add(Me.lblLightWeapons)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(311, 380)
        Me.MinimumSize = New System.Drawing.Size(311, 380)
        Me.Name = "frmTrain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Training Grounds"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblLightWeapons As System.Windows.Forms.Label
    Friend WithEvents lblBlocking As System.Windows.Forms.Label
    Friend WithEvents lblTwoHandedWeapons As System.Windows.Forms.Label
    Friend WithEvents lblHeavyWeapons As System.Windows.Forms.Label
    Friend WithEvents lblEndurance As System.Windows.Forms.Label
    Friend WithEvents lblSlipping As System.Windows.Forms.Label
    Friend WithEvents lblStealth As System.Windows.Forms.Label
    Friend WithEvents lblEndCurr As System.Windows.Forms.Label
    Friend WithEvents lblLightCurr As System.Windows.Forms.Label
    Friend WithEvents lblHeavyCurr As System.Windows.Forms.Label
    Friend WithEvents lblTwoCurr As System.Windows.Forms.Label
    Friend WithEvents lblBlockingCurr As System.Windows.Forms.Label
    Friend WithEvents lblSlippingCurr As System.Windows.Forms.Label
    Friend WithEvents lblStealthCurr As System.Windows.Forms.Label
    Friend WithEvents btnEndMinus As System.Windows.Forms.Button
    Friend WithEvents btnEndPlus As System.Windows.Forms.Button
    Friend WithEvents btnLightPlus As System.Windows.Forms.Button
    Friend WithEvents btnLightMinus As System.Windows.Forms.Button
    Friend WithEvents btnHeavyPlus As System.Windows.Forms.Button
    Friend WithEvents btnHeavyMinus As System.Windows.Forms.Button
    Friend WithEvents btnTwoPlus As System.Windows.Forms.Button
    Friend WithEvents btnTwoMinus As System.Windows.Forms.Button
    Friend WithEvents btnBlockPlus As System.Windows.Forms.Button
    Friend WithEvents btnBlockMinus As System.Windows.Forms.Button
    Friend WithEvents btnSlippingPlus As System.Windows.Forms.Button
    Friend WithEvents btnSlippingMinus As System.Windows.Forms.Button
    Friend WithEvents btnStealthPlus As System.Windows.Forms.Button
    Friend WithEvents btnStealthMinus As System.Windows.Forms.Button
    Friend WithEvents lblSkillPts As System.Windows.Forms.Label
    Friend WithEvents lblSkill As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
End Class
