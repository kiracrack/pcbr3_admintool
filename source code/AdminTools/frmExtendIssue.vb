Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO

Public Class frmExtendIssue

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
   
    Private Sub cmdset_Click(sender As Object, e As EventArgs) Handles cmdset.Click
        If MessageBox.Show("Are you sure you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
            com.CommandText = "update action_query.tbltechnicalreport set timeframe='" & ConvertDate(txtDateTarget.Text) & "' where id='" & id.Text & "'" : com.ExecuteNonQuery()
            frmTechnicalReport.TabFilter()
            MsgBox("Technical Report successfuly close!", MsgBoxStyle.Information)
            Me.Close()
        End If
    End Sub

End Class