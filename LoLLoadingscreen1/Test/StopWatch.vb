Imports System.Threading
Public Class StopWatch

    Private _seconds As Long = 0
    Private _stopFlag As Boolean = False

    Public Sub startWatch()
        Dim x As New Thread(AddressOf tick)
        _stopFlag = False
        x.Start()
    End Sub

    Public Sub stopWatch()
        _stopFlag = True
    End Sub


    Private Sub tick()
        While Not _stopFlag
            Thread.Sleep(1000)
            _seconds += 1
        End While
    End Sub

    Public Overrides Function toString() As String
        Return _seconds
    End Function

End Class
