Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Drawing.Printing

Public Class frmUserAccounts
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        ElseIf keyData = Keys.Control + Keys.C Then
            Clipboard.SetDataObject(Me.MyDataGridView.GetClipboardContent())
        End If
        Return ProcessCmdKey
    End Function

    Public Sub FilterUserAccounts()
        dst = New DataSet
        msda = New MySqlDataAdapter("select userid as 'User ID', ucase(REPLACE(username,'_',' ')) as 'Account Name', (select branchname from master.branches where branchcode = userinfo.branchcode) as 'Branch', " _
                                        + " case when login ='Y' then 'Currently Logged' else '-' end as 'Login Status', case when block = 1 then 'Yes' else 'No' end as 'Blocked', blockdesc as 'Blocked Remarks', if(defaultpassword is null,'Not Set','Done') as 'Default Password', " _
                                        + " case when (datepasswordexpiry is null) then '-' when accesscode <> defaultpassword then 'Changed' when accesscode = defaultpassword then 'Not Change' end as 'Password Status',if(maintainancemode=1,'Maintainance Mode','-') as 'Block Type'  from master.userinfo where (userid like '%" & rchar(txtSearch.Text) & "%' or username  like '%" & rchar(txtSearch.Text) & "%' or (select branchname from master.branches where branchcode = userinfo.branchcode) like '%" & rchar(txtSearch.Text) & "%') and block=" & CheckBox1.CheckState & " order by username asc ", conn)
        MyDataGridView.DataSource = Nothing
        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        'MyDataGridView.Columns("Details").Width = 300
        'MyDataGridView.Columns("id").Visible = False
        GridColumnAlignment(MyDataGridView, {"User ID", "Login Status", "Blocked", "Default Password", "Block Type"}, DataGridViewContentAlignment.MiddleCenter)
    End Sub

    Private Sub MyDataGridView_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles MyDataGridView.CellFormatting
        Dim status As String = MyDataGridView.Item("Blocked", e.RowIndex).Value().ToString
        Dim pass As String = MyDataGridView.Item("Password Status", e.RowIndex).Value().ToString
        'If status = "Yes" Then
        '    MyDataGridView.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Red
        'End If
        If pass = "Not Change" Then
            MyDataGridView.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Red
        Else
            MyDataGridView.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black
        End If
    End Sub

    'Private Sub MyDataGridView_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles MyDataGridView.CellMouseDown
    '    If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
    '        Me.MyDataGridView.CurrentCell = Me.MyDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex)
    '    End If
    'End Sub

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        If txtSearch.Text = "" Then Exit Sub
        If e.KeyChar = Chr(13) Then
            FilterUserAccounts()
        End If
    End Sub

    Public Function BlockUser(ByVal reason As String, ByVal authid As String, ByVal requestby As String, ByVal maintainancemode As Boolean)
        For Each rw As DataGridViewRow In MyDataGridView.SelectedRows
            If rw.Cells("Blocked").Value.ToString = "No" Then

                Dim maintainance As String = ""
                If maintainancemode = True Then
                    maintainance = " ,maintainancemode=1 "
                End If

                com.CommandText = "update userinfo set block=1, blockdesc='" & rchar(reason) & "', blockedby='" & authid & "', blocklevel=2 " & maintainance & " where userid='" & rw.Cells("User ID").Value.ToString & "'" : com.ExecuteNonQuery()
                com.CommandText = "INSERT into action_query.tbltechnicalreport set branchname='" & StrConv(rw.Cells("Branch").Value.ToString, vbProperCase) & "', requestorname='" & requestby & "', concern='Blocked User', actiontaken='" & rw.Cells("User ID").Value.ToString & " - " & rw.Cells("Account Name").Value.ToString & Environment.NewLine & reason & "', performedby='" & GlobalFullname & "', datetrn=current_timestamp" : com.ExecuteNonQuery()
            End If
        Next
        FilterUserAccounts()
        MsgBox("Selected users successfully blocked!", MsgBoxStyle.Information)
        Return 0
    End Function
    Public Function ChangeBranch(ByVal to_branchcode As String, ByVal reason As String)
        For Each rw As DataGridViewRow In MyDataGridView.SelectedRows
            If rw.Cells("Blocked").Value.ToString = "No" Then
                com.CommandText = "update master.userinfo set branchcode='" & to_branchcode & "' where userid='" & rw.Cells("User ID").Value.ToString & "'" : com.ExecuteNonQuery()

                Dim getBranch As String = qrysingledata("branchname", " branchname", "master.branches where branchcode = '" & to_branchcode & "'")
                com.CommandText = "INSERT into action_query.tbltechnicalreport set branchname='" & StrConv(rw.Cells("Branch").Value.ToString, vbProperCase) & "', requestorname='" & StrConv(rw.Cells("Account Name").Value.ToString, vbProperCase) & "', concern='Change Branch', actiontaken='Change branch from " & StrConv(rw.Cells("Branch").Value.ToString, vbProperCase) & " to " & getBranch & Environment.NewLine & "Reason: " & reason & "', performedby='" & GlobalFullname & "', datetrn=current_timestamp" : com.ExecuteNonQuery()
            End If
        Next
        FilterUserAccounts()
        MsgBox("Selected users successfully change!", MsgBoxStyle.Information)
        Return 0
    End Function
    Public Function UnblockUser()
        For Each rw As DataGridViewRow In MyDataGridView.SelectedRows
            If rw.Cells("Blocked").Value.ToString = "Yes" Then
                com.CommandText = "update userinfo set block=0, blockdesc='', blockedby='', blocklevel='',maintainancemode=0 where userid='" & rw.Cells("User ID").Value.ToString & "'" : com.ExecuteNonQuery()
                com.CommandText = "INSERT into action_query.tbltechnicalreport set branchname='" & StrConv(rw.Cells("Branch").Value.ToString, vbProperCase) & "', requestorname='" & rw.Cells("Account Name").Value.ToString & "', concern='Unblocked User', actiontaken='" & rw.Cells("User ID").Value.ToString & " - " & rw.Cells("Account Name").Value.ToString & Environment.NewLine & "', performedby='" & GlobalFullname & "', datetrn=current_timestamp" : com.ExecuteNonQuery()
            End If
        Next
        FilterUserAccounts()
        MsgBox("Selected users successfully Unblocked!", MsgBoxStyle.Information)
        Return 0
    End Function

    Private Sub BlockUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlockUserToolStripMenuItem.Click
        frmBlockUser.ShowDialog()
    End Sub

    Private Sub EditChapterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditChapterToolStripMenuItem.Click
        frmResetPassword.txtUserID.Text = MyDataGridView.Item("User ID", MyDataGridView.CurrentRow.Index).Value().ToString
        frmResetPassword.Text = MyDataGridView.Item("Account Name", MyDataGridView.CurrentRow.Index).Value().ToString
        frmResetPassword.Show(Me)
    End Sub

    Public Function ResetPassword()
        Dim cnt As Integer = 0
        For Each rw As DataGridViewRow In MyDataGridView.SelectedRows
            If rw.Cells("Blocked").Value.ToString = "No" Or rw.Cells("Default Password").Value.ToString <> "Not Set" Then
                com.CommandText = "update userinfo set accesscode=defaultpassword, datepasswordexpiry=date_format(current_date + interval 1 day,'%Y-%m-%d') where userid='" & rw.Cells("User ID").Value.ToString & "'" : com.ExecuteNonQuery()
                If MyDataGridView.SelectedRows.Count = 1 Then
                    com.CommandText = "INSERT into action_query.tbltechnicalreport set branchname='" & rw.Cells("Branch").Value.ToString & "', requestorname='" & rw.Cells("Account Name").Value.ToString & "', concern='Reset Password', actiontaken='" & rw.Cells("Account Name").Value.ToString & "', performedby='" & GlobalFullname & "', datetrn=current_timestamp" : com.ExecuteNonQuery()
                End If
                cnt = cnt + 1
            End If
        Next
        FilterUserAccounts()
        If cnt = 0 Then
            MsgBox("No account default password found!", MsgBoxStyle.Exclamation)
        Else
            If MyDataGridView.SelectedRows.Count > 1 Then
                com.CommandText = "INSERT into action_query.tbltechnicalreport set branchname='ALL', requestorname='ALL', concern='Reset Password', actiontaken='Memo Number# IT-20140909" & Environment.NewLine & "Subject: PCBR3 Password Reset', performedby='" & GlobalFullname & "', datetrn=current_timestamp" : com.ExecuteNonQuery()
            End If
            MsgBox("Selected users password successfully reset!", MsgBoxStyle.Information)
        End If
        Return 0
    End Function

    'Private Sub SetDefaultPasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetDefaultPasswordToolStripMenuItem.Click
    '    If MessageBox.Show("Are you sure you want to continue? " & Environment.NewLine & Environment.NewLine & "Note: Default password depending on system default password", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
    '        SetDefaultPassword()
    '    End If
    'End Sub

    Public Function SetDefaultPassword()
        Dim cnt As Integer = 0
        For Each rw As DataGridViewRow In MyDataGridView.SelectedRows
            If rw.Cells("Blocked").Value.ToString = "No" Then
                com.CommandText = "update userinfo set defaultpassword=accesscode  where userid='" & rw.Cells("User ID").Value.ToString & "'" : com.ExecuteNonQuery()
                cnt = cnt + 1
            End If
        Next
        FilterUserAccounts()
        If cnt = 0 Then
            MsgBox("No account default password found!", MsgBoxStyle.Exclamation)
        Else
            com.CommandText = "INSERT into action_query.tbltechnicalreport set branchname='Corporate Office', requestorname='Administrator', concern='Set Current Default Password', actiontaken='System Settings', performedby='" & GlobalFullname & "', datetrn=current_timestamp" : com.ExecuteNonQuery()
            MsgBox("Selected users password successfully set as default!", MsgBoxStyle.Information)
        End If
        Return 0
    End Function

    Private Sub UnblockUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnblockUserToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            UnblockUser()
        End If
    End Sub

    Private Sub ChangeBranchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeBranchToolStripMenuItem.Click
        frmChangeBranch.ShowDialog(Me)
    End Sub

    Private Sub ExportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportToolStripMenuItem.Click
        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            If f.ShowDialog() = DialogResult.OK Then
                dst.WriteXml(f.SelectedPath & "\" & LCase(Me.Text) & " " & If(CheckBox1.Checked = True, "(Blocked users)", "(Actived users)") & ".xls")
                MessageBox.Show("Export done successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub frmUserAccounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If GlobalLimited = True Then
            MyDataGridView.ContextMenuStrip = Nothing
        Else
            MyDataGridView.ContextMenuStrip = cms_em
        End If
    End Sub
End Class