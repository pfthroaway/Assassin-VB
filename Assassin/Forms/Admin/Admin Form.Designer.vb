Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

Namespace Forms.Admin
    <DesignerGenerated()> _
    Partial Class FrmAdmin
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
            Me.btnGuilds = New Button()
            Me.btnEnemies = New Button()
            Me.btnUsers = New Button()
            Me.btnBack = New Button()
            Me.Label1 = New Label()
            Me.btnChangePassword = New Button()
            Me.SuspendLayout()
            '
            'btnGuilds
            '
            Me.btnGuilds.DialogResult = DialogResult.Cancel
            Me.btnGuilds.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuilds.Location = New Point(13, 81)
            Me.btnGuilds.Margin = New Padding(4)
            Me.btnGuilds.Name = "btnGuilds"
            Me.btnGuilds.Size = New Size(175, 30)
            Me.btnGuilds.TabIndex = 1
            Me.btnGuilds.Text = "&Guilds"
            Me.btnGuilds.UseVisualStyleBackColor = True
            '
            'btnEnemies
            '
            Me.btnEnemies.DialogResult = DialogResult.Cancel
            Me.btnEnemies.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnEnemies.Location = New Point(13, 43)
            Me.btnEnemies.Margin = New Padding(4)
            Me.btnEnemies.Name = "btnEnemies"
            Me.btnEnemies.Size = New Size(175, 30)
            Me.btnEnemies.TabIndex = 0
            Me.btnEnemies.Text = "&Enemies"
            Me.btnEnemies.UseVisualStyleBackColor = True
            '
            'btnUsers
            '
            Me.btnUsers.DialogResult = DialogResult.Cancel
            Me.btnUsers.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnUsers.Location = New Point(13, 119)
            Me.btnUsers.Margin = New Padding(4)
            Me.btnUsers.Name = "btnUsers"
            Me.btnUsers.Size = New Size(175, 30)
            Me.btnUsers.TabIndex = 2
            Me.btnUsers.Text = "&Users"
            Me.btnUsers.UseVisualStyleBackColor = True
            '
            'btnBack
            '
            Me.btnBack.DialogResult = DialogResult.Cancel
            Me.btnBack.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnBack.Location = New Point(13, 195)
            Me.btnBack.Margin = New Padding(4)
            Me.btnBack.Name = "btnBack"
            Me.btnBack.Size = New Size(175, 30)
            Me.btnBack.TabIndex = 3
            Me.btnBack.Text = "&Back"
            Me.btnBack.UseVisualStyleBackColor = True
            '
            'Label1
            '
            Me.Label1.Font = New Font("Arial", 15.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New Point(12, 9)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New Size(176, 30)
            Me.Label1.TabIndex = 4
            Me.Label1.Text = "Admin"
            Me.Label1.TextAlign = ContentAlignment.MiddleCenter
            '
            'btnChangePassword
            '
            Me.btnChangePassword.DialogResult = DialogResult.Cancel
            Me.btnChangePassword.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnChangePassword.Location = New Point(13, 157)
            Me.btnChangePassword.Margin = New Padding(4)
            Me.btnChangePassword.Name = "btnChangePassword"
            Me.btnChangePassword.Size = New Size(175, 30)
            Me.btnChangePassword.TabIndex = 5
            Me.btnChangePassword.Text = "&Change Password"
            Me.btnChangePassword.UseVisualStyleBackColor = True
            '
            'frmAdmin
            '
            Me.AutoScaleDimensions = New SizeF(9.0!, 18.0!)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.CancelButton = Me.btnBack
            Me.ClientSize = New Size(201, 237)
            Me.Controls.Add(Me.btnChangePassword)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.btnBack)
            Me.Controls.Add(Me.btnUsers)
            Me.Controls.Add(Me.btnEnemies)
            Me.Controls.Add(Me.btnGuilds)
            Me.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Margin = New Padding(4)
            Me.MaximizeBox = False
            Me.MaximumSize = New Size(217, 276)
            Me.MinimumSize = New Size(217, 276)
            Me.Name = "frmAdmin"
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.Text = "Admin"
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents BtnGuilds As Button
        Friend WithEvents BtnEnemies As Button
        Friend WithEvents BtnUsers As Button
        Friend WithEvents BtnBack As Button
        Friend WithEvents Label1 As Label
        Friend WithEvents BtnChangePassword As Button
    End Class
End NameSpace