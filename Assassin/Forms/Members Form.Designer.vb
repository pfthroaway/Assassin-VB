Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

Namespace Forms
    <DesignerGenerated()> _
    Partial Class FrmMembers
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
            Me.LstMembers = New ListBox()
            Me.LblName = New Label()
            Me.BtnBack = New Button()
            Me.BtnMessage = New Button()
            Me.BtnExpel = New Button()
            Me.BtnAttack = New Button()
            Me.SuspendLayout()
            '
            'LstMembers
            '
            Me.LstMembers.FormattingEnabled = True
            Me.LstMembers.ItemHeight = 18
            Me.LstMembers.Location = New Point(12, 72)
            Me.LstMembers.Name = "LstMembers"
            Me.LstMembers.ScrollAlwaysVisible = True
            Me.LstMembers.Size = New Size(225, 220)
            Me.LstMembers.TabIndex = 0
            '
            'LblName
            '
            Me.LblName.Font = New Font("Arial", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.LblName.Location = New Point(12, 9)
            Me.LblName.Name = "LblName"
            Me.LblName.Size = New Size(225, 60)
            Me.LblName.TabIndex = 5
            Me.LblName.Text = "Members"
            Me.LblName.TextAlign = ContentAlignment.MiddleCenter
            '
            'BtnBack
            '
            Me.BtnBack.DialogResult = DialogResult.Cancel
            Me.BtnBack.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnBack.Location = New Point(49, 406)
            Me.BtnBack.Name = "BtnBack"
            Me.BtnBack.Size = New Size(150, 30)
            Me.BtnBack.TabIndex = 4
            Me.BtnBack.Text = "&Back"
            Me.BtnBack.UseVisualStyleBackColor = True
            '
            'BtnMessage
            '
            Me.BtnMessage.Enabled = False
            Me.BtnMessage.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnMessage.Location = New Point(49, 298)
            Me.BtnMessage.Name = "BtnMessage"
            Me.BtnMessage.Size = New Size(150, 30)
            Me.BtnMessage.TabIndex = 1
            Me.BtnMessage.Text = "&Message"
            Me.BtnMessage.UseVisualStyleBackColor = True
            '
            'BtnExpel
            '
            Me.BtnExpel.Enabled = False
            Me.BtnExpel.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnExpel.Location = New Point(49, 334)
            Me.BtnExpel.Name = "BtnExpel"
            Me.BtnExpel.Size = New Size(150, 30)
            Me.BtnExpel.TabIndex = 2
            Me.BtnExpel.Text = "&Expel"
            Me.BtnExpel.UseVisualStyleBackColor = True
            Me.BtnExpel.Visible = False
            '
            'BtnAttack
            '
            Me.BtnAttack.Enabled = False
            Me.BtnAttack.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnAttack.Location = New Point(49, 370)
            Me.BtnAttack.Name = "BtnAttack"
            Me.BtnAttack.Size = New Size(150, 30)
            Me.BtnAttack.TabIndex = 3
            Me.BtnAttack.Text = "&Attack"
            Me.BtnAttack.UseVisualStyleBackColor = True
            Me.BtnAttack.Visible = False
            '
            'frmMembers
            '
            Me.AutoScaleDimensions = New SizeF(9.0!, 18.0!)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.CancelButton = Me.BtnBack
            Me.ClientSize = New Size(249, 447)
            Me.Controls.Add(Me.BtnAttack)
            Me.Controls.Add(Me.BtnExpel)
            Me.Controls.Add(Me.BtnMessage)
            Me.Controls.Add(Me.BtnBack)
            Me.Controls.Add(Me.LblName)
            Me.Controls.Add(Me.LstMembers)
            Me.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Margin = New Padding(4)
            Me.MaximizeBox = False
            Me.MaximumSize = New Size(265, 486)
            Me.MinimumSize = New Size(265, 486)
            Me.Name = "frmMembers"
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.Text = "Members"
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents LstMembers As ListBox
        Friend WithEvents LblName As Label
        Friend WithEvents BtnBack As Button
        Friend WithEvents BtnMessage As Button
        Friend WithEvents BtnExpel As Button
        Friend WithEvents BtnAttack As Button
    End Class
End NameSpace