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
Imports Assassin.Classes.Enums

Namespace Forms

    Public Class FrmJail
        Dim _selectedJailedUser As JailedUser

        ''' <summary>Displays all the users currently in jail.</summary>
        Public Sub Clear()
            LstJailed.Items.Clear()
            LstJailed.ClearSelected()
            lblFine.Text = ""
            lblReason.Text = ""

            For Each user As JailedUser In AllJailedUsers
                LstJailed.Items.Add(user.Name)
            Next

            BtnBailOut.Enabled = False
        End Sub

        Private Sub LstJailed_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstJailed.SelectedIndexChanged
            If LstJailed.SelectedIndex >= 0 Then
                _selectedJailedUser = AllJailedUsers.Find(Function(user) user.Name = LstJailed.SelectedItem.ToString())
                lblReason.Text = _selectedJailedUser.Reason.ToString()
                lblFine.Text = _selectedJailedUser.Fine.ToString("N0")
                BtnBailOut.Enabled = CurrentUser.GoldOnHand >= _selectedJailedUser.Fine
            End If
        End Sub

        Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
            Close()
        End Sub

        Private Async Sub BtnBailOut_Click(sender As Object, e As EventArgs) Handles BtnBailOut.Click
            If Await DatabaseInteraction.FreeFromJail(_selectedJailedUser) Then
                CurrentUser.GoldOnHand -= _selectedJailedUser.Fine
                AllUsers.Find(Function(user) user.Name = _selectedJailedUser.Name).CurrentLocation = SleepLocation.Streets
                Clear()
            End If
        End Sub

        Private Sub FrmJail_Load(sender As Object, e As EventArgs) Handles Me.Load
            Clear()
        End Sub

        Private Async Sub FrmJail_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
            FrmGame.Show()
            Await SaveUser(CurrentUser)
        End Sub

    End Class

End Namespace