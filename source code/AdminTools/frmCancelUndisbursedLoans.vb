Imports System.Globalization

Public Class frmCancelUndisbursedLoans

    Private Sub frmLoanAdjustment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ls.View = View.Details
        ls.Columns.Add("PN#", 70, HorizontalAlignment.Center)
        ls.Columns.Add("Branch", 120, HorizontalAlignment.Left)
        ls.Columns.Add("Account Name", 170, HorizontalAlignment.Left)
        ls.Columns.Add("Product", 170, HorizontalAlignment.Left)
        ls.Columns.Add("Loan Date", 80, HorizontalAlignment.Center)
        ls.Columns.Add("Loan Amount", 90, HorizontalAlignment.Right)
        ViewLoanProfile()
    End Sub

    Public Sub ViewLoanProfile()
        ls.Items.Clear()
        com.CommandText = "select *,(select concat(lname, ', ',fname,' ',mname) from master.client where custcode = loanwithterm.custcode) as 'client', " _
                + " (select prodname from master.loanprod where prodcode =loanwithterm.loanprod) as 'product', date_format(loandate,'%Y-%m-%d') as 'dt', " _
                + " (select branchname from branches where branchcode = loanwithterm.branchcode) as 'branch' from  master.loanwithterm where paid=0 and cancelled=0 and ( refno like '%" & rchar(txtSearch.Text) & "%' or (select concat(lname, ', ',fname,' ',mname) from master.client where custcode = loanwithterm.custcode) like '%" & rchar(txtSearch.Text) & "%')" : rst = com.ExecuteReader
        While rst.Read
            Dim item1 As New ListViewItem(UCase(rst("refno").ToString), 0)
            item1.SubItems.Add(rst("branch").ToString)
            item1.SubItems.Add(rst("client").ToString)
            item1.SubItems.Add(rst("product").ToString)
            item1.SubItems.Add(rst("dt").ToString)
            item1.SubItems.Add(FormatNumber(rst("principal").ToString, 2))
            ls.Items.AddRange(New ListViewItem() {item1})
        End While
        rst.Close()

    End Sub

    Private Sub ls_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ls.SelectedIndexChanged, ls.ItemCheck, ls.ItemChecked
        If ls.CheckedItems.Count > 0 And userid.Text <> "" Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MessageBox.Show("Are you sure you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            For Each itm As ListViewItem In ls.Items
                If itm.Checked Then
                    com.CommandText = "update master.loanwithterm set cancelled=1, cancelledby='" & userid.Text & "' where refno ='" & itm.SubItems(0).Text & "'" : com.ExecuteNonQuery()
                    com.CommandText = "INSERT into action_query.tbltechnicalreport set branchname='" & StrConv(itm.SubItems(1).Text, vbProperCase) & "', requestorname='Admin Tool', concern='" & Me.Text & "', actiontaken='" & itm.SubItems(0).Text & " - " & itm.SubItems(2).Text & Environment.NewLine & "Product: " & itm.SubItems(3).Text & Environment.NewLine & "Amount: " & itm.SubItems(5).Text & "', performedby='" & GlobalFullname & "', datetrn=current_timestamp" : com.ExecuteNonQuery()
                End If
            Next
            ViewLoanProfile()
            MsgBox("Selected account successfully cancelled!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        If txtSearch.Text = "" Then Exit Sub
        If e.KeyChar() = Chr(13) Then
            ViewLoanProfile()
        End If
    End Sub
 
    Private Sub userid_TextChanged(sender As Object, e As EventArgs) Handles userid.TextChanged
        If ls.CheckedItems.Count > 0 And userid.Text <> "" Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If
    End Sub
End Class
