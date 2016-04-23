Imports System.ComponentModel

Public Class SettingsManager
    Implements INotifyPropertyChanged

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Public Property SummonerName As String
        Set(value As String)
            My.Settings.summonerName2Watch = value
            raiseChangedEvent("SummonerName")
        End Set
        Get
            Return My.Settings.summonerName2Watch
        End Get
    End Property

    Public Property useAnimatedLoadingscreens As Boolean
        Set(value As Boolean)
            My.Settings.showAnimated = value
            raiseChangedEvent("useAnimatedLoadingscreens")
        End Set
        Get
            Return My.Settings.showAnimated
        End Get
    End Property

    Public Property useDefaultIfSkinHasNoVideo As Boolean
        Set(value As Boolean)
            My.Settings.showDefaultIfSkinHasNoVideo = value
            raiseChangedEvent("useDefaultIfSkinHasNoVideo")
        End Set
        Get
            Return My.Settings.showDefaultIfSkinHasNoVideo
        End Get
    End Property

    Public Property Region As Integer
        Set(value As Integer)
            My.Settings.selectedRegion = value
            raiseChangedEvent("Region")
        End Set
        Get
            Return My.Settings.selectedRegion
        End Get
    End Property



    Private Sub raiseChangedEvent(ByVal name As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(name))
    End Sub

End Class
