Option Strict On
Option Explicit On

Imports Assassin.Classes

Namespace Forms

    Public Class FrmAssassinate

        ''' <summary>Adds text to the TextBox.</summary>
        ''' <param name="newText">Text to be added</param>
        Public Sub AddText(newText As String)
            AddTextToTextBox(TxtAssassinate, newText)
        End Sub

        ''' <summary>Checks a user's hunger and thirst.</summary>
        Public Function CheckHungerThirst() As Boolean
            AddText(CurrentUser.DisplayHungerThirstText())
            If CurrentUser.CanDoAction() Then
                Return True
            End If
            DisableButtons()
            Return False
        End Function

        ''' <summary>Disables the Assassin and New Victim Buttons.</summary>
        Private Sub DisableButtons()
            BtnAssassinate.Enabled = False
            BtnNewVictim.Enabled = False
        End Sub

        ''' <summary>Sets up the Form after finishing a battle.</summary>
        Public Sub FinishBattle()
            BtnAssassinate.Enabled = False
            If CurrentUser.Alive Then
                CheckHungerThirst()
            Else
                DisableButtons()
            End If
        End Sub

        ''' <summary>Gets a new Enemy.</summary>
        Public Sub NewEnemy()
            If CheckHungerThirst() Then
                GetEnemy()
                CurrentUser.GainHungerThirst()

                AddText($"You spot a {CurrentEnemy.Name}.")
                BtnAssassinate.Enabled = True
            End If
        End Sub

#Region "Click"

        Private Sub BtnAssassinate_Click(sender As Object, e As EventArgs) Handles BtnAssassinate.Click
            FrmBattle.Show()
            FrmBattle.Surprise()
            FrmBattle.Display()
            Hide()
        End Sub

        Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
            Close()
        End Sub

        Private Sub BtnNewVictim_Click(sender As Object, e As EventArgs) Handles BtnNewVictim.Click
            NewEnemy()
        End Sub

#End Region

        Private Async Sub FrmAssassinate_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
            FrmGame.Show()
            FrmGame.Display()
            FrmGame.AddText(TxtAssassinate.Text.Trim())
            If Not CurrentUser.Alive Then
                FrmGame.Awaken()
            End If
            Await SaveUser(CurrentUser)
        End Sub

    End Class

End Namespace