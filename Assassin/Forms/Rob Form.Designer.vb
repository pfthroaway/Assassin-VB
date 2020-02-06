Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

Namespace Forms
    <DesignerGenerated()>
    Partial Class FrmRob
        Inherits Form

        'Form overrides dispose to clean up the component list.
        <DebuggerNonUserCode()>
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
        <DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.TxtRob = New System.Windows.Forms.TextBox()
            Me.BtnPickpocket = New System.Windows.Forms.Button()
            Me.BtnWaylay = New System.Windows.Forms.Button()
            Me.BtnNewVictim = New System.Windows.Forms.Button()
            Me.BtnBack = New System.Windows.Forms.Button()
            Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.SuspendLayout()
            '
            'TxtRob
            '
            Me.TxtRob.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.TxtRob.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TxtRob.Location = New System.Drawing.Point(12, 12)
            Me.TxtRob.MaximumSize = New System.Drawing.Size(308, 150)
            Me.TxtRob.MinimumSize = New System.Drawing.Size(308, 308)
            Me.TxtRob.Multiline = True
            Me.TxtRob.Name = "TxtRob"
            Me.TxtRob.ReadOnly = True
            Me.TxtRob.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.TxtRob.Size = New System.Drawing.Size(308, 308)
            Me.TxtRob.TabIndex = 0
            '
            'BtnPickpocket
            '
            Me.BtnPickpocket.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnPickpocket.Location = New System.Drawing.Point(13, 327)
            Me.BtnPickpocket.Margin = New System.Windows.Forms.Padding(4)
            Me.BtnPickpocket.Name = "BtnPickpocket"
            Me.BtnPickpocket.Size = New System.Drawing.Size(150, 30)
            Me.BtnPickpocket.TabIndex = 1
            Me.BtnPickpocket.Text = "&Pickpocket"
            Me.BtnPickpocket.UseVisualStyleBackColor = True
            '
            'BtnWaylay
            '
            Me.BtnWaylay.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnWaylay.Location = New System.Drawing.Point(171, 327)
            Me.BtnWaylay.Margin = New System.Windows.Forms.Padding(4)
            Me.BtnWaylay.Name = "BtnWaylay"
            Me.BtnWaylay.Size = New System.Drawing.Size(150, 30)
            Me.BtnWaylay.TabIndex = 2
            Me.BtnWaylay.Text = "&Waylay"
            Me.BtnWaylay.UseVisualStyleBackColor = True
            '
            'BtnNewVictim
            '
            Me.BtnNewVictim.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnNewVictim.Location = New System.Drawing.Point(13, 365)
            Me.BtnNewVictim.Margin = New System.Windows.Forms.Padding(4)
            Me.BtnNewVictim.Name = "BtnNewVictim"
            Me.BtnNewVictim.Size = New System.Drawing.Size(150, 30)
            Me.BtnNewVictim.TabIndex = 3
            Me.BtnNewVictim.Text = "&Stalk New Victim"
            Me.BtnNewVictim.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.BtnNewVictim.UseVisualStyleBackColor = True
            '
            'BtnBack
            '
            Me.BtnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.BtnBack.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnBack.Location = New System.Drawing.Point(171, 365)
            Me.BtnBack.Margin = New System.Windows.Forms.Padding(4)
            Me.BtnBack.Name = "BtnBack"
            Me.BtnBack.Size = New System.Drawing.Size(150, 30)
            Me.BtnBack.TabIndex = 4
            Me.BtnBack.Text = "&Back"
            Me.BtnBack.UseVisualStyleBackColor = True
            '
            'Timer1
            '
            Me.Timer1.Interval = 1500
            '
            'FrmRob
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.BtnBack
            Me.ClientSize = New System.Drawing.Size(332, 407)
            Me.Controls.Add(Me.BtnBack)
            Me.Controls.Add(Me.BtnNewVictim)
            Me.Controls.Add(Me.BtnWaylay)
            Me.Controls.Add(Me.BtnPickpocket)
            Me.Controls.Add(Me.TxtRob)
            Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.MaximizeBox = False
            Me.MaximumSize = New System.Drawing.Size(348, 446)
            Me.MinimumSize = New System.Drawing.Size(348, 446)
            Me.Name = "FrmRob"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Robbery"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents TxtRob As TextBox
        Friend WithEvents BtnPickpocket As Button
        Friend WithEvents BtnWaylay As Button
        Friend WithEvents BtnNewVictim As Button
        Friend WithEvents BtnBack As Button
        Friend WithEvents Timer1 As Timer
    End Class
End NameSpace