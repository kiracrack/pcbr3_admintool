Imports System.Globalization

Public Class frmClientLoanProfile

    Private Sub frmLoanAdjustment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.View = View.Details
        ListView1.Columns.Add("PN#", 70, HorizontalAlignment.Center)
        ListView1.Columns.Add("Product", 170, HorizontalAlignment.Left)
        ListView1.Columns.Add("Loan Date", 80, HorizontalAlignment.Center)
        ListView1.Columns.Add("Loan Amount", 90, HorizontalAlignment.Right)
        ListView1.Columns.Add("Balance", 90, HorizontalAlignment.Right)
        ListView1.Columns.Add("Amort. Sched", 90, HorizontalAlignment.center)
     End Sub

    Public Sub ViewLoanProfile()
        ListView1.Items.Clear()
        com.CommandText = "select *,(select prodname from master.loanprod where prodcode =loanwithterm.loanprod) as 'product', date_format(loandate,'%Y-%m-%d') as 'dt',ifnull((select count(*) from lnamortsked where refno=loanwithterm.refno),'Not Found') as 'amortsched' from  master.loanwithterm where custcode = '" & DirectCast(txtClient.SelectedItem, ComboBoxItem).HiddenValue() & "'" : rst = com.ExecuteReader
        While rst.Read
            Dim item1 As New ListViewItem(UCase(rst("refno").ToString), 0)
            item1.SubItems.Add(rst("product").ToString)
            item1.SubItems.Add(rst("dt").ToString)
            item1.SubItems.Add(FormatNumber(rst("principal").ToString, 2))
            item1.SubItems.Add(FormatNumber(rst("pribal").ToString, 2))
            item1.SubItems.Add(rst("amortsched").ToString)
            ListView1.Items.AddRange(New ListViewItem() {item1})
        End While
        rst.Close()
    End Sub

    Private Sub txtClient_KeyDown(sender As Object, e As KeyEventArgs) Handles txtClient.KeyDown
        If e.KeyData = Keys.Enter Then
            If txtClient.Text = "" Or txtClient.Text = "%" Then Exit Sub
            Dim cnt = 0 : Dim lname As String = "" : Dim fname As String = ""
            For Each word In txtClient.Text.Split(New Char() {","c})
                If cnt = 0 Then
                    lname = Trim(word)
                ElseIf cnt = 1 Then
                    fname = Trim(word)
                End If
                cnt = cnt + 1
            Next
            If countqry("master.client", " concat(ucase(lname),', ',ucase(fname),' ',ucase(mname))  = '" & txtClient.Text & "'") = 0 Then
                LoadToComboBox("SELECT custcode, concat(ucase(lname),', ',ucase(fname),' ',ucase(mname)) as 'clientname' FROM `master`.`client`  where lname  like '%" & lname & "%' and fname  like '%" & fname & "%' order by lname asc;", "clientname", "custcode", txtClient)
                txtClient.DroppedDown = True
            Else
                ViewLoanProfile()
            End If
        End If
    End Sub

    Private Sub ViewTransactionDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewTransactionDetailsToolStripMenuItem.Click
        For Each itm As ListViewItem In ListView1.Items
            If itm.Selected Then
                frmLoanProfile.txtRefno.Text = itm.SubItems(0).Text
                frmLoanProfile.Text = "Loan Profile of " & txtClient.Text
                frmLoanProfile.ShowDialog(Me)
            End If
        Next
    End Sub
End Class
