Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

Namespace Forms
    <DesignerGenerated()> _
    Partial Class FrmRob
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
            Me.txtRob = New TextBox()
            Me.btnPickpocket = New Button()
            Me.btnWaylay = New Button()
            Me.btnNewVictim = New Button()
            Me.btnBack = New Button()
            Me.Timer1 = New Timer(Me.components)
            Me.Timer2 = New Timer(Me.components)
            Me.SuspendLayout()
            '
            'txtRob
            '
            Me.txtRob.BorderStyle = BorderStyle.FixedSingle
            Me.txtRob.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.txtRob.Location = New Point(12, 12)
            Me.txtRob.MaximumSize = New Size(308, 150)
            Me.txtRob.MinimumSize = New Size(308, 150)
            Me.txtRob.Multiline = True
            Me.txtRob.Name = "txtRob"
            Me.txtRob.ReadOnly = True
            Me.txtRob.ScrollBars = ScrollBars.Vertical
            Me.txtRob.Size = New Size(308, 150)
            Me.txtRob.TabIndex = 0
            '
            'btnPickpocket
            '
            Me.btnPickpocket.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnPickpocket.Location = New Point(13, 169)
            Me.btnPickpocket.Margin = New Padding(4)
            Me.btnPickpocket.Name = "btnPickpocket"
            Me.btnPickpocket.Size = New Size(150, 30)
            Me.btnPickpocket.TabIndex = 1
            Me.btnPickpocket.Text = "&Pickpocket"
            Me.btnPickpocket.UseVisualStyleBackColor = True
            '
            'btnWaylay
            '
            Me.btnWaylay.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnWaylay.Location = New Point(171, 169)
            Me.btnWaylay.Margin = New Padding(4)
            Me.btnWaylay.Name = "btnWaylay"
            Me.btnWaylay.Size = New Size(150, 30)
            Me.btnWaylay.TabIndex = 2
            Me.btnWaylay.Text = "&Waylay"
            Me.btnWaylay.UseVisualStyleBackColor = True
            '
            'btnNewVictim
            '
            Me.btnNewVictim.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnNewVictim.Location = New Point(13, 207)
            Me.btnNewVictim.Margin = New Padding(4)
            Me.btnNewVictim.Name = "btnNewVictim"
            Me.btnNewVictim.Size = New Size(150, 30)
            Me.btnNewVictim.TabIndex = 3
            Me.btnNewVictim.Text = "&Stalk New Victim"
            Me.btnNewVictim.TextAlign = ContentAlignment.MiddleRight
            Me.btnNewVictim.UseVisualStyleBackColor = True
            '
            'btnBack
            '
            Me.btnBack.DialogResult = DialogResult.Cancel
            Me.btnBack.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnBack.Location = New Point(171, 207)
            Me.btnBack.Margin = New Padding(4)
            Me.btnBack.Name = "btnBack"
            Me.btnBack.Size = New Size(150, 30)
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
            Me.AutoScaleDimensions = New SizeF(7.0!, 16.0!)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.CancelButton = Me.btnBack
            Me.ClientSize = New Size(332, 249)
            Me.Controls.Add(Me.btnBack)
            Me.Controls.Add(Me.btnNewVictim)
            Me.Controls.Add(Me.btnWaylay)
            Me.Controls.Add(Me.btnPickpocket)
            Me.Controls.Add(Me.txtRob)
            Me.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Margin = New Padding(3, 4, 3, 4)
            Me.MaximizeBox = False
            Me.MaximumSize = New Size(348, 288)
            Me.MinimumSize = New Size(348, 288)
            Me.Name = "frmRob"
            Me.StartPosition = FormStartPosition.CenterScreen
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
        Friend WithEvents Timer2 As Timer
    End Class
End NameSpace