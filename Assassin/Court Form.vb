' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 05/25/2012
' Filename        : Court Form.vb
' Description     : This form conducts the court activities after a player has been apprehended.

Public Class frmCourt
    Dim funcs As New Functions              'new Functions instance
    Public currUser As New User             'new user
    Public reason As String = ""            'reason for being sent to court
    Dim nl As String = ControlChars.NewLine 'new line
    Dim arrText As New ArrayList            'ArrayList of text
    Dim index As Integer = 0                'index for ArrayList
    Dim fine As Integer = 0                 'fine if found guilty
    Dim blnGuilty As Boolean = False        'boolean for being found guilty
    Dim blnFinished As Boolean = False      'boolean for being finished

    Public Sub addText(ByVal newText As String)
        '* * * * *
        '* This method adds text to the Textbox.
        '* * * * *

        Dim currText As String = txtCourt.Text
        txtCourt.Clear()

        txtCourt.Text = newText & nl & nl & currText
        txtCourt.Select(0, 0)
        txtCourt.ScrollToCaret()
    End Sub

    Public Sub display()
        '* * * * *
        '* This method displays text from the Arraylist.
        '* * * * *

        If index < arrText.Count Then
            addText(arrText(index))
            index += 1
            If index = arrText.Count Then
                Timer1.Stop()
                justice()
                arrText.Clear()
                index = 0
            End If
        End If
    End Sub

    Public Sub justice()
        '* * * * *
        '* This method administers justice!
        '* * * * *

        If blnGuilty = True Then
            If currUser.goldOnHand >= fine Then
                btnPayFine.Enabled = True
            End If
            btnJail.Enabled = True
        Else
            btnFreedom.Enabled = True
        End If
    End Sub

    Public Sub setup()
        '* * * * *
        '* This method sets up the court scenario.
        '* * * * *

        arrText.Add("You are dragged to the courts of justice.")
        arrText.Add("The judge stares at you. . .")
        If currUser.level > 6 Then
            arrText.Add(Chr(34) & "Well, if it isn't the " & funcs.getRank(currUser) & ", " & currUser.name & "." & Chr(34))
            arrText.Add(Chr(34) & "Don't worry, I will be impartial," & Chr(34) & " he laughs.")
        End If
        arrText.Add("The trial begins. . .")
        If reason = "Pickpocket" Then
            arrText.Add("You are charged with the crime of attempted theft of property.")
            fine = 50
        ElseIf reason = "Assault" Then
            arrText.Add("You are charged with the crime of attempted assault and robbery.")
            fine = 100
        ElseIf reason = "Assassinate" Then
            arrText.Add("You are charged with the crime of attempted murder.")
            fine = 250
        End If
        arrText.Add("Prosecution. . .")
        arrText.Add("Defense. . .")

        Dim guilty As Integer = funcs.random(1, 100)
        If guilty <= (100 - (currUser.level * 5)) Then  'not guilty
            arrText.Add("The judge finds you. . . innocent!")
        Else                                            'guilty
            arrText.Add("The judge finds you. . . guilty!")
            arrText.Add(Chr(34) & "You are to pay " & fine & " gold as a fine. Pay it, or you will be jailed for the night." & Chr(34))
            blnGuilty = True
        End If

        start()
    End Sub

    Public Sub start()
        '* * * * *
        '* This method starts the Timer.
        '* * * * *

        Timer1.Start()
    End Sub


    Private Sub btnFreedom_Click(sender As System.Object, e As System.EventArgs) Handles btnFreedom.Click
        '* * * * *
        '* This method displays a message and then the Game form.
        '* * * * *

        addText("You beat a hasty retreat and return to the streets.")
        blnFinished = True
        Me.Close()
    End Sub

    Private Sub btnJail_Click(sender As System.Object, e As System.EventArgs) Handles btnJail.Click
        '* * * * *
        '* This method sends the user to jail.
        '* * * * *

        If currUser.goldOnHand < fine Then
            addText("You don't have the money required to pay the fine.")
        Else
            addText("You decide it is best to spend the night in jail.")
        End If
        frmGame.disableButtons()
        frmGame.btnJail.Enabled = True
        currUser.currLoc = "Jail"
        blnFinished = True
        Me.Close()
    End Sub

    Private Sub btnPayFine_Click(sender As System.Object, e As System.EventArgs) Handles btnPayFine.Click
        '* * * * *
        '* This method pays the fine.
        '* * * * *

        addText("You decide it is best to pay the fine and depart.")
        currUser.goldOnHand -= fine
        blnFinished = True
        Me.Close()
    End Sub


    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        '* * * * *
        '* This method calls the display method on the Timer Tick.
        '* * * * *

        display()
    End Sub


    Private Sub frmCourt_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        '* * * * *
        '* This method closes the form.
        '* * * * *

        If blnFinished = True Then
            frmGame.Show()
            frmGame.currUser = currUser
            frmGame.display()
            frmGame.addText(txtCourt.Text)
            funcs.save(currUser)
        Else
            MessageBox.Show("You must make a decision first.", "Assassin", MessageBoxButtons.OK)
            e.Cancel = True
        End If
    End Sub
End Class