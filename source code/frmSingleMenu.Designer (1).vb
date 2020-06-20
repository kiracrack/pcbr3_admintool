<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSingleMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSingleMenu))
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Imagemenu = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.txtServer = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.AllowDrop = True
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(751, 377)
        Me.ListView1.TabIndex = 346
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Imagemenu
        '
        Me.Imagemenu.ImageStream = CType(resources.GetObject("Imagemenu.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Imagemenu.TransparentColor = System.Drawing.Color.Transparent
        Me.Imagemenu.Images.SetKeyName(0, "Task list.png")
        Me.Imagemenu.Images.SetKeyName(1, "document_delete_48.png")
        Me.Imagemenu.Images.SetKeyName(2, "view-right-close.png")
        Me.Imagemenu.Images.SetKeyName(3, "preferences-contact-list.png")
        Me.Imagemenu.Images.SetKeyName(4, "Paper-x.png")
        Me.Imagemenu.Images.SetKeyName(5, "system-users-4.png")
        Me.Imagemenu.Images.SetKeyName(6, "documentation2.png")
        Me.Imagemenu.Images.SetKeyName(7, "osmo.png")
        Me.Imagemenu.Images.SetKeyName(8, "user3.png")
        Me.Imagemenu.Images.SetKeyName(9, "Period end.png")
        Me.Imagemenu.Images.SetKeyName(10, "kmines-4.png")
        Me.Imagemenu.Images.SetKeyName(11, "edit-find-4.png")
        Me.Imagemenu.Images.SetKeyName(12, "edit-copy-4.png")
        Me.Imagemenu.Images.SetKeyName(13, "Password protection.png")
        Me.Imagemenu.Images.SetKeyName(14, "window-suppressed.png")
        Me.Imagemenu.Images.SetKeyName(15, "Emergency off.png")
        Me.Imagemenu.Images.SetKeyName(16, "users_two_add_48.png")
        Me.Imagemenu.Images.SetKeyName(17, "search (5).png")
        Me.Imagemenu.Images.SetKeyName(18, "computer-search.png")
        Me.Imagemenu.Images.SetKeyName(19, "document-save-as-3.png")
        Me.Imagemenu.Images.SetKeyName(20, "Calendar.png")
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "conduit-2.png")
        Me.ImageList1.Images.SetKeyName(1, "computer (3).png")
        Me.ImageList1.Images.SetKeyName(2, "Company.png")
        Me.ImageList1.Images.SetKeyName(3, "Report.png")
        '
        'Timer2
        '
        Me.Timer2.Interval = 10000
        '
        'Timer3
        '
        Me.Timer3.Enabled = True
        Me.Timer3.Interval = 10000
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtServer, Me.txtDate})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 377)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(751, 22)
        Me.StatusStrip1.TabIndex = 410
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'txtServer
        '
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(120, 17)
        Me.txtServer.Text = "ToolStripStatusLabel1"
        '
        'txtDate
        '
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(120, 17)
        Me.txtDate.Text = "ToolStripStatusLabel2"
        '
        'frmSingleMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(751, 399)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(767, 438)
        Me.Name = "frmSingleMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PCBR3 support utility tool by IT Department"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Imagemenu As System.Windows.Forms.ImageList
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Public WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents txtServer As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtDate As System.Windows.Forms.ToolStripStatusLabel

End Class
