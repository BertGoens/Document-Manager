<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bestemmeling_wijzig
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
        Dim FirmaLabel1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Bestemmeling_wijzig))
        Me.ZoekTextbox = New System.Windows.Forms.TextBox
        Me.ZoekButton = New System.Windows.Forms.Button
        Me.DtsBestemmeling = New DM.dtsBestemmeling
        Me.BestemmelingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BestemmelingTableAdapter = New DM.dtsBestemmelingTableAdapters.BestemmelingTableAdapter
        Me.TableAdapterManager = New DM.dtsBestemmelingTableAdapters.TableAdapterManager
        Me.BestemmelingBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BestemmelingBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.BestemmelingDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.SluitenButton = New System.Windows.Forms.ToolStripButton
        Me.Label2 = New System.Windows.Forms.Label
        FirmaLabel1 = New System.Windows.Forms.Label
        CType(Me.DtsBestemmeling, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BestemmelingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BestemmelingBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BestemmelingBindingNavigator.SuspendLayout()
        CType(Me.BestemmelingDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FirmaLabel1
        '
        FirmaLabel1.AutoSize = True
        FirmaLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FirmaLabel1.Location = New System.Drawing.Point(29, 50)
        FirmaLabel1.Name = "FirmaLabel1"
        FirmaLabel1.Size = New System.Drawing.Size(145, 13)
        FirmaLabel1.TabIndex = 10
        FirmaLabel1.Text = "Zoek een bestemmeling:"
        '
        'ZoekTextbox
        '
        Me.ZoekTextbox.Location = New System.Drawing.Point(181, 47)
        Me.ZoekTextbox.Name = "ZoekTextbox"
        Me.ZoekTextbox.Size = New System.Drawing.Size(192, 20)
        Me.ZoekTextbox.TabIndex = 0
        Me.ZoekTextbox.TabStop = False
        '
        'ZoekButton
        '
        Me.ZoekButton.Location = New System.Drawing.Point(379, 45)
        Me.ZoekButton.Name = "ZoekButton"
        Me.ZoekButton.Size = New System.Drawing.Size(75, 23)
        Me.ZoekButton.TabIndex = 1
        Me.ZoekButton.Text = "Zoeken"
        Me.ZoekButton.UseVisualStyleBackColor = True
        '
        'DtsBestemmeling
        '
        Me.DtsBestemmeling.DataSetName = "dtsBestemmeling"
        Me.DtsBestemmeling.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BestemmelingBindingSource
        '
        Me.BestemmelingBindingSource.DataMember = "Bestemmeling"
        Me.BestemmelingBindingSource.DataSource = Me.DtsBestemmeling
        '
        'BestemmelingTableAdapter
        '
        Me.BestemmelingTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BestemmelingTableAdapter = Me.BestemmelingTableAdapter
        Me.TableAdapterManager.UpdateOrder = DM.dtsBestemmelingTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BestemmelingBindingNavigator
        '
        Me.BestemmelingBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BestemmelingBindingNavigator.BindingSource = Me.BestemmelingBindingSource
        Me.BestemmelingBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.BestemmelingBindingNavigator.DeleteItem = Nothing
        Me.BestemmelingBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BestemmelingBindingNavigatorSaveItem, Me.SluitenButton})
        Me.BestemmelingBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.BestemmelingBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BestemmelingBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BestemmelingBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BestemmelingBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BestemmelingBindingNavigator.Name = "BestemmelingBindingNavigator"
        Me.BestemmelingBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.BestemmelingBindingNavigator.Size = New System.Drawing.Size(973, 25)
        Me.BestemmelingBindingNavigator.TabIndex = 18
        Me.BestemmelingBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(81, 22)
        Me.BindingNavigatorAddNewItem.Text = "Toevoegen"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'BestemmelingBindingNavigatorSaveItem
        '
        Me.BestemmelingBindingNavigatorSaveItem.Image = CType(resources.GetObject("BestemmelingBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.BestemmelingBindingNavigatorSaveItem.Name = "BestemmelingBindingNavigatorSaveItem"
        Me.BestemmelingBindingNavigatorSaveItem.Size = New System.Drawing.Size(66, 22)
        Me.BestemmelingBindingNavigatorSaveItem.Text = "Opslaan"
        '
        'BestemmelingDataGridView
        '
        Me.BestemmelingDataGridView.AllowUserToDeleteRows = False
        Me.BestemmelingDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BestemmelingDataGridView.AutoGenerateColumns = False
        Me.BestemmelingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BestemmelingDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.BestemmelingDataGridView.DataSource = Me.BestemmelingBindingSource
        Me.BestemmelingDataGridView.Location = New System.Drawing.Point(12, 76)
        Me.BestemmelingDataGridView.Name = "BestemmelingDataGridView"
        Me.BestemmelingDataGridView.Size = New System.Drawing.Size(793, 393)
        Me.BestemmelingDataGridView.TabIndex = 18
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Firma"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Firma"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Adres"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Adres"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 59
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Postnummer"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Postnummer"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 90
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Stad"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Stad"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(498, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Enkel toevoegen en wijzigen is mogelijk."
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(501, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(199, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Bij sluiten wordt er automatisch bewaard."
        '
        'Bestemmeling_wijzig
        '
        Me.AcceptButton = Me.ZoekButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(973, 522)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BestemmelingDataGridView)
        Me.Controls.Add(Me.BestemmelingBindingNavigator)
        Me.Controls.Add(Me.ZoekButton)
        Me.Controls.Add(Me.ZoekTextbox)
        Me.Controls.Add(FirmaLabel1)
        Me.Name = "Bestemmeling_wijzig"
        Me.Text = "Bestemmeling_wijzig"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DtsBestemmeling, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BestemmelingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BestemmelingBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BestemmelingBindingNavigator.ResumeLayout(False)
        Me.BestemmelingBindingNavigator.PerformLayout()
        CType(Me.BestemmelingDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ZoekTextbox As System.Windows.Forms.TextBox
    Friend WithEvents ZoekButton As System.Windows.Forms.Button
    Friend WithEvents DtsBestemmeling As DM.dtsBestemmeling
    Friend WithEvents BestemmelingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BestemmelingTableAdapter As DM.dtsBestemmelingTableAdapters.BestemmelingTableAdapter
    Friend WithEvents TableAdapterManager As DM.dtsBestemmelingTableAdapters.TableAdapterManager
    Friend WithEvents BestemmelingBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BestemmelingBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BestemmelingDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SluitenButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
