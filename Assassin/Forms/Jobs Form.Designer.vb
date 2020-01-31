Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

Namespace Forms
    <DesignerGenerated()> _
    Partial Class FrmJobs
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
            Me.components = New Container()
            Me.txtJobs = New TextBox()
            Me.btnAccept = New Button()
            Me.btnDecline = New Button()
            Me.btnLeave = New Button()
            Me.Timer1 = New Timer(Me.components)
            Me.SuspendLayout
            '
            'txtJobs
            '
            Me.txtJobs.BorderStyle = BorderStyle.FixedSingle
            Me.txtJobs.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.txtJobs.Location = New Point(13, 13)
            Me.txtJobs.Margin = New Padding(4)
            Me.txtJobs.Multiline = True
            Me.txtJobs.Name = "txtJobs"
            Me.txtJobs.ReadOnly = True
            Me.txtJobs.ScrollBars = ScrollBars.Vertical
            Me.txtJobs.Size = New Size(400, 150)
            Me.txtJobs.TabIndex = 3
            Me.txtJobs.Text = "You sit at a table and wait."
            '
            'btnAccept
            '
            Me.btnAccept.Enabled = False
            Me.btnAccept.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnAccept.Location = New Point(60, 170)
            Me.btnAccept.Name = "btnAccept"
            Me.btnAccept.Size = New Size(150, 30)
            Me.btnAccept.TabIndex = 0
            Me.btnAccept.Text = "&Accept"
            Me.btnAccept.UseVisualStyleBackColor = True
            '
            'btnDecline
            '
            Me.btnDecline.Enabled = False
            Me.btnDecline.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnDecline.Location = New Point(216, 170)
            Me.btnDecline.Name = "btnDecline"
            Me.btnDecline.Size = New Size(150, 30)
            Me.btnDecline.TabIndex = 1
            Me.btnDecline.Text = "&Decline"
            Me.btnDecline.UseVisualStyleBackColor = True
            '
            'btnLeave
            '
            Me.btnLeave.Enabled = False
            Me.btnLeave.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnLeave.Location = New Point(138, 206)
            Me.btnLeave.Name = "btnLeave"
            Me.btnLeave.Size = New Size(150, 30)
            Me.btnLeave.TabIndex = 2
            Me.btnLeave.Text = "&Leave Table"
            Me.btnLeave.UseVisualStyleBackColor = True
            '
            'Timer1
            '
            Me.Timer1.Interval = 1000
            '
            'frmJobs
            '
            Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.CancelButton = Me.btnLeave
            Me.ClientSize = New Size(426, 247)
            Me.Controls.Add(Me.btnLeave)
            Me.Controls.Add(Me.btnDecline)
            Me.Controls.Add(Me.btnAccept)
            Me.Controls.Add(Me.txtJobs)
            Me.MaximizeBox = False
            Me.MaximumSize = New Size(442, 286)
            Me.MinimumSize = New Size(442, 286)
            Me.Name = "frmJobs"
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.Text = "Job Opportunities"
            Me.ResumeLayout(false)
            Me.PerformLayout

        End Sub
        Friend WithEvents TxtJobs As TextBox
        Friend WithEvents BtnAccept As Button
        Friend WithEvents BtnDecline As Button
        Friend WithEvents BtnLeave As Button
        Friend WithEvents Timer1 As Timer
    End Class
End NameSpace