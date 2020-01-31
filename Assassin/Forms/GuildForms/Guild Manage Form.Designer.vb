Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

Namespace Forms.GuildForms
    <DesignerGenerated()> _
    Partial Class FrmGuildManage
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
            Me.lblGuildName = New Label()
            Me.btnOptions = New Button()
            Me.btnTransfer = New Button()
            Me.btnMembers = New Button()
            Me.btnHire = New Button()
            Me.btnBack = New Button()
            Me.btnApplications = New Button()
            Me.txtGuild = New TextBox()
            Me.SuspendLayout()
            '
            'lblGuildName
            '
            Me.lblGuildName.Font = New Font("Arial", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblGuildName.Location = New Point(15, 11)
            Me.lblGuildName.Name = "lblGuildName"
            Me.lblGuildName.Size = New Size(348, 40)
            Me.lblGuildName.TabIndex = 27
            Me.lblGuildName.Text = "Manage Guild"
            Me.lblGuildName.TextAlign = ContentAlignment.MiddleCenter
            '
            'btnOptions
            '
            Me.btnOptions.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnOptions.Location = New Point(13, 198)
            Me.btnOptions.Name = "btnOptions"
            Me.btnOptions.Size = New Size(150, 30)
            Me.btnOptions.TabIndex = 19
            Me.btnOptions.Text = "Guild &Options"
            Me.btnOptions.UseVisualStyleBackColor = True
            '
            'btnTransfer
            '
            Me.btnTransfer.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnTransfer.Location = New Point(213, 198)
            Me.btnTransfer.Name = "btnTransfer"
            Me.btnTransfer.Size = New Size(150, 30)
            Me.btnTransfer.TabIndex = 25
            Me.btnTransfer.Text = "&Transfer"
            Me.btnTransfer.UseVisualStyleBackColor = True
            '
            'btnMembers
            '
            Me.btnMembers.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnMembers.Location = New Point(213, 162)
            Me.btnMembers.Name = "btnMembers"
            Me.btnMembers.Size = New Size(150, 30)
            Me.btnMembers.TabIndex = 20
            Me.btnMembers.Text = "&Members"
            Me.btnMembers.UseVisualStyleBackColor = True
            '
            'btnHire
            '
            Me.btnHire.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnHire.Location = New Point(13, 234)
            Me.btnHire.Name = "btnHire"
            Me.btnHire.Size = New Size(150, 30)
            Me.btnHire.TabIndex = 17
            Me.btnHire.Text = "&Hire Henchmen"
            Me.btnHire.UseVisualStyleBackColor = True
            '
            'btnBack
            '
            Me.btnBack.DialogResult = DialogResult.Cancel
            Me.btnBack.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnBack.Location = New Point(213, 234)
            Me.btnBack.Name = "btnBack"
            Me.btnBack.Size = New Size(150, 30)
            Me.btnBack.TabIndex = 26
            Me.btnBack.Text = "&Back"
            Me.btnBack.UseVisualStyleBackColor = True
            '
            'btnApplications
            '
            Me.btnApplications.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnApplications.Location = New Point(13, 162)
            Me.btnApplications.Name = "btnApplications"
            Me.btnApplications.Size = New Size(150, 30)
            Me.btnApplications.TabIndex = 15
            Me.btnApplications.Text = "&Applications"
            Me.btnApplications.UseVisualStyleBackColor = True
            '
            'txtGuild
            '
            Me.txtGuild.BorderStyle = BorderStyle.FixedSingle
            Me.txtGuild.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.txtGuild.Location = New Point(13, 55)
            Me.txtGuild.Margin = New Padding(4)
            Me.txtGuild.Multiline = True
            Me.txtGuild.Name = "txtGuild"
            Me.txtGuild.ReadOnly = True
            Me.txtGuild.ScrollBars = ScrollBars.Vertical
            Me.txtGuild.Size = New Size(350, 100)
            Me.txtGuild.TabIndex = 14
            Me.txtGuild.Text = "You begin to manage the guild."
            '
            'frmGuildManage
            '
            Me.AutoScaleDimensions = New SizeF(9.0!, 18.0!)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.CancelButton = Me.btnBack
            Me.ClientSize = New Size(376, 276)
            Me.Controls.Add(Me.lblGuildName)
            Me.Controls.Add(Me.btnOptions)
            Me.Controls.Add(Me.btnTransfer)
            Me.Controls.Add(Me.btnMembers)
            Me.Controls.Add(Me.btnHire)
            Me.Controls.Add(Me.btnBack)
            Me.Controls.Add(Me.btnApplications)
            Me.Controls.Add(Me.txtGuild)
            Me.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Margin = New Padding(4)
            Me.MaximizeBox = False
            Me.MaximumSize = New Size(392, 315)
            Me.MinimumSize = New Size(392, 315)
            Me.Name = "frmGuildManage"
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.Text = "Manage Guild"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents lblGuildName As Label
        Friend WithEvents BtnOptions As Button
        Friend WithEvents BtnTransfer As Button
        Friend WithEvents BtnMembers As Button
        Friend WithEvents BtnHire As Button
        Friend WithEvents BtnBack As Button
        Friend WithEvents BtnApplications As Button
        Friend WithEvents TxtGuild As TextBox
    End Class
End NameSpace