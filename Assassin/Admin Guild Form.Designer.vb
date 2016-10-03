<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminGuilds
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
        Me.lstGuilds = New System.Windows.Forms.ListBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.cmbGuildmaster = New System.Windows.Forms.ComboBox()
        Me.lblGuildmaster = New System.Windows.Forms.Label()
        Me.lblFee = New System.Windows.Forms.Label()
        Me.txtEntranceFee = New System.Windows.Forms.TextBox()
        Me.txtGuildGold = New System.Windows.Forms.TextBox()
        Me.lblGuildGold = New System.Windows.Forms.Label()
        Me.txtHench1 = New System.Windows.Forms.TextBox()
        Me.txtHench2 = New System.Windows.Forms.TextBox()
        Me.txtHench3 = New System.Windows.Forms.TextBox()
        Me.txtHench4 = New System.Windows.Forms.TextBox()
        Me.txtHench5 = New System.Windows.Forms.TextBox()
        Me.lblHench5 = New System.Windows.Forms.Label()
        Me.lblHench4 = New System.Windows.Forms.Label()
        Me.lblHench3 = New System.Windows.Forms.Label()
        Me.lblHench2 = New System.Windows.Forms.Label()
        Me.lblHench1 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExpel = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAddMember = New System.Windows.Forms.Button()
        Me.lblMembers = New System.Windows.Forms.Label()
        Me.lstMembers = New System.Windows.Forms.ListBox()
        Me.lblGuilds = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstGuilds
        '
        Me.lstGuilds.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstGuilds.FormattingEnabled = True
        Me.lstGuilds.ItemHeight = 18
        Me.lstGuilds.Location = New System.Drawing.Point(13, 37)
        Me.lstGuilds.Margin = New System.Windows.Forms.Padding(4)
        Me.lstGuilds.Name = "lstGuilds"
        Me.lstGuilds.ScrollAlwaysVisible = True
        Me.lstGuilds.Size = New System.Drawing.Size(225, 94)
        Me.lstGuilds.TabIndex = 0
        '
        'txtName
        '
        Me.txtName.Enabled = False
        Me.txtName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(146, 141)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtName.MaxLength = 30
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(175, 22)
        Me.txtName.TabIndex = 1
        Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblName
        '
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(13, 140)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(125, 24)
        Me.lblName.TabIndex = 18
        Me.lblName.Text = "Guild Name:"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbGuildmaster
        '
        Me.cmbGuildmaster.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGuildmaster.Enabled = False
        Me.cmbGuildmaster.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGuildmaster.FormattingEnabled = True
        Me.cmbGuildmaster.Items.AddRange(New Object() {"Computer"})
        Me.cmbGuildmaster.Location = New System.Drawing.Point(145, 171)
        Me.cmbGuildmaster.Name = "cmbGuildmaster"
        Me.cmbGuildmaster.Size = New System.Drawing.Size(176, 24)
        Me.cmbGuildmaster.TabIndex = 2
        '
        'lblGuildmaster
        '
        Me.lblGuildmaster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGuildmaster.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuildmaster.Location = New System.Drawing.Point(13, 170)
        Me.lblGuildmaster.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGuildmaster.Name = "lblGuildmaster"
        Me.lblGuildmaster.Size = New System.Drawing.Size(125, 24)
        Me.lblGuildmaster.TabIndex = 19
        Me.lblGuildmaster.Text = "Guildmaster:"
        Me.lblGuildmaster.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFee
        '
        Me.lblFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFee.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFee.Location = New System.Drawing.Point(13, 200)
        Me.lblFee.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFee.Name = "lblFee"
        Me.lblFee.Size = New System.Drawing.Size(125, 24)
        Me.lblFee.TabIndex = 20
        Me.lblFee.Text = "Entrance Fee:"
        Me.lblFee.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtEntranceFee
        '
        Me.txtEntranceFee.Enabled = False
        Me.txtEntranceFee.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEntranceFee.Location = New System.Drawing.Point(146, 201)
        Me.txtEntranceFee.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEntranceFee.MaxLength = 4
        Me.txtEntranceFee.Name = "txtEntranceFee"
        Me.txtEntranceFee.Size = New System.Drawing.Size(73, 22)
        Me.txtEntranceFee.TabIndex = 3
        Me.txtEntranceFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtGuildGold
        '
        Me.txtGuildGold.Enabled = False
        Me.txtGuildGold.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuildGold.Location = New System.Drawing.Point(146, 231)
        Me.txtGuildGold.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGuildGold.MaxLength = 6
        Me.txtGuildGold.Name = "txtGuildGold"
        Me.txtGuildGold.Size = New System.Drawing.Size(73, 22)
        Me.txtGuildGold.TabIndex = 4
        Me.txtGuildGold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblGuildGold
        '
        Me.lblGuildGold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGuildGold.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuildGold.Location = New System.Drawing.Point(13, 230)
        Me.lblGuildGold.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGuildGold.Name = "lblGuildGold"
        Me.lblGuildGold.Size = New System.Drawing.Size(125, 24)
        Me.lblGuildGold.TabIndex = 21
        Me.lblGuildGold.Text = "Guild Gold:"
        Me.lblGuildGold.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtHench1
        '
        Me.txtHench1.Enabled = False
        Me.txtHench1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHench1.Location = New System.Drawing.Point(146, 261)
        Me.txtHench1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHench1.MaxLength = 3
        Me.txtHench1.Name = "txtHench1"
        Me.txtHench1.Size = New System.Drawing.Size(73, 22)
        Me.txtHench1.TabIndex = 5
        Me.txtHench1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtHench2
        '
        Me.txtHench2.Enabled = False
        Me.txtHench2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHench2.Location = New System.Drawing.Point(146, 291)
        Me.txtHench2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHench2.MaxLength = 3
        Me.txtHench2.Name = "txtHench2"
        Me.txtHench2.Size = New System.Drawing.Size(73, 22)
        Me.txtHench2.TabIndex = 6
        Me.txtHench2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtHench3
        '
        Me.txtHench3.Enabled = False
        Me.txtHench3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHench3.Location = New System.Drawing.Point(146, 321)
        Me.txtHench3.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHench3.MaxLength = 3
        Me.txtHench3.Name = "txtHench3"
        Me.txtHench3.Size = New System.Drawing.Size(73, 22)
        Me.txtHench3.TabIndex = 7
        Me.txtHench3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtHench4
        '
        Me.txtHench4.Enabled = False
        Me.txtHench4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHench4.Location = New System.Drawing.Point(146, 352)
        Me.txtHench4.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHench4.MaxLength = 3
        Me.txtHench4.Name = "txtHench4"
        Me.txtHench4.Size = New System.Drawing.Size(73, 22)
        Me.txtHench4.TabIndex = 8
        Me.txtHench4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtHench5
        '
        Me.txtHench5.Enabled = False
        Me.txtHench5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHench5.Location = New System.Drawing.Point(146, 382)
        Me.txtHench5.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHench5.MaxLength = 3
        Me.txtHench5.Name = "txtHench5"
        Me.txtHench5.Size = New System.Drawing.Size(73, 22)
        Me.txtHench5.TabIndex = 9
        Me.txtHench5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblHench5
        '
        Me.lblHench5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHench5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHench5.Location = New System.Drawing.Point(13, 381)
        Me.lblHench5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHench5.Name = "lblHench5"
        Me.lblHench5.Size = New System.Drawing.Size(125, 24)
        Me.lblHench5.TabIndex = 26
        Me.lblHench5.Text = "Lvl 5 Henchmen:"
        Me.lblHench5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblHench4
        '
        Me.lblHench4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHench4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHench4.Location = New System.Drawing.Point(13, 351)
        Me.lblHench4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHench4.Name = "lblHench4"
        Me.lblHench4.Size = New System.Drawing.Size(125, 24)
        Me.lblHench4.TabIndex = 25
        Me.lblHench4.Text = "Lvl 4 Henchmen:"
        Me.lblHench4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblHench3
        '
        Me.lblHench3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHench3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHench3.Location = New System.Drawing.Point(13, 320)
        Me.lblHench3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHench3.Name = "lblHench3"
        Me.lblHench3.Size = New System.Drawing.Size(125, 24)
        Me.lblHench3.TabIndex = 24
        Me.lblHench3.Text = "Lvl 3 Henchmen:"
        Me.lblHench3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblHench2
        '
        Me.lblHench2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHench2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHench2.Location = New System.Drawing.Point(13, 290)
        Me.lblHench2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHench2.Name = "lblHench2"
        Me.lblHench2.Size = New System.Drawing.Size(125, 24)
        Me.lblHench2.TabIndex = 23
        Me.lblHench2.Text = "Lvl 2 Henchmen:"
        Me.lblHench2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblHench1
        '
        Me.lblHench1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHench1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHench1.Location = New System.Drawing.Point(13, 260)
        Me.lblHench1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHench1.Name = "lblHench1"
        Me.lblHench1.Size = New System.Drawing.Size(125, 24)
        Me.lblHench1.TabIndex = 22
        Me.lblHench1.Text = "Lvl 1 Henchmen:"
        Me.lblHench1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnClear
        '
        Me.btnClear.Enabled = False
        Me.btnClear.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(379, 308)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(125, 30)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExpel
        '
        Me.btnExpel.Enabled = False
        Me.btnExpel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExpel.Location = New System.Drawing.Point(379, 270)
        Me.btnExpel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExpel.Name = "btnExpel"
        Me.btnExpel.Size = New System.Drawing.Size(125, 30)
        Me.btnExpel.TabIndex = 12
        Me.btnExpel.Text = "&Expel Member"
        Me.btnExpel.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(379, 384)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(125, 30)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(379, 346)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(125, 30)
        Me.btnSave.TabIndex = 14
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnAddMember
        '
        Me.btnAddMember.Enabled = False
        Me.btnAddMember.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddMember.Location = New System.Drawing.Point(379, 232)
        Me.btnAddMember.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddMember.Name = "btnAddMember"
        Me.btnAddMember.Size = New System.Drawing.Size(125, 30)
        Me.btnAddMember.TabIndex = 11
        Me.btnAddMember.Text = "&Add Member"
        Me.btnAddMember.UseVisualStyleBackColor = True
        '
        'lblMembers
        '
        Me.lblMembers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMembers.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMembers.Location = New System.Drawing.Point(328, 9)
        Me.lblMembers.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMembers.Name = "lblMembers"
        Me.lblMembers.Size = New System.Drawing.Size(225, 24)
        Me.lblMembers.TabIndex = 17
        Me.lblMembers.Text = "Guild Members"
        Me.lblMembers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstMembers
        '
        Me.lstMembers.Enabled = False
        Me.lstMembers.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstMembers.FormattingEnabled = True
        Me.lstMembers.ItemHeight = 18
        Me.lstMembers.Location = New System.Drawing.Point(329, 37)
        Me.lstMembers.Margin = New System.Windows.Forms.Padding(4)
        Me.lstMembers.Name = "lstMembers"
        Me.lstMembers.ScrollAlwaysVisible = True
        Me.lstMembers.Size = New System.Drawing.Size(225, 184)
        Me.lstMembers.Sorted = True
        Me.lstMembers.TabIndex = 10
        '
        'lblGuilds
        '
        Me.lblGuilds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGuilds.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuilds.Location = New System.Drawing.Point(13, 9)
        Me.lblGuilds.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGuilds.Name = "lblGuilds"
        Me.lblGuilds.Size = New System.Drawing.Size(225, 24)
        Me.lblGuilds.TabIndex = 16
        Me.lblGuilds.Text = "Guilds"
        Me.lblGuilds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmAdminGuilds
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(567, 427)
        Me.Controls.Add(Me.lblGuilds)
        Me.Controls.Add(Me.lstMembers)
        Me.Controls.Add(Me.lblMembers)
        Me.Controls.Add(Me.btnAddMember)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExpel)
        Me.Controls.Add(Me.txtHench1)
        Me.Controls.Add(Me.txtHench2)
        Me.Controls.Add(Me.txtHench3)
        Me.Controls.Add(Me.txtHench4)
        Me.Controls.Add(Me.txtHench5)
        Me.Controls.Add(Me.lblHench5)
        Me.Controls.Add(Me.lblHench4)
        Me.Controls.Add(Me.lblHench3)
        Me.Controls.Add(Me.lblHench2)
        Me.Controls.Add(Me.lblHench1)
        Me.Controls.Add(Me.txtGuildGold)
        Me.Controls.Add(Me.lblGuildGold)
        Me.Controls.Add(Me.txtEntranceFee)
        Me.Controls.Add(Me.lblFee)
        Me.Controls.Add(Me.cmbGuildmaster)
        Me.Controls.Add(Me.lblGuildmaster)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lstGuilds)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(583, 465)
        Me.MinimumSize = New System.Drawing.Size(583, 465)
        Me.Name = "frmAdminGuilds"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin Guilds"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstGuilds As System.Windows.Forms.ListBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents cmbGuildmaster As System.Windows.Forms.ComboBox
    Friend WithEvents lblGuildmaster As System.Windows.Forms.Label
    Friend WithEvents lblFee As System.Windows.Forms.Label
    Friend WithEvents txtEntranceFee As System.Windows.Forms.TextBox
    Friend WithEvents txtGuildGold As System.Windows.Forms.TextBox
    Friend WithEvents lblGuildGold As System.Windows.Forms.Label
    Friend WithEvents txtHench1 As System.Windows.Forms.TextBox
    Friend WithEvents txtHench2 As System.Windows.Forms.TextBox
    Friend WithEvents txtHench3 As System.Windows.Forms.TextBox
    Friend WithEvents txtHench4 As System.Windows.Forms.TextBox
    Friend WithEvents txtHench5 As System.Windows.Forms.TextBox
    Friend WithEvents lblHench5 As System.Windows.Forms.Label
    Friend WithEvents lblHench4 As System.Windows.Forms.Label
    Friend WithEvents lblHench3 As System.Windows.Forms.Label
    Friend WithEvents lblHench2 As System.Windows.Forms.Label
    Friend WithEvents lblHench1 As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExpel As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnAddMember As System.Windows.Forms.Button
    Friend WithEvents lblMembers As System.Windows.Forms.Label
    Friend WithEvents lstMembers As System.Windows.Forms.ListBox
    Friend WithEvents lblGuilds As System.Windows.Forms.Label
End Class
