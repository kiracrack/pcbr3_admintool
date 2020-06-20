Imports System.Globalization
Imports MySql.Data.MySqlClient

Public Class frmGenAppLive
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmGenAppLive_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmGenAppLive_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (Not System.IO.Directory.Exists(Application.StartupPath.ToString & "\Config")) Then
            System.IO.Directory.CreateDirectory(Application.StartupPath.ToString & "\Config")
        End If
        com.CommandText = "select * from `action_query`.`tblsupportappserver`" : rst = com.ExecuteReader
        While rst.Read
            genappserver = rst("ipaddress").ToString
            genappport = rst("port").ToString
            genappuser = rst("username").ToString
            genapppass = rst("password").ToString
            iticketdb = rst("iticketdb").ToString
            systemaccess = rst("systemaccessdb").ToString
        End While
        rst.Close()
        If OpenGenAppServer() = True Then
            ShowLiveTicket()
        End If
    End Sub
    Public Sub ShowLiveTicket()
        dstgenapp = New DataSet
        msdagenapp = New MySqlDataAdapter("select id, 'TICKET' as 'REQUEST',date_format(TCKT_DATE, '%Y-%m-%d %r') as 'reportdate', ucase(TCKT_BRANCH) as 'BRANCH', TCKT_ID as 'TICKET #', TCKT_REPORTEDBY as 'REQUESTED BY', TCKT_SUBJECT as 'SUBJECT',TCKT_MESSAGE as 'MESSAGE' from " & iticketdb & ".ticket where TCKT_STATUS = 'Open' and date_format(TCKT_DATE,'%Y-%m-%d') = current_date union all " _
                                         + " select id, 'ACCESS',date_format(effectDate,'%Y-%m-%d'), branch, '-', requestedby,purpose,case when purpose='Change Assignment' then concat(assignfrom ,' to ', assignto) when purpose='New User' then assignfrom when purpose='Branch Transfer' then concat(frombranch, ' to ', tobranch) else 'for more info please use system access system' end  from  " & systemaccess & ".accessform where status='APPROVED' and statuschecker='APPROVED' and statusadmin='NOT YET VALIDATED' and date_format(effectDate,'%Y-%m-%d') = current_date", conngenapp)
        MyDataGridView.DataSource = Nothing
        msdagenapp.Fill(dstgenapp, 0)
        MyDataGridView.DataSource = dstgenapp.Tables(0)
        MyDataGridView.Columns("id").Visible = False
        MyDataGridView.Columns("reportdate").Visible = False
        MyDataGridView.Columns("REQUEST").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        MyDataGridView.Columns("BRANCH").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        MyDataGridView.Columns("TICKET #").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
      
        MyDataGridView.Columns("MESSAGE").Width = 450
        MyDataGridView.Columns("MESSAGE").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        
        GridColumnAlignment(MyDataGridView, {"REQUEST", "BRANCH", "TICKET #"}, DataGridViewContentAlignment.MiddleCenter)


        Dim pendingticket As Integer = Val(qrysingledata("pendingticket", "pendingticket", "`action_query`.`tblsupportliveticketcount`"))
        If MyDataGridView.RowCount > pendingticket Then
            If System.IO.File.Exists(Application.StartupPath.ToString & "\notify.wav") Then
                My.Computer.Audio.Play(Application.StartupPath.ToString & "\notify.wav", AudioPlayMode.Background)
                Dim sap
                sap = CreateObject("SAPI.spvoice")
                sap.Speak("You have, new ticket received.")
            End If
        End If
        com.CommandText = "update `action_query`.`tblsupportliveticketcount` set pendingticket='" & MyDataGridView.RowCount & "'" : com.ExecuteNonQuery()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ShowLiveTicket()
    End Sub

    'Private Sub frmGenAppLive_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
    '    If Me.WindowState = FormWindowState.Maximized Then
    '        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
    '    End If
    'End Sub

    Private Sub EditChapterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditChapterToolStripMenuItem.Click
        Me.Close()
    End Sub
     
    Private Sub ClearlogToolToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearlogToolToolStripMenuItem.Click
        frmClearLog.Show(Me)
    End Sub

    Private Sub SavingsUnlockerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SavingsUnlockerToolStripMenuItem.Click
        frmClearingSavings.Show(Me)
    End Sub

    Private Sub LOanUnlockerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOanUnlockerToolStripMenuItem.Click
        frmClearingLoan.Show(Me)
    End Sub

    Private Sub POPUnlockerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles POPUnlockerToolStripMenuItem.Click
        frmPopUnlocker.Show(Me)
    End Sub

    Private Sub ClientUnlockerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientUnlockerToolStripMenuItem.Click
        frmClearingClient.Show(Me)
    End Sub

    Private Sub ChangeUserAccessToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeUserAccessToolStripMenuItem.Click
        frmChangeUserAccess.Show(Me)
    End Sub

    Private Sub AdjustmentRemoverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdjustmentRemoverToolStripMenuItem.Click
        frmLoanAdjustment.Show(Me)
    End Sub

    Private Sub PaymentRemoverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaymentRemoverToolStripMenuItem.Click
        frmFullPaymentCencellation.Show(Me)
    End Sub

    Private Sub ChargesRemoverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChargesRemoverToolStripMenuItem.Click
        frmChargesDeposit.Show(Me)
    End Sub

    Private Sub RefreshListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshListToolStripMenuItem.Click
        ShowLiveTicket()
    End Sub

    Private Sub UpdateTicketToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateTicketToolStripMenuItem.Click
        For Each rw As DataGridViewRow In MyDataGridView.SelectedRows
            If rw.Cells("REQUEST").Value.ToString = "TICKET" Then
                frmITicketUpdate.ticketid.Text = rw.Cells("TICKET #").Value.ToString
                frmITicketUpdate.txtDateReport.Value = rw.Cells("reportdate").Value.ToString
                frmITicketUpdate.Show(Me)
            Else
                frmUserAccessUpdate.ticketid.Text = rw.Cells("id").Value.ToString
                frmUserAccessUpdate.Show(Me)
            End If
        Next
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        frmUserAccounts.Show()
    End Sub
End Class
