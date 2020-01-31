Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

Namespace Forms.Admin
    <DesignerGenerated()> _
    Partial Class FrmAdminLogin
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
            Me.Label1 = New Label()
            Me.btnSubmit = New Button()
            Me.txtPassword = New TextBox()
            Me.SuspendLayout()
            '
            'Label1
            '
            Me.Label1.Location = New Point(13, 13)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New Size(159, 25)
            Me.Label1.TabIndex = 3
            Me.Label1.Text = "Enter the Password:"
            Me.Label1.TextAlign = ContentAlignment.MiddleCenter
            '
            'btnSubmit
            '
            Me.btnSubmit.Location = New Point(52, 80)
            Me.btnSubmit.Name = "btnSubmit"
            Me.btnSubmit.Size = New Size(80, 30)
            Me.btnSubmit.TabIndex = 1
            Me.btnSubmit.Text = "&Submit"
            Me.btnSubmit.UseVisualStyleBackColor = True
            '
            'txtPassword
            '
            Me.txtPassword.Location = New Point(16, 48)
            Me.txtPassword.Name = "txtPassword"
            Me.txtPassword.Size = New Size(156, 26)
            Me.txtPassword.TabIndex = 0
            Me.txtPassword.TextAlign = HorizontalAlignment.Center
            Me.txtPassword.UseSystemPasswordChar = True
            '
            'frmAdminLogin
            '
            Me.AcceptButton = Me.btnSubmit
            Me.AutoScaleDimensions = New SizeF(9.0!, 18.0!)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.ClientSize = New Size(184, 122)
            Me.Controls.Add(Me.txtPassword)
            Me.Controls.Add(Me.btnSubmit)
            Me.Controls.Add(Me.Label1)
            Me.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Margin = New Padding(4)
            Me.MaximizeBox = False
            Me.MaximumSize = New Size(200, 160)
            Me.MinimumSize = New Size(200, 160)
            Me.Name = "frmAdminLogin"
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.Text = "Admin Login"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents Label1 As Label
        Friend WithEvents BtnSubmit As Button
        Friend WithEvents TxtPassword As TextBox
    End Class
End NameSpace