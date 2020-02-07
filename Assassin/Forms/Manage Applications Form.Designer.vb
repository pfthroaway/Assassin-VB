Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

Namespace Forms
    <DesignerGenerated()> _
    Partial Class FrmManageApplications
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
            Me.LstApplications = New ListBox()
            Me.BtnConfirm = New Button()
            Me.BtnDeny = New Button()
            Me.BtnBack = New Button()
            Me.SuspendLayout()
            '
            'LblGuildName
            '
            Me.LblGuildName.Font = New Font("Arial", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.LblGuildName.Location = New Point(12, 9)
            Me.LblGuildName.Name = "LblGuildName"
            Me.LblGuildName.Size = New Size(250, 40)
            Me.LblGuildName.TabIndex = 14
            Me.LblGuildName.Text = "Manage Applications"
            Me.LblGuildName.TextAlign = ContentAlignment.MiddleCenter
            '
            'LstApplications
            '
            Me.LstApplications.FormattingEnabled = True
            Me.LstApplications.ItemHeight = 18
            Me.LstApplications.Location = New Point(17, 52)
            Me.LstApplications.Name = "LstApplications"
            Me.LstApplications.Size = New Size(245, 184)
            Me.LstApplications.TabIndex = 15
            '
            'BtnConfirm
            '
            Me.BtnConfirm.Enabled = False
            Me.BtnConfirm.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnConfirm.Location = New Point(62, 242)
            Me.BtnConfirm.Name = "BtnConfirm"
            Me.BtnConfirm.Size = New Size(150, 30)
            Me.BtnConfirm.TabIndex = 16
            Me.BtnConfirm.Text = "&Confirm"
            Me.BtnConfirm.UseVisualStyleBackColor = True
            '
            'BtnDeny
            '
            Me.BtnDeny.Enabled = False
            Me.BtnDeny.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnDeny.Location = New Point(62, 278)
            Me.BtnDeny.Name = "BtnDeny"
            Me.BtnDeny.Size = New Size(150, 30)
            Me.BtnDeny.TabIndex = 17
            Me.BtnDeny.Text = "&Deny"
            Me.BtnDeny.UseVisualStyleBackColor = True
            '
            'BtnBack
            '
            Me.BtnBack.DialogResult = DialogResult.Cancel
            Me.BtnBack.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnBack.Location = New Point(62, 314)
            Me.BtnBack.Name = "BtnBack"
            Me.BtnBack.Size = New Size(150, 30)
            Me.BtnBack.TabIndex = 18
            Me.BtnBack.Text = "&Back"
            Me.BtnBack.UseVisualStyleBackColor = True
            '
            'frmManageApplications
            '
            Me.AutoScaleDimensions = New SizeF(9.0!, 18.0!)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.CancelButton = Me.BtnBack
            Me.ClientSize = New Size(274, 355)
            Me.Controls.Add(Me.BtnBack)
            Me.Controls.Add(Me.BtnDeny)
            Me.Controls.Add(Me.BtnConfirm)
            Me.Controls.Add(Me.LstApplications)
            Me.Controls.Add(Me.LblGuildName)
            Me.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Margin = New Padding(4)
            Me.MaximizeBox = False
            Me.MaximumSize = New Size(290, 394)
            Me.MinimumSize = New Size(290, 394)
            Me.Name = "frmManageApplications"
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.Text = "Manage Applications"
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents LblGuildName As Label
        Friend WithEvents LstApplications As ListBox
        Friend WithEvents BtnConfirm As Button
        Friend WithEvents BtnDeny As Button
        Friend WithEvents BtnBack As Button
    End Class
End NameSpace