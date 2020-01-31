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
            Me.lstGuilds = New ListBox()
            Me.txtGuilds = New TextBox()
            Me.btnEnter = New Button()
            Me.btnApply = New Button()
            Me.btnBack = New Button()
            Me.lblGoldOnHand = New Label()
            Me.Label4 = New Label()
            Me.lblGuildGold = New Label()
            Me.Label6 = New Label()
            Me.Label7 = New Label()
            Me.Label8 = New Label()
            Me.Label9 = New Label()
            Me.Label10 = New Label()
            Me.Label11 = New Label()
            Me.lblHenchmenLevel1 = New Label()
            Me.lblHenchmenLevel2 = New Label()
            Me.lblHenchmenLevel3 = New Label()
            Me.lblHenchmenLevel4 = New Label()
            Me.lblHenchmenLevel5 = New Label()
            Me.Label2 = New Label()
            Me.lblGuildmaster = New Label()
            Me.lblFee = New Label()
            Me.Label5 = New Label()
            Me.SuspendLayout()
            '
            'lstGuilds
            '
            Me.lstGuilds.FormattingEnabled = True
            Me.lstGuilds.ItemHeight = 18
            Me.lstGuilds.Location = New Point(12, 159)
            Me.lstGuilds.Name = "lstGuilds"
            Me.lstGuilds.Size = New Size(225, 94)
            Me.lstGuilds.TabIndex = 0
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
            'btnEnter
            '
            Me.btnEnter.Enabled = False
            Me.btnEnter.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnEnter.Location = New Point(49, 270)
            Me.btnEnter.Name = "btnEnter"
            Me.btnEnter.Size = New Size(150, 30)
            Me.btnEnter.TabIndex = 1
            Me.btnEnter.Text = "&Enter"
            Me.btnEnter.UseVisualStyleBackColor = True
            '
            'btnApply
            '
            Me.btnApply.Enabled = False
            Me.btnApply.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnApply.Location = New Point(49, 317)
            Me.btnApply.Name = "btnApply"
            Me.btnApply.Size = New Size(150, 30)
            Me.btnApply.TabIndex = 2
            Me.btnApply.Text = "&Apply"
            Me.btnApply.UseVisualStyleBackColor = True
            '
            'btnBack
            '
            Me.btnBack.DialogResult = DialogResult.Cancel
            Me.btnBack.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnBack.Location = New Point(49, 364)
            Me.btnBack.Name = "btnBack"
            Me.btnBack.Size = New Size(150, 30)
            Me.btnBack.TabIndex = 3
            Me.btnBack.Text = "&Back"
            Me.btnBack.UseVisualStyleBackColor = True
            '
            'lblGoldOnHand
            '
            Me.lblGoldOnHand.BorderStyle = BorderStyle.FixedSingle
            Me.lblGoldOnHand.Location = New Point(363, 231)
            Me.lblGoldOnHand.Margin = New Padding(4, 0, 4, 0)
            Me.lblGoldOnHand.Name = "lblGoldOnHand"
            Me.lblGoldOnHand.Size = New Size(70, 25)
            Me.lblGoldOnHand.TabIndex = 14
            Me.lblGoldOnHand.TextAlign = ContentAlignment.MiddleCenter
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
            'lblGuildGold
            '
            Me.lblGuildGold.BorderStyle = BorderStyle.FixedSingle
            Me.lblGuildGold.Location = New Point(363, 255)
            Me.lblGuildGold.Margin = New Padding(4, 0, 4, 0)
            Me.lblGuildGold.Name = "lblGuildGold"
            Me.lblGuildGold.Size = New Size(70, 25)
            Me.lblGuildGold.TabIndex = 18
            Me.lblGuildGold.TextAlign = ContentAlignment.MiddleCenter
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
            'lblHenchmenLevel1
            '
            Me.lblHenchmenLevel1.BorderStyle = BorderStyle.FixedSingle
            Me.lblHenchmenLevel1.Location = New Point(383, 279)
            Me.lblHenchmenLevel1.Margin = New Padding(4, 0, 4, 0)
            Me.lblHenchmenLevel1.Name = "lblHenchmenLevel1"
            Me.lblHenchmenLevel1.Size = New Size(50, 25)
            Me.lblHenchmenLevel1.TabIndex = 24
            Me.lblHenchmenLevel1.TextAlign = ContentAlignment.MiddleCenter
            '
            'lblHenchmenLevel2
            '
            Me.lblHenchmenLevel2.BorderStyle = BorderStyle.FixedSingle
            Me.lblHenchmenLevel2.Location = New Point(383, 303)
            Me.lblHenchmenLevel2.Margin = New Padding(4, 0, 4, 0)
            Me.lblHenchmenLevel2.Name = "lblHenchmenLevel2"
            Me.lblHenchmenLevel2.Size = New Size(50, 25)
            Me.lblHenchmenLevel2.TabIndex = 25
            Me.lblHenchmenLevel2.TextAlign = ContentAlignment.MiddleCenter
            '
            'lblHenchmenLevel3
            '
            Me.lblHenchmenLevel3.BorderStyle = BorderStyle.FixedSingle
            Me.lblHenchmenLevel3.Location = New Point(383, 327)
            Me.lblHenchmenLevel3.Margin = New Padding(4, 0, 4, 0)
            Me.lblHenchmenLevel3.Name = "lblHenchmenLevel3"
            Me.lblHenchmenLevel3.Size = New Size(50, 25)
            Me.lblHenchmenLevel3.TabIndex = 26
            Me.lblHenchmenLevel3.TextAlign = ContentAlignment.MiddleCenter
            '
            'lblHenchmenLevel4
            '
            Me.lblHenchmenLevel4.BorderStyle = BorderStyle.FixedSingle
            Me.lblHenchmenLevel4.Location = New Point(383, 351)
            Me.lblHenchmenLevel4.Margin = New Padding(4, 0, 4, 0)
            Me.lblHenchmenLevel4.Name = "lblHenchmenLevel4"
            Me.lblHenchmenLevel4.Size = New Size(50, 25)
            Me.lblHenchmenLevel4.TabIndex = 27
            Me.lblHenchmenLevel4.TextAlign = ContentAlignment.MiddleCenter
            '
            'lblHenchmenLevel5
            '
            Me.lblHenchmenLevel5.BorderStyle = BorderStyle.FixedSingle
            Me.lblHenchmenLevel5.Location = New Point(383, 375)
            Me.lblHenchmenLevel5.Margin = New Padding(4, 0, 4, 0)
            Me.lblHenchmenLevel5.Name = "lblHenchmenLevel5"
            Me.lblHenchmenLevel5.Size = New Size(50, 25)
            Me.lblHenchmenLevel5.TabIndex = 28
            Me.lblHenchmenLevel5.TextAlign = ContentAlignment.MiddleCenter
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
            'lblGuildmaster
            '
            Me.lblGuildmaster.BorderStyle = BorderStyle.FixedSingle
            Me.lblGuildmaster.Location = New Point(244, 183)
            Me.lblGuildmaster.Margin = New Padding(4, 0, 4, 0)
            Me.lblGuildmaster.Name = "lblGuildmaster"
            Me.lblGuildmaster.Size = New Size(189, 25)
            Me.lblGuildmaster.TabIndex = 30
            Me.lblGuildmaster.TextAlign = ContentAlignment.MiddleCenter
            '
            'lblFee
            '
            Me.lblFee.BorderStyle = BorderStyle.FixedSingle
            Me.lblFee.Location = New Point(363, 207)
            Me.lblFee.Margin = New Padding(4, 0, 4, 0)
            Me.lblFee.Name = "lblFee"
            Me.lblFee.Size = New Size(70, 25)
            Me.lblFee.TabIndex = 34
            Me.lblFee.TextAlign = ContentAlignment.MiddleCenter
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
            Me.CancelButton = Me.btnBack
            Me.ClientSize = New Size(446, 409)
            Me.Controls.Add(Me.lblGuildmaster)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.lblHenchmenLevel5)
            Me.Controls.Add(Me.lblHenchmenLevel4)
            Me.Controls.Add(Me.lblHenchmenLevel3)
            Me.Controls.Add(Me.lblHenchmenLevel2)
            Me.Controls.Add(Me.lblHenchmenLevel1)
            Me.Controls.Add(Me.Label11)
            Me.Controls.Add(Me.Label10)
            Me.Controls.Add(Me.Label9)
            Me.Controls.Add(Me.Label8)
            Me.Controls.Add(Me.Label7)
            Me.Controls.Add(Me.lblGuildGold)
            Me.Controls.Add(Me.Label6)
            Me.Controls.Add(Me.lblGoldOnHand)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.btnBack)
            Me.Controls.Add(Me.btnApply)
            Me.Controls.Add(Me.btnEnter)
            Me.Controls.Add(Me.txtGuilds)
            Me.Controls.Add(Me.lstGuilds)
            Me.Controls.Add(Me.lblFee)
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
        Friend WithEvents lblGoldOnHand As Label
        Friend WithEvents Label4 As Label
        Friend WithEvents lblGuildGold As Label
        Friend WithEvents Label6 As Label
        Friend WithEvents Label7 As Label
        Friend WithEvents Label8 As Label
        Friend WithEvents Label9 As Label
        Friend WithEvents Label10 As Label
        Friend WithEvents Label11 As Label
        Friend WithEvents lblHenchmenLevel1 As Label
        Friend WithEvents lblHenchmenLevel2 As Label
        Friend WithEvents lblHenchmenLevel3 As Label
        Friend WithEvents lblHenchmenLevel4 As Label
        Friend WithEvents lblHenchmenLevel5 As Label
        Friend WithEvents Label2 As Label
        Friend WithEvents lblGuildmaster As Label
        Friend WithEvents lblFee As Label
        Friend WithEvents Label5 As Label
    End Class
End NameSpace