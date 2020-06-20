Imports System.Globalization

Public Class frmClearLog
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        loadLoggedaccounts()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MessageBox.Show("Are you sure you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            For Each i As Object In ls.CheckedItems
                com.CommandText = "UPDATE master.userinfo set login='N',block=false,blockdesc='',blockedby='',blocklevel=''  where concat('(',userid,') - ',lcase(username)) = '" & i.ToString & "'" : com.ExecuteNonQuery()
                Dim getBranch As String = qrysingledata("branch", "(select branchname from master.branches where branchcode = master.userinfo.branchcode) as 'branch'", "master.userinfo  where concat('(',userid,') - ',lcase(username)) = '" & i.ToString & "'")
                com.CommandText = "INSERT into action_query.tbltechnicalreport set branchname='" & StrConv(getBranch, vbProperCase) & "', requestorname='" & i.ToString & "', concern='" & Me.Text & "', actiontaken='" & i.ToString & "', performedby='" & GlobalFullname & "', datetrn=current_timestamp" : com.ExecuteNonQuery()
            Next
            loadLoggedaccounts()
            MsgBox("Selected user(s) successfully cleared!", MsgBoxStyle.Information)
        End If
    End Sub


    Public Sub loadLoggedaccounts()
        ls.Items.Clear()
        com.CommandText = "select * from master.userinfo where (login='Y' or (block=1 and blocklevel=1)) and (userid like '%" & txtSearch.Text & "%' or username like '%" & txtSearch.Text & "%' or (select branchname from master.branches where branchcode = userinfo.branchcode) like '%" & txtSearch.Text & "%') order by username asc" : rst = com.ExecuteReader
        While rst.Read
            ls.Items.Add("(" & rst("userid").ToString & ") - " & LCase(rst("username").ToString))

        End While
        rst.Close()
        ' ls.SetItemCheckState(1, CheckState.Indeterminate)
    End Sub

    Private Sub ls_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ls.SelectedIndexChanged, ls.ItemCheck
        If ls.CheckedItems.Count > 0 Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        For i = 0 To ls.Items.Count - 1
            If CheckBox1.Checked = True Then
                ls.SetItemCheckState(i, CheckState.Checked)
                Button1.Enabled = True
            Else
                ls.SetItemCheckState(i, CheckState.Unchecked)
                Button1.Enabled = False
            End If
        Next
    End Sub

    Private Sub frmUnblockClearLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadLoggedaccounts()
    End Sub
End Class
