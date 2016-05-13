Partial Class Ds_Volgnr
    Partial Class SAV_TellerDataTable

        Private Sub SAV_TellerDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.TellerColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class

Namespace Ds_VolgnrTableAdapters
    
    Partial Public Class SAV_TellerTableAdapter
    End Class
End Namespace
