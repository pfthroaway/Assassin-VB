<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCourt
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtCourt = New System.Windows.Forms.TextBox()
        Me.btnPayFine = New System.Windows.Forms.Button()
        Me.btnJail = New System.Windows.Forms.Button()
        Me.btnFreedom = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1500
        '
        'txtCourt
        '
        Me.txtCourt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCourt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCourt.Location = New System.Drawing.Point(12, 12)
        Me.txtCourt.MaximumSize = New System.Drawing.Size(308, 150)
        Me.txtCourt.MinimumSize = New System.Drawing.Size(308, 150)
        Me.txtCourt.Multiline = True
        Me.txtCourt.Name = "txtCourt"
        Me.txtCourt.ReadOnly = True
        Me.txtCourt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCourt.Size = New System.Drawing.Size(308, 150)
        Me.txtCourt.TabIndex = 3
        '
        'btnPayFine
        '
        Me.btnPayFine.Enabled = False
        Me.btnPayFine.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayFine.Location = New System.Drawing.Point(13, 169)
        Me.btnPayFine.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPayFine.MaximumSize = New System.Drawing.Size(150, 30)
        Me.btnPayFine.MinimumSize = New System.Drawing.Size(150, 30)
        Me.btnPayFine.Name = "btnPayFine"
        Me.btnPayFine.Size = New System.Drawing.Size(150, 30)
        Me.btnPayFine.TabIndex = 0
        Me.btnPayFine.Text = "&Pay Fine"
        Me.btnPayFine.UseVisualStyleBackColor = True
        '
        'btnJail
        '
        Me.btnJail.Enabled = False
        Me.btnJail.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJail.Location = New System.Drawing.Point(171, 169)
        Me.btnJail.Margin = New System.Windows.Forms.Padding(4)
        Me.btnJail.Name = "btnJail"
        Me.btnJail.Size = New System.Drawing.Size(150, 30)
        Me.btnJail.TabIndex = 1
        Me.btnJail.Text = "&Go to Jail"
        Me.btnJail.UseVisualStyleBackColor = True
        '
        'btnFreedom
        '
        Me.btnFreedom.Enabled = False
        Me.btnFreedom.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFreedom.Location = New System.Drawing.Point(91, 207)
        Me.btnFreedom.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFreedom.Name = "btnFreedom"
        Me.btnFreedom.Size = New System.Drawing.Size(150, 30)
        Me.btnFreedom.TabIndex = 2
        Me.btnFreedom.Text = "&Freedom!"
        Me.btnFreedom.UseVisualStyleBackColor = True
        '
        'frmCourt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(332, 250)
        Me.Controls.Add(Me.btnFreedom)
        Me.Controls.Add(Me.btnJail)
        Me.Controls.Add(Me.btnPayFine)
        Me.Controls.Add(Me.txtCourt)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(348, 288)
        Me.MinimumSize = New System.Drawing.Size(348, 288)
        Me.Name = "frmCourt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Courts of Justice"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents txtCourt As System.Windows.Forms.TextBox
    Friend WithEvents btnPayFine As System.Windows.Forms.Button
    Friend WithEvents btnJail As System.Windows.Forms.Button
    Friend WithEvents btnFreedom As System.Windows.Forms.Button
End Class
