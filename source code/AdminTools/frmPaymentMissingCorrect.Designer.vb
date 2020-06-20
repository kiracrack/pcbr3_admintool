<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPaymentMissingCorrect
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPaymentMissingCorrect))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtrefcode = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtYear = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMonth = New System.Windows.Forms.ComboBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtClient = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtLedger = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtProofsheet = New System.Windows.Forms.TextBox()
        Me.txtuserid = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(295, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please Enter OR Reference Number and press enter to verify"
        '
        'txtrefcode
        '
        Me.txtrefcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtrefcode.Location = New System.Drawing.Point(110, 96)
        Me.txtrefcode.Name = "txtrefcode"
        Me.txtrefcode.Size = New System.Drawing.Size(122, 20)
        Me.txtrefcode.TabIndex = 1
        Me.txtrefcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(110, 190)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(272, 33)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Confirm Cancel Entry"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtYear
        '
        Me.txtYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtYear.FormattingEnabled = True
        Me.txtYear.Location = New System.Drawing.Point(15, 49)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(82, 21)
        Me.txtYear.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Please select Date of transaction"
        '
        'txtMonth
        '
        Me.txtMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtMonth.FormattingEnabled = True
        Me.txtMonth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.txtMonth.Location = New System.Drawing.Point(101, 49)
        Me.txtMonth.Name = "txtMonth"
        Me.txtMonth.Size = New System.Drawing.Size(281, 21)
        Me.txtMonth.TabIndex = 9
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(15, 12)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(180, 17)
        Me.CheckBox1.TabIndex = 15
        Me.CheckBox1.Text = "Check if current date transaction"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "OR No. && User ID"
        '
        'txtClient
        '
        Me.txtClient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtClient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtClient.FormattingEnabled = True
        Me.txtClient.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.txtClient.Location = New System.Drawing.Point(110, 165)
        Me.txtClient.Name = "txtClient"
        Me.txtClient.Size = New System.Drawing.Size(272, 21)
        Me.txtClient.TabIndex = 386
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(43, 169)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 385
        Me.Label6.Text = "Request by"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 122)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 13)
        Me.Label7.TabIndex = 389
        Me.Label7.Text = "Client Ledger Entry"
        '
        'txtLedger
        '
        Me.txtLedger.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLedger.Location = New System.Drawing.Point(110, 119)
        Me.txtLedger.Name = "txtLedger"
        Me.txtLedger.ReadOnly = True
        Me.txtLedger.Size = New System.Drawing.Size(272, 20)
        Me.txtLedger.TabIndex = 388
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 145)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 13)
        Me.Label8.TabIndex = 391
        Me.Label8.Text = "Proofsheet Entry"
        '
        'txtProofsheet
        '
        Me.txtProofsheet.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProofsheet.Location = New System.Drawing.Point(110, 142)
        Me.txtProofsheet.Name = "txtProofsheet"
        Me.txtProofsheet.ReadOnly = True
        Me.txtProofsheet.Size = New System.Drawing.Size(272, 20)
        Me.txtProofsheet.TabIndex = 390
        '
        'txtuserid
        '
        Me.txtuserid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtuserid.Location = New System.Drawing.Point(235, 96)
        Me.txtuserid.Name = "txtuserid"
        Me.txtuserid.Size = New System.Drawing.Size(49, 20)
        Me.txtuserid.TabIndex = 392
        Me.txtuserid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmPaymentMissingCorrect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(398, 235)
        Me.Controls.Add(Me.txtuserid)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtProofsheet)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtLedger)
        Me.Controls.Add(Me.txtClient)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.txtMonth)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtrefcode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmPaymentMissingCorrect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cancellation of Error Payment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtrefcode As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtYear As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMonth As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtClient As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtLedger As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtProofsheet As TextBox
    Friend WithEvents txtuserid As TextBox
End Class
