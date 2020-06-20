Imports System.Globalization

Public Class frmPLDTnewOffice

    Private Sub frmAddNewIP_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If mode.Text = "edit" Then
            com.CommandText = "select * from action_query.tblpldtoffice where id='" & id.Text & "'" : rst = com.ExecuteReader
            While rst.Read
                txtOfficeName.Text = rst("officename").ToString
                txtOfficeAddress.Text = rst("officeaddress").ToString
                txtOfficeTelNumber.Text = rst("telnumber").ToString
                txtContactPerson.Text = rst("contactperson").ToString
                txtContactNumber.Text = rst("contactpersonnumber").ToString
                txtPLDTAcctNumber.Text = rst("acctnumber").ToString
                txtPLDTPLNumber.Text = rst("plnumber").ToString
                txtAcctType.Text = rst("accttype").ToString
                txtIpAddress.Text = rst("ipaddress").ToString
            End While
            rst.Close()

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtOfficeName.Text = "" Then
            MsgBox("Please enter office name!", MsgBoxStyle.Exclamation, "Error Message")
            txtOfficeName.Focus()
            Exit Sub
        ElseIf txtOfficeAddress.Text = "" Then
            MsgBox("Please enter office address!", MsgBoxStyle.Exclamation, "Error Message")
            txtOfficeAddress.Focus()
            Exit Sub
        ElseIf txtOfficeTelNumber.Text = "" Then
            MsgBox("Please enter office tel number!", MsgBoxStyle.Exclamation, "Error Message")
            txtOfficeTelNumber.Focus()
            Exit Sub
        ElseIf txtContactPerson.Text = "" Then
            MsgBox("Please enter contact person name!", MsgBoxStyle.Exclamation, "Error Message")
            txtContactPerson.Focus()
            Exit Sub
        ElseIf txtContactNumber.Text = "" Then
            MsgBox("Please enter contact person number!", MsgBoxStyle.Exclamation, "Error Message")
            txtContactNumber.Focus()
            Exit Sub
        ElseIf txtPLDTAcctNumber.Text = "" Then
            MsgBox("Please enter PLDT Acct number!", MsgBoxStyle.Exclamation, "Error Message")
            txtPLDTAcctNumber.Focus()
            Exit Sub
        ElseIf txtPLDTPLNumber.Text = "" Then
            MsgBox("Please enter PLDT PL number!", MsgBoxStyle.Exclamation, "Error Message")
            txtPLDTPLNumber.Focus()
            Exit Sub
        ElseIf txtAcctType.Text = "" Then
            MsgBox("Please enter PLDT account type!", MsgBoxStyle.Exclamation, "Error Message")
            txtAcctType.Focus()
            Exit Sub
        End If
        If mode.Text = "edit" Then
            com.CommandText = "UPDATE action_query.tblpldtoffice set officename='" & txtOfficeName.Text & "', officeaddress='" & rchar(txtOfficeAddress.Text) & "', telnumber='" & txtOfficeTelNumber.Text & "',contactperson='" & txtContactPerson.Text & "', contactpersonnumber='" & txtContactNumber.Text & "', acctnumber='" & txtPLDTAcctNumber.Text & "', plnumber='" & txtPLDTPLNumber.Text & "', accttype='" & txtAcctType.Text & "',ipaddress='" & txtIpAddress.Text & "' where id='" & id.Text & "'" : com.ExecuteNonQuery()
            ClearFields()
            frmPLDTOffices.FilterOffice()
            MsgBox("Office Successfully Updated!", MsgBoxStyle.Information)
        Else
            com.CommandText = "insert into action_query.tblpldtoffice set officename='" & txtOfficeName.Text & "', officeaddress='" & rchar(txtOfficeAddress.Text) & "', telnumber='" & txtOfficeTelNumber.Text & "',contactperson='" & txtContactPerson.Text & "', contactpersonnumber='" & txtContactNumber.Text & "', acctnumber='" & txtPLDTAcctNumber.Text & "', plnumber='" & txtPLDTPLNumber.Text & "', accttype='" & txtAcctType.Text & "',ipaddress='" & txtIpAddress.Text & "'" : com.ExecuteNonQuery()
            ClearFields()
            frmPLDTOffices.FilterOffice()
            MsgBox("Office Successfully Added!", MsgBoxStyle.Information)
        End If
    End Sub
    Public Sub ClearFields()
        txtOfficeName.Text = ""
        txtOfficeAddress.Text = ""
        txtOfficeName.Text = ""
        txtOfficeTelNumber.Text = ""
        txtContactPerson.Text = ""
        txtContactNumber.Text = ""
        txtPLDTAcctNumber.Text = ""
        txtPLDTPLNumber.Text = ""
        txtAcctType.Text = ""
        txtIpAddress.Text = ""
        mode.Text = ""
        id.Text = ""

    End Sub
End Class
