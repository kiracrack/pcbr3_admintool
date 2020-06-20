Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Drawing.Printing

Public Class frmPLDTOffices
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmPLDTOffices_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FilterOffice()
    End Sub

    Public Sub FilterOffice()
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select id, officename as 'Office', officeaddress as 'Office Address', telnumber as 'Tel Number', accttype as 'Account Type',  acctnumber as 'Account Number', plnumber as 'PL Number', contactperson as 'Contact Person', contactpersonnumber as 'Contact Number',ipaddress as 'IP Address'  from action_query.tblpldtoffice where  officename like '%" & rchar(txtServer.Text) & "%' or officeaddress like '%" & rchar(txtServer.Text) & "%' or telnumber like '%" & rchar(txtServer.Text) & "%' or contactperson like '%" & rchar(txtServer.Text) & "%'  or contactpersonnumber like '%" & rchar(txtServer.Text) & "%' or acctnumber like '%" & rchar(txtServer.Text) & "%' or plnumber like '%" & rchar(txtServer.Text) & "%' order by officename", conn)
        msda.SelectCommand.CommandTimeout = 600000
        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        'MyDataGridView.Columns("Details").Width = 300
        MyDataGridView.Columns("id").Visible = False
        GridColumnAlignment(MyDataGridView, {"Account Type", "Account Number", "PL Number", "IP Address"}, DataGridViewContentAlignment.MiddleCenter)
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

    Private Sub ViewTransactionDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewTransactionDetailsToolStripMenuItem.Click
        frmPLDTReportTransaction.txtServer.Text = MyDataGridView.Item("Office", MyDataGridView.CurrentRow.Index).Value().ToString
        frmPLDTReportTransaction.Show(Me)
    End Sub

    'Private Sub AddNewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewToolStripMenuItem.Click
    '    frmAddNewIP.txtSeriesType.Text = txtSeries.Text
    '    frmAddNewIP.Show(Me)
    'End Sub

    'Private Sub EditIPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditIPToolStripMenuItem.Click
    '    frmAddNewIP.txtSeriesType.Text = txtSeries.Text
    '    frmAddNewIP.officeid.Text = MyDataGridView.Item("officeid", MyDataGridView.CurrentRow.Index).Value().ToString
    '    frmAddNewIP.mode.Text = "edit"
    '    frmAddNewIP.Show(Me)
    'End Sub

    'Private Sub PingTestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PingTestToolStripMenuItem.Click
    '    RunCommandCom("ping " & MyDataGridView.Item("ip", MyDataGridView.CurrentRow.Index).Value().ToString, True, False)
    'End Sub


    'Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs)
    '    FilterIpInventory()
    'End Sub

    'Private Sub txtSeries_SelectedIndexChanged(sender As Object, e As EventArgs)
    '    FilterIpInventory()
    'End Sub

  
    Private Sub cmdPending_Click(sender As Object, e As EventArgs) Handles cmdPending.Click
        frmPLDTnewOffice.Show(Me)
    End Sub

    Private Sub AddNewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewToolStripMenuItem.Click
        cmdPending.PerformClick()
    End Sub

    Private Sub EditIPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditIPToolStripMenuItem.Click
        frmPLDTnewOffice.id.Text = MyDataGridView.Item("id", MyDataGridView.CurrentRow.Index).Value().ToString
        frmPLDTnewOffice.mode.Text = "edit"
        frmPLDTnewOffice.Show(Me)
    End Sub

    Private Sub ReportToPLDTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportToPLDTToolStripMenuItem.Click
        frmPLDTNewReport.officeid.Text = MyDataGridView.Item("id", MyDataGridView.CurrentRow.Index).Value().ToString
        frmPLDTNewReport.txtOfficeName.Text = MyDataGridView.Item("Office", MyDataGridView.CurrentRow.Index).Value().ToString
        frmPLDTNewReport.Show(Me)
    End Sub
End Class