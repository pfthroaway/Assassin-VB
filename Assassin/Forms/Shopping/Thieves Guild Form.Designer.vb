Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

Namespace Forms.Shopping
    <DesignerGenerated()>
    Partial Class FrmThievesGuild
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
            Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(FrmThievesGuild))
            Me.lblGold = New Label()
            Me.Label1 = New Label()
            Me.TxtThievesGuild = New TextBox()
            Me.lblLockpicks = New Label()
            Me.Label3 = New Label()
            Me.BtnPurchase = New Button()
            Me.BtnBack = New Button()
            Me.SuspendLayout()
            '
            'lblGold
            '
            Me.lblGold.BorderStyle = BorderStyle.FixedSingle
            Me.lblGold.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblGold.Location = New Point(12, 180)
            Me.lblGold.Name = "lblGold"
            Me.lblGold.Size = New Size(150, 25)
            Me.lblGold.TabIndex = 11
            Me.lblGold.TextAlign = ContentAlignment.MiddleCenter
            '
            'Label1
            '
            Me.Label1.BorderStyle = BorderStyle.FixedSingle
            Me.Label1.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New Point(12, 158)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New Size(150, 25)
            Me.Label1.TabIndex = 10
            Me.Label1.Text = "Current Gold:"
            Me.Label1.TextAlign = ContentAlignment.MiddleCenter
            '
            'txtThievesGuild
            '
            Me.TxtThievesGuild.BorderStyle = BorderStyle.FixedSingle
            Me.TxtThievesGuild.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.TxtThievesGuild.Location = New Point(12, 12)
            Me.TxtThievesGuild.Multiline = True
            Me.TxtThievesGuild.Name = "txtThievesGuild"
            Me.TxtThievesGuild.ReadOnly = True
            Me.TxtThievesGuild.ScrollBars = ScrollBars.Vertical
            Me.TxtThievesGuild.Size = New Size(402, 143)
            Me.TxtThievesGuild.TabIndex = 12
            Me.TxtThievesGuild.Text = resources.GetString("txtThievesGuild.Text")
            '
            'lblLockpicks
            '
            Me.lblLockpicks.BorderStyle = BorderStyle.FixedSingle
            Me.lblLockpicks.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblLockpicks.Location = New Point(264, 180)
            Me.lblLockpicks.Name = "lblLockpicks"
            Me.lblLockpicks.Size = New Size(150, 25)
            Me.lblLockpicks.TabIndex = 14
            Me.lblLockpicks.TextAlign = ContentAlignment.MiddleCenter
            '
            'Label3
            '
            Me.Label3.BorderStyle = BorderStyle.FixedSingle
            Me.Label3.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New Point(264, 158)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New Size(150, 25)
            Me.Label3.TabIndex = 13
            Me.Label3.Text = "Lockpicks Owned:"
            Me.Label3.TextAlign = ContentAlignment.MiddleCenter
            '
            'btnPurchase
            '
            Me.BtnPurchase.Enabled = False
            Me.BtnPurchase.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnPurchase.Location = New Point(129, 208)
            Me.BtnPurchase.Name = "btnPurchase"
            Me.BtnPurchase.Size = New Size(150, 35)
            Me.BtnPurchase.TabIndex = 15
            Me.BtnPurchase.Text = "&Purchase"
            Me.BtnPurchase.UseVisualStyleBackColor = True
            '
            'btnBack
            '
            Me.BtnBack.DialogResult = DialogResult.Cancel
            Me.BtnBack.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnBack.Location = New Point(129, 249)
            Me.BtnBack.Name = "btnBack"
            Me.BtnBack.Size = New Size(150, 35)
            Me.BtnBack.TabIndex = 16
            Me.BtnBack.Text = "&Back"
            Me.BtnBack.UseVisualStyleBackColor = True
            '
            'frmThievesGuild
            '
            Me.AutoScaleDimensions = New SizeF(9.0!, 18.0!)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.CancelButton = Me.BtnBack
            Me.ClientSize = New Size(426, 296)
            Me.Controls.Add(Me.BtnBack)
            Me.Controls.Add(Me.BtnPurchase)
            Me.Controls.Add(Me.lblLockpicks)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.TxtThievesGuild)
            Me.Controls.Add(Me.lblGold)
            Me.Controls.Add(Me.Label1)
            Me.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Margin = New Padding(4)
            Me.MaximizeBox = False
            Me.MaximumSize = New Size(442, 335)
            Me.MinimumSize = New Size(442, 335)
            Me.Name = "frmThievesGuild"
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.Text = "Thieves' Guild"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents lblGold As Label
        Friend WithEvents Label1 As Label
        Friend WithEvents TxtThievesGuild As TextBox
        Friend WithEvents lblLockpicks As Label
        Friend WithEvents Label3 As Label
        Friend WithEvents BtnPurchase As Button
        Friend WithEvents BtnBack As Button
    End Class
End Namespace