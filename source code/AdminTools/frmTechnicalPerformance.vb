Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Drawing.Printing
Imports DataGridViewGrouper


Public Class frmTechnicalPerformance
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmRequestType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TabFilter()
    End Sub
 
    Public Sub FilterGeneralTechnicalPerformance()
        msda = New MySqlDataAdapter("select distinct itname as 'IT Personnel', (select count(*) from action_query.tbltechnicalreport where performedby = a.itname and severitylvl='Enhancement' and ontechnical=0) as 'Enhancement', (select count(*) from action_query.tbltechnicalreport where performedby = a.itname and severitylvl='Minor' and ontechnical=0) as 'Minor', (select count(*) from action_query.tbltechnicalreport where performedby = a.itname and severitylvl='Normal' and ontechnical=0) as 'Normal', (select count(*) from action_query.tbltechnicalreport where performedby = a.itname and severitylvl='Major' and ontechnical=0) as 'Major', (select count(*) from action_query.tbltechnicalreport where performedby = a.itname and severitylvl='Critical' and ontechnical=0) as 'Critical', (select count(*) from action_query.tbltechnicalreport where performedby = a.itname and ontechnical=0)  as 'Total' " _
                                    + " FROM action_query.`tbltechnicalsupport` as a  " & If(GlobalLimited = True, "where a.limited=1", "") & " ;", conn)
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda.SelectCommand.CommandTimeout = 600000
        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        'MyDataGridView.Columns("Details").Width = 300
        'MyDataGridView.Columns("id").Visible = False
        GridColumnAlignment(MyDataGridView, {"Enhancement", "Minor", "Normal", "Major", "Critical", "Total"}, DataGridViewContentAlignment.MiddleCenter)
    End Sub

    Public Sub FilterOnsiteTechnicalPerformance()
        msda = New MySqlDataAdapter("select distinct itname as 'IT Personnel', (select count(*) from action_query.tbltechnicalreport where techsupport = a.itname and severitylvl='Enhancement' and ontechnical=1) as 'Enhancement', (select count(*) from action_query.tbltechnicalreport where techsupport = a.itname and severitylvl='Minor' and ontechnical=1) as 'Minor', (select count(*) from action_query.tbltechnicalreport where techsupport = a.itname and severitylvl='Normal' and ontechnical=1) as 'Normal', (select count(*) from action_query.tbltechnicalreport where techsupport = a.itname and severitylvl='Major' and ontechnical=1) as 'Major', (select count(*) from action_query.tbltechnicalreport where techsupport = a.itname and severitylvl='Critical' and ontechnical=1) as 'Critical', (select count(*) from action_query.tbltechnicalreport where techsupport = a.itname and ontechnical=1) as 'Total' " _
                                    + " FROM action_query.`tbltechnicalsupport` as a  " & If(GlobalLimited = True, "where a.limited=1", "") & " ;", conn)
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda.SelectCommand.CommandTimeout = 600000
        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        'MyDataGridView.Columns("Details").Width = 300
        'MyDataGridView.Columns("id").Visible = False
        GridColumnAlignment(MyDataGridView, {"Enhancement", "Minor", "Normal", "Major", "Critical", "Total"}, DataGridViewContentAlignment.MiddleCenter)
    End Sub

    Public Sub FilterDailyTransactionLogs()
        Me.Cursor = Cursors.WaitCursor
        msda = New MySqlDataAdapter("select date_format(datetrn, '%Y-%m-%d') as 'Date Transaction', " _
                                            + " (select count(*) from action_query.tbltechnicalreport where date_format(datetrn, '%Y-%m-%d') = date_format(a.datetrn, '%Y-%m-%d') and severitylvl='Enhancement') as 'Enhancement', " _
                                            + " (select count(*) from action_query.tbltechnicalreport where date_format(datetrn, '%Y-%m-%d') = date_format(a.datetrn, '%Y-%m-%d') and severitylvl='Minor') as 'Minor', " _
                                            + " (select count(*) from action_query.tbltechnicalreport where date_format(datetrn, '%Y-%m-%d') = date_format(a.datetrn, '%Y-%m-%d') and severitylvl='Normal') as 'Normal', " _
                                            + " (select count(*) from action_query.tbltechnicalreport where date_format(datetrn, '%Y-%m-%d') = date_format(a.datetrn, '%Y-%m-%d') and severitylvl='Major') as 'Major', " _
                                            + " (select count(*) from action_query.tbltechnicalreport where date_format(datetrn, '%Y-%m-%d') = date_format(a.datetrn, '%Y-%m-%d') and severitylvl='Critical') as 'Critical', " _
                                            + " count(*) as 'Total' " _
                                            + " FROM action_query.`tbltechnicalreport` as a " & If(GlobalLimited = True, " where a.performedby in (select itname from action_query.tbltechnicalsupport where limited=1) ", "") & "  group by date_format(a.datetrn, '%Y-%m-%d') order by datetrn asc;", conn)
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda.SelectCommand.CommandTimeout = 600000
        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        'MyDataGridView.Columns("Details").Width = 300
        'MyDataGridView.Columns("id").Visible = False
        Me.Cursor = Cursors.Default
        GridColumnAlignment(MyDataGridView, {"Date Transaction", "Enhancement", "Minor", "Normal", "Major", "Critical", "Total"}, DataGridViewContentAlignment.MiddleCenter)
    End Sub
    Public Sub FilterBranchTransactionLogs()
        Me.Cursor = Cursors.WaitCursor
        msda = New MySqlDataAdapter("select branchname as 'Branch', " _
                                            + " (select count(*) from action_query.tbltechnicalreport where branchname = a.branchname and severitylvl='Enhancement') as 'Enhancement', " _
                                            + " (select count(*) from action_query.tbltechnicalreport where branchname = a.branchname and severitylvl='Minor') as 'Minor', " _
                                            + " (select count(*) from action_query.tbltechnicalreport where branchname = a.branchname and severitylvl='Normal') as 'Normal', " _
                                            + " (select count(*) from action_query.tbltechnicalreport where branchname = a.branchname and severitylvl='Major') as 'Major', " _
                                            + " (select count(*) from action_query.tbltechnicalreport where branchname = a.branchname and severitylvl='Critical') as 'Critical', " _
                                            + " count(*) as 'Total' " _
                                            + " FROM action_query.`tbltechnicalreport` as a " & If(GlobalLimited = True, " where a.performedby in (select itname from action_query.tbltechnicalsupport where limited=1) ", "") & " group by branchname order by count(*) desc;", conn)
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda.SelectCommand.CommandTimeout = 600000
        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        'MyDataGridView.Columns("Details").Width = 300
        'MyDataGridView.Columns("id").Visible = False
        Me.Cursor = Cursors.Default
        GridColumnAlignment(MyDataGridView, {"Enhancement", "Minor", "Normal", "Major", "Critical", "Total"}, DataGridViewContentAlignment.MiddleCenter)
    End Sub
    Public Sub FilterConcernTransactionLogs()
        Me.Cursor = Cursors.WaitCursor
        msda = New MySqlDataAdapter("select Concern, count(*) as 'Total' FROM action_query.`tbltechnicalreport` as a " & If(GlobalLimited = True, " where a.performedby in (select itname from action_query.tbltechnicalsupport where limited=1) ", "") & "  group by Concern order by count(*) desc;", conn)
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda.SelectCommand.CommandTimeout = 600000
        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        Subro.Controls.GroupRow()
        'MyDataGridView.Columns("Concern").Width = 600
        'MyDataGridView.Columns("id").Visible = False
        Me.Cursor = Cursors.Default
        GridColumnAlignment(MyDataGridView, {"Total"}, DataGridViewContentAlignment.MiddleCenter)
    End Sub
    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        TabFilter()
    End Sub

    Private Sub TabControl1_TabIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.TabIndexChanged
        TabFilter()
    End Sub
    Public Sub TabFilter()
        If TabControl1.SelectedTab Is TabPage1 Then
            MyDataGridView.Parent = TabPage1
            FilterGeneralTechnicalPerformance()
        ElseIf TabControl1.SelectedTab Is TabPage2 Then
            MyDataGridView.Parent = TabPage2
            FilterOnsiteTechnicalPerformance()
        ElseIf TabControl1.SelectedTab Is TabPage3 Then
            MyDataGridView.Parent = TabPage3
            FilterDailyTransactionLogs()
        ElseIf TabControl1.SelectedTab Is TabPage4 Then
            MyDataGridView.Parent = TabPage4
            FilterBranchTransactionLogs()
        ElseIf TabControl1.SelectedTab Is TabPage5 Then
            MyDataGridView.Parent = TabPage5
            FilterConcernTransactionLogs()
        End If
    End Sub

  
    Private Sub EditChapterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditChapterToolStripMenuItem.Click
        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            If f.ShowDialog() = DialogResult.OK Then
                dst.WriteXml(f.SelectedPath & "\" & LCase(TabControl1.SelectedTab.Text) & ".xls")
                MessageBox.Show("Export done successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub ViewTransactionDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewTransactionDetailsToolStripMenuItem.Click
        Dim filter As String = ""
        If TabControl1.SelectedTab Is TabPage1 Then
            filter = MyDataGridView.Item("IT Personnel", MyDataGridView.CurrentRow.Index).Value().ToString

        ElseIf TabControl1.SelectedTab Is TabPage2 Then
            filter = MyDataGridView.Item("IT Personnel", MyDataGridView.CurrentRow.Index).Value().ToString

        ElseIf TabControl1.SelectedTab Is TabPage3 Then
            filter = MyDataGridView.Item("Date Transaction", MyDataGridView.CurrentRow.Index).Value().ToString

        ElseIf TabControl1.SelectedTab Is TabPage4 Then
            filter = MyDataGridView.Item("Branch", MyDataGridView.CurrentRow.Index).Value().ToString

        ElseIf TabControl1.SelectedTab Is TabPage5 Then
            filter = MyDataGridView.Item("Concern", MyDataGridView.CurrentRow.Index).Value().ToString

        End If
        frmTechnicalHistory.Text = "Transaction Logs of " & filter
        frmTechnicalHistory.txtSearch.Text = filter
        frmTechnicalHistory.Show(Me)
    End Sub
End Class