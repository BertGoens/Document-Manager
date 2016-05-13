﻿Public Class Bestemmeling



    Private Sub Bestemmeling_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DtsBestemmeling.Bestemmeling' table. You can move, or remove it, as needed.
        Me.BestemmelingTableAdapter.Fill(Me.DtsBestemmeling.Bestemmeling)


    End Sub


    Private Sub BestemmelingBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BestemmelingBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BestemmelingBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DtsBestemmeling)

    End Sub

    Private Sub ZoekButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZoekButton.Click
        'TODO: This line of code loads data into the 'DtsBestemmeling.Bestemmeling' table. You can move, or remove it, as needed.
        Me.BestemmelingTableAdapter.FillByZoekFirma(DtsBestemmeling.Bestemmeling, Me.ZoekTextbox.Text)

    End Sub

    Private Sub Bestemmeling_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        '
        Me.Validate()
        Me.BestemmelingBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DtsBestemmeling)
        ''
    End Sub

    Private Sub Sluiten_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sluiten.Click
        '
        Me.Close()
        '
    End Sub
End Class