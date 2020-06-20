Imports System.Globalization

Public Class frmFullPaymentCencellation

    Private Sub txtrefcode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtrefcode.KeyPress
        If e.KeyChar() = Chr(13) Then
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

            If countqry(db & ".lnwtermdet", "refno='" & txtrefcode.Text & "'") = 0 Then
                txtName.Text = "" : txtAmount.Text = ""
                Button1.Enabled = False
                MsgBox("No record found", vbExclamation)
            Else
                com.CommandText = "select *, (select concat(ucase(lname) ,', ', ucase(fname)) from master.client  inner join master.loanwithterm on client.custcode = loanwithterm.custcode where loanwithterm.refno =  lnwtermdet.lnrefno)  as cname from " & db & ".lnwtermdet where refno='" & txtrefcode.Text & "'" : rst = com.ExecuteReader
                If rst.Read Then
                    Button1.Enabled = True
                    txtName.Text = rst("cname").ToString
                    txtAmount.Text = FormatNumber(rst("principal").ToString, 2)
                    loanref.Text = rst("lnrefno")
                Else
                    txtName.Text = ""
                    txtAmount.Text = ""
                    Button1.Enabled = False
                    MsgBox("No record found", vbExclamation)
                End If
                rst.Close()
            End If
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
                Dim mo As Date = txtMonth.Text & " 01, " & txtYear.Text
                db = "db" & txtYear.Text & mo.ToString("MM")
            End If
            com.CommandText = "INSERT into action_query.lnwtermdet SELECT * FROM " & db & ".`lnwtermdet` where refno='" & txtrefcode.Text & "'" : com.ExecuteNonQuery()
            com.CommandText = "INSERT into action_query.lnwtermpay SELECT * FROM " & db & ".`lnwtermpay` where refno='" & txtrefcode.Text & "'" : com.ExecuteNonQuery()
            com.CommandText = "DELETE FROM " & db & ".`lnwtermdet` where refno='" & txtrefcode.Text & "'" : com.ExecuteNonQuery()
            com.CommandText = "DELETE FROM " & db & ".`lnwtermpay` where refno='" & txtrefcode.Text & "'" : com.ExecuteNonQuery()

            Dim getBranch As String = qrysingledata("branch", "(select branchname from master.branches where branchcode = master.loanwithterm.branchcode) as 'branch'", "master.loanwithterm  where refno = '" & loanref.Text & "'")
            com.CommandText = "INSERT into action_query.tbltechnicalreport set branchname='" & StrConv(getBranch, vbProperCase) & "', requestorname='" & txtClient.Text & "', concern='" & Me.Text & "',severitylvl='Critical', actiontaken='Refno: " & txtrefcode.Text & "Client Name: " & txtName.Text & "Amount: " & txtAmount.Text & "', performedby='" & GlobalFullname & "', datetrn=current_timestamp" : com.ExecuteNonQuery()
            txtrefcode.Text = "" : txtName.Text = "" : txtAmount.Text = ""
            MsgBox("Payment successfully removed!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub frmLoanAdjustment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtYear.Items.Add(Now.AddYears(-1).ToString("yyyy"))
        txtYear.Items.Add(Now.ToString("yyyy"))
        LoadToComboBox("SELECT * FROM `master`.`userinfo` order by username asc;", "username", "userid", txtClient)
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
