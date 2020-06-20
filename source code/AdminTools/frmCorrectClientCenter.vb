Imports System.Globalization
Imports MySql.Data.MySqlClient

Public Class frmCorrectClientCenter
    Private Sub frmClientCenter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadToComboBox("SELECT * FROM `master`.`userinfo` order by username asc;", "username", "userid", txtClient)
        LoadCenter()
    End Sub
    Private Sub LoadGroup()
        txtGroup.Items.Clear()
        com.CommandText = "select * from master.g_group where centerkey='" & centerkey.Text & "' order by groupname asc" : rst = com.ExecuteReader
        While rst.Read
            txtGroup.Items.Add(New ComboBoxItem(rst("groupname").ToString, rst("groupkey")))
        End While
        rst.Close()
    End Sub

    Private Sub txtGroup_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtGroup.SelectedValueChanged
        groupkey.Text = DirectCast(txtGroup.SelectedItem, ComboBoxItem).HiddenValue()

    End Sub
    Private Sub LoadCenter()
        txtCenter.Items.Clear()
        com.CommandText = "select * from master.g_center order by centername asc" : rst = com.ExecuteReader
        While rst.Read
            txtCenter.Items.Add(New ComboBoxItem(rst("centername").ToString, rst("centerkey")))
        End While
        rst.Close()
    End Sub
    Private Sub txtCenter_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtCenter.SelectedValueChanged
        centerkey.Text = DirectCast(txtCenter.SelectedItem, ComboBoxItem).HiddenValue()
        com.CommandText = "select (select username from master.userinfo where userid=g_center.accountofficer) as ao from master.g_center where centerkey='" & centerkey.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtAccountOfficer.Text = rst("ao").ToString
        End While
        rst.Close()
        LoadGroup()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtrefcode.Text = "" Then
            MsgBox("Please enter loan reference number", vbExclamation)
            txtrefcode.Focus()
            Exit Sub
        ElseIf countqry("master.loanwithterm", "refno='" & txtrefcode.Text & "'") = 0 Then
            MsgBox("Loan accounts not found", vbExclamation)
            txtrefcode.Focus()
            Exit Sub
        ElseIf txtGroup.Text = "" Then
            MsgBox("Please select group", vbExclamation)
            Exit Sub
        ElseIf txtCenter.Text = "" Then
            MsgBox("Please select center", vbExclamation)
            Exit Sub
        ElseIf txtClient.Text = "" Then
            MsgBox("Please select request by", vbExclamation)
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            Dim getBranch As String = qrysingledata("branch", "(select branchname from master.branches where branchcode = master.loanwithterm.branchcode) as 'branch'", "master.loanwithterm  where refno = '" & txtrefcode.Text & "'")
            com.CommandText = "UPDATE master.loanwithterm set centerkey='" & centerkey.Text & "', groupkey='" & groupkey.Text & "' where refno='" & txtrefcode.Text & "'" : com.ExecuteNonQuery()
            com.CommandText = "INSERT into action_query.tbltechnicalreport set branchname='" & StrConv(getBranch, vbProperCase) & "',severitylvl='Normal', requestorname='" & txtClient.Text & "', concern='" & Me.Text & "', actiontaken='Client Name: " & txtName.Text & Chr(13) & "Group: " & txtGroup.Text & Chr(13) & "Center: " & txtCenter.Text & "', performedby='" & GlobalFullname & "', datetrn=current_timestamp" : com.ExecuteNonQuery()
            txtCurrentCenter.Text = "" : txtCurrentGroup.Text = "" : txtName.Text = "" : txtrefcode.Focus() : txtrefcode.SelectAll()
            MsgBox("Center and group successfully corrected", vbInformation)
        End If

    End Sub

    Private Sub txtrefcode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtrefcode.KeyPress
        If e.KeyChar() = Chr(13) Then
            Dim center As String = "" : Dim group As String = ""
            If countqry("master.loanwithterm", "refno='" & txtrefcode.Text & "'") = 0 Then
                txtName.Text = ""
                Button1.Enabled = False
                txtCurrentCenter.Text = ""
                txtCurrentGroup.Text = ""
                MsgBox("No record found", vbExclamation)
            Else
                com.CommandText = "select *,concat(ucase(lname) ,', ', ucase(fname)) as cname from master.client inner join master.loanwithterm on client.custcode = loanwithterm.custcode where refno='" & txtrefcode.Text & "'" : rst = com.ExecuteReader
                If rst.Read Then
                    Button1.Enabled = True
                    txtName.Text = rst("cname").ToString
                    center = rst("centerkey").ToString
                    group = rst("groupkey").ToString
                Else
                    txtName.Text = ""
                    Button1.Enabled = False
                    txtCurrentCenter.Text = ""
                    txtCurrentGroup.Text = ""
                    MsgBox("No record found", vbExclamation)
                End If
                rst.Close()
                If Button1.Enabled = True Then
                    If countqry("master.g_center", "centerkey='" & center & "'") > 0 Then
                        txtCurrentCenter.Text = qrysingledata("center", "concat(centername,' - ',ifnull((select username from master.userinfo where userid=g_center.accountofficer),'NO AO')) as center", "master.g_center where centerkey='" & center & "'")
                    Else
                        txtCurrentCenter.Text = "NO CENTER"
                    End If
                    If countqry("master.g_group", "groupkey='" & group & "'") > 0 Then
                        txtCurrentGroup.Text = qrysingledata("groupname", "groupname", "master.g_group where groupkey='" & group & "'")
                    Else
                        txtCurrentGroup.Text = "NO GROUP"
                    End If
                End If
               
            End If

        End If
    End Sub
     
    Private Sub txtCenter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtCenter.SelectedIndexChanged

    End Sub
End Class
