Imports System.Globalization
Imports System.IO

Public Class frmCentralExecuteBackup
    Dim showSerach As Boolean = False
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function

    Public Sub LoadConnection()
        Dim path As String = Application.StartupPath.ToString & "\Connection"
        ls.Items.Clear()
        For Each file As String In System.IO.Directory.GetFiles(path)
            ls.Items.Add(UCase(System.IO.Path.GetFileNameWithoutExtension(file)))
        Next
    End Sub

    Private Sub frmUnblockClearLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadServerConnection()
    End Sub
    Public Sub LoadServerConnection()
        ls.Items.Clear()
        If System.IO.File.Exists(file_central_live) = True Then
            Dim sr As StreamReader = File.OpenText(file_central_live)
            Dim br As String = sr.ReadToEnd : sr.Close()
            For Each word In br.Split(New Char() {","c})
                OpenCentralServer(file_conn_dir & "\" & word.Replace(vbCrLf, ""))

                If connclient.State = ConnectionState.Open Then
                    comclient.CommandText = "CREATE DATABASE IF NOT EXISTS file_loans;" : comclient.ExecuteNonQuery()
                    comclient.CommandText = "CREATE DATABASE IF NOT EXISTS file_deposit;" : comclient.ExecuteNonQuery()
                    Dim systemdate As String = qrysingledataClient("dt", "date_format(trndate,'%Y%m%d') as dt", "master.syscalendar where forsystem=1 and openfortrn=0")
                    If systemdate <> "" Then
                        If countqryClient("information_schema.tables", "table_schema = 'file_loans' AND table_name = 'ln" & systemdate & "'") = 0 And countqryClient("information_schema.tables", "table_schema = 'file_deposit' AND table_name = 'dp" & systemdate & "'") = 0 Then
                            ls.Items.Add(UCase(word.Replace(vbCrLf, "")))
                        End If
                    End If
                End If
            Next
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MessageBox.Show("Are you sure you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            For Each i As Object In ls.CheckedItems
                OpenCentralServer(file_conn_dir & "\" & i.ToString.Replace(vbCrLf, ""))
                If connclient.State = ConnectionState.Open Then
                    Dim systemdate As String = qrysingledataClient("dt", "date_format(trndate,'%Y%m%d') as dt", "master.syscalendar where forsystem=1 and openfortrn=0")
                    If systemdate <> "" Then
                        comclient.CommandText = "CREATE TABLE file_loans.ln" & systemdate & " select *,(select ucase(branchname) from master.branches where branchcode = loanwithterm.branchcode) as 'branch', (select concat(lname,', ',fname, ' ',mname) from master.client where custcode =loanwithterm.custcode) as 'client',(select prodname from master.loanprod where prodcode=loanwithterm.loanprod) 'product',ifnull((select ucase(centername) from master.g_center where centerkey=loanwithterm.centerkey limit 1),'') as 'center',ifnull((select ucase(groupname) from master.g_group where groupkey = loanwithterm.groupkey limit 1),'') as 'group', ifnull((select (select replace(ucase(username),'_',' ') from master.userinfo where userid=g_center.accountofficer) from master.g_center where centerkey=loanwithterm.centerkey limit 1),'') as 'accountofficer',ifnull((select concat(ucase(lname),', ',ucase(fname)) from master.client where custcode=loanwithterm.comaker1 limit 1),'') as 'comakername1',ifnull((select concat(ucase(lname),', ',ucase(fname)) from master.client where custcode=loanwithterm.comaker2 limit 1),'') as 'comakername2' from master.loanwithterm;" : comclient.ExecuteNonQuery()
                        comclient.CommandText = "CREATE TABLE file_deposit.dp" & systemdate & " select *,(select ucase(branchname) from master.branches where branchcode = depositaccounts.branchcode) as 'branch',(select description from master.depositprod where depcode=depositaccounts.depcode) as 'product',ifnull((select concat(lname,', ',fname, ' ',mname) from master.client where custcode =depositaccounts.signatory1 limit 1),'') as 'signatoryname1',ifnull((select concat(lname,', ',fname, ' ',mname) from master.client where custcode =depositaccounts.signatory2 limit 1),'') as 'signatoryname2',ifnull((select concat(lname,', ',fname, ' ',mname) from master.client where custcode =depositaccounts.signatory3 limit 1),'') as 'signatoryname3',ifnull((select concat(lname,', ',fname, ' ',mname) from master.client where custcode =depositaccounts.signatory4 limit 1),'') as 'signatoryname4'  from master.depositaccounts;" : comclient.ExecuteNonQuery()
                    End If
                End If
            Next
            LoadServerConnection()
            MsgBox("Report successfuly backup!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub ls_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ls.SelectedIndexChanged, ls.ItemCheck
        If ls.CheckedItems.Count > 0 Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If
    End Sub

End Class
