<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBar
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
        Me.grpPurchases = New System.Windows.Forms.GroupBox()
        Me.cmbFood = New System.Windows.Forms.RadioButton()
        Me.cmbDrinks = New System.Windows.Forms.RadioButton()
        Me.lstPurchases = New System.Windows.Forms.ListBox()
        Me.lblThirst = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnPurchase = New System.Windows.Forms.Button()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblGold = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.txtBar = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblHunger = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grpPurchases.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpPurchases
        '
        Me.grpPurchases.Controls.Add(Me.cmbFood)
        Me.grpPurchases.Controls.Add(Me.cmbDrinks)
        Me.grpPurchases.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPurchases.Location = New System.Drawing.Point(13, 13)
        Me.grpPurchases.Name = "grpPurchases"
        Me.grpPurchases.Size = New System.Drawing.Size(224, 47)
        Me.grpPurchases.TabIndex = 0
        Me.grpPurchases.TabStop = False
        Me.grpPurchases.Text = "Purchases"
        '
        'cmbFood
        '
        Me.cmbFood.AutoSize = True
        Me.cmbFood.Location = New System.Drawing.Point(84, 21)
        Me.cmbFood.Name = "cmbFood"
        Me.cmbFood.Size = New System.Drawing.Size(63, 22)
        Me.cmbFood.TabIndex = 2
        Me.cmbFood.TabStop = True
        Me.cmbFood.Text = "&Food"
        Me.cmbFood.UseVisualStyleBackColor = True
        '
        'cmbDrinks
        '
        Me.cmbDrinks.AutoSize = True
        Me.cmbDrinks.Location = New System.Drawing.Point(7, 21)
        Me.cmbDrinks.Name = "cmbDrinks"
        Me.cmbDrinks.Size = New System.Drawing.Size(71, 22)
        Me.cmbDrinks.TabIndex = 1
        Me.cmbDrinks.TabStop = True
        Me.cmbDrinks.Text = "&Drinks"
        Me.cmbDrinks.UseVisualStyleBackColor = True
        '
        'lstPurchases
        '
        Me.lstPurchases.FormattingEnabled = True
        Me.lstPurchases.ItemHeight = 18
        Me.lstPurchases.Location = New System.Drawing.Point(13, 67)
        Me.lstPurchases.Name = "lstPurchases"
        Me.lstPurchases.Size = New System.Drawing.Size(224, 166)
        Me.lstPurchases.TabIndex = 4
        '
        'lblThirst
        '
        Me.lblThirst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblThirst.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThirst.Location = New System.Drawing.Point(399, 102)
        Me.lblThirst.Name = "lblThirst"
        Me.lblThirst.Size = New System.Drawing.Size(150, 25)
        Me.lblThirst.TabIndex = 15
        Me.lblThirst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(399, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 25)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Thirst:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPurchase
        '
        Me.btnPurchase.Enabled = False
        Me.btnPurchase.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPurchase.Location = New System.Drawing.Point(243, 144)
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
        Me.lblPrice.Location = New System.Drawing.Point(243, 102)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(150, 25)
        Me.lblPrice.TabIndex = 11
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(243, 80)
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
        Me.lblGold.Location = New System.Drawing.Point(243, 35)
        Me.lblGold.Name = "lblGold"
        Me.lblGold.Size = New System.Drawing.Size(150, 25)
        Me.lblGold.TabIndex = 9
        Me.lblGold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(243, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Current Gold:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBack
        '
        Me.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBack.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(399, 198)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(150, 35)
        Me.btnBack.TabIndex = 8
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'txtBar
        '
        Me.txtBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBar.Location = New System.Drawing.Point(13, 243)
        Me.txtBar.Multiline = True
        Me.txtBar.Name = "txtBar"
        Me.txtBar.ReadOnly = True
        Me.txtBar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtBar.Size = New System.Drawing.Size(534, 143)
        Me.txtBar.TabIndex = 9
        Me.txtBar.Text = "You approach the bar."
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(243, 198)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(150, 35)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblHunger
        '
        Me.lblHunger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHunger.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHunger.Location = New System.Drawing.Point(399, 35)
        Me.lblHunger.Name = "lblHunger"
        Me.lblHunger.Size = New System.Drawing.Size(150, 25)
        Me.lblHunger.TabIndex = 13
        Me.lblHunger.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(399, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 25)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Hunger:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmBar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnBack
        Me.ClientSize = New System.Drawing.Size(559, 398)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtBar)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblThirst)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblHunger)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnPurchase)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblGold)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstPurchases)
        Me.Controls.Add(Me.grpPurchases)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(575, 436)
        Me.MinimumSize = New System.Drawing.Size(575, 436)
        Me.Name = "frmBar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bar"
        Me.grpPurchases.ResumeLayout(False)
        Me.grpPurchases.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpPurchases As System.Windows.Forms.GroupBox
    Friend WithEvents cmbFood As System.Windows.Forms.RadioButton
    Friend WithEvents cmbDrinks As System.Windows.Forms.RadioButton
    Friend WithEvents lstPurchases As System.Windows.Forms.ListBox
    Friend WithEvents lblThirst As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnPurchase As System.Windows.Forms.Button
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblGold As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents txtBar As System.Windows.Forms.TextBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblHunger As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
