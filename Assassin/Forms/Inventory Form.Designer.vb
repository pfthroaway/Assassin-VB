Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

Namespace Forms
    <DesignerGenerated()> _
    Partial Class FrmInventory
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
            Me.lblLight = New Label()
            Me.Label1 = New Label()
            Me.btnLight = New Button()
            Me.btnHeavy = New Button()
            Me.lblHeavy = New Label()
            Me.Label3 = New Label()
            Me.btnTwoH = New Button()
            Me.lblTwoH = New Label()
            Me.Label5 = New Label()
            Me.btnDrink = New Button()
            Me.lblPotion = New Label()
            Me.Label7 = New Label()
            Me.btnBack = New Button()
            Me.lblLockpicks = New Label()
            Me.Label4 = New Label()
            Me.SuspendLayout()
            '
            'lblLight
            '
            Me.lblLight.BorderStyle = BorderStyle.FixedSingle
            Me.lblLight.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblLight.Location = New Point(138, 9)
            Me.lblLight.Name = "lblLight"
            Me.lblLight.Size = New Size(228, 25)
            Me.lblLight.TabIndex = 1
            Me.lblLight.TextAlign = ContentAlignment.MiddleCenter
            '
            'Label1
            '
            Me.Label1.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New Point(12, 9)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New Size(120, 25)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Light Weapon:"
            Me.Label1.TextAlign = ContentAlignment.MiddleRight
            '
            'btnLight
            '
            Me.btnLight.Font = New Font("Arial", 9.75!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnLight.Location = New Point(372, 9)
            Me.btnLight.Name = "btnLight"
            Me.btnLight.Size = New Size(75, 25)
            Me.btnLight.TabIndex = 2
            Me.btnLight.Text = "Equip"
            Me.btnLight.UseVisualStyleBackColor = True
            '
            'btnHeavy
            '
            Me.btnHeavy.Font = New Font("Arial", 9.75!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnHeavy.Location = New Point(372, 43)
            Me.btnHeavy.Name = "btnHeavy"
            Me.btnHeavy.Size = New Size(75, 25)
            Me.btnHeavy.TabIndex = 5
            Me.btnHeavy.Text = "Equip"
            Me.btnHeavy.UseVisualStyleBackColor = True
            '
            'lblHeavy
            '
            Me.lblHeavy.BorderStyle = BorderStyle.FixedSingle
            Me.lblHeavy.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblHeavy.Location = New Point(138, 43)
            Me.lblHeavy.Name = "lblHeavy"
            Me.lblHeavy.Size = New Size(228, 25)
            Me.lblHeavy.TabIndex = 4
            Me.lblHeavy.TextAlign = ContentAlignment.MiddleCenter
            '
            'Label3
            '
            Me.Label3.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New Point(12, 43)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New Size(120, 25)
            Me.Label3.TabIndex = 3
            Me.Label3.Text = "Heavy Weapon:"
            Me.Label3.TextAlign = ContentAlignment.MiddleRight
            '
            'btnTwoH
            '
            Me.btnTwoH.Font = New Font("Arial", 9.75!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnTwoH.Location = New Point(372, 77)
            Me.btnTwoH.Name = "btnTwoH"
            Me.btnTwoH.Size = New Size(75, 25)
            Me.btnTwoH.TabIndex = 8
            Me.btnTwoH.Text = "Equip"
            Me.btnTwoH.UseVisualStyleBackColor = True
            '
            'lblTwoH
            '
            Me.lblTwoH.BorderStyle = BorderStyle.FixedSingle
            Me.lblTwoH.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblTwoH.Location = New Point(138, 77)
            Me.lblTwoH.Name = "lblTwoH"
            Me.lblTwoH.Size = New Size(228, 25)
            Me.lblTwoH.TabIndex = 7
            Me.lblTwoH.TextAlign = ContentAlignment.MiddleCenter
            '
            'Label5
            '
            Me.Label5.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.Location = New Point(12, 77)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New Size(120, 25)
            Me.Label5.TabIndex = 6
            Me.Label5.Text = "Two-H Weapon:"
            Me.Label5.TextAlign = ContentAlignment.MiddleRight
            '
            'btnDrink
            '
            Me.btnDrink.Font = New Font("Arial", 9.75!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnDrink.Location = New Point(372, 111)
            Me.btnDrink.Name = "btnDrink"
            Me.btnDrink.Size = New Size(75, 25)
            Me.btnDrink.TabIndex = 11
            Me.btnDrink.Text = "&Drink"
            Me.btnDrink.UseVisualStyleBackColor = True
            '
            'lblPotion
            '
            Me.lblPotion.BorderStyle = BorderStyle.FixedSingle
            Me.lblPotion.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblPotion.Location = New Point(138, 111)
            Me.lblPotion.Name = "lblPotion"
            Me.lblPotion.Size = New Size(228, 25)
            Me.lblPotion.TabIndex = 10
            Me.lblPotion.TextAlign = ContentAlignment.MiddleCenter
            '
            'Label7
            '
            Me.Label7.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.Location = New Point(12, 111)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New Size(120, 25)
            Me.Label7.TabIndex = 9
            Me.Label7.Text = "Potion:"
            Me.Label7.TextAlign = ContentAlignment.MiddleRight
            '
            'btnBack
            '
            Me.btnBack.DialogResult = DialogResult.Cancel
            Me.btnBack.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnBack.Location = New Point(154, 184)
            Me.btnBack.Margin = New Padding(4)
            Me.btnBack.Name = "btnBack"
            Me.btnBack.Size = New Size(150, 30)
            Me.btnBack.TabIndex = 12
            Me.btnBack.Text = "&Back"
            Me.btnBack.UseVisualStyleBackColor = True
            '
            'lblLockpicks
            '
            Me.lblLockpicks.BorderStyle = BorderStyle.FixedSingle
            Me.lblLockpicks.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblLockpicks.Location = New Point(138, 145)
            Me.lblLockpicks.Name = "lblLockpicks"
            Me.lblLockpicks.Size = New Size(50, 25)
            Me.lblLockpicks.TabIndex = 14
            Me.lblLockpicks.TextAlign = ContentAlignment.MiddleCenter
            '
            'Label4
            '
            Me.Label4.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New Point(12, 145)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New Size(120, 25)
            Me.Label4.TabIndex = 13
            Me.Label4.Text = "Lockpicks:"
            Me.Label4.TextAlign = ContentAlignment.MiddleRight
            '
            'frmInventory
            '
            Me.AutoScaleDimensions = New SizeF(9.0!, 18.0!)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.CancelButton = Me.btnBack
            Me.ClientSize = New Size(459, 227)
            Me.Controls.Add(Me.lblLockpicks)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.btnBack)
            Me.Controls.Add(Me.btnDrink)
            Me.Controls.Add(Me.lblPotion)
            Me.Controls.Add(Me.Label7)
            Me.Controls.Add(Me.btnTwoH)
            Me.Controls.Add(Me.lblTwoH)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.btnHeavy)
            Me.Controls.Add(Me.lblHeavy)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.btnLight)
            Me.Controls.Add(Me.lblLight)
            Me.Controls.Add(Me.Label1)
            Me.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Margin = New Padding(4)
            Me.MaximizeBox = False
            Me.MaximumSize = New Size(475, 266)
            Me.MinimumSize = New Size(475, 266)
            Me.Name = "frmInventory"
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.Text = "Inventory"
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents lblLight As Label
        Friend WithEvents Label1 As Label
        Friend WithEvents BtnLight As Button
        Friend WithEvents BtnHeavy As Button
        Friend WithEvents lblHeavy As Label
        Friend WithEvents Label3 As Label
        Friend WithEvents BtnTwoH As Button
        Friend WithEvents lblTwoH As Label
        Friend WithEvents Label5 As Label
        Friend WithEvents BtnDrink As Button
        Friend WithEvents lblPotion As Label
        Friend WithEvents Label7 As Label
        Friend WithEvents BtnBack As Button
        Friend WithEvents lblLockpicks As Label
        Friend WithEvents Label4 As Label
    End Class
End NameSpace