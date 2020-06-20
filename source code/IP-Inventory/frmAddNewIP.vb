Imports System.Globalization

Public Class frmAddNewIP

    Private Sub frmAddNewIP_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If mode.Text = "edit" Then
            com.CommandText = "select * from action_query.tblipinventory where officeid='" & officeid.Text & "'" : rst = com.ExecuteReader
            While rst.Read
                txtOfficeName.Text = rst("officename").ToString
                txtIP1.Text = rst("ip1").ToString
                txtIP2.Text = rst("ip2").ToString
                txtIP3.Text = rst("ip3").ToString
                txtIP4.Text = rst("ip4").ToString
                txtIPLast.Text = rst("ip5").ToString
            End While
            rst.Close()
        End If
    End Sub
    Private Sub txtIP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIP1.KeyPress, txtIP2.KeyPress, txtIP3.KeyPress, txtIP4.KeyPress
        Dim txtBox As TextBox = DirectCast(sender, TextBox)
        'ONLY ALLOW CONTROL CHARS (LIKE BACKSPACE) AND NUMBERS TO BE ENTERED
        Select Case Char.GetUnicodeCategory(e.KeyChar)
            Case Globalization.UnicodeCategory.Control, Globalization.UnicodeCategory.DecimalDigitNumber
            Case Else
                e.Handled = True
        End Select
        Debug.Print(e.KeyChar.ToString)

        If e.KeyChar = "." Or e.KeyChar = "/" Then
            Me.SelectNextControl(txtBox, True, True, False, False)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If mode.Text = "edit" Then
            com.CommandText = "update action_query.tblipinventory set  officename='" & rchar(txtOfficeName.Text) & "', ip1='" & txtIP1.Text & "',ip2='" & txtIP2.Text & "', ip3='" & txtIP3.Text & "', ip4='" & txtIP4.Text & "', ip5='" & txtIPLast.Text & "' where officeid='" & officeid.Text & "'" : com.ExecuteNonQuery()
            If countqry("action_query.tblipnetworks", "officeid='" & officeid.Text & "'") = 0 Then
                If MessageBox.Show("IP Range currently not configured, are you you want to load ip address for this office?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                    For i = Val(txtIP4.Text) + 1 To Val(txtIPLast.Text)
                        com.CommandText = "insert into action_query.tblipnetworks set officeid='" & officeid.Text & "',accountable='',position='',ipaddress='" & txtIP1.Text & "." & txtIP2.Text & "." & txtIP3.Text & "." & i & "',iporder=" & i & ", username='',password=''" : com.ExecuteNonQuery()
                    Next
                End If
            End If
        Else
            com.CommandText = "insert into action_query.tblipinventory set officename='" & rchar(txtOfficeName.Text) & "', ip1='" & txtIP1.Text & "',ip2='" & txtIP2.Text & "', ip3='" & txtIP3.Text & "', ip4='" & txtIP4.Text & "', ip5='" & txtIPLast.Text & "'" : com.ExecuteNonQuery()
        End If
        CleadBox() : frmIPInventory.FilterIpInventory()
        MsgBox("IP Successfully saved!", MsgBoxStyle.Information)
    End Sub
    Public Sub CleadBox()
        txtOfficeName.Text = ""
        txtIP1.Text = ""
        txtIP2.Text = ""
        txtIP3.Text = ""
        txtIP4.Text = ""
        txtIPLast.Text = ""
        txtOfficeName.Focus()
    End Sub
End Class
