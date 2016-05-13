Public Class Diensten


    Private Sub DienstenBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DienstenBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DienstenBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DBDocumentenDataSet)

    End Sub

    Private Sub Diensten_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBDocumentenDataSet.Diensten' table. You can move, or remove it, as needed.
        Me.DienstenTableAdapter.Fill(Me.DBDocumentenDataSet.Diensten)

    End Sub


    Private Sub SluitenButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SluitenButton.Click
        '
        Me.Close()
        '
    End Sub
End Class