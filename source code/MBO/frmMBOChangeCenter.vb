Imports System.Globalization
Imports MySql.Data.MySqlClient

Public Class frmMBOChangeCenter
    Private Sub frmMBOSetup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'com.CommandText = "select (select replace(username,'_',' ') from master.userinfo where userid=g_center.accountofficer) as ao from master.g_center where centerkey='" & txtCurrentCenterKey.Text & "'" : rst = com.ExecuteReader
        'While rst.Read
        '    txtCurrentCenter.Text = rst("ao").ToString
        '    txtAO.Text = rst("ao").ToString
        'End While
        'rst.Close()
        LoadCenter()
    End Sub
    Private Sub LoadGroup()
        txtGroup.Items.Clear()
        com.CommandText = "select * from master.g_group where centerkey='" & centerkey.Text & "' order by groupname asc" : rst = com.ExecuteReader
        While rst.Read
            txtGroup.Items.Add(New ComboBoxItem(rst("groupname").ToString, rst("groupkey")))
        End While
        rst.Close()
    End Sub

    Private Sub txtGroup_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtGroup.SelectedValueChanged
        groupkey.Text = DirectCast(txtGroup.SelectedItem, ComboBoxItem).HiddenValue()

    End Sub
    Private Sub LoadCenter()
        txtCenter.Items.Clear()
        com.CommandText = "select * from master.g_center order by centername asc" : rst = com.ExecuteReader
        While rst.Read
            txtCenter.Items.Add(New ComboBoxItem(rst("centername").ToString, rst("centerkey")))
        End While
        rst.Close()
    End Sub
    Private Sub txtCenter_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtCenter.SelectedValueChanged
        centerkey.Text = DirectCast(txtCenter.SelectedItem, ComboBoxItem).HiddenValue()
        com.CommandText = "select (select username from master.userinfo where userid=g_center.accountofficer) as ao from master.g_center where centerkey='" & centerkey.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtAccountOfficer.Text = rst("ao").ToString
        End While
        rst.Close()
        LoadGroup()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtGroup.Text = "" Then
            MsgBox("Please select group", vbExclamation)
            Exit Sub
        End If
        If txtCenter.Text = "" Then
            MsgBox("Please select center", vbExclamation)
            Exit Sub
        End If
        frmClientIdentifier.ChangeCenter(groupkey.Text, centerkey.Text, txtCenter.Text, txtAccountOfficer.Text)
    End Sub
 

End Class
