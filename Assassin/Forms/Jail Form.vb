' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 09/29/2012
' Filename        : Jail Form.vb
' Description     : This form displays all users currently jailed.

Option Strict On
Option Explicit On

Imports Assassin.Classes
Imports Assassin.Classes.Entities

Namespace Forms

    Public Class FrmJail
        Dim _jailedUsers As List(Of User)
        Dim _username As String                  'selected username
        Dim _reason As String                    'reason jailed
        Dim _fine As Integer                     'fine

        ''' <summary>Displays all the users currently in jail.</summary>
        Public Async Sub Display()
            '* * * * *
            '* This method
            '* * * * *

            LstJailed.Items.Clear()     'clear ListBox
            LstJailed.ClearSelected()   'deselect ListBox items
            lblFine.Text = ""
            lblReason.Text = ""

            _jailedUsers = Await GameState.LoadUsers()

            For Each user As User In _jailedUsers
                If user.CurrentLocation <> "Jail" Then
                    _jailedUsers.Remove(user)
                End If
            Next

            For Each user As User In _jailedUsers
                LstJailed.Items.Add(user.Name)
            Next

            BtnBailOut.Enabled = False
        End Sub

        Private Sub LstJailed_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstJailed.SelectedIndexChanged
            '* * * * *
            '* This method displays jail information about the selected user.
            '* * * * *

            'If LstJailed.SelectedIndex >= 0 Then
            '    _username = LstJailed.SelectedItem.ToString
            '    _ds.Clear()
            '    _sql = "SELECT * FROM Jail WHERE Username='" & _username & "'"
            '    _table = "Jail"

            '    _reason = _ds.Tables(0).Rows(0).Item("Reason").ToString
            '    Integer.TryParse(_ds.Tables(0).Rows(0).Item("Fine").ToString, _fine)

            '    lblReason.Text = _reason
            '    lblFine.Text = _fine.ToString

            '    If CurrentUser.GoldOnHand >= _fine Then
            '        BtnBailOut.Enabled = True
            '    Else
            '        BtnBailOut.Enabled = False
            '    End If
            'End If
        End Sub

        Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
            '* * * * *
            '* This method closes the form.
            '* * * * *

            Me.Close()
        End Sub

        Private Sub BtnBailOut_Click(sender As Object, e As EventArgs) Handles BtnBailOut.Click
            '* * * * *
            '* This method bails a user out of jail.
            '* * * * *
            'TODO Fix Bail Out Jail
            '_ds.Clear()                          'clear dataSet
            '_sql = "SELECT * FROM Jail WHERE Username='" & _username & "'"
            '_table = "Jail"
            ''fill DataSet

            '.DeleteRecord(_sql, _table, _ds)  'delete record

            'CurrentUser.GoldOnHand -= _fine
            '_ds.Clear()                          'clear DataSet

            '_sql = "SELECT * FROM Users WHERE Username='" & _username & "'"
            '_table = "Users"
            ''fill DataSet

            '_ds.Tables(0).Rows(0).Item("Location") = "Streets" 'change location to street

            '.UpdateRecord(_sql, _table, _ds)  'update Record

            Display()
        End Sub

        Private Sub FrmJail_Load(sender As Object, e As EventArgs) Handles Me.Load
            '* * * * *
            '* This method handles what happens on loading the form.
            '* * * * *

            Display()
        End Sub

        Private Async Sub FrmJail_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
            '* * * * *
            '* This method manages closing the form.
            '* * * * *

            FrmGame.Show()
            Await SaveUser(CurrentUser)
        End Sub

    End Class

End Namespace