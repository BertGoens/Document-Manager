Public Class DocumentBookmarks

    Public BM_afzender As Boolean
    Public BM_geadresseerde As Boolean
    Public BM_type As Boolean
    Public BM_uwbericht As Boolean
    Public BM_uwkenmerk As Boolean
    Public BM_onskenmerk As Boolean
    Public BM_datum As Boolean
    Public BM_onderwerp As Boolean
    Public BM_startdocument As Boolean

    Sub New()
        BM_afzender = False
        BM_geadresseerde = False
        BM_type = False
        BM_uwbericht = False
        BM_uwkenmerk = False
        BM_onskenmerk = False
        BM_datum = False
        BM_onderwerp = False
        BM_startdocument = False
    End Sub
End Class
