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
            Me.LstEnemies = New System.Windows.Forms.ListBox()
            Me.BtnClear = New System.Windows.Forms.Button()
            Me.BtnExit = New System.Windows.Forms.Button()
            Me.BtnSave = New System.Windows.Forms.Button()
            Me.TxtName = New System.Windows.Forms.TextBox()
            Me.LblName = New System.Windows.Forms.Label()
            Me.TxtEndurance = New System.Windows.Forms.TextBox()
            Me.LblEnd = New System.Windows.Forms.Label()
            Me.CmbWeaponType = New System.Windows.Forms.ComboBox()
            Me.LblWeaponType = New System.Windows.Forms.Label()
            Me.LblWeapon = New System.Windows.Forms.Label()
            Me.CmbWeapon = New System.Windows.Forms.ComboBox()
            Me.CmbArmor = New System.Windows.Forms.ComboBox()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.TxtWeaponSkill = New System.Windows.Forms.TextBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.TxtSlipping = New System.Windows.Forms.TextBox()
            Me.TxtBlocking = New System.Windows.Forms.TextBox()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.TxtLevel = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.TxtGold = New System.Windows.Forms.TextBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.BtnNew = New System.Windows.Forms.Button()
            Me.BtnDelete = New System.Windows.Forms.Button()
            Me.SuspendLayout()
            '
            'LstEnemies
            '
            Me.LstEnemies.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LstEnemies.FormattingEnabled = True
            Me.LstEnemies.ItemHeight = 18
            Me.LstEnemies.Location = New System.Drawing.Point(13, 13)
            Me.LstEnemies.Margin = New System.Windows.Forms.Padding(4)
            Me.LstEnemies.Name = "LstEnemies"
            Me.LstEnemies.ScrollAlwaysVisible = True
            Me.LstEnemies.Size = New System.Drawing.Size(225, 184)
            Me.LstEnemies.TabIndex = 10
            '
            'BtnClear
            '
            Me.BtnClear.Enabled = False
            Me.BtnClear.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnClear.Location = New System.Drawing.Point(62, 243)
            Me.BtnClear.Margin = New System.Windows.Forms.Padding(4)
            Me.BtnClear.Name = "BtnClear"
            Me.BtnClear.Size = New System.Drawing.Size(125, 30)
            Me.BtnClear.TabIndex = 12
            Me.BtnClear.Text = "&Clear"
            Me.BtnClear.UseVisualStyleBackColor = True
            '
            'BtnExit
            '
            Me.BtnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.BtnExit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnExit.Location = New System.Drawing.Point(62, 357)
            Me.BtnExit.Margin = New System.Windows.Forms.Padding(4)
            Me.BtnExit.Name = "BtnExit"
            Me.BtnExit.Size = New System.Drawing.Size(125, 30)
            Me.BtnExit.TabIndex = 14
            Me.BtnExit.Text = "E&xit"
            Me.BtnExit.UseVisualStyleBackColor = True
            '
            'BtnSave
            '
            Me.BtnSave.Enabled = False
            Me.BtnSave.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnSave.Location = New System.Drawing.Point(62, 281)
            Me.BtnSave.Margin = New System.Windows.Forms.Padding(4)
            Me.BtnSave.Name = "BtnSave"
            Me.BtnSave.Size = New System.Drawing.Size(125, 30)
            Me.BtnSave.TabIndex = 13
            Me.BtnSave.Text = "&Save"
            Me.BtnSave.UseVisualStyleBackColor = True
            '
            'TxtName
            '
            Me.TxtName.Enabled = False
            Me.TxtName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TxtName.Location = New System.Drawing.Point(379, 13)
            Me.TxtName.Margin = New System.Windows.Forms.Padding(4)
            Me.TxtName.MaxLength = 20
            Me.TxtName.Name = "TxtName"
            Me.TxtName.Size = New System.Drawing.Size(175, 26)
            Me.TxtName.TabIndex = 0
            Me.TxtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'LblName
            '
            Me.LblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblName.Location = New System.Drawing.Point(246, 13)
            Me.LblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.LblName.Name = "LblName"
            Me.LblName.Size = New System.Drawing.Size(125, 24)
            Me.LblName.TabIndex = 15
            Me.LblName.Text = "Name:"
            Me.LblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'TxtEndurance
            '
            Me.TxtEndurance.Enabled = False
            Me.TxtEndurance.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TxtEndurance.Location = New System.Drawing.Point(379, 89)
            Me.TxtEndurance.Margin = New System.Windows.Forms.Padding(4)
            Me.TxtEndurance.MaxLength = 4
            Me.TxtEndurance.Name = "TxtEndurance"
            Me.TxtEndurance.Size = New System.Drawing.Size(50, 26)
            Me.TxtEndurance.TabIndex = 2
            Me.TxtEndurance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'LblEnd
            '
            Me.LblEnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblEnd.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblEnd.Location = New System.Drawing.Point(246, 89)
            Me.LblEnd.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.LblEnd.Name = "LblEnd"
            Me.LblEnd.Size = New System.Drawing.Size(125, 24)
            Me.LblEnd.TabIndex = 17
            Me.LblEnd.Text = "Endurance:"
            Me.LblEnd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'CmbWeaponType
            '
            Me.CmbWeaponType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.CmbWeaponType.Enabled = False
            Me.CmbWeaponType.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CmbWeaponType.FormattingEnabled = True
            Me.CmbWeaponType.Items.AddRange(New Object() {"Light", "Heavy", "TwoHanded"})
            Me.CmbWeaponType.Location = New System.Drawing.Point(379, 127)
            Me.CmbWeaponType.Name = "CmbWeaponType"
            Me.CmbWeaponType.Size = New System.Drawing.Size(101, 26)
            Me.CmbWeaponType.TabIndex = 3
            '
            'LblWeaponType
            '
            Me.LblWeaponType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblWeaponType.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblWeaponType.Location = New System.Drawing.Point(246, 127)
            Me.LblWeaponType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.LblWeaponType.Name = "LblWeaponType"
            Me.LblWeaponType.Size = New System.Drawing.Size(125, 24)
            Me.LblWeaponType.TabIndex = 18
            Me.LblWeaponType.Text = "Weapon Type:"
            Me.LblWeaponType.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'LblWeapon
            '
            Me.LblWeapon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblWeapon.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblWeapon.Location = New System.Drawing.Point(246, 165)
            Me.LblWeapon.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.LblWeapon.Name = "LblWeapon"
            Me.LblWeapon.Size = New System.Drawing.Size(125, 24)
            Me.LblWeapon.TabIndex = 19
            Me.LblWeapon.Tag = ""
            Me.LblWeapon.Text = "Weapon:"
            Me.LblWeapon.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'CmbWeapon
            '
            Me.CmbWeapon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.CmbWeapon.Enabled = False
            Me.CmbWeapon.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CmbWeapon.FormattingEnabled = True
            Me.CmbWeapon.Location = New System.Drawing.Point(379, 165)
            Me.CmbWeapon.Name = "CmbWeapon"
            Me.CmbWeapon.Size = New System.Drawing.Size(175, 26)
            Me.CmbWeapon.TabIndex = 4
            '
            'CmbArmor
            '
            Me.CmbArmor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.CmbArmor.Enabled = False
            Me.CmbArmor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CmbArmor.FormattingEnabled = True
            Me.CmbArmor.Location = New System.Drawing.Point(379, 203)
            Me.CmbArmor.Name = "CmbArmor"
            Me.CmbArmor.Size = New System.Drawing.Size(175, 26)
            Me.CmbArmor.TabIndex = 5
            '
            'Label12
            '
            Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label12.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label12.Location = New System.Drawing.Point(246, 203)
            Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(125, 24)
            Me.Label12.TabIndex = 20
            Me.Label12.Text = "Armor:"
            Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'TxtWeaponSkill
            '
            Me.TxtWeaponSkill.Enabled = False
            Me.TxtWeaponSkill.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TxtWeaponSkill.Location = New System.Drawing.Point(379, 279)
            Me.TxtWeaponSkill.Margin = New System.Windows.Forms.Padding(4)
            Me.TxtWeaponSkill.MaxLength = 2
            Me.TxtWeaponSkill.Name = "TxtWeaponSkill"
            Me.TxtWeaponSkill.Size = New System.Drawing.Size(50, 26)
            Me.TxtWeaponSkill.TabIndex = 7
            Me.TxtWeaponSkill.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Label5
            '
            Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.Location = New System.Drawing.Point(246, 279)
            Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(125, 24)
            Me.Label5.TabIndex = 22
            Me.Label5.Text = "Weapon Skill:"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'TxtSlipping
            '
            Me.TxtSlipping.Enabled = False
            Me.TxtSlipping.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TxtSlipping.Location = New System.Drawing.Point(379, 355)
            Me.TxtSlipping.Margin = New System.Windows.Forms.Padding(4)
            Me.TxtSlipping.MaxLength = 2
            Me.TxtSlipping.Name = "TxtSlipping"
            Me.TxtSlipping.Size = New System.Drawing.Size(50, 26)
            Me.TxtSlipping.TabIndex = 9
            Me.TxtSlipping.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'TxtBlocking
            '
            Me.TxtBlocking.Enabled = False
            Me.TxtBlocking.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TxtBlocking.Location = New System.Drawing.Point(379, 317)
            Me.TxtBlocking.Margin = New System.Windows.Forms.Padding(4)
            Me.TxtBlocking.MaxLength = 2
            Me.TxtBlocking.Name = "TxtBlocking"
            Me.TxtBlocking.Size = New System.Drawing.Size(50, 26)
            Me.TxtBlocking.TabIndex = 8
            Me.TxtBlocking.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Label8
            '
            Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.Location = New System.Drawing.Point(246, 317)
            Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(125, 24)
            Me.Label8.TabIndex = 23
            Me.Label8.Text = "Blocking:"
            Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label1
            '
            Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(246, 355)
            Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(125, 24)
            Me.Label1.TabIndex = 24
            Me.Label1.Text = "Slipping:"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'TxtLevel
            '
            Me.TxtLevel.Enabled = False
            Me.TxtLevel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TxtLevel.Location = New System.Drawing.Point(379, 51)
            Me.TxtLevel.Margin = New System.Windows.Forms.Padding(4)
            Me.TxtLevel.MaxLength = 2
            Me.TxtLevel.Name = "TxtLevel"
            Me.TxtLevel.Size = New System.Drawing.Size(50, 26)
            Me.TxtLevel.TabIndex = 1
            Me.TxtLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Label2
            '
            Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(246, 51)
            Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(125, 24)
            Me.Label2.TabIndex = 16
            Me.Label2.Text = "Level:"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'TxtGold
            '
            Me.TxtGold.Enabled = False
            Me.TxtGold.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TxtGold.Location = New System.Drawing.Point(379, 241)
            Me.TxtGold.Margin = New System.Windows.Forms.Padding(4)
            Me.TxtGold.MaxLength = 4
            Me.TxtGold.Name = "TxtGold"
            Me.TxtGold.Size = New System.Drawing.Size(50, 26)
            Me.TxtGold.TabIndex = 6
            Me.TxtGold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Label3
            '
            Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(246, 241)
            Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(125, 24)
            Me.Label3.TabIndex = 21
            Me.Label3.Text = "Gold:"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'BtnNew
            '
            Me.BtnNew.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnNew.Location = New System.Drawing.Point(62, 205)
            Me.BtnNew.Margin = New System.Windows.Forms.Padding(4)
            Me.BtnNew.Name = "BtnNew"
            Me.BtnNew.Size = New System.Drawing.Size(125, 30)
            Me.BtnNew.TabIndex = 11
            Me.BtnNew.Text = "&New"
            Me.BtnNew.UseVisualStyleBackColor = True
            '
            'BtnDelete
            '
            Me.BtnDelete.Enabled = False
            Me.BtnDelete.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnDelete.Location = New System.Drawing.Point(62, 319)
            Me.BtnDelete.Margin = New System.Windows.Forms.Padding(4)
            Me.BtnDelete.Name = "BtnDelete"
            Me.BtnDelete.Size = New System.Drawing.Size(125, 30)
            Me.BtnDelete.TabIndex = 25
            Me.BtnDelete.Text = "&Delete"
            Me.BtnDelete.UseVisualStyleBackColor = True
            '
            'FrmAdminEnemies
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.BtnExit
            Me.ClientSize = New System.Drawing.Size(567, 399)
            Me.Controls.Add(Me.BtnDelete)
            Me.Controls.Add(Me.BtnNew)
            Me.Controls.Add(Me.TxtGold)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.TxtLevel)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.TxtSlipping)
            Me.Controls.Add(Me.TxtBlocking)
            Me.Controls.Add(Me.Label8)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.TxtWeaponSkill)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.CmbArmor)
            Me.Controls.Add(Me.Label12)
            Me.Controls.Add(Me.CmbWeaponType)
            Me.Controls.Add(Me.LblWeaponType)
            Me.Controls.Add(Me.CmbWeapon)
            Me.Controls.Add(Me.LblWeapon)
            Me.Controls.Add(Me.TxtEndurance)
            Me.Controls.Add(Me.LblEnd)
            Me.Controls.Add(Me.TxtName)
            Me.Controls.Add(Me.LblName)
            Me.Controls.Add(Me.BtnClear)
            Me.Controls.Add(Me.BtnExit)
            Me.Controls.Add(Me.BtnSave)
            Me.Controls.Add(Me.LstEnemies)
            Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Margin = New System.Windows.Forms.Padding(4)
            Me.MaximizeBox = False
            Me.MaximumSize = New System.Drawing.Size(583, 438)
            Me.MinimumSize = New System.Drawing.Size(583, 438)
            Me.Name = "FrmAdminEnemies"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
        Friend WithEvents TxtLevel As TextBox
        Friend WithEvents Label2 As Label
        Friend WithEvents TxtGold As TextBox
        Friend WithEvents Label3 As Label
        Friend WithEvents BtnNew As Button
        Friend WithEvents BtnDelete As Button
    End Class
End NameSpace