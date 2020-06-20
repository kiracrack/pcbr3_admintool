Imports System.Globalization
Imports System.IO

Public Class frmCentralReportDate
    Dim showSerach As Boolean = False
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmCentralReportDate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.View = View.Details
        ListView1.Columns.Add("Server", 200, HorizontalAlignment.Left)
        ListView1.Columns.Add("System Date", 120, HorizontalAlignment.Center)
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
                OpenCentralServer(file_conn_dir & "\" & word.Replace(vbCrLf, ""))
                If connclient.State = ConnectionState.Open Then
                    comclient.CommandText = "select *,date_format(trndate,'%Y-%m-%d') as 'dt' from master.syscalendar where forsystem=1" : rstclient = comclient.ExecuteReader
                    While rstclient.Read
                        Dim item1 As New ListViewItem(UCase(word.Replace(vbCrLf, "")), 0)
                        item1.SubItems.Add(rstclient("dt").ToString)
                        ListView1.Items.AddRange(New ListViewItem() {item1})
                    End While
                    rstclient.Close()
                Else
                    Dim item1 As New ListViewItem(UCase(word.Replace(vbCrLf, "")), 0)
                    item1.SubItems.Add("DOWN")
                    item1.Font = New Font(item1.Font, item1.Font.Style Or FontStyle.Strikeout)
                    item1.ForeColor = Color.Red
                    ListView1.Items.AddRange(New ListViewItem() {item1})

                End If
            Next
        End If
    End Sub

End Class
