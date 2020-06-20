Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Drawing.Printing

Public Class frmDormantList
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = Keys.Control + Keys.F12 Then
            frmDormantSettings.ShowDialog(Me)
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmPLDTOffices_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If sqlbranchcode <> "" Then
            Me.Text = Me.Text & " (" & UCase(qrysingledata("branchname", "branchname", "master.branches where branchcode='" & sqlbranchcode & "'")) & ")"
        End If
        FilterOffice()
    End Sub

    Public Sub FilterOffice()
        MyDataGridView.DataSource = Nothing : dst2 = New DataSet
        Dim getSystemDate As String = qrysingledata("dt", "date_format(trndate,'%Y-%m-%d') as dt", "syscalendar where forsystem=1")
        msda2 = New MySqlDataAdapter("select (select branchname from master.branches where branchcode =depositaccounts.branchcode) as Branch, acctnumber as 'Account Number', " _
                                                + " (select description from master.depositprod where depcode=depositaccounts.depcode) as 'Product', " _
                                                + " accountname as 'Account Name', (select concat(lname,', ',fname,' ',mname) from master.client where custcode=depositaccounts.signatory1) as 'Signatory', " _
                                                + " (select concat(res_street,', ',res_city,', ',res_province) from master.client where custcode=depositaccounts.signatory1) as 'Address', " _
                                                + " date_format(opendate ,'%Y-%m-%d') as 'Date Open', " _
                                                + " openamount as 'Open Amount', " _
                                                + " currbalance as 'Current Balance', " _
                                                + " date_format(if(lasttransaction='1900-01-01',opendate,lasttransaction),'%Y-%m-%d') as 'Last Transaction', " _
                                                + " DATEDIFF('" & getSystemDate & "',if(lasttransaction='1900-01-01',opendate,lasttransaction)) as 'Day(s) Count', " _
                                                + " if(DATEDIFF('" & getSystemDate & "',if(lasttransaction='1900-01-01',opendate,lasttransaction)) >= term,'DORMANT','ACTIVE') as 'Status' " _
                                                + " from master.depositaccounts inner join action_query.tbldormantsettings on depositaccounts.depcode = tbldormantsettings.depcode " _
                                                + " where dormant=0 and currbalance > 0 and  " _
                                                + " (acctnumber like '%" & rchar(txtSearchBox.Text) & "%' or " _
                                                + " accountname like '%" & rchar(txtSearchBox.Text) & "%' or " _
                                                + " (select description from master.depositprod where depcode=depositaccounts.depcode) like '%" & rchar(txtSearchBox.Text) & "%') " & If(sqlbranchcode = "", "", " and branchcode='" & sqlbranchcode & "' order by DATEDIFF('" & getSystemDate & "',if(lasttransaction='1900-01-01',opendate,lasttransaction)) asc"), conn)
        msda2.SelectCommand.CommandTimeout = 600000
        msda2.Fill(dst2, 0)
        MyDataGridView.DataSource = dst2.Tables(0)
        GridColumnAlignment(MyDataGridView, {"Account Number", "Day(s) Count", "Date Open", "Last Transaction", "Status"}, DataGridViewContentAlignment.MiddleCenter)
        GridColumnAlignment(MyDataGridView, {"Current Balance", "Open Amount"}, DataGridViewContentAlignment.MiddleRight)
        GridCurrencyColumn(MyDataGridView, {"Current Balance", "Open Amount"})
    End Sub
 
    Private Sub txtSearchBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearchBox.KeyPress
        If e.KeyChar() = Chr(13) Then
            FilterOffice()
        End If
    End Sub
 
    Private Sub cmdExport_Click(sender As Object, e As EventArgs) Handles cmdExport.Click
        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            If f.ShowDialog() = DialogResult.OK Then
                dst2.WriteXml(f.SelectedPath & "\" & Me.Text & ".xls")
                MessageBox.Show("Export done successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
End Class