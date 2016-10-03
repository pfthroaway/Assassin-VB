<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminEnemies
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
        Me.lstEnemies = New System.Windows.Forms.ListBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtEndurance = New System.Windows.Forms.TextBox()
        Me.lblEnd = New System.Windows.Forms.Label()
        Me.cmbWeaponType = New System.Windows.Forms.ComboBox()
        Me.lblWeaponType = New System.Windows.Forms.Label()
        Me.lblWeapon = New System.Windows.Forms.Label()
        Me.cmbWeapon = New System.Windows.Forms.ComboBox()
        Me.cmbArmor = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtWeaponSkill = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSlipping = New System.Windows.Forms.TextBox()
        Me.txtBlocking = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstEnemies
        '
        Me.lstEnemies.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstEnemies.FormattingEnabled = True
        Me.lstEnemies.ItemHeight = 18
        Me.lstEnemies.Location = New System.Drawing.Point(13, 13)
        Me.lstEnemies.Margin = New System.Windows.Forms.Padding(4)
        Me.lstEnemies.Name = "lstEnemies"
        Me.lstEnemies.ScrollAlwaysVisible = True
        Me.lstEnemies.Size = New System.Drawing.Size(225, 184)
        Me.lstEnemies.TabIndex = 0
        '
        'btnClear
        '
        Me.btnClear.Enabled = False
        Me.btnClear.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(63, 205)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(125, 30)
        Me.btnClear.TabIndex = 40
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(63, 281)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(125, 30)
        Me.btnExit.TabIndex = 42
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(63, 243)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(125, 30)
        Me.btnSave.TabIndex = 41
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Enabled = False
        Me.txtName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(379, 14)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtName.MaxLength = 20
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(175, 22)
        Me.txtName.TabIndex = 1
        Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblName
        '
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(246, 13)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(125, 24)
        Me.lblName.TabIndex = 44
        Me.lblName.Text = "Name:"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtEndurance
        '
        Me.txtEndurance.Enabled = False
        Me.txtEndurance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEndurance.Location = New System.Drawing.Point(379, 52)
        Me.txtEndurance.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEndurance.MaxLength = 4
        Me.txtEndurance.Name = "txtEndurance"
        Me.txtEndurance.Size = New System.Drawing.Size(50, 22)
        Me.txtEndurance.TabIndex = 2
        Me.txtEndurance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblEnd
        '
        Me.lblEnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEnd.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnd.Location = New System.Drawing.Point(246, 51)
        Me.lblEnd.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEnd.Name = "lblEnd"
        Me.lblEnd.Size = New System.Drawing.Size(125, 24)
        Me.lblEnd.TabIndex = 45
        Me.lblEnd.Text = "Endurance:"
        Me.lblEnd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbWeaponType
        '
        Me.cmbWeaponType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbWeaponType.Enabled = False
        Me.cmbWeaponType.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbWeaponType.FormattingEnabled = True
        Me.cmbWeaponType.Items.AddRange(New Object() {"Light", "Heavy", "Two-H"})
        Me.cmbWeaponType.Location = New System.Drawing.Point(379, 89)
        Me.cmbWeaponType.Name = "cmbWeaponType"
        Me.cmbWeaponType.Size = New System.Drawing.Size(101, 24)
        Me.cmbWeaponType.TabIndex = 3
        '
        'lblWeaponType
        '
        Me.lblWeaponType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblWeaponType.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeaponType.Location = New System.Drawing.Point(246, 89)
        Me.lblWeaponType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWeaponType.Name = "lblWeaponType"
        Me.lblWeaponType.Size = New System.Drawing.Size(125, 24)
        Me.lblWeaponType.TabIndex = 74
        Me.lblWeaponType.Text = "Weapon Type:"
        Me.lblWeaponType.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblWeapon
        '
        Me.lblWeapon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblWeapon.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeapon.Location = New System.Drawing.Point(246, 129)
        Me.lblWeapon.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWeapon.Name = "lblWeapon"
        Me.lblWeapon.Size = New System.Drawing.Size(125, 24)
        Me.lblWeapon.TabIndex = 73
        Me.lblWeapon.Tag = ""
        Me.lblWeapon.Text = "Weapon:"
        Me.lblWeapon.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbWeapon
        '
        Me.cmbWeapon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbWeapon.Enabled = False
        Me.cmbWeapon.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbWeapon.FormattingEnabled = True
        Me.cmbWeapon.Location = New System.Drawing.Point(379, 129)
        Me.cmbWeapon.Name = "cmbWeapon"
        Me.cmbWeapon.Size = New System.Drawing.Size(175, 24)
        Me.cmbWeapon.TabIndex = 4
        '
        'cmbArmor
        '
        Me.cmbArmor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbArmor.Enabled = False
        Me.cmbArmor.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbArmor.FormattingEnabled = True
        Me.cmbArmor.Location = New System.Drawing.Point(379, 169)
        Me.cmbArmor.Name = "cmbArmor"
        Me.cmbArmor.Size = New System.Drawing.Size(175, 24)
        Me.cmbArmor.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(246, 169)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(125, 24)
        Me.Label12.TabIndex = 76
        Me.Label12.Text = "Armor:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtWeaponSkill
        '
        Me.txtWeaponSkill.Enabled = False
        Me.txtWeaponSkill.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeaponSkill.Location = New System.Drawing.Point(379, 210)
        Me.txtWeaponSkill.Margin = New System.Windows.Forms.Padding(4)
        Me.txtWeaponSkill.MaxLength = 2
        Me.txtWeaponSkill.Name = "txtWeaponSkill"
        Me.txtWeaponSkill.Size = New System.Drawing.Size(50, 22)
        Me.txtWeaponSkill.TabIndex = 6
        Me.txtWeaponSkill.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(246, 209)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 24)
        Me.Label5.TabIndex = 78
        Me.Label5.Text = "Weapon Skill:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSlipping
        '
        Me.txtSlipping.Enabled = False
        Me.txtSlipping.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSlipping.Location = New System.Drawing.Point(379, 286)
        Me.txtSlipping.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSlipping.MaxLength = 2
        Me.txtSlipping.Name = "txtSlipping"
        Me.txtSlipping.Size = New System.Drawing.Size(50, 22)
        Me.txtSlipping.TabIndex = 8
        Me.txtSlipping.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBlocking
        '
        Me.txtBlocking.Enabled = False
        Me.txtBlocking.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBlocking.Location = New System.Drawing.Point(379, 248)
        Me.txtBlocking.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBlocking.MaxLength = 2
        Me.txtBlocking.Name = "txtBlocking"
        Me.txtBlocking.Size = New System.Drawing.Size(50, 22)
        Me.txtBlocking.TabIndex = 7
        Me.txtBlocking.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(246, 247)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(125, 24)
        Me.Label8.TabIndex = 82
        Me.Label8.Text = "Blocking:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(246, 285)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 24)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "Slipping:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmAdminEnemies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(567, 323)
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
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(583, 362)
        Me.MinimumSize = New System.Drawing.Size(583, 362)
        Me.Name = "frmAdminEnemies"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin Enemies"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstEnemies As System.Windows.Forms.ListBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtEndurance As System.Windows.Forms.TextBox
    Friend WithEvents lblEnd As System.Windows.Forms.Label
    Friend WithEvents cmbWeaponType As System.Windows.Forms.ComboBox
    Friend WithEvents lblWeaponType As System.Windows.Forms.Label
    Friend WithEvents lblWeapon As System.Windows.Forms.Label
    Friend WithEvents cmbWeapon As System.Windows.Forms.ComboBox
    Friend WithEvents cmbArmor As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtWeaponSkill As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSlipping As System.Windows.Forms.TextBox
    Friend WithEvents txtBlocking As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
