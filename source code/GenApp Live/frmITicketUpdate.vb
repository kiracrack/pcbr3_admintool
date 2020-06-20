Imports System.Globalization
Imports System.IO

Public Class frmITicketUpdate
    Private Sub frmITicketUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCategory.Items.Clear()
        comgenapp.CommandText = "select distinct prob_name from `itickettest`.`problem_category` order by prob_name asc" : rstgenapp = comgenapp.ExecuteReader
        While rstgenapp.Read
            txtCategory.Items.Add(New ComboBoxItem(rstgenapp("prob_name").ToString, rstgenapp("prob_name").ToString))
        End While
        rstgenapp.Close()

        txtCause.Items.Clear()
        comgenapp.CommandText = "select distinct cause_cat from `itickettest`.`cause_category` order by cause_cat asc" : rstgenapp = comgenapp.ExecuteReader
        While rstgenapp.Read
            txtCause.Items.Add(New ComboBoxItem(rstgenapp("cause_cat").ToString, rstgenapp("cause_cat").ToString))
        End While
        rstgenapp.Close()

        txtResolvedBy.Items.Clear()
        comgenapp.CommandText = "select distinct EMP_NAME from `itickettest`.`employee` inner join `itickettest`.`user` on employee.EMP_ID = user.user_id  where USER_TYPE='ITD' order by EMP_NAME asc" : rstgenapp = comgenapp.ExecuteReader
        While rstgenapp.Read
            txtResolvedBy.Items.Add(New ComboBoxItem(rstgenapp("EMP_NAME").ToString, rstgenapp("EMP_NAME").ToString))
        End While
        rstgenapp.Close()

        txtStatus.Text = defaultCombobox(txtStatus, Me, False)
        txtPriority.Text = defaultCombobox(txtPriority, Me, False)
        txtCategory.Text = defaultCombobox(txtCategory, Me, False)
        txtCause.Text = defaultCombobox(txtCause, Me, False)
        txtResolvedBy.Text = defaultCombobox(txtResolvedBy, Me, False)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtStatus.Text = "" Then
            MsgBox("Please select status!", MsgBoxStyle.Exclamation)
            txtStatus.Focus()
            Exit Sub
        ElseIf txtPriority.Text = "" Then
            MsgBox("Please select priority!", MsgBoxStyle.Exclamation)
            txtPriority.Focus()
            Exit Sub
        ElseIf txtCategory.Text = "" Then
            MsgBox("Please select category!", MsgBoxStyle.Exclamation)
            txtCategory.Focus()
            Exit Sub
        ElseIf txtCause.Text = "" Then
            MsgBox("Please select cause!", MsgBoxStyle.Exclamation)
            txtCause.Focus()
            Exit Sub
        ElseIf txtResolution.Text = "" Then
            MsgBox("Please enter resolution!", MsgBoxStyle.Exclamation)
            txtResolution.Focus()
            Exit Sub
        ElseIf txtResolvedBy.Text = "" Then
            MsgBox("Please select resolved by!", MsgBoxStyle.Exclamation)
            txtResolvedBy.Focus()
            Exit Sub
        End If
        If txtStatus.Text <> "" Then
            DeleteExistingFile(Application.StartupPath & "\Config\default_" & Me.Name & "_" & txtStatus.Name)
            Dim detailsFile = New StreamWriter(Application.StartupPath & "\Config\default_" & Me.Name & "_" & txtStatus.Name, True)
            detailsFile.WriteLine(EncryptTripleDES(txtStatus.Text & "," & txtStatus.Text))
            detailsFile.Close()
        End If
        If txtPriority.Text <> "" Then
            DeleteExistingFile(Application.StartupPath & "\Config\default_" & Me.Name & "_" & txtPriority.Name)
            Dim detailsFile = New StreamWriter(Application.StartupPath & "\Config\default_" & Me.Name & "_" & txtPriority.Name, True)
            detailsFile.WriteLine(EncryptTripleDES(txtPriority.Text & "," & txtPriority.Text))
            detailsFile.Close()
        End If
        If txtCategory.Text <> "" Then
            DeleteExistingFile(Application.StartupPath & "\Config\default_" & Me.Name & "_" & txtCategory.Name)
            Dim detailsFile = New StreamWriter(Application.StartupPath & "\Config\default_" & Me.Name & "_" & txtCategory.Name, True)
            detailsFile.WriteLine(EncryptTripleDES(txtCategory.Text & "," & txtCategory.Text))
            detailsFile.Close()
        End If
        If txtCause.Text <> "" Then
            DeleteExistingFile(Application.StartupPath & "\Config\default_" & Me.Name & "_" & txtCause.Name)
            Dim detailsFile = New StreamWriter(Application.StartupPath & "\Config\default_" & Me.Name & "_" & txtCause.Name, True)
            detailsFile.WriteLine(EncryptTripleDES(txtCause.Text & "," & txtCause.Text))
            detailsFile.Close()
        End If
        If txtResolvedBy.Text <> "" Then
            DeleteExistingFile(Application.StartupPath & "\Config\default_" & Me.Name & "_" & txtResolvedBy.Name)
            Dim detailsFile = New StreamWriter(Application.StartupPath & "\Config\default_" & Me.Name & "_" & txtResolvedBy.Name, True)
            detailsFile.WriteLine(EncryptTripleDES(txtResolvedBy.Text & "," & txtResolvedBy.Text))
            detailsFile.Close()
        End If
        If MessageBox.Show("Are you sure you want to continue?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            comgenapp.CommandText = "insert into `itickettest`.`ticket_details` set TCKT_ID='" & ticketid.Text & "', TCKT_RESOLVED_DATE=current_timestamp,TCKT_RESOLUTION='" & rchar(txtResolution.Text) & "',TCKT_RESOLVED_NOTE='',TCKT_RESOLVED_BY='" & txtResolvedBy.Text & "',TCKT_LEFTORIGIN_DATE='',TCKT_STARTDATE='',TCKT_ENDDATE='',TCKT_NUMDAYS=FLOOR(HOUR(TIMEDIFF(current_timestamp, '" & ConvertDateTime(txtDateReport.Value) & "')) / 24),TCKT_DAYSRESOLVED=FLOOR(HOUR(TIMEDIFF(current_timestamp, '" & ConvertDateTime(txtDateReport.Value) & "')) / 24),TCKT_HOURS_RESOLVED=MOD(HOUR(TIMEDIFF(current_timestamp,  '" & ConvertDateTime(txtDateReport.Value) & "')), 24),TCKT_CAUSECAT='" & txtCause.Text & "',TCKT_GENCAT='',TCKT_PROBCAT='" & txtCategory.Text & "',TCKT_DATECLOSED=current_date;" : comgenapp.ExecuteNonQuery()
            comgenapp.CommandText = "update `itickettest`.`ticket` set TCKT_STATUS='" & txtStatus.Text & "' where TCKT_ID='" & ticketid.Text & "';" : comgenapp.ExecuteNonQuery()
            frmGenAppLive.ShowLiveTicket()
            MsgBox("Ticket Successfully Updated!", MsgBoxStyle.Information)
            Me.Close()
        End If
    End Sub
End Class
