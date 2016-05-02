Imports RiotApi.Net.RestClient
Imports RiotApi.Net.RestClient.Dto.CurrentGame
Imports RiotApi.Net.RestClient.Dto.CurrentGame.CurrentGameInfo
Imports RiotApi.Net.RestClient.Dto.LolStaticData
Imports RiotApi.Net.RestClient.Dto.LolStaticData.Champion

Public Class Game

#Region "Internal"

    Private _teamBlue As New List(Of Champion)
    Private _bannedBlue As New List(Of BannedChampion)

    Private _teamRed As New List(Of Champion)
    Private _bannedRed As New List(Of BannedChampion)

    Private _gameMode As String = ""
    Private _gameQueue As Long = 0

#End Region

#Region "Properties"

    Public ReadOnly Property TEAM_BLUE As List(Of Champion)
        Get
            Return _teamBlue
        End Get
    End Property

    Public ReadOnly Property BANNED_BLUE As List(Of BannedChampion)
        Get
            Return _bannedBlue
        End Get
    End Property

    Public ReadOnly Property TEAM_RED As List(Of Champion)
        Get
            Return _teamRed
        End Get
    End Property

    Public ReadOnly Property BANNED_RED As List(Of BannedChampion)
        Get
            Return _bannedRed
        End Get
    End Property

    Public ReadOnly Property GAME_MODE As String
        Get
            Return _gameMode
        End Get
    End Property

    Public ReadOnly Property GAME_QUEUE As Long
        Get
            Return _gameQueue
        End Get
    End Property

#End Region

#Region "Enumerations"

    Public Enum QueueMode As Long
        CUSTOM = 0
        NORMAL_3x3 = 8
        NORMAL_5x5_BLIND = 2
        NORMAL_5x5_DRAFT = 14
        RANKED_SOLO_5x5 = 4
        RANKED_PREMADE_5x5 = 6
        RANKED_PREMADE_3x3 = 9
        RANKED_TEAM_3x3 = 41
        RANKED_TEAM_5x5 = 42
        ODIN_5x5_BLIND = 16
        ODIN_5x5_DRAFT = 17
        BOT_5x5 = 7
        BOT_ODIN_5x5 = 25
        BOT_5x5_INTRO = 31
        BOT_5x5_BEGINNER = 32
        BOT_5x5_INTERMEDIATE = 33
        BOT_TT_3x3 = 52
        GROUP_FINDER_5x5 = 61
        ARAM_5x5 = 65
        ONEFORALL_5x5 = 70
        FIRSTBLOOD_1x1 = 72
        FIRSTBLOOD_2x2 = 73
        SR_6x6 = 75
        URF_5x5 = 76
        BOT_URF_5x5 = 83
        NIGHTMARE_BOT_5x5_RANK1 = 91
        NIGHTMARE_BOT_5x5_RANK2 = 92
        NIGHTMARE_BOT_5x5_RANK5 = 93
        ASCENSION_5x5 = 96
        HEXAKILL = 98
        BILGEWATER_ARAM_5x5 = 100
        KING_PORO_5x5 = 300
        COUNTER_PICK = 310
        BILGEWATER_5x5 = 313
        TEAM_BUILDER_DRAFT_UNRANKED_5x5 = 400
        TEAM_BUILDER_DRAFT_RANKED_5x5 = 410
    End Enum

#End Region

#Region "Methods"

    Public Sub findGame(summonerID As Long, apiKey As String)
        Dim cl As New RiotClient(apiKey)


        Dim info As CurrentGameInfo = cl.CurrentGame.GetCurrentGameInformationForSummonerId(Configuration.RiotApiConfig.Platforms.EUW1, summonerID)
        'game_typ festlegen
        _gameMode = info.GameMode.ToString
        _gameQueue = info.GameQueueConfigId

        'Teilnehmer durchgehen
        For Each p As CurrentGameParticipant In info.Participants
            Dim c As New Champion(p.SummonerName, getSummonerSpellKey(cl, p.Spell1Id), getSummonerSpellKey(cl, p.Spell2Id), p.TeamId, getChampionById(cl, p.ChampionId))
            If c.teamSide = 100 Then
                TEAM_BLUE.Add(c)
            Else
                TEAM_RED.Add(c)
            End If
        Next

        'Banns durchgehen
        For Each b As CurrentGameInfo.BannedChampion In info.BannedChampions
            Dim b1 As New BannedChampion(b.PickTurn, getChampionById(cl, b.ChampionId))
            If b.TeamId = 100 Then
                BANNED_BLUE.Add(b1)
            Else
                BANNED_RED.Add(b1)
            End If
        Next

    End Sub

#Region "Utils"

    Private Function getSummonerSpellKey(ByRef c As RiotClient, ByVal id As Integer) As String
        Return c.LolStaticData.GetSummonerSpellById(Configuration.RiotApiConfig.Regions.EUW, id, Nothing, Nothing, "key").Key
    End Function

    Private Function getChampionById(ByRef c As RiotClient, ByVal id As Integer) As ChampionDto
        Return c.LolStaticData.GetChampionById(Configuration.RiotApiConfig.Regions.EUW, id, Nothing, Nothing, "all")
    End Function



#End Region

#End Region






End Class
