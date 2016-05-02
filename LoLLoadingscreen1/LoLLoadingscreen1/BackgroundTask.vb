Imports ProgramChecker
Public Class BackgroundTask


    Private WithEvents _pChecker As New ProcessWatcher


    Public Sub New()
        _pChecker.ProcessName = "League of Legends"
    End Sub


    Public Sub startBT()
        _pChecker.startWatching()
    End Sub


    Public Sub stopBT()
        _pChecker.stopWatching()
    End Sub


    Private Sub gameStarted() Handles _pChecker.ProcessStarted
        MsgBox("Game Started")
    End Sub







End Class
