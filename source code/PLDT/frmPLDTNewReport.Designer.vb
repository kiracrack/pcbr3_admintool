<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPLDTNewReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPLDTNewReport))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.mode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtOfficeName = New System.Windows.Forms.TextBox()
        Me.officeid = New System.Windows.Forms.TextBox()
        Me.txtIssue = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtIncedentNumber = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDateDown = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTimeDown = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(142, 170)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 33)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Done"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'mode
        '
        Me.mode.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.mode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.mode.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.mode.ForeColor = System.Drawing.Color.Black
        Me.mode.Location = New System.Drawing.Point(11, 410)
        Me.mode.Margin = New System.Windows.Forms.Padding(4)
        Me.mode.Name = "mode"
        Me.mode.ReadOnly = True
        Me.mode.Size = New System.Drawing.Size(56, 22)
        Me.mode.TabIndex = 395
        Me.mode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mode.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(61, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 15)
        Me.Label1.TabIndex = 398
        Me.Label1.Text = "Office Name"
        '
        'txtOfficeName
        '
        Me.txtOfficeName.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtOfficeName.ForeColor = System.Drawing.Color.Black
        Me.txtOfficeName.Location = New System.Drawing.Point(142, 18)
        Me.txtOfficeName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOfficeName.Name = "txtOfficeName"
        Me.txtOfficeName.ReadOnly = True
        Me.txtOfficeName.Size = New System.Drawing.Size(211, 22)
        Me.txtOfficeName.TabIndex = 100
        '
        'officeid
        '
        Me.officeid.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.officeid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.officeid.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.officeid.ForeColor = System.Drawing.Color.Black
        Me.officeid.Location = New System.Drawing.Point(70, 410)
        Me.officeid.Margin = New System.Windows.Forms.Padding(4)
        Me.officeid.Name = "officeid"
        Me.officeid.ReadOnly = True
        Me.officeid.Size = New System.Drawing.Size(56, 22)
        Me.officeid.TabIndex = 412
        Me.officeid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.officeid.Visible = False
        '
        'txtIssue
        '
        Me.txtIssue.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtIssue.ForeColor = System.Drawing.Color.Black
        Me.txtIssue.Location = New System.Drawing.Point(142, 44)
        Me.txtIssue.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIssue.Multiline = True
        Me.txtIssue.Name = "txtIssue"
        Me.txtIssue.Size = New System.Drawing.Size(327, 42)
        Me.txtIssue.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(102, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 15)
        Me.Label3.TabIndex = 418
        Me.Label3.Text = "Issue"
        '
        'txtIncedentNumber
        '
        Me.txtIncedentNumber.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtIncedentNumber.ForeColor = System.Drawing.Color.Black
        Me.txtIncedentNumber.Location = New System.Drawing.Point(142, 90)
        Me.txtIncedentNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIncedentNumber.Name = "txtIncedentNumber"
        Me.txtIncedentNumber.Size = New System.Drawing.Size(211, 22)
        Me.txtIncedentNumber.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(28, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 15)
        Me.Label4.TabIndex = 420
        Me.Label4.Text = "Incendent Number"
        '
        'txtDateDown
        '
        Me.txtDateDown.CustomFormat = "MMMM dd, yyyy"
        Me.txtDateDown.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDateDown.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDateDown.Location = New System.Drawing.Point(142, 116)
        Me.txtDateDown.Name = "txtDateDown"
        Me.txtDateDown.Size = New System.Drawing.Size(211, 23)
        Me.txtDateDown.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(70, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 15)
        Me.Label2.TabIndex = 421
        Me.Label2.Text = "Date Down"
        '
        'txtTimeDown
        '
        Me.txtTimeDown.CustomFormat = "MMMM dd, yyyy"
        Me.txtTimeDown.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtTimeDown.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.txtTimeDown.Location = New System.Drawing.Point(142, 143)
        Me.txtTimeDown.Name = "txtTimeDown"
        Me.txtTimeDown.Size = New System.Drawing.Size(140, 23)
        Me.txtTimeDown.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(67, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 15)
        Me.Label5.TabIndex = 423
        Me.Label5.Text = "TIme Down"
        '
        'frmPLDTNewReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 214)
        Me.Controls.Add(Me.txtTimeDown)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDateDown)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtIncedentNumber)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtIssue)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.officeid)
        Me.Controls.Add(Me.txtOfficeName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmPLDTNewReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report to PLDT"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents mode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtOfficeName As System.Windows.Forms.TextBox
    Friend WithEvents officeid As System.Windows.Forms.TextBox
    Friend WithEvents txtIssue As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtIncedentNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDateDown As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTimeDown As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
