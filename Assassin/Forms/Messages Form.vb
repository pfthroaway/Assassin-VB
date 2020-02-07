' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 05/25/2012
' Filename        : Messages Form.vb
' Description     : This form allows users to send messages to one another.

Option Strict On
Option Explicit On

Imports System.Threading.Tasks
Imports Assassin.Classes

Namespace Forms

    Public Class FrmMessages

        Dim _messages As List(Of Message)
        Dim _currentIndex As Integer = 0
        Public loc As String

        ''' <summary>Clears all the information on the form.</summary>
        Private Sub Clear()
            BtnNext.Enabled = False
            BtnPrev.Enabled = False
            BtnDelete.Enabled = False
            BtnReply.Enabled = False
            LblCount.Text = ""
            TxtFrom.Clear()
            TxtDate.Clear()
            TxtMessage.Clear()
        End Sub

        ''' <summary>Displays the message.</summary>
        Private Sub Display()
            If _messages.Count <= _currentIndex Then
                Dim message As Message = _messages(_currentIndex)
                TxtFrom.Text = message.UserFrom
                TxtDate.Text = message.DateSent.ToString

                TxtMessage.Text = message.Contents
                LblCount.Text = $"{_currentIndex + 1} / {_messages.Count}"
                BtnDelete.Enabled = True
                BtnNext.Enabled = _currentIndex = _messages.Count
                BtnPrev.Enabled = _currentIndex = _messages.Count

                BtnReply.Enabled = Not message.GuildMessage
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

        ''' <summary>This method loads all names into the CmbNames ComboBox to be used in sending new messages.</summary>
        Private Sub LoadNames()
            'CmbNames.Items.Clear()

            '_sql1 = "SELECT Username FROM Users ORDER BY ID Asc"
            '_table1 = "Users"
            '_ds1 = Await .FillDs(_sql1, _table1)

            'For i As Integer = 0 To _ds1.Tables(0).Rows.Count - 1
            '    CmbNames.Items.Add(_ds1.Tables(0).Rows(i).Item("Username").ToString)
            'Next

            'CmbNames.Items.Remove(CurrentUser.Name)
        End Sub

        ''' <summary>Starts the form being able to send messages.</summary>
        Public Async Sub StartSend()
            Await LoadMessages()
            BtnReply.Enabled = True
            BtnDelete.Enabled = True
            BtnReply.Text = "&Send"     'change text to Send
            BtnDelete.Text = "&Clear"   'change text to Clear
            LblFrom.Text = "To:"        'change text to To:
            LblCount.Text = ""          'Clear LblCount
            TxtMessage.Clear()
            TxtDate.Clear()

            LoadNames()
            TxtMessage.ReadOnly = False 'allow Textbox to be edited
            BtnNext.Enabled = False     'disable Next button
            BtnPrev.Enabled = False     'disable Prev button
            BtnBack.Enabled = False     'disable Back button
        End Sub

        Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
            Close()
        End Sub

        Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
            '* * * * *
            '* This method closes the form on clicking the Back button.
            '* * * * *
            'TODO Re-implement deleting messages
            'If BtnDelete.Text = "&Delete" Then  'delete
            '    _sql1 = "SELECT * FROM Messages WHERE UserTo='" & CurrentUser.Name & "' AND UserFrom='" & _userFrom.Replace("'", "''") & "' AND Message='" & _message.Replace("'", "''") & "'"
            '    _table1 = "Messages"
            '    _ds1 = Await .FillDs(_sql1, _table1)

            '    .DeleteRecord(_sql1, _table1, _ds1)
            '    MessageBox.Show("Message successfully deleted.", "Assassin", MessageBoxButtons.OK)
            '    LoadMessages()
            'Else                                'Clear
            '    BtnReply.Text = "&Reply"    'change text to Send
            '    BtnDelete.Text = "&Delete"  'change text to Clear
            '    LblFrom.Text = "From:"      'change text to From:

            '    BtnNew.Enabled = True
            '    CmbNames.Enabled = False
            '    TxtMessage.ReadOnly = True  'allow Textbox to be edited
            '    BtnNext.Enabled = True      'disable Next button
            '    BtnPrev.Enabled = True      'disable Prev button
            '    BtnBack.Enabled = True      'disable Back button
            '    Display()
            'End If
        End Sub

        Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
            BtnNew.Enabled = False
            StartSend()
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

        Private Sub BtnReply_Click(sender As Object, e As EventArgs) Handles BtnReply.Click
            '* * * * *
            '* This method closes the form on clicking the Back button.
            '* * * * *
            'TODO Fix Reply Messages
            'If BtnReply.Text = "&Reply" Then    'reply
            '    BtnReply.Text = "&Send"         'change text to Send
            '    BtnDelete.Text = "&Clear"       'change text to Clear
            '    LblFrom.Text = "To:"            'change text to To:
            '    LblCount.Text = ""              'Clear LblCount
            '    TxtDate.Clear()                 'clear Date TextBox
            '    TxtMessage.Clear()              'clear Message TextBox

            '    TxtMessage.ReadOnly = False 'allow Textbox to be edited
            '    BtnNext.Enabled = False     'disable Next button
            '    BtnPrev.Enabled = False     'disable Prev button
            '    BtnBack.Enabled = False     'disable Back button
            '    BtnDelete.Enabled = True    'enable Delete button
            '    BtnNew.Enabled = False      'disable New button
            'Else                                'send
            '    If TxtMessage.TextLength > 0 Then
            '        _sql1 = "SELECT * FROM Users WHERE Username='" & CmbNames.SelectedItem.ToString & "'"
            '        _table1 = "Users"
            '        _ds1 = Await .FillDs(_sql1, _table1)

            '        If _ds1.Tables(0).Rows.Count > 0 Then   'if user exists
            '            _sql1 = "SELECT * FROM Messages"
            '            _table1 = "Messages"
            '            _ds1 = Await .FillDs(_sql1, _table1)

            '            Dim dsNewRow As DataRow
            '            dsNewRow = _ds1.Tables(0).NewRow()
            '            dsNewRow.Item("UserTo") = CmbNames.SelectedItem.ToString
            '            dsNewRow.Item("UserFrom") = CurrentUser.Name
            '            dsNewRow.Item("Message") = TxtMessage.Text
            '            dsNewRow.Item("DateSent") = Now
            '            _ds1.Tables(0).Rows.Add(dsNewRow)
            '            .UpdateRecord(_sql1, _table1, _ds1)

            '            BtnReply.Text = "&Reply"    'change text to Send
            '            BtnDelete.Text = "&Delete"  'change text to Clear
            '            LblFrom.Text = "From:"      'change text to From:

            '            BtnNew.Enabled = True       'enable BtnNew
            '            CmbNames.Enabled = False    'enable CmbNames
            '            TxtMessage.ReadOnly = True  'allow Textbox to be edited
            '            BtnNext.Enabled = True      'disable Next button
            '            BtnPrev.Enabled = True      'disable Prev button
            '            BtnBack.Enabled = True      'disable Back button
            '            BtnNew.Enabled = True       'enable New button

            '            MessageBox.Show("Message successfully sent.", "Assassin", MessageBoxButtons.OK)
            '            Display()
            '        Else
            '            MessageBox.Show("Please enter a valid username to be the recipient of the message.", "Assassin", MessageBoxButtons.OK)
            '        End If
            '    Else
            '        MessageBox.Show("Please ensure you have filled out all fields correctly.", "Assassin", MessageBoxButtons.OK)
            '    End If
            'End If
        End Sub

        Private Sub FrmMessages_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
            '* * * * *
            '* This method handles closing the form.
            '* * * * *

            If loc = "Streets" Then
                FrmGame.Show()
            ElseIf loc = "Members" Then
                FrmMembers.Show()
            End If
        End Sub

    End Class

End Namespace