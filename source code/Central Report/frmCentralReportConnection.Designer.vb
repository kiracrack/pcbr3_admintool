<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCentralReportConnection
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCentralReportConnection))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ls = New System.Windows.Forms.CheckedListBox()
        Me.ckLive = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(6, 359)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(317, 33)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Save Connection"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ls
        '
        Me.ls.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ls.CheckOnClick = True
        Me.ls.FormattingEnabled = True
        Me.ls.Location = New System.Drawing.Point(6, 7)
        Me.ls.Name = "ls"
        Me.ls.Size = New System.Drawing.Size(317, 349)
        Me.ls.TabIndex = 11
        '
        'ckLive
        '
        Me.ckLive.AutoSize = True
        Me.ckLive.Location = New System.Drawing.Point(111, 245)
        Me.ckLive.Name = "ckLive"
        Me.ckLive.Size = New System.Drawing.Size(81, 17)
        Me.ckLive.TabIndex = 12
        Me.ckLive.Text = "CheckBox1"
        Me.ckLive.UseVisualStyleBackColor = True
        Me.ckLive.Visible = False
        '
        'frmCentralReportConnection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 398)
        Me.Controls.Add(Me.ckLive)
        Me.Controls.Add(Me.ls)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCentralReportConnection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report Connection Setup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ls As System.Windows.Forms.CheckedListBox
    Friend WithEvents ckLive As System.Windows.Forms.CheckBox

End Class
