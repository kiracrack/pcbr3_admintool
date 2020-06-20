<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGenAppLive
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGenAppLive))
        Me.MyDataGridView = New System.Windows.Forms.DataGridView()
        Me.cms_em = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.UpdateTicketToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClearlogToolToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SavingsUnlockerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LOanUnlockerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.POPUnlockerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientUnlockerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeUserAccessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdjustmentRemoverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaymentRemoverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChargesRemoverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditChapterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_em.SuspendLayout()
        Me.SuspendLayout()
        '
        'MyDataGridView
        '
        Me.MyDataGridView.AllowUserToAddRows = False
        Me.MyDataGridView.AllowUserToDeleteRows = False
        Me.MyDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MyDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.MyDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.MyDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.MyDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MyDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MyDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.MyDataGridView.ColumnHeadersHeight = 40
        Me.MyDataGridView.ContextMenuStrip = Me.cms_em
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MyDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.MyDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyDataGridView.Location = New System.Drawing.Point(11, 11)
        Me.MyDataGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.MyDataGridView.Name = "MyDataGridView"
        Me.MyDataGridView.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MyDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.MyDataGridView.RowHeadersVisible = False
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial Narrow", 15.75!)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.MyDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.MyDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MyDataGridView.Size = New System.Drawing.Size(968, 456)
        Me.MyDataGridView.TabIndex = 373
        '
        'cms_em
        '
        Me.cms_em.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateTicketToolStripMenuItem, Me.ToolStripSeparator3, Me.ClearlogToolToolStripMenuItem, Me.SavingsUnlockerToolStripMenuItem, Me.LOanUnlockerToolStripMenuItem, Me.POPUnlockerToolStripMenuItem, Me.ClientUnlockerToolStripMenuItem, Me.ChangeUserAccessToolStripMenuItem, Me.AdjustmentRemoverToolStripMenuItem, Me.PaymentRemoverToolStripMenuItem, Me.ChargesRemoverToolStripMenuItem, Me.ToolStripMenuItem1, Me.ToolStripSeparator1, Me.RefreshListToolStripMenuItem, Me.EditChapterToolStripMenuItem})
        Me.cms_em.Name = "ContextMenuStrip1"
        Me.cms_em.Size = New System.Drawing.Size(187, 324)
        '
        'UpdateTicketToolStripMenuItem
        '
        Me.UpdateTicketToolStripMenuItem.Image = Global.AdminTool.My.Resources.Resources.tick1
        Me.UpdateTicketToolStripMenuItem.Name = "UpdateTicketToolStripMenuItem"
        Me.UpdateTicketToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.UpdateTicketToolStripMenuItem.Text = "Update Ticket"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(183, 6)
        '
        'ClearlogToolToolStripMenuItem
        '
        Me.ClearlogToolToolStripMenuItem.Image = Global.AdminTool.My.Resources.Resources.users
        Me.ClearlogToolToolStripMenuItem.Name = "ClearlogToolToolStripMenuItem"
        Me.ClearlogToolToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.ClearlogToolToolStripMenuItem.Text = "User ClearLog Tool"
        '
        'SavingsUnlockerToolStripMenuItem
        '
        Me.SavingsUnlockerToolStripMenuItem.Image = Global.AdminTool.My.Resources.Resources.safe
        Me.SavingsUnlockerToolStripMenuItem.Name = "SavingsUnlockerToolStripMenuItem"
        Me.SavingsUnlockerToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.SavingsUnlockerToolStripMenuItem.Text = "Savings Unlocker"
        '
        'LOanUnlockerToolStripMenuItem
        '
        Me.LOanUnlockerToolStripMenuItem.Image = Global.AdminTool.My.Resources.Resources._179
        Me.LOanUnlockerToolStripMenuItem.Name = "LOanUnlockerToolStripMenuItem"
        Me.LOanUnlockerToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.LOanUnlockerToolStripMenuItem.Text = "Loan Unlocker"
        '
        'POPUnlockerToolStripMenuItem
        '
        Me.POPUnlockerToolStripMenuItem.Image = Global.AdminTool.My.Resources.Resources.User_Program_Group
        Me.POPUnlockerToolStripMenuItem.Name = "POPUnlockerToolStripMenuItem"
        Me.POPUnlockerToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.POPUnlockerToolStripMenuItem.Text = "POP Unlocker"
        '
        'ClientUnlockerToolStripMenuItem
        '
        Me.ClientUnlockerToolStripMenuItem.Image = Global.AdminTool.My.Resources.Resources.user
        Me.ClientUnlockerToolStripMenuItem.Name = "ClientUnlockerToolStripMenuItem"
        Me.ClientUnlockerToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.ClientUnlockerToolStripMenuItem.Text = "Client Unlocker"
        '
        'ChangeUserAccessToolStripMenuItem
        '
        Me.ChangeUserAccessToolStripMenuItem.Image = Global.AdminTool.My.Resources.Resources._063
        Me.ChangeUserAccessToolStripMenuItem.Name = "ChangeUserAccessToolStripMenuItem"
        Me.ChangeUserAccessToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.ChangeUserAccessToolStripMenuItem.Text = "Change User Access"
        '
        'AdjustmentRemoverToolStripMenuItem
        '
        Me.AdjustmentRemoverToolStripMenuItem.Image = Global.AdminTool.My.Resources.Resources.blog__minus
        Me.AdjustmentRemoverToolStripMenuItem.Name = "AdjustmentRemoverToolStripMenuItem"
        Me.AdjustmentRemoverToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.AdjustmentRemoverToolStripMenuItem.Text = "Adjustment Remover"
        '
        'PaymentRemoverToolStripMenuItem
        '
        Me.PaymentRemoverToolStripMenuItem.Image = Global.AdminTool.My.Resources.Resources.calculator__minus
        Me.PaymentRemoverToolStripMenuItem.Name = "PaymentRemoverToolStripMenuItem"
        Me.PaymentRemoverToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.PaymentRemoverToolStripMenuItem.Text = "Payment Remover"
        '
        'ChargesRemoverToolStripMenuItem
        '
        Me.ChargesRemoverToolStripMenuItem.Image = Global.AdminTool.My.Resources.Resources.notebook__minus
        Me.ChargesRemoverToolStripMenuItem.Name = "ChargesRemoverToolStripMenuItem"
        Me.ChargesRemoverToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.ChargesRemoverToolStripMenuItem.Text = "Charges Remover"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(183, 6)
        '
        'RefreshListToolStripMenuItem
        '
        Me.RefreshListToolStripMenuItem.Image = Global.AdminTool.My.Resources.Resources.arrow_continue_090_left
        Me.RefreshListToolStripMenuItem.Name = "RefreshListToolStripMenuItem"
        Me.RefreshListToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.RefreshListToolStripMenuItem.Text = "Refresh Ticket List"
        '
        'EditChapterToolStripMenuItem
        '
        Me.EditChapterToolStripMenuItem.Image = Global.AdminTool.My.Resources.Resources._101
        Me.EditChapterToolStripMenuItem.Name = "EditChapterToolStripMenuItem"
        Me.EditChapterToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.EditChapterToolStripMenuItem.Text = "Close Window"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 15000
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = Global.AdminTool.My.Resources.Resources.user__plus
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(186, 22)
        Me.ToolStripMenuItem1.Text = "User Accounts"
        '
        'frmGenAppLive
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(990, 478)
        Me.Controls.Add(Me.MyDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(346, 445)
        Me.Name = "frmGenAppLive"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ticket Live"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_em.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MyDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents cms_em As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditChapterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearlogToolToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LOanUnlockerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SavingsUnlockerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientUnlockerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents POPUnlockerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdjustmentRemoverToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PaymentRemoverToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeUserAccessToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChargesRemoverToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UpdateTicketToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem

End Class
