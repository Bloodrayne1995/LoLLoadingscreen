Imports ProgramChecker

Public Class TestProcessWatcher

    Private WithEvents pWatch As New ProcessWatcher

    Public Sub test()
        pWatch.ProcessName = "League Of Legends"
        pWatch.startWatching()
    End Sub


    Public Sub stopIt()
        pWatch.stopWatching()
    End Sub

    Private Sub handlePRCStarted() Handles pWatch.ProcessStarted
        MsgBox("Prozess gestartet")
    End Sub

    Private Sub handlePRCStopped() Handles pWatch.ProcessStopped
        MsgBox("Prozess gestoppt")
    End Sub

End Class
