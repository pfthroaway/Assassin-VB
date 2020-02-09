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
            Me.LstGuilds = New System.Windows.Forms.ListBox()
            Me.TxtName = New System.Windows.Forms.TextBox()
            Me.LblName = New System.Windows.Forms.Label()
            Me.CmbGuildmaster = New System.Windows.Forms.ComboBox()
            Me.LblGuildmaster = New System.Windows.Forms.Label()
            Me.LblFee = New System.Windows.Forms.Label()
            Me.TxtEntranceFee = New System.Windows.Forms.TextBox()
            Me.TxtGuildGold = New System.Windows.Forms.TextBox()
            Me.LblGuildGold = New System.Windows.Forms.Label()
            Me.TxtHenchmenLevel1 = New System.Windows.Forms.TextBox()
            Me.TxtHenchmenLevel2 = New System.Windows.Forms.TextBox()
            Me.TxtHenchmenLevel3 = New System.Windows.Forms.TextBox()
            Me.TxtHenchmenLevel4 = New System.Windows.Forms.TextBox()
            Me.TxtHenchmenLevel5 = New System.Windows.Forms.TextBox()
            Me.LblHenchmenLevel5 = New System.Windows.Forms.Label()
            Me.LblHenchmenLevel4 = New System.Windows.Forms.Label()
            Me.LblHenchmenLevel3 = New System.Windows.Forms.Label()
            Me.LblHenchmenLevel2 = New System.Windows.Forms.Label()
            Me.LblHenchmenLevel1 = New System.Windows.Forms.Label()
            Me.BtnClear = New System.Windows.Forms.Button()
            Me.BtnExpel = New System.Windows.Forms.Button()
            Me.BtnExit = New System.Windows.Forms.Button()
            Me.BtnSave = New System.Windows.Forms.Button()
            Me.BtnAddMember = New System.Windows.Forms.Button()
            Me.LblMembers = New System.Windows.Forms.Label()
            Me.LstMembers = New System.Windows.Forms.ListBox()
            Me.LblGuilds = New System.Windows.Forms.Label()
            Me.SuspendLayout()
            '
            'LstGuilds
            '
            Me.LstGuilds.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LstGuilds.FormattingEnabled = True
            Me.LstGuilds.ItemHeight = 18
            Me.LstGuilds.Location = New System.Drawing.Point(13, 37)
            Me.LstGuilds.Margin = New System.Windows.Forms.Padding(4)
            Me.LstGuilds.Name = "LstGuilds"
            Me.LstGuilds.ScrollAlwaysVisible = True
            Me.LstGuilds.Size = New System.Drawing.Size(225, 94)
            Me.LstGuilds.TabIndex = 0
            '
            'TxtName
            '
            Me.TxtName.Enabled = False
            Me.TxtName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TxtName.Location = New System.Drawing.Point(146, 141)
            Me.TxtName.Margin = New System.Windows.Forms.Padding(4)
            Me.TxtName.MaxLength = 30
            Me.TxtName.Name = "TxtName"
            Me.TxtName.Size = New System.Drawing.Size(175, 26)
            Me.TxtName.TabIndex = 1
            Me.TxtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'LblName
            '
            Me.LblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblName.Location = New System.Drawing.Point(13, 140)
            Me.LblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.LblName.Name = "LblName"
            Me.LblName.Size = New System.Drawing.Size(125, 24)
            Me.LblName.TabIndex = 18
            Me.LblName.Text = "Guild Name:"
            Me.LblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'CmbGuildmaster
            '
            Me.CmbGuildmaster.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.CmbGuildmaster.Enabled = False
            Me.CmbGuildmaster.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CmbGuildmaster.FormattingEnabled = True
            Me.CmbGuildmaster.Items.AddRange(New Object() {"Computer"})
            Me.CmbGuildmaster.Location = New System.Drawing.Point(145, 171)
            Me.CmbGuildmaster.Name = "CmbGuildmaster"
            Me.CmbGuildmaster.Size = New System.Drawing.Size(176, 26)
            Me.CmbGuildmaster.TabIndex = 2
            '
            'LblGuildmaster
            '
            Me.LblGuildmaster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblGuildmaster.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblGuildmaster.Location = New System.Drawing.Point(13, 170)
            Me.LblGuildmaster.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.LblGuildmaster.Name = "LblGuildmaster"
            Me.LblGuildmaster.Size = New System.Drawing.Size(125, 24)
            Me.LblGuildmaster.TabIndex = 19
            Me.LblGuildmaster.Text = "Guildmaster:"
            Me.LblGuildmaster.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'LblFee
            '
            Me.LblFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblFee.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblFee.Location = New System.Drawing.Point(13, 200)
            Me.LblFee.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.LblFee.Name = "LblFee"
            Me.LblFee.Size = New System.Drawing.Size(125, 24)
            Me.LblFee.TabIndex = 20
            Me.LblFee.Text = "Entrance Fee:"
            Me.LblFee.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'TxtEntranceFee
            '
            Me.TxtEntranceFee.Enabled = False
            Me.TxtEntranceFee.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TxtEntranceFee.Location = New System.Drawing.Point(146, 201)
            Me.TxtEntranceFee.Margin = New System.Windows.Forms.Padding(4)
            Me.TxtEntranceFee.MaxLength = 4
            Me.TxtEntranceFee.Name = "TxtEntranceFee"
            Me.TxtEntranceFee.Size = New System.Drawing.Size(73, 26)
            Me.TxtEntranceFee.TabIndex = 3
            Me.TxtEntranceFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'TxtGuildGold
            '
            Me.TxtGuildGold.Enabled = False
            Me.TxtGuildGold.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TxtGuildGold.Location = New System.Drawing.Point(146, 231)
            Me.TxtGuildGold.Margin = New System.Windows.Forms.Padding(4)
            Me.TxtGuildGold.MaxLength = 6
            Me.TxtGuildGold.Name = "TxtGuildGold"
            Me.TxtGuildGold.Size = New System.Drawing.Size(73, 26)
            Me.TxtGuildGold.TabIndex = 4
            Me.TxtGuildGold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'LblGuildGold
            '
            Me.LblGuildGold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblGuildGold.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblGuildGold.Location = New System.Drawing.Point(13, 230)
            Me.LblGuildGold.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.LblGuildGold.Name = "LblGuildGold"
            Me.LblGuildGold.Size = New System.Drawing.Size(125, 24)
            Me.LblGuildGold.TabIndex = 21
            Me.LblGuildGold.Text = "Guild Gold:"
            Me.LblGuildGold.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'TxtHenchmenLevel1
            '
            Me.TxtHenchmenLevel1.Enabled = False
            Me.TxtHenchmenLevel1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TxtHenchmenLevel1.Location = New System.Drawing.Point(146, 261)
            Me.TxtHenchmenLevel1.Margin = New System.Windows.Forms.Padding(4)
            Me.TxtHenchmenLevel1.MaxLength = 3
            Me.TxtHenchmenLevel1.Name = "TxtHenchmenLevel1"
            Me.TxtHenchmenLevel1.Size = New System.Drawing.Size(73, 26)
            Me.TxtHenchmenLevel1.TabIndex = 5
            Me.TxtHenchmenLevel1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'TxtHenchmenLevel2
            '
            Me.TxtHenchmenLevel2.Enabled = False
            Me.TxtHenchmenLevel2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TxtHenchmenLevel2.Location = New System.Drawing.Point(146, 291)
            Me.TxtHenchmenLevel2.Margin = New System.Windows.Forms.Padding(4)
            Me.TxtHenchmenLevel2.MaxLength = 3
            Me.TxtHenchmenLevel2.Name = "TxtHenchmenLevel2"
            Me.TxtHenchmenLevel2.Size = New System.Drawing.Size(73, 26)
            Me.TxtHenchmenLevel2.TabIndex = 6
            Me.TxtHenchmenLevel2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'TxtHenchmenLevel3
            '
            Me.TxtHenchmenLevel3.Enabled = False
            Me.TxtHenchmenLevel3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TxtHenchmenLevel3.Location = New System.Drawing.Point(146, 321)
            Me.TxtHenchmenLevel3.Margin = New System.Windows.Forms.Padding(4)
            Me.TxtHenchmenLevel3.MaxLength = 3
            Me.TxtHenchmenLevel3.Name = "TxtHenchmenLevel3"
            Me.TxtHenchmenLevel3.Size = New System.Drawing.Size(73, 26)
            Me.TxtHenchmenLevel3.TabIndex = 7
            Me.TxtHenchmenLevel3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'TxtHenchmenLevel4
            '
            Me.TxtHenchmenLevel4.Enabled = False
            Me.TxtHenchmenLevel4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TxtHenchmenLevel4.Location = New System.Drawing.Point(146, 352)
            Me.TxtHenchmenLevel4.Margin = New System.Windows.Forms.Padding(4)
            Me.TxtHenchmenLevel4.MaxLength = 3
            Me.TxtHenchmenLevel4.Name = "TxtHenchmenLevel4"
            Me.TxtHenchmenLevel4.Size = New System.Drawing.Size(73, 26)
            Me.TxtHenchmenLevel4.TabIndex = 8
            Me.TxtHenchmenLevel4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'TxtHenchmenLevel5
            '
            Me.TxtHenchmenLevel5.Enabled = False
            Me.TxtHenchmenLevel5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TxtHenchmenLevel5.Location = New System.Drawing.Point(146, 382)
            Me.TxtHenchmenLevel5.Margin = New System.Windows.Forms.Padding(4)
            Me.TxtHenchmenLevel5.MaxLength = 3
            Me.TxtHenchmenLevel5.Name = "TxtHenchmenLevel5"
            Me.TxtHenchmenLevel5.Size = New System.Drawing.Size(73, 26)
            Me.TxtHenchmenLevel5.TabIndex = 9
            Me.TxtHenchmenLevel5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'LblHenchmenLevel5
            '
            Me.LblHenchmenLevel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblHenchmenLevel5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblHenchmenLevel5.Location = New System.Drawing.Point(13, 381)
            Me.LblHenchmenLevel5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.LblHenchmenLevel5.Name = "LblHenchmenLevel5"
            Me.LblHenchmenLevel5.Size = New System.Drawing.Size(125, 24)
            Me.LblHenchmenLevel5.TabIndex = 26
            Me.LblHenchmenLevel5.Text = "Lvl 5 Henchmen:"
            Me.LblHenchmenLevel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'LblHenchmenLevel4
            '
            Me.LblHenchmenLevel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblHenchmenLevel4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblHenchmenLevel4.Location = New System.Drawing.Point(13, 351)
            Me.LblHenchmenLevel4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.LblHenchmenLevel4.Name = "LblHenchmenLevel4"
            Me.LblHenchmenLevel4.Size = New System.Drawing.Size(125, 24)
            Me.LblHenchmenLevel4.TabIndex = 25
            Me.LblHenchmenLevel4.Text = "Lvl 4 Henchmen:"
            Me.LblHenchmenLevel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'LblHenchmenLevel3
            '
            Me.LblHenchmenLevel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblHenchmenLevel3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblHenchmenLevel3.Location = New System.Drawing.Point(13, 320)
            Me.LblHenchmenLevel3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.LblHenchmenLevel3.Name = "LblHenchmenLevel3"
            Me.LblHenchmenLevel3.Size = New System.Drawing.Size(125, 24)
            Me.LblHenchmenLevel3.TabIndex = 24
            Me.LblHenchmenLevel3.Text = "Lvl 3 Henchmen:"
            Me.LblHenchmenLevel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'LblHenchmenLevel2
            '
            Me.LblHenchmenLevel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblHenchmenLevel2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblHenchmenLevel2.Location = New System.Drawing.Point(13, 290)
            Me.LblHenchmenLevel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.LblHenchmenLevel2.Name = "LblHenchmenLevel2"
            Me.LblHenchmenLevel2.Size = New System.Drawing.Size(125, 24)
            Me.LblHenchmenLevel2.TabIndex = 23
            Me.LblHenchmenLevel2.Text = "Lvl 2 Henchmen:"
            Me.LblHenchmenLevel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'LblHenchmenLevel1
            '
            Me.LblHenchmenLevel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblHenchmenLevel1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblHenchmenLevel1.Location = New System.Drawing.Point(13, 260)
            Me.LblHenchmenLevel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.LblHenchmenLevel1.Name = "LblHenchmenLevel1"
            Me.LblHenchmenLevel1.Size = New System.Drawing.Size(125, 24)
            Me.LblHenchmenLevel1.TabIndex = 22
            Me.LblHenchmenLevel1.Text = "Lvl 1 Henchmen:"
            Me.LblHenchmenLevel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'BtnClear
            '
            Me.BtnClear.Enabled = False
            Me.BtnClear.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnClear.Location = New System.Drawing.Point(379, 308)
            Me.BtnClear.Margin = New System.Windows.Forms.Padding(4)
            Me.BtnClear.Name = "BtnClear"
            Me.BtnClear.Size = New System.Drawing.Size(125, 30)
            Me.BtnClear.TabIndex = 13
            Me.BtnClear.Text = "&Clear"
            Me.BtnClear.UseVisualStyleBackColor = True
            '
            'BtnExpel
            '
            Me.BtnExpel.Enabled = False
            Me.BtnExpel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnExpel.Location = New System.Drawing.Point(379, 270)
            Me.BtnExpel.Margin = New System.Windows.Forms.Padding(4)
            Me.BtnExpel.Name = "BtnExpel"
            Me.BtnExpel.Size = New System.Drawing.Size(125, 30)
            Me.BtnExpel.TabIndex = 12
            Me.BtnExpel.Text = "&Expel Member"
            Me.BtnExpel.UseVisualStyleBackColor = True
            '
            'BtnExit
            '
            Me.BtnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.BtnExit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnExit.Location = New System.Drawing.Point(379, 384)
            Me.BtnExit.Margin = New System.Windows.Forms.Padding(4)
            Me.BtnExit.Name = "BtnExit"
            Me.BtnExit.Size = New System.Drawing.Size(125, 30)
            Me.BtnExit.TabIndex = 15
            Me.BtnExit.Text = "E&xit"
            Me.BtnExit.UseVisualStyleBackColor = True
            '
            'BtnSave
            '
            Me.BtnSave.Enabled = False
            Me.BtnSave.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnSave.Location = New System.Drawing.Point(379, 346)
            Me.BtnSave.Margin = New System.Windows.Forms.Padding(4)
            Me.BtnSave.Name = "BtnSave"
            Me.BtnSave.Size = New System.Drawing.Size(125, 30)
            Me.BtnSave.TabIndex = 14
            Me.BtnSave.Text = "&Save"
            Me.BtnSave.UseVisualStyleBackColor = True
            '
            'BtnAddMember
            '
            Me.BtnAddMember.Enabled = False
            Me.BtnAddMember.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnAddMember.Location = New System.Drawing.Point(379, 232)
            Me.BtnAddMember.Margin = New System.Windows.Forms.Padding(4)
            Me.BtnAddMember.Name = "BtnAddMember"
            Me.BtnAddMember.Size = New System.Drawing.Size(125, 30)
            Me.BtnAddMember.TabIndex = 11
            Me.BtnAddMember.Text = "&Add Member"
            Me.BtnAddMember.UseVisualStyleBackColor = True
            '
            'LblMembers
            '
            Me.LblMembers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblMembers.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblMembers.Location = New System.Drawing.Point(328, 9)
            Me.LblMembers.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.LblMembers.Name = "LblMembers"
            Me.LblMembers.Size = New System.Drawing.Size(225, 24)
            Me.LblMembers.TabIndex = 17
            Me.LblMembers.Text = "Guild Members"
            Me.LblMembers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'LstMembers
            '
            Me.LstMembers.Enabled = False
            Me.LstMembers.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LstMembers.FormattingEnabled = True
            Me.LstMembers.ItemHeight = 18
            Me.LstMembers.Location = New System.Drawing.Point(329, 37)
            Me.LstMembers.Margin = New System.Windows.Forms.Padding(4)
            Me.LstMembers.Name = "LstMembers"
            Me.LstMembers.ScrollAlwaysVisible = True
            Me.LstMembers.Size = New System.Drawing.Size(225, 184)
            Me.LstMembers.Sorted = True
            Me.LstMembers.TabIndex = 10
            '
            'LblGuilds
            '
            Me.LblGuilds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblGuilds.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblGuilds.Location = New System.Drawing.Point(13, 9)
            Me.LblGuilds.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.LblGuilds.Name = "LblGuilds"
            Me.LblGuilds.Size = New System.Drawing.Size(225, 24)
            Me.LblGuilds.TabIndex = 16
            Me.LblGuilds.Text = "Guilds"
            Me.LblGuilds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'FrmAdminGuilds
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.BtnExit
            Me.ClientSize = New System.Drawing.Size(567, 426)
            Me.Controls.Add(Me.LblGuilds)
            Me.Controls.Add(Me.LstMembers)
            Me.Controls.Add(Me.LblMembers)
            Me.Controls.Add(Me.BtnAddMember)
            Me.Controls.Add(Me.BtnExit)
            Me.Controls.Add(Me.BtnSave)
            Me.Controls.Add(Me.BtnClear)
            Me.Controls.Add(Me.BtnExpel)
            Me.Controls.Add(Me.TxtHenchmenLevel1)
            Me.Controls.Add(Me.TxtHenchmenLevel2)
            Me.Controls.Add(Me.TxtHenchmenLevel3)
            Me.Controls.Add(Me.TxtHenchmenLevel4)
            Me.Controls.Add(Me.TxtHenchmenLevel5)
            Me.Controls.Add(Me.LblHenchmenLevel5)
            Me.Controls.Add(Me.LblHenchmenLevel4)
            Me.Controls.Add(Me.LblHenchmenLevel3)
            Me.Controls.Add(Me.LblHenchmenLevel2)
            Me.Controls.Add(Me.LblHenchmenLevel1)
            Me.Controls.Add(Me.TxtGuildGold)
            Me.Controls.Add(Me.LblGuildGold)
            Me.Controls.Add(Me.TxtEntranceFee)
            Me.Controls.Add(Me.LblFee)
            Me.Controls.Add(Me.CmbGuildmaster)
            Me.Controls.Add(Me.LblGuildmaster)
            Me.Controls.Add(Me.TxtName)
            Me.Controls.Add(Me.LblName)
            Me.Controls.Add(Me.LstGuilds)
            Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Margin = New System.Windows.Forms.Padding(4)
            Me.MaximizeBox = False
            Me.MaximumSize = New System.Drawing.Size(583, 465)
            Me.MinimumSize = New System.Drawing.Size(583, 465)
            Me.Name = "FrmAdminGuilds"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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