Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Drawing.Printing
Imports System.Text

Public Class frmCentralConnectionSetup
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        
        End If
        Return ProcessCmdKey
    End Function

    Private Sub cmdset_Click(sender As Object, e As EventArgs) Handles cmdset.Click
        If txtBranch.Text = "" Then
            MessageBox.Show("Please select connection", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtBranch.Focus()
            Exit Sub

        End If
        If txtBranch.SelectedIndex = 0 Then
            frmCentralReportConnection.ckLive.Checked = True
        Else
            frmCentralReportConnection.ckLive.Checked = False
        End If
        frmCentralReportConnection.Show(Me)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtBranch.Text = "" Then
            MessageBox.Show("Please select connection", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtBranch.Focus()
            Exit Sub
        End If
        If txtBranch.SelectedIndex = 0 Then
            frmCentralReportDate.ckLive.Checked = True
        Else
            frmCentralReportDate.ckLive.Checked = False
        End If
        frmCentralReportDate.Show(Me)
    End Sub
End Class