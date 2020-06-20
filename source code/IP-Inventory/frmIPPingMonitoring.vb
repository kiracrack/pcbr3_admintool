Imports System.Net.NetworkInformation
Imports System.ComponentModel
Imports System.Threading

Public Class frmIPPingMonitoring
    Delegate Sub SetTextCallback([text] As String)
    Private bw As BackgroundWorker = New BackgroundWorker

    Public Sub New()
        InitializeComponent()
        bw.WorkerReportsProgress = True
        bw.WorkerSupportsCancellation = True
        AddHandler bw.DoWork, AddressOf bw_DoWork
        AddHandler bw.RunWorkerCompleted, AddressOf bw_RunWorkerCompleted

    End Sub

    Private Sub bw_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs)
        Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)
        If bw.CancellationPending = True Then
            e.Cancel = True
        Else
            'If Not bw.IsBusy = True 
            'System.Threading.Thread.Sleep(1000)

            For i = 0 To 10000000000
                ThreadProcSafe(i)
            Next



        End If
    End Sub
    Private Sub bw_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs)
        If e.Cancelled = True Then
            'Me.tbProgress.Text = "Canceled!"
        ElseIf e.Error IsNot Nothing Then
            ' Me.tbProgress.Text = "Error: " & e.Error.Message
        Else
            ' Me.tbProgress.Text = "Done!"
        End If
    End Sub


    Private Sub frmIPPingMonitoring_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      
        ListView1.View = View.Details
        ListView1.Columns.Add("Office", -2, HorizontalAlignment.Left)
        ListView1.Columns.Add("IP Address", -2, HorizontalAlignment.Left)
        ListView1.Columns.Add("Status", -2, HorizontalAlignment.Left)
        ListView1.Columns.Add("Ping Rate", -2, HorizontalAlignment.Left)
        ListView1.Columns(0).Width = 280
        ListView1.Columns(1).Width = 280
        ListView1.Columns(2).Width = 100
        ListView1.Columns(3).Width = 150
        ShowIPAddress()
        If Not bw.IsBusy = True Then
            bw.RunWorkerAsync()
        End If

    End Sub

    Public Sub ShowIPAddress()
        ListView1.Items.Clear()
        com.CommandText = "SELECT *,concat(ip1,'.',ip2,'.',ip3,'.',ip4) as 'ip' FROM `action_query`.`tblipinventory`;" : rst = com.ExecuteReader
        While rst.Read
            Dim item1 As New ListViewItem(rst("officename").ToString, 0)
            item1.SubItems.Add(rst("ip").ToString)
            item1.SubItems.Add("")
            item1.SubItems.Add("")
            ListView1.Items.AddRange(New ListViewItem() {item1})
        End While
        rst.Close()
    End Sub

    Private Sub ThreadProcSafe(ByVal txt As Integer)
        Me.SetText(txt)
    End Sub

    Private Sub SetText(ByVal [text] As String)
        If Me.TextBox1.InvokeRequired Then
            Dim d As New SetTextCallback(AddressOf SetText)
            Me.Invoke(d, New Object() {[text]})
        Else
            Me.TextBox1.Text = [text]
        End If
    End Sub


    'Private Sub thrd()
    '    If ListView1.InvokeRequired Then
    '        ListView1.BeginInvoke(New MethodInvoker(AddressOf thrd))
    '    Else
    '        For Each itm As ListViewItem In ListView1.Items
    '            Dim pingreq As Ping = New Ping() : Dim rep As PingReply
    '            Me.Invoke(Sub() rep = pingreq.Send(itm.SubItems(1).Text))
    '            If rep.RoundtripTime > 0 Then
    '                If rep.RoundtripTime > 300 Then
    '                    itm.SubItems(2).Text = "SLOW"
    '                    itm.SubItems(3).Text = rep.RoundtripTime
    '                Else
    '                    itm.SubItems(2).Text = "UP"
    '                    itm.SubItems(3).Text = rep.RoundtripTime
    '                End If
    '            Else
    '                itm.SubItems(2).Text = "Down"
    '                itm.SubItems(3).Text = "Connection timeout.."
    '            End If
    '            DirectCast(pingreq, IDisposable).Dispose()
    '        Next
    '    End If
    'End Sub

    'Private Sub pingem(p As Object)
    '    Dim pobj As frmIPPingMonitoring = DirectCast(p, frmIPPingMonitoring)
    '    Dim MyPing As New System.Net.NetworkInformation.Ping
    '    Do
    '        Dim Myreply As System.Net.NetworkInformation.PingReply = MyPing.Send(pobj.addr)
    '        For Each itm As ListViewItem In ListView1.Items
    '            Dim pingreq As Ping = New Ping()
    '            Dim rep As PingReply = pingreq.Send(itm.SubItems(1).Text)
    '            If rep.RoundtripTime > 0 Then
    '                If rep.RoundtripTime > 300 Then
    '                    Me.Invoke(Sub() itm.SubItems(2).Text = "SLOW")
    '                    Me.Invoke(Sub() itm.SubItems(3).Text = rep.RoundtripTime)
    '                Else
    '                    itm.SubItems(2).Text = "UP"
    '                    itm.SubItems(3).Text = rep.RoundtripTime
    '                End If
    '            Else
    '                itm.SubItems(2).Text = "Down"
    '                itm.SubItems(3).Text = "Connection timeout.."
    '            End If
    '            DirectCast(pingreq, IDisposable).Dispose()
    '        Next


    '            Threading.Thread.Sleep(1000)
    '    Loop

    'End Sub

    'Public Sub PingIpAddress()
    '    For Each itm As ListViewItem In ListView1.Items
    '        Dim pingreq As Ping = New Ping()
    '        Dim rep As PingReply = pingreq.Send(itm.SubItems(1).Text)
    '        If My.Computer.Network.Ping(itm.SubItems(1).Text) = True Then
    '            If rep.RoundtripTime > 300 Then
    '                itm.SubItems(2).Text = "SLOW"
    '                itm.SubItems(3).Text = rep.RoundtripTime
    '            Else
    '                itm.SubItems(2).Text = "UP"
    '                itm.SubItems(3).Text = rep.RoundtripTime
    '            End If
    '        Else
    '            itm.SubItems(2).Text = "Down"
    '            itm.SubItems(3).Text = "Connection timeout.."
    '        End If
    '    Next
    'End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'If Not bw.IsBusy = True Then
        '    bw.RunWorkerAsync()
        'End If

    End Sub
End Class