Imports System.Globalization
Imports MySql.Data.MySqlClient

Public Class frmMBOSavingFIlter
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function
   
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim productSetting As String = ""
        If frmClientIdentifier.txtClientType.SelectedIndex = 0 Then
            For Each i As Object In ls.CheckedItems
                Dim getDepcode As String = qrysingledata("prodcode", "prodcode", "master.loanprod where lcase(prodname) = '" & i.ToString & "'")
                productSetting = productSetting & "loanprod='" & getDepcode & "' or "
            Next
            If productSetting.Length > 0 Then
                productSetting = productSetting.Remove(productSetting.Length - 3, 3)
                productSetting = " and (" & productSetting & ")"
                frmClientIdentifier.txtProfilter.Text = productSetting
            End If
        Else
            For Each i As Object In ls.CheckedItems
                Dim getDepcode As String = qrysingledata("depcode", "depcode", "master.depositprod where lcase(description) = '" & i.ToString & "'")
                productSetting = productSetting & "depcode='" & getDepcode & "' or "
            Next
            If productSetting.Length > 0 Then
                productSetting = productSetting.Remove(productSetting.Length - 3, 3)
                productSetting = " and (" & productSetting & ")"
                frmClientIdentifier.txtProfilter.Text = productSetting
            End If
        End If
      
    End Sub


    Public Sub LoadSavingAccount()
        ls.Items.Clear()
        com.CommandText = "select * from master.depositprod order by description asc" : rst = com.ExecuteReader
        While rst.Read
            ls.Items.Add(LCase(rst("description").ToString))
        End While
        rst.Close()
    End Sub

    Public Sub LoadLoanProductAccount()
        ls.Items.Clear()
        com.CommandText = "select * from master.loanprod order by prodname asc" : rst = com.ExecuteReader
        While rst.Read
            ls.Items.Add(LCase(rst("prodname").ToString))
        End While
        rst.Close()
    End Sub

    Private Sub frmMBOSavingFIlter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If frmClientIdentifier.txtClientType.SelectedIndex = 0 Then
            LoadLoanProductAccount()
        Else
            LoadSavingAccount()
        End If

    End Sub
End Class
