Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

Namespace Forms.GuildForms
    <DesignerGenerated()> _
    Partial Class FrmGuild
        Inherits Form

        'Form overrides dispose to clean up the component list.
        <DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        'Required by the Windows Form Designer
        Private components As IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.txtGuild = New TextBox()
            Me.btnChallenge = New Button()
            Me.btnBack = New Button()
            Me.btnBar = New Button()
            Me.btnHire = New Button()
            Me.btnJobs = New Button()
            Me.btnMembers = New Button()
            Me.btnRaid = New Button()
            Me.btnSleep = New Button()
            Me.btnTransfer = New Button()
            Me.btnQuit = New Button()
            Me.btnManage = New Button()
            Me.lblGuildName = New Label()
            Me.btnDonate = New Button()
            Me.SuspendLayout()
            '
            'txtGuild
            '
            Me.txtGuild.BorderStyle = BorderStyle.FixedSingle
            Me.txtGuild.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.txtGuild.Location = New Point(13, 57)
            Me.txtGuild.Margin = New Padding(4)
            Me.txtGuild.Multiline = True
            Me.txtGuild.Name = "txtGuild"
            Me.txtGuild.ReadOnly = True
            Me.txtGuild.ScrollBars = ScrollBars.Vertical
            Me.txtGuild.Size = New Size(479, 100)
            Me.txtGuild.TabIndex = 0
            '
            'btnChallenge
            '
            Me.btnChallenge.Enabled = False
            Me.btnChallenge.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnChallenge.Location = New Point(15, 164)
            Me.btnChallenge.Name = "btnChallenge"
            Me.btnChallenge.Size = New Size(150, 66)
            Me.btnChallenge.TabIndex = 1
            Me.btnChallenge.Text = "&Challenge Guildmaster"
            Me.btnChallenge.UseVisualStyleBackColor = True
            '
            'btnBack
            '
            Me.btnBack.DialogResult = DialogResult.Cancel
            Me.btnBack.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnBack.Location = New Point(344, 308)
            Me.btnBack.Name = "btnBack"
            Me.btnBack.Size = New Size(150, 30)
            Me.btnBack.TabIndex = 13
            Me.btnBack.Text = "&Back"
            Me.btnBack.UseVisualStyleBackColor = True
            '
            'btnBar
            '
            Me.btnBar.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnBar.Location = New Point(15, 236)
            Me.btnBar.Name = "btnBar"
            Me.btnBar.Size = New Size(150, 30)
            Me.btnBar.TabIndex = 2
            Me.btnBar.Text = "&Bar"
            Me.btnBar.UseVisualStyleBackColor = True
            '
            'btnHire
            '
            Me.btnHire.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnHire.Location = New Point(15, 308)
            Me.btnHire.Name = "btnHire"
            Me.btnHire.Size = New Size(150, 30)
            Me.btnHire.TabIndex = 4
            Me.btnHire.Text = "&Hire Henchmen"
            Me.btnHire.UseVisualStyleBackColor = True
            '
            'btnJobs
            '
            Me.btnJobs.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnJobs.Location = New Point(180, 164)
            Me.btnJobs.Name = "btnJobs"
            Me.btnJobs.Size = New Size(150, 30)
            Me.btnJobs.TabIndex = 5
            Me.btnJobs.Text = "&Jobs"
            Me.btnJobs.UseVisualStyleBackColor = True
            '
            'btnMembers
            '
            Me.btnMembers.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnMembers.Location = New Point(180, 236)
            Me.btnMembers.Name = "btnMembers"
            Me.btnMembers.Size = New Size(150, 30)
            Me.btnMembers.TabIndex = 7
            Me.btnMembers.Text = "&Members"
            Me.btnMembers.UseVisualStyleBackColor = True
            '
            'btnRaid
            '
            Me.btnRaid.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnRaid.Location = New Point(180, 272)
            Me.btnRaid.Name = "btnRaid"
            Me.btnRaid.Size = New Size(150, 30)
            Me.btnRaid.TabIndex = 9
            Me.btnRaid.Text = "Plan a &Raid"
            Me.btnRaid.UseVisualStyleBackColor = True
            '
            'btnSleep
            '
            Me.btnSleep.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnSleep.Location = New Point(344, 164)
            Me.btnSleep.Name = "btnSleep"
            Me.btnSleep.Size = New Size(150, 30)
            Me.btnSleep.TabIndex = 11
            Me.btnSleep.Text = "&Sleep Here"
            Me.btnSleep.UseVisualStyleBackColor = True
            '
            'btnTransfer
            '
            Me.btnTransfer.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnTransfer.Location = New Point(342, 200)
            Me.btnTransfer.Name = "btnTransfer"
            Me.btnTransfer.Size = New Size(150, 30)
            Me.btnTransfer.TabIndex = 12
            Me.btnTransfer.Text = "&Transfer Items"
            Me.btnTransfer.UseVisualStyleBackColor = True
            '
            'btnQuit
            '
            Me.btnQuit.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnQuit.Location = New Point(180, 308)
            Me.btnQuit.Name = "btnQuit"
            Me.btnQuit.Size = New Size(150, 30)
            Me.btnQuit.TabIndex = 10
            Me.btnQuit.Text = "&Quit Guild"
            Me.btnQuit.UseVisualStyleBackColor = True
            '
            'btnManage
            '
            Me.btnManage.Enabled = False
            Me.btnManage.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnManage.Location = New Point(180, 200)
            Me.btnManage.Name = "btnManage"
            Me.btnManage.Size = New Size(150, 30)
            Me.btnManage.TabIndex = 6
            Me.btnManage.Text = "Manage &Guild"
            Me.btnManage.UseVisualStyleBackColor = True
            '
            'lblGuildName
            '
            Me.lblGuildName.Font = New Font("Arial", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblGuildName.Location = New Point(15, 13)
            Me.lblGuildName.Name = "lblGuildName"
            Me.lblGuildName.Size = New Size(477, 40)
            Me.lblGuildName.TabIndex = 14
            Me.lblGuildName.Text = "Guild Name Here"
            Me.lblGuildName.TextAlign = ContentAlignment.MiddleCenter
            '
            'btnDonate
            '
            Me.btnDonate.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnDonate.Location = New Point(15, 272)
            Me.btnDonate.Name = "btnDonate"
            Me.btnDonate.Size = New Size(150, 30)
            Me.btnDonate.TabIndex = 3
            Me.btnDonate.Text = "&Donate to Guild"
            Me.btnDonate.UseVisualStyleBackColor = True
            '
            'frmGuild
            '
            Me.AutoScaleDimensions = New SizeF(9.0!, 18.0!)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.CancelButton = Me.btnBack
            Me.ClientSize = New Size(510, 349)
            Me.Controls.Add(Me.btnDonate)
            Me.Controls.Add(Me.lblGuildName)
            Me.Controls.Add(Me.btnManage)
            Me.Controls.Add(Me.btnQuit)
            Me.Controls.Add(Me.btnTransfer)
            Me.Controls.Add(Me.btnSleep)
            Me.Controls.Add(Me.btnRaid)
            Me.Controls.Add(Me.btnMembers)
            Me.Controls.Add(Me.btnJobs)
            Me.Controls.Add(Me.btnHire)
            Me.Controls.Add(Me.btnBar)
            Me.Controls.Add(Me.btnBack)
            Me.Controls.Add(Me.btnChallenge)
            Me.Controls.Add(Me.txtGuild)
            Me.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Margin = New Padding(4)
            Me.MaximizeBox = False
            Me.MaximumSize = New Size(526, 388)
            Me.MinimumSize = New Size(526, 388)
            Me.Name = "frmGuild"
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.Text = "Guild"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents TxtGuild As TextBox
        Friend WithEvents BtnChallenge As Button
        Friend WithEvents BtnBack As Button
        Friend WithEvents BtnBar As Button
        Friend WithEvents BtnHire As Button
        Friend WithEvents BtnJobs As Button
        Friend WithEvents BtnMembers As Button
        Friend WithEvents BtnRaid As Button
        Friend WithEvents BtnSleep As Button
        Friend WithEvents BtnTransfer As Button
        Friend WithEvents BtnQuit As Button
        Friend WithEvents BtnManage As Button
        Friend WithEvents lblGuildName As Label
        Friend WithEvents BtnDonate As Button
    End Class
End NameSpace