Imports System.Globalization

Public Class frmClearingSavings
    Dim showSerach As Boolean = False
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        If txtSearch.Text = "" Or txtSearch.Text = " " Then Exit Sub
        If e.KeyChar = Chr(13) Then
            loadLoggedaccounts()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtClient.Text = "" Then
            MsgBox("Please select request by!", MsgBoxStyle.Critical)
            txtClient.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            For Each itm As ListViewItem In ListView1.Items
                If itm.Checked Then
                    com.CommandText = "update master.depositaccounts set trnlocked=false,trnlockedby='',trnlockdesc='' where acctnumber  like '" & rchar(itm.SubItems(1).Text) & "' limit 1;" : com.ExecuteNonQuery()

                    Dim getBranch As String = qrysingledata("branch", "(select branchname from master.branches where branchcode = master.depositaccounts.branchcode) as 'branch'", "master.depositaccounts  where acctnumber = '" & rchar(itm.SubItems(1).Text) & "'")
                    com.CommandText = "INSERT into action_query.tbltechnicalreport set branchname='" & StrConv(getBranch, vbProperCase) & "', requestorname='" & txtClient.Text & "', concern='" & Me.Text & "', actiontaken='" & rchar(itm.SubItems(0).Text) & "', performedby='" & GlobalFullname & "', datetrn=current_timestamp" : com.ExecuteNonQuery()
                End If
            Next
            loadLoggedaccounts()
            MsgBox("Selected account successfully cleared!", MsgBoxStyle.Information)
        End If
    End Sub


    Public Sub loadLoggedaccounts()
        ListView1.Items.Clear()
        com.CommandText = "select * from master.depositaccounts  where trnlocked=1 and (accountname like '%" & If(CheckBox1.Checked = True, "return true", "return true") & "%' or acctnumber like '%" & txtSearch.Text & "%' or (select username from master.userinfo where userid = depositaccounts.trnlockedby) like '%" & LCase(txtSearch.Text).Replace("locked by ", "") & "%') order by accountname asc" : rst = com.ExecuteReader
        While rst.Read
            Dim item1 As New ListViewItem("(" & rst("acctnumber").ToString & ") - " & UCase(rst("accountname").ToString), 0)
            item1.SubItems.Add(rst("acctnumber").ToString)
            ListView1.Items.AddRange(New ListViewItem() {item1})
        End While
        rst.Close()
    End Sub


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            For Each itm As ListViewItem In ListView1.Items
                itm.Checked = True
            Next
        Else
            For Each itm As ListViewItem In ListView1.Items
                itm.Checked = False
            Next
        End If

    End Sub

    Private Sub frmUnblockClearLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.View = View.Details
        ListView1.Columns.Add("Category", -2, HorizontalAlignment.Left)
        ListView1.Columns.Add("id", -2, HorizontalAlignment.Left)
        ListView1.Columns(0).Width = 280
        ListView1.Columns(1).Width = 0
        LoadToComboBox("SELECT * FROM `master`.`userinfo` order by username asc;", "username", "userid", txtClient)
        'loadLoggedaccounts()
    End Sub

    Private Sub ListView1_ItemChecked(sender As Object, e As ItemCheckedEventArgs) Handles ListView1.ItemChecked
        If ListView1.CheckedItems.Count > 0 Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If
    End Sub


End Class
