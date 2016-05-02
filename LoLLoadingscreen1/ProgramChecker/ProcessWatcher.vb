Imports System.Threading
Imports System.Diagnostics


Public Class ProcessWatcher


#Region "Events"

    Public Event ProcessStarted()

    Public Event ProcessStopped()

#End Region

#Region "Internal"

    Private _processName As String = ""
    Private _listProcess As New List(Of Process)
    Private _stopWatch As Boolean = False

#End Region

#Region "Properties"

    Public Property ProcessName As String
        Set(value As String)
            _processName = value
        End Set
        Get
            Return _processName
        End Get
    End Property

#End Region


#Region "Methoden"

    Public Sub stopWatching()
        _stopWatch = True
    End Sub

    Private Function getProcesses() As List(Of Process)
        Dim pl() As Process = Process.GetProcessesByName(ProcessName)
        Dim l As New List(Of Process)
        For Each p As Process In pl
            l.Add(p)
        Next
        Return l
    End Function

    Private Sub watch()
        While Not _stopWatch
            Dim li As List(Of Process) = getProcesses()
            If li.Count > _listProcess.Count Then
                RaiseEvent ProcessStarted()
            ElseIf li.Count < _listProcess.Count
                RaiseEvent ProcessStopped()
            End If
            _listProcess = li
            Thread.Sleep(200)

        End While
    End Sub

    Public Sub startWatching()
        Dim t As New Thread(AddressOf watch)
        t.Name = "ProcessWatcher - Name: " & ProcessName
        _stopWatch = False
        t.Start()
    End Sub

#End Region






End Class
