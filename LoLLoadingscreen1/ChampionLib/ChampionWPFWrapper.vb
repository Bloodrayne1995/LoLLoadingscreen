Imports System.Windows.Media
Imports System.IO
Imports System.Windows.Media.Imaging
Imports System.Net

Namespace Wrapper.WPF

    Public Class ChampionWPFWrapper

        Private _champion As Champion

        Public Sub New(ByRef c As Champion)
            _champion = c
        End Sub

        Public ReadOnly Property ChampionName As String
            Get
                Return _champion.ChampionData.Name
            End Get
        End Property

        Public ReadOnly Property ChampionSquareImage As BitmapImage
            Get
                Dim web As New WebClient
                Dim data() As Byte = web.DownloadData(_champion.SquareImage)
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

        'TODO: Loading Art definieren


    End Class


End Namespace
