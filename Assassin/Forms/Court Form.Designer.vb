Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

Namespace Forms
    <DesignerGenerated()> _
    Partial Class FrmCourt
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
            Me.Timer1 = New Timer(Me.components)
            Me.txtCourt = New TextBox()
            Me.btnPayFine = New Button()
            Me.btnJail = New Button()
            Me.btnFreedom = New Button()
            Me.SuspendLayout()
            '
            'Timer1
            '
            Me.Timer1.Interval = 1500
            '
            'txtCourt
            '
            Me.txtCourt.BorderStyle = BorderStyle.FixedSingle
            Me.txtCourt.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.txtCourt.Location = New Point(12, 12)
            Me.txtCourt.MaximumSize = New Size(308, 150)
            Me.txtCourt.MinimumSize = New Size(308, 150)
            Me.txtCourt.Multiline = True
            Me.txtCourt.Name = "txtCourt"
            Me.txtCourt.ReadOnly = True
            Me.txtCourt.ScrollBars = ScrollBars.Vertical
            Me.txtCourt.Size = New Size(308, 150)
            Me.txtCourt.TabIndex = 3
            '
            'btnPayFine
            '
            Me.btnPayFine.Enabled = False
            Me.btnPayFine.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnPayFine.Location = New Point(13, 169)
            Me.btnPayFine.Margin = New Padding(4)
            Me.btnPayFine.MaximumSize = New Size(150, 30)
            Me.btnPayFine.MinimumSize = New Size(150, 30)
            Me.btnPayFine.Name = "btnPayFine"
            Me.btnPayFine.Size = New Size(150, 30)
            Me.btnPayFine.TabIndex = 0
            Me.btnPayFine.Text = "&Pay Fine"
            Me.btnPayFine.UseVisualStyleBackColor = True
            '
            'btnJail
            '
            Me.btnJail.Enabled = False
            Me.btnJail.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnJail.Location = New Point(171, 169)
            Me.btnJail.Margin = New Padding(4)
            Me.btnJail.Name = "btnJail"
            Me.btnJail.Size = New Size(150, 30)
            Me.btnJail.TabIndex = 1
            Me.btnJail.Text = "&Go to Jail"
            Me.btnJail.UseVisualStyleBackColor = True
            '
            'btnFreedom
            '
            Me.btnFreedom.Enabled = False
            Me.btnFreedom.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnFreedom.Location = New Point(91, 207)
            Me.btnFreedom.Margin = New Padding(4)
            Me.btnFreedom.Name = "btnFreedom"
            Me.btnFreedom.Size = New Size(150, 30)
            Me.btnFreedom.TabIndex = 2
            Me.btnFreedom.Text = "&Freedom!"
            Me.btnFreedom.UseVisualStyleBackColor = True
            '
            'frmCourt
            '
            Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.ClientSize = New Size(332, 250)
            Me.Controls.Add(Me.btnFreedom)
            Me.Controls.Add(Me.btnJail)
            Me.Controls.Add(Me.btnPayFine)
            Me.Controls.Add(Me.txtCourt)
            Me.MaximizeBox = False
            Me.MaximumSize = New Size(348, 288)
            Me.MinimumSize = New Size(348, 288)
            Me.Name = "frmCourt"
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.Text = "Courts of Justice"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents Timer1 As Timer
        Friend WithEvents TxtCourt As TextBox
        Friend WithEvents BtnPayFine As Button
        Friend WithEvents BtnJail As Button
        Friend WithEvents BtnFreedom As Button
    End Class
End NameSpace