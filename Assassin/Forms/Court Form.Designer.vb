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
            Me.BtnPayFine = New Button()
            Me.BtnJail = New Button()
            Me.BtnFreedom = New Button()
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
            'BtnPayFine
            '
            Me.BtnPayFine.Enabled = False
            Me.BtnPayFine.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnPayFine.Location = New Point(13, 169)
            Me.BtnPayFine.Margin = New Padding(4)
            Me.BtnPayFine.MaximumSize = New Size(150, 30)
            Me.BtnPayFine.MinimumSize = New Size(150, 30)
            Me.BtnPayFine.Name = "BtnPayFine"
            Me.BtnPayFine.Size = New Size(150, 30)
            Me.BtnPayFine.TabIndex = 0
            Me.BtnPayFine.Text = "&Pay Fine"
            Me.BtnPayFine.UseVisualStyleBackColor = True
            '
            'BtnJail
            '
            Me.BtnJail.Enabled = False
            Me.BtnJail.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnJail.Location = New Point(171, 169)
            Me.BtnJail.Margin = New Padding(4)
            Me.BtnJail.Name = "BtnJail"
            Me.BtnJail.Size = New Size(150, 30)
            Me.BtnJail.TabIndex = 1
            Me.BtnJail.Text = "&Go to Jail"
            Me.BtnJail.UseVisualStyleBackColor = True
            '
            'BtnFreedom
            '
            Me.BtnFreedom.Enabled = False
            Me.BtnFreedom.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnFreedom.Location = New Point(91, 207)
            Me.BtnFreedom.Margin = New Padding(4)
            Me.BtnFreedom.Name = "BtnFreedom"
            Me.BtnFreedom.Size = New Size(150, 30)
            Me.BtnFreedom.TabIndex = 2
            Me.BtnFreedom.Text = "&Freedom!"
            Me.BtnFreedom.UseVisualStyleBackColor = True
            '
            'frmCourt
            '
            Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.ClientSize = New Size(332, 250)
            Me.Controls.Add(Me.BtnFreedom)
            Me.Controls.Add(Me.BtnJail)
            Me.Controls.Add(Me.BtnPayFine)
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