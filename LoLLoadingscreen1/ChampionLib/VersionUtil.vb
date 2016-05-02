Public Class VersionUtil

#Region "Singleton-Pattern"

    Private Shared _instance As VersionUtil

    Public Shared Function getInstance() As VersionUtil
        If IsNothing(_instance) Then
            _instance = New VersionUtil
        End If

        Return _instance
    End Function

    Private Sub New()

    End Sub

#End Region

#Region "internal"

    Private _version As String = "6.8.1"

#End Region


#Region "Properties"

    Public Property Version As String
        Get
            Return _version
        End Get
        Set(value As String)
            _version = value

        End Set
    End Property

#End Region


End Class
