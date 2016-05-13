Partial Class dtsDocs
    Partial Class CodeDataTable

        Private Sub CodeDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.CodeColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class

Namespace dtsDocsTableAdapters
    

End Namespace

Namespace dtsDocsTableAdapters
    
    Partial Public Class SAV_DocumentenTableAdapter
    End Class
End Namespace
