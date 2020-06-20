<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainMenu))
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Imagemenu = New System.Windows.Forms.ImageList(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabAdminTool = New System.Windows.Forms.TabPage()
        Me.tabCentral = New System.Windows.Forms.TabPage()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.tabPldt = New System.Windows.Forms.TabPage()
        Me.ListView3 = New System.Windows.Forms.ListView()
        Me.tabMBO = New System.Windows.Forms.TabPage()
        Me.ListView4 = New System.Windows.Forms.ListView()
        Me.lblServer = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.imageReportCentral = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.cmdClose = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.txtServer = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdPending = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdNewReport = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdServiceReport = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdSummaryReport = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdChangePassword = New System.Windows.Forms.ToolStripButton()
        Me.TabControl1.SuspendLayout()
        Me.tabAdminTool.SuspendLayout()
        Me.tabCentral.SuspendLayout()
        Me.tabPldt.SuspendLayout()
        Me.tabMBO.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.AllowDrop = True
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(3, 3)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(781, 372)
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
        Me.Imagemenu.Images.SetKeyName(21, "help (4).png")
        Me.Imagemenu.Images.SetKeyName(22, "Search.png")
        Me.Imagemenu.Images.SetKeyName(23, "money - dollar.png")
        Me.Imagemenu.Images.SetKeyName(24, "image_48.png")
        Me.Imagemenu.Images.SetKeyName(25, "Printer.png")
        Me.Imagemenu.Images.SetKeyName(26, "epiphany-bookmarks.png")
        Me.Imagemenu.Images.SetKeyName(27, "Alert.png")
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tabAdminTool)
        Me.TabControl1.Controls.Add(Me.tabCentral)
        Me.TabControl1.Controls.Add(Me.tabPldt)
        Me.TabControl1.Controls.Add(Me.tabMBO)
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TabControl1.Location = New System.Drawing.Point(6, 44)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(795, 406)
        Me.TabControl1.TabIndex = 380
        '
        'tabAdminTool
        '
        Me.tabAdminTool.Controls.Add(Me.ListView1)
        Me.tabAdminTool.Location = New System.Drawing.Point(4, 24)
        Me.tabAdminTool.Name = "tabAdminTool"
        Me.tabAdminTool.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAdminTool.Size = New System.Drawing.Size(787, 378)
        Me.tabAdminTool.TabIndex = 0
        Me.tabAdminTool.Text = "PCBR3 Admin Tool"
        Me.tabAdminTool.UseVisualStyleBackColor = True
        '
        'tabCentral
        '
        Me.tabCentral.Controls.Add(Me.ListView2)
        Me.tabCentral.Location = New System.Drawing.Point(4, 24)
        Me.tabCentral.Name = "tabCentral"
        Me.tabCentral.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCentral.Size = New System.Drawing.Size(787, 378)
        Me.tabCentral.TabIndex = 1
        Me.tabCentral.Text = "Central Reports Tool"
        Me.tabCentral.UseVisualStyleBackColor = True
        '
        'ListView2
        '
        Me.ListView2.AllowDrop = True
        Me.ListView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ListView2.GridLines = True
        Me.ListView2.Location = New System.Drawing.Point(3, 3)
        Me.ListView2.MultiSelect = False
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(781, 372)
        Me.ListView2.TabIndex = 347
        Me.ListView2.UseCompatibleStateImageBehavior = False
        '
        'tabPldt
        '
        Me.tabPldt.Controls.Add(Me.ListView3)
        Me.tabPldt.Location = New System.Drawing.Point(4, 24)
        Me.tabPldt.Name = "tabPldt"
        Me.tabPldt.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPldt.Size = New System.Drawing.Size(787, 378)
        Me.tabPldt.TabIndex = 2
        Me.tabPldt.Text = "PLDT Report"
        Me.tabPldt.UseVisualStyleBackColor = True
        '
        'ListView3
        '
        Me.ListView3.AllowDrop = True
        Me.ListView3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ListView3.GridLines = True
        Me.ListView3.Location = New System.Drawing.Point(3, 3)
        Me.ListView3.MultiSelect = False
        Me.ListView3.Name = "ListView3"
        Me.ListView3.Size = New System.Drawing.Size(781, 372)
        Me.ListView3.TabIndex = 348
        Me.ListView3.UseCompatibleStateImageBehavior = False
        '
        'tabMBO
        '
        Me.tabMBO.Controls.Add(Me.ListView4)
        Me.tabMBO.Location = New System.Drawing.Point(4, 24)
        Me.tabMBO.Name = "tabMBO"
        Me.tabMBO.Padding = New System.Windows.Forms.Padding(3)
        Me.tabMBO.Size = New System.Drawing.Size(787, 378)
        Me.tabMBO.TabIndex = 3
        Me.tabMBO.Text = "MBO Separation Tool"
        Me.tabMBO.UseVisualStyleBackColor = True
        '
        'ListView4
        '
        Me.ListView4.AllowDrop = True
        Me.ListView4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ListView4.GridLines = True
        Me.ListView4.Location = New System.Drawing.Point(3, 3)
        Me.ListView4.MultiSelect = False
        Me.ListView4.Name = "ListView4"
        Me.ListView4.Size = New System.Drawing.Size(781, 372)
        Me.ListView4.TabIndex = 349
        Me.ListView4.UseCompatibleStateImageBehavior = False
        '
        'lblServer
        '
        Me.lblServer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblServer.AutoSize = True
        Me.lblServer.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblServer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblServer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblServer.Location = New System.Drawing.Point(3, 452)
        Me.lblServer.Name = "lblServer"
        Me.lblServer.Size = New System.Drawing.Size(0, 15)
        Me.lblServer.TabIndex = 408
        Me.lblServer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblUser
        '
        Me.lblUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUser.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblUser.Location = New System.Drawing.Point(475, 452)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(326, 15)
        Me.lblUser.TabIndex = 409
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.ImageList1.Images.SetKeyName(4, "User group.png")
        Me.ImageList1.Images.SetKeyName(5, "openterm.png")
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
        'imageReportCentral
        '
        Me.imageReportCentral.ImageStream = CType(resources.GetObject("imageReportCentral.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageReportCentral.TransparentColor = System.Drawing.Color.Transparent
        Me.imageReportCentral.Images.SetKeyName(0, "network-wireless.png")
        Me.imageReportCentral.Images.SetKeyName(1, "media-flash-smart-media.png")
        Me.imageReportCentral.Images.SetKeyName(2, "Paste.png")
        Me.imageReportCentral.Images.SetKeyName(3, "document-print-3.png")
        Me.imageReportCentral.Images.SetKeyName(4, "document-save-3.png")
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.SkyBlue
        Me.ToolStrip1.BackgroundImage = Global.AdminTool.My.Resources.Resources.bg
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdClose, Me.ToolStripSeparator6, Me.txtServer, Me.ToolStripSeparator5, Me.cmdPending, Me.ToolStripSeparator2, Me.cmdNewReport, Me.ToolStripSeparator1, Me.cmdServiceReport, Me.ToolStripSeparator3, Me.cmdSummaryReport, Me.ToolStripSeparator4, Me.cmdChangePassword})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(10, 2, 1, 2)
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(805, 35)
        Me.ToolStrip1.TabIndex = 407
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'cmdClose
        '
        Me.cmdClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdClose.ForeColor = System.Drawing.Color.White
        Me.cmdClose.Image = Global.AdminTool.My.Resources.Resources._101
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(23, 28)
        Me.cmdClose.Text = "Refresh"
        Me.cmdClose.ToolTipText = "View Updates"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 31)
        '
        'txtServer
        '
        Me.txtServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtServer.DropDownWidth = 180
        Me.txtServer.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(180, 31)
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 31)
        '
        'cmdPending
        '
        Me.cmdPending.ForeColor = System.Drawing.Color.White
        Me.cmdPending.Image = Global.AdminTool.My.Resources.Resources.exclamation_red_frame
        Me.cmdPending.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdPending.Name = "cmdPending"
        Me.cmdPending.Size = New System.Drawing.Size(71, 28)
        Me.cmdPending.Text = "Pending"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'cmdNewReport
        '
        Me.cmdNewReport.ForeColor = System.Drawing.Color.White
        Me.cmdNewReport.Image = Global.AdminTool.My.Resources.Resources.user__plus
        Me.cmdNewReport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdNewReport.Name = "cmdNewReport"
        Me.cmdNewReport.Size = New System.Drawing.Size(89, 28)
        Me.cmdNewReport.Text = "New Report"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'cmdServiceReport
        '
        Me.cmdServiceReport.ForeColor = System.Drawing.Color.White
        Me.cmdServiceReport.Image = Global.AdminTool.My.Resources.Resources.notebook
        Me.cmdServiceReport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdServiceReport.Name = "cmdServiceReport"
        Me.cmdServiceReport.Size = New System.Drawing.Size(102, 28)
        Me.cmdServiceReport.Text = "Service Report"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 31)
        '
        'cmdSummaryReport
        '
        Me.cmdSummaryReport.ForeColor = System.Drawing.Color.White
        Me.cmdSummaryReport.Image = Global.AdminTool.My.Resources.Resources.Printer__2_
        Me.cmdSummaryReport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSummaryReport.Name = "cmdSummaryReport"
        Me.cmdSummaryReport.Size = New System.Drawing.Size(116, 28)
        Me.cmdSummaryReport.Text = "Summary Report"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 31)
        '
        'cmdChangePassword
        '
        Me.cmdChangePassword.ForeColor = System.Drawing.Color.White
        Me.cmdChangePassword.Image = Global.AdminTool.My.Resources.Resources.lock1
        Me.cmdChangePassword.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdChangePassword.Name = "cmdChangePassword"
        Me.cmdChangePassword.Size = New System.Drawing.Size(121, 28)
        Me.cmdChangePassword.Text = "Change Password"
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 472)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.lblServer)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(767, 438)
        Me.Name = "frmMainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IT Support Tool by Winter Bugahod"
        Me.TabControl1.ResumeLayout(False)
        Me.tabAdminTool.ResumeLayout(False)
        Me.tabCentral.ResumeLayout(False)
        Me.tabPldt.ResumeLayout(False)
        Me.tabMBO.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Imagemenu As System.Windows.Forms.ImageList
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabAdminTool As System.Windows.Forms.TabPage
    Friend WithEvents tabCentral As System.Windows.Forms.TabPage
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdPending As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdServiceReport As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdNewReport As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdSummaryReport As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdChangePassword As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblServer As System.Windows.Forms.Label
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents tabPldt As System.Windows.Forms.TabPage
    Friend WithEvents ListView3 As System.Windows.Forms.ListView
    Public WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents tabMBO As System.Windows.Forms.TabPage
    Friend WithEvents ListView4 As System.Windows.Forms.ListView
    Friend WithEvents txtServer As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents imageReportCentral As System.Windows.Forms.ImageList

End Class
