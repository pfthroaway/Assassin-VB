Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

Namespace Forms.GuildForms
    <DesignerGenerated()> _
    Partial Class FrmGuildList
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
            Me.LstGuilds = New ListBox()
            Me.txtGuilds = New TextBox()
            Me.BtnEnter = New Button()
            Me.BtnApply = New Button()
            Me.BtnBack = New Button()
            Me.LblGoldOnHand = New Label()
            Me.Label4 = New Label()
            Me.LblGuildGold = New Label()
            Me.Label6 = New Label()
            Me.Label7 = New Label()
            Me.Label8 = New Label()
            Me.Label9 = New Label()
            Me.Label10 = New Label()
            Me.Label11 = New Label()
            Me.LblHenchmenLevel1 = New Label()
            Me.LblHenchmenLevel2 = New Label()
            Me.LblHenchmenLevel3 = New Label()
            Me.LblHenchmenLevel4 = New Label()
            Me.LblHenchmenLevel5 = New Label()
            Me.Label2 = New Label()
            Me.LblGuildmaster = New Label()
            Me.LblFee = New Label()
            Me.Label5 = New Label()
            Me.SuspendLayout()
            '
            'LstGuilds
            '
            Me.LstGuilds.FormattingEnabled = True
            Me.LstGuilds.ItemHeight = 18
            Me.LstGuilds.Location = New Point(12, 159)
            Me.LstGuilds.Name = "LstGuilds"
            Me.LstGuilds.Size = New Size(225, 94)
            Me.LstGuilds.TabIndex = 0
            '
            'txtGuilds
            '
            Me.txtGuilds.BorderStyle = BorderStyle.FixedSingle
            Me.txtGuilds.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.txtGuilds.Location = New Point(12, 12)
            Me.txtGuilds.Multiline = True
            Me.txtGuilds.Name = "txtGuilds"
            Me.txtGuilds.ReadOnly = True
            Me.txtGuilds.ScrollBars = ScrollBars.Vertical
            Me.txtGuilds.Size = New Size(421, 132)
            Me.txtGuilds.TabIndex = 4
            Me.txtGuilds.Text = "You enter the Guilds district."
            '
            'BtnEnter
            '
            Me.BtnEnter.Enabled = False
            Me.BtnEnter.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnEnter.Location = New Point(49, 270)
            Me.BtnEnter.Name = "BtnEnter"
            Me.BtnEnter.Size = New Size(150, 30)
            Me.BtnEnter.TabIndex = 1
            Me.BtnEnter.Text = "&Enter"
            Me.BtnEnter.UseVisualStyleBackColor = True
            '
            'BtnApply
            '
            Me.BtnApply.Enabled = False
            Me.BtnApply.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnApply.Location = New Point(49, 317)
            Me.BtnApply.Name = "BtnApply"
            Me.BtnApply.Size = New Size(150, 30)
            Me.BtnApply.TabIndex = 2
            Me.BtnApply.Text = "&Apply"
            Me.BtnApply.UseVisualStyleBackColor = True
            '
            'BtnBack
            '
            Me.BtnBack.DialogResult = DialogResult.Cancel
            Me.BtnBack.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnBack.Location = New Point(49, 364)
            Me.BtnBack.Name = "BtnBack"
            Me.BtnBack.Size = New Size(150, 30)
            Me.BtnBack.TabIndex = 3
            Me.BtnBack.Text = "&Back"
            Me.BtnBack.UseVisualStyleBackColor = True
            '
            'LblGoldOnHand
            '
            Me.LblGoldOnHand.BorderStyle = BorderStyle.FixedSingle
            Me.LblGoldOnHand.Location = New Point(363, 231)
            Me.LblGoldOnHand.Margin = New Padding(4, 0, 4, 0)
            Me.LblGoldOnHand.Name = "LblGoldOnHand"
            Me.LblGoldOnHand.Size = New Size(70, 25)
            Me.LblGoldOnHand.TabIndex = 14
            Me.LblGoldOnHand.TextAlign = ContentAlignment.MiddleCenter
            '
            'Label4
            '
            Me.Label4.BorderStyle = BorderStyle.FixedSingle
            Me.Label4.Location = New Point(244, 231)
            Me.Label4.Margin = New Padding(4, 0, 4, 0)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New Size(120, 25)
            Me.Label4.TabIndex = 13
            Me.Label4.Text = "Gold on Hand:"
            Me.Label4.TextAlign = ContentAlignment.MiddleCenter
            '
            'LblGuildGold
            '
            Me.LblGuildGold.BorderStyle = BorderStyle.FixedSingle
            Me.LblGuildGold.Location = New Point(363, 255)
            Me.LblGuildGold.Margin = New Padding(4, 0, 4, 0)
            Me.LblGuildGold.Name = "LblGuildGold"
            Me.LblGuildGold.Size = New Size(70, 25)
            Me.LblGuildGold.TabIndex = 18
            Me.LblGuildGold.TextAlign = ContentAlignment.MiddleCenter
            '
            'Label6
            '
            Me.Label6.BorderStyle = BorderStyle.FixedSingle
            Me.Label6.Location = New Point(244, 255)
            Me.Label6.Margin = New Padding(4, 0, 4, 0)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New Size(120, 25)
            Me.Label6.TabIndex = 17
            Me.Label6.Text = "Guild Gold:"
            Me.Label6.TextAlign = ContentAlignment.MiddleCenter
            '
            'Label7
            '
            Me.Label7.BorderStyle = BorderStyle.FixedSingle
            Me.Label7.Location = New Point(244, 279)
            Me.Label7.Margin = New Padding(4, 0, 4, 0)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New Size(140, 25)
            Me.Label7.TabIndex = 19
            Me.Label7.Text = "Lvl 1 Henchmen:"
            Me.Label7.TextAlign = ContentAlignment.MiddleCenter
            '
            'Label8
            '
            Me.Label8.BorderStyle = BorderStyle.FixedSingle
            Me.Label8.Location = New Point(244, 303)
            Me.Label8.Margin = New Padding(4, 0, 4, 0)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New Size(140, 25)
            Me.Label8.TabIndex = 20
            Me.Label8.Text = "Lvl 2 Henchmen:"
            Me.Label8.TextAlign = ContentAlignment.MiddleCenter
            '
            'Label9
            '
            Me.Label9.BorderStyle = BorderStyle.FixedSingle
            Me.Label9.Location = New Point(244, 327)
            Me.Label9.Margin = New Padding(4, 0, 4, 0)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New Size(140, 25)
            Me.Label9.TabIndex = 21
            Me.Label9.Text = "Lvl 3 Henchmen:"
            Me.Label9.TextAlign = ContentAlignment.MiddleCenter
            '
            'Label10
            '
            Me.Label10.BorderStyle = BorderStyle.FixedSingle
            Me.Label10.Location = New Point(244, 351)
            Me.Label10.Margin = New Padding(4, 0, 4, 0)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New Size(140, 25)
            Me.Label10.TabIndex = 22
            Me.Label10.Text = "Lvl 4 Henchmen:"
            Me.Label10.TextAlign = ContentAlignment.MiddleCenter
            '
            'Label11
            '
            Me.Label11.BorderStyle = BorderStyle.FixedSingle
            Me.Label11.Location = New Point(244, 375)
            Me.Label11.Margin = New Padding(4, 0, 4, 0)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New Size(140, 25)
            Me.Label11.TabIndex = 23
            Me.Label11.Text = "Lvl 5 Henchmen:"
            Me.Label11.TextAlign = ContentAlignment.MiddleCenter
            '
            'LblHenchmenLevel1
            '
            Me.LblHenchmenLevel1.BorderStyle = BorderStyle.FixedSingle
            Me.LblHenchmenLevel1.Location = New Point(383, 279)
            Me.LblHenchmenLevel1.Margin = New Padding(4, 0, 4, 0)
            Me.LblHenchmenLevel1.Name = "LblHenchmenLevel1"
            Me.LblHenchmenLevel1.Size = New Size(50, 25)
            Me.LblHenchmenLevel1.TabIndex = 24
            Me.LblHenchmenLevel1.TextAlign = ContentAlignment.MiddleCenter
            '
            'LblHenchmenLevel2
            '
            Me.LblHenchmenLevel2.BorderStyle = BorderStyle.FixedSingle
            Me.LblHenchmenLevel2.Location = New Point(383, 303)
            Me.LblHenchmenLevel2.Margin = New Padding(4, 0, 4, 0)
            Me.LblHenchmenLevel2.Name = "LblHenchmenLevel2"
            Me.LblHenchmenLevel2.Size = New Size(50, 25)
            Me.LblHenchmenLevel2.TabIndex = 25
            Me.LblHenchmenLevel2.TextAlign = ContentAlignment.MiddleCenter
            '
            'LblHenchmenLevel3
            '
            Me.LblHenchmenLevel3.BorderStyle = BorderStyle.FixedSingle
            Me.LblHenchmenLevel3.Location = New Point(383, 327)
            Me.LblHenchmenLevel3.Margin = New Padding(4, 0, 4, 0)
            Me.LblHenchmenLevel3.Name = "LblHenchmenLevel3"
            Me.LblHenchmenLevel3.Size = New Size(50, 25)
            Me.LblHenchmenLevel3.TabIndex = 26
            Me.LblHenchmenLevel3.TextAlign = ContentAlignment.MiddleCenter
            '
            'LblHenchmenLevel4
            '
            Me.LblHenchmenLevel4.BorderStyle = BorderStyle.FixedSingle
            Me.LblHenchmenLevel4.Location = New Point(383, 351)
            Me.LblHenchmenLevel4.Margin = New Padding(4, 0, 4, 0)
            Me.LblHenchmenLevel4.Name = "LblHenchmenLevel4"
            Me.LblHenchmenLevel4.Size = New Size(50, 25)
            Me.LblHenchmenLevel4.TabIndex = 27
            Me.LblHenchmenLevel4.TextAlign = ContentAlignment.MiddleCenter
            '
            'LblHenchmenLevel5
            '
            Me.LblHenchmenLevel5.BorderStyle = BorderStyle.FixedSingle
            Me.LblHenchmenLevel5.Location = New Point(383, 375)
            Me.LblHenchmenLevel5.Margin = New Padding(4, 0, 4, 0)
            Me.LblHenchmenLevel5.Name = "LblHenchmenLevel5"
            Me.LblHenchmenLevel5.Size = New Size(50, 25)
            Me.LblHenchmenLevel5.TabIndex = 28
            Me.LblHenchmenLevel5.TextAlign = ContentAlignment.MiddleCenter
            '
            'Label2
            '
            Me.Label2.BorderStyle = BorderStyle.FixedSingle
            Me.Label2.Location = New Point(244, 159)
            Me.Label2.Margin = New Padding(4, 0, 4, 0)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New Size(189, 25)
            Me.Label2.TabIndex = 29
            Me.Label2.Text = "Guildmaster:"
            Me.Label2.TextAlign = ContentAlignment.MiddleCenter
            '
            'LblGuildmaster
            '
            Me.LblGuildmaster.BorderStyle = BorderStyle.FixedSingle
            Me.LblGuildmaster.Location = New Point(244, 183)
            Me.LblGuildmaster.Margin = New Padding(4, 0, 4, 0)
            Me.LblGuildmaster.Name = "LblGuildmaster"
            Me.LblGuildmaster.Size = New Size(189, 25)
            Me.LblGuildmaster.TabIndex = 30
            Me.LblGuildmaster.TextAlign = ContentAlignment.MiddleCenter
            '
            'LblFee
            '
            Me.LblFee.BorderStyle = BorderStyle.FixedSingle
            Me.LblFee.Location = New Point(363, 207)
            Me.LblFee.Margin = New Padding(4, 0, 4, 0)
            Me.LblFee.Name = "LblFee"
            Me.LblFee.Size = New Size(70, 25)
            Me.LblFee.TabIndex = 34
            Me.LblFee.TextAlign = ContentAlignment.MiddleCenter
            '
            'Label5
            '
            Me.Label5.BorderStyle = BorderStyle.FixedSingle
            Me.Label5.Location = New Point(244, 207)
            Me.Label5.Margin = New Padding(4, 0, 4, 0)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New Size(120, 25)
            Me.Label5.TabIndex = 33
            Me.Label5.Text = "Entrance Fee:"
            Me.Label5.TextAlign = ContentAlignment.MiddleCenter
            '
            'frmGuildList
            '
            Me.AutoScaleDimensions = New SizeF(9.0!, 18.0!)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.CancelButton = Me.BtnBack
            Me.ClientSize = New Size(446, 409)
            Me.Controls.Add(Me.LblGuildmaster)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.LblHenchmenLevel5)
            Me.Controls.Add(Me.LblHenchmenLevel4)
            Me.Controls.Add(Me.LblHenchmenLevel3)
            Me.Controls.Add(Me.LblHenchmenLevel2)
            Me.Controls.Add(Me.LblHenchmenLevel1)
            Me.Controls.Add(Me.Label11)
            Me.Controls.Add(Me.Label10)
            Me.Controls.Add(Me.Label9)
            Me.Controls.Add(Me.Label8)
            Me.Controls.Add(Me.Label7)
            Me.Controls.Add(Me.LblGuildGold)
            Me.Controls.Add(Me.Label6)
            Me.Controls.Add(Me.LblGoldOnHand)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.BtnBack)
            Me.Controls.Add(Me.BtnApply)
            Me.Controls.Add(Me.BtnEnter)
            Me.Controls.Add(Me.txtGuilds)
            Me.Controls.Add(Me.LstGuilds)
            Me.Controls.Add(Me.LblFee)
            Me.Controls.Add(Me.Label5)
            Me.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Margin = New Padding(4)
            Me.MaximizeBox = False
            Me.MaximumSize = New Size(462, 447)
            Me.MinimumSize = New Size(462, 447)
            Me.Name = "frmGuildList"
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.Text = "Guild"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents LstGuilds As ListBox
        Friend WithEvents TxtGuilds As TextBox
        Friend WithEvents BtnEnter As Button
        Friend WithEvents BtnApply As Button
        Friend WithEvents BtnBack As Button
        Friend WithEvents LblGoldOnHand As Label
        Friend WithEvents Label4 As Label
        Friend WithEvents LblGuildGold As Label
        Friend WithEvents Label6 As Label
        Friend WithEvents Label7 As Label
        Friend WithEvents Label8 As Label
        Friend WithEvents Label9 As Label
        Friend WithEvents Label10 As Label
        Friend WithEvents Label11 As Label
        Friend WithEvents LblHenchmenLevel1 As Label
        Friend WithEvents LblHenchmenLevel2 As Label
        Friend WithEvents LblHenchmenLevel3 As Label
        Friend WithEvents LblHenchmenLevel4 As Label
        Friend WithEvents LblHenchmenLevel5 As Label
        Friend WithEvents Label2 As Label
        Friend WithEvents LblGuildmaster As Label
        Friend WithEvents LblFee As Label
        Friend WithEvents Label5 As Label
    End Class
End NameSpace