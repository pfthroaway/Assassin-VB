<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGuildTransfer
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
        Me.txtTransferGold = New System.Windows.Forms.TextBox()
        Me.txtGuildGold = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnTransfer = New System.Windows.Forms.Button()
        Me.txtTransfer = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTransfer5 = New System.Windows.Forms.TextBox()
        Me.txtTransfer4 = New System.Windows.Forms.TextBox()
        Me.txtTransfer3 = New System.Windows.Forms.TextBox()
        Me.txtTransfer2 = New System.Windows.Forms.TextBox()
        Me.txtTransfer1 = New System.Windows.Forms.TextBox()
        Me.txtGuild5 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtGuild4 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtGuild3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtGuild2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtGuild1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCurrentGold = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCurrent5 = New System.Windows.Forms.TextBox()
        Me.txtCurrent4 = New System.Windows.Forms.TextBox()
        Me.txtCurrent3 = New System.Windows.Forms.TextBox()
        Me.txtCurrent2 = New System.Windows.Forms.TextBox()
        Me.txtCurrent1 = New System.Windows.Forms.TextBox()
        Me.grpTransfer = New System.Windows.Forms.GroupBox()
        Me.radPlayer = New System.Windows.Forms.RadioButton()
        Me.radGuild = New System.Windows.Forms.RadioButton()
        Me.pctHelp = New System.Windows.Forms.PictureBox()
        Me.grpTransfer.SuspendLayout()
        CType(Me.pctHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTransferGold
        '
        Me.txtTransferGold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTransferGold.Location = New System.Drawing.Point(268, 303)
        Me.txtTransferGold.MaxLength = 6
        Me.txtTransferGold.Name = "txtTransferGold"
        Me.txtTransferGold.Size = New System.Drawing.Size(60, 26)
        Me.txtTransferGold.TabIndex = 6
        Me.txtTransferGold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtGuildGold
        '
        Me.txtGuildGold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGuildGold.Location = New System.Drawing.Point(118, 303)
        Me.txtGuildGold.MaxLength = 6
        Me.txtGuildGold.Name = "txtGuildGold"
        Me.txtGuildGold.ReadOnly = True
        Me.txtGuildGold.Size = New System.Drawing.Size(60, 26)
        Me.txtGuildGold.TabIndex = 16
        Me.txtGuildGold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(7, 294)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 40)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Gold:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBack
        '
        Me.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBack.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(228, 337)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(100, 30)
        Me.btnBack.TabIndex = 9
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Enabled = False
        Me.btnClear.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(119, 337)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 30)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnTransfer
        '
        Me.btnTransfer.Enabled = False
        Me.btnTransfer.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransfer.Location = New System.Drawing.Point(10, 337)
        Me.btnTransfer.Name = "btnTransfer"
        Me.btnTransfer.Size = New System.Drawing.Size(100, 30)
        Me.btnTransfer.TabIndex = 7
        Me.btnTransfer.Text = "&Transfer"
        Me.btnTransfer.UseVisualStyleBackColor = True
        '
        'txtTransfer
        '
        Me.txtTransfer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTransfer.Location = New System.Drawing.Point(336, 103)
        Me.txtTransfer.Multiline = True
        Me.txtTransfer.Name = "txtTransfer"
        Me.txtTransfer.ReadOnly = True
        Me.txtTransfer.Size = New System.Drawing.Size(335, 264)
        Me.txtTransfer.TabIndex = 10
        Me.txtTransfer.Text = "What would you like to transfer?"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(267, 69)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 25)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Transfer:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(115, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 25)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Guild:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTransfer5
        '
        Me.txtTransfer5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTransfer5.Location = New System.Drawing.Point(268, 263)
        Me.txtTransfer5.MaxLength = 3
        Me.txtTransfer5.Name = "txtTransfer5"
        Me.txtTransfer5.Size = New System.Drawing.Size(60, 26)
        Me.txtTransfer5.TabIndex = 5
        Me.txtTransfer5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTransfer4
        '
        Me.txtTransfer4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTransfer4.Location = New System.Drawing.Point(268, 223)
        Me.txtTransfer4.MaxLength = 3
        Me.txtTransfer4.Name = "txtTransfer4"
        Me.txtTransfer4.Size = New System.Drawing.Size(60, 26)
        Me.txtTransfer4.TabIndex = 4
        Me.txtTransfer4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTransfer3
        '
        Me.txtTransfer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTransfer3.Location = New System.Drawing.Point(270, 183)
        Me.txtTransfer3.MaxLength = 3
        Me.txtTransfer3.Name = "txtTransfer3"
        Me.txtTransfer3.Size = New System.Drawing.Size(60, 26)
        Me.txtTransfer3.TabIndex = 3
        Me.txtTransfer3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTransfer2
        '
        Me.txtTransfer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTransfer2.Location = New System.Drawing.Point(270, 143)
        Me.txtTransfer2.MaxLength = 3
        Me.txtTransfer2.Name = "txtTransfer2"
        Me.txtTransfer2.Size = New System.Drawing.Size(60, 26)
        Me.txtTransfer2.TabIndex = 2
        Me.txtTransfer2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTransfer1
        '
        Me.txtTransfer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTransfer1.Location = New System.Drawing.Point(270, 103)
        Me.txtTransfer1.MaxLength = 3
        Me.txtTransfer1.Name = "txtTransfer1"
        Me.txtTransfer1.Size = New System.Drawing.Size(60, 26)
        Me.txtTransfer1.TabIndex = 1
        Me.txtTransfer1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtGuild5
        '
        Me.txtGuild5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGuild5.Location = New System.Drawing.Point(118, 263)
        Me.txtGuild5.MaxLength = 3
        Me.txtGuild5.Name = "txtGuild5"
        Me.txtGuild5.ReadOnly = True
        Me.txtGuild5.Size = New System.Drawing.Size(60, 26)
        Me.txtGuild5.TabIndex = 15
        Me.txtGuild5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(7, 254)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 40)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Level 5 Henchmen:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtGuild4
        '
        Me.txtGuild4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGuild4.Location = New System.Drawing.Point(118, 223)
        Me.txtGuild4.MaxLength = 3
        Me.txtGuild4.Name = "txtGuild4"
        Me.txtGuild4.ReadOnly = True
        Me.txtGuild4.Size = New System.Drawing.Size(60, 26)
        Me.txtGuild4.TabIndex = 14
        Me.txtGuild4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(7, 214)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 40)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Level 4 Henchmen:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtGuild3
        '
        Me.txtGuild3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGuild3.Location = New System.Drawing.Point(118, 183)
        Me.txtGuild3.MaxLength = 3
        Me.txtGuild3.Name = "txtGuild3"
        Me.txtGuild3.ReadOnly = True
        Me.txtGuild3.Size = New System.Drawing.Size(60, 26)
        Me.txtGuild3.TabIndex = 13
        Me.txtGuild3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(7, 174)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 40)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Level 3 Henchmen:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtGuild2
        '
        Me.txtGuild2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGuild2.Location = New System.Drawing.Point(118, 143)
        Me.txtGuild2.MaxLength = 3
        Me.txtGuild2.Name = "txtGuild2"
        Me.txtGuild2.ReadOnly = True
        Me.txtGuild2.Size = New System.Drawing.Size(60, 26)
        Me.txtGuild2.TabIndex = 12
        Me.txtGuild2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(7, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 40)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Level 2 Henchmen:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtGuild1
        '
        Me.txtGuild1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGuild1.Location = New System.Drawing.Point(118, 103)
        Me.txtGuild1.MaxLength = 3
        Me.txtGuild1.Name = "txtGuild1"
        Me.txtGuild1.ReadOnly = True
        Me.txtGuild1.Size = New System.Drawing.Size(60, 26)
        Me.txtGuild1.TabIndex = 11
        Me.txtGuild1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(7, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 40)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Level 1 Henchmen:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCurrentGold
        '
        Me.txtCurrentGold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCurrentGold.Location = New System.Drawing.Point(194, 303)
        Me.txtCurrentGold.MaxLength = 6
        Me.txtCurrentGold.Name = "txtCurrentGold"
        Me.txtCurrentGold.ReadOnly = True
        Me.txtCurrentGold.Size = New System.Drawing.Size(60, 26)
        Me.txtCurrentGold.TabIndex = 22
        Me.txtCurrentGold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(191, 69)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 25)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Player:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCurrent5
        '
        Me.txtCurrent5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCurrent5.Location = New System.Drawing.Point(194, 263)
        Me.txtCurrent5.MaxLength = 3
        Me.txtCurrent5.Name = "txtCurrent5"
        Me.txtCurrent5.ReadOnly = True
        Me.txtCurrent5.Size = New System.Drawing.Size(60, 26)
        Me.txtCurrent5.TabIndex = 21
        Me.txtCurrent5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCurrent4
        '
        Me.txtCurrent4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCurrent4.Location = New System.Drawing.Point(194, 223)
        Me.txtCurrent4.MaxLength = 3
        Me.txtCurrent4.Name = "txtCurrent4"
        Me.txtCurrent4.ReadOnly = True
        Me.txtCurrent4.Size = New System.Drawing.Size(60, 26)
        Me.txtCurrent4.TabIndex = 20
        Me.txtCurrent4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCurrent3
        '
        Me.txtCurrent3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCurrent3.Location = New System.Drawing.Point(194, 183)
        Me.txtCurrent3.MaxLength = 3
        Me.txtCurrent3.Name = "txtCurrent3"
        Me.txtCurrent3.ReadOnly = True
        Me.txtCurrent3.Size = New System.Drawing.Size(60, 26)
        Me.txtCurrent3.TabIndex = 19
        Me.txtCurrent3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCurrent2
        '
        Me.txtCurrent2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCurrent2.Location = New System.Drawing.Point(194, 143)
        Me.txtCurrent2.MaxLength = 3
        Me.txtCurrent2.Name = "txtCurrent2"
        Me.txtCurrent2.ReadOnly = True
        Me.txtCurrent2.Size = New System.Drawing.Size(60, 26)
        Me.txtCurrent2.TabIndex = 18
        Me.txtCurrent2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCurrent1
        '
        Me.txtCurrent1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCurrent1.Location = New System.Drawing.Point(194, 103)
        Me.txtCurrent1.MaxLength = 3
        Me.txtCurrent1.Name = "txtCurrent1"
        Me.txtCurrent1.ReadOnly = True
        Me.txtCurrent1.Size = New System.Drawing.Size(60, 26)
        Me.txtCurrent1.TabIndex = 17
        Me.txtCurrent1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grpTransfer
        '
        Me.grpTransfer.Controls.Add(Me.radPlayer)
        Me.grpTransfer.Controls.Add(Me.radGuild)
        Me.grpTransfer.Location = New System.Drawing.Point(118, 16)
        Me.grpTransfer.Name = "grpTransfer"
        Me.grpTransfer.Size = New System.Drawing.Size(212, 50)
        Me.grpTransfer.TabIndex = 0
        Me.grpTransfer.TabStop = False
        Me.grpTransfer.Text = "Transfer To:"
        '
        'radPlayer
        '
        Me.radPlayer.AutoSize = True
        Me.radPlayer.Location = New System.Drawing.Point(136, 22)
        Me.radPlayer.Name = "radPlayer"
        Me.radPlayer.Size = New System.Drawing.Size(70, 22)
        Me.radPlayer.TabIndex = 1
        Me.radPlayer.Text = "Player"
        Me.radPlayer.UseVisualStyleBackColor = True
        '
        'radGuild
        '
        Me.radGuild.AutoSize = True
        Me.radGuild.Checked = True
        Me.radGuild.Location = New System.Drawing.Point(6, 22)
        Me.radGuild.Name = "radGuild"
        Me.radGuild.Size = New System.Drawing.Size(62, 22)
        Me.radGuild.TabIndex = 0
        Me.radGuild.TabStop = True
        Me.radGuild.Text = "Guild"
        Me.radGuild.UseVisualStyleBackColor = True
        '
        'pctHelp
        '
        Me.pctHelp.Image = Global.Assassin.My.Resources.Resources.Question_25px
        Me.pctHelp.ImageLocation = ""
        Me.pctHelp.Location = New System.Drawing.Point(653, 12)
        Me.pctHelp.Name = "pctHelp"
        Me.pctHelp.Size = New System.Drawing.Size(25, 25)
        Me.pctHelp.TabIndex = 32
        Me.pctHelp.TabStop = False
        '
        'frmGuildTransfer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnBack
        Me.ClientSize = New System.Drawing.Size(690, 379)
        Me.Controls.Add(Me.pctHelp)
        Me.Controls.Add(Me.grpTransfer)
        Me.Controls.Add(Me.txtCurrentGold)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtCurrent5)
        Me.Controls.Add(Me.txtCurrent4)
        Me.Controls.Add(Me.txtCurrent3)
        Me.Controls.Add(Me.txtCurrent2)
        Me.Controls.Add(Me.txtCurrent1)
        Me.Controls.Add(Me.txtTransferGold)
        Me.Controls.Add(Me.txtGuildGold)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnTransfer)
        Me.Controls.Add(Me.txtTransfer)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTransfer5)
        Me.Controls.Add(Me.txtTransfer4)
        Me.Controls.Add(Me.txtTransfer3)
        Me.Controls.Add(Me.txtTransfer2)
        Me.Controls.Add(Me.txtTransfer1)
        Me.Controls.Add(Me.txtGuild5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtGuild4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtGuild3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtGuild2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtGuild1)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(706, 418)
        Me.MinimumSize = New System.Drawing.Size(706, 418)
        Me.Name = "frmGuildTransfer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transfer"
        Me.grpTransfer.ResumeLayout(False)
        Me.grpTransfer.PerformLayout()
        CType(Me.pctHelp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTransferGold As System.Windows.Forms.TextBox
    Friend WithEvents txtGuildGold As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnTransfer As System.Windows.Forms.Button
    Friend WithEvents txtTransfer As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTransfer5 As System.Windows.Forms.TextBox
    Friend WithEvents txtTransfer4 As System.Windows.Forms.TextBox
    Friend WithEvents txtTransfer3 As System.Windows.Forms.TextBox
    Friend WithEvents txtTransfer2 As System.Windows.Forms.TextBox
    Friend WithEvents txtTransfer1 As System.Windows.Forms.TextBox
    Friend WithEvents txtGuild5 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtGuild4 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtGuild3 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtGuild2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtGuild1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCurrentGold As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCurrent5 As System.Windows.Forms.TextBox
    Friend WithEvents txtCurrent4 As System.Windows.Forms.TextBox
    Friend WithEvents txtCurrent3 As System.Windows.Forms.TextBox
    Friend WithEvents txtCurrent2 As System.Windows.Forms.TextBox
    Friend WithEvents txtCurrent1 As System.Windows.Forms.TextBox
    Friend WithEvents grpTransfer As System.Windows.Forms.GroupBox
    Friend WithEvents radGuild As System.Windows.Forms.RadioButton
    Friend WithEvents radPlayer As System.Windows.Forms.RadioButton
    Friend WithEvents pctHelp As System.Windows.Forms.PictureBox
End Class
