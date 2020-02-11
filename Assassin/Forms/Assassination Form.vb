Option Strict On
Option Explicit On

Imports Assassin.Classes

Namespace Forms

    Public Class FrmAssassinate
        Dim _blnBattle As Boolean = False

        ''' <summary>Adds text to the TextBox.</summary>
        ''' <param name="newText">Text to be added</param>
        Public Sub AddText(newText As String)
            AddTextToTextBox(TxtAssassinate, newText)
        End Sub

        ''' <summary>Checks a user's hunger and thirst.</summary>
        Public Function CheckHungerThirst() As Boolean
            If CurrentUser.Hunger >= 24 OrElse CurrentUser.Thirst >= 24 Then
                DisableButtons()

                If CurrentUser.Hunger >= 24 AndAlso CurrentUser.Thirst >= 24 Then
                    AddText("You are too hungry and thirsty to continue.")
                ElseIf CurrentUser.Hunger >= 24 Then
                    AddText("You are too hungry to continue.")
                ElseIf CurrentUser.Thirst >= 24 Then
                    AddText("You are too thirsty to continue.")
                End If
                Return False
            Else
                If CurrentUser.Hunger > 0 AndAlso CurrentUser.Hunger Mod 5 = 0 Then
                    AddText($"You are {GetHunger(CurrentUser.Hunger).ToLower}.")
                End If
                If CurrentUser.Thirst > 0 AndAlso CurrentUser.Thirst Mod 5 = 0 Then
                    AddText($"You are {GetThirst(CurrentUser.Thirst).ToLower}.")
                End If
                Return True
            End If
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
                CurrentUser.Hunger += 1
                CurrentUser.Thirst += 1

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