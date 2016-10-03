<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBattle
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
        Me.txtBattle = New System.Windows.Forms.TextBox()
        Me.lblPlrArmor = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblPlrWeapon = New System.Windows.Forms.Label()
        Me.lblPlrStatus = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblPlrEnd = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblPlrName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblEneArmor = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblEneWeapon = New System.Windows.Forms.Label()
        Me.lblEneStatus = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblEneEnd = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblEnemyName = New System.Windows.Forms.Label()
        Me.btnAttack = New System.Windows.Forms.Button()
        Me.btnBerserk = New System.Windows.Forms.Button()
        Me.btnDefend = New System.Windows.Forms.Button()
        Me.btnFlee = New System.Windows.Forms.Button()
        Me.btnInventory = New System.Windows.Forms.Button()
        Me.btnLunge = New System.Windows.Forms.Button()
        Me.btnParry = New System.Windows.Forms.Button()
        Me.btnQuickCombat = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'txtBattle
        '
        Me.txtBattle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBattle.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBattle.Location = New System.Drawing.Point(12, 12)
        Me.txtBattle.MinimumSize = New System.Drawing.Size(400, 200)
        Me.txtBattle.Multiline = True
        Me.txtBattle.Name = "txtBattle"
        Me.txtBattle.ReadOnly = True
        Me.txtBattle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtBattle.Size = New System.Drawing.Size(400, 200)
        Me.txtBattle.TabIndex = 1
        '
        'lblPlrArmor
        '
        Me.lblPlrArmor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPlrArmor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlrArmor.Location = New System.Drawing.Point(528, 100)
        Me.lblPlrArmor.Name = "lblPlrArmor"
        Me.lblPlrArmor.Size = New System.Drawing.Size(101, 23)
        Me.lblPlrArmor.TabIndex = 42
        Me.lblPlrArmor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(428, 100)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 23)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Armor:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPlrWeapon
        '
        Me.lblPlrWeapon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPlrWeapon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlrWeapon.Location = New System.Drawing.Point(528, 78)
        Me.lblPlrWeapon.Name = "lblPlrWeapon"
        Me.lblPlrWeapon.Size = New System.Drawing.Size(101, 23)
        Me.lblPlrWeapon.TabIndex = 40
        Me.lblPlrWeapon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPlrStatus
        '
        Me.lblPlrStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPlrStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlrStatus.Location = New System.Drawing.Point(528, 56)
        Me.lblPlrStatus.Name = "lblPlrStatus"
        Me.lblPlrStatus.Size = New System.Drawing.Size(101, 23)
        Me.lblPlrStatus.TabIndex = 38
        Me.lblPlrStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(428, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 23)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Weapon"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPlrEnd
        '
        Me.lblPlrEnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPlrEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlrEnd.Location = New System.Drawing.Point(528, 34)
        Me.lblPlrEnd.Name = "lblPlrEnd"
        Me.lblPlrEnd.Size = New System.Drawing.Size(101, 23)
        Me.lblPlrEnd.TabIndex = 36
        Me.lblPlrEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(428, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 23)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Status:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPlrName
        '
        Me.lblPlrName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPlrName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlrName.Location = New System.Drawing.Point(428, 12)
        Me.lblPlrName.Name = "lblPlrName"
        Me.lblPlrName.Size = New System.Drawing.Size(201, 23)
        Me.lblPlrName.TabIndex = 35
        Me.lblPlrName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(428, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 23)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Endurance:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEneArmor
        '
        Me.lblEneArmor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEneArmor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEneArmor.Location = New System.Drawing.Point(528, 311)
        Me.lblEneArmor.Name = "lblEneArmor"
        Me.lblEneArmor.Size = New System.Drawing.Size(101, 23)
        Me.lblEneArmor.TabIndex = 51
        Me.lblEneArmor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(428, 311)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(101, 23)
        Me.Label10.TabIndex = 52
        Me.Label10.Text = "Armor:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEneWeapon
        '
        Me.lblEneWeapon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEneWeapon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEneWeapon.Location = New System.Drawing.Point(528, 289)
        Me.lblEneWeapon.Name = "lblEneWeapon"
        Me.lblEneWeapon.Size = New System.Drawing.Size(101, 23)
        Me.lblEneWeapon.TabIndex = 49
        Me.lblEneWeapon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEneStatus
        '
        Me.lblEneStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEneStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEneStatus.Location = New System.Drawing.Point(528, 267)
        Me.lblEneStatus.Name = "lblEneStatus"
        Me.lblEneStatus.Size = New System.Drawing.Size(101, 23)
        Me.lblEneStatus.TabIndex = 47
        Me.lblEneStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(428, 289)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(101, 23)
        Me.Label13.TabIndex = 50
        Me.Label13.Text = "Weapon"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEneEnd
        '
        Me.lblEneEnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEneEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEneEnd.Location = New System.Drawing.Point(528, 245)
        Me.lblEneEnd.Name = "lblEneEnd"
        Me.lblEneEnd.Size = New System.Drawing.Size(101, 23)
        Me.lblEneEnd.TabIndex = 45
        Me.lblEneEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(428, 245)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(101, 23)
        Me.Label16.TabIndex = 46
        Me.Label16.Text = "Endurance:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEnemyName
        '
        Me.lblEnemyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEnemyName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnemyName.Location = New System.Drawing.Point(428, 223)
        Me.lblEnemyName.Name = "lblEnemyName"
        Me.lblEnemyName.Size = New System.Drawing.Size(201, 23)
        Me.lblEnemyName.TabIndex = 44
        Me.lblEnemyName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAttack
        '
        Me.btnAttack.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAttack.Location = New System.Drawing.Point(12, 223)
        Me.btnAttack.Name = "btnAttack"
        Me.btnAttack.Size = New System.Drawing.Size(120, 32)
        Me.btnAttack.TabIndex = 53
        Me.btnAttack.Text = "&Attack"
        Me.btnAttack.UseVisualStyleBackColor = True
        '
        'btnBerserk
        '
        Me.btnBerserk.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBerserk.Location = New System.Drawing.Point(152, 223)
        Me.btnBerserk.Name = "btnBerserk"
        Me.btnBerserk.Size = New System.Drawing.Size(120, 32)
        Me.btnBerserk.TabIndex = 54
        Me.btnBerserk.Text = "&Berserk"
        Me.btnBerserk.UseVisualStyleBackColor = True
        '
        'btnDefend
        '
        Me.btnDefend.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDefend.Location = New System.Drawing.Point(292, 223)
        Me.btnDefend.Name = "btnDefend"
        Me.btnDefend.Size = New System.Drawing.Size(120, 32)
        Me.btnDefend.TabIndex = 55
        Me.btnDefend.Text = "&Defend"
        Me.btnDefend.UseVisualStyleBackColor = True
        '
        'btnFlee
        '
        Me.btnFlee.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFlee.Location = New System.Drawing.Point(12, 266)
        Me.btnFlee.Name = "btnFlee"
        Me.btnFlee.Size = New System.Drawing.Size(120, 32)
        Me.btnFlee.TabIndex = 56
        Me.btnFlee.Text = "&Flee"
        Me.btnFlee.UseVisualStyleBackColor = True
        '
        'btnInventory
        '
        Me.btnInventory.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventory.Location = New System.Drawing.Point(470, 157)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Size = New System.Drawing.Size(120, 32)
        Me.btnInventory.TabIndex = 57
        Me.btnInventory.Text = "&Inventory"
        Me.btnInventory.UseVisualStyleBackColor = True
        '
        'btnLunge
        '
        Me.btnLunge.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLunge.Location = New System.Drawing.Point(152, 266)
        Me.btnLunge.Name = "btnLunge"
        Me.btnLunge.Size = New System.Drawing.Size(120, 32)
        Me.btnLunge.TabIndex = 58
        Me.btnLunge.Text = "&Lunge"
        Me.btnLunge.UseVisualStyleBackColor = True
        '
        'btnParry
        '
        Me.btnParry.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnParry.Location = New System.Drawing.Point(292, 266)
        Me.btnParry.Name = "btnParry"
        Me.btnParry.Size = New System.Drawing.Size(120, 32)
        Me.btnParry.TabIndex = 59
        Me.btnParry.Text = "&Parry"
        Me.btnParry.UseVisualStyleBackColor = True
        '
        'btnQuickCombat
        '
        Me.btnQuickCombat.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuickCombat.Location = New System.Drawing.Point(38, 309)
        Me.btnQuickCombat.Name = "btnQuickCombat"
        Me.btnQuickCombat.Size = New System.Drawing.Size(150, 32)
        Me.btnQuickCombat.TabIndex = 60
        Me.btnQuickCombat.Text = "&Quick Combat"
        Me.btnQuickCombat.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Enabled = False
        Me.btnExit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(238, 309)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(150, 32)
        Me.btnExit.TabIndex = 61
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 400
        '
        'frmBattle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(641, 352)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnQuickCombat)
        Me.Controls.Add(Me.btnParry)
        Me.Controls.Add(Me.btnLunge)
        Me.Controls.Add(Me.btnInventory)
        Me.Controls.Add(Me.btnFlee)
        Me.Controls.Add(Me.btnDefend)
        Me.Controls.Add(Me.btnBerserk)
        Me.Controls.Add(Me.btnAttack)
        Me.Controls.Add(Me.lblEneArmor)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblEneWeapon)
        Me.Controls.Add(Me.lblEneStatus)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblEneEnd)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.lblEnemyName)
        Me.Controls.Add(Me.lblPlrArmor)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblPlrWeapon)
        Me.Controls.Add(Me.lblPlrStatus)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblPlrEnd)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblPlrName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBattle)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(657, 391)
        Me.MinimumSize = New System.Drawing.Size(657, 391)
        Me.Name = "frmBattle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Battle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtBattle As System.Windows.Forms.TextBox
    Friend WithEvents lblPlrArmor As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblPlrWeapon As System.Windows.Forms.Label
    Friend WithEvents lblPlrStatus As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblPlrEnd As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblPlrName As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblEneArmor As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblEneWeapon As System.Windows.Forms.Label
    Friend WithEvents lblEneStatus As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblEneEnd As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblEnemyName As System.Windows.Forms.Label
    Friend WithEvents btnAttack As System.Windows.Forms.Button
    Friend WithEvents btnBerserk As System.Windows.Forms.Button
    Friend WithEvents btnDefend As System.Windows.Forms.Button
    Friend WithEvents btnFlee As System.Windows.Forms.Button
    Friend WithEvents btnInventory As System.Windows.Forms.Button
    Friend WithEvents btnLunge As System.Windows.Forms.Button
    Friend WithEvents btnParry As System.Windows.Forms.Button
    Friend WithEvents btnQuickCombat As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
