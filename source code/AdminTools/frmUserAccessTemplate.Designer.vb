<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserAccessTemplate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUserAccessTemplate))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtTemplate = New System.Windows.Forms.TextBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.cms_em = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditChapterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewTransactionDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtUserAccess = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSuppervisoryLoans = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtProductTemplate = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDepositOveride = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cms_em.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(111, 135)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(230, 33)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Save Template"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtTemplate
        '
        Me.txtTemplate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTemplate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTemplate.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtTemplate.ForeColor = System.Drawing.Color.Gray
        Me.txtTemplate.Location = New System.Drawing.Point(112, 14)
        Me.txtTemplate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTemplate.Name = "txtTemplate"
        Me.txtTemplate.Size = New System.Drawing.Size(131, 22)
        Me.txtTemplate.TabIndex = 0
        Me.txtTemplate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ListView1
        '
        Me.ListView1.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.ListView1.CheckBoxes = True
        Me.ListView1.ContextMenuStrip = Me.cms_em
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.Location = New System.Drawing.Point(346, 5)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(495, 330)
        Me.ListView1.TabIndex = 384
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'cms_em
        '
        Me.cms_em.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditChapterToolStripMenuItem, Me.ViewTransactionDetailsToolStripMenuItem})
        Me.cms_em.Name = "ContextMenuStrip1"
        Me.cms_em.Size = New System.Drawing.Size(207, 48)
        '
        'EditChapterToolStripMenuItem
        '
        Me.EditChapterToolStripMenuItem.Image = Global.AdminTool.My.Resources.Resources.document_excel_table
        Me.EditChapterToolStripMenuItem.Name = "EditChapterToolStripMenuItem"
        Me.EditChapterToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.EditChapterToolStripMenuItem.Text = "Export to Excel"
        '
        'ViewTransactionDetailsToolStripMenuItem
        '
        Me.ViewTransactionDetailsToolStripMenuItem.Image = Global.AdminTool.My.Resources.Resources._101
        Me.ViewTransactionDetailsToolStripMenuItem.Name = "ViewTransactionDetailsToolStripMenuItem"
        Me.ViewTransactionDetailsToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.ViewTransactionDetailsToolStripMenuItem.Text = "Delete Selected Template"
        '
        'txtUserAccess
        '
        Me.txtUserAccess.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtUserAccess.FormattingEnabled = True
        Me.txtUserAccess.Location = New System.Drawing.Point(112, 40)
        Me.txtUserAccess.Name = "txtUserAccess"
        Me.txtUserAccess.Size = New System.Drawing.Size(228, 21)
        Me.txtUserAccess.TabIndex = 386
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 385
        Me.Label1.Text = "Template Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 385
        Me.Label2.Text = "User Access"
        '
        'txtSuppervisoryLoans
        '
        Me.txtSuppervisoryLoans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtSuppervisoryLoans.FormattingEnabled = True
        Me.txtSuppervisoryLoans.Location = New System.Drawing.Point(112, 64)
        Me.txtSuppervisoryLoans.Name = "txtSuppervisoryLoans"
        Me.txtSuppervisoryLoans.Size = New System.Drawing.Size(228, 21)
        Me.txtSuppervisoryLoans.TabIndex = 388
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 387
        Me.Label3.Text = "Supervisory Loans"
        '
        'txtProductTemplate
        '
        Me.txtProductTemplate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtProductTemplate.FormattingEnabled = True
        Me.txtProductTemplate.Location = New System.Drawing.Point(112, 88)
        Me.txtProductTemplate.Name = "txtProductTemplate"
        Me.txtProductTemplate.Size = New System.Drawing.Size(228, 21)
        Me.txtProductTemplate.TabIndex = 390
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 389
        Me.Label4.Text = "Product Template"
        '
        'txtDepositOveride
        '
        Me.txtDepositOveride.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtDepositOveride.FormattingEnabled = True
        Me.txtDepositOveride.Location = New System.Drawing.Point(112, 112)
        Me.txtDepositOveride.Name = "txtDepositOveride"
        Me.txtDepositOveride.Size = New System.Drawing.Size(228, 21)
        Me.txtDepositOveride.TabIndex = 392
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 391
        Me.Label5.Text = "Deposit Override"
        '
        'frmUserAccessTemplate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(847, 339)
        Me.Controls.Add(Me.txtDepositOveride)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtProductTemplate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSuppervisoryLoans)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtUserAccess)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.txtTemplate)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmUserAccessTemplate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Access Template"
        Me.cms_em.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtTemplate As System.Windows.Forms.TextBox
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents txtUserAccess As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSuppervisoryLoans As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtProductTemplate As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDepositOveride As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cms_em As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditChapterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewTransactionDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
