' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 10/11/2012
' Filename        : Help Form.vb
' Description     : This form displays help for a specific form.

Option Strict On
Option Explicit On

Public Class frmHelp
    Public loc As String
    Dim nl As String = ControlChars.NewLine

    Public Sub display()
        '* * * * *
        '* This method displays the correct help depending on the location
        '* * * * *

        Select Case loc
            Case "Guild Transfer"
                guildTransfer()
        End Select
    End Sub

    Private Sub guildTransfer()
        '* * * * * 
        '* This method displays help for the Guild Transfer form.
        '* * * * *

        txtHelp.Text = "This form allows a guildmaster to transfer gold and henchmen between the guild and the guildmaster." & nl & nl & _
            "At the top, there is a choice between transferring to the guild and to the player." & nl & nl & _
            "The left two columns display the number of henchmen and gold the guild and the player currently have." & nl & nl & _
            "The third column allows the player to edit the number of henchmen and gold to be transferred."
    End Sub

    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        '* * * * *
        '* This method closes the form on clicking the Back button.
        '* * * * *

        Me.Close()
    End Sub


    Private Sub frmHelp_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        '* * * * *
        '* This method handles the form closing.
        '* * * * *

        
    End Sub
End Class