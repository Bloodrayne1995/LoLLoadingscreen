Imports System.IO
Imports System.Net
Imports System.Windows.Media.Imaging

Namespace Wrapper.WPF

    Public Class BannedChampionWPFWrapper

#Region "Internal"

        Private _bannedChampion As BannedChampion

#End Region

#Region "Constructors"

        Public Sub New(ByRef b As BannedChampion)
            _bannedChampion = b
        End Sub

#End Region

#Region "Properties"

        Public ReadOnly Property BannedChampionSquareImage As BitmapImage
            Get
                Dim web As New WebClient
                Dim data() As Byte = web.DownloadData(_bannedChampion.SquareImageUrl)
                Dim ms As New MemoryStream(data)

                Dim img As New BitmapImage
                img.BeginInit()
                img.CreateOptions = BitmapCreateOptions.PreservePixelFormat
                img.CacheOption = BitmapCacheOption.OnDemand
                img.StreamSource = ms
                img.EndInit()

                Return img
            End Get
        End Property

        Public ReadOnly Property Turn As Integer
            Get
                Return _bannedChampion.Turn
            End Get
        End Property

        Public ReadOnly Property ChampionName As String
            Get
                Return _bannedChampion.ChampionData.Name
            End Get
        End Property



#End Region


    End Class

End Namespace
