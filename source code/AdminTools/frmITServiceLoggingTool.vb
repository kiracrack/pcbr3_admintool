Imports System.Globalization

Public Class frmITServiceLoggingTool

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtBranch.Text = "" Then
            MsgBox("Please select branch!", MsgBoxStyle.Critical)
            txtBranch.Focus()
            Exit Sub
        ElseIf txtClient.Text = "" Then
            MsgBox("Please select client!", MsgBoxStyle.Critical)
            txtClient.Focus()
            Exit Sub
        ElseIf txtConcern.Text = "" Then
            MsgBox("Please enter concern!", MsgBoxStyle.Critical)
            txtConcern.Focus()
            Exit Sub
        ElseIf txtAction.Text = "" Then
            MsgBox("Please enter action taken!", MsgBoxStyle.Critical)
            txtAction.Focus()
            Exit Sub
        ElseIf txtSolveby.Text = "" Then
            MsgBox("Please select solved by!", MsgBoxStyle.Critical)
            txtSolveby.Focus()
            Exit Sub
        ElseIf ckPending.Checked = True And txtTechnical.Text = "" Then
            MsgBox("Please select technical person!", MsgBoxStyle.Critical)
            txtSolveby.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to continue?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            Dim strServices As String = ""
            If ckPending.Checked = True Then
                strServices = ",ontechnical=1, techsupport = '" & txtTechnical.Text & "', timeframe='" & ConvertDate(txtDateTarget.Text) & "' "
            End If
            Dim severity As String = ""
            If rad1.Checked = True Then
                severity = rad1.Text
            ElseIf rad2.Checked = True Then
                severity = rad2.Text
            ElseIf rad3.Checked = True Then
                severity = rad3.Text
            ElseIf rad4.Checked = True Then
                severity = rad4.Text
            ElseIf rad5.Checked = True Then
                severity = rad5.Text
            End If
            com.CommandText = "INSERT into action_query.tbltechnicalreport set ticketno='" & txtTicketNumber.Text & "', branchname='" & txtBranch.Text & "', requestorname='" & txtClient.Text & "', concern='" & rchar(txtConcern.Text) & "', actiontaken='" & rchar(txtAction.Text) & "',severitylvl='" & severity & "', performedby='" & txtSolveby.Text & "', datetrn=current_timestamp, pending='" & ckPending.CheckState & "' " & strServices : com.ExecuteNonQuery()
            txtConcern.Text = "" : txtAction.Text = "" : ckPending.Checked = False
            MsgBox("Report Successfully save!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub frmLoanAdjustment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
    End Sub
    Public Sub loaddata()
        LoadToComboBox("select * from master.branches order by branchname asc", "branchname", "branchcode", txtBranch)
        LoadToComboBox("SELECT * FROM `master`.`userinfo` order by username asc;", "username", "userid", txtClient)
        LoadToComboBox("SELECT distinct concern FROM `action_query`.`tbltechnicalreport` order by concern asc;", "concern", "concern", txtConcern)
        LoadToComboBox("SELECT * FROM `action_query`.`tbltechnicalsupport` order by itname asc;", "itname", "itname", txtSolveby)
        LoadToComboBox("SELECT * FROM `action_query`.`tbltechnicalsupport` order by itname asc;", "itname", "itname", txtTechnical)
    End Sub

    Private Sub ckPending_CheckedChanged(sender As Object, e As EventArgs) Handles ckPending.CheckedChanged
        If ckPending.Checked = True Then
            txtTechnical.Enabled = True
            txtDateTarget.Enabled = True
            If countqry("action_query.tbltechnicalreport", "ticketno<>'' and ticketno is not null") = 0 Then
                txtTicketNumber.Text = qrysingledata("ticket", "SUBSTRING(FLOOR(RAND() * 99999 + 100000), 2) as 'ticket'", "action_query.tbltechnicalreport limit 1")
            Else
                txtTicketNumber.Text = qrysingledata("ticket", "SUBSTRING(FLOOR(RAND() * 99999 + ticketno), 2) as 'ticket'", "action_query.tbltechnicalreport where ticketno<>'' and ticketno is not null order by  datetrn desc limit 1")
            End If
        Else
            txtTechnical.Enabled = False
            txtDateTarget.Enabled = False
            txtTechnical.Text = ""
            txtTicketNumber.Text = ""
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rad5.CheckedChanged

    End Sub
End Class
