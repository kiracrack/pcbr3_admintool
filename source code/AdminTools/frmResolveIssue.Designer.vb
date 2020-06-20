<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResolveIssue
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmResolveIssue))
        Me.cmdset = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.id = New System.Windows.Forms.TextBox()
        Me.txtRevise = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDateTarget = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTechnical = New System.Windows.Forms.ComboBox()
        Me.rad4 = New System.Windows.Forms.RadioButton()
        Me.rad3 = New System.Windows.Forms.RadioButton()
        Me.rad2 = New System.Windows.Forms.RadioButton()
        Me.rad1 = New System.Windows.Forms.RadioButton()
        Me.rad5 = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdset
        '
        Me.cmdset.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdset.Location = New System.Drawing.Point(281, 382)
        Me.cmdset.Name = "cmdset"
        Me.cmdset.Size = New System.Drawing.Size(187, 30)
        Me.cmdset.TabIndex = 5
        Me.cmdset.Text = "Confirm Service"
        Me.cmdset.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(10, 263)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 15)
        Me.Label4.TabIndex = 366
        Me.Label4.Text = "Resolve remarks"
        '
        'txtRemarks
        '
        Me.txtRemarks.BackColor = System.Drawing.SystemColors.Window
        Me.txtRemarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.txtRemarks.ForeColor = System.Drawing.Color.DimGray
        Me.txtRemarks.Location = New System.Drawing.Point(13, 282)
        Me.txtRemarks.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(455, 93)
        Me.txtRemarks.TabIndex = 3
        '
        'id
        '
        Me.id.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.id.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.id.ForeColor = System.Drawing.Color.Gray
        Me.id.Location = New System.Drawing.Point(13, 216)
        Me.id.Margin = New System.Windows.Forms.Padding(4)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(58, 22)
        Me.id.TabIndex = 367
        Me.id.Visible = False
        '
        'txtRevise
        '
        Me.txtRevise.BackColor = System.Drawing.SystemColors.Window
        Me.txtRevise.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.txtRevise.ForeColor = System.Drawing.Color.DimGray
        Me.txtRevise.Location = New System.Drawing.Point(13, 27)
        Me.txtRevise.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRevise.Multiline = True
        Me.txtRevise.Name = "txtRevise"
        Me.txtRevise.Size = New System.Drawing.Size(455, 151)
        Me.txtRevise.TabIndex = 368
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(10, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 15)
        Me.Label1.TabIndex = 369
        Me.Label1.Text = "Revise the problem"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(13, 382)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(140, 17)
        Me.CheckBox1.TabIndex = 370
        Me.CheckBox1.Text = "Mark as Resolved Issue"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label7.Location = New System.Drawing.Point(179, 235)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 15)
        Me.Label7.TabIndex = 384
        Me.Label7.Text = "Date Target"
        '
        'txtDateTarget
        '
        Me.txtDateTarget.CustomFormat = "MMMM dd, yyyy"
        Me.txtDateTarget.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDateTarget.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDateTarget.Location = New System.Drawing.Point(253, 231)
        Me.txtDateTarget.Name = "txtDateTarget"
        Me.txtDateTarget.Size = New System.Drawing.Size(215, 23)
        Me.txtDateTarget.TabIndex = 383
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(100, 207)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(146, 15)
        Me.Label6.TabIndex = 382
        Me.Label6.Text = "Change Technical Support"
        '
        'txtTechnical
        '
        Me.txtTechnical.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtTechnical.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtTechnical.FormattingEnabled = True
        Me.txtTechnical.Location = New System.Drawing.Point(253, 204)
        Me.txtTechnical.Name = "txtTechnical"
        Me.txtTechnical.Size = New System.Drawing.Size(215, 23)
        Me.txtTechnical.TabIndex = 381
        '
        'rad4
        '
        Me.rad4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rad4.AutoSize = True
        Me.rad4.Location = New System.Drawing.Point(357, 182)
        Me.rad4.Name = "rad4"
        Me.rad4.Size = New System.Drawing.Size(51, 17)
        Me.rad4.TabIndex = 390
        Me.rad4.Text = "Major"
        Me.rad4.UseVisualStyleBackColor = True
        '
        'rad3
        '
        Me.rad3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rad3.AutoSize = True
        Me.rad3.Checked = True
        Me.rad3.Location = New System.Drawing.Point(293, 182)
        Me.rad3.Name = "rad3"
        Me.rad3.Size = New System.Drawing.Size(58, 17)
        Me.rad3.TabIndex = 389
        Me.rad3.TabStop = True
        Me.rad3.Text = "Normal"
        Me.rad3.UseVisualStyleBackColor = True
        '
        'rad2
        '
        Me.rad2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rad2.AutoSize = True
        Me.rad2.Location = New System.Drawing.Point(236, 182)
        Me.rad2.Name = "rad2"
        Me.rad2.Size = New System.Drawing.Size(51, 17)
        Me.rad2.TabIndex = 388
        Me.rad2.Text = "Minor"
        Me.rad2.UseVisualStyleBackColor = True
        '
        'rad1
        '
        Me.rad1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rad1.AutoSize = True
        Me.rad1.Location = New System.Drawing.Point(141, 182)
        Me.rad1.Name = "rad1"
        Me.rad1.Size = New System.Drawing.Size(91, 17)
        Me.rad1.TabIndex = 387
        Me.rad1.Text = "Enhancement"
        Me.rad1.UseVisualStyleBackColor = True
        '
        'rad5
        '
        Me.rad5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rad5.AutoSize = True
        Me.rad5.Location = New System.Drawing.Point(413, 182)
        Me.rad5.Name = "rad5"
        Me.rad5.Size = New System.Drawing.Size(56, 17)
        Me.rad5.TabIndex = 386
        Me.rad5.Text = "Critical"
        Me.rad5.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(13, 182)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 15)
        Me.Label2.TabIndex = 391
        Me.Label2.Text = "Change Severity Level"
        '
        'frmResolveIssue
        '
        Me.AcceptButton = Me.cmdset
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(481, 421)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.rad4)
        Me.Controls.Add(Me.rad3)
        Me.Controls.Add(Me.rad2)
        Me.Controls.Add(Me.rad1)
        Me.Controls.Add(Me.rad5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtDateTarget)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTechnical)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.txtRevise)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmdset)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmResolveIssue"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Resolve Issue"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdset As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents id As System.Windows.Forms.TextBox
    Friend WithEvents txtRevise As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtDateTarget As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTechnical As System.Windows.Forms.ComboBox
    Friend WithEvents rad4 As System.Windows.Forms.RadioButton
    Friend WithEvents rad3 As System.Windows.Forms.RadioButton
    Friend WithEvents rad2 As System.Windows.Forms.RadioButton
    Friend WithEvents rad1 As System.Windows.Forms.RadioButton
    Friend WithEvents rad5 As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
