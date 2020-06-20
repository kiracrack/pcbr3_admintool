<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBranchConnectionSetup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBranchConnectionSetup))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtConnection = New System.Windows.Forms.ComboBox()
        Me.txtBranch = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(204, 69)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(153, 33)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Activate"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtConnection
        '
        Me.txtConnection.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtConnection.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtConnection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtConnection.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtConnection.FormattingEnabled = True
        Me.txtConnection.Items.AddRange(New Object() {"CORPORATE LIVE (ONLINE DATABASE)", "OROQUIETA BRANCH", "BRTI - TAGOLOAN BRACH", "BRTI - CDO BRANCH", "DUMAGUETE BRANCH", "TAGBILARAN BRANCH"})
        Me.txtConnection.Location = New System.Drawing.Point(12, 9)
        Me.txtConnection.Name = "txtConnection"
        Me.txtConnection.Size = New System.Drawing.Size(344, 29)
        Me.txtConnection.TabIndex = 0
        '
        'txtBranch
        '
        Me.txtBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtBranch.FormattingEnabled = True
        Me.txtBranch.Location = New System.Drawing.Point(140, 44)
        Me.txtBranch.Name = "txtBranch"
        Me.txtBranch.Size = New System.Drawing.Size(216, 21)
        Me.txtBranch.TabIndex = 391
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(27, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 15)
        Me.Label3.TabIndex = 392
        Me.Label3.Text = "Select Branch Code"
        '
        'frmBranchConnectionSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 109)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtBranch)
        Me.Controls.Add(Me.txtConnection)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmBranchConnectionSetup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "On-Time Setup Connection"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtConnection As System.Windows.Forms.ComboBox
    Friend WithEvents txtBranch As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
