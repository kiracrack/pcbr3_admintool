<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPopUnlocker
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPopUnlocker))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ls = New System.Windows.Forms.CheckedListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.txtAccounts = New System.Windows.Forms.ComboBox()
        Me.txtuserid = New System.Windows.Forms.TextBox()
        Me.txtttlclient = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.txtClient = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(10, 403)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(308, 33)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Confirm Unlock"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ls
        '
        Me.ls.CheckOnClick = True
        Me.ls.FormattingEnabled = True
        Me.ls.Location = New System.Drawing.Point(10, 53)
        Me.ls.Name = "ls"
        Me.ls.Size = New System.Drawing.Size(308, 289)
        Me.ls.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(252, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Please select user to display POP Locked Accounts"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(13, 345)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(71, 17)
        Me.CheckBox1.TabIndex = 14
        Me.CheckBox1.Text = "Check All"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'txtAccounts
        '
        Me.txtAccounts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtAccounts.FormattingEnabled = True
        Me.txtAccounts.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.txtAccounts.Location = New System.Drawing.Point(10, 28)
        Me.txtAccounts.Name = "txtAccounts"
        Me.txtAccounts.Size = New System.Drawing.Size(308, 21)
        Me.txtAccounts.TabIndex = 15
        '
        'txtuserid
        '
        Me.txtuserid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtuserid.Location = New System.Drawing.Point(124, 191)
        Me.txtuserid.Name = "txtuserid"
        Me.txtuserid.Size = New System.Drawing.Size(82, 20)
        Me.txtuserid.TabIndex = 16
        Me.txtuserid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtuserid.Visible = False
        '
        'txtttlclient
        '
        Me.txtttlclient.Location = New System.Drawing.Point(124, 346)
        Me.txtttlclient.Name = "txtttlclient"
        Me.txtttlclient.Size = New System.Drawing.Size(194, 13)
        Me.txtttlclient.TabIndex = 17
        Me.txtttlclient.Text = "Total Client"
        Me.txtttlclient.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtSearch.ForeColor = System.Drawing.Color.Gray
        Me.txtSearch.Location = New System.Drawing.Point(11, 319)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(306, 22)
        Me.txtSearch.TabIndex = 18
        Me.txtSearch.Visible = False
        '
        'txtClient
        '
        Me.txtClient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtClient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtClient.FormattingEnabled = True
        Me.txtClient.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.txtClient.Location = New System.Drawing.Point(10, 379)
        Me.txtClient.Name = "txtClient"
        Me.txtClient.Size = New System.Drawing.Size(308, 21)
        Me.txtClient.TabIndex = 386
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 363)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 385
        Me.Label4.Text = "Request by"
        '
        'frmPopUnlocker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 442)
        Me.Controls.Add(Me.txtClient)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.txtttlclient)
        Me.Controls.Add(Me.txtuserid)
        Me.Controls.Add(Me.txtAccounts)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ls)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmPopUnlocker"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "POP Client Unlock"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ls As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents txtAccounts As System.Windows.Forms.ComboBox
    Friend WithEvents txtuserid As System.Windows.Forms.TextBox
    Friend WithEvents txtttlclient As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents txtClient As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
