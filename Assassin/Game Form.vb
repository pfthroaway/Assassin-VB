' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 05/25/2012
' Filename        : Game Form.vb
' Description     : This form contains most user information and links to other forms.

Option Strict On
Option Explicit On

Public Class frmGame
    Dim funcs As New Functions              'new Functions instance
    Public currUser As New User             'current user
    Dim sql As String                       'SQL query
    Dim table As String                     'table name
    Public ds As New DataSet                'DataSet
    Dim nl As String = ControlChars.NewLine 'new line
    Dim currWeapon As New Weapon            'current weapon

    Public Sub addText(ByVal newText As String)
        '* * * * *
        '* This method adds text to the Textbox.
        '* * * * *

        Dim currText As String = txtGame.Text
        txtGame.Clear()

        txtGame.Text = newText & nl & nl & currText
        txtGame.Select(0, 0)
        txtGame.ScrollToCaret()
    End Sub

    Public Sub awaken()
        '* * * * *
        '* This method displays the appropriate text when a user awakens.
        '* * * * *

        If currUser.alive Then  'if alive
            Select Case currUser.currLoc
                Case "Streets"
                    Dim loseEnd As Integer = funcs.random(1, 5)
                    txtGame.Text = "You awaken on the streets. After a rough night sleeping on the ground, you have lost " & loseEnd & " Endurance."
                    currUser.currEnd -= loseEnd
                    If currUser.currEnd < 1 Then currUser.currEnd = 1
                Case "Jail"
                    checkjailed()
                    Exit Sub
                Case "Inn"
                    txtGame.Text = "You awaken in the inn. You feel refreshed. You exit to the streets."
                    currUser.currEnd += 10
                Case "Guild"
                    txtGame.Text = "You awaken in the guild. You exit to the streets."
            End Select
        Else                'if dead
            txtGame.Text = "You were slain. You have been resurrected by the gods."
            currUser.alive = True           'set to alive
            currUser.currEnd = 1            'set current endurance to 1
        End If

        currUser.currLoc = "Streets"    'set location to streets

        display()   'display all information
        funcs.save(currUser)      'save user

        txtGame.Select(0, 0)
        txtGame.ScrollToCaret()
    End Sub

    Private Sub checkjailed()
        '* * * * *
        '* This method checks whether a jailed user has served their time.
        '* * * * *

        sql = "SELECT * FROM Jail WHERE Username='" & currUser.name & "'"
        table = "Jail"
        ds = funcs.fillDS(sql, table)

        Dim dateJailed As DateTime
        DateTime.TryParse(ds.Tables("Jail").Rows(0).Item("DateJailed").ToString, dateJailed)
        Dim ts As TimeSpan = Today - dateJailed
        If ts.Days >= 1 Then
            sql = "SELECT * FROM Jail WHERE Username='" & currUser.name & "'"
            funcs.deleteRecord(sql, table, ds)
            addText("You awaken in a jail cell. A guard looms over you. He barks at you, " & Chr(34) & "You're free to go!" & Chr(34) & _
                    " You briskly leave the jail.")

            currUser.currLoc = "Streets"
            enableButtons()

            display()

            funcs.save(currUser)
        Else
            disableButtons()
            btnJail.Enabled = True
            addText("You awaken in a jail cell. You have not yet finished your sentence.")
        End If
    End Sub

    Public Sub disableButtons()
        '* * * * *
        '* This method disables the buttons if a user goes to jail.
        '* * * * *

        btnAssassinate.Enabled = False
        btnBank.Enabled = False
        btnChapel.Enabled = False
        btnGuild.Enabled = False
        btnInn.Enabled = False
        btnInventory.Enabled = False
        btnJail.Enabled = False
        btnMessages.Enabled = False
        btnMystic.Enabled = False
        btnOptions.Enabled = False
        btnOthers.Enabled = False
        btnPub.Enabled = False
        btnRob.Enabled = False
        btnShops.Enabled = False
        btnTrain.Enabled = False
    End Sub

    Public Sub display()
        '* * * * *
        '* This method displays all the statistics of the character.
        '* * * * *

        lblName.Text = currUser.name
        lblRank.Text = funcs.getRank(currUser)
        lblExpAmt.Text = currUser.exp.ToString
        lblSkillPtsAmt.Text = currUser.skillPts.ToString
        lblEndAmt.Text = currUser.currEnd.ToString("N0") & " / " & currUser.maxEnd.ToString("N0")

        lblHunger.Text = funcs.getHunger(currUser.hunger)

        If currUser.hunger < 20 Then
            lblHunger.ForeColor = Color.Black
        Else
            lblHunger.ForeColor = Color.Red
        End If

        lblThirst.Text = funcs.getThirst(currUser.thirst)

        If currUser.thirst < 20 Then
            lblThirst.ForeColor = Color.Black
        Else
            lblThirst.ForeColor = Color.Red
        End If

        If currUser.currWeapon = "Light" Then
            currWeapon = currUser.lightWeapon
        ElseIf currUser.currWeapon = "Heavy" Then
            currWeapon = currUser.heavyWeapon
        ElseIf currUser.currWeapon = "Two-H" Then
            currWeapon = currUser.twoHWeapon
        End If

        lblWeaponName.Text = currWeapon.name
        lblArmorName.Text = currUser.armor.name
        lblPotion.Text = currUser.potion
        lblGoldHandAmt.Text = currUser.goldOnHand.ToString("N0")
        lblGoldBankAmt.Text = currUser.goldInBank.ToString("N0")
        lblGoldLoanAmt.Text = currUser.goldOnLoan.ToString("N0")

        lblLightAmt.Text = currUser.lightWeaponSkill.ToString & "%"
        lblHeavyAmt.Text = currUser.heavyWeaponSkill.ToString & "%"
        lblTwoAmt.Text = currUser.twoHWeaponSkill.ToString & "%"
        lblBlockingAmt.Text = currUser.blocking.ToString & "%"
        lblSlippingAmt.Text = currUser.slipping.ToString & "%"
        lblStealthAmt.Text = currUser.stealth.ToString & "%"

        If currWeapon.name = "Hands" Then
            lblWeaponName.ForeColor = Color.Red
        Else
            lblWeaponName.ForeColor = Color.Black
        End If

        If currUser.armor.name = "Clothes" Then
            lblArmorName.ForeColor = Color.Red
        Else
            lblArmorName.ForeColor = Color.Black
        End If

        If currUser.currEnd <= (currUser.maxEnd * 0.2) Then
            lblEndAmt.ForeColor = Color.Red
        Else
            lblEndAmt.ForeColor = Color.Black
        End If
    End Sub

    Private Sub enableButtons()
        '* * * * *
        '* This method enables the buttons if a user exits jail.
        '* * * * *

        btnAssassinate.Enabled = True
        btnBank.Enabled = True
        btnChapel.Enabled = True
        btnGuild.Enabled = True
        btnInn.Enabled = True
        btnInventory.Enabled = True
        btnJail.Enabled = True
        btnMystic.Enabled = True
        btnOthers.Enabled = True
        btnPub.Enabled = True
        btnRob.Enabled = True
        btnShops.Enabled = True
        btnTrain.Enabled = True
    End Sub

    Public Sub loadUser()
        '* * * * *
        '* This method loads a user on first logging in.
        '* * * * *

        currUser.name = ds.Tables("User").Rows(0).Item("Username").ToString
        currUser.password = ds.Tables("User").Rows(0).Item("Pswd").ToString
        Integer.TryParse(ds.Tables("User").Rows(0).Item("UserLevel").ToString, currUser.level)
        Integer.TryParse(ds.Tables("User").Rows(0).Item("Exp").ToString, currUser.exp)
        Integer.TryParse(ds.Tables("User").Rows(0).Item("SkillPts").ToString, currUser.skillPts)
        Boolean.TryParse(ds.Tables("User").Rows(0).Item("Alive").ToString, currUser.alive)
        Integer.TryParse(ds.Tables("User").Rows(0).Item("CurrEnd").ToString, currUser.currEnd)
        currUser.currLoc = ds.Tables("User").Rows(0).Item("Location").ToString
        Integer.TryParse(ds.Tables("User").Rows(0).Item("MaxEnd").ToString, currUser.maxEnd)
        Integer.TryParse(ds.Tables("User").Rows(0).Item("Hunger").ToString, currUser.hunger)
        Integer.TryParse(ds.Tables("User").Rows(0).Item("Thirst").ToString, currUser.thirst)

        currUser.currWeapon = ds.Tables("User").Rows(0).Item("CurrWeapon").ToString
        currUser.lightWeapon = funcs.getWeapon(ds.Tables("User").Rows(0).Item("LightWeapon").ToString)
        currUser.heavyWeapon = funcs.getWeapon(ds.Tables("User").Rows(0).Item("HeavyWeapon").ToString)
        currUser.twoHWeapon = funcs.getWeapon(ds.Tables("User").Rows(0).Item("TwoHWeapon").ToString)
        currUser.armor = funcs.getArmor(ds.Tables("User").Rows(0).Item("Armor").ToString)

        currUser.potion = ds.Tables("User").Rows(0).Item("Potion").ToString
        Integer.TryParse(ds.Tables("User").Rows(0).Item("Lockpicks").ToString, currUser.lockpicks)
        Integer.TryParse(ds.Tables("User").Rows(0).Item("GoldOnHand").ToString, currUser.goldOnHand)
        Integer.TryParse(ds.Tables("User").Rows(0).Item("GoldInBank").ToString, currUser.goldInBank)
        Integer.TryParse(ds.Tables("User").Rows(0).Item("GoldOnLoan").ToString, currUser.goldOnLoan)

        Integer.TryParse(ds.Tables("User").Rows(0).Item("LightWeaponSkill").ToString, currUser.lightWeaponSkill)
        Integer.TryParse(ds.Tables("User").Rows(0).Item("HeavyWeaponSkill").ToString, currUser.heavyWeaponSkill)
        Integer.TryParse(ds.Tables("User").Rows(0).Item("TwoHWeaponSkill").ToString, currUser.twoHWeaponSkill)
        Integer.TryParse(ds.Tables("User").Rows(0).Item("Blocking").ToString, currUser.blocking)
        Integer.TryParse(ds.Tables("User").Rows(0).Item("Slipping").ToString, currUser.slipping)
        Integer.TryParse(ds.Tables("User").Rows(0).Item("Stealth").ToString, currUser.stealth)
        Integer.TryParse(ds.Tables("User").Rows(0).Item("Henchmen1").ToString, currUser.hench1)
        Integer.TryParse(ds.Tables("User").Rows(0).Item("Henchmen2").ToString, currUser.hench2)
        Integer.TryParse(ds.Tables("User").Rows(0).Item("Henchmen3").ToString, currUser.hench3)
        Integer.TryParse(ds.Tables("User").Rows(0).Item("Henchmen4").ToString, currUser.hench4)
        Integer.TryParse(ds.Tables("User").Rows(0).Item("Henchmen5").ToString, currUser.hench5)
    End Sub


    Private Sub btnAssassinate_Click(sender As System.Object, e As System.EventArgs) Handles btnAssassinate.Click
        '* * * * *
        '* This method displays the Assassination form.
        '* * * * *

        frmAssassinate.Show()
        frmAssassinate.currUser = currUser
        frmAssassinate.newEnemy()
        frmAssassinate.checkHungerThirst()
        Me.Hide()
    End Sub

    Private Sub btnBank_Click(sender As System.Object, e As System.EventArgs) Handles btnBank.Click
        '* * * * *
        '* This method displays the Bank form.
        '* * * * *

        frmBank.Show()
        frmBank.currUser = currUser
        frmBank.display()
        Me.Hide()
    End Sub

    Private Sub btnChapel_Click(sender As System.Object, e As System.EventArgs) Handles btnChapel.Click
        '* * * * *
        '* This method displays the Chapel information.
        '* * * * *

        If currUser.currEnd <= (currUser.maxEnd * 0.2) Then 'if user has less than 20% health, the priest will heal them
            addText("The priest welcomes you into his chapel. He sees your grievous injuries and blesses you. You have been healed!")
            currUser.currEnd = currUser.maxEnd
            display()
            funcs.save(currUser)
        Else
            addText("Sorry, the priest is currently holding mass. Please come again later.")
        End If
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        '* * * * *
        '* This method closes the form on clicking the Exit button.
        '* * * * *

        Me.Close()
    End Sub

    Private Sub btnGuild_Click(sender As System.Object, e As System.EventArgs) Handles btnGuild.Click '* * * * *
        '* This method displays the Guild form.
        '* * * * *

        frmGuildList.Show()
        frmGuildList.currUser = currUser
        frmGuildList.lblGoldOnHand.Text = currUser.goldOnHand.ToString("N0")
        Me.Hide()
    End Sub

    Private Sub btnInn_Click(sender As System.Object, e As System.EventArgs) Handles btnInn.Click
        '* * * * *
        '* This method displays the Inn form.
        '* * * * *

        addText("Sorry, that feature is currently unavailable.")
    End Sub

    Private Sub btnInventory_Click(sender As System.Object, e As System.EventArgs) Handles btnInventory.Click
        '* * * * *
        '* This method displays the Inventory form.
        '* * * * *

        frmInventory.Show()
        frmInventory.currUser = currUser
        frmInventory.display()
        Me.Hide()
    End Sub

    Private Sub btnJail_Click(sender As System.Object, e As System.EventArgs) Handles btnJail.Click
        '* * * * *
        '* This method displays the Jail form.
        '* * * * *

        frmJail.Show()
        frmJail.currUser = currUser
    End Sub

    Private Sub btnMessages_Click(sender As System.Object, e As System.EventArgs) Handles btnMessages.Click
        '* * * * *
        '* This method handles clicking the Messages button.
        '* * * * *

        frmMessages.Show()
        frmMessages.currUser = currUser
        frmMessages.loadMessages()
        frmMessages.loc = "Streets"
        Me.Hide()
    End Sub

    Private Sub btnMystic_Click(sender As System.Object, e As System.EventArgs) Handles btnMystic.Click
        '* * * * *
        '* This method displays the Mystic form.
        '* * * * *

        addText("Sorry, that feature is currently unavailable.")
    End Sub

    Private Sub btnOptions_Click(sender As System.Object, e As System.EventArgs) Handles btnOptions.Click
        '* * * * *
        '* This button displays the Options form.
        '* * * * *

        frmChangePassword.Show()
        frmChangePassword.currUser = currUser
        Me.Hide()
    End Sub

    Private Sub btnOthers_Click(sender As System.Object, e As System.EventArgs) Handles btnOthers.Click
        '* * * * *
        '* This method displays the Others form.
        '* * * * *

        frmMembers.Show()
        frmMembers.currUser = currUser
        frmMembers.loc = "Streets"
        frmMembers.loadMembers()
        Me.Hide()
    End Sub

    Private Sub btnPub_Click(sender As System.Object, e As System.EventArgs) Handles btnPub.Click
        '* * * * *
        '* This method displays the Pub form.
        '* * * * *

        addText("Sorry, that feature is currently unavailable.")
    End Sub

    Private Sub btnRob_Click(sender As System.Object, e As System.EventArgs) Handles btnRob.Click
        '* * * * *
        '* This method displays the Robbery form.
        '* * * * *

        frmRob.Show()
        frmRob.currUser = currUser
        frmRob.txtRob.Text = "You proceed to look for someone to rob."
        frmRob.getEnemy()
        Me.Hide()
    End Sub

    Private Sub btnShops_Click(sender As System.Object, e As System.EventArgs) Handles btnShops.Click
        '* * * * *
        '* This method displays the Shops form.
        '* * * * *

        frmShops.Show()
        frmShops.currUser = currUser
        frmShops.txtShops.Text = "You enter the shopping district."
        Me.Hide()
    End Sub

    Private Sub btnTrain_Click(sender As System.Object, e As System.EventArgs) Handles btnTrain.Click
        '* * * * *
        '* This method displays the Training form.
        '* * * * *

        frmTrain.Show()
        frmTrain.currUser = currUser
        frmTrain.loadUser()
        Me.Hide()
    End Sub


    Private Sub frmGame_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        '* * * * *
        '* This method shows the Main form on form closing.
        '* * * * *

        funcs.save(currUser)
        frmMain.Show()
    End Sub

End Class