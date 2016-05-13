Public Class Singleton

    Private Shared _Instance As Singleton = Nothing

    Private Sub New()

    End Sub

    Public Shared ReadOnly Property Instance As Singleton
        Get
            If (_Instance Is Nothing) Then
                _Instance = New Singleton()
            End If

            Return _Instance
        End Get
    End Property

    Private _Auteur As Auteur
    ''' <summary>
    ''' De auteur voluit geschreven
    ''' </summary>
    Public Property Auteur() As Auteur
        Get
            Return _Auteur
        End Get
        Set(ByVal value As Auteur)
            _Auteur = value
        End Set
    End Property

    ''' <summary>
    ''' Pad waar de user zijn application paramaters staan.
    ''' </summary>
    Public ReadOnly ConfiguratiePad As String = Application.UserAppDataPath & "\config.txt"

    ''' <summary>
    ''' Opslag van beheerderspaswoord om instellingen te wijzigen
    ''' </summary>
    Public ReadOnly GlobaalPaswoord As String = "boss"
End Class