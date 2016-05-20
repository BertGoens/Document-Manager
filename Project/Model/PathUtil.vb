Imports System.Runtime.InteropServices
Imports System.Runtime.Versioning
Imports Microsoft.CSharp
Imports System.IO
Imports System.Management
Imports Microsoft.Win32

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

    ''' <summary>
    ''' Tries to create an UNC path from a local drive path. 
    ''' Returns nothing if path cannot be converted to an UNC path
    ''' </summary>
    Public Shared Function GetUNCPathFromLocal(ByVal path As String) As String
        If (IsUncPath(path)) Then
            Return path
        End If

        Dim di As DriveInfo = New DriveInfo(Directory.GetDirectoryRoot(path))
        Dim serverPath As String = ""
        If di.DriveType = DriveType.Network Then
            Try
                serverPath = CheckUNCPath(di.Name(0))
                path = path.Replace(di.Name, serverPath + "\")
                If Not path.EndsWith("\") Then
                    path = path + "\"
                End If

                Return path
            Catch ex As Exception
            End Try
        End If

        Return Nothing
    End Function

    ''' <summary>
    ''' Given a local mapped drive letter, determine if it is a network drive. If so, return the server share.
    ''' </summary>
    ''' <returns>The server path that the drive maps to ~ "////XXXXXX//ZZZZ"</returns>
    Private Shared Function CheckUNCPath(mappedDrive As String) As String
        'Query to return all the local computer's drives.
        'See http://msdn.microsoft.com/en-us/library/ms186146.aspx, or search "WMI Queries"
        Dim selectWMIQuery As New SelectQuery("Win32_LogicalDisk")
        Dim driveSearcher As New ManagementObjectSearcher(selectWMIQuery)

        'Soem variables to be used inside and out of the foreach.
        Dim path As ManagementPath = Nothing
        Dim networkDrive As ManagementObject = Nothing
        Dim found As Boolean = False
        Dim serverName As String = Nothing

        'Check each disk, determine if it is a network drive, and then return the real server path.
        For Each disk As ManagementObject In driveSearcher.[Get]()
            path = disk.Path

            If path.ToString().Contains(mappedDrive) Then
                networkDrive = New ManagementObject(path)

                If Convert.ToUInt32(networkDrive("DriveType")) = 4 Then
                    serverName = Convert.ToString(networkDrive("ProviderName"))
                    found = True
                    Exit For
                Else
                    Throw New DirectoryNotFoundException((Convert.ToString("The drive ") & mappedDrive) + " was found, but is not a network drive. Were your network drives mapped correctly?")
                End If
            End If
        Next

        If Not found Then
            Throw New DirectoryNotFoundException((Convert.ToString("The drive ") & mappedDrive) + " was not found. Were your network drives mapped correctly?")
        Else
            Return serverName
        End If
    End Function

End Class
