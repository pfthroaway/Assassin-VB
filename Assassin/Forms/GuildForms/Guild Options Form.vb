' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 10/11/2012
' Filename        : Guild Options Form.vb
' Description     : This form allows a guildmaster to manage their guild.

Option Strict On
Option Explicit On

Imports Assassin.Classes
Imports Assassin.Classes.Entities

Namespace Forms.GuildForms

    Public Class FrmGuildOptions

        Dim _nl As String = ControlChars.NewLine
        Dim _oldName As String
        Dim _oldMaster As String
        Dim _oldFee As Integer
        Dim _blnMasterChanged As Boolean

        Private Sub AddText(newText As String)
            '* * * * *
            '* This method adds text to the Textbox.
            '* * * * *

            Dim currText As String = TxtOptions.Text
            TxtOptions.Clear()

            TxtOptions.Text = newText & _nl & _nl & currText
            TxtOptions.Select(0, 0)
            TxtOptions.ScrollToCaret()
        End Sub

        Private Sub Disable()
            '* * * * *
            '* This method disables everything on the form.
            '* * * * *

            TxtName.Enabled = False
            TxtEntranceFee.Enabled = False
            CmbGuildmaster.Enabled = False
            BtnSave.Enabled = False
        End Sub

        Private Sub Display()
            '* * * * *
            '* This method displays options.
            '* * * * *

            TxtName.Text = CurrentGuild.Name
            CmbGuildmaster.SelectedItem = CurrentGuild.Master
            TxtEntranceFee.Text = CurrentGuild.Fee.ToString
        End Sub

        Private Sub GetMembers()
            '* * * * *
            '* This method gets the members of a guild.
            '* * * * *

            CmbGuildmaster.Items.Clear()
            CmbGuildmaster.Items.Add("Computer")

            For Each member As String In CurrentGuild.Members
                CmbGuildmaster.Items.Add(member)
            Next

            CmbGuildmaster.SelectedItem = CurrentGuild.Master
        End Sub

        Public Sub LoadOptions()
            '* * * * *
            '* This method loads the options.
            '* * * * *

            _oldName = CurrentGuild.Name
            _oldMaster = CurrentGuild.Master
            _oldFee = CurrentGuild.Fee

            Display()
            GetMembers()
        End Sub

        Private Sub TxtEntranceFee_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtEntranceFee.KeyPress
            '* * * * *
            '* This method handles what buttons can be pressed in this TextBox.
            '* * * * *

            If Char.IsDigit(e.KeyChar) OrElse e.KeyChar Like Chr(8) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End Sub

        Private Sub TxtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtName.KeyPress
            '* * * * *
            '* This method handles what buttons can be pressed in this TextBox.
            '* * * * *

            If Char.IsLetter(e.KeyChar) OrElse e.KeyChar Like " " OrElse e.KeyChar Like "'" OrElse e.KeyChar Like Chr(8) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End Sub

        Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
            '* * * * *
            '* This method closes the form on clicking the Exit button.
            '* * * * *

            Close()
        End Sub

        Private Async Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
            '* * * * *
            '* This method saves the guild.
            '* * * * *

            CurrentGuild.Name = TxtName.Text
            CurrentGuild.Master = CmbGuildmaster.SelectedItem.ToString
            Integer.TryParse(TxtEntranceFee.Text, CurrentGuild.Fee)

            Await SaveGuild(CurrentGuild)

            If CurrentGuild.Name <> _oldName Then
                AddText("You change the name of the guild to " & CurrentGuild.Name & ".")
            End If

            If CurrentGuild.Fee <> _oldFee Then
                AddText("You change the guild fee to " & CurrentGuild.Fee.ToString & ".")
            End If

            If CurrentGuild.Master <> _oldMaster Then
                Disable()
                AddText("You transfer guildmastership to " & CurrentGuild.Master & ".")
                _blnMasterChanged = True
            End If

            _oldName = CurrentGuild.Name
            _oldMaster = CurrentGuild.Master
            _oldFee = CurrentGuild.Fee
            Display()

            MessageBox.Show("Save successful.", "Assassin", MessageBoxButtons.OK)
        End Sub

        Private Sub FrmGuildOptions_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
            '* * * * *
            '* This method handles the form closing.
            '* * * * *

            FrmGuildManage.Show()
            FrmGuildManage.AddText(TxtOptions.Text)
            If _blnMasterChanged = True Then
                FrmGuildManage.Disable()
            End If
        End Sub

    End Class

End Namespace