Imports System.Globalization
Imports MySql.Data.MySqlClient

Public Class frmMBOTagging
    Private Sub frmMBOSetup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBranch()
    End Sub
    Private Sub LoadBranch()
        txtMBOName.Items.Clear()
        com.CommandText = "select * from action_query.tblmbosetup where branchcode='" & txtBranchcode.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtMBOName.Items.Add(New ComboBoxItem(rst("mboname").ToString, rst("mbobranchcode")))
        End While
        rst.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtMBOName.Text = "" Then
            MsgBox("Please select MBO name", vbExclamation)
            Exit Sub
        End If
        frmClientIdentifier.TagClientMBO(DirectCast(txtMBOName.SelectedItem, ComboBoxItem).HiddenValue(), txtMBOName.Text)
    End Sub
End Class
