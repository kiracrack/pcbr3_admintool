<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMBOTagging
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMBOTagging))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMBOName = New System.Windows.Forms.ComboBox()
        Me.cms_em = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddNewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtBranchcode = New System.Windows.Forms.TextBox()
        Me.cms_em.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(42, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 21)
        Me.Label1.TabIndex = 398
        Me.Label1.Text = "Select MBO Name"
        '
        'txtMBOName
        '
        Me.txtMBOName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtMBOName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtMBOName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtMBOName.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtMBOName.FormattingEnabled = True
        Me.txtMBOName.Location = New System.Drawing.Point(44, 36)
        Me.txtMBOName.Name = "txtMBOName"
        Me.txtMBOName.Size = New System.Drawing.Size(290, 29)
        Me.txtMBOName.TabIndex = 0
        '
        'cms_em
        '
        Me.cms_em.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewToolStripMenuItem})
        Me.cms_em.Name = "ContextMenuStrip1"
        Me.cms_em.Size = New System.Drawing.Size(118, 26)
        '
        'AddNewToolStripMenuItem
        '
        Me.AddNewToolStripMenuItem.Image = Global.AdminTool.My.Resources.Resources.building__minus
        Me.AddNewToolStripMenuItem.Name = "AddNewToolStripMenuItem"
        Me.AddNewToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.AddNewToolStripMenuItem.Text = "Remove"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(225, 69)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 30)
        Me.Button1.TabIndex = 399
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtBranchcode
        '
        Me.txtBranchcode.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtBranchcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBranchcode.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtBranchcode.ForeColor = System.Drawing.Color.Black
        Me.txtBranchcode.Location = New System.Drawing.Point(278, 156)
        Me.txtBranchcode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBranchcode.Name = "txtBranchcode"
        Me.txtBranchcode.Size = New System.Drawing.Size(110, 22)
        Me.txtBranchcode.TabIndex = 400
        Me.txtBranchcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmMBOTagging
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 121)
        Me.Controls.Add(Me.txtBranchcode)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtMBOName)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMBOTagging"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MBO Client Tagging"
        Me.cms_em.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMBOName As ComboBox
    Friend WithEvents cms_em As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AddNewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtBranchcode As System.Windows.Forms.TextBox
End Class
