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
            Me.LstEnemies = New ListBox()
            Me.BtnClear = New Button()
            Me.BtnExit = New Button()
            Me.BtnSave = New Button()
            Me.txtName = New TextBox()
            Me.LblName = New Label()
            Me.txtEndurance = New TextBox()
            Me.LblEnd = New Label()
            Me.CmbWeaponType = New ComboBox()
            Me.LblWeaponType = New Label()
            Me.LblWeapon = New Label()
            Me.CmbWeapon = New ComboBox()
            Me.CmbArmor = New ComboBox()
            Me.Label12 = New Label()
            Me.txtWeaponSkill = New TextBox()
            Me.Label5 = New Label()
            Me.txtSlipping = New TextBox()
            Me.txtBlocking = New TextBox()
            Me.Label8 = New Label()
            Me.Label1 = New Label()
            Me.SuspendLayout()
            '
            'LstEnemies
            '
            Me.LstEnemies.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.LstEnemies.FormattingEnabled = True
            Me.LstEnemies.ItemHeight = 18
            Me.LstEnemies.Location = New Point(13, 13)
            Me.LstEnemies.Margin = New Padding(4)
            Me.LstEnemies.Name = "LstEnemies"
            Me.LstEnemies.ScrollAlwaysVisible = True
            Me.LstEnemies.Size = New Size(225, 184)
            Me.LstEnemies.TabIndex = 0
            '
            'BtnClear
            '
            Me.BtnClear.Enabled = False
            Me.BtnClear.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnClear.Location = New Point(63, 205)
            Me.BtnClear.Margin = New Padding(4)
            Me.BtnClear.Name = "BtnClear"
            Me.BtnClear.Size = New Size(125, 30)
            Me.BtnClear.TabIndex = 40
            Me.BtnClear.Text = "&Clear"
            Me.BtnClear.UseVisualStyleBackColor = True
            '
            'BtnExit
            '
            Me.BtnExit.DialogResult = DialogResult.Cancel
            Me.BtnExit.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnExit.Location = New Point(63, 281)
            Me.BtnExit.Margin = New Padding(4)
            Me.BtnExit.Name = "BtnExit"
            Me.BtnExit.Size = New Size(125, 30)
            Me.BtnExit.TabIndex = 42
            Me.BtnExit.Text = "E&xit"
            Me.BtnExit.UseVisualStyleBackColor = True
            '
            'BtnSave
            '
            Me.BtnSave.Enabled = False
            Me.BtnSave.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnSave.Location = New Point(63, 243)
            Me.BtnSave.Margin = New Padding(4)
            Me.BtnSave.Name = "BtnSave"
            Me.BtnSave.Size = New Size(125, 30)
            Me.BtnSave.TabIndex = 41
            Me.BtnSave.Text = "&Save"
            Me.BtnSave.UseVisualStyleBackColor = True
            '
            'txtName
            '
            Me.txtName.Enabled = False
            Me.txtName.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.txtName.Location = New Point(379, 14)
            Me.txtName.Margin = New Padding(4)
            Me.txtName.MaxLength = 20
            Me.txtName.Name = "txtName"
            Me.txtName.Size = New Size(175, 22)
            Me.txtName.TabIndex = 1
            Me.txtName.TextAlign = HorizontalAlignment.Center
            '
            'LblName
            '
            Me.LblName.BorderStyle = BorderStyle.FixedSingle
            Me.LblName.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.LblName.Location = New Point(246, 13)
            Me.LblName.Margin = New Padding(4, 0, 4, 0)
            Me.LblName.Name = "LblName"
            Me.LblName.Size = New Size(125, 24)
            Me.LblName.TabIndex = 44
            Me.LblName.Text = "Name:"
            Me.LblName.TextAlign = ContentAlignment.MiddleRight
            '
            'txtEndurance
            '
            Me.txtEndurance.Enabled = False
            Me.txtEndurance.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.txtEndurance.Location = New Point(379, 52)
            Me.txtEndurance.Margin = New Padding(4)
            Me.txtEndurance.MaxLength = 4
            Me.txtEndurance.Name = "txtEndurance"
            Me.txtEndurance.Size = New Size(50, 22)
            Me.txtEndurance.TabIndex = 2
            Me.txtEndurance.TextAlign = HorizontalAlignment.Center
            '
            'LblEnd
            '
            Me.LblEnd.BorderStyle = BorderStyle.FixedSingle
            Me.LblEnd.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.LblEnd.Location = New Point(246, 51)
            Me.LblEnd.Margin = New Padding(4, 0, 4, 0)
            Me.LblEnd.Name = "LblEnd"
            Me.LblEnd.Size = New Size(125, 24)
            Me.LblEnd.TabIndex = 45
            Me.LblEnd.Text = "Endurance:"
            Me.LblEnd.TextAlign = ContentAlignment.MiddleRight
            '
            'CmbWeaponType
            '
            Me.CmbWeaponType.DropDownStyle = ComboBoxStyle.DropDownList
            Me.CmbWeaponType.Enabled = False
            Me.CmbWeaponType.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.CmbWeaponType.FormattingEnabled = True
            Me.CmbWeaponType.Items.AddRange(New Object() {"Light", "Heavy", "Two-H"})
            Me.CmbWeaponType.Location = New Point(379, 89)
            Me.CmbWeaponType.Name = "CmbWeaponType"
            Me.CmbWeaponType.Size = New Size(101, 24)
            Me.CmbWeaponType.TabIndex = 3
            '
            'LblWeaponType
            '
            Me.LblWeaponType.BorderStyle = BorderStyle.FixedSingle
            Me.LblWeaponType.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.LblWeaponType.Location = New Point(246, 89)
            Me.LblWeaponType.Margin = New Padding(4, 0, 4, 0)
            Me.LblWeaponType.Name = "LblWeaponType"
            Me.LblWeaponType.Size = New Size(125, 24)
            Me.LblWeaponType.TabIndex = 74
            Me.LblWeaponType.Text = "Weapon Type:"
            Me.LblWeaponType.TextAlign = ContentAlignment.MiddleRight
            '
            'LblWeapon
            '
            Me.LblWeapon.BorderStyle = BorderStyle.FixedSingle
            Me.LblWeapon.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.LblWeapon.Location = New Point(246, 129)
            Me.LblWeapon.Margin = New Padding(4, 0, 4, 0)
            Me.LblWeapon.Name = "LblWeapon"
            Me.LblWeapon.Size = New Size(125, 24)
            Me.LblWeapon.TabIndex = 73
            Me.LblWeapon.Tag = ""
            Me.LblWeapon.Text = "Weapon:"
            Me.LblWeapon.TextAlign = ContentAlignment.MiddleRight
            '
            'CmbWeapon
            '
            Me.CmbWeapon.DropDownStyle = ComboBoxStyle.DropDownList
            Me.CmbWeapon.Enabled = False
            Me.CmbWeapon.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.CmbWeapon.FormattingEnabled = True
            Me.CmbWeapon.Location = New Point(379, 129)
            Me.CmbWeapon.Name = "CmbWeapon"
            Me.CmbWeapon.Size = New Size(175, 24)
            Me.CmbWeapon.TabIndex = 4
            '
            'CmbArmor
            '
            Me.CmbArmor.DropDownStyle = ComboBoxStyle.DropDownList
            Me.CmbArmor.Enabled = False
            Me.CmbArmor.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.CmbArmor.FormattingEnabled = True
            Me.CmbArmor.Location = New Point(379, 169)
            Me.CmbArmor.Name = "CmbArmor"
            Me.CmbArmor.Size = New Size(175, 24)
            Me.CmbArmor.TabIndex = 5
            '
            'Label12
            '
            Me.Label12.BorderStyle = BorderStyle.FixedSingle
            Me.Label12.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
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
            Me.txtWeaponSkill.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
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
            Me.Label5.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
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
            Me.txtSlipping.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
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
            Me.txtBlocking.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
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
            Me.Label8.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
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
            Me.Label1.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
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
            Me.CancelButton = Me.BtnExit
            Me.ClientSize = New Size(567, 323)
            Me.Controls.Add(Me.txtSlipping)
            Me.Controls.Add(Me.txtBlocking)
            Me.Controls.Add(Me.Label8)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.txtWeaponSkill)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.CmbArmor)
            Me.Controls.Add(Me.Label12)
            Me.Controls.Add(Me.CmbWeaponType)
            Me.Controls.Add(Me.LblWeaponType)
            Me.Controls.Add(Me.CmbWeapon)
            Me.Controls.Add(Me.LblWeapon)
            Me.Controls.Add(Me.txtEndurance)
            Me.Controls.Add(Me.LblEnd)
            Me.Controls.Add(Me.txtName)
            Me.Controls.Add(Me.LblName)
            Me.Controls.Add(Me.BtnClear)
            Me.Controls.Add(Me.BtnExit)
            Me.Controls.Add(Me.BtnSave)
            Me.Controls.Add(Me.LstEnemies)
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
        Friend WithEvents LblName As Label
        Friend WithEvents TxtEndurance As TextBox
        Friend WithEvents LblEnd As Label
        Friend WithEvents CmbWeaponType As ComboBox
        Friend WithEvents LblWeaponType As Label
        Friend WithEvents LblWeapon As Label
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