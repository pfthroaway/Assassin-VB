<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRob
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
        Me.txtRob = New System.Windows.Forms.TextBox()
        Me.btnPickpocket = New System.Windows.Forms.Button()
        Me.btnWaylay = New System.Windows.Forms.Button()
        Me.btnNewVictim = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'txtRob
        '
        Me.txtRob.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRob.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRob.Location = New System.Drawing.Point(12, 12)
        Me.txtRob.MaximumSize = New System.Drawing.Size(308, 150)
        Me.txtRob.MinimumSize = New System.Drawing.Size(308, 150)
        Me.txtRob.Multiline = True
        Me.txtRob.Name = "txtRob"
        Me.txtRob.ReadOnly = True
        Me.txtRob.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRob.Size = New System.Drawing.Size(308, 150)
        Me.txtRob.TabIndex = 0
        '
        'btnPickpocket
        '
        Me.btnPickpocket.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPickpocket.Location = New System.Drawing.Point(13, 169)
        Me.btnPickpocket.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPickpocket.Name = "btnPickpocket"
        Me.btnPickpocket.Size = New System.Drawing.Size(150, 30)
        Me.btnPickpocket.TabIndex = 1
        Me.btnPickpocket.Text = "&Pickpocket"
        Me.btnPickpocket.UseVisualStyleBackColor = True
        '
        'btnWaylay
        '
        Me.btnWaylay.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWaylay.Location = New System.Drawing.Point(171, 169)
        Me.btnWaylay.Margin = New System.Windows.Forms.Padding(4)
        Me.btnWaylay.Name = "btnWaylay"
        Me.btnWaylay.Size = New System.Drawing.Size(150, 30)
        Me.btnWaylay.TabIndex = 2
        Me.btnWaylay.Text = "&Waylay"
        Me.btnWaylay.UseVisualStyleBackColor = True
        '
        'btnNewVictim
        '
        Me.btnNewVictim.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewVictim.Location = New System.Drawing.Point(13, 207)
        Me.btnNewVictim.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNewVictim.Name = "btnNewVictim"
        Me.btnNewVictim.Size = New System.Drawing.Size(150, 30)
        Me.btnNewVictim.TabIndex = 3
        Me.btnNewVictim.Text = "&Stalk New Victim"
        Me.btnNewVictim.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNewVictim.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBack.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(171, 207)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(150, 30)
        Me.btnBack.TabIndex = 4
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1500
        '
        'Timer2
        '
        Me.Timer2.Interval = 5000
        '
        'frmRob
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnBack
        Me.ClientSize = New System.Drawing.Size(332, 249)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnNewVictim)
        Me.Controls.Add(Me.btnWaylay)
        Me.Controls.Add(Me.btnPickpocket)
        Me.Controls.Add(Me.txtRob)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(348, 288)
        Me.MinimumSize = New System.Drawing.Size(348, 288)
        Me.Name = "frmRob"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Robbery"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtRob As System.Windows.Forms.TextBox
    Friend WithEvents btnPickpocket As System.Windows.Forms.Button
    Friend WithEvents btnWaylay As System.Windows.Forms.Button
    Friend WithEvents btnNewVictim As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
End Class
