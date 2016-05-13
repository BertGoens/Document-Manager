<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DBLijst
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DBLijst))
        Me.DBDocumentenDataSet = New DM.DBDocumentenDataSet
        Me.SAV_DocumentenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SAV_DocumentenTableAdapter = New DM.DBDocumentenDataSetTableAdapters.SAV_DocumentenTableAdapter
        Me.TableAdapterManager = New DM.DBDocumentenDataSetTableAdapters.TableAdapterManager
        Me.SAV_DocumentenBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.SAV_DocumentenBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.SAV_DocumentenDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SluitenButton = New System.Windows.Forms.ToolStripButton
        CType(Me.DBDocumentenDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SAV_DocumentenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SAV_DocumentenBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SAV_DocumentenBindingNavigator.SuspendLayout()
        CType(Me.SAV_DocumentenDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DBDocumentenDataSet
        '
        Me.DBDocumentenDataSet.DataSetName = "DBDocumentenDataSet"
        Me.DBDocumentenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SAV_DocumentenBindingSource
        '
        Me.SAV_DocumentenBindingSource.DataMember = "SAV_Documenten"
        Me.SAV_DocumentenBindingSource.DataSource = Me.DBDocumentenDataSet
        '
        'SAV_DocumentenTableAdapter
        '
        Me.SAV_DocumentenTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AuteursjabTableAdapter = Nothing
        Me.TableAdapterManager.AuteursTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BestemmelingTableAdapter = Nothing
        Me.TableAdapterManager.CodeTableAdapter = Nothing
        Me.TableAdapterManager.DienstenTableAdapter = Nothing
        Me.TableAdapterManager.InstellingenTableAdapter = Nothing
        Me.TableAdapterManager.SAV_DocumentenTableAdapter = Me.SAV_DocumentenTableAdapter
        Me.TableAdapterManager.UpdateOrder = DM.DBDocumentenDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SAV_DocumentenBindingNavigator
        '
        Me.SAV_DocumentenBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SAV_DocumentenBindingNavigator.BindingSource = Me.SAV_DocumentenBindingSource
        Me.SAV_DocumentenBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SAV_DocumentenBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SAV_DocumentenBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SAV_DocumentenBindingNavigatorSaveItem, Me.SluitenButton})
        Me.SAV_DocumentenBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SAV_DocumentenBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SAV_DocumentenBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SAV_DocumentenBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SAV_DocumentenBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SAV_DocumentenBindingNavigator.Name = "SAV_DocumentenBindingNavigator"
        Me.SAV_DocumentenBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SAV_DocumentenBindingNavigator.Size = New System.Drawing.Size(1021, 25)
        Me.SAV_DocumentenBindingNavigator.TabIndex = 0
        Me.SAV_DocumentenBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'SAV_DocumentenBindingNavigatorSaveItem
        '
        Me.SAV_DocumentenBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SAV_DocumentenBindingNavigatorSaveItem.Image = CType(resources.GetObject("SAV_DocumentenBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SAV_DocumentenBindingNavigatorSaveItem.Name = "SAV_DocumentenBindingNavigatorSaveItem"
        Me.SAV_DocumentenBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.SAV_DocumentenBindingNavigatorSaveItem.Text = "Save Data"
        '
        'SAV_DocumentenDataGridView
        '
        Me.SAV_DocumentenDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SAV_DocumentenDataGridView.AutoGenerateColumns = False
        Me.SAV_DocumentenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SAV_DocumentenDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13})
        Me.SAV_DocumentenDataGridView.DataSource = Me.SAV_DocumentenBindingSource
        Me.SAV_DocumentenDataGridView.Location = New System.Drawing.Point(12, 41)
        Me.SAV_DocumentenDataGridView.Name = "SAV_DocumentenDataGridView"
        Me.SAV_DocumentenDataGridView.Size = New System.Drawing.Size(997, 220)
        Me.SAV_DocumentenDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Sleutel"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Sleutel"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Auteurid"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Auteurid"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Code"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Code"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Volgnummer"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Volgnummer"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Locatie"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Locatie"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Sjabloon"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Sjabloon"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Datum_create"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Datum_create"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Datum_doc"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Datum_doc"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Titel"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Titel"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Trefwoord"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Trefwoord"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Afzender"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Afzender"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Bestandsnaam"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Bestandsnaam"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Firma"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Firma"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'SluitenButton
        '
        Me.SluitenButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SluitenButton.Image = CType(resources.GetObject("SluitenButton.Image"), System.Drawing.Image)
        Me.SluitenButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SluitenButton.Name = "SluitenButton"
        Me.SluitenButton.Size = New System.Drawing.Size(43, 22)
        Me.SluitenButton.Text = "Sluiten"
        '
        'DBLijst
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1021, 506)
        Me.Controls.Add(Me.SAV_DocumentenDataGridView)
        Me.Controls.Add(Me.SAV_DocumentenBindingNavigator)
        Me.Name = "DBLijst"
        Me.Text = "DBLijst"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DBDocumentenDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SAV_DocumentenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SAV_DocumentenBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SAV_DocumentenBindingNavigator.ResumeLayout(False)
        Me.SAV_DocumentenBindingNavigator.PerformLayout()
        CType(Me.SAV_DocumentenDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DBDocumentenDataSet As DM.DBDocumentenDataSet
    Friend WithEvents SAV_DocumentenBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SAV_DocumentenTableAdapter As DM.DBDocumentenDataSetTableAdapters.SAV_DocumentenTableAdapter
    Friend WithEvents TableAdapterManager As DM.DBDocumentenDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SAV_DocumentenBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SAV_DocumentenBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents SAV_DocumentenDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SluitenButton As System.Windows.Forms.ToolStripButton
End Class
