Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO

Public Class frmChangePassword
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmRequestType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If System.IO.File.Exists(file_conn) = False Then
            frmConnectionSetup.ShowDialog()
            End
        End If
        txtNewPasssword.Text = ""
        txtVerifypassword.Text = ""
    End Sub

    Private Sub cmdset_Click(sender As Object, e As EventArgs) Handles cmdset.Click
        If txtNewPasssword.Text = "" Then
            MessageBox.Show("Please enter new password!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtNewPasssword.Focus()
            Exit Sub

        ElseIf txtVerifypassword.Text = "" Then
            MessageBox.Show("Please verify password!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtVerifypassword.Focus()
            Exit Sub

        ElseIf txtVerifypassword.Text <> txtNewPasssword.Text Then
            MessageBox.Show("Password did not match!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtVerifypassword.Focus()
            Exit Sub
        End If


        Try
            com.CommandText = "update action_query.tbltechnicalsupport set password='" & EncryptTripleDES(LCase(GlobalFullname.Replace(" ", "")) & txtVerifypassword.Text) & "' where itname='" & GlobalFullname & "'" : com.ExecuteNonQuery()
            MsgBox("Your Password Successfuly Changed", vbInformation)
            Me.Close()
        Catch errMYSQL As MySqlException
            MessageBox.Show("Message:" & errMYSQL.Message, vbCrLf _
                            & "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Catch errMS As Exception
            MessageBox.Show("Message:" & errMS.Message & vbCrLf, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

    End Sub

    Private Sub txtSolveby_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtSolveby_SelectedValueChanged(sender As Object, e As EventArgs)
        txtVerifypassword.Focus()
    End Sub
End Class