Imports System.Globalization
Imports System.IO

Public Class frmCentralAutoBackup
    Dim showSerach As Boolean = False
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmUnblockClearLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connection200()
        com.CommandText = "CREATE DATABASE IF NOT EXISTS file_loans" : com.ExecuteNonQuery()
        com.CommandText = "CREATE DATABASE IF NOT EXISTS file_deposit" : com.ExecuteNonQuery()
    End Sub
   
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If countqry("master.syscalendar", "forsystem=1 and openfortrn=0") > 0 Then
            Dim systemdate As String = qrysingledata("dt", "date_format(trndate,'%Y%m%d') as dt", "master.syscalendar where forsystem=1")
            If countqry("information_schema.tables", "table_schema = 'file_loans' AND table_name = 'ln" & systemdate & "'") = 0 Then
                Timer1.Stop()
                ExecuteBackupLoans(systemdate)
            End If
            If countqry("information_schema.tables", "table_schema = 'file_deposit' AND table_name = 'dp" & systemdate & "'") = 0 Then
                Timer1.Stop()
                ExecuteBackupDeposit(systemdate)
            End If
        End If
    End Sub

    Public Function ExecuteBackupLoans(ByVal tablename As String)
        Dim systemdate As String = qrysingledata("dt", "date_format(trndate,'%Y%m%d') as dt", "master.syscalendar where forsystem=1 and openfortrn=0")
        If systemdate <> "" Then
            com.CommandText = "CREATE TABLE file_loans.ln" & systemdate & " select *,(select ucase(branchname) from master.branches where branchcode = loanwithterm.branchcode) as 'branch', (select concat(lname,', ',fname, ' ',mname) from master.client where custcode =loanwithterm.custcode) as 'client',(select prodname from master.loanprod where prodcode=loanwithterm.loanprod) 'product',ifnull((select ucase(centername) from master.g_center where centerkey=loanwithterm.centerkey limit 1),'') as 'center',ifnull((select ucase(groupname) from master.g_group where groupkey = loanwithterm.groupkey limit 1),'') as 'group', ifnull((select (select replace(ucase(username),'_',' ') from master.userinfo where userid=g_center.accountofficer) from master.g_center where centerkey=loanwithterm.centerkey limit 1),'') as 'accountofficer',ifnull((select concat(ucase(lname),', ',ucase(fname)) from master.client where custcode=loanwithterm.comaker1 limit 1),'') as 'comakername1',ifnull((select concat(ucase(lname),', ',ucase(fname)) from master.client where custcode=loanwithterm.comaker2 limit 1),'') as 'comakername2' from master.loanwithterm;" : com.ExecuteNonQuery()
            Timer1.Start()
        End If
        Return 0
    End Function

    Public Function ExecuteBackupDeposit(ByVal tablename As String)
        Dim systemdate As String = qrysingledata("dt", "date_format(trndate,'%Y%m%d') as dt", "master.syscalendar where forsystem=1 and openfortrn=0")
        If systemdate <> "" Then
            com.CommandText = "CREATE TABLE file_deposit.dp" & systemdate & " select *,(select ucase(branchname) from master.branches where branchcode = depositaccounts.branchcode) as 'branch',(select description from master.depositprod where depcode=depositaccounts.depcode) as 'product',ifnull((select concat(lname,', ',fname, ' ',mname) from master.client where custcode =depositaccounts.signatory1 limit 1),'') as 'signatoryname1',ifnull((select concat(lname,', ',fname, ' ',mname) from master.client where custcode =depositaccounts.signatory2 limit 1),'') as 'signatoryname2',ifnull((select concat(lname,', ',fname, ' ',mname) from master.client where custcode =depositaccounts.signatory3 limit 1),'') as 'signatoryname3',ifnull((select concat(lname,', ',fname, ' ',mname) from master.client where custcode =depositaccounts.signatory4 limit 1),'') as 'signatoryname4'  from master.depositaccounts;" : com.ExecuteNonQuery()
            Timer1.Start()
        End If
        Return 0
    End Function

    Private Sub CloseThisToolToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseThisToolToolStripMenuItem.Click
        End
    End Sub
End Class
