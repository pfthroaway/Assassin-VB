<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGuild
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtGuild = New System.Windows.Forms.TextBox()
        Me.btnChallenge = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnBar = New System.Windows.Forms.Button()
        Me.btnHire = New System.Windows.Forms.Button()
        Me.btnJobs = New System.Windows.Forms.Button()
        Me.btnMembers = New System.Windows.Forms.Button()
        Me.btnRaid = New System.Windows.Forms.Button()
        Me.btnSleep = New System.Windows.Forms.Button()
        Me.btnTransfer = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnManage = New System.Windows.Forms.Button()
        Me.lblGuildName = New System.Windows.Forms.Label()
        Me.btnDonate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtGuild
        '
        Me.txtGuild.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGuild.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuild.Location = New System.Drawing.Point(13, 57)
        Me.txtGuild.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGuild.Multiline = True
        Me.txtGuild.Name = "txtGuild"
        Me.txtGuild.ReadOnly = True
        Me.txtGuild.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtGuild.Size = New System.Drawing.Size(479, 100)
        Me.txtGuild.TabIndex = 0
        '
        'btnChallenge
        '
        Me.btnChallenge.Enabled = False
        Me.btnChallenge.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChallenge.Location = New System.Drawing.Point(15, 164)
        Me.btnChallenge.Name = "btnChallenge"
        Me.btnChallenge.Size = New System.Drawing.Size(150, 66)
        Me.btnChallenge.TabIndex = 1
        Me.btnChallenge.Text = "&Challenge Guildmaster"
        Me.btnChallenge.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBack.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(344, 308)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(150, 30)
        Me.btnBack.TabIndex = 13
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnBar
        '
        Me.btnBar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBar.Location = New System.Drawing.Point(15, 236)
        Me.btnBar.Name = "btnBar"
        Me.btnBar.Size = New System.Drawing.Size(150, 30)
        Me.btnBar.TabIndex = 2
        Me.btnBar.Text = "&Bar"
        Me.btnBar.UseVisualStyleBackColor = True
        '
        'btnHire
        '
        Me.btnHire.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHire.Location = New System.Drawing.Point(15, 308)
        Me.btnHire.Name = "btnHire"
        Me.btnHire.Size = New System.Drawing.Size(150, 30)
        Me.btnHire.TabIndex = 4
        Me.btnHire.Text = "&Hire Henchmen"
        Me.btnHire.UseVisualStyleBackColor = True
        '
        'btnJobs
        '
        Me.btnJobs.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJobs.Location = New System.Drawing.Point(180, 164)
        Me.btnJobs.Name = "btnJobs"
        Me.btnJobs.Size = New System.Drawing.Size(150, 30)
        Me.btnJobs.TabIndex = 5
        Me.btnJobs.Text = "&Jobs"
        Me.btnJobs.UseVisualStyleBackColor = True
        '
        'btnMembers
        '
        Me.btnMembers.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMembers.Location = New System.Drawing.Point(180, 236)
        Me.btnMembers.Name = "btnMembers"
        Me.btnMembers.Size = New System.Drawing.Size(150, 30)
        Me.btnMembers.TabIndex = 7
        Me.btnMembers.Text = "&Members"
        Me.btnMembers.UseVisualStyleBackColor = True
        '
        'btnRaid
        '
        Me.btnRaid.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRaid.Location = New System.Drawing.Point(180, 272)
        Me.btnRaid.Name = "btnRaid"
        Me.btnRaid.Size = New System.Drawing.Size(150, 30)
        Me.btnRaid.TabIndex = 9
        Me.btnRaid.Text = "Plan a &Raid"
        Me.btnRaid.UseVisualStyleBackColor = True
        '
        'btnSleep
        '
        Me.btnSleep.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSleep.Location = New System.Drawing.Point(344, 164)
        Me.btnSleep.Name = "btnSleep"
        Me.btnSleep.Size = New System.Drawing.Size(150, 30)
        Me.btnSleep.TabIndex = 11
        Me.btnSleep.Text = "&Sleep Here"
        Me.btnSleep.UseVisualStyleBackColor = True
        '
        'btnTransfer
        '
        Me.btnTransfer.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransfer.Location = New System.Drawing.Point(342, 200)
        Me.btnTransfer.Name = "btnTransfer"
        Me.btnTransfer.Size = New System.Drawing.Size(150, 30)
        Me.btnTransfer.TabIndex = 12
        Me.btnTransfer.Text = "&Transfer Items"
        Me.btnTransfer.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.Location = New System.Drawing.Point(180, 308)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(150, 30)
        Me.btnQuit.TabIndex = 10
        Me.btnQuit.Text = "&Quit Guild"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'btnManage
        '
        Me.btnManage.Enabled = False
        Me.btnManage.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManage.Location = New System.Drawing.Point(180, 200)
        Me.btnManage.Name = "btnManage"
        Me.btnManage.Size = New System.Drawing.Size(150, 30)
        Me.btnManage.TabIndex = 6
        Me.btnManage.Text = "Manage &Guild"
        Me.btnManage.UseVisualStyleBackColor = True
        '
        'lblGuildName
        '
        Me.lblGuildName.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuildName.Location = New System.Drawing.Point(15, 13)
        Me.lblGuildName.Name = "lblGuildName"
        Me.lblGuildName.Size = New System.Drawing.Size(477, 40)
        Me.lblGuildName.TabIndex = 14
        Me.lblGuildName.Text = "Guild Name Here"
        Me.lblGuildName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnDonate
        '
        Me.btnDonate.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDonate.Location = New System.Drawing.Point(15, 272)
        Me.btnDonate.Name = "btnDonate"
        Me.btnDonate.Size = New System.Drawing.Size(150, 30)
        Me.btnDonate.TabIndex = 3
        Me.btnDonate.Text = "&Donate to Guild"
        Me.btnDonate.UseVisualStyleBackColor = True
        '
        'frmGuild
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnBack
        Me.ClientSize = New System.Drawing.Size(510, 349)
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
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(526, 388)
        Me.MinimumSize = New System.Drawing.Size(526, 388)
        Me.Name = "frmGuild"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Guild"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtGuild As System.Windows.Forms.TextBox
    Friend WithEvents btnChallenge As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnBar As System.Windows.Forms.Button
    Friend WithEvents btnHire As System.Windows.Forms.Button
    Friend WithEvents btnJobs As System.Windows.Forms.Button
    Friend WithEvents btnMembers As System.Windows.Forms.Button
    Friend WithEvents btnRaid As System.Windows.Forms.Button
    Friend WithEvents btnSleep As System.Windows.Forms.Button
    Friend WithEvents btnTransfer As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents btnManage As System.Windows.Forms.Button
    Friend WithEvents lblGuildName As System.Windows.Forms.Label
    Friend WithEvents btnDonate As System.Windows.Forms.Button
End Class
