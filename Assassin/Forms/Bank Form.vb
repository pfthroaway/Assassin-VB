Option Strict On
Option Explicit On

Imports Assassin.Classes

Namespace Forms

    Public Class FrmBank

        ''' <summary>Add text to the TextBox.</summary>
        ''' <param name="newText">Text to be added</param>
        Private Sub AddText(newText As String)
            AddTextToTextBox(TxtBank, newText)
        End Sub

        ''' <summary>Displays the current player's bank account.</summary>
        Public Sub Display()
            LblGoldOnHand.Text = CurrentUser.GoldOnHandToString
            LblGoldInBank.Text = CurrentUser.GoldInBankToString
            LblGoldOnLoan.Text = CurrentUser.GoldOnLoanToString
            LblAvailableLoan.Text = CurrentUser.LoanAvailableToString

            BtnDeposit.Enabled = CurrentUser.GoldOnHand > 0
            BtnWithdraw.Enabled = CurrentUser.GoldInBank > 0
            BtnGetLoan.Enabled = CurrentUser.LoanAvailable > 0
            BtnPayLoan.Enabled = CurrentUser.GoldOnLoan > 0
        End Sub

#Region "Click"

        Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
            Close()
        End Sub

        Private Async Sub BtnDeposit_Click(sender As Object, e As EventArgs) Handles BtnDeposit.Click
            Dim deposit As Integer  'amount of gold being deposited
            Integer.TryParse(InputBox($"How much gold would you like to deposit?{ControlChars.NewLine}You can enter a number between 1 and {CurrentUser.GoldOnHand}.", "Deposit"), deposit)

            If deposit > 0 AndAlso deposit <= CurrentUser.GoldOnHand Then      'if in bounds
                CurrentUser.GoldOnHand -= deposit
                CurrentUser.GoldInBank += deposit
                Await SaveUser(CurrentUser)
                AddText($"You deposit {deposit:N0} gold in the bank.")
                Display()
            ElseIf deposit >= CurrentUser.GoldOnHand OrElse deposit < 0 Then   'if out of bounds
                MessageBox.Show($"Please enter a number between 1 and {CurrentUser.GoldOnHandToString}.", "Deposit", MessageBoxButtons.OK)
            End If
        End Sub

        Private Async Sub BtnGetLoan_Click(sender As Object, e As EventArgs) Handles BtnGetLoan.Click
            Dim getLoan As Integer  'amount of gold being received as a loan
            Integer.TryParse(InputBox($"How much gold would you like to take out as a loan? 5% interest will be required in repayment.{ControlChars.NewLine}You can enter a number between 1 and {CurrentUser.LoanAvailable}.", "Get Loan"), getLoan)

            If getLoan > 0 AndAlso getLoan <= CurrentUser.LoanAvailable Then                'if in bounds
                CurrentUser.GoldOnHand += getLoan
                CurrentUser.GoldOnLoan += getLoan + (getLoan \ 20)
                Await SaveUser(CurrentUser)
                AddText($"You receive {getLoan:N0} gold as a loan from the bank.")
                Display()
            ElseIf getLoan >= CurrentUser.GoldInBank OrElse getLoan < 0 Then   'if out of bounds
                MessageBox.Show($"Please enter a number between 1 and {CurrentUser.LoanAvailableToString}.", "Get Loan", MessageBoxButtons.OK)
            End If
        End Sub

        Private Async Sub BtnPayLoan_Click(sender As Object, e As EventArgs) Handles BtnPayLoan.Click
            Dim payLoan As Integer  'amount of gold being paid on your loan
            If CurrentUser.GoldOnHand < CurrentUser.GoldOnLoan Then   'if you don't have enough for a complete payoff
                Integer.TryParse(InputBox($"How much gold would you like to pay back on your loan?{ControlChars.NewLine}You can enter a number between 1 and {CurrentUser.GoldOnHandToString}.", "Pay Loan"), payLoan)
                If payLoan < 0 OrElse payLoan > CurrentUser.GoldOnHand Then    'if out of bounds
                    MessageBox.Show($"Please enter a number between 1 and {CurrentUser.GoldOnHandToString}.", "Pay Loan", MessageBoxButtons.OK)
                    Exit Sub
                End If
            Else                                                'if you do have enough for a complete payoff
                Integer.TryParse(InputBox($"How much gold would you like to pay back on your loan?{ControlChars.NewLine}You can enter a number between 1 and {CurrentUser.GoldOnLoanToString}.", "Pay Loan"), payLoan)
                If payLoan < 0 OrElse payLoan > CurrentUser.GoldOnLoan Then    'if out of bounds
                    MessageBox.Show($"Please enter a number between 1 and {CurrentUser.GoldOnLoanToString}.", "Pay Loan", MessageBoxButtons.OK)
                    Exit Sub
                End If
            End If

            CurrentUser.GoldOnHand -= payLoan
            CurrentUser.GoldOnLoan -= payLoan
            Await SaveUser(CurrentUser)
            AddText($"You pay back {payLoan:N0} gold on your loan from the bank.")
            Display()

            If CurrentUser.GoldOnLoan = 0 Then                     'if you have paid off all of your loan
                FrmGame.AddText("You have successfully paid off all of your loan!")
            End If
        End Sub

        Private Async Sub BtnWithdraw_Click(sender As Object, e As EventArgs) Handles BtnWithdraw.Click
            Dim withdrawal As Integer   'amount of gold being withdrawn
            Integer.TryParse(InputBox($"How much gold would you like to withdraw?{ControlChars.NewLine}You can enter a number between 1 and {CurrentUser.GoldInBank}.", "Withdrawal"), withdrawal)

            If withdrawal > 0 AndAlso withdrawal <= CurrentUser.GoldInBank Then    'if in bounds
                CurrentUser.GoldInBank -= withdrawal
                CurrentUser.GoldOnHand += withdrawal
                Await SaveUser(CurrentUser)
                AddText($"You withdraw {withdrawal:N0} gold from the bank.")
                Display()
            ElseIf withdrawal >= CurrentUser.GoldInBank OrElse withdrawal < 0 Then 'if out of bounds
                MessageBox.Show($"Please enter a number between 1 and {CurrentUser.GoldInBank}.", "Withdrawal", MessageBoxButtons.OK)
            End If
        End Sub

#End Region

        Private Sub FrmBank_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
            AddText("You exit the bank.")
            FrmGame.Show()
            FrmGame.Display()
            FrmGame.AddText(TxtBank.Text)
        End Sub

    End Class

End Namespace