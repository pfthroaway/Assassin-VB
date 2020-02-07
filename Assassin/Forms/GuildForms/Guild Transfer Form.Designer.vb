Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

Namespace Forms.GuildForms
    <DesignerGenerated()> _
    Partial Class FrmGuildTransfer
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
            Me.txtTransferGold = New TextBox()
            Me.txtGuildGold = New TextBox()
            Me.Label1 = New Label()
            Me.BtnBack = New Button()
            Me.BtnClear = New Button()
            Me.BtnTransfer = New Button()
            Me.txtTransfer = New TextBox()
            Me.Label9 = New Label()
            Me.Label2 = New Label()
            Me.txtTransfer5 = New TextBox()
            Me.txtTransfer4 = New TextBox()
            Me.txtTransfer3 = New TextBox()
            Me.txtTransfer2 = New TextBox()
            Me.txtTransfer1 = New TextBox()
            Me.txtGuild5 = New TextBox()
            Me.Label7 = New Label()
            Me.txtGuild4 = New TextBox()
            Me.Label6 = New Label()
            Me.txtGuild3 = New TextBox()
            Me.Label5 = New Label()
            Me.txtGuild2 = New TextBox()
            Me.Label4 = New Label()
            Me.txtGuild1 = New TextBox()
            Me.Label3 = New Label()
            Me.txtCurrentGold = New TextBox()
            Me.Label8 = New Label()
            Me.txtCurrent5 = New TextBox()
            Me.txtCurrent4 = New TextBox()
            Me.txtCurrent3 = New TextBox()
            Me.txtCurrent2 = New TextBox()
            Me.txtCurrent1 = New TextBox()
            Me.grpTransfer = New GroupBox()
            Me.radPlayer = New RadioButton()
            Me.radGuild = New RadioButton()
            Me.pctHelp = New PictureBox()
            Me.grpTransfer.SuspendLayout()
            CType(Me.pctHelp, ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'txtTransferGold
            '
            Me.txtTransferGold.BorderStyle = BorderStyle.FixedSingle
            Me.txtTransferGold.Location = New Point(268, 303)
            Me.txtTransferGold.MaxLength = 6
            Me.txtTransferGold.Name = "txtTransferGold"
            Me.txtTransferGold.Size = New Size(60, 26)
            Me.txtTransferGold.TabIndex = 6
            Me.txtTransferGold.TextAlign = HorizontalAlignment.Center
            '
            'txtGuildGold
            '
            Me.txtGuildGold.BorderStyle = BorderStyle.FixedSingle
            Me.txtGuildGold.Location = New Point(118, 303)
            Me.txtGuildGold.MaxLength = 6
            Me.txtGuildGold.Name = "txtGuildGold"
            Me.txtGuildGold.ReadOnly = True
            Me.txtGuildGold.Size = New Size(60, 26)
            Me.txtGuildGold.TabIndex = 16
            Me.txtGuildGold.TextAlign = HorizontalAlignment.Center
            '
            'Label1
            '
            Me.Label1.Location = New Point(7, 294)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New Size(85, 40)
            Me.Label1.TabIndex = 28
            Me.Label1.Text = "Gold:"
            Me.Label1.TextAlign = ContentAlignment.MiddleCenter
            '
            'BtnBack
            '
            Me.BtnBack.DialogResult = DialogResult.Cancel
            Me.BtnBack.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnBack.Location = New Point(228, 337)
            Me.BtnBack.Name = "BtnBack"
            Me.BtnBack.Size = New Size(100, 30)
            Me.BtnBack.TabIndex = 9
            Me.BtnBack.Text = "&Back"
            Me.BtnBack.UseVisualStyleBackColor = True
            '
            'BtnClear
            '
            Me.BtnClear.Enabled = False
            Me.BtnClear.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnClear.Location = New Point(119, 337)
            Me.BtnClear.Name = "BtnClear"
            Me.BtnClear.Size = New Size(100, 30)
            Me.BtnClear.TabIndex = 8
            Me.BtnClear.Text = "&Clear"
            Me.BtnClear.UseVisualStyleBackColor = True
            '
            'BtnTransfer
            '
            Me.BtnTransfer.Enabled = False
            Me.BtnTransfer.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnTransfer.Location = New Point(10, 337)
            Me.BtnTransfer.Name = "BtnTransfer"
            Me.BtnTransfer.Size = New Size(100, 30)
            Me.BtnTransfer.TabIndex = 7
            Me.BtnTransfer.Text = "&Transfer"
            Me.BtnTransfer.UseVisualStyleBackColor = True
            '
            'txtTransfer
            '
            Me.txtTransfer.BorderStyle = BorderStyle.FixedSingle
            Me.txtTransfer.Location = New Point(336, 103)
            Me.txtTransfer.Multiline = True
            Me.txtTransfer.Name = "txtTransfer"
            Me.txtTransfer.ReadOnly = True
            Me.txtTransfer.Size = New Size(335, 264)
            Me.txtTransfer.TabIndex = 10
            Me.txtTransfer.Text = "What would you like to transfer?"
            '
            'Label9
            '
            Me.Label9.Location = New Point(267, 69)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New Size(70, 25)
            Me.Label9.TabIndex = 31
            Me.Label9.Text = "Transfer:"
            Me.Label9.TextAlign = ContentAlignment.MiddleCenter
            '
            'Label2
            '
            Me.Label2.Location = New Point(115, 69)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New Size(70, 25)
            Me.Label2.TabIndex = 29
            Me.Label2.Text = "Guild:"
            Me.Label2.TextAlign = ContentAlignment.MiddleCenter
            '
            'txtTransfer5
            '
            Me.txtTransfer5.BorderStyle = BorderStyle.FixedSingle
            Me.txtTransfer5.Location = New Point(268, 263)
            Me.txtTransfer5.MaxLength = 3
            Me.txtTransfer5.Name = "txtTransfer5"
            Me.txtTransfer5.Size = New Size(60, 26)
            Me.txtTransfer5.TabIndex = 5
            Me.txtTransfer5.TextAlign = HorizontalAlignment.Center
            '
            'txtTransfer4
            '
            Me.txtTransfer4.BorderStyle = BorderStyle.FixedSingle
            Me.txtTransfer4.Location = New Point(268, 223)
            Me.txtTransfer4.MaxLength = 3
            Me.txtTransfer4.Name = "txtTransfer4"
            Me.txtTransfer4.Size = New Size(60, 26)
            Me.txtTransfer4.TabIndex = 4
            Me.txtTransfer4.TextAlign = HorizontalAlignment.Center
            '
            'txtTransfer3
            '
            Me.txtTransfer3.BorderStyle = BorderStyle.FixedSingle
            Me.txtTransfer3.Location = New Point(270, 183)
            Me.txtTransfer3.MaxLength = 3
            Me.txtTransfer3.Name = "txtTransfer3"
            Me.txtTransfer3.Size = New Size(60, 26)
            Me.txtTransfer3.TabIndex = 3
            Me.txtTransfer3.TextAlign = HorizontalAlignment.Center
            '
            'txtTransfer2
            '
            Me.txtTransfer2.BorderStyle = BorderStyle.FixedSingle
            Me.txtTransfer2.Location = New Point(270, 143)
            Me.txtTransfer2.MaxLength = 3
            Me.txtTransfer2.Name = "txtTransfer2"
            Me.txtTransfer2.Size = New Size(60, 26)
            Me.txtTransfer2.TabIndex = 2
            Me.txtTransfer2.TextAlign = HorizontalAlignment.Center
            '
            'txtTransfer1
            '
            Me.txtTransfer1.BorderStyle = BorderStyle.FixedSingle
            Me.txtTransfer1.Location = New Point(270, 103)
            Me.txtTransfer1.MaxLength = 3
            Me.txtTransfer1.Name = "txtTransfer1"
            Me.txtTransfer1.Size = New Size(60, 26)
            Me.txtTransfer1.TabIndex = 1
            Me.txtTransfer1.TextAlign = HorizontalAlignment.Center
            '
            'txtGuild5
            '
            Me.txtGuild5.BorderStyle = BorderStyle.FixedSingle
            Me.txtGuild5.Location = New Point(118, 263)
            Me.txtGuild5.MaxLength = 3
            Me.txtGuild5.Name = "txtGuild5"
            Me.txtGuild5.ReadOnly = True
            Me.txtGuild5.Size = New Size(60, 26)
            Me.txtGuild5.TabIndex = 15
            Me.txtGuild5.TextAlign = HorizontalAlignment.Center
            '
            'Label7
            '
            Me.Label7.Location = New Point(7, 254)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New Size(90, 40)
            Me.Label7.TabIndex = 27
            Me.Label7.Text = "Level 5 Henchmen:"
            Me.Label7.TextAlign = ContentAlignment.MiddleCenter
            '
            'txtGuild4
            '
            Me.txtGuild4.BorderStyle = BorderStyle.FixedSingle
            Me.txtGuild4.Location = New Point(118, 223)
            Me.txtGuild4.MaxLength = 3
            Me.txtGuild4.Name = "txtGuild4"
            Me.txtGuild4.ReadOnly = True
            Me.txtGuild4.Size = New Size(60, 26)
            Me.txtGuild4.TabIndex = 14
            Me.txtGuild4.TextAlign = HorizontalAlignment.Center
            '
            'Label6
            '
            Me.Label6.Location = New Point(7, 214)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New Size(90, 40)
            Me.Label6.TabIndex = 26
            Me.Label6.Text = "Level 4 Henchmen:"
            Me.Label6.TextAlign = ContentAlignment.MiddleCenter
            '
            'txtGuild3
            '
            Me.txtGuild3.BorderStyle = BorderStyle.FixedSingle
            Me.txtGuild3.Location = New Point(118, 183)
            Me.txtGuild3.MaxLength = 3
            Me.txtGuild3.Name = "txtGuild3"
            Me.txtGuild3.ReadOnly = True
            Me.txtGuild3.Size = New Size(60, 26)
            Me.txtGuild3.TabIndex = 13
            Me.txtGuild3.TextAlign = HorizontalAlignment.Center
            '
            'Label5
            '
            Me.Label5.Location = New Point(7, 174)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New Size(90, 40)
            Me.Label5.TabIndex = 25
            Me.Label5.Text = "Level 3 Henchmen:"
            Me.Label5.TextAlign = ContentAlignment.MiddleCenter
            '
            'txtGuild2
            '
            Me.txtGuild2.BorderStyle = BorderStyle.FixedSingle
            Me.txtGuild2.Location = New Point(118, 143)
            Me.txtGuild2.MaxLength = 3
            Me.txtGuild2.Name = "txtGuild2"
            Me.txtGuild2.ReadOnly = True
            Me.txtGuild2.Size = New Size(60, 26)
            Me.txtGuild2.TabIndex = 12
            Me.txtGuild2.TextAlign = HorizontalAlignment.Center
            '
            'Label4
            '
            Me.Label4.Location = New Point(7, 134)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New Size(90, 40)
            Me.Label4.TabIndex = 24
            Me.Label4.Text = "Level 2 Henchmen:"
            Me.Label4.TextAlign = ContentAlignment.MiddleCenter
            '
            'txtGuild1
            '
            Me.txtGuild1.BorderStyle = BorderStyle.FixedSingle
            Me.txtGuild1.Location = New Point(118, 103)
            Me.txtGuild1.MaxLength = 3
            Me.txtGuild1.Name = "txtGuild1"
            Me.txtGuild1.ReadOnly = True
            Me.txtGuild1.Size = New Size(60, 26)
            Me.txtGuild1.TabIndex = 11
            Me.txtGuild1.TextAlign = HorizontalAlignment.Center
            '
            'Label3
            '
            Me.Label3.Location = New Point(7, 94)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New Size(90, 40)
            Me.Label3.TabIndex = 23
            Me.Label3.Text = "Level 1 Henchmen:"
            Me.Label3.TextAlign = ContentAlignment.MiddleCenter
            '
            'txtCurrentGold
            '
            Me.txtCurrentGold.BorderStyle = BorderStyle.FixedSingle
            Me.txtCurrentGold.Location = New Point(194, 303)
            Me.txtCurrentGold.MaxLength = 6
            Me.txtCurrentGold.Name = "txtCurrentGold"
            Me.txtCurrentGold.ReadOnly = True
            Me.txtCurrentGold.Size = New Size(60, 26)
            Me.txtCurrentGold.TabIndex = 22
            Me.txtCurrentGold.TextAlign = HorizontalAlignment.Center
            '
            'Label8
            '
            Me.Label8.Location = New Point(191, 69)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New Size(70, 25)
            Me.Label8.TabIndex = 30
            Me.Label8.Text = "Player:"
            Me.Label8.TextAlign = ContentAlignment.MiddleCenter
            '
            'txtCurrent5
            '
            Me.txtCurrent5.BorderStyle = BorderStyle.FixedSingle
            Me.txtCurrent5.Location = New Point(194, 263)
            Me.txtCurrent5.MaxLength = 3
            Me.txtCurrent5.Name = "txtCurrent5"
            Me.txtCurrent5.ReadOnly = True
            Me.txtCurrent5.Size = New Size(60, 26)
            Me.txtCurrent5.TabIndex = 21
            Me.txtCurrent5.TextAlign = HorizontalAlignment.Center
            '
            'txtCurrent4
            '
            Me.txtCurrent4.BorderStyle = BorderStyle.FixedSingle
            Me.txtCurrent4.Location = New Point(194, 223)
            Me.txtCurrent4.MaxLength = 3
            Me.txtCurrent4.Name = "txtCurrent4"
            Me.txtCurrent4.ReadOnly = True
            Me.txtCurrent4.Size = New Size(60, 26)
            Me.txtCurrent4.TabIndex = 20
            Me.txtCurrent4.TextAlign = HorizontalAlignment.Center
            '
            'txtCurrent3
            '
            Me.txtCurrent3.BorderStyle = BorderStyle.FixedSingle
            Me.txtCurrent3.Location = New Point(194, 183)
            Me.txtCurrent3.MaxLength = 3
            Me.txtCurrent3.Name = "txtCurrent3"
            Me.txtCurrent3.ReadOnly = True
            Me.txtCurrent3.Size = New Size(60, 26)
            Me.txtCurrent3.TabIndex = 19
            Me.txtCurrent3.TextAlign = HorizontalAlignment.Center
            '
            'txtCurrent2
            '
            Me.txtCurrent2.BorderStyle = BorderStyle.FixedSingle
            Me.txtCurrent2.Location = New Point(194, 143)
            Me.txtCurrent2.MaxLength = 3
            Me.txtCurrent2.Name = "txtCurrent2"
            Me.txtCurrent2.ReadOnly = True
            Me.txtCurrent2.Size = New Size(60, 26)
            Me.txtCurrent2.TabIndex = 18
            Me.txtCurrent2.TextAlign = HorizontalAlignment.Center
            '
            'txtCurrent1
            '
            Me.txtCurrent1.BorderStyle = BorderStyle.FixedSingle
            Me.txtCurrent1.Location = New Point(194, 103)
            Me.txtCurrent1.MaxLength = 3
            Me.txtCurrent1.Name = "txtCurrent1"
            Me.txtCurrent1.ReadOnly = True
            Me.txtCurrent1.Size = New Size(60, 26)
            Me.txtCurrent1.TabIndex = 17
            Me.txtCurrent1.TextAlign = HorizontalAlignment.Center
            '
            'grpTransfer
            '
            Me.grpTransfer.Controls.Add(Me.radPlayer)
            Me.grpTransfer.Controls.Add(Me.radGuild)
            Me.grpTransfer.Location = New Point(118, 16)
            Me.grpTransfer.Name = "grpTransfer"
            Me.grpTransfer.Size = New Size(212, 50)
            Me.grpTransfer.TabIndex = 0
            Me.grpTransfer.TabStop = False
            Me.grpTransfer.Text = "Transfer To:"
            '
            'radPlayer
            '
            Me.radPlayer.AutoSize = True
            Me.radPlayer.Location = New Point(136, 22)
            Me.radPlayer.Name = "radPlayer"
            Me.radPlayer.Size = New Size(70, 22)
            Me.radPlayer.TabIndex = 1
            Me.radPlayer.Text = "Player"
            Me.radPlayer.UseVisualStyleBackColor = True
            '
            'radGuild
            '
            Me.radGuild.AutoSize = True
            Me.radGuild.Checked = True
            Me.radGuild.Location = New Point(6, 22)
            Me.radGuild.Name = "radGuild"
            Me.radGuild.Size = New Size(62, 22)
            Me.radGuild.TabIndex = 0
            Me.radGuild.TabStop = True
            Me.radGuild.Text = "Guild"
            Me.radGuild.UseVisualStyleBackColor = True
            '
            'pctHelp
            '
            Me.pctHelp.Image = My.Resources.Question_25px
            Me.pctHelp.ImageLocation = ""
            Me.pctHelp.Location = New Point(653, 12)
            Me.pctHelp.Name = "pctHelp"
            Me.pctHelp.Size = New Size(25, 25)
            Me.pctHelp.TabIndex = 32
            Me.pctHelp.TabStop = False
            '
            'frmGuildTransfer
            '
            Me.AutoScaleDimensions = New SizeF(9.0!, 18.0!)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.CancelButton = Me.BtnBack
            Me.ClientSize = New Size(690, 379)
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
            Me.Controls.Add(Me.BtnBack)
            Me.Controls.Add(Me.BtnClear)
            Me.Controls.Add(Me.BtnTransfer)
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
            Me.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Margin = New Padding(4)
            Me.MaximizeBox = False
            Me.MaximumSize = New Size(706, 418)
            Me.MinimumSize = New Size(706, 418)
            Me.Name = "frmGuildTransfer"
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.Text = "Transfer"
            Me.grpTransfer.ResumeLayout(False)
            Me.grpTransfer.PerformLayout()
            CType(Me.pctHelp, ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents TxtTransferGold As TextBox
        Friend WithEvents TxtGuildGold As TextBox
        Friend WithEvents Label1 As Label
        Friend WithEvents BtnBack As Button
        Friend WithEvents BtnClear As Button
        Friend WithEvents BtnTransfer As Button
        Friend WithEvents TxtTransfer As TextBox
        Friend WithEvents Label9 As Label
        Friend WithEvents Label2 As Label
        Friend WithEvents TxtTransfer5 As TextBox
        Friend WithEvents TxtTransfer4 As TextBox
        Friend WithEvents TxtTransfer3 As TextBox
        Friend WithEvents TxtTransfer2 As TextBox
        Friend WithEvents TxtTransfer1 As TextBox
        Friend WithEvents TxtGuild5 As TextBox
        Friend WithEvents Label7 As Label
        Friend WithEvents TxtGuild4 As TextBox
        Friend WithEvents Label6 As Label
        Friend WithEvents TxtGuild3 As TextBox
        Friend WithEvents Label5 As Label
        Friend WithEvents TxtGuild2 As TextBox
        Friend WithEvents Label4 As Label
        Friend WithEvents TxtGuild1 As TextBox
        Friend WithEvents Label3 As Label
        Friend WithEvents TxtCurrentGold As TextBox
        Friend WithEvents Label8 As Label
        Friend WithEvents TxtCurrent5 As TextBox
        Friend WithEvents TxtCurrent4 As TextBox
        Friend WithEvents TxtCurrent3 As TextBox
        Friend WithEvents TxtCurrent2 As TextBox
        Friend WithEvents TxtCurrent1 As TextBox
        Friend WithEvents grpTransfer As GroupBox
        Friend WithEvents radGuild As RadioButton
        Friend WithEvents radPlayer As RadioButton
        Friend WithEvents pctHelp As PictureBox
    End Class
End NameSpace