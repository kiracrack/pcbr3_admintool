Imports System.Security.AccessControl
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frmMainMenu
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = Keys.F12 Then
            frmConnectionSetup.ShowDialog()
            FillComboFromFile()
            txtServer.Text = sqlservername
        ElseIf keyData = Keys.Control + Keys.F11 Then
            If Timer2.Enabled = True Then
                If MessageBox.Show("Auto clear log currently ACTIVATED. Click yes to DEACTIVATE", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    Timer2.Enabled = False
                End If
            Else
                If MessageBox.Show("Auto clear log currently DEACTIVATED. Click yes to ACTIVATE", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    Timer2.Enabled = True
                End If
            End If
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmMainMenu_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        frmLoginAccount.Close()
        conn.Close()
        connclient.Close()
    End Sub

    Private Sub frmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadMenu()
        FillComboFromFile()
        txtServer.Text = sqlservername
    End Sub
    Private Sub FillComboFromFile()
        Dim path As String = Application.StartupPath.ToString & "\Connection"
        txtServer.Items.Clear()
        For Each file As String In System.IO.Directory.GetFiles(path)
            txtServer.Items.Add(UCase(System.IO.Path.GetFileNameWithoutExtension(file)))
        Next
    End Sub

    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        MenuActionAdminTool()
    End Sub
    Private Sub ListView2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView2.DoubleClick
        MenuActionCentralReport()
    End Sub
    Private Sub ListView3_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView3.DoubleClick
        MenuActionPLDT()
    End Sub
    Private Sub ListView4_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView4.DoubleClick
        MenuActionMBO()
    End Sub
    Public Sub loadMenu()
        With ListView1
            .LargeImageList = Imagemenu
            If GlobalLimited = True Then
                .Items.Add("POP UnLocker", 3)
                .Items.Add("Loans Unlocker", 4)
                .Items.Add("Clients Unlocker", 5)
                .Items.Add("Savings Unlocker", 6)
                .Items.Add("User ClearLog Tool", 7)
                .Items.Add("User Accounts", 8)
                .Items.Add("Client Loan Profile", 11)
                .Items.Add("Live Ticket", 21)
            Else
                .Items.Add("Adjustment Remover", 0)
                .Items.Add("Payment Remover", 1)
                .Items.Add("Charges Remover", 2)
                .Items.Add("POP UnLocker", 3)
                .Items.Add("Loans Unlocker", 4)
                .Items.Add("Clients Unlocker", 5)
                .Items.Add("Savings Unlocker", 6)
                .Items.Add("User ClearLog Tool", 7)
                .Items.Add("User Accounts", 8)
                .Items.Add("Loan Amort. Retriver", 9)
                .Items.Add("Center Retriever", 10)
                .Items.Add("Client Loan Profile", 11)
                .Items.Add("Product Duplicator", 12)
                .Items.Add("Change User Access", 13)
                .Items.Add("Cancel Undisbursed Loans", 14)
                .Items.Add("Beginning of Day Re-confirmation", 15)
                .Items.Add("New Account", 16)
                .Items.Add("Payment Missing Correct", 23)
                .Items.Add("RSBSA Updater", 17)
                .Items.Add("Find Word on Database", 18)
                .Items.Add("Product Import/Export", 19)
                .Items.Add("Transaction Convertion Tool", 22)
                .Items.Add("Center Corrector", 26)
                .Items.Add("Dormancy Account", 20)
                .Items.Add("Live Ticket", 21)
                .Items.Add("Image Exporter", 24)
                .Items.Add("Remove GL Ticket", 27)
            End If
        End With

        If GlobalLimited = False Then
            With ListView2
                .LargeImageList = imageReportCentral
                .Items.Add("Database Connection Setup", 0)
                '.Items.Add("Execute Report Backup", 1)
                .Items.Add("Report Developer", 2)
                '.Items.Add("Export Centralize Reports", 3)
                .Items.Add("Central Report Generator", 4)
            End With

            With ListView3
                .LargeImageList = ImageList1
                .Items.Add("IP Inventory", 0)
                .Items.Add("Network IP Inventory", 1)
                .Items.Add("PING Monitoring", 5)
                .Items.Add("List of Offices", 2)
                .Items.Add("PLDT Reports", 3)
            End With
            With ListView4
                .LargeImageList = ImageList1
                .Items.Add("Client Identifier", 4)
            End With
        End If
    End Sub

    Public Sub MenuActionAdminTool()
        Select Case ListView1.SelectedItems(0).Text
            Case "Adjustment Remover"
                frmLoanAdjustment.Show()

            Case "Payment Remover"
                frmFullPaymentCencellation.Show()

            Case "Charges Remover"
                frmChargesDeposit.Show()

            Case "POP UnLocker"
                frmPopUnlocker.Show()

            Case "Loans Unlocker"
                frmClearingLoan.Show()

            Case "Clients Unlocker"
                frmClearingClient.Show()

            Case "Savings Unlocker"
                frmClearingSavings.Show()

            Case "User ClearLog Tool"
                frmClearLog.Show()

            Case "User Accounts"
                frmUserAccounts.Show()

            Case "Payment Missing Correct"
                frmPaymentMissingCorrect.Show()

            Case "Loan Amort. Retriver"
                frmAmortSchedRetriver.Show()

            Case "Center Retriever"
                frmCenterRetriever.Show()

            Case "Client Loan Profile"
                frmClientLoanProfile.Show()

            Case "Product Duplicator"
                frmProductDuplicater.Show()

            Case "Change User Access"
                frmChangeUserAccess.Show()

            Case "Cancel Undisbursed Loans"
                frmCancelUndisbursedLoans.Show()

            Case "Beginning of Day Re-confirmation"
                frmConfirmedBeginingofDay.Show()

            Case "Center Corrector"
                frmCorrectClientCenter.Show()

            Case "New Account"
                frmNewAccount.Show()

            Case "RSBSA Updater"
                Timer1.Stop()
                Timer1.Enabled = False
                Timer2.Stop()
                Timer2.Enabled = False
                Timer3.Stop()
                Timer3.Enabled = False
                frmRSBACapture.Show()

            Case "Transaction Convertion Tool"
                Timer1.Stop()
                Timer1.Enabled = False
                Timer2.Stop()
                Timer2.Enabled = False
                Timer3.Stop()
                Timer3.Enabled = False
                frmCaptureLoanPaymentSequence.Show()

            Case "Image Exporter"
                Timer1.Stop()
                Timer1.Enabled = False
                Timer2.Stop()
                Timer2.Enabled = False
                Timer3.Stop()
                Timer3.Enabled = False
                frmPCBRImageExporter.Show()


            Case "Find Word on Database"
                frmFindString.Show()

            Case "Product Import/Export"
                frmProductImporter.Show()

            Case "Dormancy Account"
                frmDormantList.Show()

            Case "Live Ticket"
                frmGenAppLive.Show()

            Case "Centralized Report"
                frmCentralReportGenerator.Show()

            Case "Remove GL Ticket"
                frmRemoveGTicket.Show()

        End Select

    End Sub

    Public Sub MenuActionCentralReport()
        Timer1.Stop()
        Timer1.Enabled = False
        Timer2.Stop()
        Timer2.Enabled = False
        Timer3.Stop()
        Timer3.Enabled = False
        Select Case ListView2.SelectedItems(0).Text
            Case "Database Connection Setup"
                frmCentralConnectionSetup.Show()

            Case "Execute Report Backup"
                frmCentralExecuteBackup.Show()

            Case "Report Developer"
                frmCentraReportDeveloper.Show()

            Case "Central Report Generator"
                frmCentralReportGenerator.Show()
        End Select
    End Sub

    Public Sub MenuActionPLDT()
        Select Case ListView3.SelectedItems(0).Text
            Case "List of Offices"
                frmPLDTOffices.Show()

            Case "PING Monitoring"
                Timer1.Stop()
                Timer1.Enabled = False
                Timer2.Stop()
                Timer2.Enabled = False
                Timer3.Stop()
                Timer3.Enabled = False
                frmIPPingMonitoring.Show()

            Case "PLDT Reports"
                frmPLDTReportTransaction.Show()

            Case "IP Inventory"
                frmIPInventory.Show()

            Case "Network IP Inventory"
                frmNetworkIPInventory.Show()

        End Select
    End Sub

    Public Sub MenuActionMBO()
        Select Case ListView4.SelectedItems(0).Text
            Case "Client Identifier"
                frmClientIdentifier.Show()
        End Select
    End Sub

    Private Sub txtServer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtServer.SelectedIndexChanged
        If txtServer.Text = "" Then Exit Sub
        ChangeConnection(file_conn_dir & "\" & txtServer.Text)
        If countqry("information_schema.tables", "table_schema = 'action_query' AND table_name = 'tblpldtoffice'") = 0 Then
            TabControl1.TabPages.Remove(tabPldt)
        Else
            If TabControl1.TabPages.Contains(tabPldt) = False Then
                TabControl1.TabPages.Add(tabPldt)
            End If
        End If
    End Sub

    Private Sub cmdPending_Click(sender As Object, e As EventArgs) Handles cmdPending.Click
        frmTechnicalReport.TabControl1.SelectedTab = frmTechnicalReport.TabPage2
        frmTechnicalReport.Show()
    End Sub

    Private Sub cmdNewReport_Click(sender As Object, e As EventArgs) Handles cmdNewReport.Click
        frmITServiceLoggingTool.Show()
    End Sub

    Private Sub cmdServiceReport_Click(sender As Object, e As EventArgs) Handles cmdServiceReport.Click
        frmTechnicalReport.Show()
    End Sub

    Private Sub cmdSummaryReport_Click(sender As Object, e As EventArgs) Handles cmdSummaryReport.Click
        Timer2.Stop()
        Timer3.Stop()
        frmTechnicalPerformance.Show()
    End Sub

    Private Sub cmdChangePassword_Click(sender As Object, e As EventArgs) Handles cmdChangePassword.Click
        frmChangePassword.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblServer.Text = "Connected Server: " & sqlipaddress
        lblUser.Text = "IT Support: " & GlobalFullname & " - " & Format(Now)
    End Sub

    Private Sub cmdClose_Click_1(sender As Object, e As EventArgs) Handles cmdClose.Click
        End
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        AutoClearlogMode()
    End Sub
    Public Sub AutoClearlogMode()
        dst = New DataSet
        msda = New MySqlDataAdapter("select * from master.userinfo where login='Y' order by username asc", conn)
        msda.Fill(dst, 0)
        For cnt = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
                com.CommandText = "UPDATE master.userinfo set login='N',block=false,blockdesc='',blockedby='',blocklevel=''  where  userid  = '" & .Rows(cnt)("userid").ToString() & "'" : com.ExecuteNonQuery()
                Dim getBranch As String = qrysingledata("branch", "(select branchname from master.branches where branchcode = master.userinfo.branchcode) as 'branch'", "master.userinfo  where userid = '" & .Rows(cnt)("userid").ToString() & "'")
                com.CommandText = "INSERT into action_query.tbltechnicalreport set branchname='" & StrConv(getBranch, vbProperCase) & "', requestorname='(" & .Rows(cnt)("userid").ToString() & ") " & .Rows(cnt)("username").ToString() & "', concern='User Clear Log', actiontaken='(" & .Rows(cnt)("userid").ToString() & ") 5" & .Rows(cnt)("username").ToString() & "', performedby='" & GlobalFullname & "', datetrn=current_timestamp" : com.ExecuteNonQuery()
            End With
        Next
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        UPdatePLDTreport()
    End Sub
 
    Public Sub UPdatePLDTreport()
        dst = New DataSet
        msda = New MySqlDataAdapter("select id,(select ipaddress from action_query.tblpldtoffice where id = tblpldtreport.officeid) as ip from action_query.tblpldtreport where upconnection=0", conn)
        msda.Fill(dst, 0)
        For cnt = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
                If .Rows(cnt)("ip").ToString() <> "" Then
                    If My.Computer.Network.Ping(.Rows(cnt)("ip").ToString(), 1000) Then
                        com.CommandText = "update action_query.tblpldtreport set upconnection=1, upconnectiondate=current_timestamp where id='" & .Rows(cnt)("id").ToString() & "'" : com.ExecuteNonQuery()
                        frmPLDTReportTransaction.FilterPending()
                    End If
                End If
            End With
        Next
    End Sub

 
End Class
