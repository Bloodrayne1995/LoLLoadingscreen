Imports RiotApi.Net.RestClient.Dto.LolStaticData.Champion

Public Class BannedChampion

#Region "Internal"

    Private _turn As Integer = 0
    Private _championData As ChampionDto = Nothing

#End Region

#Region "Properties"

    Public ReadOnly Property Turn As Integer
        Get
            Return _turn
        End Get
    End Property

    Public ReadOnly Property ChampionData As ChampionDto
        Get
            Return _championData
        End Get
    End Property

    Public ReadOnly Property SquareImageUrl As String
        Get
            Return "http://ddragon.leagueoflegends.com/cdn/" & VersionUtil.getInstance.Version & "/img/champion/" & ChampionData.Key & ".png"
        End Get
    End Property

#End Region

#Region "Constructors"

    Public Sub New(pickTurn As Integer, ch As ChampionDto)
        _turn = pickTurn
        _championData = ch

    End Sub

#End Region


End Class
