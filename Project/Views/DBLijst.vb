Public Class DBLijst




    Private Sub SAV_DocumentenBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SAV_DocumentenBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SAV_DocumentenBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DBDocumentenDataSet)

    End Sub

    Private Sub DBLijst_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBDocumentenDataSet.SAV_Documenten' table. You can move, or remove it, as needed.
        Me.SAV_DocumentenTableAdapter.Fill(Me.DBDocumentenDataSet.SAV_Documenten)

    End Sub

    Private Sub SluitenButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SluitenButton.Click
        '
        Me.Close()
        '
    End Sub
End Class