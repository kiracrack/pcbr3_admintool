<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserAccessUpdate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUserAccessUpdate))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtResolution = New System.Windows.Forms.TextBox()
        Me.ticketid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtResolvedBy = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(283, 183)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(178, 38)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Confirm"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(53, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 15)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Remarks"
        '
        'txtResolution
        '
        Me.txtResolution.BackColor = System.Drawing.SystemColors.Window
        Me.txtResolution.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtResolution.Location = New System.Drawing.Point(112, 40)
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
        Me.ticketid.Location = New System.Drawing.Point(113, 14)
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
        Me.Label2.Location = New System.Drawing.Point(34, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 15)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Ref Number"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label8.Location = New System.Drawing.Point(207, 160)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 15)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Executed By"
        '
        'txtResolvedBy
        '
        Me.txtResolvedBy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtResolvedBy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtResolvedBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtResolvedBy.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtResolvedBy.FormattingEnabled = True
        Me.txtResolvedBy.Items.AddRange(New Object() {"High", "Critical", "Medium", "Low"})
        Me.txtResolvedBy.Location = New System.Drawing.Point(283, 157)
        Me.txtResolvedBy.Name = "txtResolvedBy"
        Me.txtResolvedBy.Size = New System.Drawing.Size(178, 23)
        Me.txtResolvedBy.TabIndex = 31
        '
        'frmUserAccessUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 229)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtResolvedBy)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ticketid)
        Me.Controls.Add(Me.txtResolution)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmUserAccessUpdate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update User Access"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtResolution As System.Windows.Forms.TextBox
    Friend WithEvents ticketid As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtResolvedBy As System.Windows.Forms.ComboBox

End Class
