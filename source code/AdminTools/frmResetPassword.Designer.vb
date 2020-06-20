<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResetPassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmResetPassword))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.txtverify = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtBranch = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(180, 62)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 29)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Confirm Change"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtUserID
        '
        Me.txtUserID.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtUserID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUserID.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtUserID.ForeColor = System.Drawing.Color.Gray
        Me.txtUserID.Location = New System.Drawing.Point(98, 200)
        Me.txtUserID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUserID.MaxLength = 3
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(59, 22)
        Me.txtUserID.TabIndex = 0
        Me.txtUserID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtUserID.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label7.Location = New System.Drawing.Point(51, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 15)
        Me.Label7.TabIndex = 397
        Me.Label7.Text = "Password"
        '
        'txtpassword
        '
        Me.txtpassword.BackColor = System.Drawing.SystemColors.Window
        Me.txtpassword.Font = New System.Drawing.Font("Wingdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.txtpassword.ForeColor = System.Drawing.Color.Gray
        Me.txtpassword.Location = New System.Drawing.Point(115, 15)
        Me.txtpassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(108)
        Me.txtpassword.Size = New System.Drawing.Size(185, 20)
        Me.txtpassword.TabIndex = 0
        Me.txtpassword.Text = "Password"
        '
        'txtverify
        '
        Me.txtverify.BackColor = System.Drawing.SystemColors.Window
        Me.txtverify.Font = New System.Drawing.Font("Wingdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.txtverify.ForeColor = System.Drawing.Color.Gray
        Me.txtverify.Location = New System.Drawing.Point(115, 38)
        Me.txtverify.Margin = New System.Windows.Forms.Padding(4)
        Me.txtverify.Name = "txtverify"
        Me.txtverify.PasswordChar = Global.Microsoft.VisualBasic.ChrW(108)
        Me.txtverify.Size = New System.Drawing.Size(185, 20)
        Me.txtverify.TabIndex = 1
        Me.txtverify.Text = "Password"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label8.Location = New System.Drawing.Point(19, 41)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 15)
        Me.Label8.TabIndex = 399
        Me.Label8.Text = "Verify Password"
        '
        'txtBranch
        '
        Me.txtBranch.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtBranch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBranch.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtBranch.ForeColor = System.Drawing.Color.Gray
        Me.txtBranch.Location = New System.Drawing.Point(79, 117)
        Me.txtBranch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBranch.MaxLength = 3
        Me.txtBranch.Name = "txtBranch"
        Me.txtBranch.Size = New System.Drawing.Size(59, 22)
        Me.txtBranch.TabIndex = 400
        Me.txtBranch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtBranch.Visible = False
        '
        'frmResetPassword
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(319, 103)
        Me.Controls.Add(Me.txtBranch)
        Me.Controls.Add(Me.txtverify)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtUserID)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmResetPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtUserID As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents txtverify As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtBranch As System.Windows.Forms.TextBox

End Class
