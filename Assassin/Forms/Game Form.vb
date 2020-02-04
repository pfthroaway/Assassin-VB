' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 05/25/2012
' Filename        : Game Form.vb
' Description     : This form contains most user information and links to other forms.

Option Strict On
Option Explicit On

Imports Assassin.Classes
Imports Assassin.Forms.GuildForms
Imports Assassin.Forms.Shopping
Imports Extensions

Namespace Forms

    Public Class FrmGame

        ''' <summary>Adds text to the TextBox.</summary>
        ''' <param name="newText">Text to be added</param>
        Public Sub AddText(newText As String)
            AddTextToTextBox(TxtGame, newText)
        End Sub

        ''' <summary>Displays the appropriate text when a user awakens.</summary>
        Public Async Sub Awaken()
            If CurrentUser.Alive Then  'if alive
                Select Case CurrentUser.CurrentLocation
                    Case "Streets"
                        Dim loseEnd As Integer = Functions.GenerateRandomNumber(1, 5)
                        TxtGame.Text = "You awaken on the streets. After a rough night sleeping on the ground, you have lost " & loseEnd & " Endurance."
                        CurrentUser.CurrentEndurance -= loseEnd
                        If CurrentUser.CurrentEndurance < 1 Then CurrentUser.CurrentEndurance = 1
                    Case "Jail"
                        CheckJailed()
                        Exit Sub
                    Case "Inn"
                        TxtGame.Text = "You awaken in the inn. You feel refreshed. You exit to the streets."
                        CurrentUser.CurrentEndurance += 10
                    Case "Guild"
                        TxtGame.Text = "You awaken in the guild. You exit to the streets."
                End Select
            Else                'if dead
                TxtGame.Text = "You were slain. You have been resurrected by the gods."
                CurrentUser.Alive = True           'set to alive
                CurrentUser.CurrentEndurance = 1            'set current endurance to 1
                Await SaveUser(CurrentUser)
            End If

            CurrentUser.CurrentLocation = "Streets"    'set location to streets

            Display()   'display all information
        End Sub

        ''' <summary>Checks whether a jailed user has served their time.</summary>
        Private Sub CheckJailed()
            'TODO Fix Check Jail Game Form

            '_sql = "SELECT * FROM Jail WHERE Username='" & CurrentUser.Name & "'"
            '_table = "Jail"
            'Ds = Await .FillDs(_sql, _table)

            'Dim dateJailed As DateTime
            'DateTime.TryParse(Ds.Tables(0).Rows(0).Item("DateJailed").ToString, dateJailed)
            'Dim ts As TimeSpan = Today - dateJailed
            'If ts.Days >= 1 Then
            '    _sql = "SELECT * FROM Jail WHERE Username='" & CurrentUser.Name & "'"
            '    .DeleteRecord(_sql, _table, Ds)
            '    AddText("You awaken in a jail cell. A guard looms over you. He barks at you, " & Chr(34) & "You're free to go!" & Chr(34) &
            '            " You briskly leave the jail.")

            '    CurrentUser.CurrentLocation = "Streets"
            '    EnableButtons()

            '    Display()

            '    SaveUser(CurrentUser)
            'Else
            '    DisableButtons()
            '    BtnJail.Enabled = True
            '    AddText("You awaken in a jail cell. You have not yet finished your sentence.")
            'End If
        End Sub

        ''' <summary>Disables the buttons if a user goes to jail.</summary>
        Public Sub DisableButtons()
            BtnAssassinate.Enabled = False
            BtnBank.Enabled = False
            BtnChapel.Enabled = False
            BtnGuild.Enabled = False
            BtnInn.Enabled = False
            BtnInventory.Enabled = False
            BtnJail.Enabled = False
            BtnMessages.Enabled = False
            BtnMystic.Enabled = False
            BtnOptions.Enabled = False
            BtnOthers.Enabled = False
            BtnPub.Enabled = False
            BtnRob.Enabled = False
            BtnShops.Enabled = False
            BtnTrain.Enabled = False
        End Sub

        ''' <summary>Displays all the statistics of the character.</summary>
        Public Sub Display()
            lblName.Text = CurrentUser.Name
            lblRank.Text = AllRanks(CurrentUser.Level - 1)
            lblExpAmt.Text = CurrentUser.Experience.ToString
            lblSkillPtsAmt.Text = CurrentUser.SkillPoints.ToString
            lblEndAmt.Text = CurrentUser.CurrentEndurance.ToString("N0") & " / " & CurrentUser.MaximumEndurance.ToString("N0")

            lblHunger.Text = GetHunger(CurrentUser.Hunger)

            lblHunger.ForeColor = If(CurrentUser.Hunger < 20, Color.Black, Color.Red)

            lblThirst.Text = GetThirst(CurrentUser.Thirst)

            lblThirst.ForeColor = If(CurrentUser.Thirst < 20, Color.Black, Color.Red)

            lblWeaponName.Text = CurrentUser.CurrentWeapon.Name
            lblArmorName.Text = CurrentUser.Armor.Name
            lblPotion.Text = CurrentUser.Potion.Name
            lblGoldHandAmt.Text = CurrentUser.GoldOnHand.ToString("N0")
            lblGoldBankAmt.Text = CurrentUser.GoldInBank.ToString("N0")
            lblGoldLoanAmt.Text = CurrentUser.GoldOnLoan.ToString("N0")

            lblLightAmt.Text = CurrentUser.LightWeaponSkill.ToString & "%"
            lblHeavyAmt.Text = CurrentUser.HeavyWeaponSkill.ToString & "%"
            lblTwoAmt.Text = CurrentUser.TwoHandedWeaponSkill.ToString & "%"
            lblBlockingAmt.Text = CurrentUser.Blocking.ToString & "%"
            lblSlippingAmt.Text = CurrentUser.Slipping.ToString & "%"
            lblStealthAmt.Text = CurrentUser.Stealth.ToString & "%"

            lblWeaponName.ForeColor = If(CurrentUser.CurrentWeapon.Name = "Hands", Color.Red, Color.Black)

            lblArmorName.ForeColor = If(CurrentUser.Armor.Name = "Clothes", Color.Red, Color.Black)

            lblEndAmt.ForeColor = If(CurrentUser.CurrentEndurance <= (CurrentUser.MaximumEndurance * 0.2), Color.Red, Color.Black)
        End Sub

        ''' <summary>Enables the buttons if a user exits jail.</summary>
        Private Sub EnableButtons()
            BtnAssassinate.Enabled = True
            BtnBank.Enabled = True
            BtnChapel.Enabled = True
            BtnGuild.Enabled = True
            BtnInn.Enabled = True
            BtnInventory.Enabled = True
            BtnJail.Enabled = True
            BtnMystic.Enabled = True
            BtnOthers.Enabled = True
            BtnPub.Enabled = True
            BtnRob.Enabled = True
            BtnShops.Enabled = True
            BtnTrain.Enabled = True
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
            FrmGuildList.lblGoldOnHand.Text = CurrentUser.GoldOnHand.ToString("N0")
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

        Private Sub BtnMessages_Click(sender As Object, e As EventArgs) Handles BtnMessages.Click
            FrmMessages.Show()
            FrmMessages.LoadMessages()
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
            FrmRob.TxtRob.Text = "You proceed to look for someone to rob."
            GetEnemy()
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

        Private Async Sub FrmGame_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
            Await SaveUser(CurrentUser)
            FrmMain.Show()
        End Sub

    End Class

End Namespace