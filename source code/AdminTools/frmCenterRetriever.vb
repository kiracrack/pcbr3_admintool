Imports System.Globalization

Public Class frmCenterRetriever
    Private Sub frmLoanAdjustment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadToComboBox("SELECT * FROM `master`.`branches` order by branchname asc;", "branchname", "branchcode", txtBranch)
        LoadToComboBox("SELECT * FROM `master`.`userinfo` order by username asc;", "username", "userid", txtClient)
    End Sub
    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtBranch.Text = "" Then
            MsgBox("Please select branch!", MsgBoxStyle.Critical)
            txtBranch.Focus()
            Exit Sub
        ElseIf txtClient.Text = "" Then
            MsgBox("Please select request by!", MsgBoxStyle.Critical)
            txtClient.Focus()
            Exit Sub
        ElseIf txtQuery.Text = "" Then
            MsgBox("Please paste your center script!", MsgBoxStyle.Critical)
            txtClient.Focus()
            Exit Sub
        End If

            If MessageBox.Show("Are you sure you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            com.CommandText = Trim(txtQuery.Text) : com.ExecuteNonQuery()
            Dim getBranch As String = qrysingledata("branch", "(select branchname from master.branches where branchcode = master.loanwithterm.branchcode) as 'branch'", "master.loanwithterm  where refno = '" & DirectCast(txtBranch.SelectedItem, ComboBoxItem).HiddenValue() & "'")
            com.CommandText = "INSERT into action_query.tbltechnicalreport set branchname='" & StrConv(getBranch, vbProperCase) & "',severitylvl='Critical', requestorname='" & txtClient.Text & "', concern='PCBR3 Center Name', actiontaken='Restore Script Executed """ & txtScript.Text & """ of " & txtBranch.Text & "', performedby='" & GlobalFullname & "', datetrn=current_timestamp" : com.ExecuteNonQuery()
            MsgBox("center successfully restored!", MsgBoxStyle.Information)
        End If
    End Sub


 

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtCenter.Text = "" Then Exit Sub
        com.CommandText = "select concat('insert into master.g_center set centercode=''',centercode,''',','centername=''',centername,''',','centerkey=''',centerkey,''',','microfinance=''',microfinance,''',','accountofficer=''',accountofficer,''',','branchcode=''',branchcode,''',','areakey=''',areakey,''',','daily=''',daily,''',','weekly=''',weekly,''',','dayofweek=''',dayofweek,''',','other=''',other,''',','othersked=''',othersked,''',','recby=''',recby,''',','rectime=''',rectime,''',','recdate=''',recdate,''',','chgby=''',chgby,''',','chgtime=''',chgtime,''',','chgdate=''',chgdate,''';') as 'center' from master.g_center where centerkey ='" & DirectCast(txtCenter.SelectedItem, ComboBoxItem).HiddenValue() & "'; " : rst = com.ExecuteReader
        While rst.Read
            txtScript.Text = rst("center").ToString
        End While
        rst.Close()
    End Sub
 
    Private Sub txtBranch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtBranch.SelectedIndexChanged
        If txtBranch.Text = "" Then Exit Sub
        LoadToComboBox("SELECT * FROM `master`.`g_center` where branchcode='" & DirectCast(txtBranch.SelectedItem, ComboBoxItem).HiddenValue() & "' order by centername asc;", "centername", "centerkey", txtCenter)
    End Sub

  
    Private Sub txtQuery_TextChanged(sender As Object, e As EventArgs) Handles txtQuery.TextChanged
        If txtQuery.Text <> "" Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If
    End Sub
     
End Class
