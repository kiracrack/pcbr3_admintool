Imports System.Globalization

Public Class frmNewAccount
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmUnblockClearLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadBranch()
        loadTemplate()
        LoadToComboBox("SELECT * FROM `master`.`userinfo` order by username asc;", "username", "userid", txtClient)
    End Sub

    Public Sub loadBranch()
        LoadToComboBox("select * from master.branches order by branchname asc", "branchname", "branchcode", txtBranch)
    End Sub
    Public Sub loadTemplate()
        LoadToComboBoxPre("SELECT * FROM `action_query`.`tblaccesstemplate` order by templatename asc;", "templatename", "id", txtUserAccess)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtUserID.Text = "" Then
            MsgBox("Please enter Account id", vbExclamation)
            txtUserID.Focus()
            Exit Sub
        ElseIf txtUsername.Text = "" Then
            MsgBox("Please Enter Username", vbExclamation)
            txtUsername.Focus()
            Exit Sub
        ElseIf txtUsername.Text.Contains(" ") = True Then
            MsgBox("Please enter username without space character", vbExclamation)
            txtUsername.Focus()
            Exit Sub

        ElseIf txtpassword.Text = "" Or txtpassword.Text = "Password" Then
            MsgBox("Please enter password ", vbExclamation)
            txtpassword.Focus()
            Exit Sub

        ElseIf txtpassword.Text.Contains(" ") = True Then
            MsgBox("Please enter password without space character", vbExclamation)
            txtpassword.Focus()
            Exit Sub

        ElseIf txtpassword.Text.Length < 4 Then
            MsgBox("Please enter password atleast 4 character lenght", vbExclamation)
            txtpassword.Focus()
            Exit Sub

        ElseIf txtpassword.Text <> txtverify.Text Then
            MsgBox("Password did not match", vbExclamation)
            txtpassword.Focus()
            Exit Sub

        ElseIf txtBranch.Text = "" Then
            MsgBox("Please Please Select Branch", vbExclamation)
            txtBranch.Focus()
            Exit Sub

        ElseIf txtUserAccess.Text = "" Then
            MsgBox("Please enter user access template", vbExclamation)
            txtUserAccess.Focus()
            Exit Sub
        ElseIf userid.Text = "" Then
            MsgBox("Please enter authorized user id", vbExclamation)
            userid.Focus()
            Exit Sub
        ElseIf countqry("master.userinfo", "userid='" & txtUserID.Text & "'") > 0 Then
            MsgBox("User ID already exists!", vbExclamation)
            txtUserID.Focus()
            Exit Sub
        ElseIf countqry("master.userinfo", "username='" & txtUsername.Text & "'") > 0 Then
            MsgBox("Username already exists!", vbExclamation)
            txtUsername.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            Dim useraccess As String = "" : Dim suploans As String = "" : Dim protemplate As String = "" : Dim deposit As String = ""
            com.CommandText = "select * from action_query.tblaccesstemplate where id='" & DirectCast(txtUserAccess.SelectedItem, ComboBoxItem).HiddenValue() & "'" : rst = com.ExecuteReader
            While rst.Read
                useraccess = rst("useraccess").ToString
                suploans = rst("supervisoryloans").ToString
                protemplate = rst("productemplate").ToString
                deposit = rst("depositoverride").ToString
            End While
            rst.Close()

            com.CommandText = "INSERT INTO `master`.`userinfo` set  " _
                             + " userid='" & txtUserID.Text & "', " _
                             + " username='" & txtUsername.Text & "', " _
                             + " login_locked='0', " _
                             + " login_locked_time='', " _
                             + " access_template='" & useraccess & "', " _
                             + " approval_template='" & suploans & "', " _
                             + " filter_template='" & protemplate & "', " _
                             + " override_template='" & deposit & "', " _
                             + " accesscode=password(concat('" & txtverify.Text & "','" & txtUserID.Text & "')), " _
                             + " menu_1='', " _
                             + " menu_2='', " _
                             + " menu_3='', " _
                             + " menu_4='', " _
                             + " usertype='2', " _
                             + " branchcode='" & DirectCast(txtBranch.SelectedItem, ComboBoxItem).HiddenValue() & "', " _
                             + " cashbeginning='0.00', " _
                             + " select_priv='N', " _
                             + " insert_priv='N', " _
                             + " update_priv='N', " _
                             + " delete_priv='N', " _
                             + " login='N', " _
                             + " block='0', " _
                             + " blockdesc='', " _
                             + " blockedby='', " _
                             + " blocklevel='', " _
                             + " clearingofficer='0', " _
                             + " approvingofficer='0', " _
                             + " excesscreditline='0', " _
                             + " delinquentamount='0', " _
                             + " dayspastdue='0', " _
                             + " difftermindays='0', " _
                             + " discinterest='0', " _
                             + " intrbrclearing='0', " _
                             + " intrbrapproving='0', " _
                             + " recby='" & userid.Text & "', " _
                             + " recdate=current_date, " _
                             + " timerec=current_time, " _
                             + " chgby='', " _
                             + " chgdate='1900-01-01', " _
                             + " timechg='', " _
                             + " transactiondate=current_date, " _
                             + " cashbeg='0', " _
                             + " cashin='0', " _
                             + " cashout='0', " _
                             + " cashoverage='0', " _
                             + " cashshortage='0', " _
                             + " cashend='0', " _
                             + " cashbreakdown='', " _
                             + " verifiedcash='0', " _
                             + " verifiedby='', " _
                             + " dateverified='1900-01-01', " _
                             + " timeverified='', " _
                             + " requestverification='0', " _
                             + " requestdate='1900-01-01', " _
                             + " requesttime='';" : com.ExecuteNonQuery()

            com.CommandText = "INSERT into action_query.tbltechnicalreport set branchname='" & StrConv(txtBranch.Text, vbProperCase) & "', requestorname='" & txtClient.Text & "', concern='Added " & Me.Text & Chr(13) & " User ID: " & txtUserID.Text & Chr(13) & " Username: " & txtUsername.Text & "', actiontaken='User Account',severitylvl='Critical', performedby='" & GlobalFullname & "', datetrn=current_timestamp" : com.ExecuteNonQuery()
            txtUserID.Text = "" : txtUsername.Text = "" : txtUserID.Focus()
            MsgBox("Account successfully Activated!", MsgBoxStyle.Information)
        End If

    End Sub

 
End Class
