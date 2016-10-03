' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 05/25/2012
' Filename        : Shops Form.vb
' Description     : This form links to all the various shops.

Option Strict On
Option Explicit On
Public Class frmShops
    Public currUser As New User             'current user
    Dim nl As String = ControlChars.NewLine 'new line

    Public Sub addText(ByVal newText As String)
        '* * * * *
        '* This method adds text to the Textbox.
        '* * * * *

        Dim currText As String = txtShops.Text
        txtShops.Clear()

        txtShops.Text = newText & nl & nl & currText
        txtShops.Select(0, 0)
        txtShops.ScrollToCaret()
    End Sub


    Private Sub btnArmory_Click(sender As System.Object, e As System.EventArgs) Handles btnArmory.Click
        '* * * * *
        '* This method displays the Armory form.
        '* * * * *

        frmArmor.Show()
        frmArmor.currUser = currUser
        frmArmor.blnLoaded = True
        frmArmor.displayArmor()
        Me.Hide()
    End Sub

    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        '* * * * *
        '* This method closes the form on clicking the Back button.
        '* * * * *

        Me.Close()
    End Sub

    Private Sub btnGenStore_Click(sender As System.Object, e As System.EventArgs) Handles btnGenStore.Click
        '* * * * *
        '* This method displays the General Store form.
        '* * * * *

        addText("Sorry, that feature is currently unavailable.")
    End Sub

    Private Sub btnThieves_Click(sender As System.Object, e As System.EventArgs) Handles btnThieves.Click
        '* * * * *
        '* This method displays the Thieves Guild form.
        '* * * * *

        frmThievesGuild.Show()
        frmThievesGuild.currUser = currUser
        frmThievesGuild.display()
        Me.Hide()
    End Sub

    Private Sub btnWeapons_Click(sender As System.Object, e As System.EventArgs) Handles btnWeapons.Click
        '* * * * *
        '* This method displays the Weapons form.
        '* * * * *

        frmWeapons.Show()
        frmWeapons.currUser = currUser
        frmWeapons.blnLoaded = True
        frmWeapons.displayWeapons()
        Me.Hide()
    End Sub


    Private Sub frmShops_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        '* * * * *
        '* This method updates the Game form on this form closing.
        '* * * * *

        addText("You leave the shopping district and return to the streets.")
        frmGame.Show()
        frmGame.display()
        frmGame.addText(txtShops.Text)
    End Sub
End Class