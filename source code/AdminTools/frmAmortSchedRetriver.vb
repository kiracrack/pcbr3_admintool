Imports System.Globalization

Public Class frmAmortSchedRetriver

    Private Sub txtrefcode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtrefcode.KeyPress
        If e.KeyChar() = Chr(13) Then
            Button2.PerformClick()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtClient.Text = "" Then
            MsgBox("Please select request by!", MsgBoxStyle.Critical)
            txtClient.Focus()
            Exit Sub
        End If


        If MessageBox.Show("Are you sure you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            com.CommandText = Trim(txtQuery.Text) : com.ExecuteNonQuery()
            Dim getBranch As String = qrysingledata("branch", "(select branchname from master.branches where branchcode = master.loanwithterm.branchcode) as 'branch'", "master.loanwithterm  where refno = '" & txtrefcode.Text & "'")
            com.CommandText = "INSERT into action_query.tbltechnicalreport set branchname='" & StrConv(getBranch, vbProperCase) & "',severitylvl='Critical', requestorname='" & txtClient.Text & "', concern='Restore Loan Amortization', actiontaken='Restore missing loan amortization schedule of " & txtName.Text & "', performedby='" & GlobalFullname & "', datetrn=current_timestamp" : com.ExecuteNonQuery()
            MsgBox("Amortization successfully restored!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub frmLoanAdjustment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error Resume Next
        LoadToComboBox("SELECT * FROM `master`.`userinfo` order by username asc;", "username", "userid", txtClient)
        com.CommandText = "CREATE TABLE IF NOT EXISTS  `action_query`.`g_chargesdeposits` (  `refno` char(6) COLLATE utf8_unicode_ci NOT NULL DEFAULT '',  `chgcateg1` tinyint(1) NOT NULL DEFAULT '0',  `amortchgcode1` char(2) COLLATE utf8_unicode_ci NOT NULL DEFAULT '',  `svacct1` char(20) COLLATE utf8_unicode_ci NOT NULL DEFAULT '',  `amortamt1` double(8,2) NOT NULL DEFAULT '0.00',  `amortstart1` int(3) NOT NULL DEFAULT '0',  `chgreg1` double(8,2) NOT NULL DEFAULT '0.00',  `chglast1` double(8,2) NOT NULL DEFAULT '0.00',  `amortbal1` double(8,2) NOT NULL DEFAULT '0.00',  `chgcateg2` tinyint(1) NOT NULL DEFAULT '0',  `amortchgcode2` char(2) COLLATE utf8_unicode_ci NOT NULL DEFAULT '',  `svacct2` char(20) COLLATE utf8_unicode_ci NOT NULL DEFAULT '',  `amortamt2` double(8,2) NOT NULL DEFAULT '0.00',  `amortstart2` int(3) NOT NULL DEFAULT '0',  `chgreg2` double(8,2) NOT NULL DEFAULT '0.00',  `chglast2` double(8,2) NOT NULL DEFAULT '0.00',  `amortbal2` double(8,2) NOT NULL DEFAULT '0.00',  `chgcateg3` tinyint(1) NOT NULL DEFAULT '0',  `amortchgcode3` char(2) COLLATE utf8_unicode_ci NOT NULL DEFAULT '',  `svacct3` char(20) COLLATE utf8_unicode_ci NOT NULL DEFAULT '',  `amortamt3` double(8,2) NOT NULL DEFAULT '0.00',  `amortstart3` int(3) NOT NULL DEFAULT '0',  `chgreg3` double(8,2) NOT NULL DEFAULT '0.00',  `chglast3` double(8,2) NOT NULL DEFAULT '0.00',  `amortbal3` double(8,2) NOT NULL DEFAULT '0.00',  `chgcateg4` tinyint(1) NOT NULL DEFAULT '0',  `amortchgcode4` char(2) COLLATE utf8_unicode_ci NOT NULL DEFAULT '',  `svacct4` char(20) COLLATE utf8_unicode_ci NOT NULL DEFAULT '',  `amortamt4` double(8,2) NOT NULL DEFAULT '0.00',  `amortstart4` int(3) NOT NULL DEFAULT '0',  `chgreg4` double(8,2) NOT NULL DEFAULT '0.00',  `chglast4` double(8,2) NOT NULL DEFAULT '0.00',  `amortbal4` double(8,2) NOT NULL DEFAULT '0.00',  `chgcateg5` tinyint(1) NOT NULL DEFAULT '0',  `amortchgcode5` char(2) COLLATE utf8_unicode_ci NOT NULL DEFAULT '',  `svacct5` char(20) COLLATE utf8_unicode_ci NOT NULL DEFAULT '',  `amortamt5` double(8,2) NOT NULL DEFAULT '0.00',  `amortstart5` int(3) NOT NULL DEFAULT '0',  `chgreg5` double(8,2) NOT NULL DEFAULT '0.00',  `chglast5` double(8,2) NOT NULL DEFAULT '0.00',  `amortbal5` double(8,2) NOT NULL DEFAULT '0.00',  `chgcateg6` tinyint(1) NOT NULL DEFAULT '0',  `amortchgcode6` char(2) COLLATE utf8_unicode_ci NOT NULL DEFAULT '',  `svacct6` char(20) COLLATE utf8_unicode_ci NOT NULL DEFAULT '',  `amortamt6` double(8,2) NOT NULL DEFAULT '0.00',  `amortstart6` int(3) NOT NULL DEFAULT '0',  `chgreg6` double(8,2) NOT NULL DEFAULT '0.00',  `chglast6` double(8,2) NOT NULL DEFAULT '0.00',  `amortbal6` double(8,2) NOT NULL DEFAULT '0.00',  `chgcurr1` double(8,2) NOT NULL DEFAULT '0.00',  `chgarr1` double(8,2) NOT NULL DEFAULT '0.00',  `chgcurr2` double(8,2) NOT NULL DEFAULT '0.00',  `chgarr2` double(8,2) NOT NULL DEFAULT '0.00',  `chgcurr3` double(8,2) NOT NULL DEFAULT '0.00',  `chgarr3` double(8,2) NOT NULL DEFAULT '0.00',  `chgcurr4` double(8,2) NOT NULL DEFAULT '0.00',  `chgarr4` double(8,2) NOT NULL DEFAULT '0.00',  `chgcurr5` double(8,2) NOT NULL DEFAULT '0.00',  `chgarr5` double(8,2) NOT NULL DEFAULT '0.00',  `chgcurr6` double(8,2) NOT NULL DEFAULT '0.00',  `chgarr6` double(8,2) NOT NULL DEFAULT '0.00',  `controlkey1` char(10) COLLATE utf8_unicode_ci NOT NULL DEFAULT '',  `controlkey2` char(10) COLLATE utf8_unicode_ci NOT NULL DEFAULT '',  `controlkey3` char(10) COLLATE utf8_unicode_ci NOT NULL DEFAULT '',  `controlkey4` char(10) COLLATE utf8_unicode_ci NOT NULL DEFAULT '',  `controlkey5` char(10) COLLATE utf8_unicode_ci NOT NULL DEFAULT '',  `controlkey6` char(10) COLLATE utf8_unicode_ci NOT NULL DEFAULT '',  KEY `g_chargesdeposits_refno` (`refno`)) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;" : com.ExecuteNonQuery()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        com.CommandText = "select *,(select concat(ucase(lname) ,', ', ucase(fname)) from master.client inner join master.loanwithterm on client.custcode =  loanwithterm.custcode  where loanwithterm.refno =lnamortsked.refno) as 'fullname' from master.lnamortsked where refno = '" & txtrefcode.Text & "'" : rst = com.ExecuteReader
        If rst.Read Then
            Button1.Enabled = True
            Button2.Enabled = True
            txtName.Text = rst("fullname").ToString

        Else
            txtName.Text = ""
            Button1.Enabled = False
            Button2.Enabled = False
            MsgBox("No record found", vbExclamation)
        End If
        rst.Close()
        com.CommandText = "SELECT * FROM `master`.`lnamortsked` where refno='" & txtrefcode.Text & "'" : rst = com.ExecuteReader()
        While rst.Read
            RichTextBox1.Text = "insert into master.lnamortsked set refno='" & rst("refno").ToString & "', amortsched='" & rst("amortsched").ToString & "'"
        End While
        rst.Close()
    End Sub

    Private Sub txtrefcode_TextChanged(sender As Object, e As EventArgs) Handles txtrefcode.TextChanged
        Button2.Enabled = True
    End Sub
End Class
