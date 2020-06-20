<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmITicketUpdate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmITicketUpdate))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtStatus = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtResolution = New System.Windows.Forms.TextBox()
        Me.ticketid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPriority = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCategory = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCause = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDateReport = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtResolvedBy = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(284, 314)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(178, 38)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Confirm"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(66, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 15)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Status"
        '
        'txtStatus
        '
        Me.txtStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtStatus.FormattingEnabled = True
        Me.txtStatus.Items.AddRange(New Object() {"Pending", "Closed", "Cancelled"})
        Me.txtStatus.Location = New System.Drawing.Point(113, 66)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(233, 23)
        Me.txtStatus.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(42, 175)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 15)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Resolution"
        '
        'txtResolution
        '
        Me.txtResolution.BackColor = System.Drawing.SystemColors.Window
        Me.txtResolution.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtResolution.Location = New System.Drawing.Point(113, 171)
        Me.txtResolution.Margin = New System.Windows.Forms.Padding(5)
        Me.txtResolution.Multiline = True
        Me.txtResolution.Name = "txtResolution"
        Me.txtResolution.Size = New System.Drawing.Size(349, 112)
        Me.txtResolution.TabIndex = 1
        '
        'ticketid
        '
        Me.ticketid.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ticketid.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ticketid.ForeColor = System.Drawing.Color.Black
        Me.ticketid.Location = New System.Drawing.Point(113, 15)
        Me.ticketid.Margin = New System.Windows.Forms.Padding(5)
        Me.ticketid.Name = "ticketid"
        Me.ticketid.ReadOnly = True
        Me.ticketid.Size = New System.Drawing.Size(150, 22)
        Me.ticketid.TabIndex = 19
        Me.ticketid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(52, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 15)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Ticket ID"
        '
        'txtPriority
        '
        Me.txtPriority.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtPriority.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtPriority.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPriority.FormattingEnabled = True
        Me.txtPriority.Items.AddRange(New Object() {"High", "Critical", "Medium", "Low"})
        Me.txtPriority.Location = New System.Drawing.Point(113, 92)
        Me.txtPriority.Name = "txtPriority"
        Me.txtPriority.Size = New System.Drawing.Size(349, 23)
        Me.txtPriority.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(60, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 15)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Priority"
        '
        'txtCategory
        '
        Me.txtCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtCategory.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCategory.FormattingEnabled = True
        Me.txtCategory.Location = New System.Drawing.Point(113, 118)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(349, 23)
        Me.txtCategory.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(50, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 15)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Category"
        '
        'txtCause
        '
        Me.txtCause.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtCause.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtCause.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtCause.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCause.FormattingEnabled = True
        Me.txtCause.Location = New System.Drawing.Point(113, 144)
        Me.txtCause.Name = "txtCause"
        Me.txtCause.Size = New System.Drawing.Size(349, 23)
        Me.txtCause.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(66, 148)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 15)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Cause"
        '
        'txtDateReport
        '
        Me.txtDateReport.Enabled = False
        Me.txtDateReport.Location = New System.Drawing.Point(113, 40)
        Me.txtDateReport.Name = "txtDateReport"
        Me.txtDateReport.Size = New System.Drawing.Size(233, 23)
        Me.txtDateReport.TabIndex = 27
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label7.Location = New System.Drawing.Point(23, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 15)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Reported Date"
        '
        'txtResolvedBy
        '
        Me.txtResolvedBy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtResolvedBy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtResolvedBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtResolvedBy.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtResolvedBy.FormattingEnabled = True
        Me.txtResolvedBy.Items.AddRange(New Object() {"High", "Critical", "Medium", "Low"})
        Me.txtResolvedBy.Location = New System.Drawing.Point(284, 288)
        Me.txtResolvedBy.Name = "txtResolvedBy"
        Me.txtResolvedBy.Size = New System.Drawing.Size(178, 23)
        Me.txtResolvedBy.TabIndex = 29
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label8.Location = New System.Drawing.Point(208, 291)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 15)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Resolved By"
        '
        'frmITicketUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 359)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtResolvedBy)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtDateReport)
        Me.Controls.Add(Me.txtCause)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCategory)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPriority)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ticketid)
        Me.Controls.Add(Me.txtResolution)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtStatus)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmITicketUpdate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update ITicket"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtResolution As System.Windows.Forms.TextBox
    Friend WithEvents ticketid As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPriority As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCategory As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCause As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDateReport As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtResolvedBy As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label

End Class
