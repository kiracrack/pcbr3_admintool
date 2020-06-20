Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO

Public Class frmLoginAccount

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
        ConnectVerify()
        CreateNotExistingTable()
        LoadToComboBox("SELECT * FROM `action_query`.`tbltechnicalsupport` order by itname asc;", "itname", "itname", txtSolveby)
    End Sub

    Private Sub cmdset_Click(sender As Object, e As EventArgs) Handles cmdset.Click
        If txtSolveby.Text = "" Then
            MessageBox.Show("Please select user!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtSolveby.Focus()
            Exit Sub

        ElseIf txtpassword.Text = "" Then
            MessageBox.Show("Please enter password!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtpassword.Focus()
            Exit Sub
        End If

        Try
            If countqry("action_query.tbltechnicalsupport", "itname='" & rchar(txtSolveby.Text) & "' and password='" & rchar(txtpassword.Text) & "'") > 0 Then
                MessageBox.Show("Your password currently not encripted! Please change your password after login!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                If countqry("action_query.tbltechnicalsupport", "itname='" & rchar(txtSolveby.Text) & "' and password='" & EncryptTripleDES(LCase(txtSolveby.Text.Replace(" ", "")) & txtpassword.Text) & "'") = 0 Then
                    MessageBox.Show("Login not authorized!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtpassword.Focus()
                    Exit Sub
                End If
            End If
            loadAccounts(txtSolveby.Text)
            Me.Hide()
            frmMainMenu.Show()
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
    Public Function loadAccounts(ByVal fullname As String)
        com.CommandText = "select * from action_query.tbltechnicalsupport where itname ='" & txtSolveby.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            GlobalFullname = rst("itname").ToString
            GlobalApprover = rst("approver")
            GlobalApproverSequence = rst("approving_sequence")
            GlobalReportViewOnly = rst("reportviewing")
            GlobalLimited = rst("limited")
        End While
        rst.Close()
        Return 0
    End Function

    Private Sub txtSolveby_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtSolveby.SelectedValueChanged
        txtpassword.Focus()
    End Sub
   
End Class