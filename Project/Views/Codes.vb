Public Class Codes



    Private Sub Codes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DtsSjabloonNew.Auteurs' table. You can move, or remove it, as needed.
        Me.AuteursTableAdapter.Fill(Me.DtsSjabloonNew.Auteurs)
        'TODO: This line of code loads data into the 'DtsSjabloonNew.Code' table. You can move, or remove it, as needed.
        Me.CodeTableAdapter.Fill(Me.DtsSjabloonNew.Code)



    End Sub

    Private Sub Codes_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        '
        Me.Validate()
        Me.CodeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DtsSjabloonNew)
        '
    End Sub





    Private Sub SjabloonpadBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SjabloonpadBtn.Click
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

    Private Sub CodeBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CodeBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CodeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DtsSjabloonNew)
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        '
        Me.Close()
        '
    End Sub
End Class