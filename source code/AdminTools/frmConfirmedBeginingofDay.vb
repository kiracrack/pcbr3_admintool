Imports System.Globalization

Public Class frmConfirmedBeginingofDay

    Private Sub frmLoanAdjustment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDateOfTheDay.Value = Format(Now)
        LoadBODScript()
    End Sub
    Private Sub txtDateTarget_ValueChanged(sender As Object, e As EventArgs) Handles txtDateOfTheDay.ValueChanged
        LoadBODScript()
    End Sub
    Public Sub LoadBODScript()
        Dim database_name As String = "db" & Format(txtDateOfTheDay.Value, "yyyyMM")
        txtAction.Text = ""
        '#FIRST BATCH CONFIRMATION
        'debit 
        com.CommandText = "select a.branchcode,ifnull(branchname,'') as brname,count(acctnumber) as icount,a.depcode,ifnull(description,'UNKNOWN DEPOSIT PRODUCT') as depname,sum(currbalance) as depbal,ifnull(actglgroupcode,'') as act_grp,ifnull(actglitemcode,'') as act_item,ifnull(dormglgroupcode,'') as dorm_grp,ifnull(dormglitemcode,'') as dorm_item from master.depositaccounts as a left join master.depositprod as b on a.depcode=b.depcode left join master.branches as c on a.branchcode=c.branchcode where currbalance > 0.00 and not dormant and statusdate like '" & ConvertDate(txtDateOfTheDay.Text) & "' and opendate not like '" & ConvertDate(txtDateOfTheDay.Text) & "' group by a.branchcode,a.depcode order by a.branchcode,a.depcode" : rst = com.ExecuteReader()
        While rst.Read
            txtAction.Text += "insert " & database_name & ".gljournal set entrydate='" & ConvertDate(txtDateOfTheDay.Text) & " 00:00:00',amount=" & rst("depbal").ToString & ",remark='Re-activated " & rst("depname").ToString & " - " & rst("brname").ToString & "',trnbranch='" & rst("branchcode").ToString & "',recby='PCB',debit=true,groupcode='" & rst("act_grp").ToString & "',itemcode='" & rst("act_item").ToString & "';" & Chr(13)
        End While
        rst.Close()

        'credit
        com.CommandText = "select a.branchcode,ifnull(branchname,'') as brname,count(acctnumber) as icount,a.depcode,ifnull(description,'UNKNOWN DEPOSIT PRODUCT') as depname,sum(currbalance) as depbal,ifnull(actglgroupcode,'') as act_grp,ifnull(actglitemcode,'') as act_item,ifnull(dormglgroupcode,'') as dorm_grp,ifnull(dormglitemcode,'') as dorm_item from master.depositaccounts as a left join master.depositprod as b on a.depcode=b.depcode left join master.branches as c on a.branchcode=c.branchcode where currbalance > 0.00 and not dormant and statusdate like '" & ConvertDate(txtDateOfTheDay.Text) & "' and opendate not like '" & ConvertDate(txtDateOfTheDay.Text) & "' group by a.branchcode,a.depcode order by a.branchcode,a.depcode" : rst = com.ExecuteReader()
        While rst.Read
            txtAction.Text += "insert " & database_name & ".gljournal set entrydate='" & ConvertDate(txtDateOfTheDay.Text) & " 00:00:00',amount=" & rst("depbal").ToString & ",remark='Re-activated " & rst("depname").ToString & " - " & rst("brname").ToString & "',trnbranch='" & rst("branchcode").ToString & "',recby='PCB',debit=false,groupcode='" & rst("dorm_grp").ToString & "',itemcode='" & rst("dorm_item").ToString & "';" & Chr(13)
        End While
        rst.Close()


        '#SECOND BATCH CONFIRMATION
        'debit 
        com.CommandText = "select a.branchcode,ifnull(branchname,'') as brname,count(acctnumber) as icount,a.depcode,ifnull(description,'UNKNOWN DEPOSIT PRODUCT') as depname,sum(currbalance) as depbal,ifnull(actglgroupcode,'') as act_grp,ifnull(actglitemcode,'') as act_item,ifnull(dormglgroupcode,'') as dorm_grp,ifnull(dormglitemcode,'') as dorm_item from master.depositaccounts as a left join master.depositprod as b on a.depcode=b.depcode left join master.branches as c on a.branchcode=c.branchcode where currbalance > 0.00 and dormant and statusdate like '" & ConvertDate(txtDateOfTheDay.Text) & "' group by a.branchcode,a.depcode order by a.branchcode,a.depcode" : rst = com.ExecuteReader()
        While rst.Read
            txtAction.Text += "insert " & database_name & ".gljournal set entrydate='" & ConvertDate(txtDateOfTheDay.Text) & " 00:00:00',amount=" & rst("depbal").ToString & ",remark='DormantXfer " & rst("depname").ToString & " - " & rst("brname").ToString & "',trnbranch='" & rst("branchcode").ToString & "',recby='PCB',debit=true,groupcode='" & rst("act_grp").ToString & "',itemcode='" & rst("act_item").ToString & "';" & Chr(13)
        End While
        rst.Close()

        'credit
        com.CommandText = "select a.branchcode,ifnull(branchname,'') as brname,count(acctnumber) as icount,a.depcode,ifnull(description,'UNKNOWN DEPOSIT PRODUCT') as depname,sum(currbalance) as depbal,ifnull(actglgroupcode,'') as act_grp,ifnull(actglitemcode,'') as act_item,ifnull(dormglgroupcode,'') as dorm_grp,ifnull(dormglitemcode,'') as dorm_item from master.depositaccounts as a left join master.depositprod as b on a.depcode=b.depcode left join master.branches as c on a.branchcode=c.branchcode where currbalance > 0.00 and dormant and statusdate like '" & ConvertDate(txtDateOfTheDay.Text) & "' group by a.branchcode,a.depcode order by a.branchcode,a.depcode" : rst = com.ExecuteReader()
        While rst.Read
            txtAction.Text += "insert " & database_name & ".gljournal set entrydate='" & ConvertDate(txtDateOfTheDay.Text) & " 00:00:00',amount=" & rst("depbal").ToString & ",remark='DormantXfer " & rst("depname").ToString & " - " & rst("brname").ToString & "',trnbranch='" & rst("branchcode").ToString & "',recby='PCB',debit=false,groupcode='" & rst("dorm_grp").ToString & "',itemcode='" & rst("dorm_item").ToString & "';" & Chr(13)
        End While
        rst.Close()

        '#THIRD BATCH CONFIRMATION
        'debit 
        com.CommandText = "select a.branchcode,ifnull(branchname,'') as brname,loanprod,ifnull(prodname,'UNKNOWN LOAN PRODUCT') as pname,count(refno) as icount,sum(pribal) as pbal,ifnull(trim(curr_lngrp),'') as curr_glgrp,ifnull(trim(curr_lnitem),'') as curr_glitem,ifnull(trim(pdue_lngrp),'') as pdue_glgrp,ifnull(trim(pdue_lnitem),'') as pdue_glitem from master.loanwithterm as a left join master.loanprod as b on a.loanprod=b.prodcode left join master.branches as c on a.branchcode=c.branchcode where not cancelled and paid and pribal > 0.00 and pastdue and pduedate like '" & ConvertDate(txtDateOfTheDay.Text) & "' group by a.branchcode,loanprod order by a.branchcode,loanprod" : rst = com.ExecuteReader()
        While rst.Read
            txtAction.Text += "insert " & database_name & ".gljournal set entrydate='" & ConvertDate(txtDateOfTheDay.Text) & " 00:00:00',amount=" & rst("pbal").ToString & ",remark='PDueXfer " & rst("pname").ToString & " - " & rst("brname").ToString & "',trnbranch='" & rst("branchcode").ToString & "',recby='PCB',debit=true,groupcode='" & rst("pdue_glgrp").ToString & "',itemcode='" & rst("pdue_glitem").ToString & "';" & Chr(13)
        End While
        rst.Close()

        'credit
        com.CommandText = "select a.branchcode,ifnull(branchname,'') as brname,loanprod,ifnull(prodname,'UNKNOWN LOAN PRODUCT') as pname,count(refno) as icount,sum(pribal) as pbal,ifnull(trim(curr_lngrp),'') as curr_glgrp,ifnull(trim(curr_lnitem),'') as curr_glitem,ifnull(trim(pdue_lngrp),'') as pdue_glgrp,ifnull(trim(pdue_lnitem),'') as pdue_glitem from master.loanwithterm as a left join master.loanprod as b on a.loanprod=b.prodcode left join master.branches as c on a.branchcode=c.branchcode where not cancelled and paid and pribal > 0.00 and pastdue and pduedate like '" & ConvertDate(txtDateOfTheDay.Text) & "' group by a.branchcode,loanprod order by a.branchcode,loanprod" : rst = com.ExecuteReader()
        While rst.Read
            txtAction.Text += "insert " & database_name & ".gljournal set entrydate='" & ConvertDate(txtDateOfTheDay.Text) & " 00:00:00',amount=" & rst("pbal").ToString & ",remark='PDueXfer " & rst("pname").ToString & " - " & rst("brname").ToString & "',trnbranch='" & rst("branchcode").ToString & "',recby='PCB',debit=false,groupcode='" & rst("curr_glgrp").ToString & "',itemcode='" & rst("curr_glitem").ToString & "';" & Chr(13)
        End While
        rst.Close()

        txtAction.Text += Chr(13) & "update master.syscalendar set trndate='" & ConvertDate(txtDateOfTheDay.Text) & " 00:00:00',openfortrn=1 where forsystem;" & Chr(13)
        txtAction.Text += "update master.userinfo set block=false,blockdesc='',blockedby='',blocklevel='' where not userid like '002' and block and blocklevel='1' and blockedby='002';" & Chr(13)
        txtAction.Text += "insert master.activitylog set userid='',trndate='" & ConvertDate(txtDateOfTheDay.Text) & "',taskdone='beginning of the process successfuly completed.',branchcode='',logdate=(select curdate()),logtime=(select curtime()),username='';" & Chr(13)
        txtAction.Text += "update master.userinfo set block=false,blockdesc='',blockedby='',blocklevel='' where not userid like '' and block and blocklevel='1' and blockedby='';" & Chr(13)
        txtAction.Text += "insert master.activitylog set userid='002',trndate='" & ConvertDate(txtDateOfTheDay.Text) & "',taskdone='beginning of the day (out)',branchcode='0007',logdate=(select curdate()),logtime=(select curtime()),username='alan_l_dumalay';" & Chr(13)
        txtAction.Text += "update master.userinfo set login='N' where userid like '002';" & Chr(13)
        txtAction.Text += "insert master.activitylog set userid='002',trndate='" & ConvertDate(txtDateOfTheDay.Text) & "',taskdone='successfully logout from the system (002 alan_l_dumalay)',branchcode='0007',logdate=(select curdate()),logtime=(select curtime()),username='alan_l_dumalay';" & Chr(13)
       
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MessageBox.Show("Are you sure you want to continue?" & Environment.NewLine & "Note: Confirmation can be done just once. else can cause errors on GL", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            For Each strLine As String In txtAction.Text.Split(vbLf)
                If strLine <> "" Then
                    com.CommandText = strLine : com.ExecuteNonQuery()
                End If
            Next
            MessageBox.Show("Transaction Successfully Open!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

   
End Class
