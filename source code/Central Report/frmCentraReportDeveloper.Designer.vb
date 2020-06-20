<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCentraReportDeveloper
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCentraReportDeveloper))
        Me.cmdset = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtReportQuery = New System.Windows.Forms.TextBox()
        Me.CheckEdit1 = New System.Windows.Forms.CheckBox()
        Me.txtReportTitle = New System.Windows.Forms.TextBox()
        Me.ckAsOf = New System.Windows.Forms.CheckBox()
        Me.id = New System.Windows.Forms.TextBox()
        Me.mode = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ConnectionSetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckSystemDateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UploadTemplateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdset
        '
        Me.cmdset.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdset.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdset.Location = New System.Drawing.Point(643, 355)
        Me.cmdset.Name = "cmdset"
        Me.cmdset.Size = New System.Drawing.Size(187, 30)
        Me.cmdset.TabIndex = 5
        Me.cmdset.Text = "Save Report Template"
        Me.cmdset.UseVisualStyleBackColor = True
        '
        'txtReportQuery
        '
        Me.txtReportQuery.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtReportQuery.BackColor = System.Drawing.SystemColors.Window
        Me.txtReportQuery.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReportQuery.ForeColor = System.Drawing.Color.Maroon
        Me.txtReportQuery.Location = New System.Drawing.Point(11, 60)
        Me.txtReportQuery.Margin = New System.Windows.Forms.Padding(4)
        Me.txtReportQuery.Multiline = True
        Me.txtReportQuery.Name = "txtReportQuery"
        Me.txtReportQuery.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtReportQuery.Size = New System.Drawing.Size(819, 288)
        Me.txtReportQuery.TabIndex = 368
        Me.txtReportQuery.Text = "Paste your mysql query here.."
        '
        'CheckEdit1
        '
        Me.CheckEdit1.AutoSize = True
        Me.CheckEdit1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckEdit1.Location = New System.Drawing.Point(534, 36)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Size = New System.Drawing.Size(79, 17)
        Me.CheckEdit1.TabIndex = 370
        Me.CheckEdit1.Text = "Date Filter"
        Me.CheckEdit1.UseVisualStyleBackColor = True
        '
        'txtReportTitle
        '
        Me.txtReportTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtReportTitle.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtReportTitle.ForeColor = System.Drawing.Color.Gray
        Me.txtReportTitle.Location = New System.Drawing.Point(11, 33)
        Me.txtReportTitle.Margin = New System.Windows.Forms.Padding(4)
        Me.txtReportTitle.Name = "txtReportTitle"
        Me.txtReportTitle.Size = New System.Drawing.Size(516, 22)
        Me.txtReportTitle.TabIndex = 371
        Me.txtReportTitle.Text = "Report title.."
        '
        'ckAsOf
        '
        Me.ckAsOf.AutoSize = True
        Me.ckAsOf.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckAsOf.Location = New System.Drawing.Point(618, 36)
        Me.ckAsOf.Name = "ckAsOf"
        Me.ckAsOf.Size = New System.Drawing.Size(81, 17)
        Me.ckAsOf.TabIndex = 373
        Me.ckAsOf.Text = "As of Filter"
        Me.ckAsOf.UseVisualStyleBackColor = True
        '
        'id
        '
        Me.id.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.id.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.id.ForeColor = System.Drawing.Color.Gray
        Me.id.Location = New System.Drawing.Point(26, 344)
        Me.id.Margin = New System.Windows.Forms.Padding(4)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(70, 22)
        Me.id.TabIndex = 374
        Me.id.Visible = False
        '
        'mode
        '
        Me.mode.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.mode.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.mode.ForeColor = System.Drawing.Color.Gray
        Me.mode.Location = New System.Drawing.Point(104, 347)
        Me.mode.Margin = New System.Windows.Forms.Padding(4)
        Me.mode.Name = "mode"
        Me.mode.Size = New System.Drawing.Size(70, 22)
        Me.mode.TabIndex = 375
        Me.mode.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConnectionSetupToolStripMenuItem, Me.CheckSystemDateToolStripMenuItem, Me.UploadTemplateToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(838, 24)
        Me.MenuStrip1.TabIndex = 413
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ConnectionSetupToolStripMenuItem
        '
        Me.ConnectionSetupToolStripMenuItem.Name = "ConnectionSetupToolStripMenuItem"
        Me.ConnectionSetupToolStripMenuItem.Size = New System.Drawing.Size(106, 20)
        Me.ConnectionSetupToolStripMenuItem.Text = "Report Template"
        '
        'CheckSystemDateToolStripMenuItem
        '
        Me.CheckSystemDateToolStripMenuItem.Name = "CheckSystemDateToolStripMenuItem"
        Me.CheckSystemDateToolStripMenuItem.Size = New System.Drawing.Size(107, 20)
        Me.CheckSystemDateToolStripMenuItem.Text = "Import Template"
        '
        'UploadTemplateToolStripMenuItem
        '
        Me.UploadTemplateToolStripMenuItem.Name = "UploadTemplateToolStripMenuItem"
        Me.UploadTemplateToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.UploadTemplateToolStripMenuItem.Text = "Help"
        '
        'frmCentraReportDeveloper
        '
        Me.AcceptButton = Me.cmdset
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(838, 393)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.ckAsOf)
        Me.Controls.Add(Me.txtReportTitle)
        Me.Controls.Add(Me.CheckEdit1)
        Me.Controls.Add(Me.txtReportQuery)
        Me.Controls.Add(Me.cmdset)
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCentraReportDeveloper"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report Template"
        Me.TopMost = True
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdset As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents txtReportQuery As System.Windows.Forms.TextBox
    Friend WithEvents CheckEdit1 As System.Windows.Forms.CheckBox
    Friend WithEvents txtReportTitle As System.Windows.Forms.TextBox
    Friend WithEvents ckAsOf As System.Windows.Forms.CheckBox
    Friend WithEvents id As System.Windows.Forms.TextBox
    Friend WithEvents mode As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ConnectionSetupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheckSystemDateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UploadTemplateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
