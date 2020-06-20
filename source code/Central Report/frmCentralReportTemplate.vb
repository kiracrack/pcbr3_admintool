Imports System.Globalization
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frmCentralReportTemplate
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmCentralReportDate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        filterTemplate()
    End Sub

    Public Sub filterTemplate()
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("SELECT rptid,rptname as 'Report Template' from pcbr3.tblreporttemplate order by rptname asc", conn)
        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        MyDataGridView.Columns("rptid").Visible = False
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        If MessageBox.Show("Are you sure you want to edit selected report? ", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            frmCentraReportDeveloper.mode.Text = ""
            frmCentraReportDeveloper.id.Text = MyDataGridView.Item("rptid", MyDataGridView.CurrentRow.Index).Value().ToString
            frmCentraReportDeveloper.mode.Text = "edit"
            frmCentraReportDeveloper.txtReportTitle.Text = MyDataGridView.Item("Report Template", MyDataGridView.CurrentRow.Index).Value().ToString
            Me.Close()
        End If
    End Sub
    Private Sub dataGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyDataGridView.KeyDown
        If e.KeyCode = Keys.Enter Then
            ToolStripMenuItem1.PerformClick()
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        filterTemplate()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        If MessageBox.Show("Are you sure you want to delete selected template? ", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "delete from pcbr3.tblreporttemplate where rptid = '" & MyDataGridView.Item("rptid", MyDataGridView.CurrentRow.Index).Value().ToString & "'" : com.ExecuteNonQuery()
            com.CommandText = "delete from pcbr3.tblreportconfig where rptid = '" & MyDataGridView.Item("rptid", MyDataGridView.CurrentRow.Index).Value().ToString & "'" : com.ExecuteNonQuery()
            filterTemplate()
        End If
    End Sub

    Private Sub DuplicateTemplateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DuplicateTemplateToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to duplicate selected template? ", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim newid As String = getReportTemplateID()
            com.CommandText = "insert into pcbr3.tblreporttemplate (rptid,rptname,rptquery,status,datequery,requestby) select '" & newid & "','" & MyDataGridView.Item("Report Template", MyDataGridView.CurrentRow.Index).Value().ToString & " - COPY',rptquery,status,datequery,requestby from pcbr3.tblreporttemplate where rptid = '" & MyDataGridView.Item("rptid", MyDataGridView.CurrentRow.Index).Value().ToString & "'" : com.ExecuteNonQuery()
            com.CommandText = "insert into pcbr3.tblreportconfig (rptid,colname,coltype,colgroup,colgrpsum,colgrpsumtext,colgrpsumtype,colgensum,colgensumtext,colgensumtype,sortorder,alignment,status) " _
                    + " select '" & newid & "',colname,coltype,colgroup,colgrpsum,colgrpsumtext,colgrpsumtype,colgensum,colgensumtext,colgensumtype,sortorder,alignment,status from pcbr3.tblreportconfig where rptid = '" & MyDataGridView.Item("rptid", MyDataGridView.CurrentRow.Index).Value().ToString & "'" : com.ExecuteNonQuery()
            filterTemplate()
        End If
    End Sub

    Private Sub ExportTemplateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportTemplateToolStripMenuItem.Click
        Dim detailReportTitle As String = ""
        Dim detailReportDetails As String = ""
        Dim detailsFile As StreamWriter = Nothing

        Dim saveFileDialog1 As New SaveFileDialog()

        saveFileDialog1.Filter = "Report File (*.rpt)|*.rpt|All files (*.*)|*.*"
        saveFileDialog1.FileName = LCase(MyDataGridView.Item("Report Template", MyDataGridView.CurrentRow.Index).Value().ToString) & " " & Now.ToString.Replace("/", "").Replace(":", "") & ".rpt"
        saveFileDialog1.FilterIndex = 2
        saveFileDialog1.RestoreDirectory = True


        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            If System.IO.File.Exists(saveFileDialog1.FileName) = True Then
                System.IO.File.Delete(saveFileDialog1.FileName)
            End If
            detailsFile = New StreamWriter(saveFileDialog1.FileName, True)
            detailReportTitle = "delete from pcbr3.tblreporttemplate where rptid='" & MyDataGridView.Item("rptid", MyDataGridView.CurrentRow.Index).Value().ToString & "';" + Environment.NewLine
            com.CommandText = "select * from pcbr3.tblreporttemplate where rptid='" & MyDataGridView.Item("rptid", MyDataGridView.CurrentRow.Index).Value().ToString & "'" : rst = com.ExecuteReader
            While rst.Read
                detailReportTitle += "insert into pcbr3.tblreporttemplate set rptid='" & rst("rptid").ToString & "', rptname='" & rchar(rst("rptname").ToString) & "', rptquery='" & rchar(rst("rptquery").ToString) & "', status='" & rst("status").ToString & "', datequery=" & rst("datequery") & ", usedateasof=" & rst("usedateasof") & ", requestby='" & rst("requestby").ToString & "';"
            End While
            rst.Close()

            detailReportDetails = "delete from pcbr3.tblreportconfig where rptid='" & MyDataGridView.Item("rptid", MyDataGridView.CurrentRow.Index).Value().ToString & "';" + Environment.NewLine
            com.CommandText = "select * from pcbr3.tblreportconfig where rptid='" & MyDataGridView.Item("rptid", MyDataGridView.CurrentRow.Index).Value().ToString & "'" : rst = com.ExecuteReader
            While rst.Read
                detailReportDetails += "insert into pcbr3.tblreportconfig set rptid='" & rst("rptid").ToString & "', colname='" & rst("colname").ToString & "', coltype='" & rst("coltype").ToString & "', colgroup=" & rst("colgroup") & ", colgrpsum=" & rst("colgrpsum") & ", colgrpsumtext='" & rst("colgrpsumtext").ToString & "',colgrpsumtype='" & rst("colgrpsumtype").ToString & "', colgensum=" & rst("colgensum") & ", colgensumtext='" & rst("colgensumtext").ToString & "', colgensumtype='" & rst("colgensumtype").ToString & "', sortorder='" & rst("sortorder").ToString & "', alignment='" & rst("alignment").ToString & "', status='" & rst("status").ToString & "';"
            End While
            rst.Close()
            detailsFile.WriteLine(EncryptTripleDES(detailReportTitle + detailReportDetails + MyDataGridView.Item("rptid", MyDataGridView.CurrentRow.Index).Value().ToString))
            detailsFile.Close()
            MessageBox.Show("Report successfully exported", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class
