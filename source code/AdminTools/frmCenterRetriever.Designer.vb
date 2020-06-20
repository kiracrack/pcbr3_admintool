<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCenterRetriever
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCenterRetriever))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBranch = New System.Windows.Forms.ComboBox()
        Me.txtClient = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtQuery = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCenter = New System.Windows.Forms.ComboBox()
        Me.txtScript = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(76, 332)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(294, 33)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Confirm and Restore Center"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(189, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Please select branch and center name"
        '
        'txtBranch
        '
        Me.txtBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtBranch.FormattingEnabled = True
        Me.txtBranch.Location = New System.Drawing.Point(12, 24)
        Me.txtBranch.Name = "txtBranch"
        Me.txtBranch.Size = New System.Drawing.Size(139, 21)
        Me.txtBranch.TabIndex = 9
        '
        'txtClient
        '
        Me.txtClient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtClient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtClient.FormattingEnabled = True
        Me.txtClient.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.txtClient.Location = New System.Drawing.Point(76, 307)
        Me.txtClient.Name = "txtClient"
        Me.txtClient.Size = New System.Drawing.Size(294, 21)
        Me.txtClient.TabIndex = 386
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 310)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 385
        Me.Label4.Text = "Request by"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(183, 149)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(187, 30)
        Me.Button2.TabIndex = 387
        Me.Button2.Text = "Retrieve Center Script"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtQuery
        '
        Me.txtQuery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQuery.Location = New System.Drawing.Point(12, 202)
        Me.txtQuery.Name = "txtQuery"
        Me.txtQuery.Size = New System.Drawing.Size(358, 99)
        Me.txtQuery.TabIndex = 389
        Me.txtQuery.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 186)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 13)
        Me.Label1.TabIndex = 388
        Me.Label1.Text = "Load center script and execute"
        '
        'txtCenter
        '
        Me.txtCenter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtCenter.FormattingEnabled = True
        Me.txtCenter.Location = New System.Drawing.Point(154, 24)
        Me.txtCenter.Name = "txtCenter"
        Me.txtCenter.Size = New System.Drawing.Size(216, 21)
        Me.txtCenter.TabIndex = 390
        '
        'txtScript
        '
        Me.txtScript.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtScript.Location = New System.Drawing.Point(12, 48)
        Me.txtScript.Name = "txtScript"
        Me.txtScript.Size = New System.Drawing.Size(358, 99)
        Me.txtScript.TabIndex = 391
        Me.txtScript.Text = ""
        '
        'frmCenterRetriever
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 371)
        Me.Controls.Add(Me.txtScript)
        Me.Controls.Add(Me.txtCenter)
        Me.Controls.Add(Me.txtQuery)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtClient)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtBranch)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmCenterRetriever"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Center Retriever"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBranch As System.Windows.Forms.ComboBox
    Friend WithEvents txtClient As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtQuery As System.Windows.Forms.RichTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCenter As System.Windows.Forms.ComboBox
    Friend WithEvents txtScript As System.Windows.Forms.RichTextBox

End Class
