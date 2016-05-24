Public Class Singleton

    Private Shared _Instance As Singleton = Nothing

    Private Sub New()
        UIGebruikersInstellingen = New GebruikersInstellingen
    End Sub

    Public Shared ReadOnly Property Instance As Singleton
        Get
            If (_Instance Is Nothing) Then
                _Instance = New Singleton()
            End If

            Return _Instance
        End Get
    End Property

    Public UIGebruikersInstellingen As GebruikersInstellingen

    ''' <summary>
    ''' Controleert en onthoud of de gebruiker administrator is
    ''' </summary>
    Public Function IsAdminPaswoordCorrect(ByVal Paswoord As String) As Boolean
        UIGebruikersInstellingen.IsGebruikerAdmin = Paswoord.Equals(ApplicatieInstellingen.GlobaalPaswoord)
        Return UIGebruikersInstellingen.IsGebruikerAdmin
    End Function
End Class