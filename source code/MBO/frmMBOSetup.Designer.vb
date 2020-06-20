<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMBOSetup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMBOSetup))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtMBOName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBranch = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMBOCode = New System.Windows.Forms.TextBox()
        Me.ckMicro = New System.Windows.Forms.CheckBox()
        Me.ckRegular = New System.Windows.Forms.CheckBox()
        Me.MyDataGridView = New System.Windows.Forms.DataGridView()
        Me.cms_em = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddNewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_em.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(167, 107)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(143, 33)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtMBOName
        '
        Me.txtMBOName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMBOName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMBOName.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtMBOName.ForeColor = System.Drawing.Color.Black
        Me.txtMBOName.Location = New System.Drawing.Point(167, 60)
        Me.txtMBOName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMBOName.Name = "txtMBOName"
        Me.txtMBOName.Size = New System.Drawing.Size(214, 22)
        Me.txtMBOName.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(91, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 15)
        Me.Label2.TabIndex = 390
        Me.Label2.Text = "MBO Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(82, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 15)
        Me.Label1.TabIndex = 398
        Me.Label1.Text = "Select Branch"
        '
        'txtBranch
        '
        Me.txtBranch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtBranch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtBranch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBranch.FormattingEnabled = True
        Me.txtBranch.Location = New System.Drawing.Point(167, 9)
        Me.txtBranch.Name = "txtBranch"
        Me.txtBranch.Size = New System.Drawing.Size(214, 23)
        Me.txtBranch.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(55, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 15)
        Me.Label3.TabIndex = 414
        Me.Label3.Text = "MBO Branch Code"
        '
        'txtMBOCode
        '
        Me.txtMBOCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMBOCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMBOCode.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtMBOCode.ForeColor = System.Drawing.Color.Black
        Me.txtMBOCode.Location = New System.Drawing.Point(167, 35)
        Me.txtMBOCode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMBOCode.Name = "txtMBOCode"
        Me.txtMBOCode.Size = New System.Drawing.Size(110, 22)
        Me.txtMBOCode.TabIndex = 1
        Me.txtMBOCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ckMicro
        '
        Me.ckMicro.AutoSize = True
        Me.ckMicro.Location = New System.Drawing.Point(167, 86)
        Me.ckMicro.Name = "ckMicro"
        Me.ckMicro.Size = New System.Drawing.Size(88, 17)
        Me.ckMicro.TabIndex = 3
        Me.ckMicro.Text = "Micro Client"
        Me.ckMicro.UseVisualStyleBackColor = True
        '
        'ckRegular
        '
        Me.ckRegular.AutoSize = True
        Me.ckRegular.Location = New System.Drawing.Point(273, 86)
        Me.ckRegular.Name = "ckRegular"
        Me.ckRegular.Size = New System.Drawing.Size(99, 17)
        Me.ckRegular.TabIndex = 4
        Me.ckRegular.Text = "Regular Client"
        Me.ckRegular.UseVisualStyleBackColor = True
        '
        'MyDataGridView
        '
        Me.MyDataGridView.AllowUserToAddRows = False
        Me.MyDataGridView.AllowUserToDeleteRows = False
        Me.MyDataGridView.AllowUserToResizeColumns = False
        Me.MyDataGridView.AllowUserToResizeRows = False
        Me.MyDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MyDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.MyDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.MyDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.MyDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MyDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.MyDataGridView.ContextMenuStrip = Me.cms_em
        Me.MyDataGridView.Location = New System.Drawing.Point(10, 148)
        Me.MyDataGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.MyDataGridView.MultiSelect = False
        Me.MyDataGridView.Name = "MyDataGridView"
        Me.MyDataGridView.ReadOnly = True
        Me.MyDataGridView.RowHeadersVisible = False
        Me.MyDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.MyDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.MyDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MyDataGridView.Size = New System.Drawing.Size(474, 184)
        Me.MyDataGridView.TabIndex = 417
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
        'frmMBOSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 339)
        Me.Controls.Add(Me.MyDataGridView)
        Me.Controls.Add(Me.ckRegular)
        Me.Controls.Add(Me.ckMicro)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtMBOCode)
        Me.Controls.Add(Me.txtBranch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMBOName)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMBOSetup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MBO Setup"
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_em.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtMBOName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBranch As ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtMBOCode As System.Windows.Forms.TextBox
    Friend WithEvents ckMicro As System.Windows.Forms.CheckBox
    Friend WithEvents ckRegular As System.Windows.Forms.CheckBox
    Friend WithEvents MyDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents cms_em As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AddNewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
