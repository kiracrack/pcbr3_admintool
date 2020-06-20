Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Drawing.Printing

Public Class frmClientIdentifier
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmPLDTOffices_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If countqry("information_schema.tables", "table_schema = 'action_query' AND table_name = 'tblmbosetup'") = 0 Then
            com.CommandText = "CREATE TABLE  `action_query`.`tblmbosetup` (  `code` int(10) unsigned NOT NULL AUTO_INCREMENT,  `branchcode` varchar(45) NOT NULL,  `mbobranchcode` varchar(45) NOT NULL,  `mboname` varchar(105) NOT NULL,  `micro` tinyint(1) NOT NULL DEFAULT '0',  PRIMARY KEY (`code`),  KEY `Index_2` (`mbobranchcode`,`mboname`)) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery()
        End If
        If countqry("information_schema.COLUMNS", "TABLE_SCHEMA='master' and TABLE_NAME = 'client' AND COLUMN_NAME = 'mbocode'") = 0 Then
            com.CommandText = "ALTER TABLE `master`.`client` ADD COLUMN `mbocode` VARCHAR(45) NOT NULL DEFAULT '' AFTER `occupation`;" : com.ExecuteNonQuery()
        End If
        LoadBranch()
        txtClientType.SelectedIndex = 0
        txtAcctType.SelectedIndex = 0
        txtProductType.SelectedIndex = 0
    End Sub

    Private Sub LoadBranch()
        txtBranch.Items.Clear()
        com.CommandText = "select * from master.branches" : rst = com.ExecuteReader
        While rst.Read
            txtBranch.Items.Add(New ComboBoxItem(rst("branchname").ToString, rst("branchcode")))
        End While
        rst.Close()
    End Sub

    Private Sub txtBranch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtBranch.SelectedIndexChanged, txtClientType.SelectedIndexChanged, txtAcctType.SelectedIndexChanged, txtProductType.SelectedIndexChanged
        If txtBranch.Text = "" Then Exit Sub
        FilterClient(DirectCast(txtBranch.SelectedItem, ComboBoxItem).HiddenValue())
        If txtClientType.SelectedIndex = 0 Then
            ChangeCenterToolStripMenuItem.Visible = True
        Else
            ChangeCenterToolStripMenuItem.Visible = False
        End If
    End Sub

    Public Function FilterClient(ByVal brcode As String)
        Dim cnt = 0 : Dim lname As String = "" : Dim fname As String = ""
        For Each word In txtSearch.Text.Split(New Char() {","c})
            If cnt = 0 Then
                lname = Trim(word)
            ElseIf cnt = 1 Then
                fname = Trim(word)
            End If
            cnt = cnt + 1
        Next
        Dim productSetting As String = ""
        If txtClientType.SelectedIndex = 0 Then
            com.CommandText = "select * from master.loanprod where microfinance=" & txtProductType.SelectedIndex & "" : rst = com.ExecuteReader
            While rst.Read
                productSetting = productSetting & "loanprod='" & rst("prodcode").ToString & "' or "
            End While
            rst.Close()
        Else
            com.CommandText = "select * from master.depositprod where microfinance=" & txtProductType.SelectedIndex & "" : rst = com.ExecuteReader
            While rst.Read
                productSetting = productSetting & "depcode='" & rst("depcode").ToString & "' or "
            End While
            rst.Close()
        End If
      
        If productSetting.Length > 0 Then
            productSetting = productSetting.Remove(productSetting.Length - 3, 3)
            productSetting = " and (" & productSetting & ")"
            txtProfilter.Text = productSetting
        End If

        MyDataGridView.DataSource = Nothing : dst = New DataSet
        If txtClientType.SelectedIndex = 0 Then
            msda = New MySqlDataAdapter("select refno as 'PN Number', (select concat(lname, ', ',fname, ' ', mname) from master.client where custcode = loanwithterm.custcode) as 'Client Name', (select res_street from master.client where custcode = loanwithterm.custcode)  as 'Street', (select res_city from master.client where custcode = loanwithterm.custcode)  as 'City', (select res_province from master.client where custcode = loanwithterm.custcode)  as 'Province',  (select prodname from master.loanprod where prodcode=loanwithterm.loanprod)  as 'Product',pribal as 'Balance',(select centername from master.g_center where centerkey = loanwithterm.centerkey) as 'Center',(select (select username from master.userinfo where userid = g_center.accountofficer) from master.g_center where centerkey = loanwithterm.centerkey) as 'Account Officer' from master.loanwithterm where branchcode='" & brcode & "' " & txtProfilter.Text & If(txtAcctType.SelectedIndex = 0, " and pribal> 0", " ") & " and (((select lname from master.client where custcode = loanwithterm.custcode)   like '" & lname & "%' and (select fname from master.client where custcode = loanwithterm.custcode)   like '" & fname & "%') or refno like '%" & txtSearch.Text & "%') and cancelled=0 order by (select concat(lname, ', ',fname, ' ', mname) from master.client where custcode = loanwithterm.custcode) asc", conn)
        Else
            msda = New MySqlDataAdapter("select acctnumber as 'Acct. Number', accountname as 'Account Name', (select concat(lname, ', ',fname, ' ', mname) from master.client where custcode=depositaccounts.signatory1)  as 'Signatory 1', (select res_street from master.client where custcode = depositaccounts.signatory1)  as 'Street', (select res_city from master.client where custcode = depositaccounts.signatory1)  as 'City', (select res_province from master.client where custcode = depositaccounts.signatory1)  as 'Province', (select description from master.depositprod where depcode=depositaccounts.depcode)  as 'Product',currbalance as 'Balance' from master.depositaccounts where branchcode='" & brcode & "' " & txtProfilter.Text & If(txtAcctType.SelectedIndex = 0, " and currbalance> 0", " ") & "  and (((select lname from master.client where custcode=depositaccounts.signatory1)   like '" & lname & "%' and (select fname from master.client where custcode=depositaccounts.signatory1) like '" & fname & "%') or acctnumber like '%" & txtSearch.Text & "%') order by (select concat(lname, ', ',fname, ' ', mname) from master.client where custcode=depositaccounts.signatory1) asc", conn)
        End If

        msda.SelectCommand.CommandTimeout = 600000
        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)

        'MyDataGridView.Columns("Address").Width = 300
        MyDataGridView.Columns("Product").Width = 250
        If txtClientType.SelectedIndex = 0 Then
            MyDataGridView.Columns("Client Name").Width = 250
            GridColumnAlignment(MyDataGridView, {"PN Number"}, DataGridViewContentAlignment.MiddleCenter)
        Else
            MyDataGridView.Columns("Signatory 1").Width = 250
            GridColumnAlignment(MyDataGridView, {"Acct. Number"}, DataGridViewContentAlignment.MiddleCenter)
        End If
        GridCurrencyColumn(MyDataGridView, {"Balance"})
    End Function

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        If e.KeyChar() = Chr(13) And txtBranch.Text <> "" Then
            FilterClient(DirectCast(txtBranch.SelectedItem, ComboBoxItem).HiddenValue())
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        frmMBOSetup.Show()
    End Sub

    Private Sub EditIPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditIPToolStripMenuItem.Click
        frmMBOTagging.txtBranchcode.Text = DirectCast(txtBranch.SelectedItem, ComboBoxItem).HiddenValue()
        frmMBOTagging.Show(Me)
    End Sub
    Public Function TagClientMBO(ByVal MBOCode As String, ByVal MBOName As String)
        Dim cnt As Integer = 0
        For Each rw As DataGridViewRow In MyDataGridView.SelectedRows
            If MBOCode = "" Then
                MBOCode = DirectCast(txtBranch.SelectedItem, ComboBoxItem).HiddenValue()
            End If
            If txtClientType.SelectedIndex = 0 Then
                com.CommandText = "update master.loanwithterm set branchcode='" & MBOCode & "', groupkey=concat('" & MBOCode & "',right(groupkey,12)), centerkey=concat('" & MBOCode & "',right(centerkey,8)) where refno='" & rw.Cells("PN Number").Value.ToString & "'" : com.ExecuteNonQuery()
            Else
                com.CommandText = "update master.depositaccounts set branchcode='" & MBOCode & "' where acctnumber='" & rw.Cells("Acct. Number").Value.ToString & "'" : com.ExecuteNonQuery()
            End If
            MyDataGridView.Rows.Remove(rw)
        Next
        Return 0
    End Function

    Public Function ChangeCenter(ByVal groupkey As String, ByVal centerkey As String, ByVal center As String, ByVal ao As String)
        Dim cnt As Integer = 0
        For Each rw As DataGridViewRow In MyDataGridView.SelectedRows
            com.CommandText = "update master.loanwithterm set groupkey='" & groupkey & "', centerkey='" & centerkey & "' where refno='" & rw.Cells("PN Number").Value.ToString & "'" : com.ExecuteNonQuery()
            rw.Cells("Center").Value = center
            rw.Cells("Account Officer").Value = ao
        Next
        Return 0
    End Function

    Private Sub ToolStripTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        If e.KeyChar() = Chr(13) Then
            FilterClient(DirectCast(txtBranch.SelectedItem, ComboBoxItem).HiddenValue())
        End If
    End Sub

    Private Sub txtProfilter_TextChanged(sender As Object, e As EventArgs) Handles txtProfilter.TextChanged
        FilterClient(DirectCast(txtBranch.SelectedItem, ComboBoxItem).HiddenValue())
    End Sub
      
    Private Sub ChangeCenterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeCenterToolStripMenuItem.Click
        frmMBOChangeCenter.Show(Me)
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        FilterClient(DirectCast(txtBranch.SelectedItem, ComboBoxItem).HiddenValue())
    End Sub
End Class