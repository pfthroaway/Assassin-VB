Option Strict On
Option Explicit On

Imports Assassin.Classes

Namespace Forms.Shopping

    Public Class FrmShops

        ''' <summary>Add text to the TextBox.</summary>
        ''' <param name="newText">Text to be added</param>
        Public Sub AddText(newText As String)
            AddTextToTextBox(TxtShops, newText)
        End Sub

#Region "Click"

        Private Sub BtnArmory_Click(sender As Object, e As EventArgs) Handles BtnArmory.Click
            FrmArmor.Show()
            FrmArmor.BlnLoaded = True
            FrmArmor.DisplayArmor()
            Hide()
        End Sub

        Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
            Close()
        End Sub

        Private Sub BtnGenStore_Click(sender As Object, e As EventArgs) Handles BtnGenStore.Click
            AddText("Sorry, that feature is currently unavailable.")
        End Sub

        Private Sub BtnThieves_Click(sender As Object, e As EventArgs) Handles BtnThieves.Click
            FrmThievesGuild.Show()
            FrmThievesGuild.Display()
            Hide()
        End Sub

        Private Sub BtnWeapons_Click(sender As Object, e As EventArgs) Handles BtnWeapons.Click
            FrmWeapons.Show()
            FrmWeapons.DisplayWeapons()
            Hide()
        End Sub

#End Region

        Private Sub FrmShops_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
            AddText("You leave the shopping district and return to the streets.")
            FrmGame.Show()
            FrmGame.Display()
            FrmGame.AddText(TxtShops.Text.Trim())
        End Sub

    End Class

End Namespace