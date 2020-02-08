Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

Namespace Forms
    <DesignerGenerated()>
    Partial Class FrmBattle
        Inherits Form

        'Form overrides dispose to clean up the component list.
        <DebuggerNonUserCode()>
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
        <DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.TxtBattle = New System.Windows.Forms.TextBox()
            Me.LblPlrArmor = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.LblPlrWeapon = New System.Windows.Forms.Label()
            Me.LblPlrStatus = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.LblPlrEnd = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.LblPlrName = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.LblEneArmor = New System.Windows.Forms.Label()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.LblEneWeapon = New System.Windows.Forms.Label()
            Me.LblEneStatus = New System.Windows.Forms.Label()
            Me.Label13 = New System.Windows.Forms.Label()
            Me.LblEneEnd = New System.Windows.Forms.Label()
            Me.Label15 = New System.Windows.Forms.Label()
            Me.Label16 = New System.Windows.Forms.Label()
            Me.LblEnemyName = New System.Windows.Forms.Label()
            Me.BtnAttack = New System.Windows.Forms.Button()
            Me.BtnBerserk = New System.Windows.Forms.Button()
            Me.BtnDefend = New System.Windows.Forms.Button()
            Me.BtnFlee = New System.Windows.Forms.Button()
            Me.BtnInventory = New System.Windows.Forms.Button()
            Me.BtnLunge = New System.Windows.Forms.Button()
            Me.BtnParry = New System.Windows.Forms.Button()
            Me.BtnQuickCombat = New System.Windows.Forms.Button()
            Me.BtnExit = New System.Windows.Forms.Button()
            Me.SuspendLayout()
            '
            'TxtBattle
            '
            Me.TxtBattle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.TxtBattle.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TxtBattle.Location = New System.Drawing.Point(12, 12)
            Me.TxtBattle.MinimumSize = New System.Drawing.Size(400, 200)
            Me.TxtBattle.Multiline = True
            Me.TxtBattle.Name = "TxtBattle"
            Me.TxtBattle.ReadOnly = True
            Me.TxtBattle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.TxtBattle.Size = New System.Drawing.Size(400, 200)
            Me.TxtBattle.TabIndex = 1
            '
            'LblPlrArmor
            '
            Me.LblPlrArmor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblPlrArmor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblPlrArmor.Location = New System.Drawing.Point(528, 100)
            Me.LblPlrArmor.Name = "LblPlrArmor"
            Me.LblPlrArmor.Size = New System.Drawing.Size(101, 23)
            Me.LblPlrArmor.TabIndex = 42
            Me.LblPlrArmor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label8
            '
            Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.Location = New System.Drawing.Point(428, 100)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(101, 23)
            Me.Label8.TabIndex = 43
            Me.Label8.Text = "Armor:"
            Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'LblPlrWeapon
            '
            Me.LblPlrWeapon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblPlrWeapon.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblPlrWeapon.Location = New System.Drawing.Point(528, 78)
            Me.LblPlrWeapon.Name = "LblPlrWeapon"
            Me.LblPlrWeapon.Size = New System.Drawing.Size(101, 23)
            Me.LblPlrWeapon.TabIndex = 40
            Me.LblPlrWeapon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'LblPlrStatus
            '
            Me.LblPlrStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblPlrStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblPlrStatus.Location = New System.Drawing.Point(528, 56)
            Me.LblPlrStatus.Name = "LblPlrStatus"
            Me.LblPlrStatus.Size = New System.Drawing.Size(101, 23)
            Me.LblPlrStatus.TabIndex = 38
            Me.LblPlrStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label6
            '
            Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.Location = New System.Drawing.Point(428, 78)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(101, 23)
            Me.Label6.TabIndex = 41
            Me.Label6.Text = "Weapon"
            Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'LblPlrEnd
            '
            Me.LblPlrEnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblPlrEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblPlrEnd.Location = New System.Drawing.Point(528, 34)
            Me.LblPlrEnd.Name = "LblPlrEnd"
            Me.LblPlrEnd.Size = New System.Drawing.Size(101, 23)
            Me.LblPlrEnd.TabIndex = 36
            Me.LblPlrEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label4
            '
            Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(428, 56)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(101, 23)
            Me.Label4.TabIndex = 39
            Me.Label4.Text = "Status:"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'LblPlrName
            '
            Me.LblPlrName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblPlrName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblPlrName.Location = New System.Drawing.Point(428, 12)
            Me.LblPlrName.Name = "LblPlrName"
            Me.LblPlrName.Size = New System.Drawing.Size(201, 23)
            Me.LblPlrName.TabIndex = 35
            Me.LblPlrName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label2
            '
            Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(428, 34)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(101, 23)
            Me.Label2.TabIndex = 37
            Me.Label2.Text = "Endurance:"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'LblEneArmor
            '
            Me.LblEneArmor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblEneArmor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblEneArmor.Location = New System.Drawing.Point(528, 311)
            Me.LblEneArmor.Name = "LblEneArmor"
            Me.LblEneArmor.Size = New System.Drawing.Size(101, 23)
            Me.LblEneArmor.TabIndex = 51
            Me.LblEneArmor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label10
            '
            Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label10.Location = New System.Drawing.Point(428, 311)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(101, 23)
            Me.Label10.TabIndex = 52
            Me.Label10.Text = "Armor:"
            Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'LblEneWeapon
            '
            Me.LblEneWeapon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblEneWeapon.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblEneWeapon.Location = New System.Drawing.Point(528, 289)
            Me.LblEneWeapon.Name = "LblEneWeapon"
            Me.LblEneWeapon.Size = New System.Drawing.Size(101, 23)
            Me.LblEneWeapon.TabIndex = 49
            Me.LblEneWeapon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'LblEneStatus
            '
            Me.LblEneStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblEneStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblEneStatus.Location = New System.Drawing.Point(528, 267)
            Me.LblEneStatus.Name = "LblEneStatus"
            Me.LblEneStatus.Size = New System.Drawing.Size(101, 23)
            Me.LblEneStatus.TabIndex = 47
            Me.LblEneStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label13
            '
            Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label13.Location = New System.Drawing.Point(428, 289)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(101, 23)
            Me.Label13.TabIndex = 50
            Me.Label13.Text = "Weapon"
            Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'LblEneEnd
            '
            Me.LblEneEnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblEneEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblEneEnd.Location = New System.Drawing.Point(528, 245)
            Me.LblEneEnd.Name = "LblEneEnd"
            Me.LblEneEnd.Size = New System.Drawing.Size(101, 23)
            Me.LblEneEnd.TabIndex = 45
            Me.LblEneEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label15
            '
            Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label15.Location = New System.Drawing.Point(428, 267)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(101, 23)
            Me.Label15.TabIndex = 48
            Me.Label15.Text = "Status:"
            Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label16
            '
            Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label16.Location = New System.Drawing.Point(428, 245)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New System.Drawing.Size(101, 23)
            Me.Label16.TabIndex = 46
            Me.Label16.Text = "Endurance:"
            Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'LblEnemyName
            '
            Me.LblEnemyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblEnemyName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblEnemyName.Location = New System.Drawing.Point(428, 223)
            Me.LblEnemyName.Name = "LblEnemyName"
            Me.LblEnemyName.Size = New System.Drawing.Size(201, 23)
            Me.LblEnemyName.TabIndex = 44
            Me.LblEnemyName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'BtnAttack
            '
            Me.BtnAttack.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnAttack.Location = New System.Drawing.Point(12, 223)
            Me.BtnAttack.Name = "BtnAttack"
            Me.BtnAttack.Size = New System.Drawing.Size(120, 32)
            Me.BtnAttack.TabIndex = 53
            Me.BtnAttack.Text = "&Attack"
            Me.BtnAttack.UseVisualStyleBackColor = True
            '
            'BtnBerserk
            '
            Me.BtnBerserk.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnBerserk.Location = New System.Drawing.Point(152, 223)
            Me.BtnBerserk.Name = "BtnBerserk"
            Me.BtnBerserk.Size = New System.Drawing.Size(120, 32)
            Me.BtnBerserk.TabIndex = 54
            Me.BtnBerserk.Text = "&Berserk"
            Me.BtnBerserk.UseVisualStyleBackColor = True
            '
            'BtnDefend
            '
            Me.BtnDefend.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnDefend.Location = New System.Drawing.Point(292, 223)
            Me.BtnDefend.Name = "BtnDefend"
            Me.BtnDefend.Size = New System.Drawing.Size(120, 32)
            Me.BtnDefend.TabIndex = 55
            Me.BtnDefend.Text = "&Defend"
            Me.BtnDefend.UseVisualStyleBackColor = True
            '
            'BtnFlee
            '
            Me.BtnFlee.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnFlee.Location = New System.Drawing.Point(12, 266)
            Me.BtnFlee.Name = "BtnFlee"
            Me.BtnFlee.Size = New System.Drawing.Size(120, 32)
            Me.BtnFlee.TabIndex = 56
            Me.BtnFlee.Text = "&Flee"
            Me.BtnFlee.UseVisualStyleBackColor = True
            '
            'BtnInventory
            '
            Me.BtnInventory.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnInventory.Location = New System.Drawing.Point(470, 157)
            Me.BtnInventory.Name = "BtnInventory"
            Me.BtnInventory.Size = New System.Drawing.Size(120, 32)
            Me.BtnInventory.TabIndex = 57
            Me.BtnInventory.Text = "&Inventory"
            Me.BtnInventory.UseVisualStyleBackColor = True
            '
            'BtnLunge
            '
            Me.BtnLunge.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnLunge.Location = New System.Drawing.Point(152, 266)
            Me.BtnLunge.Name = "BtnLunge"
            Me.BtnLunge.Size = New System.Drawing.Size(120, 32)
            Me.BtnLunge.TabIndex = 58
            Me.BtnLunge.Text = "&Lunge"
            Me.BtnLunge.UseVisualStyleBackColor = True
            '
            'BtnParry
            '
            Me.BtnParry.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnParry.Location = New System.Drawing.Point(292, 266)
            Me.BtnParry.Name = "BtnParry"
            Me.BtnParry.Size = New System.Drawing.Size(120, 32)
            Me.BtnParry.TabIndex = 59
            Me.BtnParry.Text = "&Parry"
            Me.BtnParry.UseVisualStyleBackColor = True
            '
            'BtnQuickCombat
            '
            Me.BtnQuickCombat.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnQuickCombat.Location = New System.Drawing.Point(38, 309)
            Me.BtnQuickCombat.Name = "BtnQuickCombat"
            Me.BtnQuickCombat.Size = New System.Drawing.Size(150, 32)
            Me.BtnQuickCombat.TabIndex = 60
            Me.BtnQuickCombat.Text = "&Quick Combat"
            Me.BtnQuickCombat.UseVisualStyleBackColor = True
            '
            'BtnExit
            '
            Me.BtnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.BtnExit.Enabled = False
            Me.BtnExit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnExit.Location = New System.Drawing.Point(238, 309)
            Me.BtnExit.Name = "BtnExit"
            Me.BtnExit.Size = New System.Drawing.Size(150, 32)
            Me.BtnExit.TabIndex = 61
            Me.BtnExit.Text = "E&xit"
            Me.BtnExit.UseVisualStyleBackColor = True
            '
            'FrmBattle
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.BtnExit
            Me.ClientSize = New System.Drawing.Size(641, 352)
            Me.Controls.Add(Me.BtnExit)
            Me.Controls.Add(Me.BtnQuickCombat)
            Me.Controls.Add(Me.BtnParry)
            Me.Controls.Add(Me.BtnLunge)
            Me.Controls.Add(Me.BtnInventory)
            Me.Controls.Add(Me.BtnFlee)
            Me.Controls.Add(Me.BtnDefend)
            Me.Controls.Add(Me.BtnBerserk)
            Me.Controls.Add(Me.BtnAttack)
            Me.Controls.Add(Me.LblEneArmor)
            Me.Controls.Add(Me.Label10)
            Me.Controls.Add(Me.LblEneWeapon)
            Me.Controls.Add(Me.LblEneStatus)
            Me.Controls.Add(Me.Label13)
            Me.Controls.Add(Me.LblEneEnd)
            Me.Controls.Add(Me.Label15)
            Me.Controls.Add(Me.Label16)
            Me.Controls.Add(Me.LblEnemyName)
            Me.Controls.Add(Me.LblPlrArmor)
            Me.Controls.Add(Me.Label8)
            Me.Controls.Add(Me.LblPlrWeapon)
            Me.Controls.Add(Me.LblPlrStatus)
            Me.Controls.Add(Me.Label6)
            Me.Controls.Add(Me.LblPlrEnd)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.LblPlrName)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.TxtBattle)
            Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Margin = New System.Windows.Forms.Padding(4)
            Me.MaximizeBox = False
            Me.MaximumSize = New System.Drawing.Size(657, 391)
            Me.MinimumSize = New System.Drawing.Size(657, 391)
            Me.Name = "FrmBattle"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Battle"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents TxtBattle As TextBox
        Friend WithEvents LblPlrArmor As Label
        Friend WithEvents Label8 As Label
        Friend WithEvents LblPlrWeapon As Label
        Friend WithEvents LblPlrStatus As Label
        Friend WithEvents Label6 As Label
        Friend WithEvents LblPlrEnd As Label
        Friend WithEvents Label4 As Label
        Friend WithEvents LblPlrName As Label
        Friend WithEvents Label2 As Label
        Friend WithEvents LblEneArmor As Label
        Friend WithEvents Label10 As Label
        Friend WithEvents LblEneWeapon As Label
        Friend WithEvents LblEneStatus As Label
        Friend WithEvents Label13 As Label
        Friend WithEvents LblEneEnd As Label
        Friend WithEvents Label15 As Label
        Friend WithEvents Label16 As Label
        Friend WithEvents LblEnemyName As Label
        Friend WithEvents BtnAttack As Button
        Friend WithEvents BtnBerserk As Button
        Friend WithEvents BtnDefend As Button
        Friend WithEvents BtnFlee As Button
        Friend WithEvents BtnInventory As Button
        Friend WithEvents BtnLunge As Button
        Friend WithEvents BtnParry As Button
        Friend WithEvents BtnQuickCombat As Button
        Friend WithEvents BtnExit As Button
    End Class
End NameSpace