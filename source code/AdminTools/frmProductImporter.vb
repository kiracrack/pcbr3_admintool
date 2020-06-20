Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO

Public Class frmProductImporter
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub cmdset_Click(sender As Object, e As EventArgs) Handles cmdset.Click
        If TabControl1.SelectedTab Is TabPage1 Then
            If MessageBox.Show("Are you sure you want to continue? " & Environment.NewLine & Environment.NewLine & "Note: There's no undo function. please make sure you doing correctly!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
                Dim rptquery As String = "" : Dim input As String
                Dim sr As StreamReader = File.OpenText(txtFilename.Text)
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
                    End If
                Next
                MessageBox.Show("Product successfully Imported", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
        Else
            Dim detailReportTitle As String = ""
            Dim detailsFile As StreamWriter = Nothing

            If txtCurrentProduct.Text = "" Then
                MessageBox.Show("Please enter product to continue", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If MessageBox.Show("Are you sure you want to continue? " & Environment.NewLine & Environment.NewLine & "Note: There's no undo function. please make sure you doing correctly!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
                Dim saveFileDialog1 As New SaveFileDialog()

                saveFileDialog1.Filter = "Report File (*.prf)|*.prf|All files (*.*)|*.*"
                saveFileDialog1.FileName = LCase(txtCurrentCode.Text) & " " & LCase(txtCurrentProduct.Text) & " (" & If(ckUpdate.Checked = True, "update existing product", "insert new product") & ").prf"
                saveFileDialog1.FilterIndex = 2
                saveFileDialog1.RestoreDirectory = True


                If saveFileDialog1.ShowDialog() = DialogResult.OK Then
                    If System.IO.File.Exists(saveFileDialog1.FileName) = True Then
                        System.IO.File.Delete(saveFileDialog1.FileName)
                    End If
                    detailsFile = New StreamWriter(saveFileDialog1.FileName, True)
                    com.CommandText = "select * from master.loanprod where prodcode='" & txtCurrentCode.Text & "'" : rst = com.ExecuteReader
                    While rst.Read
                        If ckUpdate.Checked = True Then
                            detailReportTitle = "UPDATE `master`.`loanprod` set prodname='" & rst("prodname").ToString & "',withterm='" & rst("withterm").ToString & "',intrate='" & rst("intrate").ToString & "',intmethod='" & rst("intmethod").ToString & "',curr_lngrp='" & rst("curr_lngrp").ToString & "',curr_lnitem='" & rst("curr_lnitem").ToString & "',curr_intgrp='" & rst("curr_intgrp").ToString & "',curr_intitem='" & rst("curr_intitem").ToString & "',curr_pengrp='" & rst("curr_pengrp").ToString & "',curr_penitem='" & rst("curr_penitem").ToString & "',pdue_lngrp='" & rst("pdue_lngrp").ToString & "',pdue_lnitem='" & rst("pdue_lnitem").ToString & "',pdue_intgrp='" & rst("pdue_intgrp").ToString & "',pdue_intitem='" & rst("pdue_intitem").ToString & "',pdue_pengrp='" & rst("pdue_pengrp").ToString & "',pdue_penitem='" & rst("pdue_penitem").ToString & "',il_lngrp='" & rst("il_lngrp").ToString & "',il_lnitem='" & rst("il_lnitem").ToString & "',il_intgrp='" & rst("il_intgrp").ToString & "',il_intitem='" & rst("il_intitem").ToString & "',il_pengrp='" & rst("il_pengrp").ToString & "',il_penitem='" & rst("il_penitem").ToString & "',chgcode1='" & rst("chgcode1").ToString & "',chgld1='" & rst("chgld1").ToString & "',svchgrate='" & rst("svchgrate").ToString & "',chgcode2='" & rst("chgcode2").ToString & "',chgld2='" & rst("chgld2").ToString & "',chgamt2='" & rst("chgamt2").ToString & "',chgcode3='" & rst("chgcode3").ToString & "',chgld3='" & rst("chgld3").ToString & "',chgamt3='" & rst("chgamt3").ToString & "',chgcode4='" & rst("chgcode4").ToString & "',chgld4='" & rst("chgld4").ToString & "',chgamt4='" & rst("chgamt4").ToString & "',chgcode5='" & rst("chgcode5").ToString & "',chgld5='" & rst("chgld5").ToString & "',chgamt5='" & rst("chgamt5").ToString & "',chglndiscitem='" & rst("chglndiscitem").ToString & "',baseprin='" & rst("baseprin").ToString & "',baseprinterm='" & rst("baseprinterm").ToString & "',iscurrfixamt='" & rst("iscurrfixamt").ToString & "',currfixamt='" & rst("currfixamt").ToString & "',iscurrrate='" & rst("iscurrrate").ToString & "',currrate='" & rst("currrate").ToString & "',currfactor='" & rst("currfactor").ToString & "',currbaseon='" & rst("currbaseon").ToString & "',frequency='" & rst("frequency").ToString & "',reqnumbarrear='" & rst("reqnumbarrear").ToString & "',minamtarrear='" & rst("minamtarrear").ToString & "',currdelay='" & rst("currdelay").ToString & "',inccurrnowork='" & rst("inccurrnowork").ToString & "',ispduefixamt='" & rst("ispduefixamt").ToString & "',pduefixamt='" & rst("pduefixamt").ToString & "',ispduerate='" & rst("ispduerate").ToString & "',pduerate='" & rst("pduerate").ToString & "',pduefactor='" & rst("pduefactor").ToString & "',pduebaseon='" & rst("pduebaseon").ToString & "',pduedelay='" & rst("pduedelay").ToString & "',incpduenowork='" & rst("incpduenowork").ToString & "',maxtermdays='" & rst("maxtermdays").ToString & "',mintermdays='" & rst("mintermdays").ToString & "',intdiscmode='" & rst("intdiscmode").ToString & "',discrate='" & rst("discrate").ToString & "',advintmode='" & rst("advintmode").ToString & "',advintdays='" & rst("advintdays").ToString & "',advintcode='" & rst("advintcode").ToString & "',fixamortmode='" & rst("fixamortmode").ToString & "',amortcode='" & rst("amortcode").ToString & "',excessintpmntmode='" & rst("excessintpmntmode").ToString & "',intonexcessitem='" & rst("intonexcessitem").ToString & "',allowableexcessindays='" & rst("allowableexcessindays").ToString & "',intonexcessoverallowance='" & rst("intonexcessoverallowance").ToString & "', fixchgamt2='" & rst("fixchgamt2").ToString & "',rateonprin2='" & rst("rateonprin2").ToString & "',rateonprinterm2='" & rst("rateonprinterm2").ToString & "',chgrate2='" & rst("chgrate2").ToString & "',fixchgamt3='" & rst("fixchgamt3").ToString & "',rateonprin3='" & rst("rateonprin3").ToString & "',rateonprinterm3='" & rst("rateonprinterm3").ToString & "',chgrate3='" & rst("chgrate3").ToString & "',fixchgamt4='" & rst("fixchgamt4").ToString & "',rateonprin4='" & rst("rateonprin4").ToString & "',rateonprinterm4='" & rst("rateonprinterm4").ToString & "',chgrate4='" & rst("chgrate4").ToString & "',fixchgamt5='" & rst("fixchgamt5").ToString & "',rateonprin5='" & rst("rateonprin5").ToString & "',rateonprinterm5='" & rst("rateonprinterm5").ToString & "',chgrate5='" & rst("chgrate5").ToString & "', microfinance='" & rst("microfinance").ToString & "',waived_pnltygrp='" & rst("waived_pnltygrp").ToString & "',waived_pnltyitem='" & rst("waived_pnltyitem").ToString & "',withamortinsurance='" & rst("withamortinsurance").ToString & "',amortinsurancechgcode='" & rst("amortinsurancechgcode").ToString & "' where prodcode='" & rst("prodcode").ToString & "';"
                        Else
                            detailReportTitle = "INSERT INTO `master`.`loanprod` set prodcode='" & rst("prodcode").ToString & "',prodname='" & rst("prodname").ToString & "',withterm='" & rst("withterm").ToString & "',intrate='" & rst("intrate").ToString & "',intmethod='" & rst("intmethod").ToString & "',curr_lngrp='" & rst("curr_lngrp").ToString & "',curr_lnitem='" & rst("curr_lnitem").ToString & "',curr_intgrp='" & rst("curr_intgrp").ToString & "',curr_intitem='" & rst("curr_intitem").ToString & "',curr_pengrp='" & rst("curr_pengrp").ToString & "',curr_penitem='" & rst("curr_penitem").ToString & "',pdue_lngrp='" & rst("pdue_lngrp").ToString & "',pdue_lnitem='" & rst("pdue_lnitem").ToString & "',pdue_intgrp='" & rst("pdue_intgrp").ToString & "',pdue_intitem='" & rst("pdue_intitem").ToString & "',pdue_pengrp='" & rst("pdue_pengrp").ToString & "',pdue_penitem='" & rst("pdue_penitem").ToString & "',il_lngrp='" & rst("il_lngrp").ToString & "',il_lnitem='" & rst("il_lnitem").ToString & "',il_intgrp='" & rst("il_intgrp").ToString & "',il_intitem='" & rst("il_intitem").ToString & "',il_pengrp='" & rst("il_pengrp").ToString & "',il_penitem='" & rst("il_penitem").ToString & "',chgcode1='" & rst("chgcode1").ToString & "',chgld1='" & rst("chgld1").ToString & "',svchgrate='" & rst("svchgrate").ToString & "',chgcode2='" & rst("chgcode2").ToString & "',chgld2='" & rst("chgld2").ToString & "',chgamt2='" & rst("chgamt2").ToString & "',chgcode3='" & rst("chgcode3").ToString & "',chgld3='" & rst("chgld3").ToString & "',chgamt3='" & rst("chgamt3").ToString & "',chgcode4='" & rst("chgcode4").ToString & "',chgld4='" & rst("chgld4").ToString & "',chgamt4='" & rst("chgamt4").ToString & "',chgcode5='" & rst("chgcode5").ToString & "',chgld5='" & rst("chgld5").ToString & "',chgamt5='" & rst("chgamt5").ToString & "',chglndiscitem='" & rst("chglndiscitem").ToString & "',baseprin='" & rst("baseprin").ToString & "',baseprinterm='" & rst("baseprinterm").ToString & "',iscurrfixamt='" & rst("iscurrfixamt").ToString & "',currfixamt='" & rst("currfixamt").ToString & "',iscurrrate='" & rst("iscurrrate").ToString & "',currrate='" & rst("currrate").ToString & "',currfactor='" & rst("currfactor").ToString & "',currbaseon='" & rst("currbaseon").ToString & "',frequency='" & rst("frequency").ToString & "',reqnumbarrear='" & rst("reqnumbarrear").ToString & "',minamtarrear='" & rst("minamtarrear").ToString & "',currdelay='" & rst("currdelay").ToString & "',inccurrnowork='" & rst("inccurrnowork").ToString & "',ispduefixamt='" & rst("ispduefixamt").ToString & "',pduefixamt='" & rst("pduefixamt").ToString & "',ispduerate='" & rst("ispduerate").ToString & "',pduerate='" & rst("pduerate").ToString & "',pduefactor='" & rst("pduefactor").ToString & "',pduebaseon='" & rst("pduebaseon").ToString & "',pduedelay='" & rst("pduedelay").ToString & "',incpduenowork='" & rst("incpduenowork").ToString & "',maxtermdays='" & rst("maxtermdays").ToString & "',mintermdays='" & rst("mintermdays").ToString & "',intdiscmode='" & rst("intdiscmode").ToString & "',discrate='" & rst("discrate").ToString & "',advintmode='" & rst("advintmode").ToString & "',advintdays='" & rst("advintdays").ToString & "',advintcode='" & rst("advintcode").ToString & "',fixamortmode='" & rst("fixamortmode").ToString & "',amortcode='" & rst("amortcode").ToString & "',excessintpmntmode='" & rst("excessintpmntmode").ToString & "',intonexcessitem='" & rst("intonexcessitem").ToString & "',allowableexcessindays='" & rst("allowableexcessindays").ToString & "',intonexcessoverallowance='" & rst("intonexcessoverallowance").ToString & "', fixchgamt2='" & rst("fixchgamt2").ToString & "',rateonprin2='" & rst("rateonprin2").ToString & "',rateonprinterm2='" & rst("rateonprinterm2").ToString & "',chgrate2='" & rst("chgrate2").ToString & "',fixchgamt3='" & rst("fixchgamt3").ToString & "',rateonprin3='" & rst("rateonprin3").ToString & "',rateonprinterm3='" & rst("rateonprinterm3").ToString & "',chgrate3='" & rst("chgrate3").ToString & "',fixchgamt4='" & rst("fixchgamt4").ToString & "',rateonprin4='" & rst("rateonprin4").ToString & "',rateonprinterm4='" & rst("rateonprinterm4").ToString & "',chgrate4='" & rst("chgrate4").ToString & "',fixchgamt5='" & rst("fixchgamt5").ToString & "',rateonprin5='" & rst("rateonprin5").ToString & "',rateonprinterm5='" & rst("rateonprinterm5").ToString & "',chgrate5='" & rst("chgrate5").ToString & "', microfinance='" & rst("microfinance").ToString & "',waived_pnltygrp='" & rst("waived_pnltygrp").ToString & "',waived_pnltyitem='" & rst("waived_pnltyitem").ToString & "',withamortinsurance='" & rst("withamortinsurance").ToString & "',amortinsurancechgcode='" & rst("amortinsurancechgcode").ToString & "';"
                        End If
                    End While
                    rst.Close()

                    detailsFile.WriteLine(EncryptTripleDES(detailReportTitle))
                    detailsFile.Close()
                    MessageBox.Show("Product successfully exported", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If

    End Sub


    Private Sub userid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCurrentCode.KeyPress
        If e.KeyChar() = Chr(13) Then
            If countqry("master.loanprod", "prodcode='" & txtCurrentCode.Text & "'") = 0 Then
                MsgBox("Product dos'nt Exixts!", vbExclamation)
                Exit Sub
            End If
            com.CommandText = "select * from master.loanprod where prodcode='" & txtCurrentCode.Text & "'" : rst = com.ExecuteReader
            While rst.Read
                txtCurrentProduct.Text = rst("prodname").ToString
            End While
            rst.Close()
        End If
    End Sub

   
    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedTab Is TabPage1 Then
            cmdset.Text = "Comfirm Import Product"
        Else
            cmdset.Text = "Comfirm Export Product"
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim objOpenFileDialog As New OpenFileDialog
        'Set the Open dialog properties
        With objOpenFileDialog
            .Filter = "Report File (*.prf)|*.prf|All files (*.*)|*.*"
            .FilterIndex = 1
            .Title = "Open File Dialog"
        End With

        'Show the Open dialog and if the user clicks the Open button,
        'load the file
        If objOpenFileDialog.ShowDialog = System.Windows.Forms.DialogResult.OK Then

            Try
                'Read the contents of the file
                txtFilename.Text = objOpenFileDialog.FileName

            Catch fileException As Exception
                Throw fileException
            End Try
        End If
        objOpenFileDialog.Dispose()
        objOpenFileDialog = Nothing
    End Sub
End Class