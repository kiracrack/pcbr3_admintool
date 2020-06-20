Imports System.Globalization

Public Class frmRemoveGTicket

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtBranch.Text = "" Then
            MsgBox("Please select branch!", MsgBoxStyle.Critical)
            txtBranch.Focus()
            Exit Sub
        ElseIf txtClient.Text = "" Then
            MsgBox("Please select request by!", MsgBoxStyle.Critical)
            txtClient.Focus()
            Exit Sub
        ElseIf txtTotalTickets.Text = "" Or Val(txtTotalTickets.Text) = 0 Then
            MsgBox("There's no ticket to remove!", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If MessageBox.Show("Are you sure you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            Dim db As String = "db" & txtDateTransaction.Value.ToString("yyyyMM")
            com.CommandText = "INSERT into action_query.glticket SELECT * FROM " & db & ".`glticket` where branchcode='" & DirectCast(txtBranch.SelectedItem, ComboBoxItem).HiddenValue() & "' and trndate='" & ConvertDate(txtDateTransaction.Value) & "'" : com.ExecuteNonQuery()
            com.CommandText = "DELETE FROM " & db & ".`glticket` where branchcode='" & DirectCast(txtBranch.SelectedItem, ComboBoxItem).HiddenValue() & "' and trndate='" & ConvertDate(txtDateTransaction.Value) & "'" : com.ExecuteNonQuery()


            Dim getBranch As String = qrysingledata("branchname", "branchname", "master.branches where branchcode = '" & DirectCast(txtBranch.SelectedItem, ComboBoxItem).HiddenValue() & "'")
            com.CommandText = "INSERT into action_query.tbltechnicalreport set branchname='" & StrConv(getBranch, vbProperCase) & "', requestorname='" & txtClient.Text & "', concern='" & Me.Text & "',severitylvl='Critical', actiontaken='REMOVED GL TICKET. DATED " & ConvertDate(txtDateTransaction.Value) & "', performedby='" & GlobalFullname & "', datetrn=current_timestamp" : com.ExecuteNonQuery()
            MsgBox("GL Ticket successfully removed!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub frmRemoveGTicket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDateTransaction.Value = CDate(Now.ToShortDateString)
        LoadToComboBox("SELECT * FROM `master`.`userinfo` order by username asc;", "username", "userid", txtClient)
        LoadToComboBox("select * from master.branches order by branchname asc", "branchname", "branchcode", txtBranch)
    End Sub

  
    Private Sub txtBranch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtBranch.SelectedIndexChanged
        countTransaction()
    End Sub

    Private Sub txtDateTransaction_ValueChanged(sender As Object, e As EventArgs) Handles txtDateTransaction.ValueChanged
        countTransaction()
    End Sub
    Public Sub countTransaction()
        txtTotalTickets.Text = ""
        If txtBranch.Text = "" Then Exit Sub
        Dim db As String = "db" & txtDateTransaction.Value.ToString("yyyyMM")
        txtTotalTickets.Text = FormatNumber(qrysingledata("cnt", "count(*) as cnt", "" & db & ".`glticket` where branchcode='" & DirectCast(txtBranch.SelectedItem, ComboBoxItem).HiddenValue() & "' and trndate='" & ConvertDate(txtDateTransaction.Value) & "'"), 0)
    End Sub

    Private Sub txtTotalTickets_TextChanged(sender As Object, e As EventArgs) Handles txtTotalTickets.TextChanged
        If txtTotalTickets.Text = "" Or Val(txtTotalTickets.Text) = 0 Then
            Button1.Enabled = False
        Else
            Button1.Enabled = True
        End If
    End Sub
End Class
