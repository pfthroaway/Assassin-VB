<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGuildList
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
        Me.lstGuilds = New System.Windows.Forms.ListBox()
        Me.txtGuilds = New System.Windows.Forms.TextBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblGoldOnHand = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblGuildGold = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblHench1 = New System.Windows.Forms.Label()
        Me.lblHench2 = New System.Windows.Forms.Label()
        Me.lblHench3 = New System.Windows.Forms.Label()
        Me.lblHench4 = New System.Windows.Forms.Label()
        Me.lblHench5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblGuildmaster = New System.Windows.Forms.Label()
        Me.lblFee = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstGuilds
        '
        Me.lstGuilds.FormattingEnabled = True
        Me.lstGuilds.ItemHeight = 18
        Me.lstGuilds.Location = New System.Drawing.Point(12, 159)
        Me.lstGuilds.Name = "lstGuilds"
        Me.lstGuilds.Size = New System.Drawing.Size(225, 94)
        Me.lstGuilds.TabIndex = 0
        '
        'txtGuilds
        '
        Me.txtGuilds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGuilds.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuilds.Location = New System.Drawing.Point(12, 12)
        Me.txtGuilds.Multiline = True
        Me.txtGuilds.Name = "txtGuilds"
        Me.txtGuilds.ReadOnly = True
        Me.txtGuilds.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtGuilds.Size = New System.Drawing.Size(421, 132)
        Me.txtGuilds.TabIndex = 4
        Me.txtGuilds.Text = "You enter the Guilds district."
        '
        'btnEnter
        '
        Me.btnEnter.Enabled = False
        Me.btnEnter.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.Location = New System.Drawing.Point(49, 270)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(150, 30)
        Me.btnEnter.TabIndex = 1
        Me.btnEnter.Text = "&Enter"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnApply
        '
        Me.btnApply.Enabled = False
        Me.btnApply.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApply.Location = New System.Drawing.Point(49, 317)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(150, 30)
        Me.btnApply.TabIndex = 2
        Me.btnApply.Text = "&Apply"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBack.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(49, 364)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(150, 30)
        Me.btnBack.TabIndex = 3
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lblGoldOnHand
        '
        Me.lblGoldOnHand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGoldOnHand.Location = New System.Drawing.Point(363, 231)
        Me.lblGoldOnHand.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGoldOnHand.Name = "lblGoldOnHand"
        Me.lblGoldOnHand.Size = New System.Drawing.Size(70, 25)
        Me.lblGoldOnHand.TabIndex = 14
        Me.lblGoldOnHand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Location = New System.Drawing.Point(244, 231)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 25)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Gold on Hand:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGuildGold
        '
        Me.lblGuildGold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGuildGold.Location = New System.Drawing.Point(363, 255)
        Me.lblGuildGold.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGuildGold.Name = "lblGuildGold"
        Me.lblGuildGold.Size = New System.Drawing.Size(70, 25)
        Me.lblGuildGold.TabIndex = 18
        Me.lblGuildGold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Location = New System.Drawing.Point(244, 255)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 25)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Guild Gold:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Location = New System.Drawing.Point(244, 279)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(140, 25)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Lvl 1 Henchmen:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Location = New System.Drawing.Point(244, 303)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(140, 25)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Lvl 2 Henchmen:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Location = New System.Drawing.Point(244, 327)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(140, 25)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Lvl 3 Henchmen:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Location = New System.Drawing.Point(244, 351)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(140, 25)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Lvl 4 Henchmen:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.Location = New System.Drawing.Point(244, 375)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(140, 25)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Lvl 5 Henchmen:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHench1
        '
        Me.lblHench1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHench1.Location = New System.Drawing.Point(383, 279)
        Me.lblHench1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHench1.Name = "lblHench1"
        Me.lblHench1.Size = New System.Drawing.Size(50, 25)
        Me.lblHench1.TabIndex = 24
        Me.lblHench1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHench2
        '
        Me.lblHench2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHench2.Location = New System.Drawing.Point(383, 303)
        Me.lblHench2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHench2.Name = "lblHench2"
        Me.lblHench2.Size = New System.Drawing.Size(50, 25)
        Me.lblHench2.TabIndex = 25
        Me.lblHench2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHench3
        '
        Me.lblHench3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHench3.Location = New System.Drawing.Point(383, 327)
        Me.lblHench3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHench3.Name = "lblHench3"
        Me.lblHench3.Size = New System.Drawing.Size(50, 25)
        Me.lblHench3.TabIndex = 26
        Me.lblHench3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHench4
        '
        Me.lblHench4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHench4.Location = New System.Drawing.Point(383, 351)
        Me.lblHench4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHench4.Name = "lblHench4"
        Me.lblHench4.Size = New System.Drawing.Size(50, 25)
        Me.lblHench4.TabIndex = 27
        Me.lblHench4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHench5
        '
        Me.lblHench5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHench5.Location = New System.Drawing.Point(383, 375)
        Me.lblHench5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHench5.Name = "lblHench5"
        Me.lblHench5.Size = New System.Drawing.Size(50, 25)
        Me.lblHench5.TabIndex = 28
        Me.lblHench5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(244, 159)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(189, 25)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Guildmaster:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGuildmaster
        '
        Me.lblGuildmaster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGuildmaster.Location = New System.Drawing.Point(244, 183)
        Me.lblGuildmaster.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGuildmaster.Name = "lblGuildmaster"
        Me.lblGuildmaster.Size = New System.Drawing.Size(189, 25)
        Me.lblGuildmaster.TabIndex = 30
        Me.lblGuildmaster.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFee
        '
        Me.lblFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFee.Location = New System.Drawing.Point(363, 207)
        Me.lblFee.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFee.Name = "lblFee"
        Me.lblFee.Size = New System.Drawing.Size(70, 25)
        Me.lblFee.TabIndex = 34
        Me.lblFee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Location = New System.Drawing.Point(244, 207)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 25)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Entrance Fee:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmGuildList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnBack
        Me.ClientSize = New System.Drawing.Size(446, 409)
        Me.Controls.Add(Me.lblGuildmaster)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblHench5)
        Me.Controls.Add(Me.lblHench4)
        Me.Controls.Add(Me.lblHench3)
        Me.Controls.Add(Me.lblHench2)
        Me.Controls.Add(Me.lblHench1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblGuildGold)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblGoldOnHand)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.txtGuilds)
        Me.Controls.Add(Me.lstGuilds)
        Me.Controls.Add(Me.lblFee)
        Me.Controls.Add(Me.Label5)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(462, 447)
        Me.MinimumSize = New System.Drawing.Size(462, 447)
        Me.Name = "frmGuildList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Guild"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstGuilds As System.Windows.Forms.ListBox
    Friend WithEvents txtGuilds As System.Windows.Forms.TextBox
    Friend WithEvents btnEnter As System.Windows.Forms.Button
    Friend WithEvents btnApply As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents lblGoldOnHand As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblGuildGold As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblHench1 As System.Windows.Forms.Label
    Friend WithEvents lblHench2 As System.Windows.Forms.Label
    Friend WithEvents lblHench3 As System.Windows.Forms.Label
    Friend WithEvents lblHench4 As System.Windows.Forms.Label
    Friend WithEvents lblHench5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblGuildmaster As System.Windows.Forms.Label
    Friend WithEvents lblFee As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
