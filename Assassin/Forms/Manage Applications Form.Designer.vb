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
            Me.lblGuildName = New Label()
            Me.lstApplications = New ListBox()
            Me.btnConfirm = New Button()
            Me.btnDeny = New Button()
            Me.btnBack = New Button()
            Me.SuspendLayout()
            '
            'lblGuildName
            '
            Me.lblGuildName.Font = New Font("Arial", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblGuildName.Location = New Point(12, 9)
            Me.lblGuildName.Name = "lblGuildName"
            Me.lblGuildName.Size = New Size(250, 40)
            Me.lblGuildName.TabIndex = 14
            Me.lblGuildName.Text = "Manage Applications"
            Me.lblGuildName.TextAlign = ContentAlignment.MiddleCenter
            '
            'lstApplications
            '
            Me.lstApplications.FormattingEnabled = True
            Me.lstApplications.ItemHeight = 18
            Me.lstApplications.Location = New Point(17, 52)
            Me.lstApplications.Name = "lstApplications"
            Me.lstApplications.Size = New Size(245, 184)
            Me.lstApplications.TabIndex = 15
            '
            'btnConfirm
            '
            Me.btnConfirm.Enabled = False
            Me.btnConfirm.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnConfirm.Location = New Point(62, 242)
            Me.btnConfirm.Name = "btnConfirm"
            Me.btnConfirm.Size = New Size(150, 30)
            Me.btnConfirm.TabIndex = 16
            Me.btnConfirm.Text = "&Confirm"
            Me.btnConfirm.UseVisualStyleBackColor = True
            '
            'btnDeny
            '
            Me.btnDeny.Enabled = False
            Me.btnDeny.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnDeny.Location = New Point(62, 278)
            Me.btnDeny.Name = "btnDeny"
            Me.btnDeny.Size = New Size(150, 30)
            Me.btnDeny.TabIndex = 17
            Me.btnDeny.Text = "&Deny"
            Me.btnDeny.UseVisualStyleBackColor = True
            '
            'btnBack
            '
            Me.btnBack.DialogResult = DialogResult.Cancel
            Me.btnBack.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnBack.Location = New Point(62, 314)
            Me.btnBack.Name = "btnBack"
            Me.btnBack.Size = New Size(150, 30)
            Me.btnBack.TabIndex = 18
            Me.btnBack.Text = "&Back"
            Me.btnBack.UseVisualStyleBackColor = True
            '
            'frmManageApplications
            '
            Me.AutoScaleDimensions = New SizeF(9.0!, 18.0!)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.CancelButton = Me.btnBack
            Me.ClientSize = New Size(274, 355)
            Me.Controls.Add(Me.btnBack)
            Me.Controls.Add(Me.btnDeny)
            Me.Controls.Add(Me.btnConfirm)
            Me.Controls.Add(Me.lstApplications)
            Me.Controls.Add(Me.lblGuildName)
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
        Friend WithEvents lblGuildName As Label
        Friend WithEvents LstApplications As ListBox
        Friend WithEvents BtnConfirm As Button
        Friend WithEvents BtnDeny As Button
        Friend WithEvents BtnBack As Button
    End Class
End NameSpace