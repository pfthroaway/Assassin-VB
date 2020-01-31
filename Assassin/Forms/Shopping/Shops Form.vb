' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 05/25/2012
' Filename        : Shops Form.vb
' Description     : This form links to all the various shops.

Option Strict On
Option Explicit On

Imports Assassin.Classes.Entities

Namespace Forms.Shopping

    Public Class FrmShops
        Dim _nl As String = ControlChars.NewLine 'new line

        Public Sub AddText(newText As String)
            '* * * * *
            '* This method adds text to the Textbox.
            '* * * * *

            Dim currText As String = TxtShops.Text
            TxtShops.Clear()

            TxtShops.Text = newText & _nl & _nl & currText
            TxtShops.Select(0, 0)
            TxtShops.ScrollToCaret()
        End Sub

        Private Sub BtnArmory_Click(sender As Object, e As EventArgs) Handles BtnArmory.Click
            '* * * * *
            '* This method displays the Armory form.
            '* * * * *

            FrmArmor.Show()
            FrmArmor.BlnLoaded = True
            FrmArmor.DisplayArmor()
            Me.Hide()
        End Sub

        Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
            '* * * * *
            '* This method closes the form on clicking the Back button.
            '* * * * *

            Me.Close()
        End Sub

        Private Sub BtnGenStore_Click(sender As Object, e As EventArgs) Handles BtnGenStore.Click
            '* * * * *
            '* This method displays the General Store form.
            '* * * * *

            AddText("Sorry, that feature is currently unavailable.")
        End Sub

        Private Sub BtnThieves_Click(sender As Object, e As EventArgs) Handles BtnThieves.Click
            '* * * * *
            '* This method displays the Thieves Guild form.
            '* * * * *

            FrmThievesGuild.Show()
            FrmThievesGuild.Display()
            Me.Hide()
        End Sub

        Private Sub BtnWeapons_Click(sender As Object, e As EventArgs) Handles BtnWeapons.Click
            '* * * * *
            '* This method displays the Weapons form.
            '* * * * *

            FrmWeapons.Show()
            FrmWeapons.DisplayWeapons()
            Me.Hide()
        End Sub

        Private Sub FrmShops_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
            '* * * * *
            '* This method updates the Game form on this form closing.
            '* * * * *

            AddText("You leave the shopping district and return to the streets.")
            FrmGame.Show()
            FrmGame.Display()
            FrmGame.AddText(TxtShops.Text)
        End Sub

    End Class

End Namespace