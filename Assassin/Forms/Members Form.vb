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
Imports Assassin.Classes.Enums
Imports Assassin.Forms.GuildForms

Namespace Forms

    Public Class FrmMembers
        Dim allUsers As List(Of User)
        Dim selectedUser As User
        Public loc As String            'location

        ''' <summary>Disables most buttons.</summary>
        Private Sub DisableButtons()
            BtnMessage.Enabled = False
            BtnExpel.Enabled = False
            BtnAttack.Enabled = False
        End Sub

        ''' <summary>Loads members of the current <see cref="Guild"/>.</summary>
        Public Async Function LoadMembers() As Task
            LstMembers.Items.Clear()

            If loc = "Manage" OrElse loc = "Guild" Then
                If loc = "Manage" Then
                    BtnExpel.Show()
                End If

                lblName.Text = CurrentGuild.Name & " Members"

                For Each member As String In CurrentGuild.Members
                    LstMembers.Items.Add(member)
                Next
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
            MessageBox.Show("This feature is currently unavailable.")
        End Sub

        Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
            Close()
        End Sub

        Private Async Sub BtnExpel_Click(sender As Object, e As EventArgs) Handles BtnExpel.Click
            If Await MemberLeavesGuild(selectedUser, CurrentGuild) Then
                MessageBox.Show($"{selectedUser.Name} has been expelled from {CurrentGuild.Name}.")
            End If
        End Sub

        Private Sub BtnMessage_Click(sender As Object, e As EventArgs) Handles BtnMessage.Click
            FrmMessages.Show()
            FrmMessages.StartSend()
            FrmMessages.loc = "Members"
            FrmMessages.TxtFrom.Text = LstMembers.SelectedItem.ToString
            Hide()
        End Sub

        Private Sub LstMembers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstMembers.SelectedIndexChanged
            If LstMembers.SelectedIndex >= 0 Then
                If LstMembers.SelectedItem.ToString <> CurrentUser.Name Then
                    selectedUser = allUsers.Find(Function(user) user.Name = LstMembers.SelectedItem.ToString)
                    BtnMessage.Enabled = True
                    BtnExpel.Enabled = True
                    If loc = "Streets" Then
                        BtnAttack.Enabled = selectedUser.CurrentLocation = SleepLocation.Streets
                    End If
                Else
                    DisableButtons()
                End If
            Else
                DisableButtons()
            End If
        End Sub

        Private Sub FrmMembers_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
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