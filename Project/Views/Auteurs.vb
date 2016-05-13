Public Class Auteurs

    Private Sub AuteursBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AuteursBindingNavigatorSaveItem.Click
        '
        Me.Validate()
        Me.AuteursBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DBDocumentenDataSet)
        '
    End Sub

    Private Sub Auteurs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBDocumentenDataSet.Auteurs' table. You can move, or remove it, as needed.
        Me.AuteursTableAdapter.Fill(Me.DBDocumentenDataSet.Auteurs)

    End Sub

    Private Sub Auteurs_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        '
        Me.Validate()
        Me.AuteursBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DBDocumentenDataSet)
        '
    End Sub

    Private Sub SluitenButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SluitenButton.Click
        '
        Me.Close()
        '
    End Sub
End Class