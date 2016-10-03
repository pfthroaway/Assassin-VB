<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWeapons
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
        Me.grpWeaponType = New System.Windows.Forms.GroupBox()
        Me.cmbTwoH = New System.Windows.Forms.RadioButton()
        Me.cmbHeavy = New System.Windows.Forms.RadioButton()
        Me.cmbLight = New System.Windows.Forms.RadioButton()
        Me.lstWeapons = New System.Windows.Forms.ListBox()
        Me.btnSell = New System.Windows.Forms.Button()
        Me.lblValue = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblCurrent = New System.Windows.Forms.Label()
        Me.btnPurchase = New System.Windows.Forms.Button()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblGold = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.txtWeapons = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblSelected = New System.Windows.Forms.Label()
        Me.lblCurrentDamage = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblSelectedDamage = New System.Windows.Forms.Label()
        Me.grpWeaponType.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpWeaponType
        '
        Me.grpWeaponType.Controls.Add(Me.cmbTwoH)
        Me.grpWeaponType.Controls.Add(Me.cmbHeavy)
        Me.grpWeaponType.Controls.Add(Me.cmbLight)
        Me.grpWeaponType.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpWeaponType.Location = New System.Drawing.Point(13, 13)
        Me.grpWeaponType.Name = "grpWeaponType"
        Me.grpWeaponType.Size = New System.Drawing.Size(224, 47)
        Me.grpWeaponType.TabIndex = 0
        Me.grpWeaponType.TabStop = False
        Me.grpWeaponType.Text = "Weapon Type"
        '
        'cmbTwoH
        '
        Me.cmbTwoH.AutoSize = True
        Me.cmbTwoH.Location = New System.Drawing.Point(148, 21)
        Me.cmbTwoH.Name = "cmbTwoH"
        Me.cmbTwoH.Size = New System.Drawing.Size(70, 22)
        Me.cmbTwoH.TabIndex = 3
        Me.cmbTwoH.TabStop = True
        Me.cmbTwoH.Text = "&Two-H"
        Me.cmbTwoH.UseVisualStyleBackColor = True
        '
        'cmbHeavy
        '
        Me.cmbHeavy.AutoSize = True
        Me.cmbHeavy.Location = New System.Drawing.Point(73, 21)
        Me.cmbHeavy.Name = "cmbHeavy"
        Me.cmbHeavy.Size = New System.Drawing.Size(69, 22)
        Me.cmbHeavy.TabIndex = 2
        Me.cmbHeavy.TabStop = True
        Me.cmbHeavy.Text = "&Heavy"
        Me.cmbHeavy.UseVisualStyleBackColor = True
        '
        'cmbLight
        '
        Me.cmbLight.AutoSize = True
        Me.cmbLight.Location = New System.Drawing.Point(7, 21)
        Me.cmbLight.Name = "cmbLight"
        Me.cmbLight.Size = New System.Drawing.Size(60, 22)
        Me.cmbLight.TabIndex = 1
        Me.cmbLight.TabStop = True
        Me.cmbLight.Text = "&Light"
        Me.cmbLight.UseVisualStyleBackColor = True
        '
        'lstWeapons
        '
        Me.lstWeapons.FormattingEnabled = True
        Me.lstWeapons.ItemHeight = 18
        Me.lstWeapons.Location = New System.Drawing.Point(13, 67)
        Me.lstWeapons.Name = "lstWeapons"
        Me.lstWeapons.Size = New System.Drawing.Size(224, 166)
        Me.lstWeapons.TabIndex = 4
        '
        'btnSell
        '
        Me.btnSell.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSell.Location = New System.Drawing.Point(47, 288)
        Me.btnSell.Name = "btnSell"
        Me.btnSell.Size = New System.Drawing.Size(150, 35)
        Me.btnSell.TabIndex = 6
        Me.btnSell.Text = "&Sell"
        Me.btnSell.UseVisualStyleBackColor = True
        '
        'lblValue
        '
        Me.lblValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblValue.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValue.Location = New System.Drawing.Point(392, 94)
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Size = New System.Drawing.Size(150, 25)
        Me.lblValue.TabIndex = 15
        Me.lblValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(243, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 25)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Value:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCurrent
        '
        Me.lblCurrent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCurrent.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrent.Location = New System.Drawing.Point(243, 70)
        Me.lblCurrent.Name = "lblCurrent"
        Me.lblCurrent.Size = New System.Drawing.Size(299, 25)
        Me.lblCurrent.TabIndex = 13
        Me.lblCurrent.Text = "Current Weapon"
        Me.lblCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPurchase
        '
        Me.btnPurchase.Enabled = False
        Me.btnPurchase.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPurchase.Location = New System.Drawing.Point(47, 247)
        Me.btnPurchase.Name = "btnPurchase"
        Me.btnPurchase.Size = New System.Drawing.Size(150, 35)
        Me.btnPurchase.TabIndex = 5
        Me.btnPurchase.Text = "&Purchase"
        Me.btnPurchase.UseVisualStyleBackColor = True
        '
        'lblPrice
        '
        Me.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPrice.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(392, 190)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(150, 25)
        Me.lblPrice.TabIndex = 11
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(243, 190)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 25)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Price:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGold
        '
        Me.lblGold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGold.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGold.Location = New System.Drawing.Point(392, 22)
        Me.lblGold.Name = "lblGold"
        Me.lblGold.Size = New System.Drawing.Size(150, 25)
        Me.lblGold.TabIndex = 9
        Me.lblGold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(243, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Gold on Hand:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBack
        '
        Me.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBack.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(47, 370)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(150, 35)
        Me.btnBack.TabIndex = 8
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'txtWeapons
        '
        Me.txtWeapons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtWeapons.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeapons.Location = New System.Drawing.Point(243, 262)
        Me.txtWeapons.Multiline = True
        Me.txtWeapons.Name = "txtWeapons"
        Me.txtWeapons.ReadOnly = True
        Me.txtWeapons.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtWeapons.Size = New System.Drawing.Size(299, 143)
        Me.txtWeapons.TabIndex = 9
        Me.txtWeapons.Text = "You enter Weapons 'R Us. The weaponsmith greets you." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & """Weapons 'R Us is the name," & _
    " tools of destruction is our game."""
        '
        'btnClear
        '
        Me.btnClear.Enabled = False
        Me.btnClear.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(47, 329)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(150, 35)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblSelected
        '
        Me.lblSelected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSelected.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelected.Location = New System.Drawing.Point(243, 166)
        Me.lblSelected.Name = "lblSelected"
        Me.lblSelected.Size = New System.Drawing.Size(299, 25)
        Me.lblSelected.TabIndex = 16
        Me.lblSelected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCurrentDamage
        '
        Me.lblCurrentDamage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCurrentDamage.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentDamage.Location = New System.Drawing.Point(392, 118)
        Me.lblCurrentDamage.Name = "lblCurrentDamage"
        Me.lblCurrentDamage.Size = New System.Drawing.Size(150, 25)
        Me.lblCurrentDamage.TabIndex = 18
        Me.lblCurrentDamage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(243, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(150, 25)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Damage:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(243, 214)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(150, 25)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Damage:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSelectedDamage
        '
        Me.lblSelectedDamage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSelectedDamage.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectedDamage.Location = New System.Drawing.Point(392, 214)
        Me.lblSelectedDamage.Name = "lblSelectedDamage"
        Me.lblSelectedDamage.Size = New System.Drawing.Size(150, 25)
        Me.lblSelectedDamage.TabIndex = 20
        Me.lblSelectedDamage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmWeapons
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnBack
        Me.ClientSize = New System.Drawing.Size(559, 415)
        Me.Controls.Add(Me.lblSelectedDamage)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblCurrentDamage)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblSelected)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtWeapons)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnSell)
        Me.Controls.Add(Me.lblValue)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblCurrent)
        Me.Controls.Add(Me.btnPurchase)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblGold)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstWeapons)
        Me.Controls.Add(Me.grpWeaponType)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(575, 454)
        Me.MinimumSize = New System.Drawing.Size(575, 454)
        Me.Name = "frmWeapons"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Weapons 'R Us"
        Me.grpWeaponType.ResumeLayout(False)
        Me.grpWeaponType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpWeaponType As System.Windows.Forms.GroupBox
    Friend WithEvents cmbTwoH As System.Windows.Forms.RadioButton
    Friend WithEvents cmbHeavy As System.Windows.Forms.RadioButton
    Friend WithEvents cmbLight As System.Windows.Forms.RadioButton
    Friend WithEvents lstWeapons As System.Windows.Forms.ListBox
    Friend WithEvents btnSell As System.Windows.Forms.Button
    Friend WithEvents lblValue As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblCurrent As System.Windows.Forms.Label
    Friend WithEvents btnPurchase As System.Windows.Forms.Button
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblGold As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents txtWeapons As System.Windows.Forms.TextBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblSelected As System.Windows.Forms.Label
    Friend WithEvents lblCurrentDamage As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblSelectedDamage As System.Windows.Forms.Label
End Class
