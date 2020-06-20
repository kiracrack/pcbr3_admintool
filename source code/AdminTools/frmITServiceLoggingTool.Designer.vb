<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmITServiceLoggingTool
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmITServiceLoggingTool))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtClient = New System.Windows.Forms.ComboBox()
        Me.txtBranch = New System.Windows.Forms.ComboBox()
        Me.txtSolveby = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtConcern = New System.Windows.Forms.ComboBox()
        Me.ckPending = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTechnical = New System.Windows.Forms.ComboBox()
        Me.txtDateTarget = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.rad5 = New System.Windows.Forms.RadioButton()
        Me.rad1 = New System.Windows.Forms.RadioButton()
        Me.rad2 = New System.Windows.Forms.RadioButton()
        Me.rad3 = New System.Windows.Forms.RadioButton()
        Me.rad4 = New System.Windows.Forms.RadioButton()
        Me.txtTicketNumber = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtAction = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(160, 357)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(153, 33)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(110, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 15)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Branch"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(81, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 15)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Client Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(87, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 15)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Select Issue"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(157, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(220, 15)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Action Taken or Remarks of the problem"
        '
        'txtClient
        '
        Me.txtClient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtClient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtClient.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtClient.FormattingEnabled = True
        Me.txtClient.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.txtClient.Location = New System.Drawing.Point(160, 37)
        Me.txtClient.Name = "txtClient"
        Me.txtClient.Size = New System.Drawing.Size(272, 23)
        Me.txtClient.TabIndex = 1
        '
        'txtBranch
        '
        Me.txtBranch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtBranch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtBranch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBranch.FormattingEnabled = True
        Me.txtBranch.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.txtBranch.Location = New System.Drawing.Point(160, 12)
        Me.txtBranch.Name = "txtBranch"
        Me.txtBranch.Size = New System.Drawing.Size(178, 23)
        Me.txtBranch.TabIndex = 0
        '
        'txtSolveby
        '
        Me.txtSolveby.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtSolveby.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtSolveby.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSolveby.FormattingEnabled = True
        Me.txtSolveby.Location = New System.Drawing.Point(160, 332)
        Me.txtSolveby.Name = "txtSolveby"
        Me.txtSolveby.Size = New System.Drawing.Size(215, 23)
        Me.txtSolveby.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(94, 336)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 15)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Record by"
        '
        'txtConcern
        '
        Me.txtConcern.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtConcern.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtConcern.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtConcern.FormattingEnabled = True
        Me.txtConcern.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.txtConcern.Location = New System.Drawing.Point(160, 62)
        Me.txtConcern.Name = "txtConcern"
        Me.txtConcern.Size = New System.Drawing.Size(373, 23)
        Me.txtConcern.TabIndex = 2
        '
        'ckPending
        '
        Me.ckPending.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ckPending.AutoSize = True
        Me.ckPending.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ckPending.ForeColor = System.Drawing.Color.Black
        Me.ckPending.Location = New System.Drawing.Point(160, 235)
        Me.ckPending.Name = "ckPending"
        Me.ckPending.Size = New System.Drawing.Size(99, 19)
        Me.ckPending.TabIndex = 376
        Me.ckPending.Text = "Pending Issue"
        Me.ckPending.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(51, 282)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 15)
        Me.Label6.TabIndex = 378
        Me.Label6.Text = "Technical Support"
        '
        'txtTechnical
        '
        Me.txtTechnical.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTechnical.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtTechnical.Enabled = False
        Me.txtTechnical.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtTechnical.FormattingEnabled = True
        Me.txtTechnical.Location = New System.Drawing.Point(160, 279)
        Me.txtTechnical.Name = "txtTechnical"
        Me.txtTechnical.Size = New System.Drawing.Size(215, 23)
        Me.txtTechnical.TabIndex = 377
        '
        'txtDateTarget
        '
        Me.txtDateTarget.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtDateTarget.CustomFormat = "MMMM dd, yyyy"
        Me.txtDateTarget.Enabled = False
        Me.txtDateTarget.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDateTarget.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDateTarget.Location = New System.Drawing.Point(160, 306)
        Me.txtDateTarget.Name = "txtDateTarget"
        Me.txtDateTarget.Size = New System.Drawing.Size(215, 23)
        Me.txtDateTarget.TabIndex = 379
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label7.Location = New System.Drawing.Point(86, 310)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 15)
        Me.Label7.TabIndex = 380
        Me.Label7.Text = "Date Target"
        '
        'rad5
        '
        Me.rad5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rad5.AutoSize = True
        Me.rad5.Location = New System.Drawing.Point(432, 212)
        Me.rad5.Name = "rad5"
        Me.rad5.Size = New System.Drawing.Size(56, 17)
        Me.rad5.TabIndex = 381
        Me.rad5.Text = "Critical"
        Me.rad5.UseVisualStyleBackColor = True
        '
        'rad1
        '
        Me.rad1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rad1.AutoSize = True
        Me.rad1.Location = New System.Drawing.Point(160, 212)
        Me.rad1.Name = "rad1"
        Me.rad1.Size = New System.Drawing.Size(91, 17)
        Me.rad1.TabIndex = 382
        Me.rad1.Text = "Enhancement"
        Me.rad1.UseVisualStyleBackColor = True
        '
        'rad2
        '
        Me.rad2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rad2.AutoSize = True
        Me.rad2.Location = New System.Drawing.Point(255, 212)
        Me.rad2.Name = "rad2"
        Me.rad2.Size = New System.Drawing.Size(51, 17)
        Me.rad2.TabIndex = 383
        Me.rad2.Text = "Minor"
        Me.rad2.UseVisualStyleBackColor = True
        '
        'rad3
        '
        Me.rad3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rad3.AutoSize = True
        Me.rad3.Checked = True
        Me.rad3.Location = New System.Drawing.Point(312, 212)
        Me.rad3.Name = "rad3"
        Me.rad3.Size = New System.Drawing.Size(58, 17)
        Me.rad3.TabIndex = 384
        Me.rad3.TabStop = True
        Me.rad3.Text = "Normal"
        Me.rad3.UseVisualStyleBackColor = True
        '
        'rad4
        '
        Me.rad4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rad4.AutoSize = True
        Me.rad4.Location = New System.Drawing.Point(376, 212)
        Me.rad4.Name = "rad4"
        Me.rad4.Size = New System.Drawing.Size(51, 17)
        Me.rad4.TabIndex = 385
        Me.rad4.Text = "Major"
        Me.rad4.UseVisualStyleBackColor = True
        '
        'txtTicketNumber
        '
        Me.txtTicketNumber.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTicketNumber.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTicketNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTicketNumber.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtTicketNumber.ForeColor = System.Drawing.Color.Black
        Me.txtTicketNumber.Location = New System.Drawing.Point(160, 254)
        Me.txtTicketNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTicketNumber.Name = "txtTicketNumber"
        Me.txtTicketNumber.ReadOnly = True
        Me.txtTicketNumber.Size = New System.Drawing.Size(112, 22)
        Me.txtTicketNumber.TabIndex = 386
        Me.txtTicketNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label8.Location = New System.Drawing.Point(68, 259)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 15)
        Me.Label8.TabIndex = 387
        Me.Label8.Text = "Ticket Number"
        '
        'txtAction
        '
        Me.txtAction.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAction.Location = New System.Drawing.Point(160, 108)
        Me.txtAction.Name = "txtAction"
        Me.txtAction.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.txtAction.Size = New System.Drawing.Size(373, 98)
        Me.txtAction.TabIndex = 388
        Me.txtAction.Text = ""
        '
        'frmITServiceLoggingTool
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 399)
        Me.Controls.Add(Me.txtAction)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtTicketNumber)
        Me.Controls.Add(Me.rad4)
        Me.Controls.Add(Me.rad3)
        Me.Controls.Add(Me.rad2)
        Me.Controls.Add(Me.rad1)
        Me.Controls.Add(Me.rad5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtDateTarget)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTechnical)
        Me.Controls.Add(Me.ckPending)
        Me.Controls.Add(Me.txtConcern)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSolveby)
        Me.Controls.Add(Me.txtBranch)
        Me.Controls.Add(Me.txtClient)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmITServiceLoggingTool"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Technical Report"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtClient As System.Windows.Forms.ComboBox
    Friend WithEvents txtBranch As System.Windows.Forms.ComboBox
    Friend WithEvents txtSolveby As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtConcern As System.Windows.Forms.ComboBox
    Friend WithEvents ckPending As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTechnical As System.Windows.Forms.ComboBox
    Friend WithEvents txtDateTarget As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents rad5 As System.Windows.Forms.RadioButton
    Friend WithEvents rad1 As System.Windows.Forms.RadioButton
    Friend WithEvents rad2 As System.Windows.Forms.RadioButton
    Friend WithEvents rad3 As System.Windows.Forms.RadioButton
    Friend WithEvents rad4 As System.Windows.Forms.RadioButton
    Friend WithEvents txtTicketNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtAction As System.Windows.Forms.RichTextBox

End Class
