''' <summary>
''' UI Instellingen van de gebruiker, momenteel beheerd in Form Main
''' </summary>
''' <remarks></remarks>
Public Class GebruikersInstellingen

    Private _IsGebruikerAdmin As Boolean = False
    Public Property IsGebruikerAdmin As Boolean
        Get
            Return _IsGebruikerAdmin
        End Get
        Set(ByVal value As Boolean)
            _IsGebruikerAdmin = value
        End Set
    End Property

    Private _Opslagplaats As String
    ''' <summary>
    ''' De opslagplaats
    ''' </summary>
    Public Property Opslagplaats() As String
        Get
            Return _Opslagplaats
        End Get
        Set(ByVal value As String)
            _Opslagplaats = value
        End Set
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


End Class
