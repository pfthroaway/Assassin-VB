<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBank
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblGoldOnHand = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblGoldInBank = New System.Windows.Forms.Label()
        Me.lblGoldOnLoan = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnDeposit = New System.Windows.Forms.Button()
        Me.btnWithdraw = New System.Windows.Forms.Button()
        Me.btnGetLoan = New System.Windows.Forms.Button()
        Me.btnPayLoan = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblAvailableLoan = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBank = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(58, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Gold on Hand:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblGoldOnHand
        '
        Me.lblGoldOnHand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGoldOnHand.Location = New System.Drawing.Point(177, 9)
        Me.lblGoldOnHand.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGoldOnHand.Name = "lblGoldOnHand"
        Me.lblGoldOnHand.Size = New System.Drawing.Size(120, 25)
        Me.lblGoldOnHand.TabIndex = 6
        Me.lblGoldOnHand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(58, 33)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 25)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Gold in Bank:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblGoldInBank
        '
        Me.lblGoldInBank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGoldInBank.Location = New System.Drawing.Point(177, 33)
        Me.lblGoldInBank.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGoldInBank.Name = "lblGoldInBank"
        Me.lblGoldInBank.Size = New System.Drawing.Size(120, 25)
        Me.lblGoldInBank.TabIndex = 8
        Me.lblGoldInBank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGoldOnLoan
        '
        Me.lblGoldOnLoan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGoldOnLoan.Location = New System.Drawing.Point(177, 57)
        Me.lblGoldOnLoan.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGoldOnLoan.Name = "lblGoldOnLoan"
        Me.lblGoldOnLoan.Size = New System.Drawing.Size(120, 25)
        Me.lblGoldOnLoan.TabIndex = 10
        Me.lblGoldOnLoan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(58, 57)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 25)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Gold on Loan:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnDeposit
        '
        Me.btnDeposit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeposit.Location = New System.Drawing.Point(12, 273)
        Me.btnDeposit.Name = "btnDeposit"
        Me.btnDeposit.Size = New System.Drawing.Size(125, 30)
        Me.btnDeposit.TabIndex = 0
        Me.btnDeposit.Text = "&Deposit"
        Me.btnDeposit.UseVisualStyleBackColor = True
        '
        'btnWithdraw
        '
        Me.btnWithdraw.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWithdraw.Location = New System.Drawing.Point(207, 273)
        Me.btnWithdraw.Name = "btnWithdraw"
        Me.btnWithdraw.Size = New System.Drawing.Size(125, 30)
        Me.btnWithdraw.TabIndex = 1
        Me.btnWithdraw.Text = "&Withdraw"
        Me.btnWithdraw.UseVisualStyleBackColor = True
        '
        'btnGetLoan
        '
        Me.btnGetLoan.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetLoan.Location = New System.Drawing.Point(12, 309)
        Me.btnGetLoan.Name = "btnGetLoan"
        Me.btnGetLoan.Size = New System.Drawing.Size(125, 30)
        Me.btnGetLoan.TabIndex = 2
        Me.btnGetLoan.Text = "&Get Loan"
        Me.btnGetLoan.UseVisualStyleBackColor = True
        '
        'btnPayLoan
        '
        Me.btnPayLoan.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayLoan.Location = New System.Drawing.Point(207, 309)
        Me.btnPayLoan.Name = "btnPayLoan"
        Me.btnPayLoan.Size = New System.Drawing.Size(125, 30)
        Me.btnPayLoan.TabIndex = 3
        Me.btnPayLoan.Text = "&Pay Loan"
        Me.btnPayLoan.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBack.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(110, 345)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(125, 30)
        Me.btnBack.TabIndex = 4
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lblAvailableLoan
        '
        Me.lblAvailableLoan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAvailableLoan.Location = New System.Drawing.Point(177, 81)
        Me.lblAvailableLoan.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAvailableLoan.Name = "lblAvailableLoan"
        Me.lblAvailableLoan.Size = New System.Drawing.Size(120, 25)
        Me.lblAvailableLoan.TabIndex = 12
        Me.lblAvailableLoan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Location = New System.Drawing.Point(58, 81)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 25)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Available Loan:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBank
        '
        Me.txtBank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBank.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBank.Location = New System.Drawing.Point(12, 117)
        Me.txtBank.Multiline = True
        Me.txtBank.Name = "txtBank"
        Me.txtBank.ReadOnly = True
        Me.txtBank.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtBank.Size = New System.Drawing.Size(320, 150)
        Me.txtBank.TabIndex = 13
        Me.txtBank.Text = "You enter the bank. The teller greets you." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & """Welcome to The Bank, the only secure" & _
    " place to store gold in the city!"""
        '
        'frmBank
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnBack
        Me.ClientSize = New System.Drawing.Size(344, 387)
        Me.Controls.Add(Me.txtBank)
        Me.Controls.Add(Me.lblAvailableLoan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnPayLoan)
        Me.Controls.Add(Me.btnGetLoan)
        Me.Controls.Add(Me.btnWithdraw)
        Me.Controls.Add(Me.btnDeposit)
        Me.Controls.Add(Me.lblGoldOnLoan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblGoldInBank)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblGoldOnHand)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(360, 426)
        Me.MinimumSize = New System.Drawing.Size(360, 426)
        Me.Name = "frmBank"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bank"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblGoldOnHand As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblGoldInBank As System.Windows.Forms.Label
    Friend WithEvents lblGoldOnLoan As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnDeposit As System.Windows.Forms.Button
    Friend WithEvents btnWithdraw As System.Windows.Forms.Button
    Friend WithEvents btnGetLoan As System.Windows.Forms.Button
    Friend WithEvents btnPayLoan As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents lblAvailableLoan As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtBank As System.Windows.Forms.TextBox
End Class
