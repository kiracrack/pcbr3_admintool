Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Drawing.Printing

Public Class frmIPInventory
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmRequestType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FilterIpInventory()
    End Sub

    Public Sub FilterIpInventory()
        msda = New MySqlDataAdapter("select officeid, officename as 'Office', concat(ip1,'.',ip2,'.',ip3,'.',ip4,' - ',ip5) as 'IP Address', concat(ip1,'.',ip2,'.',ip3,'.',ip4+1) as ip from action_query.tblipinventory where  (officename like '%" & rchar(txtSearch.Text) & "%' or concat(ip1,'.',ip2,'.',ip3,'.',ip4) like '%" & rchar(txtSearch.Text) & "%') order by officename", conn)
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda.SelectCommand.CommandTimeout = 600000
        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        'MyDataGridView.Columns("Details").Width = 300
        MyDataGridView.Columns("officeid").Visible = False : MyDataGridView.Columns("ip").Visible = False
        GridColumnAlignment(MyDataGridView, {"IP Address"}, DataGridViewContentAlignment.MiddleCenter)
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
        frmNetworkIPInventory.officeid.Text = MyDataGridView.Item("officeid", MyDataGridView.CurrentRow.Index).Value().ToString
        frmNetworkIPInventory.Show(Me)
        frmNetworkIPInventory.txtOffice.Text = MyDataGridView.Item("Office", MyDataGridView.CurrentRow.Index).Value().ToString
    End Sub

    Private Sub AddNewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewToolStripMenuItem.Click
        frmAddNewIP.Show(Me)
    End Sub

    Private Sub EditIPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditIPToolStripMenuItem.Click
        frmAddNewIP.officeid.Text = MyDataGridView.Item("officeid", MyDataGridView.CurrentRow.Index).Value().ToString
        frmAddNewIP.mode.Text = "edit"
        frmAddNewIP.Show(Me)
    End Sub

    Private Sub PingTestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PingTestToolStripMenuItem.Click
        RunCommandCom("ping " & MyDataGridView.Item("ip", MyDataGridView.CurrentRow.Index).Value().ToString, True, False)
    End Sub

   
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        FilterIpInventory()
    End Sub

    Private Sub txtSeries_SelectedIndexChanged(sender As Object, e As EventArgs)
        FilterIpInventory()
    End Sub

    Private Sub RemoveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to remove selected office? NOTE: all connected ip address will also remove?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            com.CommandText = "DELETE FROM action_query.tblipinventory where officeid='" & MyDataGridView.Item("officeid", MyDataGridView.CurrentRow.Index).Value().ToString & "'" : com.ExecuteNonQuery()
            com.CommandText = "DELETE FROM action_query.tblipnetworks where officeid='" & MyDataGridView.Item("officeid", MyDataGridView.CurrentRow.Index).Value().ToString & "'" : com.ExecuteNonQuery()
            FilterIpInventory()
            MsgBox("Office successfully removed", MsgBoxStyle.Information)
        End If
    End Sub
End Class