<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMBOSavingFIlter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMBOSavingFIlter))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ls = New System.Windows.Forms.CheckedListBox()
        Me.cms_em = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditChapterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewTransactionDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cms_em.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Button1.Location = New System.Drawing.Point(10, 374)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(308, 33)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Filter"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ls
        '
        Me.ls.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ls.CheckOnClick = True
        Me.ls.FormattingEnabled = True
        Me.ls.Location = New System.Drawing.Point(10, 4)
        Me.ls.Name = "ls"
        Me.ls.Size = New System.Drawing.Size(308, 364)
        Me.ls.TabIndex = 10
        '
        'cms_em
        '
        Me.cms_em.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditChapterToolStripMenuItem, Me.ViewTransactionDetailsToolStripMenuItem})
        Me.cms_em.Name = "ContextMenuStrip1"
        Me.cms_em.Size = New System.Drawing.Size(165, 48)
        '
        'EditChapterToolStripMenuItem
        '
        Me.EditChapterToolStripMenuItem.Image = Global.AdminTool.My.Resources.Resources.document_excel_table
        Me.EditChapterToolStripMenuItem.Name = "EditChapterToolStripMenuItem"
        Me.EditChapterToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.EditChapterToolStripMenuItem.Text = "Export to Excel"
        '
        'ViewTransactionDetailsToolStripMenuItem
        '
        Me.ViewTransactionDetailsToolStripMenuItem.Image = Global.AdminTool.My.Resources.Resources._101
        Me.ViewTransactionDetailsToolStripMenuItem.Name = "ViewTransactionDetailsToolStripMenuItem"
        Me.ViewTransactionDetailsToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.ViewTransactionDetailsToolStripMenuItem.Text = "Remove Selected"
        '
        'frmMBOSavingFIlter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 410)
        Me.Controls.Add(Me.ls)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(346, 445)
        Me.Name = "frmMBOSavingFIlter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Filter Settings"
        Me.cms_em.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ls As System.Windows.Forms.CheckedListBox
    Friend WithEvents cms_em As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditChapterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewTransactionDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
