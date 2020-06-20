Imports System.Security.AccessControl
Imports System.IO

Public Class DirReader

    

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        'Dim dinfo As New DirectoryInfo("DirectoryList.txt")
        'MessageBox.Show(dinfo.GetAccessControl.ToString)
        RichTextBox1.Text = ""
        Dim fi As New FileInfo(txtrefcode.Text)
        Dim fs As New FileSecurity
        Dim obTypeToGet As Type

        ' Get ACL object on the selected file or folder.  
        fs = fi.GetAccessControl()
        obTypeToGet = Type.GetType("System.Security.Principal.NTAccount")

        Dim PaddingValue As Integer = 10
        ' Get each ACL.  
        For Each ace As FileSystemAccessRule In fs.GetAccessRules(True, True, obTypeToGet)
            ' Print the name of the ACL owner.  
            '  StringArray.Add(ace.IdentityReference.Value)

            Dim ACL_Type As String = ""
            ' Determine if this ACL is an Allow or Deny type.  
            If ace.AccessControlType.Equals(Security.AccessControl.AccessControlType.Deny) Then
                ACL_Type = "Deny"
            Else
                ACL_Type = "Allow"
            End If

            ' Enumerate all the individual ACLs which make up the main ACL.  
            Dim ACL_PermissionFC As String = ""
            If (ace.FileSystemRights And FileSystemRights.FullControl) = FileSystemRights.FullControl Then _
                ACL_PermissionFC = "Has full control"

            Dim ACL_PermissionM As String = ""
            If (ace.FileSystemRights And FileSystemRights.Modify) = FileSystemRights.Modify Then _
                ACL_PermissionM = "Has Modify security"

            Dim ACL_PermissionRE As String = ""
            If (ace.FileSystemRights And FileSystemRights.ReadAndExecute) = FileSystemRights.ReadAndExecute Then _
                ACL_PermissionRE = "Has Read & Execute security"

            Dim ACL_PermissionLD As String = ""
            If (ace.FileSystemRights And FileSystemRights.ListDirectory) = FileSystemRights.ListDirectory Then _
                ACL_PermissionLD = "Has List Folder Contents security"

            Dim ACL_PermissionR As String = ""
            If (ace.FileSystemRights And FileSystemRights.Read) = FileSystemRights.Read Then _
                ACL_PermissionR = "Has Read security"

            Dim ACL_PermissionW As String = ""
            If (ace.FileSystemRights And FileSystemRights.Write) = FileSystemRights.Write Then _
                ACL_PermissionW = "Has Write security"

            ' Display the results.  
            If ACL_PermissionFC.Length > 0 Then RichTextBox1.Text += ACL_PermissionFC.PadLeft(PaddingValue) & " [" & ACL_Type & "]" + Environment.NewLine
            If ACL_PermissionM.Length > 0 Then RichTextBox1.Text += ACL_PermissionM.PadLeft(PaddingValue) & " [" & ACL_Type & "]" + Environment.NewLine
            If ACL_PermissionRE.Length > 0 Then RichTextBox1.Text += ACL_PermissionRE.PadLeft(PaddingValue) & " [" & ACL_Type & "]" + Environment.NewLine
            If ACL_PermissionLD.Length > 0 Then RichTextBox1.Text += ACL_PermissionLD.PadLeft(PaddingValue) & " [" & ACL_Type & "]" + Environment.NewLine
            If ACL_PermissionR.Length > 0 Then RichTextBox1.Text += ACL_PermissionR.PadLeft(PaddingValue) & " [" & ACL_Type & "]" + Environment.NewLine
            ' If ACL_PermissionW.Length > 0 Then StringArray.Add(ACL_PermissionW.PadLeft(PaddingValue) & " [" & ACL_Type & "]")
        Next
    End Sub
End Class
