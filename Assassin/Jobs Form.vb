' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 05/25/2012
' Filename        : Jobs Form.vb
' Description     : This form allows job opportunities.

Option Explicit On
Option Strict On

Public Class frmJobs
    Dim funcs As New Functions              'new Functions instance
    Public currUser As New User             'current User
    Private employers As New ArrayList      'employers Arraylist    
    Dim currEnemy As New Enemy              'current enemy
    Public arrText As New ArrayList         'ArrayList of text to be added
    Dim nl As String = ControlChars.NewLine 'new line
    Dim index As Integer                    'index in employers ArrayList
    Dim currEmployer As String              'current employer name
    Dim bounty As Integer                   'bounty
    Dim blnDone As Boolean = False          'done?

    Public Sub addText(ByVal newText As String)
        '* * * * *
        '* This method adds text to the Textbox.
        '* * * * *

        Dim currText As String = txtJobs.Text
        txtJobs.Clear()

        txtJobs.Text = newText & nl & nl & currText
        txtJobs.Select(0, 0)
        txtJobs.ScrollToCaret()
    End Sub

    Public Sub checkHungerThirst()
        '* * * * *
        '* This method checks a user's hunger and thirst.
        '* * * * *

        If currUser.hunger >= 24 OrElse currUser.thirst >= 24 Then
            btnAccept.Enabled = False
            btnDecline.Enabled = False

            If currUser.hunger >= 24 AndAlso currUser.thirst >= 24 Then
                addText("You are too hungry and thirsty to continue.")
            ElseIf currUser.hunger >= 24 Then
                addText("You are too hungry to continue.")
            ElseIf currUser.thirst >= 24 Then
                addText("You are too thirsty to continue.")
            End If
        Else
            If currUser.hunger > 0 AndAlso currUser.hunger Mod 5 = 0 Then
                addText("You are " & funcs.getHunger(currUser.hunger).ToLower & ".")
            End If
            If currUser.thirst > 0 AndAlso currUser.thirst Mod 5 = 0 Then
                addText("You are " & funcs.getThirst(currUser.thirst).ToLower & ".")
            End If
        End If
    End Sub

    Private Sub cycleText()
        '* * * * *
        '* This method cycles the text in the ArrayList on the Timer's tick.
        '* * * * *

        addText(arrText(index).ToString)
        index += 1

        If index = arrText.Count Then
            If blnDone = False Then
                enableButtons()
                Timer1.Stop()
                index = 0
                arrText.Clear()
            Else
                btnLeave.Enabled = True
                Timer1.Stop()
                index = 0
                arrText.Clear()
            End If
        End If
    End Sub

    Public Sub disableButtons()
        '* * * * *
        '* This method disabled the buttons on the form
        '* * * * *

        btnAccept.Enabled = False
        btnDecline.Enabled = False
        btnLeave.Enabled = False
    End Sub

    Private Sub enableButtons()
        '* * * * *
        '* This method enables the buttons on the form
        '* * * * *

        btnAccept.Enabled = True
        btnDecline.Enabled = True
        btnLeave.Enabled = True
    End Sub

    Private Sub getEmployers()
        '* * * * *
        '* This method fills the employers Arraylist with employers.
        '* * * * *

        employers.Add("A youthful man")
        employers.Add("A middle-aged man")
        employers.Add("An old man")
        employers.Add("A youthful woman")
        employers.Add("A middle-aged woman")
        employers.Add("An old woman")
    End Sub

    Private Sub getJob()
        '* * * * *
        '* This method gets a job opportunity from an employer.
        '* * * * *

        disableButtons()
        Dim employer As Integer = funcs.random(0, 5)
        currEmployer = employers(employer).ToString
        arrText.Add(currEmployer & " approaches you.")
        currEnemy = funcs.getEnemy(currUser)
        bounty = funcs.random(currEnemy.currEnd, currEnemy.currEnd * 2)
        arrText.Add(Chr(34) & "Greetings, " & funcs.getRank(currUser) & "." & nl & _
                    "I have an opportunity for you." & nl & _
                    "It concerns the elimination of a " & currEnemy.name & "." & nl & _
                    "I will pay you " & bounty & " gold." & nl & _
                    "Are you interested?" & Chr(34))

        Timer1.Start()
    End Sub

    Public Sub getPaid()
        '* * * * *
        '* This method handles getting paid.
        '* * * * *

        disableButtons()
        arrText.Add("The " & currEmployer.Substring(currEmployer.IndexOf(" ") + 1) & " welcomes your return." & nl & _
                Chr(34) & "Well done. Here is your payment." & Chr(34) & nl & _
                "You are handed " & bounty & " gold.")
        currUser.goldOnHand += bounty

        blnDone = True

        Timer1.Start()

        funcs.save(currUser)
    End Sub

    Public Sub loadJobs()
        '* * * * *
        '* This method loads everything needed for the Jobs form.
        '* * * * *

        txtJobs.ScrollToCaret()
        getEmployers()
        getJob()
    End Sub


    Private Sub btnAccept_Click(sender As System.Object, e As System.EventArgs) Handles btnAccept.Click
        '* * * * *
        '* This method accepts the job.
        '* * * * *

        currUser.hunger += 1
        currUser.thirst += 1
        frmBattle.Show()
        frmBattle.currUser = currUser
        frmBattle.currEnemy = currEnemy
        frmBattle.setPlayer()
        frmBattle.setEnemy()
        frmBattle.surprise()
        If frmBattle.txtBattle.TextLength = 0 Then frmBattle.txtBattle.Text = "You stalk your opponent."
        frmBattle.display()
        frmBattle.blnJob = True
        Me.Hide()
    End Sub

    Private Sub btnDecline_Click(sender As System.Object, e As System.EventArgs) Handles btnDecline.Click
        '* * * * *
        '* This method declines the job.
        '* * * * *

        currUser.hunger += 1
        currUser.thirst += 1
        getJob()
        checkHungerThirst()
    End Sub

    Private Sub btnLeave_Click(sender As System.Object, e As System.EventArgs) Handles btnLeave.Click
        '* * * * *
        '* This method leaves the table.
        '* * * * *

        Me.Close()
    End Sub


    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        '* * * * *
        '* This method handles what happens on the timer's tick.
        '* * * * *

        cycleText()
    End Sub


    Private Sub frmJobs_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        '* * * * * 
        '* This method handles closing the form.
        '* * * * *

        frmGuild.Show()
        frmGuild.currUser = currUser
        frmGuild.addText(txtJobs.Text)
    End Sub
End Class