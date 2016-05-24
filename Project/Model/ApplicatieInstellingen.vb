Public Class ApplicatieInstellingen
    ''' <summary>
    ''' Pad waar de user zijn application paramaters staan.
    ''' Dit komt in de AppData folder terecht voor elke ingelogde gebruiker per pc.
    ''' </summary>
    Public Shared ReadOnly ConfiguratieInstellingenPad As String = Application.UserAppDataPath & "\config.txt"

    ''' <summary>
    ''' Opslag van beheerderspaswoord om instellingen te wijzigen
    ''' </summary>
    Public Shared ReadOnly GlobaalPaswoord As String = "boss"

    ''' <summary>
    ''' De huidige docman versie
    ''' </summary>
    ''' <remarks>Verander dit bij elke update die je doet</remarks>
    Public Shared DocmanVersie As String = "08-04-2016"

    ''' <summary>
    ''' Een link naar het bestand, dat publiekelijk beschikbaar is, met de patch notes voor deze versie
    ''' </summary>
    ''' <remarks>Verander dit bij elke update die je doet</remarks>
    Public Shared ReadOnly DocmanPatchNotesPad As String = "\\file-srv\Public\Document Manager\Docman Patch Notes 04-08-2016.docx"
End Class
