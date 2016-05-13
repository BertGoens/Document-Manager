Public Class AuteurSjabloon

  

    Private Sub AuteurSjabloon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBDocumentenDataSet.Auteursjab' table. You can move, or remove it, as needed.
        ' Me.AuteursjabTableAdapter1.Fill(Me.DBDocumentenDataSet.Auteursjab)
        'TODO: This line of code loads data into the 'DBDocumentenDataSet.Auteurs' table. You can move, or remove it, as needed.
        Me.AuteursTableAdapter.Fill(Me.DBDocumentenDataSet.Auteurs)
        'TODO: This line of code loads data into the 'DtsSjabloonNew.Auteursjab' table. You can move, or remove it, as needed.
        Me.AuteursjabTableAdapter.Fill(Me.DtsSjabloonNew.Auteursjab)


    End Sub


    Private Sub AuteursjabBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AuteursjabBindingNavigatorSaveItem.Click
        '
        Me.Validate()
        Me.AuteursjabBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DtsSjabloonNew)
        '
    End Sub

    Private Sub SjoblonenBrowseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SjoblonenBrowseButton.Click
        'Use the open file dialog to choose a word dot document
        OpenFileDialog1.InitialDirectory = System.Environment.CurrentDirectory
        OpenFileDialog1.Title = "Open Dot File"
        OpenFileDialog1.Filter = "Text files (*.dot)|*.dot"
        OpenFileDialog1.FilterIndex = 1
        OpenFileDialog1.RestoreDirectory = True

        If Me.OpenFileDialog1.ShowDialog() = DialogResult.OK Then

            ' set the file name from the open file dialog
            Dim StrDotName As String = OpenFileDialog1.FileName

            'zet de nieuwe waarde in txtSjabloon
            SjablonenpadTextBox.Text = StrDotName

        End If
    End Sub

    Private Sub OpslagBrowseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpslagBrowseButton.Click
        'Use the folder browser dialog to choose a directory

        FolderBrowserDialog1.Description = "Open Directory"

        If Me.FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then

            ' set the file name from the open file dialog
            Dim StrOpslag As String = FolderBrowserDialog1.SelectedPath

            'zet de nieuwe waarde in txtSjabloon
            OpslagpadTextBox.Text = StrOpslag

        End If
    End Sub

  
    Private Sub AuteurSjabloon_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        '
        Me.Validate()
        Me.AuteursjabBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DtsSjabloonNew)
        '
    End Sub

    Private Sub SluitenButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SluitenButton.Click
        '
        Me.Close()
        '
    End Sub
End Class