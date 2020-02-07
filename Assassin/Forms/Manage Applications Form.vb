' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 05/25/2012
' Filename        : Manage Applications Form.vb
' Description     : This form allows a guildmaster to confirm or deny applications to join the guild.

Option Strict On
Option Explicit On

Imports System.Threading.Tasks
Imports Assassin.Classes
Imports Assassin.Classes.Entities
Imports Assassin.Forms.GuildForms

Namespace Forms

    Public Class FrmManageApplications
        Dim _applicant As User

        ''' <summary>Resets all the data in the form.</summary>
        Private Sub Clear()
            BtnConfirm.Enabled = False
            BtnDeny.Enabled = False
            LstApplications.ClearSelected()
            LstApplications.Items.Clear()
        End Sub

        ''' <summary>Confirms an applicant.</summary>
        Private Async Sub Confirm()
            Await DenyGuildApplication(_applicant, CurrentGuild)
            MessageBox.Show("Application successfully approved.", "Assassin", MessageBoxButtons.OK)
            Await GetApplicants()
            FrmGuildManage.AddText($"{_applicant.Name} has been accepted to the guild.")
        End Sub

        ''' <summary>Denies an applicant.</summary>
        Private Async Sub Deny()
            Await DenyGuildApplication(_applicant, CurrentGuild)
            MessageBox.Show("Application successfully denied.", "Assassin", MessageBoxButtons.OK)
            Await GetApplicants()
            FrmGuildManage.AddText($"{_applicant.Name} has been denied access to the guild.")
        End Sub

        ''' <summary>Gets all applicants for the current <see cref="Guild"/>.</summary>
        Public Async Function GetApplicants() As Task
            Clear()
            Dim applicants As List(Of String) = Await GameState.DatabaseInteraction.LoadGuildApplicants(CurrentGuild)

            If applicants.Count > 0 Then
                For Each applicant As Integer In applicants
                    LstApplications.Items.Add(applicant)
                Next
            End If
        End Function

#Region "Click"

        Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
            Close()
        End Sub

        Private Sub BtnConfirm_Click(sender As Object, e As EventArgs) Handles BtnConfirm.Click
            Confirm()
        End Sub

        Private Sub BtnDeny_Click(sender As Object, e As EventArgs) Handles BtnDeny.Click
            Deny()
        End Sub

        Private Sub LstApplications_SelectedIndexChangedAsync(sender As Object, e As EventArgs) Handles LstApplications.SelectedIndexChanged
            If LstApplications.SelectedIndex >= 0 Then
                _applicant = AllUsers.Find(Function(user) user.Name = LstApplications.SelectedItem.ToString)
                BtnConfirm.Enabled = True
                BtnDeny.Enabled = True
            Else
                BtnConfirm.Enabled = False
                BtnDeny.Enabled = False
            End If
        End Sub

#End Region

        Private Sub FrmGuildManageApplications_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
            FrmGuildManage.Show()
        End Sub

    End Class

End Namespace