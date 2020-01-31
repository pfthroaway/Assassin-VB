' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 10/11/2012
' Filename        : Help Form.vb
' Description     : This form displays help for a specific form.

Option Strict On
Option Explicit On

Namespace Forms

    Public Class FrmHelp
        Public loc As String
        Dim _nl As String = ControlChars.NewLine

        Public Sub Display()
            '* * * * *
            '* This method displays the correct help depending on the location
            '* * * * *

            Select Case loc
                Case "Guild Transfer"
                    GuildTransfer()
            End Select
        End Sub

        Private Sub GuildTransfer()
            '* * * * *
            '* This method displays help for the Guild Transfer form.
            '* * * * *

            TxtHelp.Text = "This form allows a guildmaster to transfer gold and henchmen between the guild and the guildmaster." & _nl & _nl &
                           "At the top, there is a choice between transferring to the guild and to the player." & _nl & _nl &
                           "The left two columns display the number of henchmen and gold the guild and the player currently have." & _nl & _nl &
                           "The third column allows the player to edit the number of henchmen and gold to be transferred."
        End Sub

        Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
            '* * * * *
            '* This method closes the form on clicking the Back button.
            '* * * * *

            Me.Close()
        End Sub

        Private Sub FrmHelp_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
            '* * * * *
            '* This method handles the form closing.
            '* * * * *

        End Sub

    End Class

End Namespace