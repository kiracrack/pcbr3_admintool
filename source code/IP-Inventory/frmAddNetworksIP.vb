Imports System.Globalization

Public Class frmAddNetworksIP

    Private Sub frmAddNewIP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadComboData()
        If mode.Text = "edit" Then
            com.CommandText = "select * from action_query.tblipnetworks where id='" & id.Text & "'" : rst = com.ExecuteReader
            While rst.Read
                officeid.Text = rst("officeid").ToString
                txtComputerName.Text = rst("accountable").ToString
                txtPosition.Text = rst("position").ToString
                txtIPAdress.Text = rst("ipaddress").ToString
                txtUsername.Text = rst("username").ToString
                CheckBox1.Checked = rst("encryptpassword")
                If rst("encryptpassword").ToString = "1" Then
                    txtPassword.Text = DecryptTripleDES(rst("password").ToString)
                Else
                    txtPassword.Text = rst("password").ToString
                End If
            End While
            rst.Close()
        End If

    End Sub
    Public Sub LoadComboData()
        LoadToComboBox("SELECT * FROM `master`.`userinfo` order by username asc;", "username", "userid", txtComputerName)
        LoadToComboBoxPre("select * from action_query.tblipnetworks", "position", "position", txtPosition)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If mode.Text <> "edit" And countqry("action_query.tblipnetworks", "ipaddress='" & txtIPAdress.Text & "' and id<>'" & id.Text & "'") > 0 Then
            MsgBox("IP Address already exixts!", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Dim EncriptPassword As String = "" : Dim password As String = ""
        If CheckBox1.Checked = True Then
            password = EncryptTripleDES(txtPassword.Text)
            EncriptPassword = ",encryptpassword=1"
        Else
            password = txtPassword.Text
            EncriptPassword = ",encryptpassword=0"
        End If
        If mode.Text = "edit" Then
            com.CommandText = "update action_query.tblipnetworks set officeid='" & officeid.Text & "', accountable='" & UCase(rchar(txtComputerName.Text)) & "',position='" & rchar(txtPosition.Text) & "',  username='" & txtUsername.Text & "',ipaddress='" & txtIPAdress.Text & "', password='" & password & "' " & EncriptPassword & " where id='" & id.Text & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "insert into action_query.tblipnetworks set officeid='" & officeid.Text & "', accountable='" & UCase(rchar(txtComputerName.Text)) & "', position='" & rchar(txtPosition.Text) & "', ipaddress='" & txtIPAdress.Text & "', username='" & txtUsername.Text & "', password='" & password & "'" & EncriptPassword & "" : com.ExecuteNonQuery()
        End If
        ClearFields()
        frmNetworkIPInventory.FilterIpInventory()
    End Sub
    Public Sub ClearFields()
        txtComputerName.Text = ""
        txtPosition.SelectedIndex = -1
        txtIPAdress.Text = ""
        txtUsername.Text = ""
        txtPassword.Text = ""
        mode.Text = ""
        id.Text = ""
        txtComputerName.Focus()
    End Sub


End Class
