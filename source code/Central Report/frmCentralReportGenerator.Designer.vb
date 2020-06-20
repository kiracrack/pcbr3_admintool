<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCentralReportGenerator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCentralReportGenerator))
        Me.txtReportTemplate = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmdset = New System.Windows.Forms.Button()
        Me.ConnectionSetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckSystemDateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.date_to = New System.Windows.Forms.DateTimePicker()
        Me.date_from = New System.Windows.Forms.DateTimePicker()
        Me.lblasof = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblWarning = New System.Windows.Forms.Label()
        Me.id = New System.Windows.Forms.TextBox()
        Me.txtBranch = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.radConsolidated = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtReportTemplate
        '
        Me.txtReportTemplate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtReportTemplate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtReportTemplate.FormattingEnabled = True
        Me.txtReportTemplate.Location = New System.Drawing.Point(184, 64)
        Me.txtReportTemplate.MaxDropDownItems = 15
        Me.txtReportTemplate.Name = "txtReportTemplate"
        Me.txtReportTemplate.Size = New System.Drawing.Size(364, 23)
        Me.txtReportTemplate.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(50, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 15)
        Me.Label6.TabIndex = 410
        Me.Label6.Text = "Select Report Template"
        '
        'cmdset
        '
        Me.cmdset.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdset.Location = New System.Drawing.Point(247, 163)
        Me.cmdset.Name = "cmdset"
        Me.cmdset.Size = New System.Drawing.Size(218, 35)
        Me.cmdset.TabIndex = 411
        Me.cmdset.Text = "Generate Report"
        Me.cmdset.UseVisualStyleBackColor = True
        '
        'ConnectionSetupToolStripMenuItem
        '
        Me.ConnectionSetupToolStripMenuItem.Name = "ConnectionSetupToolStripMenuItem"
        Me.ConnectionSetupToolStripMenuItem.Size = New System.Drawing.Size(114, 20)
        Me.ConnectionSetupToolStripMenuItem.Text = "Connection Setup"
        '
        'CheckSystemDateToolStripMenuItem
        '
        Me.CheckSystemDateToolStripMenuItem.Name = "CheckSystemDateToolStripMenuItem"
        Me.CheckSystemDateToolStripMenuItem.Size = New System.Drawing.Size(120, 20)
        Me.CheckSystemDateToolStripMenuItem.Text = "Check System Date"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConnectionSetupToolStripMenuItem, Me.CheckSystemDateToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(572, 24)
        Me.MenuStrip1.TabIndex = 412
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'date_to
        '
        Me.date_to.CustomFormat = "MMMM dd, yyyy"
        Me.date_to.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.date_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.date_to.Location = New System.Drawing.Point(407, 109)
        Me.date_to.Name = "date_to"
        Me.date_to.Size = New System.Drawing.Size(141, 23)
        Me.date_to.TabIndex = 414
        '
        'date_from
        '
        Me.date_from.CustomFormat = "MMMM dd, yyyy"
        Me.date_from.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.date_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.date_from.Location = New System.Drawing.Point(247, 109)
        Me.date_from.Name = "date_from"
        Me.date_from.Size = New System.Drawing.Size(141, 23)
        Me.date_from.TabIndex = 413
        '
        'lblasof
        '
        Me.lblasof.AutoSize = True
        Me.lblasof.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblasof.Location = New System.Drawing.Point(181, 113)
        Me.lblasof.Name = "lblasof"
        Me.lblasof.Size = New System.Drawing.Size(60, 15)
        Me.lblasof.TabIndex = 415
        Me.lblasof.Text = "Date Filter"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(392, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(12, 15)
        Me.Label2.TabIndex = 416
        Me.Label2.Text = "-"
        '
        'lblWarning
        '
        Me.lblWarning.AutoSize = True
        Me.lblWarning.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblWarning.Location = New System.Drawing.Point(181, 90)
        Me.lblWarning.Name = "lblWarning"
        Me.lblWarning.Size = New System.Drawing.Size(164, 15)
        Me.lblWarning.TabIndex = 417
        Me.lblWarning.Text = "Please select date transaction."
        '
        'id
        '
        Me.id.Location = New System.Drawing.Point(377, 254)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(45, 23)
        Me.id.TabIndex = 418
        Me.id.Visible = False
        '
        'txtBranch
        '
        Me.txtBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtBranch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.txtBranch.FormattingEnabled = True
        Me.txtBranch.Items.AddRange(New Object() {"LIVE TRANSACTION DATABASE SETUP", "BACKUP DATABASE CONNECTION SETUP"})
        Me.txtBranch.Location = New System.Drawing.Point(184, 37)
        Me.txtBranch.Name = "txtBranch"
        Me.txtBranch.Size = New System.Drawing.Size(281, 23)
        Me.txtBranch.TabIndex = 419
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(75, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 15)
        Me.Label1.TabIndex = 420
        Me.Label1.Text = "Select Connection"
        '
        'radConsolidated
        '
        Me.radConsolidated.AutoSize = True
        Me.radConsolidated.Checked = True
        Me.radConsolidated.Location = New System.Drawing.Point(247, 138)
        Me.radConsolidated.Name = "radConsolidated"
        Me.radConsolidated.Size = New System.Drawing.Size(95, 19)
        Me.radConsolidated.TabIndex = 421
        Me.radConsolidated.TabStop = True
        Me.radConsolidated.Text = "Consolidated"
        Me.radConsolidated.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(348, 138)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(98, 19)
        Me.RadioButton2.TabIndex = 422
        Me.RadioButton2.Text = "Separated File"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'frmCentralReportGenerator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(572, 221)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.radConsolidated)
        Me.Controls.Add(Me.date_to)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBranch)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.lblWarning)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblasof)
        Me.Controls.Add(Me.date_from)
        Me.Controls.Add(Me.cmdset)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtReportTemplate)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmCentralReportGenerator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Centralized Report Generator"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtReportTemplate As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmdset As System.Windows.Forms.Button
    Friend WithEvents ConnectionSetupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheckSystemDateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents date_to As System.Windows.Forms.DateTimePicker
    Friend WithEvents date_from As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblasof As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblWarning As System.Windows.Forms.Label
    Friend WithEvents id As System.Windows.Forms.TextBox
    Friend WithEvents txtBranch As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents radConsolidated As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
End Class
