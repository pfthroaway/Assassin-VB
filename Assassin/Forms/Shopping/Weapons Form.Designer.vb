Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

Namespace Forms.Shopping
    <DesignerGenerated()>
    Partial Class FrmWeapons
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
            Me.grpWeaponType = New GroupBox()
            Me.CmbTwoH = New RadioButton()
            Me.CmbHeavy = New RadioButton()
            Me.CmbLight = New RadioButton()
            Me.LstWeapons = New ListBox()
            Me.BtnSell = New Button()
            Me.LblValue = New Label()
            Me.Label4 = New Label()
            Me.LblCurrent = New Label()
            Me.BtnPurchase = New Button()
            Me.LblPrice = New Label()
            Me.Label2 = New Label()
            Me.LblGold = New Label()
            Me.Label1 = New Label()
            Me.BtnBack = New Button()
            Me.TxtWeapons = New TextBox()
            Me.BtnClear = New Button()
            Me.LblSelected = New Label()
            Me.LblCurrentDamage = New Label()
            Me.Label5 = New Label()
            Me.Label6 = New Label()
            Me.LblSelectedDamage = New Label()
            Me.grpWeaponType.SuspendLayout()
            Me.SuspendLayout()
            '
            'grpWeaponType
            '
            Me.grpWeaponType.Controls.Add(Me.CmbTwoH)
            Me.grpWeaponType.Controls.Add(Me.CmbHeavy)
            Me.grpWeaponType.Controls.Add(Me.CmbLight)
            Me.grpWeaponType.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.grpWeaponType.Location = New Point(13, 13)
            Me.grpWeaponType.Name = "grpWeaponType"
            Me.grpWeaponType.Size = New Size(224, 47)
            Me.grpWeaponType.TabIndex = 0
            Me.grpWeaponType.TabStop = False
            Me.grpWeaponType.Text = "Weapon Type"
            '
            'CmbTwoH
            '
            Me.CmbTwoH.AutoSize = True
            Me.CmbTwoH.Location = New Point(148, 21)
            Me.CmbTwoH.Name = "CmbTwoH"
            Me.CmbTwoH.Size = New Size(70, 22)
            Me.CmbTwoH.TabIndex = 3
            Me.CmbTwoH.TabStop = True
            Me.CmbTwoH.Text = "&Two-H"
            Me.CmbTwoH.UseVisualStyleBackColor = True
            '
            'CmbHeavy
            '
            Me.CmbHeavy.AutoSize = True
            Me.CmbHeavy.Location = New Point(73, 21)
            Me.CmbHeavy.Name = "CmbHeavy"
            Me.CmbHeavy.Size = New Size(69, 22)
            Me.CmbHeavy.TabIndex = 2
            Me.CmbHeavy.TabStop = True
            Me.CmbHeavy.Text = "&Heavy"
            Me.CmbHeavy.UseVisualStyleBackColor = True
            '
            'CmbLight
            '
            Me.CmbLight.AutoSize = True
            Me.CmbLight.Location = New Point(7, 21)
            Me.CmbLight.Name = "CmbLight"
            Me.CmbLight.Size = New Size(60, 22)
            Me.CmbLight.TabIndex = 1
            Me.CmbLight.TabStop = True
            Me.CmbLight.Text = "&Light"
            Me.CmbLight.UseVisualStyleBackColor = True
            '
            'LstWeapons
            '
            Me.LstWeapons.FormattingEnabled = True
            Me.LstWeapons.ItemHeight = 18
            Me.LstWeapons.Location = New Point(13, 67)
            Me.LstWeapons.Name = "LstWeapons"
            Me.LstWeapons.Size = New Size(224, 166)
            Me.LstWeapons.TabIndex = 4
            '
            'BtnSell
            '
            Me.BtnSell.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnSell.Location = New Point(47, 288)
            Me.BtnSell.Name = "BtnSell"
            Me.BtnSell.Size = New Size(150, 35)
            Me.BtnSell.TabIndex = 6
            Me.BtnSell.Text = "&Sell"
            Me.BtnSell.UseVisualStyleBackColor = True
            '
            'LblValue
            '
            Me.LblValue.BorderStyle = BorderStyle.FixedSingle
            Me.LblValue.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.LblValue.Location = New Point(392, 94)
            Me.LblValue.Name = "LblValue"
            Me.LblValue.Size = New Size(150, 25)
            Me.LblValue.TabIndex = 15
            Me.LblValue.TextAlign = ContentAlignment.MiddleCenter
            '
            'Label4
            '
            Me.Label4.BorderStyle = BorderStyle.FixedSingle
            Me.Label4.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New Point(243, 94)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New Size(150, 25)
            Me.Label4.TabIndex = 14
            Me.Label4.Text = "Value:"
            Me.Label4.TextAlign = ContentAlignment.MiddleCenter
            '
            'LblCurrent
            '
            Me.LblCurrent.BorderStyle = BorderStyle.FixedSingle
            Me.LblCurrent.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.LblCurrent.Location = New Point(243, 70)
            Me.LblCurrent.Name = "LblCurrent"
            Me.LblCurrent.Size = New Size(299, 25)
            Me.LblCurrent.TabIndex = 13
            Me.LblCurrent.Text = "Current Weapon"
            Me.LblCurrent.TextAlign = ContentAlignment.MiddleCenter
            '
            'BtnPurchase
            '
            Me.BtnPurchase.Enabled = False
            Me.BtnPurchase.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnPurchase.Location = New Point(47, 247)
            Me.BtnPurchase.Name = "BtnPurchase"
            Me.BtnPurchase.Size = New Size(150, 35)
            Me.BtnPurchase.TabIndex = 5
            Me.BtnPurchase.Text = "&Purchase"
            Me.BtnPurchase.UseVisualStyleBackColor = True
            '
            'LblPrice
            '
            Me.LblPrice.BorderStyle = BorderStyle.FixedSingle
            Me.LblPrice.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.LblPrice.Location = New Point(392, 190)
            Me.LblPrice.Name = "LblPrice"
            Me.LblPrice.Size = New Size(150, 25)
            Me.LblPrice.TabIndex = 11
            Me.LblPrice.TextAlign = ContentAlignment.MiddleCenter
            '
            'Label2
            '
            Me.Label2.BorderStyle = BorderStyle.FixedSingle
            Me.Label2.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New Point(243, 190)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New Size(150, 25)
            Me.Label2.TabIndex = 10
            Me.Label2.Text = "Price:"
            Me.Label2.TextAlign = ContentAlignment.MiddleCenter
            '
            'LblGold
            '
            Me.LblGold.BorderStyle = BorderStyle.FixedSingle
            Me.LblGold.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.LblGold.Location = New Point(392, 22)
            Me.LblGold.Name = "LblGold"
            Me.LblGold.Size = New Size(150, 25)
            Me.LblGold.TabIndex = 9
            Me.LblGold.TextAlign = ContentAlignment.MiddleCenter
            '
            'Label1
            '
            Me.Label1.BorderStyle = BorderStyle.FixedSingle
            Me.Label1.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New Point(243, 22)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New Size(150, 25)
            Me.Label1.TabIndex = 8
            Me.Label1.Text = "Gold on Hand:"
            Me.Label1.TextAlign = ContentAlignment.MiddleCenter
            '
            'BtnBack
            '
            Me.BtnBack.DialogResult = DialogResult.Cancel
            Me.BtnBack.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnBack.Location = New Point(47, 370)
            Me.BtnBack.Name = "BtnBack"
            Me.BtnBack.Size = New Size(150, 35)
            Me.BtnBack.TabIndex = 8
            Me.BtnBack.Text = "&Back"
            Me.BtnBack.UseVisualStyleBackColor = True
            '
            'txtWeapons
            '
            Me.TxtWeapons.BorderStyle = BorderStyle.FixedSingle
            Me.TxtWeapons.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.TxtWeapons.Location = New Point(243, 262)
            Me.TxtWeapons.Multiline = True
            Me.TxtWeapons.Name = "txtWeapons"
            Me.TxtWeapons.ReadOnly = True
            Me.TxtWeapons.ScrollBars = ScrollBars.Vertical
            Me.TxtWeapons.Size = New Size(299, 143)
            Me.TxtWeapons.TabIndex = 9
            Me.TxtWeapons.Text = "You enter Weapons 'R Us. The weaponsmith greets you." & ChrW(13) & ChrW(10) & """Weapons 'R Us is the name," &
                                 " tools of destruction is our game."""
            '
            'BtnClear
            '
            Me.BtnClear.Enabled = False
            Me.BtnClear.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnClear.Location = New Point(47, 329)
            Me.BtnClear.Name = "BtnClear"
            Me.BtnClear.Size = New Size(150, 35)
            Me.BtnClear.TabIndex = 7
            Me.BtnClear.Text = "&Clear"
            Me.BtnClear.UseVisualStyleBackColor = True
            '
            'LblSelected
            '
            Me.LblSelected.BorderStyle = BorderStyle.FixedSingle
            Me.LblSelected.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.LblSelected.Location = New Point(243, 166)
            Me.LblSelected.Name = "LblSelected"
            Me.LblSelected.Size = New Size(299, 25)
            Me.LblSelected.TabIndex = 16
            Me.LblSelected.TextAlign = ContentAlignment.MiddleCenter
            '
            'LblCurrentDamage
            '
            Me.LblCurrentDamage.BorderStyle = BorderStyle.FixedSingle
            Me.LblCurrentDamage.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.LblCurrentDamage.Location = New Point(392, 118)
            Me.LblCurrentDamage.Name = "LblCurrentDamage"
            Me.LblCurrentDamage.Size = New Size(150, 25)
            Me.LblCurrentDamage.TabIndex = 18
            Me.LblCurrentDamage.TextAlign = ContentAlignment.MiddleCenter
            '
            'Label5
            '
            Me.Label5.BorderStyle = BorderStyle.FixedSingle
            Me.Label5.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.Location = New Point(243, 118)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New Size(150, 25)
            Me.Label5.TabIndex = 17
            Me.Label5.Text = "Damage:"
            Me.Label5.TextAlign = ContentAlignment.MiddleCenter
            '
            'Label6
            '
            Me.Label6.BorderStyle = BorderStyle.FixedSingle
            Me.Label6.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.Location = New Point(243, 214)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New Size(150, 25)
            Me.Label6.TabIndex = 19
            Me.Label6.Text = "Damage:"
            Me.Label6.TextAlign = ContentAlignment.MiddleCenter
            '
            'LblSelectedDamage
            '
            Me.LblSelectedDamage.BorderStyle = BorderStyle.FixedSingle
            Me.LblSelectedDamage.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.LblSelectedDamage.Location = New Point(392, 214)
            Me.LblSelectedDamage.Name = "LblSelectedDamage"
            Me.LblSelectedDamage.Size = New Size(150, 25)
            Me.LblSelectedDamage.TabIndex = 20
            Me.LblSelectedDamage.TextAlign = ContentAlignment.MiddleCenter
            '
            'frmWeapons
            '
            Me.AutoScaleDimensions = New SizeF(9.0!, 18.0!)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.CancelButton = Me.BtnBack
            Me.ClientSize = New Size(559, 415)
            Me.Controls.Add(Me.LblSelectedDamage)
            Me.Controls.Add(Me.Label6)
            Me.Controls.Add(Me.LblCurrentDamage)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.LblSelected)
            Me.Controls.Add(Me.BtnClear)
            Me.Controls.Add(Me.TxtWeapons)
            Me.Controls.Add(Me.BtnBack)
            Me.Controls.Add(Me.BtnSell)
            Me.Controls.Add(Me.LblValue)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.LblCurrent)
            Me.Controls.Add(Me.BtnPurchase)
            Me.Controls.Add(Me.LblPrice)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.LblGold)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.LstWeapons)
            Me.Controls.Add(Me.grpWeaponType)
            Me.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Margin = New Padding(4)
            Me.MaximizeBox = False
            Me.MaximumSize = New Size(575, 454)
            Me.MinimumSize = New Size(575, 454)
            Me.Name = "frmWeapons"
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.Text = "Weapons 'R Us"
            Me.grpWeaponType.ResumeLayout(False)
            Me.grpWeaponType.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents grpWeaponType As GroupBox
        Friend WithEvents CmbTwoH As RadioButton
        Friend WithEvents CmbHeavy As RadioButton
        Friend WithEvents CmbLight As RadioButton
        Friend WithEvents LstWeapons As ListBox
        Friend WithEvents BtnSell As Button
        Friend WithEvents LblValue As Label
        Friend WithEvents Label4 As Label
        Friend WithEvents LblCurrent As Label
        Friend WithEvents BtnPurchase As Button
        Friend WithEvents LblPrice As Label
        Friend WithEvents Label2 As Label
        Friend WithEvents LblGold As Label
        Friend WithEvents Label1 As Label
        Friend WithEvents BtnBack As Button
        Friend WithEvents TxtWeapons As TextBox
        Friend WithEvents BtnClear As Button
        Friend WithEvents LblSelected As Label
        Friend WithEvents LblCurrentDamage As Label
        Friend WithEvents Label5 As Label
        Friend WithEvents Label6 As Label
        Friend WithEvents LblSelectedDamage As Label
    End Class
End Namespace