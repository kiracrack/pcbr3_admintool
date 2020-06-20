<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfirmedBeginingofDay
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfirmedBeginingofDay))
        Me.cms_em = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ViewTransactionDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtAction = New System.Windows.Forms.RichTextBox()
        Me.txtDateOfTheDay = New System.Windows.Forms.DateTimePicker()
        Me.cms_em.SuspendLayout()
        Me.SuspendLayout()
        '
        'cms_em
        '
        Me.cms_em.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewTransactionDetailsToolStripMenuItem})
        Me.cms_em.Name = "ContextMenuStrip1"
        Me.cms_em.Size = New System.Drawing.Size(166, 26)
        '
        'ViewTransactionDetailsToolStripMenuItem
        '
        Me.ViewTransactionDetailsToolStripMenuItem.Image = Global.AdminTool.My.Resources.Resources.blue_document_export
        Me.ViewTransactionDetailsToolStripMenuItem.Name = "ViewTransactionDetailsToolStripMenuItem"
        Me.ViewTransactionDetailsToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ViewTransactionDetailsToolStripMenuItem.Text = "View Loan Profile"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(287, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "List of beginning of day confirmation script about to execute"
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button1.Location = New System.Drawing.Point(224, 340)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(272, 33)
        Me.Button1.TabIndex = 388
        Me.Button1.Text = "Execute Confirm"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtAction
        '
        Me.txtAction.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAction.Location = New System.Drawing.Point(10, 50)
        Me.txtAction.Name = "txtAction"
        Me.txtAction.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.txtAction.Size = New System.Drawing.Size(713, 284)
        Me.txtAction.TabIndex = 389
        Me.txtAction.Text = ""
        Me.txtAction.WordWrap = False
        '
        'txtDateOfTheDay
        '
        Me.txtDateOfTheDay.CustomFormat = "MMMM dd, yyyy"
        Me.txtDateOfTheDay.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDateOfTheDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDateOfTheDay.Location = New System.Drawing.Point(10, 8)
        Me.txtDateOfTheDay.Name = "txtDateOfTheDay"
        Me.txtDateOfTheDay.Size = New System.Drawing.Size(215, 23)
        Me.txtDateOfTheDay.TabIndex = 390
        '
        'frmConfirmedBeginingofDay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(735, 379)
        Me.Controls.Add(Me.txtDateOfTheDay)
        Me.Controls.Add(Me.txtAction)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmConfirmedBeginingofDay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tiwason and Beginning of Day kay ga error sa system"
        Me.cms_em.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cms_em As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ViewTransactionDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtAction As System.Windows.Forms.RichTextBox
    Friend WithEvents txtDateOfTheDay As System.Windows.Forms.DateTimePicker

End Class
