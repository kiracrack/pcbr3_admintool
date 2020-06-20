Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Drawing.Printing

Public Class frmPLDTReportTransaction
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmPLDTOffices_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtdatefrom.Text = Format(Now)
        txtdateto.Text = Format(Now)
        TabFilter()
    End Sub
    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        TabFilter()
    End Sub
    Public Sub TabFilter()
         If TabControl1.SelectedTab Is tabPending Then
            MyDataGridView.Parent = tabPending
            FilterPending()
            cmdCloseReport.Visible = True
            lineseparator.Visible = True
            txtdatefrom.Enabled = False
            txtdateto.Enabled = False
        ElseIf TabControl1.SelectedTab Is tabClose Then
            MyDataGridView.Parent = tabClose
            FilterClosed()
            cmdCloseReport.Visible = False
            lineseparator.Visible = False
            txtdatefrom.Enabled = True
            txtdateto.Enabled = True
        End If
    End Sub
   
    Public Sub FilterPending()
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select id, (select officename from action_query.tblpldtoffice where id = tblpldtreport.officeid) as 'Office',date_format(downdate,'%Y-%m-%d') as 'Down Date', date_format(downtime,'%r') as 'Down Time',incendentnumber as 'Incendent Number', Issue, date_format(reporteddate,'%Y-%m-%d %r') as 'Report Date', reportby as 'Report By',case when upconnection=1 then 'UP' else 'DOWN' end as 'Status',date_format(upconnectiondate,'%Y-%m-%d') as 'UP Date', date_format(upconnectiondate,'%r') as 'UP Time'  from action_query.tblpldtreport where " _
                                    + " closed=0 " _
                                    + " and ((select officename from action_query.tblpldtoffice where id = tblpldtreport.officeid) like '%" & rchar(txtServer.Text) & "%' or " _
                                    + " date_format(downdate,'%Y-%m-%d') like '%" & rchar(txtServer.Text) & "%' or " _
                                    + " downtime like '%" & rchar(txtServer.Text) & "%' or " _
                                    + " incendentnumber like '%" & rchar(txtServer.Text) & "%'  or " _
                                    + " Issue like '%" & rchar(txtServer.Text) & "%' or " _
                                    + " date_format(reporteddate,'%Y-%m-%d %r') like '%" & rchar(txtServer.Text) & "%' or " _
                                    + " reportby like '%" & rchar(txtServer.Text) & "%') order by reporteddate", conn)
        msda.SelectCommand.CommandTimeout = 600000
        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        MyDataGridView.Columns("id").Visible = False
        GridColumnAlignment(MyDataGridView, {"Incendent Number", "Down Date", "Down Time", "UP Date", "UP Time", "Status"}, DataGridViewContentAlignment.MiddleCenter)
    End Sub

    Public Sub FilterClosed()
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select id, (select officename from action_query.tblpldtoffice where id = tblpldtreport.officeid) as 'Office', date_format(downdate,'%Y-%m-%d') as 'Down Date', date_format(downtime,'%r')  as 'Down Time',incendentnumber as 'Incendent Number', Issue, date_format(reporteddate,'%Y-%m-%d %r') as 'Report Date', reportby as 'Report By', case when upconnection=1 then 'UP' else 'DOWN' end as 'Status',date_format(upconnectiondate,'%Y-%m-%d') as 'UP Date', date_format(upconnectiondate,'%r') as 'UP Time',date_format(dateclosed,'%Y-%m-%d') as 'Date Closed', closeby as 'Close By'  from action_query.tblpldtreport where " _
                                    + " closed=1 and ((select officename from action_query.tblpldtoffice where id = tblpldtreport.officeid) like '%" & rchar(txtServer.Text) & "%' or " _
                                    + " date_format(downdate,'%Y-%m-%d') like '%" & rchar(txtServer.Text) & "%' or " _
                                    + " downtime like '%" & rchar(txtServer.Text) & "%' or " _
                                    + " incendentnumber like '%" & rchar(txtServer.Text) & "%'  or " _
                                    + " Issue like '%" & rchar(txtServer.Text) & "%' or " _
                                    + " date_format(reporteddate,'%Y-%m-%d %r') like '%" & rchar(txtServer.Text) & "%' or " _
                                    + " reportby like '%" & rchar(txtServer.Text) & "%') and date_format(reporteddate,'%Y-%m-%d') between '" & ConvertDate(txtdatefrom.Text) & "' and '" & ConvertDate(txtdateto.Text) & "' order by reporteddate", conn)
        msda.SelectCommand.CommandTimeout = 600000
        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        'MyDataGridView.Columns("Issue").Width = 500
        MyDataGridView.Columns("id").Visible = False
        GridColumnAlignment(MyDataGridView, {"Incendent Number", "Down Date", "Down Time", "Up Date", "Up Time", "Status"}, DataGridViewContentAlignment.MiddleCenter)
    End Sub

    Private Sub cmdExportToExcel_Click(sender As Object, e As EventArgs) Handles cmdExportToExcel.Click
        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            If f.ShowDialog() = DialogResult.OK Then
                dst.WriteXml(f.SelectedPath & "\" & Me.Text & ".xls")
                MessageBox.Show("Export done successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub cmdPending_Click(sender As Object, e As EventArgs)
        frmPLDTnewOffice.Show(Me)
    End Sub

    Private Sub EditIPToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmPLDTnewOffice.id.Text = MyDataGridView.Item("id", MyDataGridView.CurrentRow.Index).Value().ToString
        frmPLDTnewOffice.mode.Text = "edit"
        frmPLDTnewOffice.Show(Me)
    End Sub


    Private Sub EditChapterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdCloseReport.Click
        If MessageBox.Show("Are you sure you want to continue? " & Environment.NewLine & Environment.NewLine, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
            For Each rw As DataGridViewRow In MyDataGridView.SelectedRows
                If rw.Cells("Status").Value.ToString = "DOWN" Then
                    com.CommandText = "update action_query.tblpldtreport set upconnection=1, upconnectiondate=current_timestamp, closed=1, closeby='" & GlobalFullname & "',dateclosed=current_timestamp where id='" & rw.Cells("id").Value.ToString & "'" : com.ExecuteNonQuery()
                Else
                    com.CommandText = "update action_query.tblpldtreport set closed=1, closeby='" & GlobalFullname & "',dateclosed=current_timestamp where id='" & rw.Cells("id").Value.ToString & "'" : com.ExecuteNonQuery()
                End If
            Next
            TabFilter()
        End If
    End Sub

   
    Private Sub txtServer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtServer.KeyPress
        If e.KeyChar() = Chr(13) Then
            TabFilter()
        End If
    End Sub

    Private Sub cmdset_Click(sender As Object, e As EventArgs) Handles cmdset.Click
        TabFilter()
    End Sub
End Class