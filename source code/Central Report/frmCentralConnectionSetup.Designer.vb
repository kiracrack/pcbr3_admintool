<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCentralConnectionSetup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCentralConnectionSetup))
        Me.txtBranch = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmdset = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtBranch
        '
        Me.txtBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtBranch.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtBranch.FormattingEnabled = True
        Me.txtBranch.Items.AddRange(New Object() {"LIVE TRANSACTION DATABASE SETUP", "BACKUP DATABASE CONNECTION SETUP"})
        Me.txtBranch.Location = New System.Drawing.Point(41, 28)
        Me.txtBranch.Name = "txtBranch"
        Me.txtBranch.Size = New System.Drawing.Size(377, 29)
        Me.txtBranch.TabIndex = 409
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(38, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 15)
        Me.Label6.TabIndex = 410
        Me.Label6.Text = "Select Connection Type"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdset
        '
        Me.cmdset.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdset.Location = New System.Drawing.Point(257, 60)
        Me.cmdset.Name = "cmdset"
        Me.cmdset.Size = New System.Drawing.Size(161, 32)
        Me.cmdset.TabIndex = 411
        Me.cmdset.Text = "Connection Setup"
        Me.cmdset.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(257, 93)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(161, 32)
        Me.Button1.TabIndex = 413
        Me.Button1.Text = "Check System Date"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmCentralConnectionSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(459, 141)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmdset)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtBranch)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmCentralConnectionSetup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select Connection Setup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtBranch As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmdset As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
