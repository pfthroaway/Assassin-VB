' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 05/25/2012
' Filename        : Manage Applications Form.vb
' Description     : This form allows a guildmaster to confirm or deny applications to join the guild.

Option Strict On
Option Explicit On

Imports Assassin.Classes
Imports Assassin.Forms.GuildForms

Namespace Forms

    Public Class FrmManageApplications

        Dim _applicant As String         'applicant's username

        Private Sub Clear()
            '* * * * *
            '* This method resets all the data in the form.
            '* * * * *

            BtnConfirm.Enabled = False
            BtnDeny.Enabled = False
            LstApplications.ClearSelected()
            LstApplications.Items.Clear()
        End Sub

        Private Sub Confirm()
            '* * * * *
            '* This method confirms an applicant.
            '* * * * *
            'TODO Guild Application Accept
            '_sql = "SELECT * FROM Applications WHERE Guild=" & CurrentGuild.ID & " AND Username='" & _applicant & "'"
            '_table = "Applications"

            '                   'fill DS with applicants
            '.DeleteRecord(_sql, _table, _ds)              'delete application

            '_sql = "SELECT * FROM Guild" & CurrentGuild.ID & "Members WHERE Username='" & _applicant & "'"
            '_table = "Guild"

            '                   'fill DS with guild members with applicant name
            'Dim dsNewRow As DataRow
            'dsNewRow = _ds.Tables(0).NewRow()          'create new row
            'dsNewRow.Item("Username") = _applicant

            '_ds.Tables(0).Rows.Add(dsNewRow)           'add new row to DataSet
            '.UpdateRecord(_sql, _table, _ds)              'update DataSet

            '_sql = "SELECT * FROM Messages WHERE UserTo='" & _applicant & "' AND UserFrom='" & CurrentGuild.Name.Replace("'", "''") &
            '       "' AND Message='Your application to join the " & CurrentGuild.Name.Replace("'", "''") & " guild has been approved. Welcome!'"
            '_table = "Messages"

            'Dim dsNewRow2 As DataRow
            'dsNewRow2 = _ds.Tables(0).NewRow()
            'dsNewRow2.Item("UserTo") = _applicant
            'dsNewRow2.Item("UserFrom") = CurrentGuild.Name
            'dsNewRow2.Item("Message") = "Your application to join the " & CurrentGuild.Name & " guild has been approved. Welcome!"
            'dsNewRow2.Item("DateSent") = Now
            'dsNewRow2.Item("GuildMessage") = True

            '_ds.Tables(0).Rows.Add(dsNewRow2)
            '.UpdateRecord(_sql, _table, _ds)

            'GetApplicants()
            'MessageBox.Show("Application successfully approved.", "Assassin", MessageBoxButtons.OK)
            'FrmGuildManage.AddText(_applicant & " has been accepted to the guild.")
        End Sub

        Private Sub Deny()
            '* * * * *
            '* This method denies an applicant.
            '* * * * *
            'TODO Fix Application Denial
            '_sql = "SELECT * FROM Applications WHERE Guild=" & CurrentGuild.ID & " AND Username='" & _applicant & "'"
            '_table = "Applications"

            '       'fill DS
            '.DeleteRecord(_sql, _table, _ds)  'delete application

            '_sql = "SELECT * FROM Messages WHERE UserTo='" & _applicant & "' AND UserFrom='" & CurrentGuild.Name.Replace("'", "''") &
            '       "' AND Message='Your application to join the " & CurrentGuild.Name.Replace("'", "''") & " guild has been approved. Welcome!'"
            '_table = "Messages"

            'If _ds.Tables(0).Rows.Count = 0 Then
            '    Dim dsNewRow As DataRow
            '    dsNewRow = _ds.Tables(0).NewRow()
            '    dsNewRow.Item("UserTo") = _applicant
            '    dsNewRow.Item("UserFrom") = CurrentGuild.Name
            '    dsNewRow.Item("Message") = "Your application to join the " & CurrentGuild.Name & " guild has been declined."
            '    dsNewRow.Item("DateSent") = Now
            '    dsNewRow.Item("GuildMessage") = True

            '    _ds.Tables(0).Rows.Add(dsNewRow)
            '    .UpdateRecord(_sql, _table, _ds)
            'End If

            'GetApplicants()
            'MessageBox.Show("Application successfully denied.", "Assassin", MessageBoxButtons.OK)
            'FrmGuildManage.AddText(_applicant & " has been denied access to the guild.")
        End Sub

        Public Async Function GetApplicants() As Threading.Tasks.Task
            '* * * * *
            '* This method gets all applicants for the current guild.
            '* * * * *

            Clear()
            Dim applicants As List(Of String) = Await LoadGuildApplicants(CurrentGuild)

            If applicants.Count > 0 Then
                For Each applicant As Integer In applicants
                    LstApplications.Items.Add(applicant)
                Next
            End If
        End Function

        Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
            '* * * * *
            '* This method closes the form.
            '* * * * *

            Close()
        End Sub

        Private Sub BtnConfirm_Click(sender As Object, e As EventArgs) Handles BtnConfirm.Click
            '* * * * *
            '* This method confirms an applicant.
            '* * * * *

            Confirm()
        End Sub

        Private Sub BtnDeny_Click(sender As Object, e As EventArgs) Handles BtnDeny.Click
            '* * * * *
            '* This method denies an applicant.
            '* * * * *

            Deny()
        End Sub

        Private Sub LstApplications_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstApplications.SelectedIndexChanged
            '* * * * *
            '* This method handles the selected index changing on the LstApplications ListBox.
            '* * * * *

            If LstApplications.SelectedIndex >= 0 Then
                _applicant = LstApplications.SelectedItem.ToString   'save selected applicant name
                BtnConfirm.Enabled = True
                BtnDeny.Enabled = True
            Else
                BtnConfirm.Enabled = False
                BtnDeny.Enabled = False
            End If
        End Sub

        Private Sub FrmGuildManageApplications_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
            '* * * * *
            '* This method handles closing the form.
            '* * * * *

            FrmGuildManage.Show()
        End Sub

    End Class

End Namespace