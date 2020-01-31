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
            Me.LstArmor = New ListBox()
            Me.BtnSell = New Button()
            Me.lblValue = New Label()
            Me.Label4 = New Label()
            Me.lblCurrent = New Label()
            Me.Label3 = New Label()
            Me.BtnPurchase = New Button()
            Me.lblPrice = New Label()
            Me.Label2 = New Label()
            Me.lblGold = New Label()
            Me.Label1 = New Label()
            Me.BtnBack = New Button()
            Me.TxtArmor = New TextBox()
            Me.BtnClear = New Button()
            Me.SuspendLayout()
            '
            'lstArmor
            '
            Me.LstArmor.FormattingEnabled = True
            Me.LstArmor.ItemHeight = 18
            Me.LstArmor.Location = New Point(13, 12)
            Me.LstArmor.Name = "lstArmor"
            Me.LstArmor.Size = New Size(224, 166)
            Me.LstArmor.TabIndex = 0
            '
            'btnSell
            '
            Me.BtnSell.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnSell.Location = New Point(399, 144)
            Me.BtnSell.Name = "btnSell"
            Me.BtnSell.Size = New Size(150, 35)
            Me.BtnSell.TabIndex = 2
            Me.BtnSell.Text = "&Sell"
            Me.BtnSell.UseVisualStyleBackColor = True
            '
            'lblValue
            '
            Me.lblValue.BorderStyle = BorderStyle.FixedSingle
            Me.lblValue.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblValue.Location = New Point(399, 102)
            Me.lblValue.Name = "lblValue"
            Me.lblValue.Size = New Size(150, 25)
            Me.lblValue.TabIndex = 15
            Me.lblValue.TextAlign = ContentAlignment.MiddleCenter
            '
            'Label4
            '
            Me.Label4.BorderStyle = BorderStyle.FixedSingle
            Me.Label4.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New Point(399, 80)
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
            Me.lblCurrent.Location = New Point(399, 35)
            Me.lblCurrent.Name = "lblCurrent"
            Me.lblCurrent.Size = New Size(150, 25)
            Me.lblCurrent.TabIndex = 13
            Me.lblCurrent.TextAlign = ContentAlignment.MiddleCenter
            '
            'Label3
            '
            Me.Label3.BorderStyle = BorderStyle.FixedSingle
            Me.Label3.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New Point(399, 13)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New Size(150, 25)
            Me.Label3.TabIndex = 12
            Me.Label3.Text = "Current Armor:"
            Me.Label3.TextAlign = ContentAlignment.MiddleCenter
            '
            'btnPurchase
            '
            Me.BtnPurchase.Enabled = False
            Me.BtnPurchase.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnPurchase.Location = New Point(243, 144)
            Me.BtnPurchase.Name = "btnPurchase"
            Me.BtnPurchase.Size = New Size(150, 35)
            Me.BtnPurchase.TabIndex = 1
            Me.BtnPurchase.Text = "&Purchase"
            Me.BtnPurchase.UseVisualStyleBackColor = True
            '
            'lblPrice
            '
            Me.lblPrice.BorderStyle = BorderStyle.FixedSingle
            Me.lblPrice.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblPrice.Location = New Point(243, 102)
            Me.lblPrice.Name = "lblPrice"
            Me.lblPrice.Size = New Size(150, 25)
            Me.lblPrice.TabIndex = 11
            Me.lblPrice.TextAlign = ContentAlignment.MiddleCenter
            '
            'Label2
            '
            Me.Label2.BorderStyle = BorderStyle.FixedSingle
            Me.Label2.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New Point(243, 80)
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
            Me.lblGold.Location = New Point(243, 35)
            Me.lblGold.Name = "lblGold"
            Me.lblGold.Size = New Size(150, 25)
            Me.lblGold.TabIndex = 9
            Me.lblGold.TextAlign = ContentAlignment.MiddleCenter
            '
            'Label1
            '
            Me.Label1.BorderStyle = BorderStyle.FixedSingle
            Me.Label1.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New Point(243, 13)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New Size(150, 25)
            Me.Label1.TabIndex = 8
            Me.Label1.Text = "Current Gold:"
            Me.Label1.TextAlign = ContentAlignment.MiddleCenter
            '
            'btnBack
            '
            Me.BtnBack.DialogResult = DialogResult.Cancel
            Me.BtnBack.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnBack.Location = New Point(399, 198)
            Me.BtnBack.Name = "btnBack"
            Me.BtnBack.Size = New Size(150, 35)
            Me.BtnBack.TabIndex = 4
            Me.BtnBack.Text = "&Back"
            Me.BtnBack.UseVisualStyleBackColor = True
            '
            'txtArmor
            '
            Me.TxtArmor.BorderStyle = BorderStyle.FixedSingle
            Me.TxtArmor.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.TxtArmor.Location = New Point(13, 243)
            Me.TxtArmor.Multiline = True
            Me.TxtArmor.Name = "txtArmor"
            Me.TxtArmor.ReadOnly = True
            Me.TxtArmor.ScrollBars = ScrollBars.Vertical
            Me.TxtArmor.Size = New Size(534, 143)
            Me.TxtArmor.TabIndex = 5
            Me.TxtArmor.Text = "You enter The Armoury. The armorer greets you." & ChrW(13) & ChrW(10) & """Welcome to The Armoury! We deal " &
                               "only in the finest of armors."""
            '
            'btnClear
            '
            Me.BtnClear.Enabled = False
            Me.BtnClear.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnClear.Location = New Point(243, 198)
            Me.BtnClear.Name = "btnClear"
            Me.BtnClear.Size = New Size(150, 35)
            Me.BtnClear.TabIndex = 3
            Me.BtnClear.Text = "&Clear"
            Me.BtnClear.UseVisualStyleBackColor = True
            '
            'frmArmor
            '
            Me.AutoScaleDimensions = New SizeF(9.0!, 18.0!)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.CancelButton = Me.BtnBack
            Me.ClientSize = New Size(559, 397)
            Me.Controls.Add(Me.BtnClear)
            Me.Controls.Add(Me.TxtArmor)
            Me.Controls.Add(Me.BtnBack)
            Me.Controls.Add(Me.BtnSell)
            Me.Controls.Add(Me.lblValue)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.lblCurrent)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.BtnPurchase)
            Me.Controls.Add(Me.lblPrice)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.lblGold)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.LstArmor)
            Me.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Margin = New Padding(4)
            Me.MaximizeBox = False
            Me.MaximumSize = New Size(575, 436)
            Me.MinimumSize = New Size(575, 436)
            Me.Name = "frmArmor"
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.Text = "The Armoury"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents LstArmor As ListBox
        Friend WithEvents BtnSell As Button
        Friend WithEvents lblValue As Label
        Friend WithEvents Label4 As Label
        Friend WithEvents lblCurrent As Label
        Friend WithEvents Label3 As Label
        Friend WithEvents BtnPurchase As Button
        Friend WithEvents lblPrice As Label
        Friend WithEvents Label2 As Label
        Friend WithEvents lblGold As Label
        Friend WithEvents Label1 As Label
        Friend WithEvents BtnBack As Button
        Friend WithEvents TxtArmor As TextBox
        Friend WithEvents BtnClear As Button
    End Class
End Namespace