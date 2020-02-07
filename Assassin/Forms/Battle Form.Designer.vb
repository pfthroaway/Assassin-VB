Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

Namespace Forms
    <DesignerGenerated()> _
    Partial Class FrmBattle
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
            Me.txtBattle = New TextBox()
            Me.lblPlrArmor = New Label()
            Me.Label8 = New Label()
            Me.lblPlrWeapon = New Label()
            Me.lblPlrStatus = New Label()
            Me.Label6 = New Label()
            Me.lblPlrEnd = New Label()
            Me.Label4 = New Label()
            Me.lblPlrName = New Label()
            Me.Label2 = New Label()
            Me.lblEneArmor = New Label()
            Me.Label10 = New Label()
            Me.lblEneWeapon = New Label()
            Me.lblEneStatus = New Label()
            Me.Label13 = New Label()
            Me.lblEneEnd = New Label()
            Me.Label15 = New Label()
            Me.Label16 = New Label()
            Me.lblEnemyName = New Label()
            Me.btnAttack = New Button()
            Me.btnBerserk = New Button()
            Me.btnDefend = New Button()
            Me.btnFlee = New Button()
            Me.btnInventory = New Button()
            Me.btnLunge = New Button()
            Me.btnParry = New Button()
            Me.btnQuickCombat = New Button()
            Me.btnExit = New Button()
            Me.Timer1 = New Timer(Me.components)
            Me.SuspendLayout()
            '
            'txtBattle
            '
            Me.txtBattle.BorderStyle = BorderStyle.FixedSingle
            Me.txtBattle.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.txtBattle.Location = New Point(12, 12)
            Me.txtBattle.MinimumSize = New Size(400, 200)
            Me.txtBattle.Multiline = True
            Me.txtBattle.Name = "txtBattle"
            Me.txtBattle.ReadOnly = True
            Me.txtBattle.ScrollBars = ScrollBars.Vertical
            Me.txtBattle.Size = New Size(400, 200)
            Me.txtBattle.TabIndex = 1
            '
            'lblPlrArmor
            '
            Me.lblPlrArmor.BorderStyle = BorderStyle.FixedSingle
            Me.lblPlrArmor.Font = New Font("Microsoft Sans Serif", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblPlrArmor.Location = New Point(528, 100)
            Me.lblPlrArmor.Name = "lblPlrArmor"
            Me.lblPlrArmor.Size = New Size(101, 23)
            Me.lblPlrArmor.TabIndex = 42
            Me.lblPlrArmor.TextAlign = ContentAlignment.MiddleCenter
            '
            'Label8
            '
            Me.Label8.BorderStyle = BorderStyle.FixedSingle
            Me.Label8.Font = New Font("Microsoft Sans Serif", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.Location = New Point(428, 100)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New Size(101, 23)
            Me.Label8.TabIndex = 43
            Me.Label8.Text = "Armor:"
            Me.Label8.TextAlign = ContentAlignment.MiddleCenter
            '
            'lblPlrWeapon
            '
            Me.lblPlrWeapon.BorderStyle = BorderStyle.FixedSingle
            Me.lblPlrWeapon.Font = New Font("Microsoft Sans Serif", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblPlrWeapon.Location = New Point(528, 78)
            Me.lblPlrWeapon.Name = "lblPlrWeapon"
            Me.lblPlrWeapon.Size = New Size(101, 23)
            Me.lblPlrWeapon.TabIndex = 40
            Me.lblPlrWeapon.TextAlign = ContentAlignment.MiddleCenter
            '
            'lblPlrStatus
            '
            Me.lblPlrStatus.BorderStyle = BorderStyle.FixedSingle
            Me.lblPlrStatus.Font = New Font("Microsoft Sans Serif", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblPlrStatus.Location = New Point(528, 56)
            Me.lblPlrStatus.Name = "lblPlrStatus"
            Me.lblPlrStatus.Size = New Size(101, 23)
            Me.lblPlrStatus.TabIndex = 38
            Me.lblPlrStatus.TextAlign = ContentAlignment.MiddleCenter
            '
            'Label6
            '
            Me.Label6.BorderStyle = BorderStyle.FixedSingle
            Me.Label6.Font = New Font("Microsoft Sans Serif", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.Location = New Point(428, 78)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New Size(101, 23)
            Me.Label6.TabIndex = 41
            Me.Label6.Text = "Weapon"
            Me.Label6.TextAlign = ContentAlignment.MiddleCenter
            '
            'lblPlrEnd
            '
            Me.lblPlrEnd.BorderStyle = BorderStyle.FixedSingle
            Me.lblPlrEnd.Font = New Font("Microsoft Sans Serif", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblPlrEnd.Location = New Point(528, 34)
            Me.lblPlrEnd.Name = "lblPlrEnd"
            Me.lblPlrEnd.Size = New Size(101, 23)
            Me.lblPlrEnd.TabIndex = 36
            Me.lblPlrEnd.TextAlign = ContentAlignment.MiddleCenter
            '
            'Label4
            '
            Me.Label4.BorderStyle = BorderStyle.FixedSingle
            Me.Label4.Font = New Font("Microsoft Sans Serif", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New Point(428, 56)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New Size(101, 23)
            Me.Label4.TabIndex = 39
            Me.Label4.Text = "Status:"
            Me.Label4.TextAlign = ContentAlignment.MiddleCenter
            '
            'lblPlrName
            '
            Me.lblPlrName.BorderStyle = BorderStyle.FixedSingle
            Me.lblPlrName.Font = New Font("Microsoft Sans Serif", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblPlrName.Location = New Point(428, 12)
            Me.lblPlrName.Name = "lblPlrName"
            Me.lblPlrName.Size = New Size(201, 23)
            Me.lblPlrName.TabIndex = 35
            Me.lblPlrName.TextAlign = ContentAlignment.MiddleCenter
            '
            'Label2
            '
            Me.Label2.BorderStyle = BorderStyle.FixedSingle
            Me.Label2.Font = New Font("Microsoft Sans Serif", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New Point(428, 34)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New Size(101, 23)
            Me.Label2.TabIndex = 37
            Me.Label2.Text = "Endurance:"
            Me.Label2.TextAlign = ContentAlignment.MiddleCenter
            '
            'lblEneArmor
            '
            Me.lblEneArmor.BorderStyle = BorderStyle.FixedSingle
            Me.lblEneArmor.Font = New Font("Microsoft Sans Serif", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblEneArmor.Location = New Point(528, 311)
            Me.lblEneArmor.Name = "lblEneArmor"
            Me.lblEneArmor.Size = New Size(101, 23)
            Me.lblEneArmor.TabIndex = 51
            Me.lblEneArmor.TextAlign = ContentAlignment.MiddleCenter
            '
            'Label10
            '
            Me.Label10.BorderStyle = BorderStyle.FixedSingle
            Me.Label10.Font = New Font("Microsoft Sans Serif", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Label10.Location = New Point(428, 311)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New Size(101, 23)
            Me.Label10.TabIndex = 52
            Me.Label10.Text = "Armor:"
            Me.Label10.TextAlign = ContentAlignment.MiddleCenter
            '
            'lblEneWeapon
            '
            Me.lblEneWeapon.BorderStyle = BorderStyle.FixedSingle
            Me.lblEneWeapon.Font = New Font("Microsoft Sans Serif", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblEneWeapon.Location = New Point(528, 289)
            Me.lblEneWeapon.Name = "lblEneWeapon"
            Me.lblEneWeapon.Size = New Size(101, 23)
            Me.lblEneWeapon.TabIndex = 49
            Me.lblEneWeapon.TextAlign = ContentAlignment.MiddleCenter
            '
            'lblEneStatus
            '
            Me.lblEneStatus.BorderStyle = BorderStyle.FixedSingle
            Me.lblEneStatus.Font = New Font("Microsoft Sans Serif", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblEneStatus.Location = New Point(528, 267)
            Me.lblEneStatus.Name = "lblEneStatus"
            Me.lblEneStatus.Size = New Size(101, 23)
            Me.lblEneStatus.TabIndex = 47
            Me.lblEneStatus.TextAlign = ContentAlignment.MiddleCenter
            '
            'Label13
            '
            Me.Label13.BorderStyle = BorderStyle.FixedSingle
            Me.Label13.Font = New Font("Microsoft Sans Serif", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Label13.Location = New Point(428, 289)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New Size(101, 23)
            Me.Label13.TabIndex = 50
            Me.Label13.Text = "Weapon"
            Me.Label13.TextAlign = ContentAlignment.MiddleCenter
            '
            'lblEneEnd
            '
            Me.lblEneEnd.BorderStyle = BorderStyle.FixedSingle
            Me.lblEneEnd.Font = New Font("Microsoft Sans Serif", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblEneEnd.Location = New Point(528, 245)
            Me.lblEneEnd.Name = "lblEneEnd"
            Me.lblEneEnd.Size = New Size(101, 23)
            Me.lblEneEnd.TabIndex = 45
            Me.lblEneEnd.TextAlign = ContentAlignment.MiddleCenter
            '
            'Label15
            '
            Me.Label15.BorderStyle = BorderStyle.FixedSingle
            Me.Label15.Font = New Font("Microsoft Sans Serif", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Label15.Location = New Point(428, 267)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New Size(101, 23)
            Me.Label15.TabIndex = 48
            Me.Label15.Text = "Status:"
            Me.Label15.TextAlign = ContentAlignment.MiddleCenter
            '
            'Label16
            '
            Me.Label16.BorderStyle = BorderStyle.FixedSingle
            Me.Label16.Font = New Font("Microsoft Sans Serif", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Label16.Location = New Point(428, 245)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New Size(101, 23)
            Me.Label16.TabIndex = 46
            Me.Label16.Text = "Endurance:"
            Me.Label16.TextAlign = ContentAlignment.MiddleCenter
            '
            'lblEnemyName
            '
            Me.lblEnemyName.BorderStyle = BorderStyle.FixedSingle
            Me.lblEnemyName.Font = New Font("Microsoft Sans Serif", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblEnemyName.Location = New Point(428, 223)
            Me.lblEnemyName.Name = "lblEnemyName"
            Me.lblEnemyName.Size = New Size(201, 23)
            Me.lblEnemyName.TabIndex = 44
            Me.lblEnemyName.TextAlign = ContentAlignment.MiddleCenter
            '
            'btnAttack
            '
            Me.btnAttack.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnAttack.Location = New Point(12, 223)
            Me.btnAttack.Name = "btnAttack"
            Me.btnAttack.Size = New Size(120, 32)
            Me.btnAttack.TabIndex = 53
            Me.btnAttack.Text = "&Attack"
            Me.btnAttack.UseVisualStyleBackColor = True
            '
            'btnBerserk
            '
            Me.btnBerserk.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnBerserk.Location = New Point(152, 223)
            Me.btnBerserk.Name = "btnBerserk"
            Me.btnBerserk.Size = New Size(120, 32)
            Me.btnBerserk.TabIndex = 54
            Me.btnBerserk.Text = "&Berserk"
            Me.btnBerserk.UseVisualStyleBackColor = True
            '
            'btnDefend
            '
            Me.btnDefend.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnDefend.Location = New Point(292, 223)
            Me.btnDefend.Name = "btnDefend"
            Me.btnDefend.Size = New Size(120, 32)
            Me.btnDefend.TabIndex = 55
            Me.btnDefend.Text = "&Defend"
            Me.btnDefend.UseVisualStyleBackColor = True
            '
            'btnFlee
            '
            Me.btnFlee.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnFlee.Location = New Point(12, 266)
            Me.btnFlee.Name = "btnFlee"
            Me.btnFlee.Size = New Size(120, 32)
            Me.btnFlee.TabIndex = 56
            Me.btnFlee.Text = "&Flee"
            Me.btnFlee.UseVisualStyleBackColor = True
            '
            'btnInventory
            '
            Me.btnInventory.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnInventory.Location = New Point(470, 157)
            Me.btnInventory.Name = "btnInventory"
            Me.btnInventory.Size = New Size(120, 32)
            Me.btnInventory.TabIndex = 57
            Me.btnInventory.Text = "&Inventory"
            Me.btnInventory.UseVisualStyleBackColor = True
            '
            'btnLunge
            '
            Me.btnLunge.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnLunge.Location = New Point(152, 266)
            Me.btnLunge.Name = "btnLunge"
            Me.btnLunge.Size = New Size(120, 32)
            Me.btnLunge.TabIndex = 58
            Me.btnLunge.Text = "&Lunge"
            Me.btnLunge.UseVisualStyleBackColor = True
            '
            'btnParry
            '
            Me.btnParry.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnParry.Location = New Point(292, 266)
            Me.btnParry.Name = "btnParry"
            Me.btnParry.Size = New Size(120, 32)
            Me.btnParry.TabIndex = 59
            Me.btnParry.Text = "&Parry"
            Me.btnParry.UseVisualStyleBackColor = True
            '
            'btnQuickCombat
            '
            Me.btnQuickCombat.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnQuickCombat.Location = New Point(38, 309)
            Me.btnQuickCombat.Name = "btnQuickCombat"
            Me.btnQuickCombat.Size = New Size(150, 32)
            Me.btnQuickCombat.TabIndex = 60
            Me.btnQuickCombat.Text = "&Quick Combat"
            Me.btnQuickCombat.UseVisualStyleBackColor = True
            '
            'btnExit
            '
            Me.btnExit.DialogResult = DialogResult.Cancel
            Me.btnExit.Enabled = False
            Me.btnExit.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnExit.Location = New Point(238, 309)
            Me.btnExit.Name = "btnExit"
            Me.btnExit.Size = New Size(150, 32)
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
            Me.AutoScaleDimensions = New SizeF(9.0!, 18.0!)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.CancelButton = Me.btnExit
            Me.ClientSize = New Size(641, 352)
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
            Me.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Margin = New Padding(4)
            Me.MaximizeBox = False
            Me.MaximumSize = New Size(657, 391)
            Me.MinimumSize = New Size(657, 391)
            Me.Name = "frmBattle"
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.Text = "Battle"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents TxtBattle As TextBox
        Friend WithEvents lblPlrArmor As Label
        Friend WithEvents Label8 As Label
        Friend WithEvents lblPlrWeapon As Label
        Friend WithEvents lblPlrStatus As Label
        Friend WithEvents Label6 As Label
        Friend WithEvents lblPlrEnd As Label
        Friend WithEvents Label4 As Label
        Friend WithEvents lblPlrName As Label
        Friend WithEvents Label2 As Label
        Friend WithEvents lblEneArmor As Label
        Friend WithEvents Label10 As Label
        Friend WithEvents lblEneWeapon As Label
        Friend WithEvents lblEneStatus As Label
        Friend WithEvents Label13 As Label
        Friend WithEvents lblEneEnd As Label
        Friend WithEvents Label15 As Label
        Friend WithEvents Label16 As Label
        Friend WithEvents lblEnemyName As Label
        Friend WithEvents BtnAttack As Button
        Friend WithEvents BtnBerserk As Button
        Friend WithEvents BtnDefend As Button
        Friend WithEvents BtnFlee As Button
        Friend WithEvents BtnInventory As Button
        Friend WithEvents BtnLunge As Button
        Friend WithEvents BtnParry As Button
        Friend WithEvents BtnQuickCombat As Button
        Friend WithEvents BtnExit As Button
        Friend WithEvents Timer1 As Timer
    End Class
End NameSpace