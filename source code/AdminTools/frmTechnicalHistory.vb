Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Drawing.Printing

Public Class frmTechnicalHistory
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmRequestType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FilterSearch()
    End Sub

    Public Function FilterSearch()
        If txtSearch.Text = "" Then Return False
        msda = New MySqlDataAdapter("select  if(branchname = '','Corporate Office',branchname)  as 'Branch', requestorname as 'Request By', Concern,severitylvl as 'Severity Level', actiontaken as 'Details',performedby as 'Recorded  by', date_format(datetrn,'%Y-%m-%d %r') as 'Date Recorded', case when ontechnical=1 then 'Yes' else 'No' end as 'Onsite Technical', techsupport as 'Technical Person', case when timeframe is null then '' else if(datediff(dateclose,datetrn)=0,TIMEDIFF(dateclose,datetrn),concat(datediff(dateclose,datetrn),' Day(s)')) end as 'Time Frame', remarks as 'Remarks',dateclose as 'Date Closed'  from action_query.tbltechnicalreport where " & If(GlobalLimited = True, "performedby in (select itname from action_query.tbltechnicalsupport where limited=1) and ", "") & " (ticketno like '%" & txtSearch.Text & "%' or branchname like '%" & txtSearch.Text & "%' or requestorname like '%" & txtSearch.Text & "%' or concern like '%" & txtSearch.Text & "%' or actiontaken like '%" & txtSearch.Text & "%' or severitylvl like '%" & txtSearch.Text & "%' or performedby like '%" & txtSearch.Text & "%' or techsupport like '%" & txtSearch.Text & "%' or remarks like '%" & txtSearch.Text & "%' or date_format(datetrn,'%Y-%m-%d') like '%" & txtSearch.Text & "%');", conn)
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        MyDataGridView.Columns("Details").Width = 300

        GridColumnAlignment(MyDataGridView, {"Onsite Technical", "Time Frame"}, DataGridViewContentAlignment.MiddleCenter)
        MyDataGridView.Columns("Remarks").Width = 400
        MyDataGridView.Columns("Remarks").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        MyDataGridView.Columns("Remarks").DefaultCellStyle.WrapMode = DataGridViewTriState.True
 
        MyDataGridView.Columns("Details").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        MyDataGridView.Columns("Details").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        MyDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        Return 0
    End Function


    Private Sub EditChapterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditChapterToolStripMenuItem.Click
        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            If f.ShowDialog() = DialogResult.OK Then
                dst.WriteXml(f.SelectedPath & "\" & LCase(Me.Text) & ".xls")
                MessageBox.Show("Export done successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub

   

End Class