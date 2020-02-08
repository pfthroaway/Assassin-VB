' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 05/25/2012
' Filename        : Game Form.vb
' Description     : This form contains most user information and links to other forms.

Option Strict On
Option Explicit On

Imports Assassin.Classes
Imports Assassin.Classes.Enums
Imports Assassin.Forms.GuildForms
Imports Assassin.Forms.Shopping
Imports Extensions

Namespace Forms

    Public Class FrmGame
        Dim jailTimeSpan As TimeSpan
        Dim jailedUser As JailedUser

        ''' <summary>Adds text to the TextBox.</summary>
        ''' <param name="newText">Text to be added</param>
        Public Sub AddText(newText As String)
            AddTextToTextBox(TxtGame, newText)
        End Sub

        ''' <summary>Displays the appropriate text when a user awakens.</summary>
        Public Async Sub Awaken()
            If CurrentUser.Alive Then
                Select Case CurrentUser.CurrentLocation
                    Case SleepLocation.Streets
                        Dim loseEnd As Integer = Functions.GenerateRandomNumber(1, 5)
                        AddText($"You awaken on the streets. After a rough night sleeping on the ground, you have lost {loseEnd} Endurance.")
                        CurrentUser.CurrentEndurance -= loseEnd
                        If CurrentUser.CurrentEndurance < 1 Then CurrentUser.CurrentEndurance = 1
                    Case SleepLocation.Jail
                        CheckJailed()
                        Exit Sub
                    Case SleepLocation.Inn
                        AddText("You awaken in the inn. You feel refreshed. You exit to the streets.")
                        CurrentUser.CurrentEndurance += 10
                    Case SleepLocation.Guild
                        AddText("You awaken in the guild. You exit to the streets.")
                End Select
            Else
                TxtGame.Text = "You were slain. You have been resurrected by the gods."
                CurrentUser.Alive = True
                CurrentUser.CurrentEndurance = 1
                Await SaveUser(CurrentUser)
            End If

            CurrentUser.CurrentLocation = SleepLocation.Streets

            Display()
        End Sub

        ''' <summary>Checks whether a jailed user has served their time.</summary>
        Public Async Sub CheckJailed()
            jailedUser = AllJailedUsers.Find(Function(user) user.Name = CurrentUser.Name)
            jailTimeSpan = Date.UtcNow - jailedUser.DateJailed
            If jailTimeSpan.Seconds >= jailedUser.Fine \ 10 Then
                AddText($"You awaken in a jail cell. A guard looms over you.{ControlChars.NewLine}He barks at you, ""You're free to go!""{ControlChars.NewLine}You briskly leave the jail.")
                Await DatabaseInteraction.FreeFromJail(jailedUser)
                CurrentUser.CurrentLocation = SleepLocation.Streets
                ToggleButtons(True)

                Display()

                Await SaveUser(CurrentUser)
            Else
                ToggleButtons(False)
                AddText($"You awaken in a jail cell. You have not yet finished your sentence. You have {jailedUser.Fine \ 10 - jailTimeSpan.Seconds} seconds remaining.")
                Timer1.Start()
            End If
        End Sub

        ''' <summary>Displays all the statistics of the character.</summary>
        Public Sub Display()
            LblName.Text = CurrentUser.Name
            LblRank.Text = CurrentUser.Rank
            LblExpAmt.Text = CurrentUser.Experience.ToString
            LblSkillPtsAmt.Text = CurrentUser.SkillPoints.ToString
            LblEndAmt.Text = CurrentUser.EnduranceToString

            LblHunger.Text = GetHunger(CurrentUser.Hunger)

            LblHunger.ForeColor = If(CurrentUser.Hunger < 20, Color.Black, Color.Red)

            LblThirst.Text = GetThirst(CurrentUser.Thirst)

            LblThirst.ForeColor = If(CurrentUser.Thirst < 20, Color.Black, Color.Red)

            LblWeaponName.Text = CurrentUser.CurrentWeapon.Name
            LblArmorName.Text = CurrentUser.Armor.Name
            LblPotion.Text = CurrentUser.Potion.Name
            LblGoldHandAmt.Text = CurrentUser.GoldOnHand.ToString("N0")
            LblGoldBankAmt.Text = CurrentUser.GoldInBank.ToString("N0")
            LblGoldLoanAmt.Text = CurrentUser.GoldOnLoan.ToString("N0")

            LblLightAmt.Text = CurrentUser.LightWeaponSkillToString
            LblHeavyAmt.Text = CurrentUser.HeavyWeaponSkillToString
            LblTwoAmt.Text = CurrentUser.TwoHandedWeaponSkillToString
            LblBlockingAmt.Text = CurrentUser.BlockingToString
            LblSlippingAmt.Text = CurrentUser.SlippingToString
            LblStealthAmt.Text = CurrentUser.StealthToString

            LblWeaponName.ForeColor = If(CurrentUser.CurrentWeapon.Name = "Hands", Color.Red, Color.Black)

            LblArmorName.ForeColor = If(CurrentUser.Armor.Name = "Clothes", Color.Red, Color.Black)

            LblEndAmt.ForeColor = If(CurrentUser.CurrentEndurance <= (CurrentUser.MaximumEndurance * 0.2), Color.Red, Color.Black)
        End Sub

        ''' <summary>Toggles all the Buttons on the Form.</summary>
        ''' <param name="enabled">Should the Buttons be enabled?</param>
        Public Sub ToggleButtons(enabled As Boolean)
            BtnAssassinate.Enabled = enabled
            BtnBank.Enabled = enabled
            BtnChapel.Enabled = enabled
            BtnGuild.Enabled = enabled
            BtnInn.Enabled = enabled
            BtnInventory.Enabled = enabled
            BtnJail.Enabled = enabled
            BtnMessages.Enabled = enabled
            BtnMystic.Enabled = enabled
            BtnOptions.Enabled = enabled
            BtnOthers.Enabled = enabled
            BtnPub.Enabled = enabled
            BtnRob.Enabled = enabled
            BtnShops.Enabled = enabled
            BtnTrain.Enabled = enabled
        End Sub

#Region "Click"

        Private Sub BtnAssassinate_Click(sender As Object, e As EventArgs) Handles BtnAssassinate.Click
            FrmAssassinate.Show()
            FrmAssassinate.NewEnemy()
            FrmAssassinate.CheckHungerThirst()
            Hide()
        End Sub

        Private Sub BtnBank_Click(sender As Object, e As EventArgs) Handles BtnBank.Click
            FrmBank.Show()
            FrmBank.Display()
            Hide()
        End Sub

        Private Async Sub BtnChapel_Click(sender As Object, e As EventArgs) Handles BtnChapel.Click
            If CurrentUser.CurrentEndurance <= (CurrentUser.MaximumEndurance * 0.2) Then 'if user has less than 20% health, the priest will heal them
                AddText("The priest welcomes you into his chapel. He sees your grievous injuries and blesses you. You have been healed!")
                CurrentUser.CurrentEndurance = CurrentUser.MaximumEndurance
                Display()
                Await SaveUser(CurrentUser)
            Else
                AddText("Sorry, the priest is currently holding mass. Please come again later.")
            End If
        End Sub

        Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
            Close()
        End Sub

        Private Sub BtnGuild_Click(sender As Object, e As EventArgs) Handles BtnGuild.Click
            FrmGuildList.Show()
            FrmGuildList.LblGoldOnHand.Text = CurrentUser.GoldOnHand.ToString("N0")
            Hide()
        End Sub

        Private Sub BtnInn_Click(sender As Object, e As EventArgs) Handles BtnInn.Click
            AddText("Sorry, that feature is currently unavailable.")
        End Sub

        Private Sub BtnInventory_Click(sender As Object, e As EventArgs) Handles BtnInventory.Click
            FrmInventory.Show()
            FrmInventory.Display()
            Hide()
        End Sub

        Private Sub BtnJail_Click(sender As Object, e As EventArgs) Handles BtnJail.Click
            FrmJail.Show()
        End Sub

        Private Async Sub BtnMessages_Click(sender As Object, e As EventArgs) Handles BtnMessages.Click
            FrmMessages.Show()
            Await FrmMessages.LoadMessages()
            FrmMessages.loc = "Streets"
            Hide()
        End Sub

        Private Sub BtnMystic_Click(sender As Object, e As EventArgs) Handles BtnMystic.Click
            AddText("Sorry, that feature is currently unavailable.")
        End Sub

        Private Sub BtnOptions_Click(sender As Object, e As EventArgs) Handles BtnOptions.Click
            FrmChangePassword.Show()
            Hide()
        End Sub

        Private Sub BtnOthers_Click(sender As Object, e As EventArgs) Handles BtnOthers.Click
            FrmMembers.Show()
            FrmMembers.loc = "Streets"
            FrmMembers.LoadMembers()
            Hide()
        End Sub

        Private Sub BtnPub_Click(sender As Object, e As EventArgs) Handles BtnPub.Click
            AddText("Sorry, that feature is currently unavailable.")
        End Sub

        Private Sub BtnRob_Click(sender As Object, e As EventArgs) Handles BtnRob.Click
            FrmRob.Show()
            FrmRob.LoadRobbery()
            Hide()
        End Sub

        Private Sub BtnShops_Click(sender As Object, e As EventArgs) Handles BtnShops.Click
            FrmShops.Show()
            FrmShops.TxtShops.Text = "You enter the shopping district."
            Hide()
        End Sub

        Private Sub BtnTrain_Click(sender As Object, e As EventArgs) Handles BtnTrain.Click
            FrmTrain.Show()
            FrmTrain.LoadUser()
            Hide()
        End Sub

#End Region

#Region "Form Manipulation"

        Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
            jailTimeSpan = Date.UtcNow - jailedUser.DateJailed
            If jailTimeSpan.Seconds >= jailedUser.Fine \ 10 Then
                CheckJailed()
                Timer1.Stop()
            End If
        End Sub

        Private Async Sub FrmGame_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
            Await SaveUser(CurrentUser)
            FrmMain.Show()
        End Sub

#End Region

    End Class

End Namespace