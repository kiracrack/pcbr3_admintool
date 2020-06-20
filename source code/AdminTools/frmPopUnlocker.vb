Imports System.Globalization

Public Class frmPopUnlocker
    Dim showSerach As Boolean = False
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        ElseIf keyData = Keys.F3 Then
            If showSerach = True Then
                txtSearch.Visible = False
                txtSearch.Text = ""
                showSerach = False
            Else
                txtSearch.Visible = True
                txtSearch.Focus()
                showSerach = True
            End If
        End If
        Return ProcessCmdKey
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtClient.Text = "" Then
            MsgBox("Please select request by!", MsgBoxStyle.Critical)
            txtClient.Focus()
            Exit Sub
        End If

        If MessageBox.Show("Are you sure you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            For Each i As Object In ls.CheckedItems
                Dim getBranch As String = qrysingledata("branch", "(select branchname from master.branches where branchcode = master.client.branchcode) as 'branch'", "master.client  where concat('(',custcode,') - ',concat(lname, ', ',fname)) = '" & i.ToString & "'")
                com.CommandText = "UPDATE master.client set trnlocked=0, lockedby='' where concat('(',custcode,') - ',concat(lname, ', ',fname)) = '" & i.ToString & "'" : com.ExecuteNonQuery()
                com.CommandText = "INSERT into action_query.tbltechnicalreport set branchname='" & StrConv(getBranch, vbProperCase) & "', requestorname='" & txtClient.Text & "', concern='" & Me.Text & "', actiontaken='" & i.ToString & "', performedby='" & GlobalFullname & "', datetrn=current_timestamp" : com.ExecuteNonQuery()
            Next
            loadClients()
            MsgBox("client pop successfully Unblock!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub frmLoanAdjustment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadToComboBox("select distinct(lockedby), (select username from master.userinfo where userid = client.lockedby) as name from master.client order by (select username from master.userinfo where userid = client.lockedby) asc ", "name", "lockedby", txtAccounts)
        LoadToComboBox("SELECT * FROM `master`.`userinfo` order by username asc;", "username", "userid", txtClient)
    End Sub
    Public Sub loadClients()
        ls.Items.Clear()
        com.CommandText = "select custcode, concat(lname, ', ',fname) as clientname from master.client where trnlocked=1 and lockedby='" & txtuserid.Text & "' and (custcode like '%" & txtSearch.Text & "%' or lname like '%" & txtSearch.Text & "%' or mname like '%" & txtSearch.Text & "%') order by concat(lname, ', ',fname) asc" : rst = com.ExecuteReader
        While rst.Read
            ls.Items.Add("(" & rst("custcode").ToString & ") - " & LCase(rst("clientname").ToString))
        End While
        rst.Close()
    End Sub
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        loadClients()
    End Sub
    Private Sub ls_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ls.SelectedIndexChanged
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
 
    Private Sub txtAccounts_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtAccounts.SelectedValueChanged
        If txtAccounts.Text <> "" Then
            txtuserid.Text = DirectCast(txtAccounts.SelectedItem, ComboBoxItem).HiddenValue()
        Else
            txtuserid.Text = ""
        End If
        loadClients()
        txtttlclient.Text = "Total Client " & FormatNumber(ls.Items.Count, 0)
    End Sub
End Class
