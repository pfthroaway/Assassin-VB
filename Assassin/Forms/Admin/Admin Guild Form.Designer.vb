Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

Namespace Forms.Admin
    <DesignerGenerated()> _
    Partial Class FrmAdminGuilds
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
            Me.txtName = New TextBox()
            Me.LblName = New Label()
            Me.CmbGuildmaster = New ComboBox()
            Me.LblGuildmaster = New Label()
            Me.LblFee = New Label()
            Me.txtEntranceFee = New TextBox()
            Me.txtGuildGold = New TextBox()
            Me.LblGuildGold = New Label()
            Me.txtHenchmenLevel1 = New TextBox()
            Me.txtHenchmenLevel2 = New TextBox()
            Me.txtHenchmenLevel3 = New TextBox()
            Me.txtHenchmenLevel4 = New TextBox()
            Me.txtHenchmenLevel5 = New TextBox()
            Me.LblHenchmenLevel5 = New Label()
            Me.LblHenchmenLevel4 = New Label()
            Me.LblHenchmenLevel3 = New Label()
            Me.LblHenchmenLevel2 = New Label()
            Me.LblHenchmenLevel1 = New Label()
            Me.BtnClear = New Button()
            Me.BtnExpel = New Button()
            Me.BtnExit = New Button()
            Me.BtnSave = New Button()
            Me.BtnAddMember = New Button()
            Me.LblMembers = New Label()
            Me.LstMembers = New ListBox()
            Me.LblGuilds = New Label()
            Me.SuspendLayout()
            '
            'LstGuilds
            '
            Me.LstGuilds.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.LstGuilds.FormattingEnabled = True
            Me.LstGuilds.ItemHeight = 18
            Me.LstGuilds.Location = New Point(13, 37)
            Me.LstGuilds.Margin = New Padding(4)
            Me.LstGuilds.Name = "LstGuilds"
            Me.LstGuilds.ScrollAlwaysVisible = True
            Me.LstGuilds.Size = New Size(225, 94)
            Me.LstGuilds.TabIndex = 0
            '
            'txtName
            '
            Me.txtName.Enabled = False
            Me.txtName.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.txtName.Location = New Point(146, 141)
            Me.txtName.Margin = New Padding(4)
            Me.txtName.MaxLength = 30
            Me.txtName.Name = "txtName"
            Me.txtName.Size = New Size(175, 22)
            Me.txtName.TabIndex = 1
            Me.txtName.TextAlign = HorizontalAlignment.Center
            '
            'LblName
            '
            Me.LblName.BorderStyle = BorderStyle.FixedSingle
            Me.LblName.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.LblName.Location = New Point(13, 140)
            Me.LblName.Margin = New Padding(4, 0, 4, 0)
            Me.LblName.Name = "LblName"
            Me.LblName.Size = New Size(125, 24)
            Me.LblName.TabIndex = 18
            Me.LblName.Text = "Guild Name:"
            Me.LblName.TextAlign = ContentAlignment.MiddleRight
            '
            'CmbGuildmaster
            '
            Me.CmbGuildmaster.DropDownStyle = ComboBoxStyle.DropDownList
            Me.CmbGuildmaster.Enabled = False
            Me.CmbGuildmaster.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.CmbGuildmaster.FormattingEnabled = True
            Me.CmbGuildmaster.Items.AddRange(New Object() {"Computer"})
            Me.CmbGuildmaster.Location = New Point(145, 171)
            Me.CmbGuildmaster.Name = "CmbGuildmaster"
            Me.CmbGuildmaster.Size = New Size(176, 24)
            Me.CmbGuildmaster.TabIndex = 2
            '
            'LblGuildmaster
            '
            Me.LblGuildmaster.BorderStyle = BorderStyle.FixedSingle
            Me.LblGuildmaster.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.LblGuildmaster.Location = New Point(13, 170)
            Me.LblGuildmaster.Margin = New Padding(4, 0, 4, 0)
            Me.LblGuildmaster.Name = "LblGuildmaster"
            Me.LblGuildmaster.Size = New Size(125, 24)
            Me.LblGuildmaster.TabIndex = 19
            Me.LblGuildmaster.Text = "Guildmaster:"
            Me.LblGuildmaster.TextAlign = ContentAlignment.MiddleRight
            '
            'LblFee
            '
            Me.LblFee.BorderStyle = BorderStyle.FixedSingle
            Me.LblFee.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.LblFee.Location = New Point(13, 200)
            Me.LblFee.Margin = New Padding(4, 0, 4, 0)
            Me.LblFee.Name = "LblFee"
            Me.LblFee.Size = New Size(125, 24)
            Me.LblFee.TabIndex = 20
            Me.LblFee.Text = "Entrance Fee:"
            Me.LblFee.TextAlign = ContentAlignment.MiddleRight
            '
            'txtEntranceFee
            '
            Me.txtEntranceFee.Enabled = False
            Me.txtEntranceFee.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.txtEntranceFee.Location = New Point(146, 201)
            Me.txtEntranceFee.Margin = New Padding(4)
            Me.txtEntranceFee.MaxLength = 4
            Me.txtEntranceFee.Name = "txtEntranceFee"
            Me.txtEntranceFee.Size = New Size(73, 22)
            Me.txtEntranceFee.TabIndex = 3
            Me.txtEntranceFee.TextAlign = HorizontalAlignment.Center
            '
            'txtGuildGold
            '
            Me.txtGuildGold.Enabled = False
            Me.txtGuildGold.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.txtGuildGold.Location = New Point(146, 231)
            Me.txtGuildGold.Margin = New Padding(4)
            Me.txtGuildGold.MaxLength = 6
            Me.txtGuildGold.Name = "txtGuildGold"
            Me.txtGuildGold.Size = New Size(73, 22)
            Me.txtGuildGold.TabIndex = 4
            Me.txtGuildGold.TextAlign = HorizontalAlignment.Center
            '
            'LblGuildGold
            '
            Me.LblGuildGold.BorderStyle = BorderStyle.FixedSingle
            Me.LblGuildGold.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.LblGuildGold.Location = New Point(13, 230)
            Me.LblGuildGold.Margin = New Padding(4, 0, 4, 0)
            Me.LblGuildGold.Name = "LblGuildGold"
            Me.LblGuildGold.Size = New Size(125, 24)
            Me.LblGuildGold.TabIndex = 21
            Me.LblGuildGold.Text = "Guild Gold:"
            Me.LblGuildGold.TextAlign = ContentAlignment.MiddleRight
            '
            'txtHenchmenLevel1
            '
            Me.txtHenchmenLevel1.Enabled = False
            Me.txtHenchmenLevel1.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.txtHenchmenLevel1.Location = New Point(146, 261)
            Me.txtHenchmenLevel1.Margin = New Padding(4)
            Me.txtHenchmenLevel1.MaxLength = 3
            Me.txtHenchmenLevel1.Name = "txtHenchmenLevel1"
            Me.txtHenchmenLevel1.Size = New Size(73, 22)
            Me.txtHenchmenLevel1.TabIndex = 5
            Me.txtHenchmenLevel1.TextAlign = HorizontalAlignment.Center
            '
            'txtHenchmenLevel2
            '
            Me.txtHenchmenLevel2.Enabled = False
            Me.txtHenchmenLevel2.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.txtHenchmenLevel2.Location = New Point(146, 291)
            Me.txtHenchmenLevel2.Margin = New Padding(4)
            Me.txtHenchmenLevel2.MaxLength = 3
            Me.txtHenchmenLevel2.Name = "txtHenchmenLevel2"
            Me.txtHenchmenLevel2.Size = New Size(73, 22)
            Me.txtHenchmenLevel2.TabIndex = 6
            Me.txtHenchmenLevel2.TextAlign = HorizontalAlignment.Center
            '
            'txtHenchmenLevel3
            '
            Me.txtHenchmenLevel3.Enabled = False
            Me.txtHenchmenLevel3.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.txtHenchmenLevel3.Location = New Point(146, 321)
            Me.txtHenchmenLevel3.Margin = New Padding(4)
            Me.txtHenchmenLevel3.MaxLength = 3
            Me.txtHenchmenLevel3.Name = "txtHenchmenLevel3"
            Me.txtHenchmenLevel3.Size = New Size(73, 22)
            Me.txtHenchmenLevel3.TabIndex = 7
            Me.txtHenchmenLevel3.TextAlign = HorizontalAlignment.Center
            '
            'txtHenchmenLevel4
            '
            Me.txtHenchmenLevel4.Enabled = False
            Me.txtHenchmenLevel4.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.txtHenchmenLevel4.Location = New Point(146, 352)
            Me.txtHenchmenLevel4.Margin = New Padding(4)
            Me.txtHenchmenLevel4.MaxLength = 3
            Me.txtHenchmenLevel4.Name = "txtHenchmenLevel4"
            Me.txtHenchmenLevel4.Size = New Size(73, 22)
            Me.txtHenchmenLevel4.TabIndex = 8
            Me.txtHenchmenLevel4.TextAlign = HorizontalAlignment.Center
            '
            'txtHenchmenLevel5
            '
            Me.txtHenchmenLevel5.Enabled = False
            Me.txtHenchmenLevel5.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.txtHenchmenLevel5.Location = New Point(146, 382)
            Me.txtHenchmenLevel5.Margin = New Padding(4)
            Me.txtHenchmenLevel5.MaxLength = 3
            Me.txtHenchmenLevel5.Name = "txtHenchmenLevel5"
            Me.txtHenchmenLevel5.Size = New Size(73, 22)
            Me.txtHenchmenLevel5.TabIndex = 9
            Me.txtHenchmenLevel5.TextAlign = HorizontalAlignment.Center
            '
            'LblHenchmenLevel5
            '
            Me.LblHenchmenLevel5.BorderStyle = BorderStyle.FixedSingle
            Me.LblHenchmenLevel5.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.LblHenchmenLevel5.Location = New Point(13, 381)
            Me.LblHenchmenLevel5.Margin = New Padding(4, 0, 4, 0)
            Me.LblHenchmenLevel5.Name = "LblHenchmenLevel5"
            Me.LblHenchmenLevel5.Size = New Size(125, 24)
            Me.LblHenchmenLevel5.TabIndex = 26
            Me.LblHenchmenLevel5.Text = "Lvl 5 Henchmen:"
            Me.LblHenchmenLevel5.TextAlign = ContentAlignment.MiddleRight
            '
            'LblHenchmenLevel4
            '
            Me.LblHenchmenLevel4.BorderStyle = BorderStyle.FixedSingle
            Me.LblHenchmenLevel4.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.LblHenchmenLevel4.Location = New Point(13, 351)
            Me.LblHenchmenLevel4.Margin = New Padding(4, 0, 4, 0)
            Me.LblHenchmenLevel4.Name = "LblHenchmenLevel4"
            Me.LblHenchmenLevel4.Size = New Size(125, 24)
            Me.LblHenchmenLevel4.TabIndex = 25
            Me.LblHenchmenLevel4.Text = "Lvl 4 Henchmen:"
            Me.LblHenchmenLevel4.TextAlign = ContentAlignment.MiddleRight
            '
            'LblHenchmenLevel3
            '
            Me.LblHenchmenLevel3.BorderStyle = BorderStyle.FixedSingle
            Me.LblHenchmenLevel3.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.LblHenchmenLevel3.Location = New Point(13, 320)
            Me.LblHenchmenLevel3.Margin = New Padding(4, 0, 4, 0)
            Me.LblHenchmenLevel3.Name = "LblHenchmenLevel3"
            Me.LblHenchmenLevel3.Size = New Size(125, 24)
            Me.LblHenchmenLevel3.TabIndex = 24
            Me.LblHenchmenLevel3.Text = "Lvl 3 Henchmen:"
            Me.LblHenchmenLevel3.TextAlign = ContentAlignment.MiddleRight
            '
            'LblHenchmenLevel2
            '
            Me.LblHenchmenLevel2.BorderStyle = BorderStyle.FixedSingle
            Me.LblHenchmenLevel2.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.LblHenchmenLevel2.Location = New Point(13, 290)
            Me.LblHenchmenLevel2.Margin = New Padding(4, 0, 4, 0)
            Me.LblHenchmenLevel2.Name = "LblHenchmenLevel2"
            Me.LblHenchmenLevel2.Size = New Size(125, 24)
            Me.LblHenchmenLevel2.TabIndex = 23
            Me.LblHenchmenLevel2.Text = "Lvl 2 Henchmen:"
            Me.LblHenchmenLevel2.TextAlign = ContentAlignment.MiddleRight
            '
            'LblHenchmenLevel1
            '
            Me.LblHenchmenLevel1.BorderStyle = BorderStyle.FixedSingle
            Me.LblHenchmenLevel1.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.LblHenchmenLevel1.Location = New Point(13, 260)
            Me.LblHenchmenLevel1.Margin = New Padding(4, 0, 4, 0)
            Me.LblHenchmenLevel1.Name = "LblHenchmenLevel1"
            Me.LblHenchmenLevel1.Size = New Size(125, 24)
            Me.LblHenchmenLevel1.TabIndex = 22
            Me.LblHenchmenLevel1.Text = "Lvl 1 Henchmen:"
            Me.LblHenchmenLevel1.TextAlign = ContentAlignment.MiddleRight
            '
            'BtnClear
            '
            Me.BtnClear.Enabled = False
            Me.BtnClear.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnClear.Location = New Point(379, 308)
            Me.BtnClear.Margin = New Padding(4)
            Me.BtnClear.Name = "BtnClear"
            Me.BtnClear.Size = New Size(125, 30)
            Me.BtnClear.TabIndex = 13
            Me.BtnClear.Text = "&Clear"
            Me.BtnClear.UseVisualStyleBackColor = True
            '
            'BtnExpel
            '
            Me.BtnExpel.Enabled = False
            Me.BtnExpel.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnExpel.Location = New Point(379, 270)
            Me.BtnExpel.Margin = New Padding(4)
            Me.BtnExpel.Name = "BtnExpel"
            Me.BtnExpel.Size = New Size(125, 30)
            Me.BtnExpel.TabIndex = 12
            Me.BtnExpel.Text = "&Expel Member"
            Me.BtnExpel.UseVisualStyleBackColor = True
            '
            'BtnExit
            '
            Me.BtnExit.DialogResult = DialogResult.Cancel
            Me.BtnExit.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnExit.Location = New Point(379, 384)
            Me.BtnExit.Margin = New Padding(4)
            Me.BtnExit.Name = "BtnExit"
            Me.BtnExit.Size = New Size(125, 30)
            Me.BtnExit.TabIndex = 15
            Me.BtnExit.Text = "E&xit"
            Me.BtnExit.UseVisualStyleBackColor = True
            '
            'BtnSave
            '
            Me.BtnSave.Enabled = False
            Me.BtnSave.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnSave.Location = New Point(379, 346)
            Me.BtnSave.Margin = New Padding(4)
            Me.BtnSave.Name = "BtnSave"
            Me.BtnSave.Size = New Size(125, 30)
            Me.BtnSave.TabIndex = 14
            Me.BtnSave.Text = "&Save"
            Me.BtnSave.UseVisualStyleBackColor = True
            '
            'BtnAddMember
            '
            Me.BtnAddMember.Enabled = False
            Me.BtnAddMember.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnAddMember.Location = New Point(379, 232)
            Me.BtnAddMember.Margin = New Padding(4)
            Me.BtnAddMember.Name = "BtnAddMember"
            Me.BtnAddMember.Size = New Size(125, 30)
            Me.BtnAddMember.TabIndex = 11
            Me.BtnAddMember.Text = "&Add Member"
            Me.BtnAddMember.UseVisualStyleBackColor = True
            '
            'LblMembers
            '
            Me.LblMembers.BorderStyle = BorderStyle.FixedSingle
            Me.LblMembers.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.LblMembers.Location = New Point(328, 9)
            Me.LblMembers.Margin = New Padding(4, 0, 4, 0)
            Me.LblMembers.Name = "LblMembers"
            Me.LblMembers.Size = New Size(225, 24)
            Me.LblMembers.TabIndex = 17
            Me.LblMembers.Text = "Guild Members"
            Me.LblMembers.TextAlign = ContentAlignment.MiddleCenter
            '
            'LstMembers
            '
            Me.LstMembers.Enabled = False
            Me.LstMembers.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.LstMembers.FormattingEnabled = True
            Me.LstMembers.ItemHeight = 18
            Me.LstMembers.Location = New Point(329, 37)
            Me.LstMembers.Margin = New Padding(4)
            Me.LstMembers.Name = "LstMembers"
            Me.LstMembers.ScrollAlwaysVisible = True
            Me.LstMembers.Size = New Size(225, 184)
            Me.LstMembers.Sorted = True
            Me.LstMembers.TabIndex = 10
            '
            'LblGuilds
            '
            Me.LblGuilds.BorderStyle = BorderStyle.FixedSingle
            Me.LblGuilds.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.LblGuilds.Location = New Point(13, 9)
            Me.LblGuilds.Margin = New Padding(4, 0, 4, 0)
            Me.LblGuilds.Name = "LblGuilds"
            Me.LblGuilds.Size = New Size(225, 24)
            Me.LblGuilds.TabIndex = 16
            Me.LblGuilds.Text = "Guilds"
            Me.LblGuilds.TextAlign = ContentAlignment.MiddleCenter
            '
            'frmAdminGuilds
            '
            Me.AutoScaleDimensions = New SizeF(9.0!, 18.0!)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.CancelButton = Me.BtnExit
            Me.ClientSize = New Size(567, 427)
            Me.Controls.Add(Me.LblGuilds)
            Me.Controls.Add(Me.LstMembers)
            Me.Controls.Add(Me.LblMembers)
            Me.Controls.Add(Me.BtnAddMember)
            Me.Controls.Add(Me.BtnExit)
            Me.Controls.Add(Me.BtnSave)
            Me.Controls.Add(Me.BtnClear)
            Me.Controls.Add(Me.BtnExpel)
            Me.Controls.Add(Me.txtHenchmenLevel1)
            Me.Controls.Add(Me.txtHenchmenLevel2)
            Me.Controls.Add(Me.txtHenchmenLevel3)
            Me.Controls.Add(Me.txtHenchmenLevel4)
            Me.Controls.Add(Me.txtHenchmenLevel5)
            Me.Controls.Add(Me.LblHenchmenLevel5)
            Me.Controls.Add(Me.LblHenchmenLevel4)
            Me.Controls.Add(Me.LblHenchmenLevel3)
            Me.Controls.Add(Me.LblHenchmenLevel2)
            Me.Controls.Add(Me.LblHenchmenLevel1)
            Me.Controls.Add(Me.txtGuildGold)
            Me.Controls.Add(Me.LblGuildGold)
            Me.Controls.Add(Me.txtEntranceFee)
            Me.Controls.Add(Me.LblFee)
            Me.Controls.Add(Me.CmbGuildmaster)
            Me.Controls.Add(Me.LblGuildmaster)
            Me.Controls.Add(Me.txtName)
            Me.Controls.Add(Me.LblName)
            Me.Controls.Add(Me.LstGuilds)
            Me.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Margin = New Padding(4)
            Me.MaximizeBox = False
            Me.MaximumSize = New Size(583, 465)
            Me.MinimumSize = New Size(583, 465)
            Me.Name = "frmAdminGuilds"
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.Text = "Admin Guilds"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents LstGuilds As ListBox
        Friend WithEvents TxtName As TextBox
        Friend WithEvents LblName As Label
        Friend WithEvents CmbGuildmaster As ComboBox
        Friend WithEvents LblGuildmaster As Label
        Friend WithEvents LblFee As Label
        Friend WithEvents TxtEntranceFee As TextBox
        Friend WithEvents TxtGuildGold As TextBox
        Friend WithEvents LblGuildGold As Label
        Friend WithEvents TxtHenchmenLevel1 As TextBox
        Friend WithEvents TxtHenchmenLevel2 As TextBox
        Friend WithEvents TxtHenchmenLevel3 As TextBox
        Friend WithEvents TxtHenchmenLevel4 As TextBox
        Friend WithEvents TxtHenchmenLevel5 As TextBox
        Friend WithEvents LblHenchmenLevel5 As Label
        Friend WithEvents LblHenchmenLevel4 As Label
        Friend WithEvents LblHenchmenLevel3 As Label
        Friend WithEvents LblHenchmenLevel2 As Label
        Friend WithEvents LblHenchmenLevel1 As Label
        Friend WithEvents BtnClear As Button
        Friend WithEvents BtnExpel As Button
        Friend WithEvents BtnExit As Button
        Friend WithEvents BtnSave As Button
        Friend WithEvents BtnAddMember As Button
        Friend WithEvents LblMembers As Label
        Friend WithEvents LstMembers As ListBox
        Friend WithEvents LblGuilds As Label
    End Class
End NameSpace