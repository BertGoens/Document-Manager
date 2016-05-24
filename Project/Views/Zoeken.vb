Imports System.Data.SqlClient
Imports System.IO

Public Class Zoeken

    Private dbDocumenten As New DBDocumentenDataSetTableAdapters.SAV_DocumentenTableAdapter
    Private _Singleton As Singleton = Singleton.Instance

    Private Sub Zoeken_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.Ag
        Me.Refresh()

        dgvZoeken.Update()

        'Laad de datasources om de zoekparameters te vullen
        Me.CodeTableAdapter.Fill(DtsZoeken.Code)
        Me.AuteursTableAdapter.Fill(DtsZoeken.Auteurs)

        'Andere zoekparameters opmaken
        Me.DatumVanDTP.Value = DateAdd(DateInterval.Month, -4, Today)
        Me.DatumTotDTP.Value = Today
        cboDocumentTypeCode.Text = "ALLES"
        cboAuteurs.Text = _Singleton.UIGebruikersInstellingen.Auteur.AuteurLang
        cboAuteurs.Enabled = _Singleton.UIGebruikersInstellingen.Auteur.MagAllesZien
        btnZoek.Visible = True
    End Sub

    Private Sub ZoekBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZoek.Click
        reloadDatagrid()
        btnVerplaatsen.Visible = True
        btnVerwijderen.Visible = True
        btnWijzigTitel.Visible = True
    End Sub

    Private Sub ZoekDataGridView_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvZoeken.CellContentDoubleClick
        Dim StrFullBestand As String = dgvZoeken.CurrentRow.Cells(0).Value.ToString()

        Try
            'openen van andere bestanden
            Process.Start(StrFullBestand)
        Catch ex As Exception
            MsgBox(ex.Message + vbCrLf + StrFullBestand, MsgBoxStyle.Critical, "Bestand openen fout")
        End Try
    End Sub

    ''' <summary>
    ''' Wijzig het pad (en documentnaam) op 3 plaatsen: databank titel, databank pad, fileserver pad
    ''' </summary>
    ''' <remarks>De totale naam bestaat uit: </remarks>
    Private Sub WijzigPadBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWijzigTitel.Click
        'Controleer of de juiste row in de datagrid geselecteerd is
        If dgvZoeken.CurrentRow.Index < 0 Then
            MessageBox.Show("Selecteer het bestand dat je wilt hernoemen.")
            Return
        End If

        'ZoekDataGridView.SelectedCells.Item(0).Value.ToString()
        Dim OrigineelBestandPadEnNaam As String = dgvZoeken.CurrentRow.Cells(0).Value.ToString()
        Dim OrigineleTitel As String = dgvZoeken.CurrentRow.Cells(1).Value.ToString()

        'Controleer of het bestand bestaat
        If Not File.Exists(OrigineelBestandPadEnNaam) Then
            If PathUtil.IsUncPath(OrigineelBestandPadEnNaam) Then
                MessageBox.Show("Het bestand staat niet op een publieke share, " + _
                                "je kan er van deze computer niet op.", "Bestand niet gevonden")
            Else
                MessageBox.Show("Het bestand bestaat niet meer of is verplaatst", "Bestand niet gevonden")
            End If
            Exit Sub
        End If

        'Opvragen nieuwe naam
        Dim nieuweNaam As String = InputBox("Welke nieuwe naam wil je geven aan dit bestand?",
                                            "Nieuwe documentsnaam", OrigineleTitel)
        Dim extensie As String = ".docx"

        'Input controleren
        If Not PathUtil.IsValidFileName(nieuweNaam) Then
            MessageBox.Show("Ongeldige naam!", "Nieuwe documentsnaam")
            Return
        End If

        'Bouw het nieuwe (server) locatiepad op
        'Ik ~steel~ het van het bestaande want voor zover ik weet kun je het niet zelf opnieuw opbouwen?
        Dim LastIndexOfUnderscore As Integer = OrigineelBestandPadEnNaam.LastIndexOf("_")
        Dim pad As String = OrigineelBestandPadEnNaam.Substring(0, LastIndexOfUnderscore + 1) 'de underscore meepakken
        Dim nieuwBestandPadEnNaam As String = pad + nieuweNaam + extensie

        Dim fi As FileInfo = New FileInfo(OrigineelBestandPadEnNaam)

        'Hernoem bestand
        Try
            fi.MoveTo(nieuwBestandPadEnNaam)
        Catch ex As Exception
            'Mislukt
            MessageBox.Show(ex.Message, "Hernoemen mislukt!")
            Return
        End Try

        'Verander de waardes op de server
        'db.UpdatLocatie verandert alleen het pad in de database
        Dim bestandenHernoemd As Integer = dbDocumenten.UpdateLocatie(nieuwBestandPadEnNaam, OrigineelBestandPadEnNaam)
        'verander nu de titel in de database
        Dim titelHernoemd As Integer = dbDocumenten.UpdateTitel(nieuweNaam, nieuwBestandPadEnNaam)

        reloadDatagrid()

        If (bestandenHernoemd = 1 And titelHernoemd = 1) Then
            MessageBox.Show("Naam wijziging: " + OrigineleTitel + Environment.NewLine + _
                            "Naar: " + nieuweNaam, "Bestand hernoemd")
        Else
            'Door database fouten kunnen er mogelijks ongewenste dingen gebeuren
            MessageBox.Show(bestandenHernoemd.ToString() + " bestand(en) hernoemd + " + Environment.NewLine + _
                            titelHernoemd.ToString() + " titel(s) veranderd " + Environment.NewLine + _
                            "naar " + nieuweNaam, "Bestand(en) hernoemd", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Zoeken_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Validate()
        Me.SAV_DocumentenBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DtsZoeken)
    End Sub

    Private Sub btnVerplaatsen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerplaatsen.Click
        If dgvZoeken.CurrentRow.Index > -1 Then
            Dim TeVerplaatsenFilePathAndName As String = dgvZoeken.CurrentRow.Cells(0).Value.ToString()
            Dim VerplaatsFileName As String = Path.GetFileName(TeVerplaatsenFilePathAndName)
            Dim VerplaatsFileDirectory As String = Path.GetDirectoryName(TeVerplaatsenFilePathAndName)
            'Controleer of het bestand bestaat
            If Not File.Exists(TeVerplaatsenFilePathAndName) Then
                If Not PathUtil.IsUncPath(TeVerplaatsenFilePathAndName) Then
                    MessageBox.Show("Het bestand dat je wil verplaatsen staat niet op een publieke share, " & _
                                    "je kan er van deze computer niet op.", "Bestand niet gevonden")
                Else
                    MessageBox.Show("Het bestand dat je wil verplaatsen bestaat niet, is manueel verplaatst of je hebt niet genoeg rechten.",
                                    "Bestand niet gevonden")
                End If
                Exit Sub
            End If

            'Vraag gebruiker een nieuwe locatie om bestand naar te verplaatsen
            Dim dlgFolderLocatie As SaveFileDialog = New SaveFileDialog
            dlgFolderLocatie.FileName = VerplaatsFileName
            If String.IsNullOrEmpty(_Singleton.UIGebruikersInstellingen.Opslagplaats) Then
                dlgFolderLocatie.InitialDirectory = TeVerplaatsenFilePathAndName
                dlgFolderLocatie.RestoreDirectory = True
            Else
                dlgFolderLocatie.InitialDirectory = _Singleton.UIGebruikersInstellingen.Opslagplaats
            End If

            dlgFolderLocatie.AddExtension = False
            dlgFolderLocatie.CheckPathExists = True

            If dlgFolderLocatie.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Dim NiewPathAndName As String = dlgFolderLocatie.FileName
                'Controleer of het geselecteerde pad een UNC pad is
                Dim SaveToFolder As String = Path.GetDirectoryName(dlgFolderLocatie.FileName) + "\"
                If PathUtil.IsUncPath(SaveToFolder) Then
                    'Verplaats
                    File.Move(TeVerplaatsenFilePathAndName, SaveToFolder + VerplaatsFileName)
                    'Update DB
                    dbDocumenten.UpdateLocatie(SaveToFolder + VerplaatsFileName, TeVerplaatsenFilePathAndName)
                    reloadDatagrid()
                Else

                    MessageBox.Show("Je kunt het bestand alleen naar een andere publieke share verplaatsen!" & _
                                   vbCrLf & SaveToFolder + " is niet geldig.", "Verplaatsen niet toegestaan")
                End If

            End If
        End If
    End Sub

    Private Sub btnVerwijderen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerwijderen.Click
        Dim datagridInitialen As String = dgvZoeken.Rows(dgvZoeken.SelectedCells.Item(0).RowIndex).Cells(3).Value.ToString()
        Dim comboboxInitialen As String = cboAuteurs.SelectedValue.ToString() 'in orde --> BD is het resultaat

        Try
            If comboboxInitialen.Trim.Equals(datagridInitialen.Trim) Then
                System.IO.File.Delete(dgvZoeken.SelectedCells.Item(0).Value.ToString())
                dbDocumenten.VerwijderBestand(dgvZoeken.SelectedCells.Item(0).Value.ToString())
                reloadDatagrid()
            Else
                MessageBox.Show("U bent niet bevoegt om dit bestand te verwijderen")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message(), "Onverwachte fout bij verwijderen")
        End Try
    End Sub

    Private Sub reloadDatagrid()
        Dim strCode, strAuteur, strDatumVan, strDatumTot As String
        strAuteur = Me.cboAuteurs.SelectedValue.ToString()
        strCode = Me.cboDocumentTypeCode.SelectedValue.ToString()
        strDatumVan = "'" & DatumVanDTP.Value.ToString("MM-dd-yyyy") & " 00:00:00'"
        strDatumTot = "'" & DatumTotDTP.Value.ToString("MM-dd-yyyy") & " 00:00:00'"

        Try
            'keuze 1
            ' auteur :alles en doc-type : alles
            If (strAuteur = "ALL") And (strCode = "ALLES") Then
                Me.SAV_DocumentenTableAdapter.FillByZOEK1(DtsZoeken.SAV_Documenten, txtZoekterm.Text, DatumVanDTP.Value, DatumTotDTP.Value)

            ElseIf (strAuteur <> "ALL") And (strCode = "ALLES") Then
                'keuze 2
                'auteur: keuze en doc-type : alles
                Me.SAV_DocumentenTableAdapter.FillByZOEK2(DtsZoeken.SAV_Documenten, txtZoekterm.Text, strAuteur, DatumVanDTP.Value, DatumTotDTP.Value)


            ElseIf (strAuteur <> "ALL") And (strCode <> "ALLES") Then
                'keuze 3
                'auteur: keuze en doc-type : keuze
                Me.SAV_DocumentenTableAdapter.FillByZOEK3(DtsZoeken.SAV_Documenten, txtZoekterm.Text, strAuteur, strCode, DatumVanDTP.Value, DatumTotDTP.Value)

            ElseIf (strAuteur = "ALL") And (strCode <> "ALLES") Then
                'keuze 4
                'auteur: alles en doc-type : keuze
                Me.SAV_DocumentenTableAdapter.FillByZOEK4(DtsZoeken.SAV_Documenten, txtZoekterm.Text, strCode, DatumVanDTP.Value, DatumTotDTP.Value)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Zoeken_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        'Resize Datagrid
        Dim intDgvZoekenYLocation As Integer = 285
        dgvZoeken.Height = Me.Size.Height - intDgvZoekenYLocation
    End Sub
End Class