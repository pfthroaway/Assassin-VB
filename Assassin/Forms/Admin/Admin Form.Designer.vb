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
            Me.BtnGuilds = New Button()
            Me.BtnEnemies = New Button()
            Me.BtnUsers = New Button()
            Me.BtnBack = New Button()
            Me.Label1 = New Label()
            Me.BtnChangePassword = New Button()
            Me.SuspendLayout()
            '
            'BtnGuilds
            '
            Me.BtnGuilds.DialogResult = DialogResult.Cancel
            Me.BtnGuilds.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnGuilds.Location = New Point(13, 81)
            Me.BtnGuilds.Margin = New Padding(4)
            Me.BtnGuilds.Name = "BtnGuilds"
            Me.BtnGuilds.Size = New Size(175, 30)
            Me.BtnGuilds.TabIndex = 1
            Me.BtnGuilds.Text = "&Guilds"
            Me.BtnGuilds.UseVisualStyleBackColor = True
            '
            'BtnEnemies
            '
            Me.BtnEnemies.DialogResult = DialogResult.Cancel
            Me.BtnEnemies.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnEnemies.Location = New Point(13, 43)
            Me.BtnEnemies.Margin = New Padding(4)
            Me.BtnEnemies.Name = "BtnEnemies"
            Me.BtnEnemies.Size = New Size(175, 30)
            Me.BtnEnemies.TabIndex = 0
            Me.BtnEnemies.Text = "&Enemies"
            Me.BtnEnemies.UseVisualStyleBackColor = True
            '
            'BtnUsers
            '
            Me.BtnUsers.DialogResult = DialogResult.Cancel
            Me.BtnUsers.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnUsers.Location = New Point(13, 119)
            Me.BtnUsers.Margin = New Padding(4)
            Me.BtnUsers.Name = "BtnUsers"
            Me.BtnUsers.Size = New Size(175, 30)
            Me.BtnUsers.TabIndex = 2
            Me.BtnUsers.Text = "&Users"
            Me.BtnUsers.UseVisualStyleBackColor = True
            '
            'BtnBack
            '
            Me.BtnBack.DialogResult = DialogResult.Cancel
            Me.BtnBack.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnBack.Location = New Point(13, 195)
            Me.BtnBack.Margin = New Padding(4)
            Me.BtnBack.Name = "BtnBack"
            Me.BtnBack.Size = New Size(175, 30)
            Me.BtnBack.TabIndex = 3
            Me.BtnBack.Text = "&Back"
            Me.BtnBack.UseVisualStyleBackColor = True
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
            'BtnChangePassword
            '
            Me.BtnChangePassword.DialogResult = DialogResult.Cancel
            Me.BtnChangePassword.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnChangePassword.Location = New Point(13, 157)
            Me.BtnChangePassword.Margin = New Padding(4)
            Me.BtnChangePassword.Name = "BtnChangePassword"
            Me.BtnChangePassword.Size = New Size(175, 30)
            Me.BtnChangePassword.TabIndex = 5
            Me.BtnChangePassword.Text = "&Change Password"
            Me.BtnChangePassword.UseVisualStyleBackColor = True
            '
            'frmAdmin
            '
            Me.AutoScaleDimensions = New SizeF(9.0!, 18.0!)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.CancelButton = Me.BtnBack
            Me.ClientSize = New Size(201, 237)
            Me.Controls.Add(Me.BtnChangePassword)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.BtnBack)
            Me.Controls.Add(Me.BtnUsers)
            Me.Controls.Add(Me.BtnEnemies)
            Me.Controls.Add(Me.BtnGuilds)
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