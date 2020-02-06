' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 10/11/2012
' Filename        : Guild Options Form.vb
' Description     : This form allows a guildmaster to manage their guild.

Option Strict On
Option Explicit On

Imports Assassin.Classes

Namespace Forms.GuildForms

    Public Class FrmGuildOptions
        Dim _oldName As String
        Dim _oldMaster As String
        Dim _oldFee As Integer
        Dim _blnMasterChanged As Boolean

        ''' <summary>Add text to the TextBox.</summary>
        ''' <param name="newText">Text to be added</param>
        Public Sub AddText(newText As String)
            AddTextToTextBox(TxtOptions, newText)
        End Sub

        ''' <summary>Disables everything on the form.</summary>
        Private Sub Disable()
            TxtName.Enabled = False
            TxtEntranceFee.Enabled = False
            CmbGuildmaster.Enabled = False
            BtnSave.Enabled = False
        End Sub

        ''' <summary>Displays options.</summary>
        Private Sub Display()
            TxtName.Text = CurrentGuild.Name
            CmbGuildmaster.SelectedItem = CurrentGuild.Master
            TxtEntranceFee.Text = CurrentGuild.Fee.ToString
        End Sub

        ''' <summary>Gets the members of a guild.</summary>
        Private Sub GetMembers()
            CmbGuildmaster.Items.Clear()
            CmbGuildmaster.Items.Add("Computer")

            For Each member As String In CurrentGuild.Members
                CmbGuildmaster.Items.Add(member)
            Next

            CmbGuildmaster.SelectedItem = CurrentGuild.Master
        End Sub

        ''' <summary>Loads the options.</summary>
        Public Sub LoadOptions()
            _oldName = CurrentGuild.Name
            _oldMaster = CurrentGuild.Master
            _oldFee = CurrentGuild.Fee

            Display()
            GetMembers()
        End Sub

        Private Sub TxtEntranceFee_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtEntranceFee.KeyPress
            e.Handled = Char.IsDigit(e.KeyChar) OrElse e.KeyChar Like Chr(8)
        End Sub

        Private Sub TxtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtName.KeyPress
            e.Handled = Char.IsLetter(e.KeyChar) OrElse e.KeyChar Like " " OrElse e.KeyChar Like "'" OrElse e.KeyChar Like Chr(8)
        End Sub

        Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
            Close()
        End Sub

        Private Async Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
            CurrentGuild.Name = TxtName.Text
            CurrentGuild.Master = CmbGuildmaster.SelectedItem.ToString
            Integer.TryParse(TxtEntranceFee.Text, CurrentGuild.Fee)

            Await SaveGuild(CurrentGuild)

            If CurrentGuild.Name <> _oldName Then
                AddText($"You change the name of the guild to {CurrentGuild.Name}.")
            End If

            If CurrentGuild.Fee <> _oldFee Then
                AddText($"You change the guild fee to {CurrentGuild.Fee.ToString}.")
            End If

            If CurrentGuild.Master <> _oldMaster Then
                Disable()
                AddText($"You transfer guildmastership to {CurrentGuild.Master}.")
                _blnMasterChanged = True
            End If

            _oldName = CurrentGuild.Name
            _oldMaster = CurrentGuild.Master
            _oldFee = CurrentGuild.Fee
            Display()

            MessageBox.Show("Save successful.", "Assassin", MessageBoxButtons.OK)
        End Sub

        Private Sub FrmGuildOptions_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
            FrmGuildManage.Show()
            FrmGuildManage.AddText(TxtOptions.Text)
            If _blnMasterChanged = True Then
                FrmGuildManage.Disable()
            End If
        End Sub

    End Class

End Namespace