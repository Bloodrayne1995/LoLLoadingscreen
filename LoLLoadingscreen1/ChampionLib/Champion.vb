Imports RiotApi.Net.RestClient.Dto.LolStaticData.Champion

Public Class Champion

#Region "Internal"

    Private _playerName As String = ""

    '200 = red
    '100 = blue
    Private _teamSide As Integer = 0

    Private _spell1 As String = ""
    Private _spell2 As String = ""

    Private _championData As ChampionDto



#End Region

#Region "Properties"

    Public ReadOnly Property PlayerName As String
        Get
            Return _playerName
        End Get
    End Property


    Public ReadOnly Property teamSide As Integer
        Get
            Return _teamSide
        End Get
    End Property

    Public ReadOnly Property spell1 As String
        Get
            Return "http://ddragon.leagueoflegends.com/cdn/" & VersionUtil.getInstance.Version & "/img/spell/" & _spell1 & ".png"
        End Get
    End Property

    Public ReadOnly Property spell2 As String
        Get
            Return "http://ddragon.leagueoflegends.com/cdn/" & VersionUtil.getInstance.Version & "/img/spell/" & _spell2 & ".png"
        End Get
    End Property

    Public ReadOnly Property ChampionData As ChampionDto
        Get
            Return _championData
        End Get
    End Property

    Public ReadOnly Property SquareImage As String
        Get
            Return "http://ddragon.leagueoflegends.com/cdn/" & VersionUtil.getInstance.Version & "/img/champion/" & ChampionData.Key & ".png"
        End Get
    End Property


#End Region

#Region "Constructor"

    Public Sub New(name As String, spell1Key As String, spell2Key As String, team As Integer, champion As ChampionDto)
        _playerName = name
        _spell1 = spell1Key
        _spell2 = spell2Key
        _teamSide = team
        _championData = champion
    End Sub

#End Region


End Class
