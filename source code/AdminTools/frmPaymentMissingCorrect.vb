Imports System.Globalization

Public Class frmPaymentMissingCorrect

    Private Sub txtrefcode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtrefcode.KeyPress, txtuserid.KeyPress
        If e.KeyChar() = Chr(13) Then
            If txtrefcode.Text = "" Then
                txtrefcode.Focus()
                Exit Sub
            ElseIf txtuserid.Text = "" Then
                txtuserid.Focus()
                Exit Sub
            End If

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

            If countqry(db & ".lnwtermdet", "refno='" & txtrefcode.Text & "' and recby='" & txtuserid.Text & "'") = 0 Then
                txtLedger.Text = "TRANSACTION NOT FOUND"
            Else
                txtLedger.Text = "TRANSACTION FOUND"
            End If

            If countqry(db & ".lnwtermpay", "refno='" & txtrefcode.Text & "' and recby='" & txtuserid.Text & "'") = 0 Then
                txtProofsheet.Text = "TRANSACTION NOT FOUND"
            Else
                txtProofsheet.Text = "TRANSACTION FOUND"
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtrefcode.Text = "" And txtuserid.Text = "" Then
            MsgBox("Please enter Or number and userid!", MsgBoxStyle.Critical)
            txtrefcode.Focus()
            Exit Sub

        ElseIf txtLedger.Text = "TRANSACTION FOUND" And txtProofsheet.Text = "TRANSACTION FOUND" Then
            MsgBox("Cancel all posted transaction cannot be proceed!", MsgBoxStyle.Critical)
            txtrefcode.Focus()
            Exit Sub
        ElseIf txtLedger.Text = "TRANSACTION NOT FOUND" And txtProofsheet.Text = "TRANSACTION NOT FOUND" Then
            MsgBox("Nothing to cancel!", MsgBoxStyle.Critical)
            txtrefcode.Focus()
            Exit Sub
        ElseIf txtClient.Text = "" Then
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

            com.CommandText = "INSERT into action_query.lnwtermdet SELECT * FROM " & db & ".`lnwtermdet` where refno='" & txtrefcode.Text & "' and recby='" & txtuserid.Text & "'" : com.ExecuteNonQuery()
            com.CommandText = "INSERT into action_query.lnwtermpay SELECT * FROM " & db & ".`lnwtermpay` where refno='" & txtrefcode.Text & "' and recby='" & txtuserid.Text & "'" : com.ExecuteNonQuery()

            com.CommandText = "DELETE FROM " & db & ".`lnwtermdet` where refno='" & txtrefcode.Text & "' and recby='" & txtuserid.Text & "'" : com.ExecuteNonQuery()
            com.CommandText = "DELETE FROM " & db & ".`lnwtermpay` where refno='" & txtrefcode.Text & "' and recby='" & txtuserid.Text & "'" : com.ExecuteNonQuery()

            Dim getBranch As String = qrysingledata("branch", "(select branchname from master.branches where branchcode = master.userinfo.branchcode) as 'branch'", "master.userinfo  where userid = '" & DirectCast(txtClient.SelectedItem, ComboBoxItem).HiddenValue() & "'")
            com.CommandText = "INSERT into action_query.tbltechnicalreport set branchname='" & StrConv(getBranch, vbProperCase) & "', requestorname='" & txtClient.Text & "', concern='" & Me.Text & "',severitylvl='Critical', actiontaken='OR Number: " & txtrefcode.Text & "', performedby='" & GlobalFullname & "', datetrn=current_timestamp" : com.ExecuteNonQuery()
            txtrefcode.Text = "" : txtLedger.Text = "" : txtProofsheet.Text = ""
            txtLedger.BackColor = DefaultBackColor : txtLedger.ForeColor = DefaultForeColor
            txtProofsheet.BackColor = DefaultBackColor : txtProofsheet.ForeColor = DefaultForeColor
            MsgBox("Payment successfully cancelled!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub frmPaymentMissingCorrect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Private Sub txtLedger_TextChanged(sender As Object, e As EventArgs) Handles txtLedger.TextChanged
        If txtLedger.Text = "TRANSACTION NOT FOUND" Then
            txtLedger.BackColor = Color.Red
            txtLedger.ForeColor = Color.White
        Else
            txtLedger.BackColor = Color.YellowGreen
            txtLedger.ForeColor = Color.Black
        End If
    End Sub
    Private Sub txtProofsheet_TextChanged(sender As Object, e As EventArgs) Handles txtProofsheet.TextChanged
        If txtProofsheet.Text = "TRANSACTION NOT FOUND" Then
            txtProofsheet.BackColor = Color.Red
            txtProofsheet.ForeColor = Color.White
        Else
            txtProofsheet.BackColor = Color.YellowGreen
            txtProofsheet.ForeColor = Color.Black
        End If
    End Sub


End Class
