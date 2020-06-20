Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Drawing.Printing

Public Class frmTechnicalReport
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        ElseIf keyData = (Keys.Enter) Then
            FilterSearch(rchar(txtSearch.Text))
            txtSearch.Focus()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmRequestType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtdatefrom.Text = Format(Now)
        txtdateto.Text = Format(Now)
        TabFilter()
    End Sub

    Public Sub TabFilter()
        If TabControl1.SelectedTab Is TabPage1 Then
            MyDataGridView.Parent = TabPage1
            FilterServiceReports()
            ckPending.Visible = False
            FilterServiceReports()
            cmdEditIssue.Visible = False
            cmdExtendService.Visible = False
        Else
            MyDataGridView.Parent = TabPage2
            ckPending.Visible = True
            FilterTechnicalReports()
            cmdEditIssue.Visible = True
            cmdExtendService.Visible = True
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdset.Click
        TabFilter()
    End Sub

    Public Sub FilterServiceReports()
        msda = New MySqlDataAdapter("select  id,if(branchname = '','Corporate Office',branchname)  as 'Branch', requestorname as 'Request By', Concern,severitylvl as 'Severity Level', actiontaken as 'Details',performedby as 'Performed By', datetrn as 'Date Performed' from action_query.tbltechnicalreport where " & If(GlobalLimited = True, "performedby in (select itname from action_query.tbltechnicalsupport where limited=1) and ", "") & " date_format(datetrn,'%Y-%m-%d') between '" & ConvertDate(txtdatefrom.Text) & "' and '" & ConvertDate(txtdateto.Text) & "';", conn)
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        MyDataGridView.Columns("Details").Width = 300
        MyDataGridView.Columns("id").Visible = False

        MyDataGridView.Columns("Details").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        MyDataGridView.Columns("Details").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        MyDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
    End Sub

    Public Sub FilterTechnicalReports()
        If ckPending.Checked = True Then
            msda = New MySqlDataAdapter("select  id, timeframe,ticketno as 'Ticket No.', if(branchname = '','Corporate Office',branchname)  as 'Branch', requestorname as 'Request By', Concern,severitylvl as 'Severity Level', actiontaken as 'Details',performedby as 'Recorded  by', datetrn as 'Date Recorded', techsupport as 'Technical Person', case when timeframe is null then 'No Expiration' when timeframe > current_date and pending=1 then cast(concat(datediff(timeframe,current_timestamp), ' day(s) left') as char(100)) when timeframe = current_date and pending=1 then 'Today' when timeframe < current_date and pending=1 then 'Over Due' when pending=0 then 'Close' end as 'TimeFrame Remaining' from action_query.tbltechnicalreport where " & If(GlobalLimited = True, "performedby in (select itname from action_query.tbltechnicalsupport where limited=1) and ", "") & " pending=" & ckPending.CheckState & " and ontechnical=1;", conn)
        Else
            msda = New MySqlDataAdapter("select  id, timeframe,ticketno as 'Ticket No.', if(branchname = '','Corporate Office',branchname)  as 'Branch', requestorname as 'Request By', Concern,severitylvl as 'Severity Level', actiontaken as 'Details',performedby as 'Recorded  by', datetrn as 'Date Recorded', techsupport as 'Technical Person', case when timeframe is null then 'No Expiration' when timeframe > current_date and pending=1 then cast(concat(datediff(timeframe,current_timestamp), ' day(s) left') as char(100)) when timeframe = current_date and pending=1 then 'Today' when timeframe < current_date and pending=1 then 'Over Due' when pending=0 then 'Resolved Issue' end as 'TimeFrame Remaining', remarks as 'Remarks',dateclose as 'Date Closed'  from action_query.tbltechnicalreport where " & If(GlobalLimited = True, "performedby in (select itname from action_query.tbltechnicalsupport where limited=1) and ", "") & " pending=" & ckPending.CheckState & " and ontechnical=1 and date_format(dateclose,'%Y-%m-%d') between '" & ConvertDate(txtdatefrom.Text) & "' and '" & ConvertDate(txtdateto.Text) & "';", conn)
        End If

        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        MyDataGridView.Columns("Details").Width = 300

        If ckPending.Checked = False Then
            MyDataGridView.Columns("Remarks").Width = 400
            MyDataGridView.Columns("Remarks").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            MyDataGridView.Columns("Remarks").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        End If

        MyDataGridView.Columns("id").Visible = False
        MyDataGridView.Columns("timeframe").Visible = False
        MyDataGridView.Columns("Ticket No.").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        MyDataGridView.Columns("Ticket No.").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        MyDataGridView.Columns("Details").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        MyDataGridView.Columns("Details").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        MyDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
    End Sub
    Public Function FilterSearch(ByVal keyword As String)
        If txtSearch.Text = "" Then Return False
        TabControl1.SelectedTab = TabPage3
        MyDataGridView.Parent = TabPage3
        msda = New MySqlDataAdapter("select  id, timeframe,ticketno as 'Ticket No.', if(branchname = '','Corporate Office',branchname)  as 'Branch', requestorname as 'Request By', Concern,severitylvl as 'Severity Level', actiontaken as 'Details',performedby as 'Recorded  by', datetrn as 'Date Recorded', techsupport as 'Technical Person', case when timeframe is null then 'No Expiration' when timeframe > current_date and pending=1 then cast(concat(datediff(timeframe,current_timestamp), ' day(s) left') as char(100)) when timeframe = current_date and pending=1 then 'Today' when timeframe < current_date and pending=1 then 'Over Due' when pending=0 then 'Resolved Issue' end as 'TimeFrame Remaining', remarks as 'Remarks',dateclose as 'Date Closed'  from action_query.tbltechnicalreport where " & If(GlobalLimited = True, "performedby in (select itname from action_query.tbltechnicalsupport where limited=1) and ", "") & " (ticketno like '%" & keyword & "%' or branchname like '%" & keyword & "%' or requestorname like '%" & keyword & "%' or concern like '%" & keyword & "%' or actiontaken like '%" & keyword & "%' or severitylvl like '%" & keyword & "%' or performedby like '%" & keyword & "%' or techsupport like '%" & keyword & "%' or remarks like '%" & keyword & "%');", conn)
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        MyDataGridView.Columns("Details").Width = 300

        MyDataGridView.Columns("Remarks").Width = 400
        MyDataGridView.Columns("Remarks").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        MyDataGridView.Columns("Remarks").DefaultCellStyle.WrapMode = DataGridViewTriState.True

        MyDataGridView.Columns("id").Visible = False
        MyDataGridView.Columns("timeframe").Visible = False
        MyDataGridView.Columns("Ticket No.").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        MyDataGridView.Columns("Ticket No.").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        MyDataGridView.Columns("Details").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        MyDataGridView.Columns("Details").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        MyDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        Return 0
    End Function


    Private Sub EditChapterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdEditIssue.Click
        frmResolveIssue.id.Text = MyDataGridView.Item("id", MyDataGridView.CurrentRow.Index).Value().ToString
        frmResolveIssue.Show(Me)
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        TabFilter()
    End Sub

    Private Sub ExtendServiceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdExtendService.Click
        frmExtendIssue.id.Text = MyDataGridView.Item("id", MyDataGridView.CurrentRow.Index).Value().ToString
        frmExtendIssue.txtDateTarget.MinDate = MyDataGridView.Item("timeframe", MyDataGridView.CurrentRow.Index).Value().ToString
        frmExtendIssue.Show(Me)
    End Sub

    Private Sub ckPending_CheckedChanged(sender As Object, e As EventArgs) Handles ckPending.CheckedChanged
        If ckPending.Checked = True Then
            MyDataGridView.ContextMenuStrip = cms_em
        Else
            MyDataGridView.ContextMenuStrip = Nothing
        End If
    End Sub
 
    Private Sub ExportToExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportToExcelToolStripMenuItem.Click
        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            If f.ShowDialog() = DialogResult.OK Then
                dst.WriteXml(f.SelectedPath & "\" & LCase(Me.Text) & " " & txtdatefrom.Text & " - " & txtdateto.Text & ".xls")
                MessageBox.Show("Export done successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
End Class