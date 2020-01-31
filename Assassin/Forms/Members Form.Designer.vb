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
            Me.lstMembers = New ListBox()
            Me.lblName = New Label()
            Me.btnBack = New Button()
            Me.btnMessage = New Button()
            Me.btnExpel = New Button()
            Me.btnAttack = New Button()
            Me.SuspendLayout()
            '
            'lstMembers
            '
            Me.lstMembers.FormattingEnabled = True
            Me.lstMembers.ItemHeight = 18
            Me.lstMembers.Location = New Point(12, 72)
            Me.lstMembers.Name = "lstMembers"
            Me.lstMembers.ScrollAlwaysVisible = True
            Me.lstMembers.Size = New Size(225, 220)
            Me.lstMembers.TabIndex = 0
            '
            'lblName
            '
            Me.lblName.Font = New Font("Arial", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblName.Location = New Point(12, 9)
            Me.lblName.Name = "lblName"
            Me.lblName.Size = New Size(225, 60)
            Me.lblName.TabIndex = 5
            Me.lblName.Text = "Members"
            Me.lblName.TextAlign = ContentAlignment.MiddleCenter
            '
            'btnBack
            '
            Me.btnBack.DialogResult = DialogResult.Cancel
            Me.btnBack.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnBack.Location = New Point(49, 406)
            Me.btnBack.Name = "btnBack"
            Me.btnBack.Size = New Size(150, 30)
            Me.btnBack.TabIndex = 4
            Me.btnBack.Text = "&Back"
            Me.btnBack.UseVisualStyleBackColor = True
            '
            'btnMessage
            '
            Me.btnMessage.Enabled = False
            Me.btnMessage.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnMessage.Location = New Point(49, 298)
            Me.btnMessage.Name = "btnMessage"
            Me.btnMessage.Size = New Size(150, 30)
            Me.btnMessage.TabIndex = 1
            Me.btnMessage.Text = "&Message"
            Me.btnMessage.UseVisualStyleBackColor = True
            '
            'btnExpel
            '
            Me.btnExpel.Enabled = False
            Me.btnExpel.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnExpel.Location = New Point(49, 334)
            Me.btnExpel.Name = "btnExpel"
            Me.btnExpel.Size = New Size(150, 30)
            Me.btnExpel.TabIndex = 2
            Me.btnExpel.Text = "&Expel"
            Me.btnExpel.UseVisualStyleBackColor = True
            Me.btnExpel.Visible = False
            '
            'btnAttack
            '
            Me.btnAttack.Enabled = False
            Me.btnAttack.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnAttack.Location = New Point(49, 370)
            Me.btnAttack.Name = "btnAttack"
            Me.btnAttack.Size = New Size(150, 30)
            Me.btnAttack.TabIndex = 3
            Me.btnAttack.Text = "&Attack"
            Me.btnAttack.UseVisualStyleBackColor = True
            Me.btnAttack.Visible = False
            '
            'frmMembers
            '
            Me.AutoScaleDimensions = New SizeF(9.0!, 18.0!)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.CancelButton = Me.btnBack
            Me.ClientSize = New Size(249, 447)
            Me.Controls.Add(Me.btnAttack)
            Me.Controls.Add(Me.btnExpel)
            Me.Controls.Add(Me.btnMessage)
            Me.Controls.Add(Me.btnBack)
            Me.Controls.Add(Me.lblName)
            Me.Controls.Add(Me.lstMembers)
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
        Friend WithEvents lblName As Label
        Friend WithEvents BtnBack As Button
        Friend WithEvents BtnMessage As Button
        Friend WithEvents BtnExpel As Button
        Friend WithEvents BtnAttack As Button
    End Class
End NameSpace