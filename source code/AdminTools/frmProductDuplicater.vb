Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO

Public Class frmProductDuplicater
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
   
    Private Sub cmdset_Click(sender As Object, e As EventArgs) Handles cmdset.Click
        If MessageBox.Show("Are you sure you want to continue? " & Environment.NewLine & Environment.NewLine & "Note: There's no undo function. please make sure you doing correctly!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
            com.CommandText = "INSERT INTO `master`.`loanprod` (prodcode,prodname,withterm,intrate,intmethod,curr_lngrp,curr_lnitem,curr_intgrp,curr_intitem,curr_pengrp,curr_penitem,pdue_lngrp,pdue_lnitem,pdue_intgrp,pdue_intitem,pdue_pengrp,pdue_penitem,il_lngrp,il_lnitem,il_intgrp,il_intitem,il_pengrp,il_penitem,chgcode1,chgld1,svchgrate,chgcode2,chgld2,chgamt2,chgcode3,chgld3,chgamt3,chgcode4,chgld4,chgamt4,chgcode5,chgld5,chgamt5,chglndiscitem,baseprin,baseprinterm,iscurrfixamt,currfixamt,iscurrrate,currrate,currfactor,currbaseon,frequency,reqnumbarrear,minamtarrear,currdelay,inccurrnowork,ispduefixamt,pduefixamt,ispduerate,pduerate,pduefactor,pduebaseon,pduedelay,incpduenowork,maxtermdays,mintermdays,intdiscmode,discrate,advintmode,advintdays,advintcode,fixamortmode,amortcode,excessintpmntmode,intonexcessitem,allowableexcessindays,intonexcessoverallowance, fixchgamt2,rateonprin2,rateonprinterm2,chgrate2,fixchgamt3,rateonprin3,rateonprinterm3,chgrate3,fixchgamt4,rateonprin4,rateonprinterm4,chgrate4,fixchgamt5,rateonprin5,rateonprinterm5,chgrate5, microfinance,waived_pnltygrp,waived_pnltyitem,withamortinsurance,amortinsurancechgcode) " _
                               + " SELECT '" & txtNewCode.Text & "','" & txtNewProduct.Text & "',withterm,intrate,intmethod,curr_lngrp,curr_lnitem,curr_intgrp,curr_intitem,curr_pengrp,curr_penitem,pdue_lngrp,pdue_lnitem,pdue_intgrp,pdue_intitem,pdue_pengrp,pdue_penitem,il_lngrp,il_lnitem,il_intgrp,il_intitem,il_pengrp,il_penitem,chgcode1,chgld1,svchgrate,chgcode2,chgld2,chgamt2,chgcode3,chgld3,chgamt3,chgcode4,chgld4,chgamt4,chgcode5,chgld5,chgamt5,chglndiscitem,baseprin,baseprinterm,iscurrfixamt,currfixamt,iscurrrate,currrate,currfactor,currbaseon,frequency,reqnumbarrear,minamtarrear,currdelay,inccurrnowork,ispduefixamt,pduefixamt,ispduerate,pduerate,pduefactor,pduebaseon,pduedelay,incpduenowork,maxtermdays,mintermdays,intdiscmode,discrate,advintmode,advintdays,advintcode,fixamortmode,amortcode,excessintpmntmode,intonexcessitem,allowableexcessindays,intonexcessoverallowance,fixchgamt2,rateonprin2,rateonprinterm2,chgrate2,fixchgamt3,rateonprin3,rateonprinterm3,chgrate3,fixchgamt4,rateonprin4,rateonprinterm4,chgrate4,fixchgamt5,rateonprin5,rateonprinterm5,chgrate5,microfinance,waived_pnltygrp,waived_pnltyitem,withamortinsurance,amortinsurancechgcode FROM `master`.`loanprod` where prodcode='" & txtCurrentCode.Text & "'" : com.ExecuteNonQuery()
        End If

        If CheckBox2.Checked = True Then
            If countRecord("action_query.prodgltemplatefilter") = 0 Then
                com.CommandText = "insert into action_query.prodgltemplatefilter select * from master.prodgltemplatefilter;" : com.ExecuteNonQuery()
            End If

            com.CommandText = "UPDATE master.prodgltemplatefilter SET loanproducts = replace(loanproducts, '|" & txtCurrentCode.Text & "|', '|" & txtNewCode.Text & "|');" : com.ExecuteNonQuery()
        End If
        MsgBox("Function successfully executed!", vbInformation)
        Me.Close()
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
End Class