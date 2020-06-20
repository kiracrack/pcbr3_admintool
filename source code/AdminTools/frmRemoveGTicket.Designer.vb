<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRemoveGTicket
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRemoveGTicket))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtClient = New System.Windows.Forms.ComboBox()
        Me.txtBranch = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTotalTickets = New System.Windows.Forms.TextBox()
        Me.txtDateTransaction = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(98, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Please select date of transaction"
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(101, 132)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(272, 33)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Confirm Remove"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(32, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 385
        Me.Label6.Text = "Request by"
        '
        'txtClient
        '
        Me.txtClient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtClient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtClient.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClient.FormattingEnabled = True
        Me.txtClient.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.txtClient.Location = New System.Drawing.Point(101, 108)
        Me.txtClient.Name = "txtClient"
        Me.txtClient.Size = New System.Drawing.Size(272, 21)
        Me.txtClient.TabIndex = 386
        '
        'txtBranch
        '
        Me.txtBranch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtBranch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtBranch.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBranch.FormattingEnabled = True
        Me.txtBranch.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.txtBranch.Location = New System.Drawing.Point(101, 53)
        Me.txtBranch.Name = "txtBranch"
        Me.txtBranch.Size = New System.Drawing.Size(272, 25)
        Me.txtBranch.TabIndex = 391
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(52, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 15)
        Me.Label3.TabIndex = 392
        Me.Label3.Text = "Branch"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label8.Location = New System.Drawing.Point(23, 84)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 15)
        Me.Label8.TabIndex = 394
        Me.Label8.Text = "Total Tickets"
        '
        'txtTotalTickets
        '
        Me.txtTotalTickets.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTotalTickets.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotalTickets.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtTotalTickets.ForeColor = System.Drawing.Color.Black
        Me.txtTotalTickets.Location = New System.Drawing.Point(101, 82)
        Me.txtTotalTickets.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotalTickets.Name = "txtTotalTickets"
        Me.txtTotalTickets.ReadOnly = True
        Me.txtTotalTickets.Size = New System.Drawing.Size(112, 22)
        Me.txtTotalTickets.TabIndex = 393
        Me.txtTotalTickets.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDateTransaction
        '
        Me.txtDateTransaction.CustomFormat = "MMMM dd, yyyy"
        Me.txtDateTransaction.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDateTransaction.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDateTransaction.Location = New System.Drawing.Point(101, 26)
        Me.txtDateTransaction.Name = "txtDateTransaction"
        Me.txtDateTransaction.Size = New System.Drawing.Size(233, 23)
        Me.txtDateTransaction.TabIndex = 395
        '
        'frmRemoveGTicket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 177)
        Me.Controls.Add(Me.txtDateTransaction)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtTotalTickets)
        Me.Controls.Add(Me.txtBranch)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtClient)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmRemoveGTicket"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GL Ticket Remover"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtClient As System.Windows.Forms.ComboBox
    Friend WithEvents txtBranch As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtTotalTickets As System.Windows.Forms.TextBox
    Friend WithEvents txtDateTransaction As System.Windows.Forms.DateTimePicker

End Class
