' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 05/25/2012
' Filename        : Thieves Guild Form.vb
' Description     : This form contains the Thieves' Guild.

Option Strict On
Option Explicit On

Imports Assassin.Classes
Imports Assassin.Classes.Entities

Namespace Forms.Shopping

    Public Class FrmThievesGuild

        Dim _nl As String = ControlChars.NewLine 'new line

        Private Sub AddText(newText As String)
            '* * * * *
            '* This method adds formatted text to the TextBox.
            '* * * * *

            Dim currText As String = TxtThievesGuild.Text
            TxtThievesGuild.Clear()

            TxtThievesGuild.Text = newText & _nl & _nl & currText
            TxtThievesGuild.Select(0, 0)
            TxtThievesGuild.ScrollToCaret()
        End Sub

        Public Sub Display()
            '* * * * *
            '* This method displays the player's current gold and number of lockpicks.
            '* * * * *

            TxtThievesGuild.Select(0, 0)
            TxtThievesGuild.ScrollToCaret()

            lblGold.Text = CurrentUser.GoldOnHand.ToString("N0")
            lblLockpicks.Text = CurrentUser.Lockpicks.ToString("N0")

            If CurrentUser.GoldOnHand >= 300 AndAlso CurrentUser.Lockpicks < 99 Then
                BtnPurchase.Enabled = True
            Else
                BtnPurchase.Enabled = False
            End If
        End Sub

        Public Async Sub Purchase()
            '* * * * *
            '* This method purchases lockpicks.
            '* * * * *

            Dim lockpicks As Integer
            Dim maxLockpicks As Integer

            If CurrentUser.Lockpicks + maxLockpicks > 99 Then
                maxLockpicks = 99 - CurrentUser.Lockpicks
            Else
                maxLockpicks = CurrentUser.GoldOnHand \ 300
            End If

            Integer.TryParse(InputBox("How many lockpicks would you like to purchase?" & _nl &
                                      "You can enter a number between 1 and " & maxLockpicks & "."), lockpicks)

            If lockpicks > 0 AndAlso lockpicks <= maxLockpicks Then
                CurrentUser.Lockpicks += lockpicks
                CurrentUser.GoldOnHand -= (lockpicks * 300)
                AddText("You purchase " & lockpicks & " for " & (lockpicks * 300) & " gold.")
                Await SaveUser(CurrentUser)

                Display()
            Else
                MessageBox.Show("Please enter a number between 1 and " & maxLockpicks & ".", "Assassin", MessageBoxButtons.OK)
            End If
        End Sub

        Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
            '* * * * *
            '* This method closes the form on clicking the Back button.
            '* * * * *

            Close()
        End Sub

        Private Sub BtnPurchase_Click(sender As Object, e As EventArgs) Handles BtnPurchase.Click
            '* * * * *
            '* This method allows a user to purchase lockpicks.
            '* * * * *

            Purchase()
        End Sub

        Private Sub FrmThievesGuild_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
            '* * * * *
            '* This method handles the form closing.
            '* * * * *

            FrmShops.Show()
        End Sub

    End Class

End Namespace