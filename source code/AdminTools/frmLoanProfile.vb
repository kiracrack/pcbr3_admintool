Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Drawing.Printing

Public Class frmLoanProfile
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmRequestType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FilterLoanProfile()
    End Sub

    Public Sub FilterLoanProfile()
        msda = New MySqlDataAdapter("select 'Branch' as 'Description', (select ucase(branchname) from master.branches where branchcode = loanwithterm.branchcode) as 'Value' FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "' union all  " _
                               + "select 'New Borrower', if(newborrower=1,'Yes','No') FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "' union all  " _
                               + "select 'Past Due', if(pastdue=1,'Yes','No') FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "' union all  " _
                               + "select 'Past Due Date', pduedate FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "' union all  " _
                               + "select 'In Litigation', if(inlitigation=1,'Yes','No') FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "' union all  " _
                               + "select 'In Litigation Date', lildate FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "' union all  " _
                               + "select 'Customer Code', custcode FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "' union all  " _
                               + "select 'Loan Product', (select prodname from loanprod where prodcode=loanwithterm.loanprod ) FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "' union all  " _
                               + "select 'Interest Rate', format(intrate,2) FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "' union all  " _
                               + "select 'Amortization Mode', (select amortdesc from master.amortmode where amortcode =loanwithterm.amortcode) FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "' union all  " _
                               + "select 'Payment Frequency', pmntfreq FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "' union all  " _
                               + "select 'Factor 360', format(factor360,2) FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "' union all  " _
                               + "select 'Factor 365', format(factor365,2) FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "' union all  " _
                               + "select 'Loan Date', loandate FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "' union all  " _
                               + "select 'First Payment', firstpmnt FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "' union all  " _
                               + "select 'Last Payment', lastpmnt FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "' union all  " _
                               + "select 'Maturity Date', maturity FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "' union all  " _
                               + "select 'Number of Installment', numbinst FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "' union all  " _
                               + "select 'Number of Paid Installment', numbpaidinst FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "' union all  " _
                               + "select 'Term in Days', termindays FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "' union all  " _
                               + "select 'Principal Amount', format(principal,2) FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "' union all  " _
                               + "select 'Interest Term', intterm FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "' union all  " _
                               + "select 'Principal Balance', format(pribal,2) FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "' union all  " _
                               + "select 'Interest Balance', format(intbal,2) FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "' union all  " _
                               + "select 'Amortization Payment to Date', amortpmnttodate FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "' union all  " _
                               + "select 'Last Transaction', lasttrn FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "' union all  " _
                               + "select 'Penalty Payment to Date', pnltypmnttodate FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "' union all  " _
                               + "select 'Interest Due', format(intdue,2) FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "' union all  " _
                               + "select 'Penalty Due', format(pendue,2) FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "' union all  " _
                               + "select (select chgdesc from master.charges where chgcode = loanwithterm.chgcode1), format(chgamt1,2) FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "' union all  " _
                               + "select (select chgdesc from master.charges where chgcode = loanwithterm.chgcode2), format(chgamt2,2) FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "' union all  " _
                               + "select (select chgdesc from master.charges where chgcode = loanwithterm.chgcode3), format(chgamt3,2) FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "' union all  " _
                               + "select (select chgdesc from master.charges where chgcode = loanwithterm.chgcode4), format(chgamt4,2) FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "' union all  " _
                               + "select (select chgdesc from master.charges where chgcode = loanwithterm.chgcode5), format(chgamt5,2) FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "' union all  " _
                               + "select (select chgdesc from master.charges where chgcode = loanwithterm.chgcode6), format(chgamt6,2) FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "' union all  " _
                               + "select (select chgdesc from master.charges where chgcode = loanwithterm.chgcode7), format(chgamt7,2) FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "' union all  " _
                               + "select 'Regular Amortization Principal', format(reg_amortpri,2) FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "' union all  " _
                               + "select 'Regular Amortization Interest', format(reg_amortint,2) FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "' union all  " _
                               + "select 'Last Amortization Principal', format(last_amortpri,2) FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "' union all  " _
                               + "select 'Last Amortization Interest', format(last_amortint,2) FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "' union all  " _
                               + "select 'Date Interest Due', dateinstdue FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "' union all  " _
                               + "select 'Next principal Due', format(nextprindue,2) FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "' union all  " _
                               + "select 'Next Interest Due', format(nextintdue,2) FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "' union all  " _
                               + "select 'Number of Installment Due', numbinstdue FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "' union all  " _
                               + "select 'Amortization Installment Due', amort_instdue FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "' union all  " _
                               + "select 'Days Delayed', daysdelayed FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "' union all  " _
                               + "select 'Current principal Due', format(currdue_prin,2) FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "' union all  " _
                               + "select 'Current Interest Due', format(currdue_int,2) FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "' union all  " _
                               + "select 'Arrears Principal Due', format(arrdue_prin,2) FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "' union all  " _
                               + "select 'Arrears Interest Due', format(arrdue_int,2) FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "' union all  " _
                               + "select 'Last Update', lastupdate FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "' union all  " _
                               + "select 'Days Delay', daysdelay FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "' union all  " _
                               + "select 'Loan Discount Balance BOD', format(ldbal_bod,2) FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "' union all  " _
                               + "select 'Loan Discount Balance EOD', format(ldbal_eod,2)  FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "' union all  " _
                               + "select 'Loan Discount Transfer Amount', format(ldxfer_amount,2) FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "' union all  " _
                               + "select 'Loan Discount Prior Date', date_format(ldxfer_priordate,'%Y-%m-%d') FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "' union all  " _
                               + "select 'Loan Discount Current Date', date_format(ldxfer_currdate,'%Y-%m-%d') FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "' union all  " _
                               + "select 'Co-Maker 1', (select concat(ucase(lname),', ',ucase(fname)) from client where custcode=loanwithterm.comaker1) FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "' union all  " _
                               + "select 'Co-Maker 2', (select concat(ucase(lname),', ',ucase(fname)) from client where custcode=loanwithterm.comaker2) FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "' union all  " _
                               + "select 'Account Officer', (select (select replace(ucase(username),'_',' ') from userinfo where userid=g_center.accountofficer) from g_center where centerkey=loanwithterm.centerkey) FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "' union all  " _
                               + "select 'Center', (select ucase(centername) from g_center where centerkey=loanwithterm.centerkey) FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "' union all  " _
                               + "select 'Group', (select ucase(groupname) from g_group where groupkey = loanwithterm.groupkey) FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "' union all  " _
                               + "select 'Processed By',(select replace(ucase(username),'_',' ') from userinfo where userid=loanwithterm.recby) FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "' union all  " _
                               + "select 'Date Processed', concat(daterec,' ',timerec) FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "' union all  " _
                               + "select 'Cleared By', (select replace(ucase(username),'_',' ') from userinfo where userid=loanwithterm.clearedby) FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "' union all  " _
                               + "select 'Cleared Date', clearinfo FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "' union all  " _
                               + "select 'Approved By', (select replace(ucase(username),'_',' ') from userinfo where userid=loanwithterm.clearedcrlimitby) FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "' union all  " _
                               + "select 'Approved Date', clearedcrlimitinfo FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "' union all  " _
                               + "select 'Disbursed By', (select replace(ucase(username),'_',' ') from userinfo where userid=loanwithterm.paidby) FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "' union all  " _
                               + "select 'Tracking Preference #', trackingreference FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "' union all  " _
                               + "select 'Cancelled', if(cancelled=1,'Yes','No') FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "' union all  " _
                               + "select 'Cancelled By',  (select replace(ucase(username),'_',' ') from userinfo where userid=loanwithterm.cancelledby) FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "' union all  " _
                               + "select 'Account Locked', if(locked=1,'Yes','No') FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "' union all  " _
                               + "select 'Account Locked By', (select replace(ucase(username),'_',' ') from userinfo where userid=loanwithterm.lockedby) FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "' union all  " _
                               + "select 'Transaction Locked', if(trnlocked=1,'Yes','No') FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "' union all  " _
                               + "select 'Transaction Locked By', (select replace(ucase(username),'_',' ') from userinfo where userid=loanwithterm.trnlockedby) FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "' union all  " _
                               + "select 'Lock Remarks', trnlockremark FROM `master`.`loanwithterm` where refno='" & txtRefno.Text & "'", conn)
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda.SelectCommand.CommandTimeout = 600000
        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        GridColumnAlignment(MyDataGridView, {"Value"}, DataGridViewContentAlignment.MiddleRight)

        Dim mtCell As Integer = 0
        Dim row As DataGridViewRow = New DataGridViewRow()
        For rowNo As Integer = MyDataGridView.Rows.Count - 2 To 0 Step -1
            row = MyDataGridView.Rows(rowNo)
            Try
                For j = 0 To row.Cells.Count - 2
                    If row.Cells(j).Value Is Nothing OrElse row.Cells(j).Value Is DBNull.Value Then
                        mtCell += 1
                    End If
                Next
                If mtCell = row.Cells.Count - 1 Then
                    MyDataGridView.Rows.RemoveAt(rowNo)
                End If
                mtCell = 0
            Catch ex As Exception
                Exit For
            End Try
        Next rowNo
    End Sub

   
    Private Sub EditChapterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditChapterToolStripMenuItem.Click
        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            If f.ShowDialog() = DialogResult.OK Then
                dst.WriteXml(f.SelectedPath & "\" & LCase(Me.Text) & ".xls")
                MessageBox.Show("Export done successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
End Class