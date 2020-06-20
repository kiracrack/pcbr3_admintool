Imports System.Globalization
Imports System.IO

Public Class frmUserAccessUpdate
    Private Sub frmITicketUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtResolvedBy.Items.Clear()
        comgenapp.CommandText = "select distinct NAME_OF_USER from `systemaccessdb2`.`user` where USER_TYPE='ITD' order by NAME_OF_USER asc" : rstgenapp = comgenapp.ExecuteReader
        While rstgenapp.Read
            txtResolvedBy.Items.Add(New ComboBoxItem(rstgenapp("NAME_OF_USER").ToString, rstgenapp("NAME_OF_USER").ToString))
        End While
        rstgenapp.Close()
        txtResolvedBy.Text = defaultCombobox(txtResolvedBy, Me, False)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
      If txtResolution.Text = "" Then
            MsgBox("Please enter remarks!", MsgBoxStyle.Critical)
            txtResolution.Focus()
            Exit Sub
        ElseIf txtResolvedBy.Text = "" Then
            MsgBox("Please select resolved by!", MsgBoxStyle.Critical)
            txtResolvedBy.Focus()
            Exit Sub
        End If
        If txtResolvedBy.Text <> "" Then
            DeleteExistingFile(Application.StartupPath & "\Config\default_" & Me.Name & "_" & txtResolvedBy.Name)
            Dim detailsFile = New StreamWriter(Application.StartupPath & "\Config\default_" & Me.Name & "_" & txtResolvedBy.Name, True)
            detailsFile.WriteLine(EncryptTripleDES(txtResolvedBy.Text & "," & txtResolvedBy.Text))
            detailsFile.Close()
        End If
        If MessageBox.Show("Are you sure you want to continue?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            comgenapp.CommandText = "update `systemaccessdb2`.`accessform` set VerifiedBy='" & txtResolvedBy.Text & "', statusAdmin='VALIDATED',dateverified=current_timestamp,validatorRemarks='" & rchar(txtResolution.Text) & "' where id='" & ticketid.Text & "';" : comgenapp.ExecuteNonQuery()
            frmGenAppLive.ShowLiveTicket()
            MsgBox("User Access Successfully Validated!", MsgBoxStyle.Information)
            Me.Close()
        End If
    End Sub
End Class
