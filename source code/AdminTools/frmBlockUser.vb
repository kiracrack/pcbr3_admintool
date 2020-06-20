Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO

Public Class frmBlockUser

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmRequestType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadToComboBox("SELECT * FROM `master`.`userinfo` order by username asc;", "username", "userid", txtClient)
    End Sub

    Private Sub cmdset_Click(sender As Object, e As EventArgs) Handles cmdset.Click
        If txtRemarks.Text = "" Then
            MsgBox("Please enter valid reason for blocking user!")
            txtRemarks.Focus()
            Exit Sub
        ElseIf txtClient.Text = "" Then
            MsgBox("Please select request by!")
            txtClient.Focus()
            Exit Sub
        ElseIf userid.Text = "" Then
            MsgBox("Please enter pcbr3 authorized user id!")
            userid.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to continue? " & Environment.NewLine & Environment.NewLine & "Note: Only selected unblocked user will proceed to this function", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
            frmUserAccounts.BlockUser(rchar(txtRemarks.Text), rchar(userid.Text), txtClient.Text, CheckBox1.CheckState)
            Me.Close()
        End If
    End Sub


    Private Sub txtSolveby_SelectedValueChanged(sender As Object, e As EventArgs)
        txtRemarks.Focus()
    End Sub
End Class