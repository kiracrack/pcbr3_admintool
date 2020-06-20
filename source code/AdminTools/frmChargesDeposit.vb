Imports System.Globalization

Public Class frmChargesDeposit

    Private Sub txtrefcode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtrefcode.KeyPress
        If e.KeyChar() = Chr(13) Then
            com.CommandText = "select concat(ucase(lname) ,', ', ucase(fname)) as cname from master.client inner join master.loanwithterm on client.custcode = loanwithterm.custcode where refno='" & txtrefcode.Text & "'" : rst = com.ExecuteReader
                If rst.Read Then
                Button1.Enabled = True
                Button2.Enabled = True
                txtName.Text = rst("cname").ToString

                Else
                    txtName.Text = ""
                Button1.Enabled = False
                Button2.Enabled = False
                    MsgBox("No record found", vbExclamation)
                End If
                rst.Close()
            com.CommandText = "SELECT * FROM `master`.`g_chargesdeposits` where refno='" & txtrefcode.Text & "'" : rst = com.ExecuteReader()
            While rst.Read
                RichTextBox1.Text = "chgcateg1=" & rst("chgcateg1").ToString & ",amortchgcode1=" & rst("amortchgcode1").ToString & ",svacct1=" & rst("svacct1").ToString & ",amortamt1=" & rst("amortamt1").ToString & ",amortstart1=" & rst("amortstart1").ToString & ",chgreg1=" & rst("chgreg1").ToString & ",chglast1=" & rst("chglast1").ToString & ",amortbal1=" & rst("amortbal1").ToString & Environment.NewLine _
                     + "chgcateg2=" & rst("chgcateg2").ToString & ",amortchgcode2=" & rst("amortchgcode2").ToString & ",svacct2=" & rst("svacct2").ToString & ",amortamt2=" & rst("amortamt2").ToString & ",amortstart2=" & rst("amortstart2").ToString & ",chgreg2=" & rst("chgreg2").ToString & ",chglast2=" & rst("chglast2").ToString & ",amortbal2=" & rst("amortbal2").ToString & Environment.NewLine _
                     + "chgcateg3=" & rst("chgcateg3").ToString & ",amortchgcode3=" & rst("amortchgcode3").ToString & ",svacct3=" & rst("svacct3").ToString & ",amortamt3=" & rst("amortamt3").ToString & ",amortstart3=" & rst("amortstart3").ToString & ",chgreg3=" & rst("chgreg3").ToString & ",chglast3=" & rst("chglast3").ToString & ",amortbal3=" & rst("amortbal3").ToString & Environment.NewLine _
                     + "chgcateg4=" & rst("chgcateg4").ToString & ",amortchgcode4=" & rst("amortchgcode4").ToString & ",svacct4=" & rst("svacct4").ToString & ",amortamt4=" & rst("amortamt4").ToString & ",amortstart4=" & rst("amortstart4").ToString & ",chgreg4=" & rst("chgreg4").ToString & ",chglast4=" & rst("chglast4").ToString & ",amortbal4=" & rst("amortbal4").ToString & Environment.NewLine _
                     + "chgcateg5=" & rst("chgcateg5").ToString & ",amortchgcode5=" & rst("amortchgcode5").ToString & ",svacct5=" & rst("svacct5").ToString & ",amortamt5=" & rst("amortamt5").ToString & ",amortstart5=" & rst("amortstart5").ToString & ",chgreg5=" & rst("chgreg5").ToString & ",chglast5=" & rst("chglast5").ToString & ",amortbal5=" & rst("amortbal5").ToString & Environment.NewLine _
                     + "chgcateg6=" & rst("chgcateg6").ToString & ",amortchgcode6=" & rst("amortchgcode6").ToString & ",svacct6=" & rst("svacct6").ToString & ",amortamt6=" & rst("amortamt6").ToString & ",amortstart6=" & rst("amortstart6").ToString & ",chgreg6=" & rst("chgreg6").ToString & ",chglast6=" & rst("chglast6").ToString & ",amortbal6=" & rst("amortbal6").ToString & Environment.NewLine
            End While
            rst.Close()
        End If
       
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtClient.Text = "" Then
            MsgBox("Please select request by!", MsgBoxStyle.Critical)
            txtClient.Focus()
            Exit Sub
        End If


        If MessageBox.Show("Are you sure you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            com.CommandText = "INSERT into action_query.g_chargesdeposits SELECT * FROM `master`.`g_chargesdeposits` where refno='" & txtrefcode.Text & "'" : com.ExecuteNonQuery()
            com.CommandText = "UPDATE `master`.`g_chargesdeposits` set chgcateg" & txtCharges.Text & "='0',amortchgcode" & txtCharges.Text & "='',svacct" & txtCharges.Text & "='',amortamt" & txtCharges.Text & "='0.00',amortstart" & txtCharges.Text & "='0',chgreg" & txtCharges.Text & "='0.00',chglast" & txtCharges.Text & "='0.00',amortbal" & txtCharges.Text & "='0.00' where refno='" & txtrefcode.Text & "';" : com.ExecuteNonQuery()
            Dim getBranch As String = qrysingledata("branch", "(select branchname from master.branches where branchcode = master.loanwithterm.branchcode) as 'branch'", "master.loanwithterm  where refno = '" & txtrefcode.Text & "'")
            com.CommandText = "INSERT into action_query.tbltechnicalreport set branchname='" & StrConv(getBranch, vbProperCase) & "',severitylvl='Critical', requestorname='" & txtClient.Text & "', concern='Remove charge deposit error', actiontaken='Charges line " & txtCharges.Text & " successfully removed reference #" & txtrefcode.Text & ": " & Chr(13) & RichTextBox1.Text & "', performedby='" & GlobalFullname & "', datetrn=current_timestamp" : com.ExecuteNonQuery()
            MsgBox("Charges successfully removed!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub frmLoanAdjustment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error Resume Next
        LoadToComboBox("SELECT * FROM `master`.`userinfo` order by username asc;", "username", "userid", txtClient)
        com.CommandText = "CREATE TABLE IF NOT EXISTS  `action_query`.`g_chargesdeposits` (  `refno` char(6) COLLATE utf8_unicode_ci NOT NULL DEFAULT '',  `chgcateg1` tinyint(1) NOT NULL DEFAULT '0',  `amortchgcode1` char(2) COLLATE utf8_unicode_ci NOT NULL DEFAULT '',  `svacct1` char(20) COLLATE utf8_unicode_ci NOT NULL DEFAULT '',  `amortamt1` double(8,2) NOT NULL DEFAULT '0.00',  `amortstart1` int(3) NOT NULL DEFAULT '0',  `chgreg1` double(8,2) NOT NULL DEFAULT '0.00',  `chglast1` double(8,2) NOT NULL DEFAULT '0.00',  `amortbal1` double(8,2) NOT NULL DEFAULT '0.00',  `chgcateg2` tinyint(1) NOT NULL DEFAULT '0',  `amortchgcode2` char(2) COLLATE utf8_unicode_ci NOT NULL DEFAULT '',  `svacct2` char(20) COLLATE utf8_unicode_ci NOT NULL DEFAULT '',  `amortamt2` double(8,2) NOT NULL DEFAULT '0.00',  `amortstart2` int(3) NOT NULL DEFAULT '0',  `chgreg2` double(8,2) NOT NULL DEFAULT '0.00',  `chglast2` double(8,2) NOT NULL DEFAULT '0.00',  `amortbal2` double(8,2) NOT NULL DEFAULT '0.00',  `chgcateg3` tinyint(1) NOT NULL DEFAULT '0',  `amortchgcode3` char(2) COLLATE utf8_unicode_ci NOT NULL DEFAULT '',  `svacct3` char(20) COLLATE utf8_unicode_ci NOT NULL DEFAULT '',  `amortamt3` double(8,2) NOT NULL DEFAULT '0.00',  `amortstart3` int(3) NOT NULL DEFAULT '0',  `chgreg3` double(8,2) NOT NULL DEFAULT '0.00',  `chglast3` double(8,2) NOT NULL DEFAULT '0.00',  `amortbal3` double(8,2) NOT NULL DEFAULT '0.00',  `chgcateg4` tinyint(1) NOT NULL DEFAULT '0',  `amortchgcode4` char(2) COLLATE utf8_unicode_ci NOT NULL DEFAULT '',  `svacct4` char(20) COLLATE utf8_unicode_ci NOT NULL DEFAULT '',  `amortamt4` double(8,2) NOT NULL DEFAULT '0.00',  `amortstart4` int(3) NOT NULL DEFAULT '0',  `chgreg4` double(8,2) NOT NULL DEFAULT '0.00',  `chglast4` double(8,2) NOT NULL DEFAULT '0.00',  `amortbal4` double(8,2) NOT NULL DEFAULT '0.00',  `chgcateg5` tinyint(1) NOT NULL DEFAULT '0',  `amortchgcode5` char(2) COLLATE utf8_unicode_ci NOT NULL DEFAULT '',  `svacct5` char(20) COLLATE utf8_unicode_ci NOT NULL DEFAULT '',  `amortamt5` double(8,2) NOT NULL DEFAULT '0.00',  `amortstart5` int(3) NOT NULL DEFAULT '0',  `chgreg5` double(8,2) NOT NULL DEFAULT '0.00',  `chglast5` double(8,2) NOT NULL DEFAULT '0.00',  `amortbal5` double(8,2) NOT NULL DEFAULT '0.00',  `chgcateg6` tinyint(1) NOT NULL DEFAULT '0',  `amortchgcode6` char(2) COLLATE utf8_unicode_ci NOT NULL DEFAULT '',  `svacct6` char(20) COLLATE utf8_unicode_ci NOT NULL DEFAULT '',  `amortamt6` double(8,2) NOT NULL DEFAULT '0.00',  `amortstart6` int(3) NOT NULL DEFAULT '0',  `chgreg6` double(8,2) NOT NULL DEFAULT '0.00',  `chglast6` double(8,2) NOT NULL DEFAULT '0.00',  `amortbal6` double(8,2) NOT NULL DEFAULT '0.00',  `chgcurr1` double(8,2) NOT NULL DEFAULT '0.00',  `chgarr1` double(8,2) NOT NULL DEFAULT '0.00',  `chgcurr2` double(8,2) NOT NULL DEFAULT '0.00',  `chgarr2` double(8,2) NOT NULL DEFAULT '0.00',  `chgcurr3` double(8,2) NOT NULL DEFAULT '0.00',  `chgarr3` double(8,2) NOT NULL DEFAULT '0.00',  `chgcurr4` double(8,2) NOT NULL DEFAULT '0.00',  `chgarr4` double(8,2) NOT NULL DEFAULT '0.00',  `chgcurr5` double(8,2) NOT NULL DEFAULT '0.00',  `chgarr5` double(8,2) NOT NULL DEFAULT '0.00',  `chgcurr6` double(8,2) NOT NULL DEFAULT '0.00',  `chgarr6` double(8,2) NOT NULL DEFAULT '0.00',  `controlkey1` char(10) COLLATE utf8_unicode_ci NOT NULL DEFAULT '',  `controlkey2` char(10) COLLATE utf8_unicode_ci NOT NULL DEFAULT '',  `controlkey3` char(10) COLLATE utf8_unicode_ci NOT NULL DEFAULT '',  `controlkey4` char(10) COLLATE utf8_unicode_ci NOT NULL DEFAULT '',  `controlkey5` char(10) COLLATE utf8_unicode_ci NOT NULL DEFAULT '',  `controlkey6` char(10) COLLATE utf8_unicode_ci NOT NULL DEFAULT '',  KEY `g_chargesdeposits_refno` (`refno`)) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;" : com.ExecuteNonQuery()
    End Sub

    
End Class
