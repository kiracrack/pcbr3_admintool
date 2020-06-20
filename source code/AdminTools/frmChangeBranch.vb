Imports System.Globalization

Public Class frmChangeBranch

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtBranch.Text = "" Then
            MsgBox("Please select branch!", MsgBoxStyle.Critical)
            txtBranch.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to continue?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            frmUserAccounts.ChangeBranch(DirectCast(txtBranch.SelectedItem, ComboBoxItem).HiddenValue(), txtReason.Text)
            Me.Close()
        End If
    End Sub

    Private Sub frmLoanAdjustment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
    End Sub
    Public Sub loaddata()
        LoadToComboBox("select * from master.branches order by branchname asc", "branchname", "branchcode", txtBranch)
    End Sub
End Class
