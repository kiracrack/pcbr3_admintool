Imports System.Security.AccessControl
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frmSingleMenu
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = Keys.Control + Keys.F12 Then
            If System.IO.File.Exists(single_conn) = True Then
                If MessageBox.Show("Are you sure you want to delete existing connection?" & Environment.NewLine & Environment.NewLine & "NOTE: Please re-open pcbr3 utility tool to select another connection", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                    System.IO.File.Delete(single_conn)
                    End
                End If
            End If
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmMainMenu_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        conn.Close()
    End Sub

    Private Sub frmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Closed Then
            If System.IO.File.Exists(single_conn) = False Then
                frmBranchConnectionSetup.ShowDialog()
                End
            Else
                SingleConnectionVerify()
            End If
        End If
        CreateNotExistingTable()
        loadMenu()
        GlobalFullname = "utilitytool"
    End Sub

    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        MenuActionAdminTool()
    End Sub
  
    Public Sub loadMenu()
        With ListView1
            .LargeImageList = Imagemenu
            .Items.Add("Client Loan Profile", 11)
            .Items.Add("Dormancy Account", 20)
            .Items.Add("MBO Accounts Identifier", 21)
            .Items.Add("Central Report Generator", 19)
        End With
      
    End Sub

    Public Sub MenuActionAdminTool()
        Select Case ListView1.SelectedItems(0).Text
            Case "Client Loan Profile"
                frmClientLoanProfile.Show()

            Case "Dormancy Account"
                frmDormantList.Show()

            Case "MBO Accounts Identifier"
                frmClientIdentifier.Show()

            Case "Central Report Generator"
                frmCentralReportGenerator.Show()
        End Select

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtServer.Text = "Connected Server: " & sqlipaddress
        txtDate.Text = Format(Now)
    End Sub

    Private Sub cmdClose_Click_1(sender As Object, e As EventArgs)
        End
    End Sub

End Class
