Imports System.Globalization
Imports MySql.Data.MySqlClient

Public Class frmMBOSetup
    Private Sub frmMBOSetup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBranch()
    End Sub
    Private Sub LoadBranch()
        txtBranch.Items.Clear()
        com.CommandText = "select * from master.branches" : rst = com.ExecuteReader
        While rst.Read
            txtBranch.Items.Add(New ComboBoxItem(rst("branchname").ToString, rst("branchcode")))
        End While
        rst.Close()
    End Sub
    Private Sub txtBranch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtBranch.SelectedIndexChanged
        If txtBranch.Text = "" Then Exit Sub
        FilterMBO(DirectCast(txtBranch.SelectedItem, ComboBoxItem).HiddenValue())
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If countqry("action_query.tblmbosetup", "mbobranchcode='" & txtMBOCode.Text & "'") > 0 Then
            MsgBox("Branch code already exists please try different code", vbCritical)
            Exit Sub
        ElseIf ckMicro.Checked = False And ckRegular.Checked = False Then
            MsgBox("Please check at least one of the product option", vbCritical)
            Exit Sub
        End If
        com.CommandText = "insert into action_query.tblmbosetup set branchcode='" & DirectCast(txtBranch.SelectedItem, ComboBoxItem).HiddenValue() & "', mbobranchcode='" & txtMBOCode.Text & "', mboname='" & rchar(txtMBOName.Text) & "', micro=" & ckMicro.CheckState & ", regular=" & ckRegular.CheckState & "" : com.ExecuteNonQuery()
        FilterMBO(DirectCast(txtBranch.SelectedItem, ComboBoxItem).HiddenValue())
        txtMBOCode.Text = "" : txtMBOName.Text = "" : ckMicro.Checked = False : ckRegular.Checked = False : txtMBOCode.Focus()
    End Sub
    Public Function FilterMBO(ByVal brcode As String)
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select mbobranchcode as 'Code', mboname as 'MBO Name', if(Micro=1,'YES','NO') as 'Micro' from action_query.tblmbosetup where branchcode='" & brcode & "'", conn)
        msda.SelectCommand.CommandTimeout = 600000
        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        GridColumnAlignment(MyDataGridView, {"Code", "Micro"}, DataGridViewContentAlignment.MiddleCenter)
    End Function

    Private Sub AddNewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to remove selected MBO?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            com.CommandText = "DELETE FROM action_query.tblmbosetup where mbobranchcode='" & MyDataGridView.Item("Code", MyDataGridView.CurrentRow.Index).Value().ToString & "'" : com.ExecuteNonQuery()
            FilterMBO(DirectCast(txtBranch.SelectedItem, ComboBoxItem).HiddenValue())

        End If
    End Sub
End Class
