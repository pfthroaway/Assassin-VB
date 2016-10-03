<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGuildManage
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
        Me.lblGuildName = New System.Windows.Forms.Label()
        Me.btnOptions = New System.Windows.Forms.Button()
        Me.btnTransfer = New System.Windows.Forms.Button()
        Me.btnMembers = New System.Windows.Forms.Button()
        Me.btnHire = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnApplications = New System.Windows.Forms.Button()
        Me.txtGuild = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblGuildName
        '
        Me.lblGuildName.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuildName.Location = New System.Drawing.Point(15, 11)
        Me.lblGuildName.Name = "lblGuildName"
        Me.lblGuildName.Size = New System.Drawing.Size(348, 40)
        Me.lblGuildName.TabIndex = 27
        Me.lblGuildName.Text = "Manage Guild"
        Me.lblGuildName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnOptions
        '
        Me.btnOptions.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOptions.Location = New System.Drawing.Point(13, 198)
        Me.btnOptions.Name = "btnOptions"
        Me.btnOptions.Size = New System.Drawing.Size(150, 30)
        Me.btnOptions.TabIndex = 19
        Me.btnOptions.Text = "Guild &Options"
        Me.btnOptions.UseVisualStyleBackColor = True
        '
        'btnTransfer
        '
        Me.btnTransfer.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransfer.Location = New System.Drawing.Point(213, 198)
        Me.btnTransfer.Name = "btnTransfer"
        Me.btnTransfer.Size = New System.Drawing.Size(150, 30)
        Me.btnTransfer.TabIndex = 25
        Me.btnTransfer.Text = "&Transfer"
        Me.btnTransfer.UseVisualStyleBackColor = True
        '
        'btnMembers
        '
        Me.btnMembers.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMembers.Location = New System.Drawing.Point(213, 162)
        Me.btnMembers.Name = "btnMembers"
        Me.btnMembers.Size = New System.Drawing.Size(150, 30)
        Me.btnMembers.TabIndex = 20
        Me.btnMembers.Text = "&Members"
        Me.btnMembers.UseVisualStyleBackColor = True
        '
        'btnHire
        '
        Me.btnHire.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHire.Location = New System.Drawing.Point(13, 234)
        Me.btnHire.Name = "btnHire"
        Me.btnHire.Size = New System.Drawing.Size(150, 30)
        Me.btnHire.TabIndex = 17
        Me.btnHire.Text = "&Hire Henchmen"
        Me.btnHire.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBack.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(213, 234)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(150, 30)
        Me.btnBack.TabIndex = 26
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnApplications
        '
        Me.btnApplications.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApplications.Location = New System.Drawing.Point(13, 162)
        Me.btnApplications.Name = "btnApplications"
        Me.btnApplications.Size = New System.Drawing.Size(150, 30)
        Me.btnApplications.TabIndex = 15
        Me.btnApplications.Text = "&Applications"
        Me.btnApplications.UseVisualStyleBackColor = True
        '
        'txtGuild
        '
        Me.txtGuild.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGuild.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuild.Location = New System.Drawing.Point(13, 55)
        Me.txtGuild.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGuild.Multiline = True
        Me.txtGuild.Name = "txtGuild"
        Me.txtGuild.ReadOnly = True
        Me.txtGuild.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtGuild.Size = New System.Drawing.Size(350, 100)
        Me.txtGuild.TabIndex = 14
        Me.txtGuild.Text = "You begin to manage the guild."
        '
        'frmGuildManage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnBack
        Me.ClientSize = New System.Drawing.Size(376, 276)
        Me.Controls.Add(Me.lblGuildName)
        Me.Controls.Add(Me.btnOptions)
        Me.Controls.Add(Me.btnTransfer)
        Me.Controls.Add(Me.btnMembers)
        Me.Controls.Add(Me.btnHire)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnApplications)
        Me.Controls.Add(Me.txtGuild)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(392, 315)
        Me.MinimumSize = New System.Drawing.Size(392, 315)
        Me.Name = "frmGuildManage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manage Guild"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblGuildName As System.Windows.Forms.Label
    Friend WithEvents btnOptions As System.Windows.Forms.Button
    Friend WithEvents btnTransfer As System.Windows.Forms.Button
    Friend WithEvents btnMembers As System.Windows.Forms.Button
    Friend WithEvents btnHire As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnApplications As System.Windows.Forms.Button
    Friend WithEvents txtGuild As System.Windows.Forms.TextBox
End Class
