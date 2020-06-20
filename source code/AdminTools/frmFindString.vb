Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Drawing.Printing

Public Class frmFindString
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmRequestType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MyDataGridView.Rows.Clear()
        MyDataGridView.ColumnCount = 3
        MyDataGridView.ColumnHeadersVisible = True

        MyDataGridView.Columns(0).Name = "Table Name"
        MyDataGridView.Columns(1).Name = "Column Name"
        MyDataGridView.Columns(2).Name = "Found Match"

        MyDataGridView.Columns(0).Width = 50
        MyDataGridView.Columns(1).Width = 50
        MyDataGridView.Columns(2).Width = 500

        LoadToComboBoxPre("Show databases;", "Database", "Database", txtDatabase)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtSearch.Text = "" Then Exit Sub
        Dim tables_list As String = "" : Dim column_list As String = ""
        MyDataGridView.Rows.Clear()

        com.CommandText = "Show tables from " & txtDatabase.Text : rst = com.ExecuteReader
        While rst.Read
            tables_list = tables_list + rst("Tables_in_" & txtDatabase.Text).ToString & ","
        End While
        rst.Close()

        If tables_list <> "" Then
            tables_list = tables_list.Remove(tables_list.Length - 1, 1)
        End If

        'For Each strresult In tables_list.Split(New Char() {","c})
        '    com.CommandText = "Show fields from " & txtDatabase.Text & "." & strresult : rst = com.ExecuteReader
        '    While rst.Read
        '        column_list = column_list + rst("Field").ToString & ","
        '    End While
        '    rst.Close()
        'Next

     
        'find match strings
        For Each strTable In tables_list.Split(New Char() {","c})
            column_list = ""
            com.CommandText = "Show fields from " & txtDatabase.Text & "." & strTable : rst = com.ExecuteReader
            While rst.Read
                column_list = column_list + rst("Field").ToString & ","
            End While
            rst.Close()

            If column_list <> "" Then
                column_list = column_list.Remove(column_list.Length - 1, 1)
            End If

            For Each strcolumn In column_list.Split(New Char() {","c})
                com.CommandText = "select * from " & txtDatabase.Text & "." & strTable & " where " & strcolumn & " like '%" & txtSearch.Text & "%'" : rst = com.ExecuteReader
                While rst.Read
                    MyDataGridView.Rows.Add(strTable, strcolumn, rst(strcolumn).ToString)
                End While
                rst.Close()
            Next
        Next
        'MsgBox(column_list)




        'dst = New DataSet
        'msda = New MySqlDataAdapter("Show tables from " & txtDatabase.Text, conn)
        'msda.Fill(dst, 0)
        'For cnt = 0 To dst.Tables(0).Rows.Count - 1
        '    With (dst.Tables(0))
        '        com.CommandText = "show fields from " & txtDatabase.Text & "." & .Rows(cnt)("Table_in_" & txtDatabase.Text).ToString() : rst = com.ExecuteReader
        '        While rst.Read

        '            MsgBox(.Rows(cnt)("Table_in_" & txtDatabase.Text).ToString(), " | ", rst("Field").ToString)
        '            'MyDataGridView.Rows.Add(arr)
        '        End While
        '        rst.Close()
        '    End With
        'Next
    End Sub
    
  
End Class