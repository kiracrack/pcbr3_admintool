Imports System.Globalization

Public Class frmLoanAdjustment

    Private Sub txtrefcode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtrefcode.KeyPress
        If e.KeyChar() = Chr(13) Then
            checkAdjustment()
        End If
    End Sub
    Private Sub frmLoanAdjustment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtYear.Items.Add(Now.AddYears(-1).ToString("yyyy"))
        txtYear.Items.Add(Now.ToString("yyyy"))

        ListView1.View = View.Details
        ListView1.Columns.Add("id", 20, HorizontalAlignment.Left)
        ListView1.Columns.Add("refno", 70, HorizontalAlignment.Center)
        ListView1.Columns.Add("ClientName", 150, HorizontalAlignment.Left)
        ListView1.Columns.Add("Amount", 100, HorizontalAlignment.Right)
        LoadToComboBox("SELECT * FROM `master`.`userinfo` order by username asc;", "username", "userid", txtClient)

    End Sub
    Public Sub checkAdjustment()
        Dim db As String = ""
        If CheckBox1.Checked = True Then
            db = "master"
        Else
            If txtYear.Text = "" Then
                MsgBox("Please select year", MsgBoxStyle.Exclamation)
                txtYear.Focus()
                Exit Sub
            ElseIf txtMonth.Text = "" Then
                MsgBox("Please select month", MsgBoxStyle.Exclamation)
                txtMonth.Focus()
                Exit Sub
            End If
            Dim mo As Date = txtMonth.Text & " 01, " & txtYear.Text
            db = "db" & txtYear.Text & mo.ToString("MM")
        End If



        If countqry(db & ".loanadj", "refno in (select refno from  master.loanwithterm inner join master.client " _
                                        + " on loanwithterm.custcode = client.custcode where " _
                                        + " concat(lname,', ',fname) like '%" & txtrefcode.Text & "%' or " _
                                        + " refno like '%" & txtrefcode.Text & "%')") = 0 Then
            Button1.Enabled = False
            MsgBox("No record found", vbExclamation)
        Else
            ListView1.Items.Clear()
            com.CommandText = "select *, (select concat(lname,', ',fname, ' ', mname) from  master.loanwithterm inner join master.client " _
                                        + " on loanwithterm.custcode = client.custcode where refno = loanadj.refno) as 'clientName' from " & db & ".loanadj where refno in (select refno from  master.loanwithterm inner join master.client " _
                                        + " on loanwithterm.custcode = client.custcode where " _
                                        + " concat(lname,', ',fname) like '%" & txtrefcode.Text & "%' or " _
                                        + " refno like '%" & txtrefcode.Text & "%')" : rst = com.ExecuteReader
            While rst.Read
                Dim item1 As New ListViewItem(UCase(rst("trackingnumber").ToString), 0)
                item1.SubItems.Add(rst("refno").ToString)
                item1.SubItems.Add(UCase(rst("clientName").ToString))
                item1.SubItems.Add(FormatNumber(rst("principal").ToString, 2))
                ListView1.Items.AddRange(New ListViewItem() {item1})
            End While
            rst.Close()

            If ListView1.Items.Count > 0 Then
                Button1.Enabled = True
            Else
                MsgBox("No record found", vbExclamation)
            End If
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
            Dim db As String = ""
            If CheckBox1.Checked = True Then
                db = "master"
            Else
                If txtYear.Text = "" Then
                    MsgBox("Please select year", MsgBoxStyle.Exclamation)
                    txtYear.Focus()
                    Exit Sub
                ElseIf txtMonth.Text = "" Then
                    MsgBox("Please select month", MsgBoxStyle.Exclamation)
                    txtMonth.Focus()
                    Exit Sub
                End If
                Dim mo As Date = txtMonth.Text & " 01, " & txtYear.Text
                db = "db" & txtYear.Text & mo.ToString("MM")
            End If

            For Each itm As ListViewItem In ListView1.Items
                If itm.Checked Then
                    ' com.CommandText = "update tblcriteriacategory set activated=1, lastcategory=" & ckLastCategory.CheckState & "  where categoryid='" & itm.SubItems(1).Text & "'" : com.ExecuteNonQuery()
                    ' MsgBox(itm.SubItems(0).Text & " - " & itm.SubItems(1).Text)
                    com.CommandText = "INSERT into action_query.loanadj SELECT * FROM " & db & ".`loanadj` where trackingnumber='" & itm.SubItems(0).Text & "'" : com.ExecuteNonQuery()
                    com.CommandText = "DELETE FROM " & db & ".`loanadj` where trackingnumber='" & itm.SubItems(0).Text & "'" : com.ExecuteNonQuery()

                    Dim getBranch As String = qrysingledata("branch", "(select branchname from master.branches where branchcode = master.loanwithterm.branchcode) as 'branch'", "master.loanwithterm  where refno = '" & itm.SubItems(1).Text & "'")
                    com.CommandText = "INSERT into action_query.tbltechnicalreport set branchname='" & StrConv(getBranch, vbProperCase) & "', requestorname='" & txtClient.Text & "', concern='" & Me.Text & "', actiontaken='Refno: " & itm.SubItems(1).Text & "',severitylvl='Critical', performedby='" & GlobalFullname & "', datetrn=current_timestamp" : com.ExecuteNonQuery()
                End If
            Next
            checkAdjustment()
            MsgBox("Adjustment successfully removed!", MsgBoxStyle.Information)
        End If
    End Sub

 

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtYear.SelectedIndex = -1
            txtYear.Enabled = False
            txtMonth.SelectedIndex = -1
            txtMonth.Enabled = False
        Else
            txtYear.Enabled = True
            txtMonth.Enabled = True
        End If
    End Sub
End Class
