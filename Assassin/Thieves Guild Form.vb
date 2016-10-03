' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 05/25/2012
' Filename        : Thieves Guild Form.vb
' Description     : This form contains the Thieves' Guild.

Option Strict On
Option Explicit On

Public Class frmThievesGuild
    Dim funcs As New Functions
    Public currUser As New User
    Dim nl As String = ControlChars.NewLine 'new line

    Private Sub addText(ByVal newText As String)
        '* * * * *
        '* This method adds formatted text to the TextBox.
        '* * * * *

        Dim currText As String = txtThievesGuild.Text
        txtThievesGuild.Clear()

        txtThievesGuild.Text = newText & nl & nl & currText
        txtThievesGuild.Select(0, 0)
        txtThievesGuild.ScrollToCaret()
    End Sub

    Public Sub display()
        '* * * * *
        '* This method displays the player's current gold and number of lockpicks.
        '* * * * *

        txtThievesGuild.Select(0, 0)
        txtThievesGuild.ScrollToCaret()

        lblGold.Text = currUser.goldOnHand.ToString("N0")
        lblLockpicks.Text = currUser.lockpicks.ToString("N0")

        If currUser.goldOnHand >= 300 AndAlso currUser.lockpicks < 99 Then
            btnPurchase.Enabled = True
        Else
            btnPurchase.Enabled = False
        End If
    End Sub

    Public Sub purchase()
        '* * * * *
        '* This method purchases lockpicks.
        '* * * * *

        Dim lockpicks As Integer
        Dim maxLockpicks As Integer

        If currUser.lockpicks + maxLockpicks > 99 Then
            maxLockpicks = 99 - currUser.lockpicks
        Else
            maxLockpicks = currUser.goldOnHand \ 300
        End If

        Integer.TryParse(InputBox("How many lockpicks would you like to purchase?" & nl & _
                                  "You can enter a number between 1 and " & maxLockpicks & "."), lockpicks)

        If lockpicks > 0 AndAlso lockpicks <= maxLockpicks Then
            currUser.lockpicks += lockpicks
            currUser.goldOnHand -= (lockpicks * 300)
            addText("You purchase " & lockpicks & " for " & (lockpicks * 300) & " gold.")
            funcs.save(currUser)

            display()
        Else
            MessageBox.Show("Please enter a number between 1 and " & maxLockpicks & ".", "Assassin", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        '* * * * *
        '* This method closes the form on clicking the Back button.
        '* * * * *

        Me.Close()
    End Sub

    Private Sub btnPurchase_Click(sender As System.Object, e As System.EventArgs) Handles btnPurchase.Click
        '* * * * *
        '* This method allows a user to purchase lockpicks.
        '* * * * *

        purchase()
    End Sub

    Private Sub frmThievesGuild_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        '* * * * *
        '* This method handles the form closing.
        '* * * * *

        frmShops.Show()
        frmShops.currUser = currUser
    End Sub
End Class