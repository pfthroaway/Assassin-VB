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
            Me.lblValue = New Label()
            Me.Label4 = New Label()
            Me.lblCurrent = New Label()
            Me.BtnPurchase = New Button()
            Me.lblPrice = New Label()
            Me.Label2 = New Label()
            Me.lblGold = New Label()
            Me.Label1 = New Label()
            Me.BtnBack = New Button()
            Me.TxtWeapons = New TextBox()
            Me.BtnClear = New Button()
            Me.lblSelected = New Label()
            Me.lblCurrentDamage = New Label()
            Me.Label5 = New Label()
            Me.Label6 = New Label()
            Me.lblSelectedDamage = New Label()
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
            'cmbTwoH
            '
            Me.CmbTwoH.AutoSize = True
            Me.CmbTwoH.Location = New Point(148, 21)
            Me.CmbTwoH.Name = "cmbTwoH"
            Me.CmbTwoH.Size = New Size(70, 22)
            Me.CmbTwoH.TabIndex = 3
            Me.CmbTwoH.TabStop = True
            Me.CmbTwoH.Text = "&Two-H"
            Me.CmbTwoH.UseVisualStyleBackColor = True
            '
            'cmbHeavy
            '
            Me.CmbHeavy.AutoSize = True
            Me.CmbHeavy.Location = New Point(73, 21)
            Me.CmbHeavy.Name = "cmbHeavy"
            Me.CmbHeavy.Size = New Size(69, 22)
            Me.CmbHeavy.TabIndex = 2
            Me.CmbHeavy.TabStop = True
            Me.CmbHeavy.Text = "&Heavy"
            Me.CmbHeavy.UseVisualStyleBackColor = True
            '
            'cmbLight
            '
            Me.CmbLight.AutoSize = True
            Me.CmbLight.Location = New Point(7, 21)
            Me.CmbLight.Name = "cmbLight"
            Me.CmbLight.Size = New Size(60, 22)
            Me.CmbLight.TabIndex = 1
            Me.CmbLight.TabStop = True
            Me.CmbLight.Text = "&Light"
            Me.CmbLight.UseVisualStyleBackColor = True
            '
            'lstWeapons
            '
            Me.LstWeapons.FormattingEnabled = True
            Me.LstWeapons.ItemHeight = 18
            Me.LstWeapons.Location = New Point(13, 67)
            Me.LstWeapons.Name = "lstWeapons"
            Me.LstWeapons.Size = New Size(224, 166)
            Me.LstWeapons.TabIndex = 4
            '
            'btnSell
            '
            Me.BtnSell.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnSell.Location = New Point(47, 288)
            Me.BtnSell.Name = "btnSell"
            Me.BtnSell.Size = New Size(150, 35)
            Me.BtnSell.TabIndex = 6
            Me.BtnSell.Text = "&Sell"
            Me.BtnSell.UseVisualStyleBackColor = True
            '
            'lblValue
            '
            Me.lblValue.BorderStyle = BorderStyle.FixedSingle
            Me.lblValue.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblValue.Location = New Point(392, 94)
            Me.lblValue.Name = "lblValue"
            Me.lblValue.Size = New Size(150, 25)
            Me.lblValue.TabIndex = 15
            Me.lblValue.TextAlign = ContentAlignment.MiddleCenter
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
            'lblCurrent
            '
            Me.lblCurrent.BorderStyle = BorderStyle.FixedSingle
            Me.lblCurrent.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblCurrent.Location = New Point(243, 70)
            Me.lblCurrent.Name = "lblCurrent"
            Me.lblCurrent.Size = New Size(299, 25)
            Me.lblCurrent.TabIndex = 13
            Me.lblCurrent.Text = "Current Weapon"
            Me.lblCurrent.TextAlign = ContentAlignment.MiddleCenter
            '
            'btnPurchase
            '
            Me.BtnPurchase.Enabled = False
            Me.BtnPurchase.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnPurchase.Location = New Point(47, 247)
            Me.BtnPurchase.Name = "btnPurchase"
            Me.BtnPurchase.Size = New Size(150, 35)
            Me.BtnPurchase.TabIndex = 5
            Me.BtnPurchase.Text = "&Purchase"
            Me.BtnPurchase.UseVisualStyleBackColor = True
            '
            'lblPrice
            '
            Me.lblPrice.BorderStyle = BorderStyle.FixedSingle
            Me.lblPrice.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblPrice.Location = New Point(392, 190)
            Me.lblPrice.Name = "lblPrice"
            Me.lblPrice.Size = New Size(150, 25)
            Me.lblPrice.TabIndex = 11
            Me.lblPrice.TextAlign = ContentAlignment.MiddleCenter
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
            'lblGold
            '
            Me.lblGold.BorderStyle = BorderStyle.FixedSingle
            Me.lblGold.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblGold.Location = New Point(392, 22)
            Me.lblGold.Name = "lblGold"
            Me.lblGold.Size = New Size(150, 25)
            Me.lblGold.TabIndex = 9
            Me.lblGold.TextAlign = ContentAlignment.MiddleCenter
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
            'btnBack
            '
            Me.BtnBack.DialogResult = DialogResult.Cancel
            Me.BtnBack.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnBack.Location = New Point(47, 370)
            Me.BtnBack.Name = "btnBack"
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
            'btnClear
            '
            Me.BtnClear.Enabled = False
            Me.BtnClear.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnClear.Location = New Point(47, 329)
            Me.BtnClear.Name = "btnClear"
            Me.BtnClear.Size = New Size(150, 35)
            Me.BtnClear.TabIndex = 7
            Me.BtnClear.Text = "&Clear"
            Me.BtnClear.UseVisualStyleBackColor = True
            '
            'lblSelected
            '
            Me.lblSelected.BorderStyle = BorderStyle.FixedSingle
            Me.lblSelected.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblSelected.Location = New Point(243, 166)
            Me.lblSelected.Name = "lblSelected"
            Me.lblSelected.Size = New Size(299, 25)
            Me.lblSelected.TabIndex = 16
            Me.lblSelected.TextAlign = ContentAlignment.MiddleCenter
            '
            'lblCurrentDamage
            '
            Me.lblCurrentDamage.BorderStyle = BorderStyle.FixedSingle
            Me.lblCurrentDamage.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblCurrentDamage.Location = New Point(392, 118)
            Me.lblCurrentDamage.Name = "lblCurrentDamage"
            Me.lblCurrentDamage.Size = New Size(150, 25)
            Me.lblCurrentDamage.TabIndex = 18
            Me.lblCurrentDamage.TextAlign = ContentAlignment.MiddleCenter
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
            'lblSelectedDamage
            '
            Me.lblSelectedDamage.BorderStyle = BorderStyle.FixedSingle
            Me.lblSelectedDamage.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblSelectedDamage.Location = New Point(392, 214)
            Me.lblSelectedDamage.Name = "lblSelectedDamage"
            Me.lblSelectedDamage.Size = New Size(150, 25)
            Me.lblSelectedDamage.TabIndex = 20
            Me.lblSelectedDamage.TextAlign = ContentAlignment.MiddleCenter
            '
            'frmWeapons
            '
            Me.AutoScaleDimensions = New SizeF(9.0!, 18.0!)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.CancelButton = Me.BtnBack
            Me.ClientSize = New Size(559, 415)
            Me.Controls.Add(Me.lblSelectedDamage)
            Me.Controls.Add(Me.Label6)
            Me.Controls.Add(Me.lblCurrentDamage)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.lblSelected)
            Me.Controls.Add(Me.BtnClear)
            Me.Controls.Add(Me.TxtWeapons)
            Me.Controls.Add(Me.BtnBack)
            Me.Controls.Add(Me.BtnSell)
            Me.Controls.Add(Me.lblValue)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.lblCurrent)
            Me.Controls.Add(Me.BtnPurchase)
            Me.Controls.Add(Me.lblPrice)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.lblGold)
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
        Friend WithEvents lblValue As Label
        Friend WithEvents Label4 As Label
        Friend WithEvents lblCurrent As Label
        Friend WithEvents BtnPurchase As Button
        Friend WithEvents lblPrice As Label
        Friend WithEvents Label2 As Label
        Friend WithEvents lblGold As Label
        Friend WithEvents Label1 As Label
        Friend WithEvents BtnBack As Button
        Friend WithEvents TxtWeapons As TextBox
        Friend WithEvents BtnClear As Button
        Friend WithEvents lblSelected As Label
        Friend WithEvents lblCurrentDamage As Label
        Friend WithEvents Label5 As Label
        Friend WithEvents Label6 As Label
        Friend WithEvents lblSelectedDamage As Label
    End Class
End Namespace