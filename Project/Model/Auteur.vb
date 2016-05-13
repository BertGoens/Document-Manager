Public Class Auteur

    Private _MagAllesZien As Boolean
    ''' <summary>
    ''' Mag de auteur documenten van andere auteurs zoeken
    ''' </summary>
    Public Property MagAllesZien() As Boolean
        Get
            Return _MagAllesZien
        End Get
        Private Set(ByVal value As Boolean)
            _MagAllesZien = value
        End Set
    End Property

    Private _AuteurLang As String
    ''' <summary>
    ''' De auteur voluit geschreven
    ''' </summary>
    Public Property AuteurLang() As String
        Get
            Return _AuteurLang
        End Get
        Private Set(ByVal value As String)
            _AuteurLang = value
        End Set
    End Property

    Private _AuteurKort As String
    ''' <summary>
    ''' De initialen van de auteur
    ''' </summary>
    Public Property AuteurKort() As String
        Get
            Return _AuteurKort
        End Get
        Private Set(ByVal value As String)
            _AuteurKort = value
        End Set
    End Property

    Public Sub New(ByVal AuteurLang As String, ByVal AuteurKort As String, ByVal MagAllesZien As Boolean)
        Me.AuteurLang = AuteurLang
        Me.AuteurKort = AuteurKort
        Me.MagAllesZien = MagAllesZien
    End Sub
End Class
