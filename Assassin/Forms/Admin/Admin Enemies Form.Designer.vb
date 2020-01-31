Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

Namespace Forms.Admin
    <DesignerGenerated()> _
    Partial Class FrmAdminEnemies
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
            Me.lstEnemies = New ListBox()
            Me.btnClear = New Button()
            Me.btnExit = New Button()
            Me.btnSave = New Button()
            Me.txtName = New TextBox()
            Me.lblName = New Label()
            Me.txtEndurance = New TextBox()
            Me.lblEnd = New Label()
            Me.cmbWeaponType = New ComboBox()
            Me.lblWeaponType = New Label()
            Me.lblWeapon = New Label()
            Me.cmbWeapon = New ComboBox()
            Me.cmbArmor = New ComboBox()
            Me.Label12 = New Label()
            Me.txtWeaponSkill = New TextBox()
            Me.Label5 = New Label()
            Me.txtSlipping = New TextBox()
            Me.txtBlocking = New TextBox()
            Me.Label8 = New Label()
            Me.Label1 = New Label()
            Me.SuspendLayout()
            '
            'lstEnemies
            '
            Me.lstEnemies.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lstEnemies.FormattingEnabled = True
            Me.lstEnemies.ItemHeight = 18
            Me.lstEnemies.Location = New Point(13, 13)
            Me.lstEnemies.Margin = New Padding(4)
            Me.lstEnemies.Name = "lstEnemies"
            Me.lstEnemies.ScrollAlwaysVisible = True
            Me.lstEnemies.Size = New Size(225, 184)
            Me.lstEnemies.TabIndex = 0
            '
            'btnClear
            '
            Me.btnClear.Enabled = False
            Me.btnClear.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnClear.Location = New Point(63, 205)
            Me.btnClear.Margin = New Padding(4)
            Me.btnClear.Name = "btnClear"
            Me.btnClear.Size = New Size(125, 30)
            Me.btnClear.TabIndex = 40
            Me.btnClear.Text = "&Clear"
            Me.btnClear.UseVisualStyleBackColor = True
            '
            'btnExit
            '
            Me.btnExit.DialogResult = DialogResult.Cancel
            Me.btnExit.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnExit.Location = New Point(63, 281)
            Me.btnExit.Margin = New Padding(4)
            Me.btnExit.Name = "btnExit"
            Me.btnExit.Size = New Size(125, 30)
            Me.btnExit.TabIndex = 42
            Me.btnExit.Text = "E&xit"
            Me.btnExit.UseVisualStyleBackColor = True
            '
            'btnSave
            '
            Me.btnSave.Enabled = False
            Me.btnSave.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnSave.Location = New Point(63, 243)
            Me.btnSave.Margin = New Padding(4)
            Me.btnSave.Name = "btnSave"
            Me.btnSave.Size = New Size(125, 30)
            Me.btnSave.TabIndex = 41
            Me.btnSave.Text = "&Save"
            Me.btnSave.UseVisualStyleBackColor = True
            '
            'txtName
            '
            Me.txtName.Enabled = False
            Me.txtName.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.txtName.Location = New Point(379, 14)
            Me.txtName.Margin = New Padding(4)
            Me.txtName.MaxLength = 20
            Me.txtName.Name = "txtName"
            Me.txtName.Size = New Size(175, 22)
            Me.txtName.TabIndex = 1
            Me.txtName.TextAlign = HorizontalAlignment.Center
            '
            'lblName
            '
            Me.lblName.BorderStyle = BorderStyle.FixedSingle
            Me.lblName.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblName.Location = New Point(246, 13)
            Me.lblName.Margin = New Padding(4, 0, 4, 0)
            Me.lblName.Name = "lblName"
            Me.lblName.Size = New Size(125, 24)
            Me.lblName.TabIndex = 44
            Me.lblName.Text = "Name:"
            Me.lblName.TextAlign = ContentAlignment.MiddleRight
            '
            'txtEndurance
            '
            Me.txtEndurance.Enabled = False
            Me.txtEndurance.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.txtEndurance.Location = New Point(379, 52)
            Me.txtEndurance.Margin = New Padding(4)
            Me.txtEndurance.MaxLength = 4
            Me.txtEndurance.Name = "txtEndurance"
            Me.txtEndurance.Size = New Size(50, 22)
            Me.txtEndurance.TabIndex = 2
            Me.txtEndurance.TextAlign = HorizontalAlignment.Center
            '
            'lblEnd
            '
            Me.lblEnd.BorderStyle = BorderStyle.FixedSingle
            Me.lblEnd.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblEnd.Location = New Point(246, 51)
            Me.lblEnd.Margin = New Padding(4, 0, 4, 0)
            Me.lblEnd.Name = "lblEnd"
            Me.lblEnd.Size = New Size(125, 24)
            Me.lblEnd.TabIndex = 45
            Me.lblEnd.Text = "Endurance:"
            Me.lblEnd.TextAlign = ContentAlignment.MiddleRight
            '
            'cmbWeaponType
            '
            Me.cmbWeaponType.DropDownStyle = ComboBoxStyle.DropDownList
            Me.cmbWeaponType.Enabled = False
            Me.cmbWeaponType.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.cmbWeaponType.FormattingEnabled = True
            Me.cmbWeaponType.Items.AddRange(New Object() {"Light", "Heavy", "Two-H"})
            Me.cmbWeaponType.Location = New Point(379, 89)
            Me.cmbWeaponType.Name = "cmbWeaponType"
            Me.cmbWeaponType.Size = New Size(101, 24)
            Me.cmbWeaponType.TabIndex = 3
            '
            'lblWeaponType
            '
            Me.lblWeaponType.BorderStyle = BorderStyle.FixedSingle
            Me.lblWeaponType.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblWeaponType.Location = New Point(246, 89)
            Me.lblWeaponType.Margin = New Padding(4, 0, 4, 0)
            Me.lblWeaponType.Name = "lblWeaponType"
            Me.lblWeaponType.Size = New Size(125, 24)
            Me.lblWeaponType.TabIndex = 74
            Me.lblWeaponType.Text = "Weapon Type:"
            Me.lblWeaponType.TextAlign = ContentAlignment.MiddleRight
            '
            'lblWeapon
            '
            Me.lblWeapon.BorderStyle = BorderStyle.FixedSingle
            Me.lblWeapon.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblWeapon.Location = New Point(246, 129)
            Me.lblWeapon.Margin = New Padding(4, 0, 4, 0)
            Me.lblWeapon.Name = "lblWeapon"
            Me.lblWeapon.Size = New Size(125, 24)
            Me.lblWeapon.TabIndex = 73
            Me.lblWeapon.Tag = ""
            Me.lblWeapon.Text = "Weapon:"
            Me.lblWeapon.TextAlign = ContentAlignment.MiddleRight
            '
            'cmbWeapon
            '
            Me.cmbWeapon.DropDownStyle = ComboBoxStyle.DropDownList
            Me.cmbWeapon.Enabled = False
            Me.cmbWeapon.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.cmbWeapon.FormattingEnabled = True
            Me.cmbWeapon.Location = New Point(379, 129)
            Me.cmbWeapon.Name = "cmbWeapon"
            Me.cmbWeapon.Size = New Size(175, 24)
            Me.cmbWeapon.TabIndex = 4
            '
            'cmbArmor
            '
            Me.cmbArmor.DropDownStyle = ComboBoxStyle.DropDownList
            Me.cmbArmor.Enabled = False
            Me.cmbArmor.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.cmbArmor.FormattingEnabled = True
            Me.cmbArmor.Location = New Point(379, 169)
            Me.cmbArmor.Name = "cmbArmor"
            Me.cmbArmor.Size = New Size(175, 24)
            Me.cmbArmor.TabIndex = 5
            '
            'Label12
            '
            Me.Label12.BorderStyle = BorderStyle.FixedSingle
            Me.Label12.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Label12.Location = New Point(246, 169)
            Me.Label12.Margin = New Padding(4, 0, 4, 0)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New Size(125, 24)
            Me.Label12.TabIndex = 76
            Me.Label12.Text = "Armor:"
            Me.Label12.TextAlign = ContentAlignment.MiddleRight
            '
            'txtWeaponSkill
            '
            Me.txtWeaponSkill.Enabled = False
            Me.txtWeaponSkill.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.txtWeaponSkill.Location = New Point(379, 210)
            Me.txtWeaponSkill.Margin = New Padding(4)
            Me.txtWeaponSkill.MaxLength = 2
            Me.txtWeaponSkill.Name = "txtWeaponSkill"
            Me.txtWeaponSkill.Size = New Size(50, 22)
            Me.txtWeaponSkill.TabIndex = 6
            Me.txtWeaponSkill.TextAlign = HorizontalAlignment.Center
            '
            'Label5
            '
            Me.Label5.BorderStyle = BorderStyle.FixedSingle
            Me.Label5.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.Location = New Point(246, 209)
            Me.Label5.Margin = New Padding(4, 0, 4, 0)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New Size(125, 24)
            Me.Label5.TabIndex = 78
            Me.Label5.Text = "Weapon Skill:"
            Me.Label5.TextAlign = ContentAlignment.MiddleRight
            '
            'txtSlipping
            '
            Me.txtSlipping.Enabled = False
            Me.txtSlipping.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.txtSlipping.Location = New Point(379, 286)
            Me.txtSlipping.Margin = New Padding(4)
            Me.txtSlipping.MaxLength = 2
            Me.txtSlipping.Name = "txtSlipping"
            Me.txtSlipping.Size = New Size(50, 22)
            Me.txtSlipping.TabIndex = 8
            Me.txtSlipping.TextAlign = HorizontalAlignment.Center
            '
            'txtBlocking
            '
            Me.txtBlocking.Enabled = False
            Me.txtBlocking.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.txtBlocking.Location = New Point(379, 248)
            Me.txtBlocking.Margin = New Padding(4)
            Me.txtBlocking.MaxLength = 2
            Me.txtBlocking.Name = "txtBlocking"
            Me.txtBlocking.Size = New Size(50, 22)
            Me.txtBlocking.TabIndex = 7
            Me.txtBlocking.TextAlign = HorizontalAlignment.Center
            '
            'Label8
            '
            Me.Label8.BorderStyle = BorderStyle.FixedSingle
            Me.Label8.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.Location = New Point(246, 247)
            Me.Label8.Margin = New Padding(4, 0, 4, 0)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New Size(125, 24)
            Me.Label8.TabIndex = 82
            Me.Label8.Text = "Blocking:"
            Me.Label8.TextAlign = ContentAlignment.MiddleRight
            '
            'Label1
            '
            Me.Label1.BorderStyle = BorderStyle.FixedSingle
            Me.Label1.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New Point(246, 285)
            Me.Label1.Margin = New Padding(4, 0, 4, 0)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New Size(125, 24)
            Me.Label1.TabIndex = 79
            Me.Label1.Text = "Slipping:"
            Me.Label1.TextAlign = ContentAlignment.MiddleRight
            '
            'frmAdminEnemies
            '
            Me.AutoScaleDimensions = New SizeF(9.0!, 18.0!)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.CancelButton = Me.btnExit
            Me.ClientSize = New Size(567, 323)
            Me.Controls.Add(Me.txtSlipping)
            Me.Controls.Add(Me.txtBlocking)
            Me.Controls.Add(Me.Label8)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.txtWeaponSkill)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.cmbArmor)
            Me.Controls.Add(Me.Label12)
            Me.Controls.Add(Me.cmbWeaponType)
            Me.Controls.Add(Me.lblWeaponType)
            Me.Controls.Add(Me.cmbWeapon)
            Me.Controls.Add(Me.lblWeapon)
            Me.Controls.Add(Me.txtEndurance)
            Me.Controls.Add(Me.lblEnd)
            Me.Controls.Add(Me.txtName)
            Me.Controls.Add(Me.lblName)
            Me.Controls.Add(Me.btnClear)
            Me.Controls.Add(Me.btnExit)
            Me.Controls.Add(Me.btnSave)
            Me.Controls.Add(Me.lstEnemies)
            Me.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Margin = New Padding(4)
            Me.MaximizeBox = False
            Me.MaximumSize = New Size(583, 362)
            Me.MinimumSize = New Size(583, 362)
            Me.Name = "frmAdminEnemies"
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.Text = "Admin Enemies"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents LstEnemies As ListBox
        Friend WithEvents BtnClear As Button
        Friend WithEvents BtnExit As Button
        Friend WithEvents BtnSave As Button
        Friend WithEvents TxtName As TextBox
        Friend WithEvents lblName As Label
        Friend WithEvents TxtEndurance As TextBox
        Friend WithEvents lblEnd As Label
        Friend WithEvents CmbWeaponType As ComboBox
        Friend WithEvents lblWeaponType As Label
        Friend WithEvents lblWeapon As Label
        Friend WithEvents CmbWeapon As ComboBox
        Friend WithEvents CmbArmor As ComboBox
        Friend WithEvents Label12 As Label
        Friend WithEvents TxtWeaponSkill As TextBox
        Friend WithEvents Label5 As Label
        Friend WithEvents TxtSlipping As TextBox
        Friend WithEvents TxtBlocking As TextBox
        Friend WithEvents Label8 As Label
        Friend WithEvents Label1 As Label
    End Class
End NameSpace