Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Drawing.Printing
Imports MSTSCLib

Public Class frmNetworkIPInventory
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmRequestType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadComboData()
        FilterIpInventory()
    End Sub
    Public Sub LoadComboData()
        LoadToComboBoxPre("select * from action_query.tblipinventory order by officename asc", "officename", "officeid", txtOffice)
    End Sub
    Private Sub txtOffice_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtOffice.SelectedValueChanged
        officeid.Text = DirectCast(txtOffice.SelectedItem, ComboBoxItem).HiddenValue()
        FilterIpInventory()
    End Sub
    Public Sub FilterIpInventory()
        msda = New MySqlDataAdapter("select id,if(encryptpassword=1,'YES','NO') as 'EncryptPassword', accountable as 'Accountable Person',Position, ipaddress as 'IP Address' , Username, if(encryptpassword=1,'(Encrypted)',Password) as 'Password', password as 'Encrypted Password' from action_query.tblipnetworks where  officeid='" & officeid.Text & "' and (accountable like '%" & rchar(txtSearch.Text) & "%' or ipaddress like '%" & rchar(txtSearch.Text) & "%') order by iporder asc", conn)
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda.SelectCommand.CommandTimeout = 600000
        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)

        For Each valueArr In MyDataGridView.Columns
            valueArr.SortMode = DataGridViewColumnSortMode.NotSortable
        Next

        MyDataGridView.Columns("id").Visible = False : MyDataGridView.Columns("EncryptPassword").Visible = False : MyDataGridView.Columns("Encrypted Password").Visible = False
        GridColumnAlignment(MyDataGridView, {"IP Address", "Username", "Password"}, DataGridViewContentAlignment.MiddleCenter)
    End Sub

    Private Sub cmdExportToExcel_Click(sender As Object, e As EventArgs) Handles cmdExportToExcel.Click
        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            If f.ShowDialog() = DialogResult.OK Then
                dst.WriteXml(f.SelectedPath & "\" & txtSearch.Text & ".xls")
                MessageBox.Show("Export done successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub ViewTransactionDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'Filter = MyDataGridView.Item("Concern", MyDataGridView.CurrentRow.Index).Value().ToString
        'frmTechnicalHistory.Text = "Transaction Logs of " & Filter()
        'frmTechnicalHistory.txtSearch.Text = Filter()
        'frmTechnicalHistory.Show(Me)
    End Sub

    Private Sub AddNewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewToolStripMenuItem.Click
        If txtOffice.Text = "" Then
            MsgBox("Please select office", vbExclamation)
            txtOffice.Focus()
            Exit Sub
        End If
        frmAddNetworksIP.officeid.Text = officeid.Text
        frmAddNetworksIP.Show(Me)
    End Sub

    Private Sub EditIPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditIPToolStripMenuItem.Click
        frmAddNetworksIP.id.Text = MyDataGridView.Item("id", MyDataGridView.CurrentRow.Index).Value().ToString
        frmAddNetworksIP.mode.Text = "edit"
        frmAddNetworksIP.Show(Me)
    End Sub

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        If e.KeyChar() = Chr(13) Then
            If txtSearch.Text = "" Then Exit Sub
            FilterIpInventory()
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        RunCommandCom("ping " & MyDataGridView.Item("IP Address", MyDataGridView.CurrentRow.Index).Value().ToString, True, False)
    End Sub

    Private Sub txtSeries_SelectedIndexChanged(sender As Object, e As EventArgs)
        FilterIpInventory()
    End Sub

    Private Sub ConnectRemoteDecktopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConnectRemoteDecktopToolStripMenuItem.Click
        Dim password As String = ""
        If MyDataGridView.Item("EncryptPassword", MyDataGridView.CurrentRow.Index).Value().ToString = "YES" Then
            password = DecryptTripleDES(MyDataGridView.Item("Encrypted Password", MyDataGridView.CurrentRow.Index).Value().ToString)
        Else
            password = MyDataGridView.Item("Encrypted Password", MyDataGridView.CurrentRow.Index).Value().ToString
        End If
        RunCommandCom("mstsc /v:" & MyDataGridView.Item("IP Address", MyDataGridView.CurrentRow.Index).Value().ToString & ":" & MyDataGridView.Item("Port", MyDataGridView.CurrentRow.Index).Value().ToString & " /f /admin", False, True)
        
    End Sub

    Private Sub OpenShareFoldersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenShareFoldersToolStripMenuItem.Click
        Process.Start("\\" & MyDataGridView.Item("IP Address", MyDataGridView.CurrentRow.Index).Value().ToString & "")
    End Sub

    Private Sub RemoveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to remove selected office? NOTE: all connected ip address will also remove?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            com.CommandText = "DELETE FROM action_query.tblipnetworks where id='" & MyDataGridView.Item("id", MyDataGridView.CurrentRow.Index).Value().ToString & "'" : com.ExecuteNonQuery()
            FilterIpInventory()
            MsgBox("IP successfully removed", MsgBoxStyle.Information)
        End If
    End Sub
End Class