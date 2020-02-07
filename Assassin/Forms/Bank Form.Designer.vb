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
            Me.LblGoldOnHand = New Label()
            Me.Label2 = New Label()
            Me.LblGoldInBank = New Label()
            Me.LblGoldOnLoan = New Label()
            Me.Label3 = New Label()
            Me.BtnDeposit = New Button()
            Me.BtnWithdraw = New Button()
            Me.BtnGetLoan = New Button()
            Me.BtnPayLoan = New Button()
            Me.BtnBack = New Button()
            Me.LblAvailableLoan = New Label()
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
            'LblGoldOnHand
            '
            Me.LblGoldOnHand.BorderStyle = BorderStyle.FixedSingle
            Me.LblGoldOnHand.Location = New Point(177, 9)
            Me.LblGoldOnHand.Margin = New Padding(4, 0, 4, 0)
            Me.LblGoldOnHand.Name = "LblGoldOnHand"
            Me.LblGoldOnHand.Size = New Size(120, 25)
            Me.LblGoldOnHand.TabIndex = 6
            Me.LblGoldOnHand.TextAlign = ContentAlignment.MiddleCenter
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
            'LblGoldInBank
            '
            Me.LblGoldInBank.BorderStyle = BorderStyle.FixedSingle
            Me.LblGoldInBank.Location = New Point(177, 33)
            Me.LblGoldInBank.Margin = New Padding(4, 0, 4, 0)
            Me.LblGoldInBank.Name = "LblGoldInBank"
            Me.LblGoldInBank.Size = New Size(120, 25)
            Me.LblGoldInBank.TabIndex = 8
            Me.LblGoldInBank.TextAlign = ContentAlignment.MiddleCenter
            '
            'LblGoldOnLoan
            '
            Me.LblGoldOnLoan.BorderStyle = BorderStyle.FixedSingle
            Me.LblGoldOnLoan.Location = New Point(177, 57)
            Me.LblGoldOnLoan.Margin = New Padding(4, 0, 4, 0)
            Me.LblGoldOnLoan.Name = "LblGoldOnLoan"
            Me.LblGoldOnLoan.Size = New Size(120, 25)
            Me.LblGoldOnLoan.TabIndex = 10
            Me.LblGoldOnLoan.TextAlign = ContentAlignment.MiddleCenter
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
            'BtnDeposit
            '
            Me.BtnDeposit.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnDeposit.Location = New Point(12, 273)
            Me.BtnDeposit.Name = "BtnDeposit"
            Me.BtnDeposit.Size = New Size(125, 30)
            Me.BtnDeposit.TabIndex = 0
            Me.BtnDeposit.Text = "&Deposit"
            Me.BtnDeposit.UseVisualStyleBackColor = True
            '
            'BtnWithdraw
            '
            Me.BtnWithdraw.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnWithdraw.Location = New Point(207, 273)
            Me.BtnWithdraw.Name = "BtnWithdraw"
            Me.BtnWithdraw.Size = New Size(125, 30)
            Me.BtnWithdraw.TabIndex = 1
            Me.BtnWithdraw.Text = "&Withdraw"
            Me.BtnWithdraw.UseVisualStyleBackColor = True
            '
            'BtnGetLoan
            '
            Me.BtnGetLoan.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnGetLoan.Location = New Point(12, 309)
            Me.BtnGetLoan.Name = "BtnGetLoan"
            Me.BtnGetLoan.Size = New Size(125, 30)
            Me.BtnGetLoan.TabIndex = 2
            Me.BtnGetLoan.Text = "&Get Loan"
            Me.BtnGetLoan.UseVisualStyleBackColor = True
            '
            'BtnPayLoan
            '
            Me.BtnPayLoan.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnPayLoan.Location = New Point(207, 309)
            Me.BtnPayLoan.Name = "BtnPayLoan"
            Me.BtnPayLoan.Size = New Size(125, 30)
            Me.BtnPayLoan.TabIndex = 3
            Me.BtnPayLoan.Text = "&Pay Loan"
            Me.BtnPayLoan.UseVisualStyleBackColor = True
            '
            'BtnBack
            '
            Me.BtnBack.DialogResult = DialogResult.Cancel
            Me.BtnBack.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnBack.Location = New Point(110, 345)
            Me.BtnBack.Name = "BtnBack"
            Me.BtnBack.Size = New Size(125, 30)
            Me.BtnBack.TabIndex = 4
            Me.BtnBack.Text = "&Back"
            Me.BtnBack.UseVisualStyleBackColor = True
            '
            'LblAvailableLoan
            '
            Me.LblAvailableLoan.BorderStyle = BorderStyle.FixedSingle
            Me.LblAvailableLoan.Location = New Point(177, 81)
            Me.LblAvailableLoan.Margin = New Padding(4, 0, 4, 0)
            Me.LblAvailableLoan.Name = "LblAvailableLoan"
            Me.LblAvailableLoan.Size = New Size(120, 25)
            Me.LblAvailableLoan.TabIndex = 12
            Me.LblAvailableLoan.TextAlign = ContentAlignment.MiddleCenter
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
            Me.CancelButton = Me.BtnBack
            Me.ClientSize = New Size(344, 387)
            Me.Controls.Add(Me.txtBank)
            Me.Controls.Add(Me.LblAvailableLoan)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.BtnBack)
            Me.Controls.Add(Me.BtnPayLoan)
            Me.Controls.Add(Me.BtnGetLoan)
            Me.Controls.Add(Me.BtnWithdraw)
            Me.Controls.Add(Me.BtnDeposit)
            Me.Controls.Add(Me.LblGoldOnLoan)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.LblGoldInBank)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.LblGoldOnHand)
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
        Friend WithEvents LblGoldOnHand As Label
        Friend WithEvents Label2 As Label
        Friend WithEvents LblGoldInBank As Label
        Friend WithEvents LblGoldOnLoan As Label
        Friend WithEvents Label3 As Label
        Friend WithEvents BtnDeposit As Button
        Friend WithEvents BtnWithdraw As Button
        Friend WithEvents BtnGetLoan As Button
        Friend WithEvents BtnPayLoan As Button
        Friend WithEvents BtnBack As Button
        Friend WithEvents LblAvailableLoan As Label
        Friend WithEvents Label4 As Label
        Friend WithEvents TxtBank As TextBox
    End Class
End NameSpace