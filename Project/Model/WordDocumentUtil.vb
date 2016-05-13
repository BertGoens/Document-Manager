Public Class WordDocumentUtil

    Public Shared Function GetDocumentNaam(ByVal SjabloonCode As String, ByVal Datum As Date, _
            ByVal Volgnummer As Long, ByVal AuteurKort As String, ByVal Titel As String, ByVal Extensie As String) As String
        Dim DatumFormatted As String = Format(Datum, "yyyyMMdd")
        Dim StrBestandsnaam As String = SjabloonCode & "_" & DatumFormatted & "_" & Volgnummer.ToString() & "_" & AuteurKort & "_" & Titel & Extensie
        Return StrBestandsnaam
    End Function
End Class
