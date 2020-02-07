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
            Me.LblGuildName = New Label()
            Me.BtnOptions = New Button()
            Me.BtnTransfer = New Button()
            Me.BtnMembers = New Button()
            Me.BtnHire = New Button()
            Me.BtnBack = New Button()
            Me.BtnApplications = New Button()
            Me.txtGuild = New TextBox()
            Me.SuspendLayout()
            '
            'LblGuildName
            '
            Me.LblGuildName.Font = New Font("Arial", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.LblGuildName.Location = New Point(15, 11)
            Me.LblGuildName.Name = "LblGuildName"
            Me.LblGuildName.Size = New Size(348, 40)
            Me.LblGuildName.TabIndex = 27
            Me.LblGuildName.Text = "Manage Guild"
            Me.LblGuildName.TextAlign = ContentAlignment.MiddleCenter
            '
            'BtnOptions
            '
            Me.BtnOptions.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnOptions.Location = New Point(13, 198)
            Me.BtnOptions.Name = "BtnOptions"
            Me.BtnOptions.Size = New Size(150, 30)
            Me.BtnOptions.TabIndex = 19
            Me.BtnOptions.Text = "Guild &Options"
            Me.BtnOptions.UseVisualStyleBackColor = True
            '
            'BtnTransfer
            '
            Me.BtnTransfer.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnTransfer.Location = New Point(213, 198)
            Me.BtnTransfer.Name = "BtnTransfer"
            Me.BtnTransfer.Size = New Size(150, 30)
            Me.BtnTransfer.TabIndex = 25
            Me.BtnTransfer.Text = "&Transfer"
            Me.BtnTransfer.UseVisualStyleBackColor = True
            '
            'BtnMembers
            '
            Me.BtnMembers.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnMembers.Location = New Point(213, 162)
            Me.BtnMembers.Name = "BtnMembers"
            Me.BtnMembers.Size = New Size(150, 30)
            Me.BtnMembers.TabIndex = 20
            Me.BtnMembers.Text = "&Members"
            Me.BtnMembers.UseVisualStyleBackColor = True
            '
            'BtnHire
            '
            Me.BtnHire.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnHire.Location = New Point(13, 234)
            Me.BtnHire.Name = "BtnHire"
            Me.BtnHire.Size = New Size(150, 30)
            Me.BtnHire.TabIndex = 17
            Me.BtnHire.Text = "&Hire Henchmen"
            Me.BtnHire.UseVisualStyleBackColor = True
            '
            'BtnBack
            '
            Me.BtnBack.DialogResult = DialogResult.Cancel
            Me.BtnBack.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnBack.Location = New Point(213, 234)
            Me.BtnBack.Name = "BtnBack"
            Me.BtnBack.Size = New Size(150, 30)
            Me.BtnBack.TabIndex = 26
            Me.BtnBack.Text = "&Back"
            Me.BtnBack.UseVisualStyleBackColor = True
            '
            'BtnApplications
            '
            Me.BtnApplications.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnApplications.Location = New Point(13, 162)
            Me.BtnApplications.Name = "BtnApplications"
            Me.BtnApplications.Size = New Size(150, 30)
            Me.BtnApplications.TabIndex = 15
            Me.BtnApplications.Text = "&Applications"
            Me.BtnApplications.UseVisualStyleBackColor = True
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
            Me.CancelButton = Me.BtnBack
            Me.ClientSize = New Size(376, 276)
            Me.Controls.Add(Me.LblGuildName)
            Me.Controls.Add(Me.BtnOptions)
            Me.Controls.Add(Me.BtnTransfer)
            Me.Controls.Add(Me.BtnMembers)
            Me.Controls.Add(Me.BtnHire)
            Me.Controls.Add(Me.BtnBack)
            Me.Controls.Add(Me.BtnApplications)
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
        Friend WithEvents LblGuildName As Label
        Friend WithEvents BtnOptions As Button
        Friend WithEvents BtnTransfer As Button
        Friend WithEvents BtnMembers As Button
        Friend WithEvents BtnHire As Button
        Friend WithEvents BtnBack As Button
        Friend WithEvents BtnApplications As Button
        Friend WithEvents TxtGuild As TextBox
    End Class
End NameSpace