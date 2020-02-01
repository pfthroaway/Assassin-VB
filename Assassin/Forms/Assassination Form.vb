' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 05/25/2012
' Filename        : Assassinate Form.vb
' Description     : This form allows a user to assassinate a victim.

Option Strict On
Option Explicit On

Imports Assassin.Classes

Namespace Forms

    Public Class FrmAssassinate
        Dim _blnBattle As Boolean = False            'boolean to determine if going to battle or game form

        ''' <summary>Adds text to the TextBox.</summary>
        ''' <param name="newText">Text to be added</param>
        Private Sub AddText(newText As String)
            AddTextToTextBox(TxtAssassinate, newText)
        End Sub

        ''' <summary>Checks a user's hunger and thirst.</summary>
        Public Sub CheckHungerThirst()
            If CurrentUser.Hunger >= 24 OrElse CurrentUser.Thirst >= 24 Then
                BtnNewVictim.Enabled = False
                BtnAssassinate.Enabled = False

                If CurrentUser.Hunger >= 24 AndAlso CurrentUser.Thirst >= 24 Then
                    AddText("You are too hungry and thirsty to continue.")
                ElseIf CurrentUser.Hunger >= 24 Then
                    AddText("You are too hungry to continue.")
                ElseIf CurrentUser.Thirst >= 24 Then
                    AddText("You are too thirsty to continue.")
                End If
            Else
                If CurrentUser.Hunger > 0 AndAlso CurrentUser.Hunger Mod 5 = 0 Then
                    AddText("You are " & GetHunger(CurrentUser.Hunger).ToLower & ".")
                End If
                If CurrentUser.Thirst > 0 AndAlso CurrentUser.Thirst Mod 5 = 0 Then
                    AddText("You are " & GetThirst(CurrentUser.Thirst).ToLower & ".")
                End If
            End If
        End Sub

        ''' <summary>Gets a new Enemy.</summary>
        Public Sub NewEnemy()
            GetEnemy()
            AddText($"You spot a {CurrentEnemy.Name}.")
        End Sub

#Region "Click"

        Private Sub BtnAssassinate_Click(sender As Object, e As EventArgs) Handles BtnAssassinate.Click
            CurrentUser.Hunger += 1
            CurrentUser.Thirst += 1

            _blnBattle = True
            Close()
        End Sub

        Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
            Close()
        End Sub

        Private Sub BtnNewVictim_Click(sender As Object, e As EventArgs) Handles BtnNewVictim.Click
            CurrentUser.Hunger += 1
            CurrentUser.Thirst += 1

            NewEnemy()
        End Sub

#End Region

        Private Sub FrmAssassinate_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
            If _blnBattle = True Then    'if going to battle
                FrmBattle.Show()
                FrmBattle.TxtBattle.Text = $"You approach the {CurrentEnemy.Name}.\n\n{TxtAssassinate.Text}"
                FrmBattle.Surprise()
                FrmBattle.Display()
            Else                        'if not going to battle
                FrmGame.Show()
                FrmGame.AddText(TxtAssassinate.Text)
            End If
        End Sub

    End Class

End Namespace