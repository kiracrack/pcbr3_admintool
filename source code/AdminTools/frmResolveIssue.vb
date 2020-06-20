Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO

Public Class frmResolveIssue

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmRequestType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadToComboBox("SELECT * FROM `action_query`.`tbltechnicalsupport` order by itname asc;", "itname", "itname", txtTechnical)
        loadInformation()
    End Sub
    Public Sub loadInformation()
        com.CommandText = "select * from action_query.tbltechnicalreport where id='" & id.Text & "' " : rst = com.ExecuteReader
        While rst.Read
            txtRevise.Text = rst("actiontaken").ToString
            txtTechnical.Text = rst("techsupport").ToString
            txtDateTarget.Text = rst("timeframe").ToString
            txtRemarks.Text = rst("remarks").ToString
            If rst("severitylvl").ToString = "Enhancement" Then
                rad1.Checked = True
            ElseIf rst("severitylvl").ToString = "Minor" Then
                rad2.Checked = True
            ElseIf rst("severitylvl").ToString = "Normal" Then
                rad3.Checked = True
            ElseIf rst("severitylvl").ToString = "Major" Then
                rad4.Checked = True
            ElseIf rst("severitylvl").ToString = "Critical" Then
                rad5.Checked = True
            End If
        End While
        rst.Close()
    End Sub
    Private Sub cmdset_Click(sender As Object, e As EventArgs) Handles cmdset.Click
        If MessageBox.Show("Are you sure you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
            Dim issueresolved As String = ""
            If CheckBox1.Checked = True Then
                issueresolved = " pending=0, dateclose=current_timestamp, "
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

            com.CommandText = "update action_query.tbltechnicalreport set " & issueresolved & " severitylvl='" & severity & "', techsupport='" & txtTechnical.Text & "', timeframe='" & ConvertDate(txtDateTarget.Text) & "',  actiontaken='" & rchar(txtRevise.Text) & "',remarks='" & rchar(txtRemarks.Text) & "' where id='" & id.Text & "'" : com.ExecuteNonQuery()
            frmTechnicalReport.TabFilter()
            MsgBox("Technical Report successfuly close!", MsgBoxStyle.Information)
            Me.Close()
        End If
    End Sub
 

    Private Sub txtSolveby_SelectedValueChanged(sender As Object, e As EventArgs)
        txtRemarks.Focus()
    End Sub
End Class