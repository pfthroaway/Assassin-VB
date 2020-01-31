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
            Me.lstGuilds = New ListBox()
            Me.txtName = New TextBox()
            Me.lblName = New Label()
            Me.cmbGuildmaster = New ComboBox()
            Me.lblGuildmaster = New Label()
            Me.lblFee = New Label()
            Me.txtEntranceFee = New TextBox()
            Me.txtGuildGold = New TextBox()
            Me.lblGuildGold = New Label()
            Me.txtHenchmenLevel1 = New TextBox()
            Me.txtHenchmenLevel2 = New TextBox()
            Me.txtHenchmenLevel3 = New TextBox()
            Me.txtHenchmenLevel4 = New TextBox()
            Me.txtHenchmenLevel5 = New TextBox()
            Me.lblHenchmenLevel5 = New Label()
            Me.lblHenchmenLevel4 = New Label()
            Me.lblHenchmenLevel3 = New Label()
            Me.lblHenchmenLevel2 = New Label()
            Me.lblHenchmenLevel1 = New Label()
            Me.btnClear = New Button()
            Me.btnExpel = New Button()
            Me.btnExit = New Button()
            Me.btnSave = New Button()
            Me.btnAddMember = New Button()
            Me.lblMembers = New Label()
            Me.lstMembers = New ListBox()
            Me.lblGuilds = New Label()
            Me.SuspendLayout()
            '
            'lstGuilds
            '
            Me.lstGuilds.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lstGuilds.FormattingEnabled = True
            Me.lstGuilds.ItemHeight = 18
            Me.lstGuilds.Location = New Point(13, 37)
            Me.lstGuilds.Margin = New Padding(4)
            Me.lstGuilds.Name = "lstGuilds"
            Me.lstGuilds.ScrollAlwaysVisible = True
            Me.lstGuilds.Size = New Size(225, 94)
            Me.lstGuilds.TabIndex = 0
            '
            'txtName
            '
            Me.txtName.Enabled = False
            Me.txtName.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.txtName.Location = New Point(146, 141)
            Me.txtName.Margin = New Padding(4)
            Me.txtName.MaxLength = 30
            Me.txtName.Name = "txtName"
            Me.txtName.Size = New Size(175, 22)
            Me.txtName.TabIndex = 1
            Me.txtName.TextAlign = HorizontalAlignment.Center
            '
            'lblName
            '
            Me.lblName.BorderStyle = BorderStyle.FixedSingle
            Me.lblName.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblName.Location = New Point(13, 140)
            Me.lblName.Margin = New Padding(4, 0, 4, 0)
            Me.lblName.Name = "lblName"
            Me.lblName.Size = New Size(125, 24)
            Me.lblName.TabIndex = 18
            Me.lblName.Text = "Guild Name:"
            Me.lblName.TextAlign = ContentAlignment.MiddleRight
            '
            'cmbGuildmaster
            '
            Me.cmbGuildmaster.DropDownStyle = ComboBoxStyle.DropDownList
            Me.cmbGuildmaster.Enabled = False
            Me.cmbGuildmaster.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.cmbGuildmaster.FormattingEnabled = True
            Me.cmbGuildmaster.Items.AddRange(New Object() {"Computer"})
            Me.cmbGuildmaster.Location = New Point(145, 171)
            Me.cmbGuildmaster.Name = "cmbGuildmaster"
            Me.cmbGuildmaster.Size = New Size(176, 24)
            Me.cmbGuildmaster.TabIndex = 2
            '
            'lblGuildmaster
            '
            Me.lblGuildmaster.BorderStyle = BorderStyle.FixedSingle
            Me.lblGuildmaster.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblGuildmaster.Location = New Point(13, 170)
            Me.lblGuildmaster.Margin = New Padding(4, 0, 4, 0)
            Me.lblGuildmaster.Name = "lblGuildmaster"
            Me.lblGuildmaster.Size = New Size(125, 24)
            Me.lblGuildmaster.TabIndex = 19
            Me.lblGuildmaster.Text = "Guildmaster:"
            Me.lblGuildmaster.TextAlign = ContentAlignment.MiddleRight
            '
            'lblFee
            '
            Me.lblFee.BorderStyle = BorderStyle.FixedSingle
            Me.lblFee.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblFee.Location = New Point(13, 200)
            Me.lblFee.Margin = New Padding(4, 0, 4, 0)
            Me.lblFee.Name = "lblFee"
            Me.lblFee.Size = New Size(125, 24)
            Me.lblFee.TabIndex = 20
            Me.lblFee.Text = "Entrance Fee:"
            Me.lblFee.TextAlign = ContentAlignment.MiddleRight
            '
            'txtEntranceFee
            '
            Me.txtEntranceFee.Enabled = False
            Me.txtEntranceFee.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
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
            Me.txtGuildGold.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.txtGuildGold.Location = New Point(146, 231)
            Me.txtGuildGold.Margin = New Padding(4)
            Me.txtGuildGold.MaxLength = 6
            Me.txtGuildGold.Name = "txtGuildGold"
            Me.txtGuildGold.Size = New Size(73, 22)
            Me.txtGuildGold.TabIndex = 4
            Me.txtGuildGold.TextAlign = HorizontalAlignment.Center
            '
            'lblGuildGold
            '
            Me.lblGuildGold.BorderStyle = BorderStyle.FixedSingle
            Me.lblGuildGold.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblGuildGold.Location = New Point(13, 230)
            Me.lblGuildGold.Margin = New Padding(4, 0, 4, 0)
            Me.lblGuildGold.Name = "lblGuildGold"
            Me.lblGuildGold.Size = New Size(125, 24)
            Me.lblGuildGold.TabIndex = 21
            Me.lblGuildGold.Text = "Guild Gold:"
            Me.lblGuildGold.TextAlign = ContentAlignment.MiddleRight
            '
            'txtHenchmenLevel1
            '
            Me.txtHenchmenLevel1.Enabled = False
            Me.txtHenchmenLevel1.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
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
            Me.txtHenchmenLevel2.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
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
            Me.txtHenchmenLevel3.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
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
            Me.txtHenchmenLevel4.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
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
            Me.txtHenchmenLevel5.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.txtHenchmenLevel5.Location = New Point(146, 382)
            Me.txtHenchmenLevel5.Margin = New Padding(4)
            Me.txtHenchmenLevel5.MaxLength = 3
            Me.txtHenchmenLevel5.Name = "txtHenchmenLevel5"
            Me.txtHenchmenLevel5.Size = New Size(73, 22)
            Me.txtHenchmenLevel5.TabIndex = 9
            Me.txtHenchmenLevel5.TextAlign = HorizontalAlignment.Center
            '
            'lblHenchmenLevel5
            '
            Me.lblHenchmenLevel5.BorderStyle = BorderStyle.FixedSingle
            Me.lblHenchmenLevel5.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblHenchmenLevel5.Location = New Point(13, 381)
            Me.lblHenchmenLevel5.Margin = New Padding(4, 0, 4, 0)
            Me.lblHenchmenLevel5.Name = "lblHenchmenLevel5"
            Me.lblHenchmenLevel5.Size = New Size(125, 24)
            Me.lblHenchmenLevel5.TabIndex = 26
            Me.lblHenchmenLevel5.Text = "Lvl 5 Henchmen:"
            Me.lblHenchmenLevel5.TextAlign = ContentAlignment.MiddleRight
            '
            'lblHenchmenLevel4
            '
            Me.lblHenchmenLevel4.BorderStyle = BorderStyle.FixedSingle
            Me.lblHenchmenLevel4.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblHenchmenLevel4.Location = New Point(13, 351)
            Me.lblHenchmenLevel4.Margin = New Padding(4, 0, 4, 0)
            Me.lblHenchmenLevel4.Name = "lblHenchmenLevel4"
            Me.lblHenchmenLevel4.Size = New Size(125, 24)
            Me.lblHenchmenLevel4.TabIndex = 25
            Me.lblHenchmenLevel4.Text = "Lvl 4 Henchmen:"
            Me.lblHenchmenLevel4.TextAlign = ContentAlignment.MiddleRight
            '
            'lblHenchmenLevel3
            '
            Me.lblHenchmenLevel3.BorderStyle = BorderStyle.FixedSingle
            Me.lblHenchmenLevel3.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblHenchmenLevel3.Location = New Point(13, 320)
            Me.lblHenchmenLevel3.Margin = New Padding(4, 0, 4, 0)
            Me.lblHenchmenLevel3.Name = "lblHenchmenLevel3"
            Me.lblHenchmenLevel3.Size = New Size(125, 24)
            Me.lblHenchmenLevel3.TabIndex = 24
            Me.lblHenchmenLevel3.Text = "Lvl 3 Henchmen:"
            Me.lblHenchmenLevel3.TextAlign = ContentAlignment.MiddleRight
            '
            'lblHenchmenLevel2
            '
            Me.lblHenchmenLevel2.BorderStyle = BorderStyle.FixedSingle
            Me.lblHenchmenLevel2.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblHenchmenLevel2.Location = New Point(13, 290)
            Me.lblHenchmenLevel2.Margin = New Padding(4, 0, 4, 0)
            Me.lblHenchmenLevel2.Name = "lblHenchmenLevel2"
            Me.lblHenchmenLevel2.Size = New Size(125, 24)
            Me.lblHenchmenLevel2.TabIndex = 23
            Me.lblHenchmenLevel2.Text = "Lvl 2 Henchmen:"
            Me.lblHenchmenLevel2.TextAlign = ContentAlignment.MiddleRight
            '
            'lblHenchmenLevel1
            '
            Me.lblHenchmenLevel1.BorderStyle = BorderStyle.FixedSingle
            Me.lblHenchmenLevel1.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblHenchmenLevel1.Location = New Point(13, 260)
            Me.lblHenchmenLevel1.Margin = New Padding(4, 0, 4, 0)
            Me.lblHenchmenLevel1.Name = "lblHenchmenLevel1"
            Me.lblHenchmenLevel1.Size = New Size(125, 24)
            Me.lblHenchmenLevel1.TabIndex = 22
            Me.lblHenchmenLevel1.Text = "Lvl 1 Henchmen:"
            Me.lblHenchmenLevel1.TextAlign = ContentAlignment.MiddleRight
            '
            'btnClear
            '
            Me.btnClear.Enabled = False
            Me.btnClear.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnClear.Location = New Point(379, 308)
            Me.btnClear.Margin = New Padding(4)
            Me.btnClear.Name = "btnClear"
            Me.btnClear.Size = New Size(125, 30)
            Me.btnClear.TabIndex = 13
            Me.btnClear.Text = "&Clear"
            Me.btnClear.UseVisualStyleBackColor = True
            '
            'btnExpel
            '
            Me.btnExpel.Enabled = False
            Me.btnExpel.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnExpel.Location = New Point(379, 270)
            Me.btnExpel.Margin = New Padding(4)
            Me.btnExpel.Name = "btnExpel"
            Me.btnExpel.Size = New Size(125, 30)
            Me.btnExpel.TabIndex = 12
            Me.btnExpel.Text = "&Expel Member"
            Me.btnExpel.UseVisualStyleBackColor = True
            '
            'btnExit
            '
            Me.btnExit.DialogResult = DialogResult.Cancel
            Me.btnExit.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnExit.Location = New Point(379, 384)
            Me.btnExit.Margin = New Padding(4)
            Me.btnExit.Name = "btnExit"
            Me.btnExit.Size = New Size(125, 30)
            Me.btnExit.TabIndex = 15
            Me.btnExit.Text = "E&xit"
            Me.btnExit.UseVisualStyleBackColor = True
            '
            'btnSave
            '
            Me.btnSave.Enabled = False
            Me.btnSave.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnSave.Location = New Point(379, 346)
            Me.btnSave.Margin = New Padding(4)
            Me.btnSave.Name = "btnSave"
            Me.btnSave.Size = New Size(125, 30)
            Me.btnSave.TabIndex = 14
            Me.btnSave.Text = "&Save"
            Me.btnSave.UseVisualStyleBackColor = True
            '
            'btnAddMember
            '
            Me.btnAddMember.Enabled = False
            Me.btnAddMember.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnAddMember.Location = New Point(379, 232)
            Me.btnAddMember.Margin = New Padding(4)
            Me.btnAddMember.Name = "btnAddMember"
            Me.btnAddMember.Size = New Size(125, 30)
            Me.btnAddMember.TabIndex = 11
            Me.btnAddMember.Text = "&Add Member"
            Me.btnAddMember.UseVisualStyleBackColor = True
            '
            'lblMembers
            '
            Me.lblMembers.BorderStyle = BorderStyle.FixedSingle
            Me.lblMembers.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.lblMembers.Location = New Point(328, 9)
            Me.lblMembers.Margin = New Padding(4, 0, 4, 0)
            Me.lblMembers.Name = "lblMembers"
            Me.lblMembers.Size = New Size(225, 24)
            Me.lblMembers.TabIndex = 17
            Me.lblMembers.Text = "Guild Members"
            Me.lblMembers.TextAlign = ContentAlignment.MiddleCenter
            '
            'lstMembers
            '
            Me.lstMembers.Enabled = False
            Me.lstMembers.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lstMembers.FormattingEnabled = True
            Me.lstMembers.ItemHeight = 18
            Me.lstMembers.Location = New Point(329, 37)
            Me.lstMembers.Margin = New Padding(4)
            Me.lstMembers.Name = "lstMembers"
            Me.lstMembers.ScrollAlwaysVisible = True
            Me.lstMembers.Size = New Size(225, 184)
            Me.lstMembers.Sorted = True
            Me.lstMembers.TabIndex = 10
            '
            'lblGuilds
            '
            Me.lblGuilds.BorderStyle = BorderStyle.FixedSingle
            Me.lblGuilds.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.lblGuilds.Location = New Point(13, 9)
            Me.lblGuilds.Margin = New Padding(4, 0, 4, 0)
            Me.lblGuilds.Name = "lblGuilds"
            Me.lblGuilds.Size = New Size(225, 24)
            Me.lblGuilds.TabIndex = 16
            Me.lblGuilds.Text = "Guilds"
            Me.lblGuilds.TextAlign = ContentAlignment.MiddleCenter
            '
            'frmAdminGuilds
            '
            Me.AutoScaleDimensions = New SizeF(9.0!, 18.0!)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.CancelButton = Me.btnExit
            Me.ClientSize = New Size(567, 427)
            Me.Controls.Add(Me.lblGuilds)
            Me.Controls.Add(Me.lstMembers)
            Me.Controls.Add(Me.lblMembers)
            Me.Controls.Add(Me.btnAddMember)
            Me.Controls.Add(Me.btnExit)
            Me.Controls.Add(Me.btnSave)
            Me.Controls.Add(Me.btnClear)
            Me.Controls.Add(Me.btnExpel)
            Me.Controls.Add(Me.txtHenchmenLevel1)
            Me.Controls.Add(Me.txtHenchmenLevel2)
            Me.Controls.Add(Me.txtHenchmenLevel3)
            Me.Controls.Add(Me.txtHenchmenLevel4)
            Me.Controls.Add(Me.txtHenchmenLevel5)
            Me.Controls.Add(Me.lblHenchmenLevel5)
            Me.Controls.Add(Me.lblHenchmenLevel4)
            Me.Controls.Add(Me.lblHenchmenLevel3)
            Me.Controls.Add(Me.lblHenchmenLevel2)
            Me.Controls.Add(Me.lblHenchmenLevel1)
            Me.Controls.Add(Me.txtGuildGold)
            Me.Controls.Add(Me.lblGuildGold)
            Me.Controls.Add(Me.txtEntranceFee)
            Me.Controls.Add(Me.lblFee)
            Me.Controls.Add(Me.cmbGuildmaster)
            Me.Controls.Add(Me.lblGuildmaster)
            Me.Controls.Add(Me.txtName)
            Me.Controls.Add(Me.lblName)
            Me.Controls.Add(Me.lstGuilds)
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
        Friend WithEvents lblName As Label
        Friend WithEvents CmbGuildmaster As ComboBox
        Friend WithEvents lblGuildmaster As Label
        Friend WithEvents lblFee As Label
        Friend WithEvents TxtEntranceFee As TextBox
        Friend WithEvents TxtGuildGold As TextBox
        Friend WithEvents lblGuildGold As Label
        Friend WithEvents TxtHenchmenLevel1 As TextBox
        Friend WithEvents TxtHenchmenLevel2 As TextBox
        Friend WithEvents TxtHenchmenLevel3 As TextBox
        Friend WithEvents TxtHenchmenLevel4 As TextBox
        Friend WithEvents TxtHenchmenLevel5 As TextBox
        Friend WithEvents lblHenchmenLevel5 As Label
        Friend WithEvents lblHenchmenLevel4 As Label
        Friend WithEvents lblHenchmenLevel3 As Label
        Friend WithEvents lblHenchmenLevel2 As Label
        Friend WithEvents lblHenchmenLevel1 As Label
        Friend WithEvents BtnClear As Button
        Friend WithEvents BtnExpel As Button
        Friend WithEvents BtnExit As Button
        Friend WithEvents BtnSave As Button
        Friend WithEvents BtnAddMember As Button
        Friend WithEvents lblMembers As Label
        Friend WithEvents LstMembers As ListBox
        Friend WithEvents lblGuilds As Label
    End Class
End NameSpace