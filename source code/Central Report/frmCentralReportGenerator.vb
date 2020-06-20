Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Drawing.Printing
Imports System.Text

Public Class frmCentralReportGenerator
    
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmPLDTOffices_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtReportTemplate.Items.Clear()
        com.CommandText = "select * from pcbr3.tblreporttemplate order by rptname asc" : rst = com.ExecuteReader
        While rst.Read
            txtReportTemplate.Items.Add(New ComboBoxItem(rst("rptname").ToString, rst("rptid")))
        End While
        rst.Close()
    End Sub
    Private Sub cmdset_Click(sender As Object, e As EventArgs) Handles cmdset.Click
        If txtBranch.Text = "" Then
            MessageBox.Show("Please select connection", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtBranch.Focus()
            Exit Sub
        ElseIf txtReportTemplate.Text = "" Then
            MessageBox.Show("Please select report template", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtReportTemplate.Focus()
            Exit Sub
        ElseIf System.IO.Directory.Exists(Application.StartupPath.ToString & "\mysql.exe") Then
            MessageBox.Show("Mysql.exe file missing on admin tool directory", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Dim saveFileDialog1 As New SaveFileDialog()
        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        If radConsolidated.Checked = True Then
            saveFileDialog1.Filter = "Report File (*.xls)|*.xls|All files (*.*)|*.*"
            saveFileDialog1.FileName = LCase(txtReportTemplate.Text) & ".xls"
            saveFileDialog1.FilterIndex = 2
            saveFileDialog1.RestoreDirectory = True
            If Not saveFileDialog1.ShowDialog() = DialogResult.OK Then Exit Sub
            If System.IO.File.Exists(saveFileDialog1.FileName) = True Then
                System.IO.File.Delete(saveFileDialog1.FileName)
            End If

        Else
            If Not f.ShowDialog() = DialogResult.OK Then Exit Sub
            ' dst.WriteXml(f.SelectedPath & "\" & Me.Text & ".xls")
        End If

        cmdset.Text = "Exporting reports..."
        cmdset.Enabled = False
        Dim temptable As String = "rpt" & GlobalFullname.Replace(" ", "")
        Dim tempdir As String = Application.StartupPath.ToString & "\Config\GeneratedReport"
        If System.IO.Directory.Exists(tempdir) Then
            System.IO.Directory.Delete(tempdir, True)
        End If
        Dim rpt_file As String = ""
        If txtBranch.SelectedIndex = 0 Then
            rpt_file = file_central_live
        Else
            rpt_file = file_central_backup
        End If

        Dim sr As StreamReader = File.OpenText(rpt_file)
        Dim br As String = sr.ReadToEnd : sr.Close()


        If System.IO.Directory.Exists(tempdir) = False Then
            System.IO.Directory.CreateDirectory(tempdir)
        End If

        For Each word In br.Split(New Char() {",c"})
            Dim strSetup As String = "" : Dim s_ip As String = "" : Dim s_port As String = "" : Dim s_user As String = "" : Dim s_pass As String = "" : Dim Command As String = ""
            Dim sr2 As StreamReader = File.OpenText(file_conn_dir & "\" & word.ToString.Replace(vbCrLf, ""))
            Dim br2 As String = sr2.ReadLine() : sr2.Close()
            strSetup = DecryptTripleDES(br2) : Dim cnt As Integer = 0
            For Each word2 In strSetup.Split(New Char() {","c})
                If cnt = 1 Then
                    s_ip = word2
                ElseIf cnt = 2 Then
                    s_port = word2
                ElseIf cnt = 3 Then
                    s_user = word2
                ElseIf cnt = 4 Then
                    s_pass = word2
                End If
                cnt = cnt + 1
            Next
            Dim strquery As String = ""
            com.CommandText = "select * from pcbr3.tblreporttemplate where rptid='" & id.Text & "'" : rst = com.ExecuteReader
            While rst.Read
                strquery = DecryptTripleDES(rst("rptquery").ToString)
                If CBool(rst("datequery")) = True Then
                    strquery = rDateSelect(strquery, date_from.Text, date_to.Text)
                End If
                'MsgBox(strquery.ToString.Replace(vbCrLf, " ").Replace(";", ""))
                Command += "mysql -e """ & strquery.ToString.Replace(vbCrLf, " ").Replace(";", "") & """ -h " & s_ip & " -P " & s_port & " -u " & s_user & " -p" & s_pass & " master > """ & Application.StartupPath.ToString & "\Config\GeneratedReport\" & word.ToString.Replace(vbCrLf, "") & ".txt"""" "
                Command = Command.Remove(Command.Length - 2, 2)
                Shell("cmd /k" & Command.ToString.Replace(vbCrLf, " ") & " & exit", AppWinStyle.Hide, True)
            End While
            rst.Close()
        Next

        Dim Paths() As String = Directory.GetFiles(tempdir, "*.txt")
        If radConsolidated.Checked = True Then
            Dim ln As Integer = 0
            For Each Path As String In Paths
                If ln > 0 Then
                    IO.File.WriteAllText(Path, File.ReadAllText(Path).Substring(File.ReadAllText(Path).IndexOf(vbLf) + 1))
                End If
                File.AppendAllText(saveFileDialog1.FileName, File.ReadAllText(Path), Encoding.Default) 'The text file will be created if it does not already exist 
                If File.ReadAllText(Path).Length > 0 Then
                    ln = ln + 1
                End If
            Next
        Else
            For Each Path As String In Paths
                IO.File.Delete(f.SelectedPath & "\" & System.IO.Path.GetFileNameWithoutExtension(LCase(Path)) & ".xls")
                File.AppendAllText(f.SelectedPath & "\" & System.IO.Path.GetFileNameWithoutExtension(LCase(Path)) & ".xls", File.ReadAllText(Path), Encoding.Default) 'The text file will be created if it does not already exist 
            Next
        End If
        
        cmdset.Text = "Generate Report"
        cmdset.Enabled = True
        MessageBox.Show("Report successfully exported", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Function LoadFile(ByVal filePath As String, ByVal table As String)
        Dim records As String = "" : Dim cnt As String = 0
        For Each line As String In File.ReadAllLines(filePath)
            If cnt > 0 Then
                Dim values As String = ""
                For Each field As String In line.Split(New String() {ControlChars.Tab}, StringSplitOptions.None)
                    values += "'" & rchar(field) & "',"
                Next
                If values.Length <> 0 Then
                    records += "(" & values.Remove(values.Length - 1, 1) & "),"
                End If
            End If
            cnt = cnt + 1
        Next

        If records.Length <> 0 Then
            com.CommandText = "insert into action_query." & table & " values " & records.Remove(records.Length - 1, 1) : com.ExecuteNonQuery()
        End If
        Return True
    End Function

    Private Sub ConnectionSetupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConnectionSetupToolStripMenuItem.Click
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

    Private Sub CheckSystemDateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckSystemDateToolStripMenuItem.Click
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

    Private Sub txtBranch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtReportTemplate.SelectedIndexChanged
        On Error Resume Next
        id.Text = DirectCast(txtReportTemplate.SelectedItem, ComboBoxItem).HiddenValue()

        If CBool(qrysingledata("datequery", "datequery", "pcbr3.tblreporttemplate where rptid='" & id.Text & "'")) = True Then
            If CBool(qrysingledata("usedateasof", "usedateasof", "pcbr3.tblreporttemplate where rptid='" & id.Text & "'")) = True Then
                lblWarning.Text = "Please select as of transaction date.."
                lblWarning.ForeColor = DefaultForeColor

                lblasof.Enabled = True
                date_from.Enabled = False
                date_to.Location = date_from.Location
                date_to.Size = New Size(301, 23)
                date_to.Enabled = True
                lblasof.Text = "As of"
            Else
                lblWarning.Text = "Please select between transaction date.."
                lblWarning.ForeColor = DefaultForeColor

                lblasof.Enabled = True
                lblasof.Text = "Date Filter"
                date_from.Enabled = True
                date_to.Enabled = True
                date_to.Location = New Point(407, 109)
                date_to.Size = date_from.Size
            End If
        Else
            lblWarning.Text = "Report will vary to current system date "
            lblWarning.ForeColor = Color.Red
            lblasof.Enabled = False
            date_from.Enabled = False
            date_to.Enabled = False
        End If
    End Sub

    Public Function rDateSelect(ByVal str As String, ByVal sFromdate As Date, ByVal sTodate As Date)
        Dim from_dateSel As Date = sFromdate
        Dim to_dateSel As Date = sTodate

        ' CONVERTION FROM DATE SELECT
        Dim from_RFullDate As String = ConvertDate(date_from.Text)
        Dim from_RMonthDate As String = from_dateSel.ToString("MM")
        Dim from_RDayDate As String = from_dateSel.ToString("dd")
        Dim from_RYearDate As String = from_dateSel.Year
        str = str.Replace("{from_fulldate}", from_RFullDate)
        str = str.Replace("{from_year}", from_RYearDate)
        str = str.Replace("{from_month}", from_RMonthDate)
        str = str.Replace("{from_day}", from_RDayDate)

        ' CONVERTION TO DATE SELECT
        Dim to_RFullDate As String = ConvertDate(date_to.Text)
        Dim to_RMonthDate As String = to_dateSel.ToString("MM")
        Dim to_RDayDate As String = to_dateSel.ToString("dd")
        Dim to_RYearDate As String = to_dateSel.Year
        str = str.Replace("{to_fulldate}", to_RFullDate)
        str = str.Replace("{to_year}", to_RYearDate)
        str = str.Replace("{to_month}", to_RMonthDate)
        str = str.Replace("{to_day}", to_RDayDate)
        Return str
    End Function

    'com.CommandText = "drop table if exists action_query." & temptable : com.ExecuteNonQuery()

    'Dim executeqry As String = ""
    'com.CommandText = "select * from pcbr3.tblreporttemplate where rptid='" & id.Text & "'" : rst = com.ExecuteReader
    'While rst.Read
    '    executeqry = DecryptTripleDES(rst("rptquery").ToString)
    '    If CBool(rst("datequery")) = True Then
    '        executeqry = rDateSelect(executeqry, date_from.Text, date_to.Text)
    '    End If
    'End While
    'rst.Close()

    'com.CommandText = "create table action_query." & temptable & " " & If(executeqry.Contains(";") = True, executeqry.Replace(";", "") & " limit 1;", executeqry & " limit 1;") : com.ExecuteNonQuery()
    'com.CommandText = "delete from action_query." & temptable & ";" : com.ExecuteNonQuery()
  
End Class