Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

Namespace Forms.Shopping
    <DesignerGenerated()>
    Partial Class FrmBar
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
            Me.grpPurchases = New GroupBox()
            Me.CmbFood = New RadioButton()
            Me.CmbDrinks = New RadioButton()
            Me.LstPurchases = New ListBox()
            Me.LblThirst = New Label()
            Me.Label4 = New Label()
            Me.BtnPurchase = New Button()
            Me.LblPrice = New Label()
            Me.Label2 = New Label()
            Me.LblGold = New Label()
            Me.Label1 = New Label()
            Me.BtnBack = New Button()
            Me.TxtBar = New TextBox()
            Me.BtnClear = New Button()
            Me.LblHunger = New Label()
            Me.Label3 = New Label()
            Me.grpPurchases.SuspendLayout()
            Me.SuspendLayout()
            '
            'grpPurchases
            '
            Me.grpPurchases.Controls.Add(Me.CmbFood)
            Me.grpPurchases.Controls.Add(Me.CmbDrinks)
            Me.grpPurchases.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.grpPurchases.Location = New Point(13, 13)
            Me.grpPurchases.Name = "grpPurchases"
            Me.grpPurchases.Size = New Size(224, 47)
            Me.grpPurchases.TabIndex = 0
            Me.grpPurchases.TabStop = False
            Me.grpPurchases.Text = "Purchases"
            '
            'CmbFood
            '
            Me.CmbFood.AutoSize = True
            Me.CmbFood.Location = New Point(84, 21)
            Me.CmbFood.Name = "CmbFood"
            Me.CmbFood.Size = New Size(63, 22)
            Me.CmbFood.TabIndex = 2
            Me.CmbFood.TabStop = True
            Me.CmbFood.Text = "&Food"
            Me.CmbFood.UseVisualStyleBackColor = True
            '
            'CmbDrinks
            '
            Me.CmbDrinks.AutoSize = True
            Me.CmbDrinks.Location = New Point(7, 21)
            Me.CmbDrinks.Name = "CmbDrinks"
            Me.CmbDrinks.Size = New Size(71, 22)
            Me.CmbDrinks.TabIndex = 1
            Me.CmbDrinks.TabStop = True
            Me.CmbDrinks.Text = "&Drinks"
            Me.CmbDrinks.UseVisualStyleBackColor = True
            '
            'LstPurchases
            '
            Me.LstPurchases.FormattingEnabled = True
            Me.LstPurchases.ItemHeight = 18
            Me.LstPurchases.Location = New Point(13, 67)
            Me.LstPurchases.Name = "LstPurchases"
            Me.LstPurchases.Size = New Size(224, 166)
            Me.LstPurchases.TabIndex = 4
            '
            'LblThirst
            '
            Me.LblThirst.BorderStyle = BorderStyle.FixedSingle
            Me.LblThirst.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.LblThirst.Location = New Point(399, 102)
            Me.LblThirst.Name = "LblThirst"
            Me.LblThirst.Size = New Size(150, 25)
            Me.LblThirst.TabIndex = 15
            Me.LblThirst.TextAlign = ContentAlignment.MiddleCenter
            '
            'Label4
            '
            Me.Label4.BorderStyle = BorderStyle.FixedSingle
            Me.Label4.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New Point(399, 80)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New Size(150, 25)
            Me.Label4.TabIndex = 14
            Me.Label4.Text = "Thirst:"
            Me.Label4.TextAlign = ContentAlignment.MiddleCenter
            '
            'BtnPurchase
            '
            Me.BtnPurchase.Enabled = False
            Me.BtnPurchase.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnPurchase.Location = New Point(243, 144)
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
            Me.LblPrice.Location = New Point(243, 102)
            Me.LblPrice.Name = "LblPrice"
            Me.LblPrice.Size = New Size(150, 25)
            Me.LblPrice.TabIndex = 11
            Me.LblPrice.TextAlign = ContentAlignment.MiddleCenter
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
            'LblGold
            '
            Me.LblGold.BorderStyle = BorderStyle.FixedSingle
            Me.LblGold.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.LblGold.Location = New Point(243, 35)
            Me.LblGold.Name = "LblGold"
            Me.LblGold.Size = New Size(150, 25)
            Me.LblGold.TabIndex = 9
            Me.LblGold.TextAlign = ContentAlignment.MiddleCenter
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
            'BtnBack
            '
            Me.BtnBack.DialogResult = DialogResult.Cancel
            Me.BtnBack.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnBack.Location = New Point(399, 198)
            Me.BtnBack.Name = "BtnBack"
            Me.BtnBack.Size = New Size(150, 35)
            Me.BtnBack.TabIndex = 8
            Me.BtnBack.Text = "&Back"
            Me.BtnBack.UseVisualStyleBackColor = True
            '
            'txtBar
            '
            Me.TxtBar.BorderStyle = BorderStyle.FixedSingle
            Me.TxtBar.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.TxtBar.Location = New Point(13, 243)
            Me.TxtBar.Multiline = True
            Me.TxtBar.Name = "txtBar"
            Me.TxtBar.ReadOnly = True
            Me.TxtBar.ScrollBars = ScrollBars.Vertical
            Me.TxtBar.Size = New Size(534, 143)
            Me.TxtBar.TabIndex = 9
            Me.TxtBar.Text = "You approach the bar."
            '
            'BtnClear
            '
            Me.BtnClear.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnClear.Location = New Point(243, 198)
            Me.BtnClear.Name = "BtnClear"
            Me.BtnClear.Size = New Size(150, 35)
            Me.BtnClear.TabIndex = 7
            Me.BtnClear.Text = "&Clear"
            Me.BtnClear.UseVisualStyleBackColor = True
            '
            'LblHunger
            '
            Me.LblHunger.BorderStyle = BorderStyle.FixedSingle
            Me.LblHunger.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.LblHunger.Location = New Point(399, 35)
            Me.LblHunger.Name = "LblHunger"
            Me.LblHunger.Size = New Size(150, 25)
            Me.LblHunger.TabIndex = 13
            Me.LblHunger.TextAlign = ContentAlignment.MiddleCenter
            '
            'Label3
            '
            Me.Label3.BorderStyle = BorderStyle.FixedSingle
            Me.Label3.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New Point(399, 13)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New Size(150, 25)
            Me.Label3.TabIndex = 12
            Me.Label3.Text = "Hunger:"
            Me.Label3.TextAlign = ContentAlignment.MiddleCenter
            '
            'frmBar
            '
            Me.AutoScaleDimensions = New SizeF(9.0!, 18.0!)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.CancelButton = Me.BtnBack
            Me.ClientSize = New Size(559, 398)
            Me.Controls.Add(Me.BtnClear)
            Me.Controls.Add(Me.TxtBar)
            Me.Controls.Add(Me.BtnBack)
            Me.Controls.Add(Me.LblThirst)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.LblHunger)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.BtnPurchase)
            Me.Controls.Add(Me.LblPrice)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.LblGold)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.LstPurchases)
            Me.Controls.Add(Me.grpPurchases)
            Me.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Margin = New Padding(4)
            Me.MaximizeBox = False
            Me.MaximumSize = New Size(575, 436)
            Me.MinimumSize = New Size(575, 436)
            Me.Name = "frmBar"
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.Text = "Bar"
            Me.grpPurchases.ResumeLayout(False)
            Me.grpPurchases.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents grpPurchases As GroupBox
        Friend WithEvents CmbFood As RadioButton
        Friend WithEvents CmbDrinks As RadioButton
        Friend WithEvents LstPurchases As ListBox
        Friend WithEvents LblThirst As Label
        Friend WithEvents Label4 As Label
        Friend WithEvents BtnPurchase As Button
        Friend WithEvents LblPrice As Label
        Friend WithEvents Label2 As Label
        Friend WithEvents LblGold As Label
        Friend WithEvents Label1 As Label
        Friend WithEvents BtnBack As Button
        Friend WithEvents TxtBar As TextBox
        Friend WithEvents BtnClear As Button
        Friend WithEvents LblHunger As Label
        Friend WithEvents Label3 As Label
    End Class
End Namespace