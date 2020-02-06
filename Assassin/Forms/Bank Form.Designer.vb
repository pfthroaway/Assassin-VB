Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

Namespace Forms
    <DesignerGenerated()> _
    Partial Class FrmBank
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
            Me.Label1 = New Label()
            Me.lblGoldOnHand = New Label()
            Me.Label2 = New Label()
            Me.lblGoldInBank = New Label()
            Me.lblGoldOnLoan = New Label()
            Me.Label3 = New Label()
            Me.btnDeposit = New Button()
            Me.btnWithdraw = New Button()
            Me.btnGetLoan = New Button()
            Me.btnPayLoan = New Button()
            Me.btnBack = New Button()
            Me.lblAvailableLoan = New Label()
            Me.Label4 = New Label()
            Me.txtBank = New TextBox()
            Me.SuspendLayout()
            '
            'Label1
            '
            Me.Label1.BorderStyle = BorderStyle.FixedSingle
            Me.Label1.Location = New Point(58, 9)
            Me.Label1.Margin = New Padding(4, 0, 4, 0)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New Size(120, 25)
            Me.Label1.TabIndex = 5
            Me.Label1.Text = "Gold on Hand:"
            Me.Label1.TextAlign = ContentAlignment.MiddleRight
            '
            'lblGoldOnHand
            '
            Me.lblGoldOnHand.BorderStyle = BorderStyle.FixedSingle
            Me.lblGoldOnHand.Location = New Point(177, 9)
            Me.lblGoldOnHand.Margin = New Padding(4, 0, 4, 0)
            Me.lblGoldOnHand.Name = "lblGoldOnHand"
            Me.lblGoldOnHand.Size = New Size(120, 25)
            Me.lblGoldOnHand.TabIndex = 6
            Me.lblGoldOnHand.TextAlign = ContentAlignment.MiddleCenter
            '
            'Label2
            '
            Me.Label2.BorderStyle = BorderStyle.FixedSingle
            Me.Label2.Location = New Point(58, 33)
            Me.Label2.Margin = New Padding(4, 0, 4, 0)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New Size(120, 25)
            Me.Label2.TabIndex = 7
            Me.Label2.Text = "Gold in Bank:"
            Me.Label2.TextAlign = ContentAlignment.MiddleRight
            '
            'lblGoldInBank
            '
            Me.lblGoldInBank.BorderStyle = BorderStyle.FixedSingle
            Me.lblGoldInBank.Location = New Point(177, 33)
            Me.lblGoldInBank.Margin = New Padding(4, 0, 4, 0)
            Me.lblGoldInBank.Name = "lblGoldInBank"
            Me.lblGoldInBank.Size = New Size(120, 25)
            Me.lblGoldInBank.TabIndex = 8
            Me.lblGoldInBank.TextAlign = ContentAlignment.MiddleCenter
            '
            'lblGoldOnLoan
            '
            Me.lblGoldOnLoan.BorderStyle = BorderStyle.FixedSingle
            Me.lblGoldOnLoan.Location = New Point(177, 57)
            Me.lblGoldOnLoan.Margin = New Padding(4, 0, 4, 0)
            Me.lblGoldOnLoan.Name = "lblGoldOnLoan"
            Me.lblGoldOnLoan.Size = New Size(120, 25)
            Me.lblGoldOnLoan.TabIndex = 10
            Me.lblGoldOnLoan.TextAlign = ContentAlignment.MiddleCenter
            '
            'Label3
            '
            Me.Label3.BorderStyle = BorderStyle.FixedSingle
            Me.Label3.Location = New Point(58, 57)
            Me.Label3.Margin = New Padding(4, 0, 4, 0)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New Size(120, 25)
            Me.Label3.TabIndex = 9
            Me.Label3.Text = "Gold on Loan:"
            Me.Label3.TextAlign = ContentAlignment.MiddleRight
            '
            'btnDeposit
            '
            Me.btnDeposit.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnDeposit.Location = New Point(12, 273)
            Me.btnDeposit.Name = "btnDeposit"
            Me.btnDeposit.Size = New Size(125, 30)
            Me.btnDeposit.TabIndex = 0
            Me.btnDeposit.Text = "&Deposit"
            Me.btnDeposit.UseVisualStyleBackColor = True
            '
            'btnWithdraw
            '
            Me.btnWithdraw.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnWithdraw.Location = New Point(207, 273)
            Me.btnWithdraw.Name = "btnWithdraw"
            Me.btnWithdraw.Size = New Size(125, 30)
            Me.btnWithdraw.TabIndex = 1
            Me.btnWithdraw.Text = "&Withdraw"
            Me.btnWithdraw.UseVisualStyleBackColor = True
            '
            'btnGetLoan
            '
            Me.btnGetLoan.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnGetLoan.Location = New Point(12, 309)
            Me.btnGetLoan.Name = "btnGetLoan"
            Me.btnGetLoan.Size = New Size(125, 30)
            Me.btnGetLoan.TabIndex = 2
            Me.btnGetLoan.Text = "&Get Loan"
            Me.btnGetLoan.UseVisualStyleBackColor = True
            '
            'btnPayLoan
            '
            Me.btnPayLoan.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnPayLoan.Location = New Point(207, 309)
            Me.btnPayLoan.Name = "btnPayLoan"
            Me.btnPayLoan.Size = New Size(125, 30)
            Me.btnPayLoan.TabIndex = 3
            Me.btnPayLoan.Text = "&Pay Loan"
            Me.btnPayLoan.UseVisualStyleBackColor = True
            '
            'btnBack
            '
            Me.btnBack.DialogResult = DialogResult.Cancel
            Me.btnBack.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnBack.Location = New Point(110, 345)
            Me.btnBack.Name = "btnBack"
            Me.btnBack.Size = New Size(125, 30)
            Me.btnBack.TabIndex = 4
            Me.btnBack.Text = "&Back"
            Me.btnBack.UseVisualStyleBackColor = True
            '
            'lblAvailableLoan
            '
            Me.lblAvailableLoan.BorderStyle = BorderStyle.FixedSingle
            Me.lblAvailableLoan.Location = New Point(177, 81)
            Me.lblAvailableLoan.Margin = New Padding(4, 0, 4, 0)
            Me.lblAvailableLoan.Name = "lblAvailableLoan"
            Me.lblAvailableLoan.Size = New Size(120, 25)
            Me.lblAvailableLoan.TabIndex = 12
            Me.lblAvailableLoan.TextAlign = ContentAlignment.MiddleCenter
            '
            'Label4
            '
            Me.Label4.BorderStyle = BorderStyle.FixedSingle
            Me.Label4.Location = New Point(58, 81)
            Me.Label4.Margin = New Padding(4, 0, 4, 0)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New Size(120, 25)
            Me.Label4.TabIndex = 11
            Me.Label4.Text = "Available Loan:"
            Me.Label4.TextAlign = ContentAlignment.MiddleRight
            '
            'txtBank
            '
            Me.txtBank.BorderStyle = BorderStyle.FixedSingle
            Me.txtBank.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.txtBank.Location = New Point(12, 117)
            Me.txtBank.Multiline = True
            Me.txtBank.Name = "txtBank"
            Me.txtBank.ReadOnly = True
            Me.txtBank.ScrollBars = ScrollBars.Vertical
            Me.txtBank.Size = New Size(320, 150)
            Me.txtBank.TabIndex = 13
            Me.TxtBank.Text = "You enter the bank. The teller greets you." & ChrW(13) & ChrW(10) & """Welcome to The Bank, the only secure" &
                              " place to store gold in the city!"""
            '
            'frmBank
            '
            Me.AutoScaleDimensions = New SizeF(9.0!, 18.0!)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.CancelButton = Me.btnBack
            Me.ClientSize = New Size(344, 387)
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
            Me.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Margin = New Padding(4)
            Me.MaximizeBox = False
            Me.MaximumSize = New Size(360, 426)
            Me.MinimumSize = New Size(360, 426)
            Me.Name = "frmBank"
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.Text = "Bank"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents Label1 As Label
        Friend WithEvents lblGoldOnHand As Label
        Friend WithEvents Label2 As Label
        Friend WithEvents lblGoldInBank As Label
        Friend WithEvents lblGoldOnLoan As Label
        Friend WithEvents Label3 As Label
        Friend WithEvents BtnDeposit As Button
        Friend WithEvents BtnWithdraw As Button
        Friend WithEvents BtnGetLoan As Button
        Friend WithEvents BtnPayLoan As Button
        Friend WithEvents BtnBack As Button
        Friend WithEvents lblAvailableLoan As Label
        Friend WithEvents Label4 As Label
        Friend WithEvents TxtBank As TextBox
    End Class
End NameSpace