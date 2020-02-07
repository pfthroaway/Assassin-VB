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
            Me.LblLight = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.BtnLight = New System.Windows.Forms.Button()
            Me.BtnHeavy = New System.Windows.Forms.Button()
            Me.LblHeavy = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.BtnTwoH = New System.Windows.Forms.Button()
            Me.LblTwoH = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.BtnDrink = New System.Windows.Forms.Button()
            Me.LblPotion = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.BtnBack = New System.Windows.Forms.Button()
            Me.LblLockpicks = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.SuspendLayout()
            '
            'LblLight
            '
            Me.LblLight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblLight.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblLight.Location = New System.Drawing.Point(138, 9)
            Me.LblLight.Name = "LblLight"
            Me.LblLight.Size = New System.Drawing.Size(228, 30)
            Me.LblLight.TabIndex = 1
            Me.LblLight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label1
            '
            Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(12, 12)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(120, 25)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Light Weapon:"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'BtnLight
            '
            Me.BtnLight.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnLight.Location = New System.Drawing.Point(372, 9)
            Me.BtnLight.Name = "BtnLight"
            Me.BtnLight.Size = New System.Drawing.Size(75, 30)
            Me.BtnLight.TabIndex = 2
            Me.BtnLight.Text = "Equip"
            Me.BtnLight.UseVisualStyleBackColor = True
            '
            'BtnHeavy
            '
            Me.BtnHeavy.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnHeavy.Location = New System.Drawing.Point(372, 43)
            Me.BtnHeavy.Name = "BtnHeavy"
            Me.BtnHeavy.Size = New System.Drawing.Size(75, 30)
            Me.BtnHeavy.TabIndex = 5
            Me.BtnHeavy.Text = "Equip"
            Me.BtnHeavy.UseVisualStyleBackColor = True
            '
            'LblHeavy
            '
            Me.LblHeavy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblHeavy.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblHeavy.Location = New System.Drawing.Point(138, 43)
            Me.LblHeavy.Name = "LblHeavy"
            Me.LblHeavy.Size = New System.Drawing.Size(228, 30)
            Me.LblHeavy.TabIndex = 4
            Me.LblHeavy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label3
            '
            Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(12, 46)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(120, 25)
            Me.Label3.TabIndex = 3
            Me.Label3.Text = "Heavy Weapon:"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'BtnTwoH
            '
            Me.BtnTwoH.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnTwoH.Location = New System.Drawing.Point(372, 77)
            Me.BtnTwoH.Name = "BtnTwoH"
            Me.BtnTwoH.Size = New System.Drawing.Size(75, 30)
            Me.BtnTwoH.TabIndex = 8
            Me.BtnTwoH.Text = "Equip"
            Me.BtnTwoH.UseVisualStyleBackColor = True
            '
            'LblTwoH
            '
            Me.LblTwoH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblTwoH.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblTwoH.Location = New System.Drawing.Point(138, 77)
            Me.LblTwoH.Name = "LblTwoH"
            Me.LblTwoH.Size = New System.Drawing.Size(228, 30)
            Me.LblTwoH.TabIndex = 7
            Me.LblTwoH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label5
            '
            Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.Location = New System.Drawing.Point(12, 80)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(120, 25)
            Me.Label5.TabIndex = 6
            Me.Label5.Text = "Two-H Weapon:"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'BtnDrink
            '
            Me.BtnDrink.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnDrink.Location = New System.Drawing.Point(372, 111)
            Me.BtnDrink.Name = "BtnDrink"
            Me.BtnDrink.Size = New System.Drawing.Size(75, 30)
            Me.BtnDrink.TabIndex = 11
            Me.BtnDrink.Text = "&Drink"
            Me.BtnDrink.UseVisualStyleBackColor = True
            '
            'LblPotion
            '
            Me.LblPotion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblPotion.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblPotion.Location = New System.Drawing.Point(138, 111)
            Me.LblPotion.Name = "LblPotion"
            Me.LblPotion.Size = New System.Drawing.Size(228, 30)
            Me.LblPotion.TabIndex = 10
            Me.LblPotion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label7
            '
            Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.Location = New System.Drawing.Point(12, 114)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(120, 25)
            Me.Label7.TabIndex = 9
            Me.Label7.Text = "Potion:"
            Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'BtnBack
            '
            Me.BtnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.BtnBack.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnBack.Location = New System.Drawing.Point(154, 184)
            Me.BtnBack.Margin = New System.Windows.Forms.Padding(4)
            Me.BtnBack.Name = "BtnBack"
            Me.BtnBack.Size = New System.Drawing.Size(150, 30)
            Me.BtnBack.TabIndex = 12
            Me.BtnBack.Text = "&Back"
            Me.BtnBack.UseVisualStyleBackColor = True
            '
            'LblLockpicks
            '
            Me.LblLockpicks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblLockpicks.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblLockpicks.Location = New System.Drawing.Point(138, 145)
            Me.LblLockpicks.Name = "LblLockpicks"
            Me.LblLockpicks.Size = New System.Drawing.Size(50, 30)
            Me.LblLockpicks.TabIndex = 14
            Me.LblLockpicks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label4
            '
            Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(12, 148)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(120, 25)
            Me.Label4.TabIndex = 13
            Me.Label4.Text = "Lockpicks:"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'FrmInventory
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.BtnBack
            Me.ClientSize = New System.Drawing.Size(459, 227)
            Me.Controls.Add(Me.LblLockpicks)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.BtnBack)
            Me.Controls.Add(Me.BtnDrink)
            Me.Controls.Add(Me.LblPotion)
            Me.Controls.Add(Me.Label7)
            Me.Controls.Add(Me.BtnTwoH)
            Me.Controls.Add(Me.LblTwoH)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.BtnHeavy)
            Me.Controls.Add(Me.LblHeavy)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.BtnLight)
            Me.Controls.Add(Me.LblLight)
            Me.Controls.Add(Me.Label1)
            Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Margin = New System.Windows.Forms.Padding(4)
            Me.MaximizeBox = False
            Me.MaximumSize = New System.Drawing.Size(475, 266)
            Me.MinimumSize = New System.Drawing.Size(475, 266)
            Me.Name = "FrmInventory"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Inventory"
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents LblLight As Label
        Friend WithEvents Label1 As Label
        Friend WithEvents BtnLight As Button
        Friend WithEvents BtnHeavy As Button
        Friend WithEvents LblHeavy As Label
        Friend WithEvents Label3 As Label
        Friend WithEvents BtnTwoH As Button
        Friend WithEvents LblTwoH As Label
        Friend WithEvents Label5 As Label
        Friend WithEvents BtnDrink As Button
        Friend WithEvents LblPotion As Label
        Friend WithEvents Label7 As Label
        Friend WithEvents BtnBack As Button
        Friend WithEvents LblLockpicks As Label
        Friend WithEvents Label4 As Label
    End Class
End NameSpace