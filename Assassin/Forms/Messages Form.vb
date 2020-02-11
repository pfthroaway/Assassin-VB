Option Strict On
Option Explicit On

Imports System.Threading.Tasks
Imports Assassin.Classes
Imports Assassin.Classes.Entities

Namespace Forms

    Public Class FrmMessages
        Dim _messages As List(Of Message)
        Dim _currentMessage As Message
        Dim _currentIndex As Integer = 0
        Public loc As String

        ''' <summary>Clears all the information on the form.</summary>
        Private Sub Clear()
            BtnNext.Enabled = False
            BtnPrev.Enabled = False
            BtnDelete.Enabled = False
            BtnReply.Enabled = False
            LblCount.Text = ""
            CmbNames.SelectedIndex = -1
            TxtDate.Clear()
            TxtMessage.Clear()
        End Sub

        ''' <summary>Displays the message.</summary>
        Private Sub Display()
            If _messages.Count > 0 AndAlso _messages.Count >= _currentIndex Then
                _currentMessage = _messages(_currentIndex)
                CmbNames.Text = _currentMessage.UserFrom
                TxtDate.Text = _currentMessage.DateSent.ToString

                TxtMessage.Text = _currentMessage.Contents
                LblCount.Text = $"{_currentIndex + 1} / {_messages.Count}"
                BtnDelete.Enabled = True
                BtnNext.Enabled = _currentIndex = _messages.Count
                BtnPrev.Enabled = _currentIndex = _messages.Count

                BtnReply.Enabled = Not _currentMessage.GuildMessage
            Else
                Clear()
                BtnNew.Enabled = True
                TxtMessage.Text = "You have no messages."
            End If
        End Sub

        ''' <summary>Loads messages for the current user.</summary>
        Public Async Function LoadMessages() As Task
            _messages = Await DatabaseInteraction.LoadMessages(CurrentUser)

            If _messages.Count > 0 Then
                _currentIndex = 0
                Display()
            Else
                Clear()
                TxtMessage.Text = "You have no messages."
            End If
        End Function

        ''' <summary>Sets the Controls to default.</summary>
        Private Sub SetDefaultControls()
            BtnReply.Text = "&Reply"
            BtnDelete.Text = "&Delete"
            LblFrom.Text = "From:"
            LblCount.Text = ""
            TxtDate.Clear()

            ToggleControls(True)
            TxtMessage.ReadOnly = True
            CmbNames.Enabled = False
        End Sub

        ''' <summary>Sets up the controls for sending a <see cref="Message"/>.</summary>
        Private Sub SetUpSend()
            BtnReply.Text = "&Send"
            BtnDelete.Text = "&Clear"
            LblFrom.Text = "To:"
            LblCount.Text = ""
            TxtDate.Clear()
            TxtMessage.Clear()
            ToggleControls(False)
            TxtMessage.ReadOnly = False
            BtnDelete.Enabled = True
            CmbNames.SelectedIndex = 0
        End Sub

        ''' <summary>Toggles all Controls on the Form.</summary>
        ''' <param name="enabled">Should the Controls be enabled?</param>
        Private Sub ToggleControls(enabled As Boolean)
            BtnNext.Enabled = enabled AndAlso _messages.Count > 1
            BtnPrev.Enabled = enabled AndAlso _messages.Count > 1
            BtnNew.Enabled = enabled
        End Sub

#Region "Click"

        Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
            Close()
        End Sub

        Private Async Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
            If BtnDelete.Text = "&Delete" Then 'Delete
                If Await DatabaseInteraction.DeleteMessage(_currentMessage) Then
                    Await LoadMessages()
                End If
            Else 'Clear
                Clear()
                Display()
            End If
        End Sub

        Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
            BtnNew.Enabled = False
            SetUpSend()
            CmbNames.Enabled = True
        End Sub

        Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
            If _currentIndex = _messages.Count - 1 Then
                _currentIndex = 0
            Else
                _currentIndex += 1
            End If

            Display()
        End Sub

        Private Sub BtnPrev_Click(sender As Object, e As EventArgs) Handles BtnPrev.Click
            If _currentIndex = 0 Then
                _currentIndex = _messages.Count - 1
            Else
                _currentIndex -= 1
            End If

            Display()
        End Sub

        Private Async Sub BtnReply_Click(sender As Object, e As EventArgs) Handles BtnReply.Click
            If BtnReply.Text = "&Reply" Then 'Set Up Send
                SetUpSend()
            Else 'Already Clicked Reply
                If TxtMessage.TextLength > 0 AndAlso Await DatabaseInteraction.SendMessage(New Message(0, CurrentUser.Name, CmbNames.SelectedItem.ToString(), TxtMessage.Text.Trim(), Date.UtcNow, False)) Then 'If Message Successfully Sent
                    SetDefaultControls()
                    ToggleControls(True)
                    TxtMessage.ReadOnly = True
                    Display()
                Else
                    MessageBox.Show("Please ensure you have filled out all fields correctly.", "Assassin", MessageBoxButtons.OK)
                End If
            End If
        End Sub

        Private Sub CmbNames_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbNames.SelectedIndexChanged
            If CmbNames.SelectedIndex >= 0 Then
                BtnReply.Enabled = True
            End If
        End Sub

#End Region

#Region "Form Manipulation"

        Private Async Sub FrmMessages_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            For Each user As User In AllUsers
                CmbNames.Items.Add(user)
            Next
            CmbNames.Items.Remove(CurrentUser)
            Await LoadMessages()
        End Sub

        Private Sub FrmMessages_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
            If loc = "Streets" Then
                FrmGame.Show()
            ElseIf loc = "Members" Then
                FrmMembers.Show()
            End If
        End Sub

#End Region

    End Class

End Namespace