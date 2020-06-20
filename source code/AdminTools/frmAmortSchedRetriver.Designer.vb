<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAmortSchedRetriver
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAmortSchedRetriver))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtrefcode = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.txtClient = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtQuery = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(303, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please Enter Loan Reference Number and press enter to verify"
        '
        'txtrefcode
        '
        Me.txtrefcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtrefcode.Location = New System.Drawing.Point(12, 28)
        Me.txtrefcode.Name = "txtrefcode"
        Me.txtrefcode.Size = New System.Drawing.Size(82, 20)
        Me.txtrefcode.TabIndex = 0
        Me.txtrefcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtName
        '
        Me.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtName.Location = New System.Drawing.Point(98, 28)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(272, 20)
        Me.txtName.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(442, 262)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(184, 33)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Confirm and Restore Schedule"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(373, 27)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(166, 22)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Retrieve Amortization Script"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 55)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(614, 76)
        Me.RichTextBox1.TabIndex = 12
        Me.RichTextBox1.Text = ""
        '
        'txtClient
        '
        Me.txtClient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtClient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtClient.FormattingEnabled = True
        Me.txtClient.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.txtClient.Location = New System.Drawing.Point(354, 237)
        Me.txtClient.Name = "txtClient"
        Me.txtClient.Size = New System.Drawing.Size(272, 21)
        Me.txtClient.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(288, 241)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Request by"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(249, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Load loan amortization schedule script and execute"
        '
        'txtQuery
        '
        Me.txtQuery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQuery.Location = New System.Drawing.Point(12, 156)
        Me.txtQuery.Name = "txtQuery"
        Me.txtQuery.Size = New System.Drawing.Size(614, 76)
        Me.txtQuery.TabIndex = 26
        Me.txtQuery.Text = ""
        '
        'frmAmortSchedRetriver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 304)
        Me.Controls.Add(Me.txtQuery)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.txtClient)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtrefcode)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmAmortSchedRetriver"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Amortization Schedule Retriever"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtrefcode As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents txtClient As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtQuery As System.Windows.Forms.RichTextBox

End Class
