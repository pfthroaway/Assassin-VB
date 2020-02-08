' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 05/25/2012
' Filename        : Thieves Guild Form.vb
' Description     : This form contains the Thieves' Guild.

Option Strict On
Option Explicit On

Imports Assassin.Classes

Namespace Forms.Shopping

    Public Class FrmThievesGuild

        ''' <summary>Add text to the TextBox.</summary>
        ''' <param name="newText">Text to be added</param>
        Public Sub AddText(newText As String)
            AddTextToTextBox(TxtThievesGuild, newText)
        End Sub

        ''' <summary>Displays the player's current gold and number of lockpicks.</summary>
        Public Sub Display()
            TxtThievesGuild.Select(0, 0)
            TxtThievesGuild.ScrollToCaret()

            LblGold.Text = CurrentUser.GoldOnHandToString
            LblLockpicks.Text = CurrentUser.Lockpicks.ToString("N0")

            BtnPurchase.Enabled = CurrentUser.GoldOnHand >= 300 AndAlso CurrentUser.Lockpicks < 99
        End Sub

        ''' <summary>Purchases lockpicks.</summary>
        Public Async Sub Purchase()
            Dim lockpicks As Integer
            Dim maxLockpicks As Integer

            maxLockpicks = If(CurrentUser.Lockpicks + maxLockpicks > 99, 99 - CurrentUser.Lockpicks, CurrentUser.GoldOnHand \ 300)

            Integer.TryParse(InputBox($"How many lockpicks would you like to purchase?{ControlChars.NewLine}You can enter a number between 1 and {maxLockpicks}."), lockpicks)

            If lockpicks > 0 AndAlso lockpicks <= maxLockpicks Then
                CurrentUser.Lockpicks += lockpicks
                CurrentUser.GoldOnHand -= lockpicks * 300
                AddText($"You purchase {lockpicks} for {lockpicks * 300} gold.")
                Await SaveUser(CurrentUser)

                Display()
            Else
                MessageBox.Show($"Please enter a number between 1 and {maxLockpicks}.", "Assassin", MessageBoxButtons.OK)
            End If
        End Sub

        Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
            Close()
        End Sub

        Private Sub BtnPurchase_Click(sender As Object, e As EventArgs) Handles BtnPurchase.Click
            Purchase()
        End Sub

        Private Sub FrmThievesGuild_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
            FrmShops.Show()
        End Sub

    End Class

End Namespace