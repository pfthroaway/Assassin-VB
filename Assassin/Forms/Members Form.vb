' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 05/25/2012
' Filename        : Members Form.vb
' Description     : This form contains the list of users.

Option Strict On
Option Explicit On

Imports System.Threading.Tasks
Imports Assassin.Classes
Imports Assassin.Classes.Entities
Imports Assassin.Forms.GuildForms

Namespace Forms

    ' TODO 2019-08-23 - Fixing all instances where CurrentUser/Guild or DataSets were being used.
    Public Class FrmMembers
        Dim allUsers As List(Of User)
        Dim selectedUser As User
        Public loc As String            'location

        Public Async Function LoadMembers() As Task
            '* * * * *
            '* This method loads members of the current guild.
            '* * * * *

            LstMembers.Items.Clear()

            If loc = "Manage" OrElse loc = "Guild" Then

                If loc = "Manage" Then
                    BtnExpel.Show()
                End If

                lblName.Text = CurrentGuild.Name & " Members"

                LstMembers.Items.Add(CurrentGuild.Members)
            ElseIf loc = "Streets" Then
                BtnAttack.Show()
                lblName.Text = "All Players"
                allUsers = Await LoadUsers()
                For Each user As User In allUsers
                    LstMembers.Items.Add(user.Name)
                Next
            End If
        End Function

        Private Sub BtnAttack_Click(sender As Object, e As EventArgs) Handles BtnAttack.Click
            '* * * * *
            '* This method attacks another player.
            '* * * * *

        End Sub

        Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
            '* * * * *
            '* This method closes the form on clicking the Back button.
            '* * * * *

            Close()
        End Sub

        Private Sub BtnExpel_Click(sender As Object, e As EventArgs) Handles BtnExpel.Click
            '* * * * *
            '* This method expels the selected user.
            '* * * * *
            'TODO Fix Guild Expulsion
            'Dim dlg As DialogResult
            'Dim expelName As String = LstMembers.SelectedItem.ToString
            'dlg = MessageBox.Show("Are you sure you want to expel " & expelName & "?", "Assassin", MessageBoxButtons.YesNo)
            'If dlg = DialogResult.Yes Then
            '    _sql = "SELECT * FROM Guild" & CurrentGuild.ID & "Members WHERE Username='" & expelName & "'"
            '    _table = "Members"

            '    .DeleteRecord(_sql, _table, _ds)

            '    MessageBox.Show("Member successfully expelled.")

            '    _sql = "SELECT * FROM Messages WHERE UserTo='" & expelName & "' AND UserFrom='" & CurrentGuild.Name.Replace("'", "''") &
            '           "' AND Message='You have been expelled from " & CurrentGuild.Name.Replace("'", "''") & ".'"
            '    _table = "Messages"

            '    Dim dsNewRow As DataRow
            '    dsNewRow = _ds.Tables(0).NewRow()
            '    dsNewRow.Item("UserTo") = expelName
            '    dsNewRow.Item("UserFrom") = CurrentGuild.Name
            '    dsNewRow.Item("Message") = "You have been expelled from " & CurrentGuild.Name & "."
            '    dsNewRow.Item("DateSent") = Now
            '    dsNewRow.Item("GuildMessage") = True

            '    _ds.Tables(0).Rows.Add(dsNewRow)
            '    .UpdateRecord(_sql, _table, _ds)
            '    LoadMembers()
            'End If
        End Sub

        Private Sub BtnMessage_Click(sender As Object, e As EventArgs) Handles BtnMessage.Click
            '* * * * *
            '* This method closes the form on clicking the Back button.
            '* * * * *

            FrmMessages.Show()
            FrmMessages.StartSend()
            FrmMessages.loc = "Members"
            FrmMessages.TxtFrom.Text = LstMembers.SelectedItem.ToString
            Hide()
        End Sub

        Private Sub LstMembers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstMembers.SelectedIndexChanged
            '* * * * *
            '* This method closes the form on clicking the Back button.
            '* * * * *

            If LstMembers.SelectedIndex >= 0 Then
                If LstMembers.SelectedItem.ToString <> CurrentUser.Name Then
                    selectedUser = allUsers.Find(Function(user) user.Name = LstMembers.SelectedItem.ToString)
                    BtnMessage.Enabled = True
                    BtnExpel.Enabled = True
                    If loc = "Streets" Then
                        If selectedUser.CurrentLocation = "Streets" Then
                            BtnAttack.Enabled = True
                        Else
                            BtnAttack.Enabled = False
                        End If
                    End If
                Else
                    BtnMessage.Enabled = False
                    BtnExpel.Enabled = False
                    BtnAttack.Enabled = False
                End If
            Else
                BtnMessage.Enabled = False
                BtnExpel.Enabled = False
                BtnAttack.Enabled = False
            End If
        End Sub

        Private Sub FrmMembers_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
            '* * * * *
            '* This method handles closing the form.
            '* * * * *

            If loc = "Manage" Then
                FrmGuildManage.Show()
            ElseIf loc = "Guild" Then
                FrmGuild.Show()
            ElseIf loc = "Streets" Then
                FrmGame.Show()
            End If
        End Sub

    End Class

End Namespace