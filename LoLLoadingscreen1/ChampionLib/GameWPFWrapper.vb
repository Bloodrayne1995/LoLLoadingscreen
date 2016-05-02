Namespace Wrapper.WPF

    Public Class GameWPFWrapper

#Region "Internal"

        Private _game As Game

#End Region

#Region "Constructors"

        Public Sub New(g As Game)
            _game = g
        End Sub

#End Region

#Region "Properties"

#Region "BLUE-TEAM"

        Public ReadOnly Property BLUE_CHAMPION_1 As ChampionWPFWrapper
            Get
                Return New ChampionWPFWrapper(_game.TEAM_BLUE(0))
            End Get
        End Property

        Public ReadOnly Property BLUE_CHAMPION_2 As ChampionWPFWrapper
            Get
                Return New ChampionWPFWrapper(_game.TEAM_BLUE(1))
            End Get
        End Property

        Public ReadOnly Property BLUE_CHAMPION_3 As ChampionWPFWrapper
            Get
                Return New ChampionWPFWrapper(_game.TEAM_BLUE(2))
            End Get
        End Property

        Public ReadOnly Property BLUE_CHAMPION_4 As ChampionWPFWrapper
            Get
                Return New ChampionWPFWrapper(_game.TEAM_BLUE(3))
            End Get
        End Property

        Public ReadOnly Property BLUE_CHAMPION_5 As ChampionWPFWrapper
            Get
                Return New ChampionWPFWrapper(_game.TEAM_BLUE(4))
            End Get
        End Property

        Public ReadOnly Property BLUE_CHAMPION_6 As ChampionWPFWrapper
            Get
                Return New ChampionWPFWrapper(_game.TEAM_BLUE(5))
            End Get
        End Property

#End Region

#Region "RED-TEAM"

        Public ReadOnly Property RED_CHAMPION_1 As ChampionWPFWrapper
            Get
                Return New ChampionWPFWrapper(_game.TEAM_RED(0))
            End Get
        End Property

        Public ReadOnly Property RED_CHAMPION_2 As ChampionWPFWrapper
            Get
                Return New ChampionWPFWrapper(_game.TEAM_RED(1))
            End Get
        End Property

        Public ReadOnly Property RED_CHAMPION_3 As ChampionWPFWrapper
            Get
                Return New ChampionWPFWrapper(_game.TEAM_RED(2))
            End Get
        End Property

        Public ReadOnly Property RED_CHAMPION_4 As ChampionWPFWrapper
            Get
                Return New ChampionWPFWrapper(_game.TEAM_RED(3))
            End Get
        End Property

        Public ReadOnly Property RED_CHAMPION_5 As ChampionWPFWrapper
            Get
                Return New ChampionWPFWrapper(_game.TEAM_RED(4))
            End Get
        End Property

        Public ReadOnly Property RED_CHAMPION_6 As ChampionWPFWrapper
            Get
                Return New ChampionWPFWrapper(_game.TEAM_RED(5))
            End Get
        End Property

#End Region

#Region "BLUE-BANNED"

        Public ReadOnly Property BLUE_BANNED_1 As BannedChampionWPFWrapper
            Get
                Return New BannedChampionWPFWrapper(_game.BANNED_BLUE(0))
            End Get
        End Property

        Public ReadOnly Property BLUE_BANNED_2 As BannedChampionWPFWrapper
            Get
                Return New BannedChampionWPFWrapper(_game.BANNED_BLUE(1))
            End Get
        End Property

        Public ReadOnly Property BLUE_BANNED_3 As BannedChampionWPFWrapper
            Get
                Return New BannedChampionWPFWrapper(_game.BANNED_BLUE(2))
            End Get
        End Property

#End Region

#Region "RED-BANNED"

        Public ReadOnly Property RED_BANNED_1 As BannedChampionWPFWrapper
            Get
                Return New BannedChampionWPFWrapper(_game.BANNED_RED(0))
            End Get
        End Property

        Public ReadOnly Property RED_BANNED_2 As BannedChampionWPFWrapper
            Get
                Return New BannedChampionWPFWrapper(_game.BANNED_RED(1))
            End Get
        End Property

        Public ReadOnly Property RED_BANNED_3 As BannedChampionWPFWrapper
            Get
                Return New BannedChampionWPFWrapper(_game.BANNED_RED(2))
            End Get
        End Property

#End Region


#End Region



    End Class


End Namespace


