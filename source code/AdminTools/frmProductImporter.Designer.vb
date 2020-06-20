<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductImporter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProductImporter))
        Me.cmdset = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtFilename = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ckUpdate = New System.Windows.Forms.CheckBox()
        Me.txtCurrentCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCurrentProduct = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdset
        '
        Me.cmdset.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdset.Location = New System.Drawing.Point(185, 148)
        Me.cmdset.Name = "cmdset"
        Me.cmdset.Size = New System.Drawing.Size(237, 35)
        Me.cmdset.TabIndex = 3
        Me.cmdset.Text = "Comfirm Import Product"
        Me.cmdset.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(7, 7)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(574, 135)
        Me.TabControl1.TabIndex = 400
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.txtFilename)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(566, 107)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Import Product"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(376, 41)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(125, 26)
        Me.Button1.TabIndex = 390
        Me.Button1.Text = "Import FIle"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtFilename
        '
        Me.txtFilename.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFilename.Location = New System.Drawing.Point(51, 42)
        Me.txtFilename.Name = "txtFilename"
        Me.txtFilename.ReadOnly = True
        Me.txtFilename.Size = New System.Drawing.Size(322, 23)
        Me.txtFilename.TabIndex = 389
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ckUpdate)
        Me.TabPage2.Controls.Add(Me.txtCurrentCode)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.txtCurrentProduct)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(566, 107)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Export Product"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ckUpdate
        '
        Me.ckUpdate.AutoSize = True
        Me.ckUpdate.Location = New System.Drawing.Point(140, 75)
        Me.ckUpdate.Name = "ckUpdate"
        Me.ckUpdate.Size = New System.Drawing.Size(152, 19)
        Me.ckUpdate.TabIndex = 400
        Me.ckUpdate.Text = "Update existing product"
        Me.ckUpdate.UseVisualStyleBackColor = True
        '
        'txtCurrentCode
        '
        Me.txtCurrentCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCurrentCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCurrentCode.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrentCode.ForeColor = System.Drawing.Color.Gray
        Me.txtCurrentCode.Location = New System.Drawing.Point(27, 49)
        Me.txtCurrentCode.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCurrentCode.Name = "txtCurrentCode"
        Me.txtCurrentCode.Size = New System.Drawing.Size(109, 23)
        Me.txtCurrentCode.TabIndex = 2
        Me.txtCurrentCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(23, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 15)
        Me.Label1.TabIndex = 399
        Me.Label1.Text = "Please Enter Existing Product code to export"
        '
        'txtCurrentProduct
        '
        Me.txtCurrentProduct.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCurrentProduct.Location = New System.Drawing.Point(141, 49)
        Me.txtCurrentProduct.Name = "txtCurrentProduct"
        Me.txtCurrentProduct.ReadOnly = True
        Me.txtCurrentProduct.Size = New System.Drawing.Size(399, 23)
        Me.txtCurrentProduct.TabIndex = 388
        '
        'frmProductImporter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(588, 190)
        Me.Controls.Add(Me.cmdset)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmProductImporter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product Import / Export"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdset As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents txtCurrentCode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCurrentProduct As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtFilename As System.Windows.Forms.TextBox
    Friend WithEvents ckUpdate As CheckBox
End Class
