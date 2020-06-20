Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.ComponentModel

Public Class frmCaptureLoanPaymentSequence
    Dim bw As BackgroundWorker = New BackgroundWorker
    Dim datequery As Date
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub cmdset_Click(sender As Object, e As EventArgs) Handles cmdset.Click
        AddHandler bw.DoWork, AddressOf bw_DoWork
        AddHandler bw.ProgressChanged, AddressOf bw_ProgressChanged
        AddHandler bw.RunWorkerCompleted, AddressOf bw_RunWorkerCompleted
        Dim dbase As String = "db" & txtTRansactionDate.Value.ToString("yyyy").ToString & txtTRansactionDate.Value.ToString("MM").ToString

        If countqry("information_schema.SCHEMATA", "schema_name = '" & dbase & "'") = 0 And ckCaptureAllLoansAccounts.Checked = False Then
            MsgBox("Transaction selected date not available", MsgBoxStyle.Critical)
            Exit Sub
        ElseIf txtBranch.Text = "" And CheckBox1.Checked = False Then
            MsgBox("Please select branch", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If MessageBox.Show("Are you sure you want to continue? " & Environment.NewLine & Environment.NewLine & "Note: There's no undo function. please make sure you doing correctly!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
            If Not bw.IsBusy = True Then
                cmdset.Enabled = False
                Me.ControlBox = False
                bw.RunWorkerAsync()
            End If
        End If
    End Sub

    Private Sub bw_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs)
        Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)
        Dim dbase As String = "db" & txtTRansactionDate.Value.ToString("yyyy").ToString & txtTRansactionDate.Value.ToString("MM").ToString

        'CAPTURE LOAN PAYMENT SEQUENCE IF SYSTEM FOUND NEW RELEASED FROM PCBR3 BASE ON SELECTED DATE (tblloanpaymentcharges)
        'if One type setup only (Capture all PCBR3 Accounts and Charges Sequence) = checked then all transaction will be captured
        Dim dst As New DataSet
        msda = New MySqlDataAdapter("select refno, CAST((select amortsched from master.lnamortsked where lnamortsked.refno=loanwithterm.refno) as char(500)) as 'sched' from master.loanwithterm where cancelled=0 " & If(ckCaptureAllLoansAccounts.Checked = True, "", " and loandate='" & ConvertDate(txtTRansactionDate.Value) & "'") & "  " & If(CheckBox1.Checked = True, "", " and branchcode='" & branchcode.Text & "'"), conn)
        msda.SelectCommand.CommandTimeout = 9000000
        msda.Fill(dst, 0)
        For cnt = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
                If bw.CancellationPending = True Then
                    e.Cancel = True
                    Exit For
                Else
                    System.Threading.Thread.Sleep(0)
                    Dim getfirstline As String = ""
                    Dim cnn As Integer = 0
                    For Each word In .Rows(cnt)("sched").ToString().Split(New Char() {"|"c})
                        If cnn = 0 Then
                            getfirstline = word
                        End If
                        cnn = cnn + 1
                    Next

                    Dim chgcode1 As String = "" : Dim chgacct1 As String = "" : Dim chgamt1 As Double = 0 : Dim chgdesc1 As String = ""
                    Dim chgcode2 As String = "" : Dim chgacct2 As String = "" : Dim chgamt2 As Double = 0 : Dim chgdesc2 As String = ""
                    Dim chgcode3 As String = "" : Dim chgacct3 As String = "" : Dim chgamt3 As Double = 0 : Dim chgdesc3 As String = ""
                    Dim chgcode4 As String = "" : Dim chgacct4 As String = "" : Dim chgamt4 As Double = 0 : Dim chgdesc4 As String = ""
                    Dim chgcode5 As String = "" : Dim chgacct5 As String = "" : Dim chgamt5 As Double = 0 : Dim chgdesc5 As String = ""
                    Dim chgcode6 As String = "" : Dim chgacct6 As String = "" : Dim chgamt6 As Double = 0 : Dim chgdesc6 As String = ""
                    Dim cns As Integer = 0

                    For Each word In getfirstline.Split(New Char() {":"c})
                        If cns = 3 Then
                            chgcode1 = word
                        ElseIf cns = 4 Then
                            chgacct1 = word
                        ElseIf cns = 5 Then
                            chgamt1 = word
                        ElseIf cns = 6 Then
                            chgcode2 = word
                        ElseIf cns = 7 Then
                            chgacct2 = word
                        ElseIf cns = 8 Then
                            chgamt2 = word
                        ElseIf cns = 9 Then
                            chgcode3 = word
                        ElseIf cns = 10 Then
                            chgacct3 = word
                        ElseIf cns = 11 Then
                            chgamt3 = word
                        ElseIf cns = 12 Then
                            chgcode4 = word
                        ElseIf cns = 13 Then
                            chgacct4 = word
                        ElseIf cns = 14 Then
                            chgamt4 = word
                        ElseIf cns = 15 Then
                            chgcode5 = word
                        ElseIf cns = 16 Then
                            chgacct5 = word
                        ElseIf cns = 17 Then
                            chgamt5 = word
                        ElseIf cns = 18 Then
                            chgcode6 = word
                        ElseIf cns = 19 Then
                            chgacct6 = word
                        ElseIf cns = 20 Then
                            chgamt6 = word
                        End If
                        cns = cns + 1
                    Next
                    If countqry("`migration`.`tblloanpaymentcharges`", "refno='" & .Rows(cnt)("refno").ToString() & "'") = 0 Then
                        com.CommandText = "INSERT INTO `migration`.`tblloanpaymentcharges` set  " _
                                               + " refno='" & .Rows(cnt)("refno").ToString() & "', " _
                                               + " chgcode1='" & If(chgcode1 = "", chgacct1, chgcode1) & "', " _
                                               + " chgdesc1='" & If(chgcode1 = "", If(checksavingsAccount(chgacct1) = True, getSavingsAccount(chgacct1), getPartyAccount(chgacct1)), getCharges(chgcode1)) & "', " _
                                               + " chgcode2='" & If(chgcode2 = "", chgacct2, chgcode2) & "', " _
                                               + " chgdesc2='" & If(chgcode2 = "", If(checksavingsAccount(chgacct2) = True, getSavingsAccount(chgacct2), getPartyAccount(chgacct2)), getCharges(chgcode2)) & "', " _
                                               + " chgcode3='" & If(chgcode3 = "", chgacct3, chgcode3) & "', " _
                                               + " chgdesc3='" & If(chgcode3 = "", If(checksavingsAccount(chgacct3) = True, getSavingsAccount(chgacct3), getPartyAccount(chgacct3)), getCharges(chgcode3)) & "', " _
                                               + " chgcode4='" & If(chgcode4 = "", chgacct4, chgcode4) & "', " _
                                               + " chgdesc4='" & If(chgcode4 = "", If(checksavingsAccount(chgacct4) = True, getSavingsAccount(chgacct4), getPartyAccount(chgacct4)), getCharges(chgcode4)) & "', " _
                                               + " chgcode5='" & If(chgcode5 = "", chgacct5, chgcode5) & "', " _
                                               + " chgdesc5='" & If(chgcode5 = "", If(checksavingsAccount(chgacct5) = True, getSavingsAccount(chgacct5), getPartyAccount(chgacct5)), getCharges(chgcode5)) & "', " _
                                               + " chgcode6='" & If(chgcode6 = "", chgacct6, chgcode6) & "', " _
                                               + " chgdesc6='" & If(chgcode6 = "", If(checksavingsAccount(chgacct6) = True, getSavingsAccount(chgacct6), getPartyAccount(chgacct6)), getCharges(chgcode6)) & "';" : com.ExecuteNonQuery()
                    End If
                    bw.ReportProgress(cnt)
                End If
            End With
        Next

        If ckCaptureAllLoansAccounts.Checked = False Then
            'OVERWRITE ALL EXISTING TRANSACTION LEDGER BASE ON SELECTED DATE
            com.CommandText = "DELETE from migration.bosledger where trndate='" & ConvertDate(txtTRansactionDate.Value) & "'" : com.ExecuteNonQuery()

            'CAPTURE LOAN PAYMENT BASE ON SELECTED DATE
            com.CommandText = "insert into migration.bosledger " _
                                + " Select branchcode, lnrefno,pmntdate,lnwtermdet.refno,'PAY', 0, principal, amtpaid, 'principal','Prin','', lnwtermdet.recby from " & dbase & ".lnwtermdet where principal>0 and cancelled=0 and pmntdate='" & ConvertDate(txtTRansactionDate.Value) & "' union all " _
                                + " Select branchcode, lnrefno,pmntdate,lnwtermdet.refno,'PAY', 0, interest, amtpaid, 'interest','Int', '', lnwtermdet.recby from " & dbase & ".lnwtermdet where interest>0 and cancelled=0 and pmntdate='" & ConvertDate(txtTRansactionDate.Value) & "' union all " _
                                + " select branchcode, lnrefno,pmntdate,lnwtermdet.refno,'PAY', 0, penalty, amtpaid, 'penalty','PCLI', '', lnwtermdet.recby from " & dbase & ".lnwtermdet where penalty>0 and cancelled=0 and pmntdate='" & ConvertDate(txtTRansactionDate.Value) & "' union all " _
                                + " select branchcode, lnrefno,pmntdate,lnwtermdet.refno,'PAY', 0, lnwtermdet.chgpmnt1, amtpaid, tblloanpaymentcharges.chgdesc1,ifnull((select boscharges from master.charges where chgcode=tblloanpaymentcharges.chgcode1),'Misc'),'',lnwtermdet.recby from " & dbase & ".lnwtermdet inner join migration.tblloanpaymentcharges on tblloanpaymentcharges.refno = lnwtermdet.lnrefno where chgpmnt1 > 0 and lnwtermdet.cancelled=0 and pmntdate='" & ConvertDate(txtTRansactionDate.Value) & "' union all " _
                                + " select branchcode, lnrefno,pmntdate,lnwtermdet.refno,'PAY', 0, lnwtermdet.chgpmnt2, amtpaid, tblloanpaymentcharges.chgdesc2,ifnull((select boscharges from master.charges where chgcode=tblloanpaymentcharges.chgcode2),'Misc'),'',lnwtermdet.recby from " & dbase & ".lnwtermdet inner join migration.tblloanpaymentcharges on tblloanpaymentcharges.refno = lnwtermdet.lnrefno where chgpmnt2 > 0 and lnwtermdet.cancelled=0 and pmntdate='" & ConvertDate(txtTRansactionDate.Value) & "' union all " _
                                + " select branchcode, lnrefno,pmntdate,lnwtermdet.refno,'PAY', 0, lnwtermdet.chgpmnt3, amtpaid, tblloanpaymentcharges.chgdesc3,ifnull((select boscharges from master.charges where chgcode=tblloanpaymentcharges.chgcode3),'Misc'),'',lnwtermdet.recby from " & dbase & ".lnwtermdet inner join migration.tblloanpaymentcharges on tblloanpaymentcharges.refno = lnwtermdet.lnrefno where chgpmnt3 > 0 and lnwtermdet.cancelled=0 and pmntdate='" & ConvertDate(txtTRansactionDate.Value) & "' union all " _
                                + " select branchcode, lnrefno,pmntdate,lnwtermdet.refno,'PAY', 0, lnwtermdet.chgpmnt4, amtpaid, tblloanpaymentcharges.chgdesc4,ifnull((select boscharges from master.charges where chgcode=tblloanpaymentcharges.chgcode4),'Misc'),'',lnwtermdet.recby from " & dbase & ".lnwtermdet inner join migration.tblloanpaymentcharges on tblloanpaymentcharges.refno = lnwtermdet.lnrefno where chgpmnt4 > 0 and lnwtermdet.cancelled=0 and pmntdate='" & ConvertDate(txtTRansactionDate.Value) & "' union all " _
                                + " select branchcode, lnrefno,pmntdate,lnwtermdet.refno,'PAY', 0, lnwtermdet.chgpmnt5, amtpaid, tblloanpaymentcharges.chgdesc5,ifnull((select boscharges from master.charges where chgcode=tblloanpaymentcharges.chgcode5),'Misc'),'',lnwtermdet.recby from " & dbase & ".lnwtermdet inner join migration.tblloanpaymentcharges on tblloanpaymentcharges.refno = lnwtermdet.lnrefno where chgpmnt5 > 0 and lnwtermdet.cancelled=0 and pmntdate='" & ConvertDate(txtTRansactionDate.Value) & "' union all " _
                                + " select branchcode, lnrefno,pmntdate,lnwtermdet.refno,'PAY', 0, lnwtermdet.chgpmnt6, amtpaid, tblloanpaymentcharges.chgdesc6,ifnull((select boscharges from master.charges where chgcode=tblloanpaymentcharges.chgcode6),'Misc'),'',lnwtermdet.recby from " & dbase & ".lnwtermdet inner join migration.tblloanpaymentcharges on tblloanpaymentcharges.refno = lnwtermdet.lnrefno where chgpmnt6 > 0 and lnwtermdet.cancelled=0 and pmntdate='" & ConvertDate(txtTRansactionDate.Value) & "'; " : com.ExecuteNonQuery()

            'CAPTURE LOAN ADJUSTMENT BASE ON SELECTED DATE
            com.CommandText = "insert into migration.bosledger " _
                                + " Select (Select branchcode from master.loanwithterm where refno = loanadj.refno), loanadj.refno, adjdate,'','ADJ', if(prin_add=1,principal,0), if(prin_add=0,principal,0), 0, 'principal','Prin',remark, loanadj.recby from " & dbase & ".loanadj where principal>0 and approvedby<>'' and adjdate='" & ConvertDate(txtTRansactionDate.Value) & "' union all " _
                                + " Select (Select branchcode from master.loanwithterm where refno = loanadj.refno), loanadj.refno, adjdate,'','ADJ', if(int_add=1,interest,0), if(int_add=0,interest,0), 0, 'interest','Int',remark, loanadj.recby from " & dbase & ".loanadj where interest>0 and approvedby<>'' and adjdate='" & ConvertDate(txtTRansactionDate.Value) & "' union all " _
                                + " select (select branchcode from master.loanwithterm where refno = loanadj.refno), loanadj.refno, adjdate,'','ADJ', if(pen_add=1,penalty,0) , if(pen_add=0,penalty,0), 0, 'penalty','PCLI',remark,loanadj.recby from " & dbase & ".loanadj where penalty>0 and approvedby<>'' and adjdate='" & ConvertDate(txtTRansactionDate.Value) & "' union all " _
                                + " select (select branchcode from master.loanwithterm where refno = loanadj.refno), loanadj.refno, adjdate,'','ADJ', if(chg1_add=1,loanadj.chgadj1,0), if(chg1_add=0,loanadj.chgadj1,0), 0, tblloanpaymentcharges.chgdesc1,ifnull((select boscharges from master.charges where chgcode=tblloanpaymentcharges.chgcode1),'Misc'),remark,loanadj.recby from " & dbase & ".loanadj inner join migration.tblloanpaymentcharges on loanadj.refno = tblloanpaymentcharges.refno where chgadj1 > 0 and approvedby<>'' and adjdate='" & ConvertDate(txtTRansactionDate.Value) & "' union all " _
                                + " select (select branchcode from master.loanwithterm where refno = loanadj.refno), loanadj.refno, adjdate,'','ADJ', if(chg2_add=1,loanadj.chgadj2,0), if(chg2_add=0,loanadj.chgadj2,0), 0, tblloanpaymentcharges.chgdesc2,ifnull((select boscharges from master.charges where chgcode=tblloanpaymentcharges.chgcode2),'Misc'),remark,loanadj.recby from " & dbase & ".loanadj inner join migration.tblloanpaymentcharges on loanadj.refno = tblloanpaymentcharges.refno where chgadj2 > 0 and approvedby<>'' and adjdate='" & ConvertDate(txtTRansactionDate.Value) & "' union all " _
                                + " select (select branchcode from master.loanwithterm where refno = loanadj.refno), loanadj.refno, adjdate,'','ADJ', if(chg3_add=1,loanadj.chgadj3,0), if(chg3_add=0,loanadj.chgadj3,0), 0, tblloanpaymentcharges.chgdesc3,ifnull((select boscharges from master.charges where chgcode=tblloanpaymentcharges.chgcode3),'Misc'),remark,loanadj.recby from " & dbase & ".loanadj inner join migration.tblloanpaymentcharges on loanadj.refno = tblloanpaymentcharges.refno where chgadj3 > 0 and approvedby<>'' and adjdate='" & ConvertDate(txtTRansactionDate.Value) & "' union all " _
                                + " select (select branchcode from master.loanwithterm where refno = loanadj.refno), loanadj.refno, adjdate,'','ADJ', if(chg4_add=1,loanadj.chgadj4,0), if(chg4_add=0,loanadj.chgadj4,0), 0, tblloanpaymentcharges.chgdesc4,ifnull((select boscharges from master.charges where chgcode=tblloanpaymentcharges.chgcode4),'Misc'),remark,loanadj.recby from " & dbase & ".loanadj inner join migration.tblloanpaymentcharges on loanadj.refno = tblloanpaymentcharges.refno where chgadj4 > 0 and approvedby<>'' and adjdate='" & ConvertDate(txtTRansactionDate.Value) & "' union all " _
                                + " select (select branchcode from master.loanwithterm where refno = loanadj.refno), loanadj.refno, adjdate,'','ADJ', if(chg5_add=1,loanadj.chgadj5,0), if(chg5_add=0,loanadj.chgadj5,0), 0, tblloanpaymentcharges.chgdesc5,ifnull((select boscharges from master.charges where chgcode=tblloanpaymentcharges.chgcode5),'Misc'),remark,loanadj.recby from " & dbase & ".loanadj inner join migration.tblloanpaymentcharges on loanadj.refno = tblloanpaymentcharges.refno where chgadj5 > 0 and approvedby<>'' and adjdate='" & ConvertDate(txtTRansactionDate.Value) & "' union all " _
                                + " select (select branchcode from master.loanwithterm where refno = loanadj.refno), loanadj.refno, adjdate,'','ADJ', if(chg6_add=1,loanadj.chgadj6,0), if(chg6_add=0,loanadj.chgadj6,0), 0, tblloanpaymentcharges.chgdesc6,ifnull((select boscharges from master.charges where chgcode=tblloanpaymentcharges.chgcode6),'Misc'),remark,loanadj.recby from " & dbase & ".loanadj inner join migration.tblloanpaymentcharges on loanadj.refno = tblloanpaymentcharges.refno where chgadj6 > 0 and approvedby<>'' and adjdate='" & ConvertDate(txtTRansactionDate.Value) & "'; " : com.ExecuteNonQuery()

        End If
    End Sub
    Public Function checksavingsAccount(ByVal acct As String) As Boolean
        checksavingsAccount = CBool(countqry("master.depositaccounts", "acctnumber='" & acct & "' limit 1"))
        Return checksavingsAccount
    End Function

    Public Function getSavingsAccount(ByVal acct As String) As String
        getSavingsAccount = rchar(qrysingledata("acctnumber", "acctnumber", "master.depositaccounts where acctnumber='" & acct & "'"))
        Return getSavingsAccount
    End Function

    Public Function getPartyAccount(ByVal acct As String) As String
        getPartyAccount = rchar(qrysingledata("entitysvaccount", "entitysvaccount", "master.3rdpartyaccount where entitycode='" & acct & "'"))
        Return getPartyAccount
    End Function

    Public Function getCharges(ByVal code As String) As String
        getCharges = rchar(qrysingledata("chgdesc", "chgdesc", "master.charges where chgcode='" & code & "'"))
        Return getCharges
    End Function

    Private Sub bw_ProgressChanged(ByVal sender As Object, ByVal e As ProgressChangedEventArgs)
        TextBox1.Text = FormatNumber(e.ProgressPercentage.ToString(), 0)
    End Sub

    Private Sub bw_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs)
        If e.Cancelled = True Then
            Me.TextBox1.Text = "Canceled!"
        ElseIf e.Error IsNot Nothing Then
            Me.TextBox1.Text = "Error: " & e.Error.Message
        Else
            Me.TextBox1.Text = "DONE CAPTURED"
        End If
        Me.ControlBox = True
        cmdset.Enabled = True

    End Sub

    Private Sub frmRSBACapture_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadBranch()
        bw.WorkerSupportsCancellation = True
        bw.WorkerReportsProgress = True
        txtTRansactionDate.Text = Format(Now)
        com.CommandText = "CREATE DATABASE IF NOT EXISTS migration" : com.ExecuteNonQuery()
        com.CommandText = "CREATE TABLE IF NOT EXISTS `migration`.`tblloanpaymentcharges` (  `refno` varchar(20) NOT NULL,  `chgcode1` varchar(400) DEFAULT '',  `chgdesc1` varchar(400) DEFAULT '',  `chgcode2` varchar(400) DEFAULT '',  `chgdesc2` varchar(400) DEFAULT '',  `chgcode3` varchar(400) DEFAULT '',  `chgdesc3` varchar(400) DEFAULT '',  `chgcode4` varchar(400) DEFAULT '',  `chgdesc4` varchar(400) DEFAULT '',  `chgcode5` varchar(400) DEFAULT '',  `chgdesc5` varchar(400) DEFAULT '',  `chgcode6` varchar(400) DEFAULT '',  `chgdesc6` varchar(400) DEFAULT '',  PRIMARY KEY (`refno`) USING BTREE) ENGINE=MyISAM DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery()
        com.CommandText = "CREATE TABLE IF NOT EXISTS `migration`.`bosledger` (  `branchcode` char(10) COLLATE utf8_unicode_ci NOT NULL,  `lnrefno` text COLLATE utf8_unicode_ci NOT NULL,  `trndate` date NOT NULL DEFAULT '0000-00-00',  `reference` text COLLATE utf8_unicode_ci,  `transcode` text CHARACTER SET utf8,  `debit` double NOT NULL DEFAULT '0',  `credit` double NOT NULL DEFAULT '0',  `amtpaid` double NOT NULL DEFAULT '0',  `description` text CHARACTER SET latin1,  `ledgertype` varchar(45) COLLATE utf8_unicode_ci DEFAULT NULL,  `remarks` text CHARACTER SET utf8,  `recby` varchar(5) COLLATE utf8_unicode_ci DEFAULT NULL) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci ROW_FORMAT=FIXED;" : com.ExecuteNonQuery()
    End Sub
    Public Sub loadBranch()
        LoadToComboBox("select * from master.branches order by branchname asc", "branchname", "branchcode", txtBranch)
    End Sub

    Private Sub txtBranch_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtBranch.SelectedValueChanged
        If txtBranch.Text <> "" Then
            branchcode.Text = DirectCast(txtBranch.SelectedItem, ComboBoxItem).HiddenValue()
        Else
            branchcode.Text = ""
        End If
        loadTotalTrn()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtBranch.Enabled = False
            txtBranch.SelectedIndex = -1
        Else
            txtBranch.Enabled = True
        End If
        loadTotalTrn()
    End Sub

    Public Sub loadTotalTrn()
        Dim dbase As String = "db" & txtTRansactionDate.Value.ToString("yyyy").ToString & txtTRansactionDate.Value.ToString("MM").ToString
        If countqry("information_schema.SCHEMATA", "schema_name = '" & dbase & "'") = 0 Then
            txtTotalPayment.Text = "0"
            txtTotalAdjustment.Text = "0"
        Else
            txtTotalPayment.Text = FormatNumber(countRecord(dbase & ".lnwtermdet where cancelled=0 And pmntdate='" & ConvertDate(txtTRansactionDate.Value) & "'"), 0)
            txtTotalAdjustment.Text = FormatNumber(countRecord(dbase & ".loanadj where approvedby<>'' and adjdate='" & ConvertDate(txtTRansactionDate.Value) & "'"), 0)
        End If
        txtTotalLoanReleased.Text = FormatNumber(countRecord("master.loanwithterm where cancelled=0 " & If(ckCaptureAllLoansAccounts.Checked = True, "", " and loandate='" & ConvertDate(txtTRansactionDate.Value) & "'") & "  " & If(CheckBox1.Checked = True, "", " and branchcode='" & branchcode.Text & "'")), 0)
    End Sub

    Private Sub ckCaptureAllLoansAccounts_CheckedChanged(sender As Object, e As EventArgs) Handles ckCaptureAllLoansAccounts.CheckedChanged
        If ckCaptureAllLoansAccounts.Checked = True Then
            txtTRansactionDate.Enabled = False
        Else
            txtTRansactionDate.Enabled = True
        End If
        loadTotalTrn()
    End Sub

    Private Sub txtTRansactionDate_ValueChanged(sender As Object, e As EventArgs) Handles txtTRansactionDate.ValueChanged
        loadTotalTrn()
    End Sub

    Private Sub txtBranch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtBranch.SelectedIndexChanged

    End Sub
End Class