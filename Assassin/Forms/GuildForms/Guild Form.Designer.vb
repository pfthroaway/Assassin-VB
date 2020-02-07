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
            Me.TxtGuild = New System.Windows.Forms.TextBox()
            Me.BtnChallenge = New System.Windows.Forms.Button()
            Me.BtnBack = New System.Windows.Forms.Button()
            Me.BtnBar = New System.Windows.Forms.Button()
            Me.BtnHire = New System.Windows.Forms.Button()
            Me.BtnJobs = New System.Windows.Forms.Button()
            Me.BtnMembers = New System.Windows.Forms.Button()
            Me.BtnRaid = New System.Windows.Forms.Button()
            Me.BtnSleep = New System.Windows.Forms.Button()
            Me.BtnTransfer = New System.Windows.Forms.Button()
            Me.BtnQuit = New System.Windows.Forms.Button()
            Me.BtnManage = New System.Windows.Forms.Button()
            Me.LblGuildName = New System.Windows.Forms.Label()
            Me.BtnDonate = New System.Windows.Forms.Button()
            Me.SuspendLayout()
            '
            'TxtGuild
            '
            Me.TxtGuild.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.TxtGuild.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TxtGuild.Location = New System.Drawing.Point(13, 57)
            Me.TxtGuild.Margin = New System.Windows.Forms.Padding(4)
            Me.TxtGuild.Multiline = True
            Me.TxtGuild.Name = "TxtGuild"
            Me.TxtGuild.ReadOnly = True
            Me.TxtGuild.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.TxtGuild.Size = New System.Drawing.Size(479, 100)
            Me.TxtGuild.TabIndex = 0
            '
            'BtnChallenge
            '
            Me.BtnChallenge.Enabled = False
            Me.BtnChallenge.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnChallenge.Location = New System.Drawing.Point(15, 164)
            Me.BtnChallenge.Name = "BtnChallenge"
            Me.BtnChallenge.Size = New System.Drawing.Size(150, 66)
            Me.BtnChallenge.TabIndex = 1
            Me.BtnChallenge.Text = "&Challenge Guildmaster"
            Me.BtnChallenge.UseVisualStyleBackColor = True
            '
            'BtnBack
            '
            Me.BtnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.BtnBack.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnBack.Location = New System.Drawing.Point(344, 308)
            Me.BtnBack.Name = "BtnBack"
            Me.BtnBack.Size = New System.Drawing.Size(150, 30)
            Me.BtnBack.TabIndex = 13
            Me.BtnBack.Text = "&Back"
            Me.BtnBack.UseVisualStyleBackColor = True
            '
            'BtnBar
            '
            Me.BtnBar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnBar.Location = New System.Drawing.Point(15, 236)
            Me.BtnBar.Name = "BtnBar"
            Me.BtnBar.Size = New System.Drawing.Size(150, 30)
            Me.BtnBar.TabIndex = 2
            Me.BtnBar.Text = "&Bar"
            Me.BtnBar.UseVisualStyleBackColor = True
            '
            'BtnHire
            '
            Me.BtnHire.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnHire.Location = New System.Drawing.Point(15, 308)
            Me.BtnHire.Name = "BtnHire"
            Me.BtnHire.Size = New System.Drawing.Size(150, 30)
            Me.BtnHire.TabIndex = 4
            Me.BtnHire.Text = "&Hire Henchmen"
            Me.BtnHire.UseVisualStyleBackColor = True
            '
            'BtnJobs
            '
            Me.BtnJobs.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnJobs.Location = New System.Drawing.Point(180, 164)
            Me.BtnJobs.Name = "BtnJobs"
            Me.BtnJobs.Size = New System.Drawing.Size(150, 30)
            Me.BtnJobs.TabIndex = 5
            Me.BtnJobs.Text = "&Jobs"
            Me.BtnJobs.UseVisualStyleBackColor = True
            '
            'BtnMembers
            '
            Me.BtnMembers.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnMembers.Location = New System.Drawing.Point(180, 236)
            Me.BtnMembers.Name = "BtnMembers"
            Me.BtnMembers.Size = New System.Drawing.Size(150, 30)
            Me.BtnMembers.TabIndex = 7
            Me.BtnMembers.Text = "&Members"
            Me.BtnMembers.UseVisualStyleBackColor = True
            '
            'BtnRaid
            '
            Me.BtnRaid.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnRaid.Location = New System.Drawing.Point(180, 272)
            Me.BtnRaid.Name = "BtnRaid"
            Me.BtnRaid.Size = New System.Drawing.Size(150, 30)
            Me.BtnRaid.TabIndex = 9
            Me.BtnRaid.Text = "Plan a &Raid"
            Me.BtnRaid.UseVisualStyleBackColor = True
            '
            'BtnSleep
            '
            Me.BtnSleep.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnSleep.Location = New System.Drawing.Point(344, 164)
            Me.BtnSleep.Name = "BtnSleep"
            Me.BtnSleep.Size = New System.Drawing.Size(150, 30)
            Me.BtnSleep.TabIndex = 11
            Me.BtnSleep.Text = "&Sleep Here"
            Me.BtnSleep.UseVisualStyleBackColor = True
            '
            'BtnTransfer
            '
            Me.BtnTransfer.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnTransfer.Location = New System.Drawing.Point(342, 200)
            Me.BtnTransfer.Name = "BtnTransfer"
            Me.BtnTransfer.Size = New System.Drawing.Size(150, 30)
            Me.BtnTransfer.TabIndex = 12
            Me.BtnTransfer.Text = "&Transfer Items"
            Me.BtnTransfer.UseVisualStyleBackColor = True
            '
            'BtnQuit
            '
            Me.BtnQuit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnQuit.Location = New System.Drawing.Point(180, 308)
            Me.BtnQuit.Name = "BtnQuit"
            Me.BtnQuit.Size = New System.Drawing.Size(150, 30)
            Me.BtnQuit.TabIndex = 10
            Me.BtnQuit.Text = "&Quit Guild"
            Me.BtnQuit.UseVisualStyleBackColor = True
            '
            'BtnManage
            '
            Me.BtnManage.Enabled = False
            Me.BtnManage.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnManage.Location = New System.Drawing.Point(180, 200)
            Me.BtnManage.Name = "BtnManage"
            Me.BtnManage.Size = New System.Drawing.Size(150, 30)
            Me.BtnManage.TabIndex = 6
            Me.BtnManage.Text = "Manage &Guild"
            Me.BtnManage.UseVisualStyleBackColor = True
            '
            'LblGuildName
            '
            Me.LblGuildName.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblGuildName.Location = New System.Drawing.Point(15, 13)
            Me.LblGuildName.Name = "LblGuildName"
            Me.LblGuildName.Size = New System.Drawing.Size(477, 40)
            Me.LblGuildName.TabIndex = 14
            Me.LblGuildName.Text = "Guild Name Here"
            Me.LblGuildName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'BtnDonate
            '
            Me.BtnDonate.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnDonate.Location = New System.Drawing.Point(15, 272)
            Me.BtnDonate.Name = "BtnDonate"
            Me.BtnDonate.Size = New System.Drawing.Size(150, 30)
            Me.BtnDonate.TabIndex = 3
            Me.BtnDonate.Text = "&Donate to Guild"
            Me.BtnDonate.UseVisualStyleBackColor = True
            '
            'FrmGuild
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.BtnBack
            Me.ClientSize = New System.Drawing.Size(510, 349)
            Me.Controls.Add(Me.BtnDonate)
            Me.Controls.Add(Me.LblGuildName)
            Me.Controls.Add(Me.BtnManage)
            Me.Controls.Add(Me.BtnQuit)
            Me.Controls.Add(Me.BtnTransfer)
            Me.Controls.Add(Me.BtnSleep)
            Me.Controls.Add(Me.BtnRaid)
            Me.Controls.Add(Me.BtnMembers)
            Me.Controls.Add(Me.BtnJobs)
            Me.Controls.Add(Me.BtnHire)
            Me.Controls.Add(Me.BtnBar)
            Me.Controls.Add(Me.BtnBack)
            Me.Controls.Add(Me.BtnChallenge)
            Me.Controls.Add(Me.TxtGuild)
            Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Margin = New System.Windows.Forms.Padding(4)
            Me.MaximizeBox = False
            Me.MaximumSize = New System.Drawing.Size(526, 388)
            Me.MinimumSize = New System.Drawing.Size(526, 388)
            Me.Name = "FrmGuild"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
        Friend WithEvents LblGuildName As Label
        Friend WithEvents BtnDonate As Button
    End Class
End NameSpace