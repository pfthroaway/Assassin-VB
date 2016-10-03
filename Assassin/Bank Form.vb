' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 05/25/2012
' Filename        : Bank Form.vb
' Description     : This form contains the banking system.

Option Strict On
Option Explicit On

Public Class frmBank
    Dim funcs As New Functions              'new Functions instance
    Public currUser As New User             'current user
    Dim nl As String = ControlChars.NewLine 'new line
    Dim availLoan As Integer                'available loan

    Private Sub addText(ByVal newText As String)
        '* * * * *
        '* This method adds formatted text to the TextBox.
        '* * * * *

        Dim currText As String = txtBank.Text
        txtBank.Clear()

        txtBank.Text = newText & nl & nl & currText
        txtBank.Select(0, 0)
        txtBank.ScrollToCaret()
    End Sub

    Public Sub display()
        '* * * * *
        '* This method displays the amount of gold in each category.
        '* * * * *

        availLoan = (currUser.level * 250) - currUser.goldOnLoan    'calculate available loan

        lblGoldOnHand.Text = currUser.goldOnHand.ToString("N0")
        lblGoldInBank.Text = currUser.goldInBank.ToString("N0")
        lblGoldOnLoan.Text = currUser.goldOnLoan.ToString("N0")
        lblAvailableLoan.Text = availLoan.ToString("N0")

        If currUser.goldOnHand = 0 Then
            btnDeposit.Enabled = False
        Else
            btnDeposit.Enabled = True
        End If

        If currUser.goldInBank = 0 Then
            btnWithdraw.Enabled = False
        Else
            btnWithdraw.Enabled = True
        End If

        If availLoan = 0 Then
            btnGetLoan.Enabled = False
        Else
            btnGetLoan.Enabled = True
        End If

        If currUser.goldOnLoan = 0 Then
            btnPayLoan.Enabled = False
        Else
            btnPayLoan.Enabled = True
        End If
    End Sub


    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        '* * * * *
        '* This method closes the form on clicking the Back button.
        '* * * * *

        Me.Close()
    End Sub

    Private Sub btnDeposit_Click(sender As System.Object, e As System.EventArgs) Handles btnDeposit.Click
        '* * * * *
        '* This method deposits gold in the bank.
        '* * * * *

        Dim deposit As Integer  'amount of gold being deposited
        Integer.TryParse(InputBox("How much gold would you like to deposit?" & nl & _
                                  "You can enter a number between 1 and " & currUser.goldOnHand & ".", "Deposit"), deposit)

        If deposit > 0 AndAlso deposit <= currUser.goldOnHand Then      'if in bounds
            currUser.goldOnHand -= deposit
            currUser.goldInBank += deposit
            funcs.save(currUser)
            addText("You deposit " & deposit & " gold in the bank.")
            display()
        ElseIf deposit >= currUser.goldOnHand OrElse deposit < 0 Then   'if out of bounds
            MessageBox.Show("Please enter a number between 1 and " & currUser.goldOnHand & ".", "Deposit", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub btnGetLoan_Click(sender As System.Object, e As System.EventArgs) Handles btnGetLoan.Click
        '* * * * *
        '* This method gets a loan from the bank.
        '* * * * *

        Dim getLoan As Integer  'amount of gold being received as a loan
        Integer.TryParse(InputBox("How much gold would you like to take out as a loan? 5% interest will be required in repayment." & nl & _
                                  "You can enter a number between 1 and " & availLoan & ".", "Get Loan"), getLoan)

        If getLoan > 0 AndAlso getLoan <= availLoan Then                'if in bounds
            currUser.goldOnHand += getLoan
            currUser.goldOnLoan += getLoan + (getLoan \ 20)
            funcs.save(currUser)
            addText("You receive " & getLoan & " gold as a loan from the bank.")
            display()
        ElseIf getLoan >= currUser.goldInBank OrElse getLoan < 0 Then   'if out of bounds
            MessageBox.Show("Please enter a number between 1 and " & availLoan & ".", "Get Loan", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub btnPayLoan_Click(sender As System.Object, e As System.EventArgs) Handles btnPayLoan.Click
        '* * * * *
        '* This method pays back a loan to the bank.
        '* * * * *

        Dim payLoan As Integer  'amount of gold being paid on your loan
        If currUser.goldOnHand < currUser.goldOnLoan Then   'if you don't have enough for a complete payoff
            Integer.TryParse(InputBox("How much gold would you like to pay back on your loan?" & nl & _
                                  "You can enter a number between 1 and " & currUser.goldOnHand & ".", "Pay Loan"), payLoan)
            If payLoan < 0 OrElse payLoan > currUser.goldOnHand Then    'if out of bounds
                MessageBox.Show("Please enter a number between 1 and " & currUser.goldOnHand & ".", "Pay Loan", MessageBoxButtons.OK)
                Exit Sub
            End If
        Else                                                'if you do have enough for a complete payoff
            Integer.TryParse(InputBox("How much gold would you like to pay back on your loan?" & nl & _
                                      "You can enter a number between 1 and " & currUser.goldOnLoan & ".", "Pay Loan"), payLoan)
            If payLoan < 0 OrElse payLoan > currUser.goldOnLoan Then    'if out of bounds
                MessageBox.Show("Please enter a number between 1 and " & currUser.goldOnLoan & ".", "Pay Loan", MessageBoxButtons.OK)
                Exit Sub
            End If
        End If

        currUser.goldOnHand -= payLoan
        currUser.goldOnLoan -= payLoan
        funcs.save(currUser)
        addText("You pay back " & payLoan & " gold on your loan from the bank.")
        display()

        If currUser.goldOnLoan = 0 Then                     'if you have paid off all of your loan
            frmGame.addText("You have successfully paid off all of your loan!")
        End If
    End Sub

    Private Sub btnWithdraw_Click(sender As System.Object, e As System.EventArgs) Handles btnWithdraw.Click
        '* * * * *
        '* This method withdraws gold from the bank.
        '* * * * *

        Dim withdrawal As Integer   'amount of gold being withdrawn
        Integer.TryParse(InputBox("How much gold would you like to withdraw?" & nl & _
                                  "You can enter a number between 1 and " & currUser.goldInBank & ".", "Withdrawal"), withdrawal)

        If withdrawal > 0 AndAlso withdrawal <= currUser.goldInBank Then    'if in bounds
            currUser.goldInBank -= withdrawal
            currUser.goldOnHand += withdrawal
            funcs.save(currUser)
            addText("You withdraw " & withdrawal & " gold from the bank.")
            display()
        ElseIf withdrawal >= currUser.goldInBank OrElse withdrawal < 0 Then 'if out of bounds
            MessageBox.Show("Please enter a number between 1 and " & currUser.goldInBank & ".", "Withdrawal", MessageBoxButtons.OK)
        End If
    End Sub


    Private Sub frmBank_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        '* * * * *
        '* This method updates the Game form on this form closing.
        '* * * * *

        addText("You exit the bank.")
        frmGame.Show()
        frmGame.display()
        frmGame.addText(txtBank.Text)
    End Sub
End Class