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
            Me.LblName = New Label()
            Me.LblLightWeapons = New Label()
            Me.LblBlocking = New Label()
            Me.LblTwoHandedWeapons = New Label()
            Me.LblHeavyWeapons = New Label()
            Me.LblEndurance = New Label()
            Me.txtName = New TextBox()
            Me.LblSlipping = New Label()
            Me.LblStealth = New Label()
            Me.LblEndCurr = New Label()
            Me.LblLightCurr = New Label()
            Me.LblHeavyCurr = New Label()
            Me.LblTwoCurr = New Label()
            Me.LblBlockingCurr = New Label()
            Me.LblSlippingCurr = New Label()
            Me.LblStealthCurr = New Label()
            Me.BtnEndMinus = New Button()
            Me.BtnEndPlus = New Button()
            Me.BtnLightPlus = New Button()
            Me.BtnLightMinus = New Button()
            Me.BtnHeavyPlus = New Button()
            Me.BtnHeavyMinus = New Button()
            Me.BtnTwoPlus = New Button()
            Me.BtnTwoMinus = New Button()
            Me.BtnBlockPlus = New Button()
            Me.BtnBlockMinus = New Button()
            Me.BtnSlippingPlus = New Button()
            Me.BtnSlippingMinus = New Button()
            Me.BtnStealthPlus = New Button()
            Me.BtnStealthMinus = New Button()
            Me.LblSkillPts = New Label()
            Me.LblSkill = New Label()
            Me.BtnCreate = New Button()
            Me.BtnClear = New Button()
            Me.BtnExit = New Button()
            Me.Timer1 = New Timer(Me.components)
            Me.Timer2 = New Timer(Me.components)
            Me.txtPass = New TextBox()
            Me.LblPass = New Label()
            Me.txtConfirm = New TextBox()
            Me.LblConfirm = New Label()
            Me.SuspendLayout()
            '
            'LblName
            '
            Me.LblName.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.LblName.Location = New Point(48, 9)
            Me.LblName.Margin = New Padding(4, 0, 4, 0)
            Me.LblName.Name = "LblName"
            Me.LblName.Size = New Size(100, 25)
            Me.LblName.TabIndex = 0
            Me.LblName.Text = "Name:"
            Me.LblName.TextAlign = ContentAlignment.MiddleRight
            '
            'LblLightWeapons
            '
            Me.LblLightWeapons.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.LblLightWeapons.Location = New Point(13, 159)
            Me.LblLightWeapons.Margin = New Padding(4, 0, 4, 0)
            Me.LblLightWeapons.Name = "LblLightWeapons"
            Me.LblLightWeapons.Size = New Size(135, 25)
            Me.LblLightWeapons.TabIndex = 1
            Me.LblLightWeapons.Text = "Light Weapons:"
            Me.LblLightWeapons.TextAlign = ContentAlignment.MiddleRight
            '
            'LblBlocking
            '
            Me.LblBlocking.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.LblBlocking.Location = New Point(13, 255)
            Me.LblBlocking.Margin = New Padding(4, 0, 4, 0)
            Me.LblBlocking.Name = "LblBlocking"
            Me.LblBlocking.Size = New Size(135, 25)
            Me.LblBlocking.TabIndex = 2
            Me.LblBlocking.Text = "Blocking:"
            Me.LblBlocking.TextAlign = ContentAlignment.MiddleRight
            '
            'LblTwoHandedWeapons
            '
            Me.LblTwoHandedWeapons.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.LblTwoHandedWeapons.Location = New Point(13, 223)
            Me.LblTwoHandedWeapons.Margin = New Padding(4, 0, 4, 0)
            Me.LblTwoHandedWeapons.Name = "LblTwoHandedWeapons"
            Me.LblTwoHandedWeapons.Size = New Size(135, 25)
            Me.LblTwoHandedWeapons.TabIndex = 3
            Me.LblTwoHandedWeapons.Text = "Two-H Weapons:"
            Me.LblTwoHandedWeapons.TextAlign = ContentAlignment.MiddleRight
            '
            'LblHeavyWeapons
            '
            Me.LblHeavyWeapons.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.LblHeavyWeapons.Location = New Point(13, 191)
            Me.LblHeavyWeapons.Margin = New Padding(4, 0, 4, 0)
            Me.LblHeavyWeapons.Name = "LblHeavyWeapons"
            Me.LblHeavyWeapons.Size = New Size(135, 25)
            Me.LblHeavyWeapons.TabIndex = 4
            Me.LblHeavyWeapons.Text = "Heavy Weapons:"
            Me.LblHeavyWeapons.TextAlign = ContentAlignment.MiddleRight
            '
            'LblEndurance
            '
            Me.LblEndurance.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.LblEndurance.Location = New Point(13, 127)
            Me.LblEndurance.Margin = New Padding(4, 0, 4, 0)
            Me.LblEndurance.Name = "LblEndurance"
            Me.LblEndurance.Size = New Size(135, 25)
            Me.LblEndurance.TabIndex = 5
            Me.LblEndurance.Text = "Endurance:"
            Me.LblEndurance.TextAlign = ContentAlignment.MiddleRight
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
            'LblSlipping
            '
            Me.LblSlipping.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.LblSlipping.Location = New Point(13, 287)
            Me.LblSlipping.Margin = New Padding(4, 0, 4, 0)
            Me.LblSlipping.Name = "LblSlipping"
            Me.LblSlipping.Size = New Size(135, 25)
            Me.LblSlipping.TabIndex = 7
            Me.LblSlipping.Text = "Slipping:"
            Me.LblSlipping.TextAlign = ContentAlignment.MiddleRight
            '
            'LblStealth
            '
            Me.LblStealth.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.LblStealth.Location = New Point(13, 318)
            Me.LblStealth.Margin = New Padding(4, 0, 4, 0)
            Me.LblStealth.Name = "LblStealth"
            Me.LblStealth.Size = New Size(135, 25)
            Me.LblStealth.TabIndex = 8
            Me.LblStealth.Text = "Stealth:"
            Me.LblStealth.TextAlign = ContentAlignment.MiddleRight
            '
            'LblEndCurr
            '
            Me.LblEndCurr.BorderStyle = BorderStyle.FixedSingle
            Me.LblEndCurr.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.LblEndCurr.Location = New Point(156, 127)
            Me.LblEndCurr.Margin = New Padding(4, 0, 4, 0)
            Me.LblEndCurr.Name = "LblEndCurr"
            Me.LblEndCurr.Size = New Size(50, 25)
            Me.LblEndCurr.TabIndex = 9
            Me.LblEndCurr.Text = "100"
            Me.LblEndCurr.TextAlign = ContentAlignment.MiddleCenter
            '
            'LblLightCurr
            '
            Me.LblLightCurr.BorderStyle = BorderStyle.FixedSingle
            Me.LblLightCurr.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.LblLightCurr.Location = New Point(156, 159)
            Me.LblLightCurr.Margin = New Padding(4, 0, 4, 0)
            Me.LblLightCurr.Name = "LblLightCurr"
            Me.LblLightCurr.Size = New Size(50, 25)
            Me.LblLightCurr.TabIndex = 10
            Me.LblLightCurr.Text = "10%"
            Me.LblLightCurr.TextAlign = ContentAlignment.MiddleCenter
            '
            'LblHeavyCurr
            '
            Me.LblHeavyCurr.BorderStyle = BorderStyle.FixedSingle
            Me.LblHeavyCurr.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.LblHeavyCurr.Location = New Point(156, 191)
            Me.LblHeavyCurr.Margin = New Padding(4, 0, 4, 0)
            Me.LblHeavyCurr.Name = "LblHeavyCurr"
            Me.LblHeavyCurr.Size = New Size(50, 25)
            Me.LblHeavyCurr.TabIndex = 11
            Me.LblHeavyCurr.Text = "10%"
            Me.LblHeavyCurr.TextAlign = ContentAlignment.MiddleCenter
            '
            'LblTwoCurr
            '
            Me.LblTwoCurr.BorderStyle = BorderStyle.FixedSingle
            Me.LblTwoCurr.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.LblTwoCurr.Location = New Point(156, 223)
            Me.LblTwoCurr.Margin = New Padding(4, 0, 4, 0)
            Me.LblTwoCurr.Name = "LblTwoCurr"
            Me.LblTwoCurr.Size = New Size(50, 25)
            Me.LblTwoCurr.TabIndex = 12
            Me.LblTwoCurr.Text = "10%"
            Me.LblTwoCurr.TextAlign = ContentAlignment.MiddleCenter
            '
            'LblBlockingCurr
            '
            Me.LblBlockingCurr.BorderStyle = BorderStyle.FixedSingle
            Me.LblBlockingCurr.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.LblBlockingCurr.Location = New Point(156, 255)
            Me.LblBlockingCurr.Margin = New Padding(4, 0, 4, 0)
            Me.LblBlockingCurr.Name = "LblBlockingCurr"
            Me.LblBlockingCurr.Size = New Size(50, 25)
            Me.LblBlockingCurr.TabIndex = 13
            Me.LblBlockingCurr.Text = "10%"
            Me.LblBlockingCurr.TextAlign = ContentAlignment.MiddleCenter
            '
            'LblSlippingCurr
            '
            Me.LblSlippingCurr.BorderStyle = BorderStyle.FixedSingle
            Me.LblSlippingCurr.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.LblSlippingCurr.Location = New Point(156, 287)
            Me.LblSlippingCurr.Margin = New Padding(4, 0, 4, 0)
            Me.LblSlippingCurr.Name = "LblSlippingCurr"
            Me.LblSlippingCurr.Size = New Size(50, 25)
            Me.LblSlippingCurr.TabIndex = 14
            Me.LblSlippingCurr.Text = "10%"
            Me.LblSlippingCurr.TextAlign = ContentAlignment.MiddleCenter
            '
            'LblStealthCurr
            '
            Me.LblStealthCurr.BorderStyle = BorderStyle.FixedSingle
            Me.LblStealthCurr.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.LblStealthCurr.Location = New Point(156, 318)
            Me.LblStealthCurr.Margin = New Padding(4, 0, 4, 0)
            Me.LblStealthCurr.Name = "LblStealthCurr"
            Me.LblStealthCurr.Size = New Size(50, 25)
            Me.LblStealthCurr.TabIndex = 15
            Me.LblStealthCurr.Text = "10%"
            Me.LblStealthCurr.TextAlign = ContentAlignment.MiddleCenter
            '
            'BtnEndMinus
            '
            Me.BtnEndMinus.Enabled = False
            Me.BtnEndMinus.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnEndMinus.Location = New Point(214, 127)
            Me.BtnEndMinus.Margin = New Padding(4)
            Me.BtnEndMinus.Name = "BtnEndMinus"
            Me.BtnEndMinus.Size = New Size(30, 25)
            Me.BtnEndMinus.TabIndex = 3
            Me.BtnEndMinus.Text = "-"
            Me.BtnEndMinus.TextAlign = ContentAlignment.BottomCenter
            Me.BtnEndMinus.UseVisualStyleBackColor = True
            '
            'BtnEndPlus
            '
            Me.BtnEndPlus.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnEndPlus.Location = New Point(252, 127)
            Me.BtnEndPlus.Margin = New Padding(4)
            Me.BtnEndPlus.Name = "BtnEndPlus"
            Me.BtnEndPlus.Size = New Size(30, 25)
            Me.BtnEndPlus.TabIndex = 4
            Me.BtnEndPlus.Text = "+"
            Me.BtnEndPlus.TextAlign = ContentAlignment.BottomCenter
            Me.BtnEndPlus.UseVisualStyleBackColor = True
            '
            'BtnLightPlus
            '
            Me.BtnLightPlus.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnLightPlus.Location = New Point(252, 159)
            Me.BtnLightPlus.Margin = New Padding(4)
            Me.BtnLightPlus.Name = "BtnLightPlus"
            Me.BtnLightPlus.Size = New Size(30, 25)
            Me.BtnLightPlus.TabIndex = 6
            Me.BtnLightPlus.Text = "+"
            Me.BtnLightPlus.TextAlign = ContentAlignment.BottomCenter
            Me.BtnLightPlus.UseVisualStyleBackColor = True
            '
            'BtnLightMinus
            '
            Me.BtnLightMinus.Enabled = False
            Me.BtnLightMinus.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnLightMinus.Location = New Point(214, 159)
            Me.BtnLightMinus.Margin = New Padding(4)
            Me.BtnLightMinus.Name = "BtnLightMinus"
            Me.BtnLightMinus.Size = New Size(30, 25)
            Me.BtnLightMinus.TabIndex = 5
            Me.BtnLightMinus.Text = "-"
            Me.BtnLightMinus.TextAlign = ContentAlignment.BottomCenter
            Me.BtnLightMinus.UseVisualStyleBackColor = True
            '
            'BtnHeavyPlus
            '
            Me.BtnHeavyPlus.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnHeavyPlus.Location = New Point(252, 191)
            Me.BtnHeavyPlus.Margin = New Padding(4)
            Me.BtnHeavyPlus.Name = "BtnHeavyPlus"
            Me.BtnHeavyPlus.Size = New Size(30, 25)
            Me.BtnHeavyPlus.TabIndex = 8
            Me.BtnHeavyPlus.Text = "+"
            Me.BtnHeavyPlus.TextAlign = ContentAlignment.BottomCenter
            Me.BtnHeavyPlus.UseVisualStyleBackColor = True
            '
            'BtnHeavyMinus
            '
            Me.BtnHeavyMinus.Enabled = False
            Me.BtnHeavyMinus.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnHeavyMinus.Location = New Point(214, 191)
            Me.BtnHeavyMinus.Margin = New Padding(4)
            Me.BtnHeavyMinus.Name = "BtnHeavyMinus"
            Me.BtnHeavyMinus.Size = New Size(30, 25)
            Me.BtnHeavyMinus.TabIndex = 7
            Me.BtnHeavyMinus.Text = "-"
            Me.BtnHeavyMinus.TextAlign = ContentAlignment.BottomCenter
            Me.BtnHeavyMinus.UseVisualStyleBackColor = True
            '
            'BtnTwoPlus
            '
            Me.BtnTwoPlus.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnTwoPlus.Location = New Point(252, 223)
            Me.BtnTwoPlus.Margin = New Padding(4)
            Me.BtnTwoPlus.Name = "BtnTwoPlus"
            Me.BtnTwoPlus.Size = New Size(30, 25)
            Me.BtnTwoPlus.TabIndex = 10
            Me.BtnTwoPlus.Text = "+"
            Me.BtnTwoPlus.TextAlign = ContentAlignment.BottomCenter
            Me.BtnTwoPlus.UseVisualStyleBackColor = True
            '
            'BtnTwoMinus
            '
            Me.BtnTwoMinus.Enabled = False
            Me.BtnTwoMinus.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnTwoMinus.Location = New Point(214, 223)
            Me.BtnTwoMinus.Margin = New Padding(4)
            Me.BtnTwoMinus.Name = "BtnTwoMinus"
            Me.BtnTwoMinus.Size = New Size(30, 25)
            Me.BtnTwoMinus.TabIndex = 9
            Me.BtnTwoMinus.Text = "-"
            Me.BtnTwoMinus.TextAlign = ContentAlignment.BottomCenter
            Me.BtnTwoMinus.UseVisualStyleBackColor = True
            '
            'BtnBlockPlus
            '
            Me.BtnBlockPlus.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnBlockPlus.Location = New Point(252, 255)
            Me.BtnBlockPlus.Margin = New Padding(4)
            Me.BtnBlockPlus.Name = "BtnBlockPlus"
            Me.BtnBlockPlus.Size = New Size(30, 25)
            Me.BtnBlockPlus.TabIndex = 12
            Me.BtnBlockPlus.Text = "+"
            Me.BtnBlockPlus.TextAlign = ContentAlignment.BottomCenter
            Me.BtnBlockPlus.UseVisualStyleBackColor = True
            '
            'BtnBlockMinus
            '
            Me.BtnBlockMinus.Enabled = False
            Me.BtnBlockMinus.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnBlockMinus.Location = New Point(214, 255)
            Me.BtnBlockMinus.Margin = New Padding(4)
            Me.BtnBlockMinus.Name = "BtnBlockMinus"
            Me.BtnBlockMinus.Size = New Size(30, 25)
            Me.BtnBlockMinus.TabIndex = 11
            Me.BtnBlockMinus.Text = "-"
            Me.BtnBlockMinus.TextAlign = ContentAlignment.BottomCenter
            Me.BtnBlockMinus.UseVisualStyleBackColor = True
            '
            'BtnSlippingPlus
            '
            Me.BtnSlippingPlus.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnSlippingPlus.Location = New Point(252, 287)
            Me.BtnSlippingPlus.Margin = New Padding(4)
            Me.BtnSlippingPlus.Name = "BtnSlippingPlus"
            Me.BtnSlippingPlus.Size = New Size(30, 25)
            Me.BtnSlippingPlus.TabIndex = 14
            Me.BtnSlippingPlus.Text = "+"
            Me.BtnSlippingPlus.TextAlign = ContentAlignment.BottomCenter
            Me.BtnSlippingPlus.UseVisualStyleBackColor = True
            '
            'BtnSlippingMinus
            '
            Me.BtnSlippingMinus.Enabled = False
            Me.BtnSlippingMinus.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnSlippingMinus.Location = New Point(214, 287)
            Me.BtnSlippingMinus.Margin = New Padding(4)
            Me.BtnSlippingMinus.Name = "BtnSlippingMinus"
            Me.BtnSlippingMinus.Size = New Size(30, 25)
            Me.BtnSlippingMinus.TabIndex = 13
            Me.BtnSlippingMinus.Text = "-"
            Me.BtnSlippingMinus.TextAlign = ContentAlignment.BottomCenter
            Me.BtnSlippingMinus.UseVisualStyleBackColor = True
            '
            'BtnStealthPlus
            '
            Me.BtnStealthPlus.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnStealthPlus.Location = New Point(252, 318)
            Me.BtnStealthPlus.Margin = New Padding(4)
            Me.BtnStealthPlus.Name = "BtnStealthPlus"
            Me.BtnStealthPlus.Size = New Size(30, 25)
            Me.BtnStealthPlus.TabIndex = 16
            Me.BtnStealthPlus.Text = "+"
            Me.BtnStealthPlus.TextAlign = ContentAlignment.BottomCenter
            Me.BtnStealthPlus.UseVisualStyleBackColor = True
            '
            'BtnStealthMinus
            '
            Me.BtnStealthMinus.Enabled = False
            Me.BtnStealthMinus.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnStealthMinus.Location = New Point(214, 318)
            Me.BtnStealthMinus.Margin = New Padding(4)
            Me.BtnStealthMinus.Name = "BtnStealthMinus"
            Me.BtnStealthMinus.Size = New Size(30, 25)
            Me.BtnStealthMinus.TabIndex = 15
            Me.BtnStealthMinus.Text = "-"
            Me.BtnStealthMinus.TextAlign = ContentAlignment.BottomCenter
            Me.BtnStealthMinus.UseVisualStyleBackColor = True
            '
            'LblSkillPts
            '
            Me.LblSkillPts.BorderStyle = BorderStyle.FixedSingle
            Me.LblSkillPts.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.LblSkillPts.Location = New Point(214, 367)
            Me.LblSkillPts.Margin = New Padding(4, 0, 4, 0)
            Me.LblSkillPts.Name = "LblSkillPts"
            Me.LblSkillPts.Size = New Size(68, 25)
            Me.LblSkillPts.TabIndex = 31
            Me.LblSkillPts.Text = "5"
            Me.LblSkillPts.TextAlign = ContentAlignment.MiddleCenter
            '
            'LblSkill
            '
            Me.LblSkill.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.LblSkill.Location = New Point(13, 367)
            Me.LblSkill.Margin = New Padding(4, 0, 4, 0)
            Me.LblSkill.Name = "LblSkill"
            Me.LblSkill.Size = New Size(193, 25)
            Me.LblSkill.TabIndex = 30
            Me.LblSkill.Text = "Skill Points:"
            Me.LblSkill.TextAlign = ContentAlignment.MiddleRight
            '
            'BtnCreate
            '
            Me.BtnCreate.Enabled = False
            Me.BtnCreate.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnCreate.Location = New Point(13, 417)
            Me.BtnCreate.Margin = New Padding(4)
            Me.BtnCreate.Name = "BtnCreate"
            Me.BtnCreate.Size = New Size(80, 30)
            Me.BtnCreate.TabIndex = 17
            Me.BtnCreate.Text = "&Create"
            Me.BtnCreate.UseVisualStyleBackColor = True
            '
            'BtnClear
            '
            Me.BtnClear.Enabled = False
            Me.BtnClear.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnClear.Location = New Point(107, 417)
            Me.BtnClear.Margin = New Padding(4)
            Me.BtnClear.Name = "BtnClear"
            Me.BtnClear.Size = New Size(80, 30)
            Me.BtnClear.TabIndex = 18
            Me.BtnClear.Text = "C&lear"
            Me.BtnClear.UseVisualStyleBackColor = True
            '
            'BtnExit
            '
            Me.BtnExit.DialogResult = DialogResult.Cancel
            Me.BtnExit.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnExit.Location = New Point(202, 417)
            Me.BtnExit.Margin = New Padding(4)
            Me.BtnExit.Name = "BtnExit"
            Me.BtnExit.Size = New Size(80, 30)
            Me.BtnExit.TabIndex = 19
            Me.BtnExit.Text = "E&xit"
            Me.BtnExit.UseVisualStyleBackColor = True
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
            'LblPass
            '
            Me.LblPass.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.LblPass.Location = New Point(48, 43)
            Me.LblPass.Margin = New Padding(4, 0, 4, 0)
            Me.LblPass.Name = "LblPass"
            Me.LblPass.Size = New Size(100, 25)
            Me.LblPass.TabIndex = 35
            Me.LblPass.Text = "Password:"
            Me.LblPass.TextAlign = ContentAlignment.MiddleRight
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
            'LblConfirm
            '
            Me.LblConfirm.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.LblConfirm.Location = New Point(48, 78)
            Me.LblConfirm.Margin = New Padding(4, 0, 4, 0)
            Me.LblConfirm.Name = "LblConfirm"
            Me.LblConfirm.Size = New Size(100, 25)
            Me.LblConfirm.TabIndex = 37
            Me.LblConfirm.Text = "Confirm:"
            Me.LblConfirm.TextAlign = ContentAlignment.MiddleRight
            '
            'frmNewUser
            '
            Me.AutoScaleDimensions = New SizeF(9.0!, 18.0!)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.CancelButton = Me.BtnExit
            Me.ClientSize = New Size(295, 459)
            Me.Controls.Add(Me.txtConfirm)
            Me.Controls.Add(Me.LblConfirm)
            Me.Controls.Add(Me.txtPass)
            Me.Controls.Add(Me.LblPass)
            Me.Controls.Add(Me.BtnExit)
            Me.Controls.Add(Me.BtnClear)
            Me.Controls.Add(Me.BtnCreate)
            Me.Controls.Add(Me.LblSkillPts)
            Me.Controls.Add(Me.LblSkill)
            Me.Controls.Add(Me.BtnStealthPlus)
            Me.Controls.Add(Me.BtnStealthMinus)
            Me.Controls.Add(Me.BtnSlippingPlus)
            Me.Controls.Add(Me.BtnSlippingMinus)
            Me.Controls.Add(Me.BtnBlockPlus)
            Me.Controls.Add(Me.BtnBlockMinus)
            Me.Controls.Add(Me.BtnTwoPlus)
            Me.Controls.Add(Me.BtnTwoMinus)
            Me.Controls.Add(Me.BtnHeavyPlus)
            Me.Controls.Add(Me.BtnHeavyMinus)
            Me.Controls.Add(Me.BtnLightPlus)
            Me.Controls.Add(Me.BtnLightMinus)
            Me.Controls.Add(Me.BtnEndPlus)
            Me.Controls.Add(Me.BtnEndMinus)
            Me.Controls.Add(Me.LblStealthCurr)
            Me.Controls.Add(Me.LblSlippingCurr)
            Me.Controls.Add(Me.LblBlockingCurr)
            Me.Controls.Add(Me.LblTwoCurr)
            Me.Controls.Add(Me.LblHeavyCurr)
            Me.Controls.Add(Me.LblLightCurr)
            Me.Controls.Add(Me.LblEndCurr)
            Me.Controls.Add(Me.LblStealth)
            Me.Controls.Add(Me.LblSlipping)
            Me.Controls.Add(Me.txtName)
            Me.Controls.Add(Me.LblEndurance)
            Me.Controls.Add(Me.LblHeavyWeapons)
            Me.Controls.Add(Me.LblTwoHandedWeapons)
            Me.Controls.Add(Me.LblBlocking)
            Me.Controls.Add(Me.LblLightWeapons)
            Me.Controls.Add(Me.LblName)
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
        Friend WithEvents LblName As Label
        Friend WithEvents LblLightWeapons As Label
        Friend WithEvents LblBlocking As Label
        Friend WithEvents LblTwoHandedWeapons As Label
        Friend WithEvents LblHeavyWeapons As Label
        Friend WithEvents LblEndurance As Label
        Friend WithEvents TxtName As TextBox
        Friend WithEvents LblSlipping As Label
        Friend WithEvents LblStealth As Label
        Friend WithEvents LblEndCurr As Label
        Friend WithEvents LblLightCurr As Label
        Friend WithEvents LblHeavyCurr As Label
        Friend WithEvents LblTwoCurr As Label
        Friend WithEvents LblBlockingCurr As Label
        Friend WithEvents LblSlippingCurr As Label
        Friend WithEvents LblStealthCurr As Label
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
        Friend WithEvents LblSkillPts As Label
        Friend WithEvents LblSkill As Label
        Friend WithEvents BtnCreate As Button
        Friend WithEvents BtnClear As Button
        Friend WithEvents BtnExit As Button
        Friend WithEvents Timer1 As Timer
        Friend WithEvents Timer2 As Timer
        Friend WithEvents TxtPass As TextBox
        Friend WithEvents LblPass As Label
        Friend WithEvents TxtConfirm As TextBox
        Friend WithEvents LblConfirm As Label
    End Class
End NameSpace