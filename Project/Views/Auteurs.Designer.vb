<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Auteurs
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Auteurs))
        Me.AuteursBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.AuteursBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DBDocumentenDataSet = New DM.DBDocumentenDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AuteursBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.SluitenButton = New System.Windows.Forms.ToolStripButton()
        Me.AuteursTableAdapter = New DM.DBDocumentenDataSetTableAdapters.AuteursTableAdapter()
        Me.TableAdapterManager = New DM.DBDocumentenDataSetTableAdapters.TableAdapterManager()
        Me.AuteursDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.AuteursBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AuteursBindingNavigator.SuspendLayout()
        CType(Me.AuteursBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBDocumentenDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuteursDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AuteursBindingNavigator
        '
        Me.AuteursBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AuteursBindingNavigator.BindingSource = Me.AuteursBindingSource
        Me.AuteursBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AuteursBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.AuteursBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AuteursBindingNavigatorSaveItem, Me.SluitenButton})
        Me.AuteursBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AuteursBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AuteursBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AuteursBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AuteursBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AuteursBindingNavigator.Name = "AuteursBindingNavigator"
        Me.AuteursBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AuteursBindingNavigator.Size = New System.Drawing.Size(864, 25)
        Me.AuteursBindingNavigator.TabIndex = 0
        Me.AuteursBindingNavigator.Text = "BindingNavigator1"
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
        'AuteursBindingSource
        '
        Me.AuteursBindingSource.DataMember = "Auteurs"
        Me.AuteursBindingSource.DataSource = Me.DBDocumentenDataSet
        '
        'DBDocumentenDataSet
        '
        Me.DBDocumentenDataSet.DataSetName = "DBDocumentenDataSet"
        Me.DBDocumentenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'AuteursBindingNavigatorSaveItem
        '
        Me.AuteursBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AuteursBindingNavigatorSaveItem.Image = CType(resources.GetObject("AuteursBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AuteursBindingNavigatorSaveItem.Name = "AuteursBindingNavigatorSaveItem"
        Me.AuteursBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.AuteursBindingNavigatorSaveItem.Text = "Save Data"
        '
        'SluitenButton
        '
        Me.SluitenButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SluitenButton.Image = CType(resources.GetObject("SluitenButton.Image"), System.Drawing.Image)
        Me.SluitenButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SluitenButton.Name = "SluitenButton"
        Me.SluitenButton.Size = New System.Drawing.Size(47, 22)
        Me.SluitenButton.Text = "Sluiten"
        '
        'AuteursTableAdapter
        '
        Me.AuteursTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AuteursjabTableAdapter = Nothing
        Me.TableAdapterManager.AuteursTableAdapter = Me.AuteursTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BestemmelingTableAdapter = Nothing
        Me.TableAdapterManager.CodeTableAdapter = Nothing
        Me.TableAdapterManager.DienstenTableAdapter = Nothing
        Me.TableAdapterManager.InstellingenTableAdapter = Nothing
        Me.TableAdapterManager.SAV_DocumentenTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = DM.DBDocumentenDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AuteursDataGridView
        '
        Me.AuteursDataGridView.AutoGenerateColumns = False
        Me.AuteursDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AuteursDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewCheckBoxColumn1})
        Me.AuteursDataGridView.DataSource = Me.AuteursBindingSource
        Me.AuteursDataGridView.Location = New System.Drawing.Point(12, 42)
        Me.AuteursDataGridView.Name = "AuteursDataGridView"
        Me.AuteursDataGridView.Size = New System.Drawing.Size(671, 220)
        Me.AuteursDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "AuteurID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "AuteurID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Auteur"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Auteur"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "MagAllesZien"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "MagAllesZien"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'Auteurs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 315)
        Me.Controls.Add(Me.AuteursDataGridView)
        Me.Controls.Add(Me.AuteursBindingNavigator)
        Me.Name = "Auteurs"
        Me.Text = "Auteurs"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.AuteursBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AuteursBindingNavigator.ResumeLayout(False)
        Me.AuteursBindingNavigator.PerformLayout()
        CType(Me.AuteursBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBDocumentenDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuteursDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DBDocumentenDataSet As DM.DBDocumentenDataSet
    Friend WithEvents AuteursBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AuteursTableAdapter As DM.DBDocumentenDataSetTableAdapters.AuteursTableAdapter
    Friend WithEvents TableAdapterManager As DM.DBDocumentenDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AuteursBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents AuteursBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents SluitenButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents AuteursDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
