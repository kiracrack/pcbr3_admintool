Imports System.Globalization

Public Class frmLoanReleasedCancellation

    Private Sub txtrefcode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtrefcode.KeyPress
        If e.KeyChar() = Chr(13) Then

            If countqry("master.loanwithterm", "refno='" & txtrefcode.Text & "'") = 0 Then
                txtName.Text = "" : txtAmount.Text = ""
                Button1.Enabled = False
                MsgBox("No record found", vbExclamation)
            Else
                com.CommandText = "select *, (select concat(ucase(lname) ,', ', ucase(fname)) from master.client  where custcode =  loanwithterm.custcode)  as cname from master.loanwithterm where refno='" & txtrefcode.Text & "'" : rst = com.ExecuteReader
                If rst.Read Then
                    Button1.Enabled = True
                    txtName.Text = rst("cname").ToString
                    txtAmount.Text = FormatNumber(rst("principal").ToString, 2)
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
            com.CommandText = "INSERT into action_query.loanwithterm SELECT * FROM master.loanwithterm where refno='" & txtrefcode.Text & "'" : com.ExecuteNonQuery()
            com.CommandText = "INSERT into action_query.lnamortsked SELECT * FROM master.lnamortsked where refno='" & txtrefcode.Text & "'" : com.ExecuteNonQuery()

            com.CommandText = "DELETE FROM master.loanwithterm where refno='" & txtrefcode.Text & "'" : com.ExecuteNonQuery()
            com.CommandText = "DELETE FROM master.lnamortsked where refno='" & txtrefcode.Text & "'" : com.ExecuteNonQuery()
            Dim getBranch As String = qrysingledata("branch", "(select branchname from master.branches where branchcode = master.loanwithterm.branchcode) as 'branch'", "master.loanwithterm  where refno = '" & txtrefcode.Text & "'")
            com.CommandText = "INSERT into action_query.tbltechnicalreport set branchname='" & StrConv(getBranch, vbProperCase) & "', requestorname='" & txtClient.Text & "', concern='" & Me.Text & "', actiontaken='Refno: " & txtrefcode.Text & "',severitylvl='Critical', performedby='" & GlobalFullname & "', datetrn=current_timestamp" : com.ExecuteNonQuery()
            txtrefcode.Text = "" : txtName.Text = "" : txtAmount.Text = ""
            MsgBox("Loan successfully removed!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub frmLoanAdjustment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadToComboBox("SELECT * FROM `master`.`userinfo` order by username asc;", "username", "userid", txtClient)
    End Sub
 

End Class
