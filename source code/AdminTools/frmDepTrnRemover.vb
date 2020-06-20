Imports System.Globalization

Public Class frmDepTrnRemover

    Private Sub txtrefcode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtrefcode.KeyPress
        If e.KeyChar() = Chr(13) Then
            Dim mo As Date = txtMonth.Text & " 01, " & txtYear.Text
            Dim db As String = "db" & txtYear.Text & mo.ToString("MM")
            If countqry(db & ".loanadj", "refno='" & txtrefcode.Text & "'") = 0 Then
                txtName.Text = ""
                Button1.Enabled = False
                MsgBox("No record found", vbExclamation)
            Else
                com.CommandText = "select concat(ucase(lname) ,', ', ucase(fname)) as cname from master.client inner join master.loanwithterm on client.custcode = loanwithterm.custcode where refno='" & txtrefcode.Text & "'" : rst = com.ExecuteReader
                If rst.Read Then
                    Button1.Enabled = True
                    txtName.Text = rst("cname").ToString
                Else
                    txtName.Text = ""
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
            Dim mo As Date = txtMonth.Text & " 01, " & txtYear.Text
            Dim db As String = "db" & txtYear.Text & mo.ToString("MM")
            com.CommandText = "INSERT into action_query.loanadj SELECT * FROM " & db & ".`loanadj` where refno='" & txtrefcode.Text & "'" : com.ExecuteNonQuery()
            com.CommandText = "DELETE FROM " & db & ".`loanadj` where refno='" & txtrefcode.Text & "'" : com.ExecuteNonQuery()

            Dim getBranch As String = qrysingledata("branch", "(select branchname from master.branches where branchcode = master.loanwithterm.branchcode) as 'branch'", "master.loanwithterm  where refno = '" & txtrefcode.Text & "'")
            com.CommandText = "INSERT into action_query.tbltechnicalreport set branchname='" & StrConv(getBranch, vbProperCase) & "',severitylvl='Critical', requestorname='" & txtClient.Text & "', concern='" & Me.Text & "', actiontaken='Refno: " & txtrefcode.Text & "Client Name: " & txtName.Text & "', performedby='" & GlobalFullname & "', datetrn=current_timestamp" : com.ExecuteNonQuery()
            txtrefcode.Text = "" : txtName.Text = ""
            MsgBox("Adjustment successfully removed!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub frmLoanAdjustment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtYear.Items.Add(Now.AddYears(-1).ToString("yyyy"))
        txtYear.Items.Add(Now.ToString("yyyy"))
        LoadToComboBox("SELECT * FROM `master`.`userinfo` order by username asc;", "username", "userid", txtClient)
    End Sub
End Class
