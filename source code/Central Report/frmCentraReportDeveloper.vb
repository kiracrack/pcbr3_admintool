Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Text.RegularExpressions

Public Class frmCentraReportDeveloper
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub cmdset_Click(sender As Object, e As EventArgs) Handles cmdset.Click
        If txtReportTitle.Text = "" Then
            MessageBox.Show("Please enter report name!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtReportTitle.Focus()
            Exit Sub
        ElseIf txtReportQuery.Text = "" Then
            MessageBox.Show("Please enter report query!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtReportQuery.Focus()
            Exit Sub
        ElseIf LCase(txtReportQuery.Text).Contains("drop") = True Then
            MessageBox.Show("Query not allowed! it contain's DROP function!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtReportQuery.Focus()
            Exit Sub
        ElseIf LCase(txtReportQuery.Text).Contains("delete") = True Then
            MessageBox.Show("Query not allowed! it contain's DELETE function!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtReportQuery.Focus()
            Exit Sub
        ElseIf LCase(txtReportQuery.Text).Contains("update ") = True Then
            MessageBox.Show("Query not allowed! it contain's UPDATE function!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtReportQuery.Focus()
            Exit Sub
        ElseIf LCase(txtReportQuery.Text).Contains("insert") = True Then
            MessageBox.Show("Query not allowed! it contain's INSERT function!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtReportQuery.Focus()
            Exit Sub
        End If
        If mode.Text <> "edit" Then
            com.CommandText = "insert into pcbr3.tblreporttemplate set rptid='" & id.Text & "', rptname='" & rchar(txtReportTitle.Text) & "', rptquery='" & EncryptTripleDES(remSqlScript(txtReportQuery.Text.Replace(";", ""))) & "',datequery='" & CheckEdit1.CheckState & "',usedateasof='" & ckAsOf.CheckState & "',requestby='ADMIN TOOL'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "update pcbr3.tblreporttemplate set rptname='" & rchar(txtReportTitle.Text) & "', rptquery='" & EncryptTripleDES(remSqlScript(txtReportQuery.Text.Replace(";", ""))) & "',datequery='" & CheckEdit1.CheckState & "', usedateasof='" & ckAsOf.CheckState & "', requestby='ADMIN TOOL' where rptid='" & id.Text & "'" : com.ExecuteNonQuery()
        End If
        ClearReports()
        MessageBox.Show("Report Template Successfully Save!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub frmUploadReportTemplate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        id.Text = getReportTemplateID()
    End Sub

    Private Sub mode_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mode.TextChanged
        If mode.Text = "" Then Exit Sub
        com.CommandText = "select * from pcbr3.tblreporttemplate where rptid='" & id.Text & "'"
        rst = com.ExecuteReader
        While rst.Read
            txtReportTitle.Text = rst("rptname").ToString
            If rst("rptquery").ToString.Contains("select") = True Then
                txtReportQuery.Text = rst("rptquery").ToString
            Else
                txtReportQuery.Text = DecryptTripleDES(rst("rptquery").ToString)
            End If
            CheckEdit1.Checked = rst("datequery")
            ckAsOf.Checked = rst("usedateasof")
        End While
        rst.Close()
     
    End Sub
    Public Sub ClearReports()
        id.Text = getReportTemplateID()
        txtReportTitle.Text = ""
        txtReportQuery.Text = ""
        CheckEdit1.Checked = False
        mode.Text = ""

    End Sub
    Public Function remSqlScript(ByVal str As String)
        str = Regex.Replace(str, "drop", "", RegexOptions.IgnoreCase)
        str = Regex.Replace(str, "delete", "", RegexOptions.IgnoreCase)
        str = Regex.Replace(str, "update ", "", RegexOptions.IgnoreCase)
        str = Regex.Replace(str, "insert", "", RegexOptions.IgnoreCase)
        Return str
    End Function

    Private Sub UploadTemplateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UploadTemplateToolStripMenuItem.Click
        MessageBox.Show("HELP" & Environment.NewLine & Environment.NewLine _
                        + "1. Please run your mysql query first to check your syntax is working. " & Environment.NewLine _
                        + "2. Please set your each column using Ex. [colname as 'Column Name'] " & Environment.NewLine _
                        + "3. Use identifier field for date format using for FROM date and TO date Select " & Environment.NewLine _
                        & Environment.NewLine & "1. Format From [{from_fulldate},{from_year},{from_month},{from_day}]" _
                        & Environment.NewLine & "2. Format To [{to_fulldate},{to_year},{to_month},{to_day}]", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ConnectionSetupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConnectionSetupToolStripMenuItem.Click
        frmCentralReportTemplate.Show(Me)
    End Sub

    Private Sub CheckSystemDateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckSystemDateToolStripMenuItem.Click
        Dim rptquery As String = "" : Dim input As String
        Dim objOpenFileDialog As New OpenFileDialog
        'Set the Open dialog properties
        With objOpenFileDialog
            .Filter = "Report File (*.rpt)|*.rpt|All files (*.*)|*.*"
            .FilterIndex = 1
            .Title = "Open File Dialog"
        End With

        'Show the Open dialog and if the user clicks the Open button,
        'load the file
        If objOpenFileDialog.ShowDialog = System.Windows.Forms.DialogResult.OK Then

            Try
                'Read the contents of the file
                Dim sr As StreamReader = File.OpenText(objOpenFileDialog.FileName)
                input = sr.ReadLine()
                While Not input Is Nothing
                    rptquery += input
                    input = sr.ReadLine()
                End While
                sr.Close()
                For Each qry In DecryptTripleDES(rptquery).Split(New Char() {";"c})
                    'MsgBox(qry.Replace(""" & vbCrLf & """, ""))
                    Dim rawqry As String = qry.Replace(vbCrLf, "")
                    'MsgBox(rawqry & " - " & rawqry.Length)
                    If rawqry.Length > 10 Then
                        com.CommandText = rawqry : com.ExecuteNonQuery()
                    Else
                        mode.Text = ""
                        id.Text = rawqry
                        mode.Text = "edit"
                    End If
                Next

            Catch fileException As Exception
                Throw fileException
            End Try
        End If
        objOpenFileDialog.Dispose()
        objOpenFileDialog = Nothing
    End Sub

    Private Sub txtReportQuery_GotFocus(sender As Object, e As EventArgs) Handles txtReportQuery.GotFocus
        If txtReportQuery.Text = "Paste your mysql query here.." Then
            txtReportQuery.Text = ""
        End If
    End Sub

    Private Sub txtReportQuery_LostFocus(sender As Object, e As EventArgs) Handles txtReportQuery.LostFocus
        If txtReportQuery.Text = "" Then
            txtReportQuery.Text = "Paste your mysql query here.."
        End If
    End Sub



    Private Sub txtReportTitle_GotFocus(sender As Object, e As EventArgs) Handles txtReportTitle.GotFocus
        If txtReportTitle.Text = "Report title.." Then
            txtReportTitle.Text = ""
        End If
    End Sub

    Private Sub txtReportTitle_LostFocus(sender As Object, e As EventArgs) Handles txtReportTitle.LostFocus
        If txtReportTitle.Text = "" Then
            txtReportTitle.Text = "Report title.."
        End If
    End Sub


End Class