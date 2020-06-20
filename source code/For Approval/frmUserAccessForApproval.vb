Imports System.Globalization
Imports MySql.Data.MySqlClient

Public Class frmUserAccessForApproval
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        If txtSearch.Text = "" Then Exit Sub
        If e.KeyChar() = Chr(13) Then
            loadLoggedaccounts()
        End If
    End Sub

    Private Sub frmUnblockClearLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.View = View.Details
        ListView1.Columns.Add("User ID", 50, HorizontalAlignment.Center)
        ListView1.Columns.Add("Username", 150, HorizontalAlignment.Left)
        ListView1.Columns.Add("User Access", 150, HorizontalAlignment.Left)
        ListView1.Columns.Add("Suppervisory Loans", 150, HorizontalAlignment.Left)
        ListView1.Columns.Add("Product Template", 150, HorizontalAlignment.Left)
        ListView1.Columns.Add("Deposit Override", 150, HorizontalAlignment.Left)
        loadTemplate()
        loadLoggedaccounts()
    End Sub
    Public Sub loadTemplate()
        LoadToComboBoxPre("SELECT * FROM `action_query`.`tblaccesstemplate` order by templatename asc;", "templatename", "id", txtTemplate)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtTemplate.Text = "" Then
            MsgBox("Please enter template name", vbExclamation)
            txtTemplate.Focus()
            Exit Sub
        End If

        If MessageBox.Show("Are you sure you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            Dim useraccess As String = "" : Dim suploans As String = "" : Dim protemplate As String = "" : Dim deposit As String = ""
            com.CommandText = "select * from action_query.tblaccesstemplate where id='" & DirectCast(txtTemplate.SelectedItem, ComboBoxItem).HiddenValue() & "'" : rst = com.ExecuteReader
            While rst.Read
                useraccess = rst("useraccess").ToString
                suploans = rst("supervisoryloans").ToString
                protemplate = rst("productemplate").ToString
                deposit = rst("depositoverride").ToString
            End While
            rst.Close()

            For Each itm As ListViewItem In ListView1.Items
                If itm.Checked Then
                    com.CommandText = "UPDATE master.userinfo set access_template='" & useraccess & "', approval_template='" & suploans & "', filter_template='" & protemplate & "', override_template='" & deposit & "' where userid='" & itm.SubItems(0).Text & "'" : com.ExecuteNonQuery()
                    Dim getBranch As String = qrysingledata("branch", "(select branchname from master.branches where branchcode = master.userinfo.branchcode) as 'branch'", "master.userinfo  where  userid  = '" & itm.SubItems(0).Text & "'")
                    com.CommandText = "INSERT into action_query.tbltechnicalreport set branchname='" & StrConv(getBranch, vbProperCase) & "', requestorname='" & itm.SubItems(1).Text & "', concern='" & Me.Text & " to " & txtTemplate.Text & "', actiontaken='Access Changed',severitylvl='Critical', performedby='" & GlobalFullname & "', datetrn=current_timestamp" : com.ExecuteNonQuery()
                End If
            Next
            loadLoggedaccounts()
            MsgBox("Selected user(s) successfully changed!", MsgBoxStyle.Information)
        End If
    End Sub
    Public Sub loadLoggedaccounts()
        ListView1.Items.Clear()
        com.CommandText = "SELECT userid, username,ifnull((select template_description from usertemplate where template_code = userinfo.access_template),'-') as 'User Access'," _
                                    + " ifnull((select template_description from userapprovaltemplate where template_code = userinfo.approval_template),'-') as 'Supervisory Loans', " _
                                    + " ifnull((select template_description from prodgltemplatefilter where template_code = userinfo.filter_template),'-') as 'Product Template', " _
                                    + " ifnull((select description from depositoverride where template_code = userinfo.override_template),'-') as 'Deposit Override' FROM `master`.`userinfo` where " _
                                    + " (userid like '%" & txtSearch.Text & "%' or username like '%" & txtSearch.Text & "%' or (select branchname from master.branches where branchcode = userinfo.branchcode) like '%" & txtSearch.Text & "%') or " _
                                    + " (select template_description from usertemplate where template_code = userinfo.access_template) like '%" & txtSearch.Text & "%' or " _
                                    + " (select template_description from userapprovaltemplate where template_code = userinfo.approval_template) like '%" & txtSearch.Text & "%' or " _
                                    + " (select template_description from prodgltemplatefilter where template_code = userinfo.filter_template) like '%" & txtSearch.Text & "%' or " _
                                    + " (select description from depositoverride where template_code = userinfo.override_template) like '%" & txtSearch.Text & "%' order by username asc" : rst = com.ExecuteReader

        While rst.Read
            Dim item1 As New ListViewItem(UCase(rst("userid").ToString), 0)
            item1.SubItems.Add(rst("username").ToString)
            item1.SubItems.Add(rst("User Access").ToString)
            item1.SubItems.Add(rst("Supervisory Loans").ToString)
            item1.SubItems.Add(rst("Product Template").ToString)
            item1.SubItems.Add(rst("Deposit Override").ToString)
            ListView1.Items.AddRange(New ListViewItem() {item1})
        End While
        rst.Close()

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        frmUserAccessTemplate.Show(Me)
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            If f.ShowDialog() = DialogResult.OK Then
                msda = New MySqlDataAdapter("Select UserID, Username, (select branchname from branches where branchcode = userinfo.branchcode) as 'Branch',ifnull((select template_description from usertemplate where template_code = userinfo.access_template),'-') as 'User Access'," _
                                    + " ifnull((select template_description from userapprovaltemplate where template_code = userinfo.approval_template),'-') as 'Supervisory Loans', " _
                                    + " ifnull((select template_description from prodgltemplatefilter where template_code = userinfo.filter_template),'-') as 'Product Template', " _
                                    + " ifnull((select description from depositoverride where template_code = userinfo.override_template),'-') as 'Deposit Override', if(block=1, 'BLOCKED','ACTIVED') as 'Status' FROM `master`.`userinfo` where " _
                                    + " (userid like '%" & txtSearch.Text & "%' or username like '%" & txtSearch.Text & "%' or (select branchname from master.branches where branchcode = userinfo.branchcode) like '%" & txtSearch.Text & "%') or " _
                                    + " (select template_description from usertemplate where template_code = userinfo.access_template) like '%" & txtSearch.Text & "%' or " _
                                    + " (select template_description from userapprovaltemplate where template_code = userinfo.approval_template) like '%" & txtSearch.Text & "%' or " _
                                    + " (select template_description from prodgltemplatefilter where template_code = userinfo.filter_template) like '%" & txtSearch.Text & "%' or " _
                                    + " (select description from depositoverride where template_code = userinfo.override_template) like '%" & txtSearch.Text & "%' order by username asc", conn)
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
