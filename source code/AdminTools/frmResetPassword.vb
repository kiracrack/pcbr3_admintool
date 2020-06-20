Imports System.Globalization

Public Class frmResetPassword
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmUnblockClearLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
     
    End Sub
 
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtpassword.Text = "" Or txtpassword.Text = "Password" Then
            MsgBox("Please enter password ", vbExclamation)
            txtpassword.Focus()
            Exit Sub

        ElseIf txtpassword.Text.Contains(" ") = True Then
            MsgBox("Please enter password without space character", vbExclamation)
            txtpassword.Focus()
            Exit Sub

        ElseIf txtpassword.Text.Length < 4 Then
            MsgBox("Please enter password atleast 4 character lenght", vbExclamation)
            txtpassword.Focus()
            Exit Sub

        ElseIf txtpassword.Text <> txtverify.Text Then
            MsgBox("Password did not match", vbExclamation)
            txtpassword.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            com.CommandText = "UPDATE `master`.`userinfo` set accesscode=password(concat('" & txtverify.Text & "','" & txtUserID.Text & "')) where userid='" & txtUserID.Text & "';" : com.ExecuteNonQuery()

            com.CommandText = "INSERT into action_query.tbltechnicalreport set branchname='" & StrConv(txtBranch.Text, vbProperCase) & "', requestorname='" & Me.Text & "', concern='Change user password', actiontaken='User Account',severitylvl='Critical', performedby='" & GlobalFullname & "', datetrn=current_timestamp" : com.ExecuteNonQuery()
            txtpassword.Text = "Password" : txtverify.Text = "Password" : txtpassword.Focus()
            MsgBox("Password successfully changed!", MsgBoxStyle.Information)
        End If

    End Sub
End Class
