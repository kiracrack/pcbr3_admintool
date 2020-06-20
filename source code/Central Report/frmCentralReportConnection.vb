Imports System.Globalization
Imports System.IO

Public Class frmCentralReportConnection
    Dim showSerach As Boolean = False
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function

    Public Sub LoadConnection()
        Dim path As String = Application.StartupPath.ToString & "\Connection"
        ls.Items.Clear()
        For Each file As String In System.IO.Directory.GetFiles(path)
            ls.Items.Add(UCase(System.IO.Path.GetFileNameWithoutExtension(file)))
        Next
    End Sub

    Private Sub frmUnblockClearLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If System.IO.Directory.Exists(Application.StartupPath.ToString & "\Config") = False Then
            System.IO.Directory.CreateDirectory(Application.StartupPath.ToString & "\Config")
        End If
        LoadConnection()
        Dim rpt_file As String = ""
        If ckLive.Checked = True Then
            rpt_file = file_central_live
        Else
            rpt_file = file_central_backup
        End If
        If System.IO.File.Exists(rpt_file) = True Then
            Dim sr As StreamReader = File.OpenText(rpt_file)
            Dim br As String = sr.ReadToEnd : sr.Close()
            For Each word In br.Split(New Char() {","c})
                For i = 0 To ls.Items.Count - 1
                    If ls.Items(i).ToString = word.ToString.Replace(vbCrLf, "") Then
                        ls.SetItemCheckState(i, CheckState.Checked)
                    End If
                Next
            Next
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MessageBox.Show("Are you sure you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            Dim detailsFile As StreamWriter = Nothing
            Dim str_conn As String = ""
            For Each i As Object In ls.CheckedItems
                str_conn = str_conn & i.ToString & ","
            Next
            Dim rpt_file As String = ""
            If ckLive.Checked = True Then
                rpt_file = file_central_live
            Else
                rpt_file = file_central_backup
            End If
            str_conn = str_conn.Remove(str_conn.Length - 1, 1)
            DeleteExistingFile(rpt_file)
            detailsFile = Nothing
            detailsFile = New StreamWriter(rpt_file, True)
            detailsFile.WriteLine(str_conn)
            detailsFile.Close()
            MsgBox("Connection successfuly save!", MsgBoxStyle.Information)
        End If
    End Sub

      Private Sub ls_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ls.SelectedIndexChanged, ls.ItemCheck
        If ls.CheckedItems.Count > 0 Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If
    End Sub
   
End Class
