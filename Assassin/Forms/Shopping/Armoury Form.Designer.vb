Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

Namespace Forms.Shopping
    <DesignerGenerated()>
    Partial Class FrmArmor
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
            Me.LstArmor = New System.Windows.Forms.ListBox()
            Me.LblValue = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.LblCurrentDefense = New System.Windows.Forms.Label()
            Me.LblCurrent = New System.Windows.Forms.Label()
            Me.LblPrice = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.LblGold = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.TxtArmor = New System.Windows.Forms.TextBox()
            Me.BtnClear = New System.Windows.Forms.Button()
            Me.BtnBack = New System.Windows.Forms.Button()
            Me.BtnSell = New System.Windows.Forms.Button()
            Me.BtnPurchase = New System.Windows.Forms.Button()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.LblSelectedDefense = New System.Windows.Forms.Label()
            Me.LblSelected = New System.Windows.Forms.Label()
            Me.SuspendLayout()
            '
            'LstArmor
            '
            Me.LstArmor.FormattingEnabled = True
            Me.LstArmor.ItemHeight = 18
            Me.LstArmor.Location = New System.Drawing.Point(13, 12)
            Me.LstArmor.Name = "LstArmor"
            Me.LstArmor.Size = New System.Drawing.Size(224, 166)
            Me.LstArmor.TabIndex = 0
            '
            'LblValue
            '
            Me.LblValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblValue.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblValue.Location = New System.Drawing.Point(392, 70)
            Me.LblValue.Name = "LblValue"
            Me.LblValue.Size = New System.Drawing.Size(150, 25)
            Me.LblValue.TabIndex = 15
            Me.LblValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label4
            '
            Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(243, 70)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(150, 25)
            Me.Label4.TabIndex = 14
            Me.Label4.Text = "Value:"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'LblCurrentDefense
            '
            Me.LblCurrentDefense.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblCurrentDefense.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblCurrentDefense.Location = New System.Drawing.Point(392, 94)
            Me.LblCurrentDefense.Name = "LblCurrentDefense"
            Me.LblCurrentDefense.Size = New System.Drawing.Size(150, 25)
            Me.LblCurrentDefense.TabIndex = 13
            Me.LblCurrentDefense.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'LblCurrent
            '
            Me.LblCurrent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblCurrent.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblCurrent.Location = New System.Drawing.Point(243, 46)
            Me.LblCurrent.Name = "LblCurrent"
            Me.LblCurrent.Size = New System.Drawing.Size(299, 25)
            Me.LblCurrent.TabIndex = 12
            Me.LblCurrent.Text = "Current Armor:"
            Me.LblCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'LblPrice
            '
            Me.LblPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblPrice.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblPrice.Location = New System.Drawing.Point(392, 151)
            Me.LblPrice.Name = "LblPrice"
            Me.LblPrice.Size = New System.Drawing.Size(150, 25)
            Me.LblPrice.TabIndex = 11
            Me.LblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label2
            '
            Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(243, 151)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(150, 25)
            Me.Label2.TabIndex = 10
            Me.Label2.Text = "Price:"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'LblGold
            '
            Me.LblGold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblGold.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblGold.Location = New System.Drawing.Point(392, 13)
            Me.LblGold.Name = "LblGold"
            Me.LblGold.Size = New System.Drawing.Size(150, 25)
            Me.LblGold.TabIndex = 9
            Me.LblGold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label1
            '
            Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(243, 13)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(150, 25)
            Me.Label1.TabIndex = 8
            Me.Label1.Text = "Gold On Hand:"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'TxtArmor
            '
            Me.TxtArmor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.TxtArmor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TxtArmor.Location = New System.Drawing.Point(243, 207)
            Me.TxtArmor.Multiline = True
            Me.TxtArmor.Name = "TxtArmor"
            Me.TxtArmor.ReadOnly = True
            Me.TxtArmor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.TxtArmor.Size = New System.Drawing.Size(304, 143)
            Me.TxtArmor.TabIndex = 5
            Me.TxtArmor.Text = "You enter The Armoury. The armorer greets you." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & """Welcome to The Armoury! We deal " &
    "only in the finest of armors."""
            '
            'BtnClear
            '
            Me.BtnClear.Enabled = False
            Me.BtnClear.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnClear.Location = New System.Drawing.Point(47, 274)
            Me.BtnClear.Name = "BtnClear"
            Me.BtnClear.Size = New System.Drawing.Size(150, 35)
            Me.BtnClear.TabIndex = 3
            Me.BtnClear.Text = "&Clear"
            Me.BtnClear.UseVisualStyleBackColor = True
            '
            'BtnBack
            '
            Me.BtnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.BtnBack.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnBack.Location = New System.Drawing.Point(47, 315)
            Me.BtnBack.Name = "BtnBack"
            Me.BtnBack.Size = New System.Drawing.Size(150, 35)
            Me.BtnBack.TabIndex = 4
            Me.BtnBack.Text = "&Back"
            Me.BtnBack.UseVisualStyleBackColor = True
            '
            'BtnSell
            '
            Me.BtnSell.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnSell.Location = New System.Drawing.Point(47, 233)
            Me.BtnSell.Name = "BtnSell"
            Me.BtnSell.Size = New System.Drawing.Size(150, 35)
            Me.BtnSell.TabIndex = 2
            Me.BtnSell.Text = "&Sell"
            Me.BtnSell.UseVisualStyleBackColor = True
            '
            'BtnPurchase
            '
            Me.BtnPurchase.Enabled = False
            Me.BtnPurchase.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnPurchase.Location = New System.Drawing.Point(47, 192)
            Me.BtnPurchase.Name = "BtnPurchase"
            Me.BtnPurchase.Size = New System.Drawing.Size(150, 35)
            Me.BtnPurchase.TabIndex = 1
            Me.BtnPurchase.Text = "&Purchase"
            Me.BtnPurchase.UseVisualStyleBackColor = True
            '
            'Label5
            '
            Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.Location = New System.Drawing.Point(243, 94)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(150, 25)
            Me.Label5.TabIndex = 16
            Me.Label5.Text = "Defense:"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label6
            '
            Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.Location = New System.Drawing.Point(243, 175)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(150, 25)
            Me.Label6.TabIndex = 19
            Me.Label6.Text = "Defense:"
            Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'LblSelectedDefense
            '
            Me.LblSelectedDefense.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblSelectedDefense.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblSelectedDefense.Location = New System.Drawing.Point(392, 175)
            Me.LblSelectedDefense.Name = "LblSelectedDefense"
            Me.LblSelectedDefense.Size = New System.Drawing.Size(150, 25)
            Me.LblSelectedDefense.TabIndex = 18
            Me.LblSelectedDefense.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'LblSelected
            '
            Me.LblSelected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblSelected.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblSelected.Location = New System.Drawing.Point(243, 127)
            Me.LblSelected.Name = "LblSelected"
            Me.LblSelected.Size = New System.Drawing.Size(299, 25)
            Me.LblSelected.TabIndex = 17
            Me.LblSelected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'FrmArmor
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.BtnBack
            Me.ClientSize = New System.Drawing.Size(559, 362)
            Me.Controls.Add(Me.Label6)
            Me.Controls.Add(Me.LblSelectedDefense)
            Me.Controls.Add(Me.LblSelected)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.BtnClear)
            Me.Controls.Add(Me.TxtArmor)
            Me.Controls.Add(Me.BtnBack)
            Me.Controls.Add(Me.BtnSell)
            Me.Controls.Add(Me.LblValue)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.LblCurrentDefense)
            Me.Controls.Add(Me.LblCurrent)
            Me.Controls.Add(Me.BtnPurchase)
            Me.Controls.Add(Me.LblPrice)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.LblGold)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.LstArmor)
            Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Margin = New System.Windows.Forms.Padding(4)
            Me.MaximizeBox = False
            Me.MaximumSize = New System.Drawing.Size(575, 401)
            Me.MinimumSize = New System.Drawing.Size(575, 401)
            Me.Name = "FrmArmor"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "The Armoury"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents LstArmor As ListBox
        Friend WithEvents LblValue As Label
        Friend WithEvents Label4 As Label
        Friend WithEvents LblCurrentDefense As Label
        Friend WithEvents LblCurrent As Label
        Friend WithEvents LblPrice As Label
        Friend WithEvents Label2 As Label
        Friend WithEvents LblGold As Label
        Friend WithEvents Label1 As Label
        Friend WithEvents TxtArmor As TextBox
        Friend WithEvents BtnClear As Button
        Friend WithEvents BtnBack As Button
        Friend WithEvents BtnSell As Button
        Friend WithEvents BtnPurchase As Button
        Friend WithEvents Label5 As Label
        Friend WithEvents Label6 As Label
        Friend WithEvents LblSelectedDefense As Label
        Friend WithEvents LblSelected As Label
    End Class
End Namespace