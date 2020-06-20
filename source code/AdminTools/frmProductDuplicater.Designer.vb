<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductDuplicater
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProductDuplicater))
        Me.cmdset = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtCurrentCode = New System.Windows.Forms.TextBox()
        Me.txtCurrentProduct = New System.Windows.Forms.TextBox()
        Me.txtNewProduct = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNewCode = New System.Windows.Forms.TextBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdset
        '
        Me.cmdset.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdset.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdset.Location = New System.Drawing.Point(82, 132)
        Me.cmdset.Name = "cmdset"
        Me.cmdset.Size = New System.Drawing.Size(221, 30)
        Me.cmdset.TabIndex = 3
        Me.cmdset.Text = "Confirm Execute Duplicate"
        Me.cmdset.UseVisualStyleBackColor = True
        '
        'txtCurrentCode
        '
        Me.txtCurrentCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCurrentCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCurrentCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtCurrentCode.ForeColor = System.Drawing.Color.Gray
        Me.txtCurrentCode.Location = New System.Drawing.Point(13, 29)
        Me.txtCurrentCode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCurrentCode.Name = "txtCurrentCode"
        Me.txtCurrentCode.Size = New System.Drawing.Size(94, 20)
        Me.txtCurrentCode.TabIndex = 2
        Me.txtCurrentCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCurrentProduct
        '
        Me.txtCurrentProduct.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCurrentProduct.Location = New System.Drawing.Point(110, 29)
        Me.txtCurrentProduct.Name = "txtCurrentProduct"
        Me.txtCurrentProduct.ReadOnly = True
        Me.txtCurrentProduct.Size = New System.Drawing.Size(272, 20)
        Me.txtCurrentProduct.TabIndex = 388
        '
        'txtNewProduct
        '
        Me.txtNewProduct.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNewProduct.Location = New System.Drawing.Point(110, 80)
        Me.txtNewProduct.Name = "txtNewProduct"
        Me.txtNewProduct.Size = New System.Drawing.Size(272, 20)
        Me.txtNewProduct.TabIndex = 391
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(10, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(306, 15)
        Me.Label3.TabIndex = 390
        Me.Label3.Text = "Please Enter NEW Product Code and Product Description"
        '
        'txtNewCode
        '
        Me.txtNewCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNewCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNewCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtNewCode.ForeColor = System.Drawing.Color.Gray
        Me.txtNewCode.Location = New System.Drawing.Point(13, 80)
        Me.txtNewCode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNewCode.Name = "txtNewCode"
        Me.txtNewCode.Size = New System.Drawing.Size(94, 20)
        Me.txtNewCode.TabIndex = 389
        Me.txtNewCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(12, 107)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(246, 17)
        Me.CheckBox2.TabIndex = 393
        Me.CheckBox2.Text = "Transfer all Product filter to Duplicated Product"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(9, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(347, 15)
        Me.Label1.TabIndex = 399
        Me.Label1.Text = "Please Enter Existing Product Code to Duplicate and Press ENTER"
        '
        'frmProductDuplicater
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(394, 167)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.txtNewProduct)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNewCode)
        Me.Controls.Add(Me.txtCurrentProduct)
        Me.Controls.Add(Me.txtCurrentCode)
        Me.Controls.Add(Me.cmdset)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmProductDuplicater"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product Duplicator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdset As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents txtCurrentCode As System.Windows.Forms.TextBox
    Friend WithEvents txtCurrentProduct As System.Windows.Forms.TextBox
    Friend WithEvents txtNewProduct As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNewCode As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
