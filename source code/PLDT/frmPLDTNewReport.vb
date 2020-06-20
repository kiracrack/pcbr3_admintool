Imports System.Globalization

Public Class frmPLDTNewReport
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtOfficeName.Text = "" Then
            MsgBox("Please enter office name!", MsgBoxStyle.Exclamation, "Error Message")
            txtOfficeName.Focus()
            Exit Sub
        ElseIf txtIssue.Text = "" Then
            MsgBox("Please enter report issue!", MsgBoxStyle.Exclamation, "Error Message")
            txtIssue.Focus()
            Exit Sub
        ElseIf txtIncedentNumber.Text = "" Then
            MsgBox("Please enter PLDT incedent number!", MsgBoxStyle.Exclamation, "Error Message")
            txtIncedentNumber.Focus()
            Exit Sub
        End If
        com.CommandText = "insert into action_query.tblpldtreport set officeid='" & officeid.Text & "', downdate='" & ConvertDate(txtDateDown.Value) & "', downtime='" & ConvertTime(txtTimeDown.Value) & "',issue='" & rchar(txtIssue.Text) & "', incendentnumber='" & txtIncedentNumber.Text & "', reporteddate=current_timestamp, reportby='" & GlobalFullname & "'" : com.ExecuteNonQuery()
        ClearFields()
        frmPLDTOffices.FilterOffice()
        MsgBox("Office Successfully reported!", MsgBoxStyle.Information)
        Me.Close()
    End Sub
    Public Sub ClearFields()
        txtOfficeName.Text = ""
        txtIssue.Text = ""
        txtOfficeName.Text = ""
        txtIncedentNumber.Text = ""
        mode.Text = ""
        officeid.Text = ""
    End Sub
End Class
