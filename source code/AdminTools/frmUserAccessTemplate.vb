Imports System.Globalization
Imports MySql.Data.MySqlClient

Public Class frmUserAccessTemplate
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmUnblockClearLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.View = View.Details
        ListView1.Columns.Add("id", 0, HorizontalAlignment.Center)
        ListView1.Columns.Add("Template Name", 150, HorizontalAlignment.Left)
        ListView1.Columns.Add("User Access", 150, HorizontalAlignment.Left)
        ListView1.Columns.Add("Suppervisory Loans", 150, HorizontalAlignment.Left)
        ListView1.Columns.Add("Product Template", 150, HorizontalAlignment.Left)
        ListView1.Columns.Add("Deposit Override", 150, HorizontalAlignment.Left)
        LoadToComboBoxPre("select * from master.usertemplate order by template_description asc;", "template_description", "template_code", txtUserAccess)
        LoadToComboBoxPre("select * from master.userapprovaltemplate order by template_description asc;", "template_description", "template_code", txtSuppervisoryLoans)
        LoadToComboBoxPre("select * from master.prodgltemplatefilter order by template_description asc;", "template_description", "template_code", txtProductTemplate)
        LoadToComboBoxPre("select * from master.depositoverride order by description asc;", "description", "template_code", txtDepositOveride)
        LoadTemplates()
    End Sub


    Public Sub LoadTemplates()
        ListView1.Items.Clear()
        com.CommandText = "SELECT id, templatename,ifnull((select template_description from usertemplate where template_code = tblaccesstemplate.useraccess),'-') as 'User Access'," _
                                    + " ifnull((select template_description from userapprovaltemplate where template_code = tblaccesstemplate.supervisoryloans),'-') as 'Supervisory Loans', " _
                                    + " ifnull((select template_description from prodgltemplatefilter where template_code = tblaccesstemplate.productemplate),'-') as 'Product Template', " _
                                    + " ifnull((select description from depositoverride where template_code = tblaccesstemplate.depositoverride),'-') as 'Deposit Override' FROM `action_query`.`tblaccesstemplate`" : rst = com.ExecuteReader

        While rst.Read
            Dim item1 As New ListViewItem(UCase(rst("id").ToString), 0)
            item1.SubItems.Add(rst("templatename").ToString)
            item1.SubItems.Add(rst("User Access").ToString)
            item1.SubItems.Add(rst("Supervisory Loans").ToString)
            item1.SubItems.Add(rst("Product Template").ToString)
            item1.SubItems.Add(rst("Deposit Override").ToString)
            ListView1.Items.AddRange(New ListViewItem() {item1})
        End While
        rst.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtTemplate.Text = "" Then
            MsgBox("Please enter template name", vbExclamation)
            txtTemplate.Focus()
            Exit Sub
        ElseIf txtUserAccess.Text = "" Then
            MsgBox("Please enter user access template", vbExclamation)
            txtUserAccess.Focus()
            Exit Sub
        ElseIf txtSuppervisoryLoans.Text = "" Then
            MsgBox("Please enter suppervisory loans template", vbExclamation)
            txtSuppervisoryLoans.Focus()
            Exit Sub
        ElseIf txtProductTemplate.Text = "" Then
            MsgBox("Please enter product template", vbExclamation)
            txtProductTemplate.Focus()
            Exit Sub
        ElseIf txtDepositOveride.Text = "" Then
            MsgBox("Please enter deposit override template", vbExclamation)
            txtDepositOveride.Focus()
            Exit Sub
        End If
        com.CommandText = "insert into action_query.tblaccesstemplate set templatename='" & rchar(txtTemplate.Text) & "', useraccess='" & DirectCast(txtUserAccess.SelectedItem, ComboBoxItem).HiddenValue() & "', supervisoryloans='" & DirectCast(txtSuppervisoryLoans.SelectedItem, ComboBoxItem).HiddenValue() & "', productemplate='" & DirectCast(txtProductTemplate.SelectedItem, ComboBoxItem).HiddenValue() & "', depositoverride='" & DirectCast(txtDepositOveride.SelectedItem, ComboBoxItem).HiddenValue() & "'" : com.ExecuteNonQuery()
        txtTemplate.Text = ""
        txtUserAccess.SelectedIndex = -1
        txtSuppervisoryLoans.SelectedIndex = -1
        txtProductTemplate.SelectedIndex = -1
        txtDepositOveride.SelectedIndex = -1
        txtTemplate.Focus()
        LoadTemplates()
        frmChangeUserAccess.loadTemplate()
        MsgBox("Template successfully save", MsgBoxStyle.Information)
    End Sub

    Private Sub ViewTransactionDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewTransactionDetailsToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            For Each itm As ListViewItem In ListView1.Items
                If itm.Selected Then
                    frmLoanProfile.txtRefno.Text = itm.SubItems(0).Text
                    com.CommandText = "delete from action_query.tblaccesstemplate where id='" & itm.SubItems(0).Text & "'" : com.ExecuteNonQuery()
                End If
            Next
            LoadTemplates()
            MsgBox("Selected user(s) successfully deleted!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub EditChapterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditChapterToolStripMenuItem.Click
        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            If f.ShowDialog() = DialogResult.OK Then
                msda = New MySqlDataAdapter("select templatename,ifnull((select template_description from usertemplate where template_code = tblaccesstemplate.useraccess),'-') as 'User Access'," _
                                    + " ifnull((select template_description from userapprovaltemplate where template_code = tblaccesstemplate.supervisoryloans),'-') as 'Supervisory Loans', " _
                                    + " ifnull((select template_description from prodgltemplatefilter where template_code = tblaccesstemplate.productemplate),'-') as 'Product Template', " _
                                    + " ifnull((select description from depositoverride where template_code = tblaccesstemplate.depositoverride),'-') as 'Deposit Override' FROM `action_query`.`tblaccesstemplate`", conn)
                dst = New DataSet
                msda.SelectCommand.CommandTimeout = 600000
                msda.Fill(dst, 0)
                dst.WriteXml(f.SelectedPath & "\" & Me.Text & ".xls")
                MessageBox.Show("Export done successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
End Class
