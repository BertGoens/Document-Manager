Imports System.Runtime.InteropServices
Imports System.Runtime.Versioning
Imports Microsoft.CSharp

Public Class PathUtil
    ''' <summary>
    ''' Controleer als een path legaal is; dit mag geen *,;: enz bevatten
    ''' </summary>
    Public Shared Function IsValidPathName(ByVal name As String) As Boolean
        ' Determines if the name is Nothing.
        If name Is Nothing Then
            Return False
        End If

        If name.Trim().Length < 1 Then
            Return False
        End If

        ' Determines if there are bad characters in the name.
        For Each badChar As Char In System.IO.Path.GetInvalidPathChars
            If InStr(name, badChar) > 0 Then
                Return False
            End If
        Next

        ' The name passes basic validation.
        Return True
    End Function

    ''' <summary>
    ''' Controleer als een naam legaal is; dit mag geen *,;: enz bevatten
    ''' </summary>
    Public Shared Function IsValidFileName(ByVal Name As String) As Boolean
        ' Determines if the name is Nothing.
        If Name Is Nothing Then
            Return False
        End If

        If Name.Trim().Length < 1 Then
            Return False
        End If

        For Each badChar As Char In System.IO.Path.GetInvalidFileNameChars
            If InStr(Name, badChar) > 0 Then
                Return False
            End If
        Next

        ' The name passes basic validation.
        Return True
    End Function

    ''' <summary>
    ''' Checks if a path is on a share in format \\server\share
    ''' </summary>
    Public Shared Function IsUncPath(ByVal path As String) As Boolean
        If System.IO.Path.IsPathRooted(path) Then
            If path.StartsWith("\\") Then
                Return True
            End If
        End If
        Return False
    End Function
End Class
