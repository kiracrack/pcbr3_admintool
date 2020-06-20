<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMBOChangeCenter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMBOChangeCenter))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCenter = New System.Windows.Forms.ComboBox()
        Me.cms_em = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddNewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.groupkey = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAccountOfficer = New System.Windows.Forms.TextBox()
        Me.txtGroup = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.centerkey = New System.Windows.Forms.TextBox()
        Me.refno = New System.Windows.Forms.TextBox()
        Me.txtCurrentCenterKey = New System.Windows.Forms.TextBox()
        Me.cms_em.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(82, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 21)
        Me.Label1.TabIndex = 398
        Me.Label1.Text = "Change Center"
        '
        'txtCenter
        '
        Me.txtCenter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtCenter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtCenter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtCenter.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtCenter.FormattingEnabled = True
        Me.txtCenter.Location = New System.Drawing.Point(202, 25)
        Me.txtCenter.Name = "txtCenter"
        Me.txtCenter.Size = New System.Drawing.Size(288, 29)
        Me.txtCenter.TabIndex = 0
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
        Me.Button1.Location = New System.Drawing.Point(381, 124)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 30)
        Me.Button1.TabIndex = 399
        Me.Button1.Text = "Confirm"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'groupkey
        '
        Me.groupkey.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.groupkey.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.groupkey.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.groupkey.ForeColor = System.Drawing.Color.Black
        Me.groupkey.Location = New System.Drawing.Point(344, 302)
        Me.groupkey.Margin = New System.Windows.Forms.Padding(4)
        Me.groupkey.Name = "groupkey"
        Me.groupkey.Size = New System.Drawing.Size(76, 22)
        Me.groupkey.TabIndex = 400
        Me.groupkey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(74, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 21)
        Me.Label4.TabIndex = 406
        Me.Label4.Text = "Officer Incharge"
        '
        'txtAccountOfficer
        '
        Me.txtAccountOfficer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAccountOfficer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAccountOfficer.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtAccountOfficer.ForeColor = System.Drawing.Color.Black
        Me.txtAccountOfficer.Location = New System.Drawing.Point(202, 91)
        Me.txtAccountOfficer.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAccountOfficer.Name = "txtAccountOfficer"
        Me.txtAccountOfficer.Size = New System.Drawing.Size(288, 29)
        Me.txtAccountOfficer.TabIndex = 405
        Me.txtAccountOfficer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtGroup
        '
        Me.txtGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtGroup.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtGroup.FormattingEnabled = True
        Me.txtGroup.Location = New System.Drawing.Point(202, 58)
        Me.txtGroup.Name = "txtGroup"
        Me.txtGroup.Size = New System.Drawing.Size(288, 29)
        Me.txtGroup.TabIndex = 407
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(96, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 21)
        Me.Label5.TabIndex = 408
        Me.Label5.Text = "Select Group"
        '
        'centerkey
        '
        Me.centerkey.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.centerkey.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.centerkey.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.centerkey.ForeColor = System.Drawing.Color.Black
        Me.centerkey.Location = New System.Drawing.Point(428, 302)
        Me.centerkey.Margin = New System.Windows.Forms.Padding(4)
        Me.centerkey.Name = "centerkey"
        Me.centerkey.Size = New System.Drawing.Size(76, 22)
        Me.centerkey.TabIndex = 409
        Me.centerkey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'refno
        '
        Me.refno.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.refno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.refno.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.refno.ForeColor = System.Drawing.Color.Black
        Me.refno.Location = New System.Drawing.Point(260, 302)
        Me.refno.Margin = New System.Windows.Forms.Padding(4)
        Me.refno.Name = "refno"
        Me.refno.Size = New System.Drawing.Size(76, 22)
        Me.refno.TabIndex = 410
        Me.refno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCurrentCenterKey
        '
        Me.txtCurrentCenterKey.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCurrentCenterKey.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCurrentCenterKey.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtCurrentCenterKey.ForeColor = System.Drawing.Color.Black
        Me.txtCurrentCenterKey.Location = New System.Drawing.Point(176, 302)
        Me.txtCurrentCenterKey.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCurrentCenterKey.Name = "txtCurrentCenterKey"
        Me.txtCurrentCenterKey.Size = New System.Drawing.Size(76, 22)
        Me.txtCurrentCenterKey.TabIndex = 411
        Me.txtCurrentCenterKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmMBOChangeCenter
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 175)
        Me.Controls.Add(Me.txtCurrentCenterKey)
        Me.Controls.Add(Me.refno)
        Me.Controls.Add(Me.centerkey)
        Me.Controls.Add(Me.txtGroup)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtAccountOfficer)
        Me.Controls.Add(Me.groupkey)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtCenter)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMBOChangeCenter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MBO Client Tagging"
        Me.cms_em.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCenter As ComboBox
    Friend WithEvents cms_em As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AddNewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents groupkey As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtAccountOfficer As System.Windows.Forms.TextBox
    Friend WithEvents txtGroup As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents centerkey As System.Windows.Forms.TextBox
    Friend WithEvents refno As System.Windows.Forms.TextBox
    Friend WithEvents txtCurrentCenterKey As System.Windows.Forms.TextBox
End Class
