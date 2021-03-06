﻿Option Strict On
Option Explicit On

Imports Assassin.Classes
Imports Assassin.Classes.Entities
Imports Assassin.Classes.Enums

Namespace Forms

    Public Class FrmJail
        'TODO Fix Jail Form where users are still displayed after exiting jail.
        'TODO Fix Jail Form where you can bail out someone who's no longer in jail.
        'TODO Fix Jail Form where bailing out actually works and updates the display.
        Dim _selectedJailedUser As JailedUser

        ''' <summary>Displays all the users currently in jail.</summary>
        Public Sub Clear()
            LstJailed.Items.Clear()
            LstJailed.ClearSelected()
            LblFine.Text = ""
            LblReason.Text = ""

            For Each user As JailedUser In AllJailedUsers
                LstJailed.Items.Add(user.Name)
            Next

            BtnBailOut.Enabled = False
        End Sub

#Region "Click"

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

        Private Sub LstJailed_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstJailed.SelectedIndexChanged
            If LstJailed.SelectedIndex >= 0 Then
                _selectedJailedUser = AllJailedUsers.Find(Function(user) user.Name = LstJailed.SelectedItem.ToString())
                LblReason.Text = _selectedJailedUser.Reason.ToString()
                LblFine.Text = _selectedJailedUser.Fine.ToString("N0")
                BtnBailOut.Enabled = CurrentUser.GoldOnHand >= _selectedJailedUser.Fine
            End If
        End Sub

#End Region

        Private Sub FrmJail_Load(sender As Object, e As EventArgs) Handles Me.Load
            Clear()
        End Sub

        Private Async Sub FrmJail_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
            FrmGame.Show()
            Await SaveUser(CurrentUser)
        End Sub

    End Class

End Namespace