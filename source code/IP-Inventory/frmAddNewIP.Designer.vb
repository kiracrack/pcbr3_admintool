<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddNewIP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddNewIP))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtIP1 = New System.Windows.Forms.TextBox()
        Me.officeid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIP2 = New System.Windows.Forms.TextBox()
        Me.txtIP3 = New System.Windows.Forms.TextBox()
        Me.txtIP4 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIPLast = New System.Windows.Forms.TextBox()
        Me.txtOfficeName = New System.Windows.Forms.TextBox()
        Me.mode = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(222, 72)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(142, 33)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(20, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 15)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Enter Office Name"
        '
        'txtIP1
        '
        Me.txtIP1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtIP1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIP1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtIP1.ForeColor = System.Drawing.Color.Black
        Me.txtIP1.Location = New System.Drawing.Point(130, 45)
        Me.txtIP1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIP1.Name = "txtIP1"
        Me.txtIP1.Size = New System.Drawing.Size(43, 22)
        Me.txtIP1.TabIndex = 2
        Me.txtIP1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'officeid
        '
        Me.officeid.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.officeid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.officeid.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.officeid.ForeColor = System.Drawing.Color.Black
        Me.officeid.Location = New System.Drawing.Point(66, 133)
        Me.officeid.Margin = New System.Windows.Forms.Padding(4)
        Me.officeid.Name = "officeid"
        Me.officeid.ReadOnly = True
        Me.officeid.Size = New System.Drawing.Size(56, 22)
        Me.officeid.TabIndex = 389
        Me.officeid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.officeid.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(71, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 15)
        Me.Label2.TabIndex = 390
        Me.Label2.Text = "IP Range"
        '
        'txtIP2
        '
        Me.txtIP2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtIP2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIP2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtIP2.ForeColor = System.Drawing.Color.Black
        Me.txtIP2.Location = New System.Drawing.Point(176, 45)
        Me.txtIP2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIP2.Name = "txtIP2"
        Me.txtIP2.Size = New System.Drawing.Size(43, 22)
        Me.txtIP2.TabIndex = 3
        Me.txtIP2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtIP3
        '
        Me.txtIP3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtIP3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIP3.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtIP3.ForeColor = System.Drawing.Color.Black
        Me.txtIP3.Location = New System.Drawing.Point(222, 45)
        Me.txtIP3.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIP3.Name = "txtIP3"
        Me.txtIP3.Size = New System.Drawing.Size(43, 22)
        Me.txtIP3.TabIndex = 4
        Me.txtIP3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtIP4
        '
        Me.txtIP4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtIP4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIP4.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtIP4.ForeColor = System.Drawing.Color.Black
        Me.txtIP4.Location = New System.Drawing.Point(268, 45)
        Me.txtIP4.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIP4.Name = "txtIP4"
        Me.txtIP4.Size = New System.Drawing.Size(43, 22)
        Me.txtIP4.TabIndex = 5
        Me.txtIP4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(311, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(12, 15)
        Me.Label1.TabIndex = 391
        Me.Label1.Text = "-"
        '
        'txtIPLast
        '
        Me.txtIPLast.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtIPLast.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIPLast.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtIPLast.ForeColor = System.Drawing.Color.Black
        Me.txtIPLast.Location = New System.Drawing.Point(321, 45)
        Me.txtIPLast.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIPLast.Name = "txtIPLast"
        Me.txtIPLast.Size = New System.Drawing.Size(43, 22)
        Me.txtIPLast.TabIndex = 6
        Me.txtIPLast.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtOfficeName
        '
        Me.txtOfficeName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOfficeName.Location = New System.Drawing.Point(130, 22)
        Me.txtOfficeName.Name = "txtOfficeName"
        Me.txtOfficeName.Size = New System.Drawing.Size(234, 20)
        Me.txtOfficeName.TabIndex = 0
        '
        'mode
        '
        Me.mode.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.mode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.mode.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.mode.ForeColor = System.Drawing.Color.Black
        Me.mode.Location = New System.Drawing.Point(8, 133)
        Me.mode.Margin = New System.Windows.Forms.Padding(4)
        Me.mode.Name = "mode"
        Me.mode.ReadOnly = True
        Me.mode.Size = New System.Drawing.Size(56, 22)
        Me.mode.TabIndex = 395
        Me.mode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mode.Visible = False
        '
        'frmAddNewIP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 124)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.txtOfficeName)
        Me.Controls.Add(Me.txtIPLast)
        Me.Controls.Add(Me.txtIP4)
        Me.Controls.Add(Me.txtIP3)
        Me.Controls.Add(Me.txtIP2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.officeid)
        Me.Controls.Add(Me.txtIP1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmAddNewIP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add New IP Address"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtIP1 As System.Windows.Forms.TextBox
    Friend WithEvents officeid As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtIP2 As System.Windows.Forms.TextBox
    Friend WithEvents txtIP3 As System.Windows.Forms.TextBox
    Friend WithEvents txtIP4 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtIPLast As System.Windows.Forms.TextBox
    Friend WithEvents txtOfficeName As System.Windows.Forms.TextBox
    Friend WithEvents mode As System.Windows.Forms.TextBox

End Class
