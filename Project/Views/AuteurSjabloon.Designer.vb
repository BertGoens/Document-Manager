<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AuteurSjabloon
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
        Dim SjablonenpadLabel As System.Windows.Forms.Label
        Dim OpslagpadLabel As System.Windows.Forms.Label
        Dim AuteuridLabel As System.Windows.Forms.Label
        Dim Auteursjab_IDLabel As System.Windows.Forms.Label
        Dim AfzenderLabel As System.Windows.Forms.Label
        Dim Afzender_tekstLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AuteurSjabloon))
        Me.DtsSjabloonNew = New DM.dtsSjabloonNew
        Me.AuteursjabBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AuteursjabTableAdapter = New DM.dtsSjabloonNewTableAdapters.AuteursjabTableAdapter
        Me.TableAdapterManager = New DM.dtsSjabloonNewTableAdapters.TableAdapterManager
        Me.AuteursjabBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.AuteursjabBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.SluitenButton = New System.Windows.Forms.ToolStripButton
        Me.SjablonenpadTextBox = New System.Windows.Forms.TextBox
        Me.OpslagpadTextBox = New System.Windows.Forms.TextBox
        Me.DBDocumentenDataSet = New DM.DBDocumentenDataSet
        Me.AuteuridComboBox = New System.Windows.Forms.ComboBox
        Me.AuteursBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Auteursjab_IDLabel1 = New System.Windows.Forms.Label
        Me.AuteursTableAdapter = New DM.DBDocumentenDataSetTableAdapters.AuteursTableAdapter
        Me.Label1 = New System.Windows.Forms.Label
        Me.OpslagBrowseButton = New System.Windows.Forms.Button
        Me.SjoblonenBrowseButton = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.DtsSjabloonNewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AuteursjabBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AuteursjabTableAdapter1 = New DM.DBDocumentenDataSetTableAdapters.AuteursjabTableAdapter
        Me.TableAdapterManager1 = New DM.DBDocumentenDataSetTableAdapters.TableAdapterManager
        Me.AuteursjabDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AfzenderTextBox = New System.Windows.Forms.TextBox
        Me.Afzender_tekstTextBox = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        SjablonenpadLabel = New System.Windows.Forms.Label
        OpslagpadLabel = New System.Windows.Forms.Label
        AuteuridLabel = New System.Windows.Forms.Label
        Auteursjab_IDLabel = New System.Windows.Forms.Label
        AfzenderLabel = New System.Windows.Forms.Label
        Afzender_tekstLabel = New System.Windows.Forms.Label
        CType(Me.DtsSjabloonNew, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuteursjabBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuteursjabBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AuteursjabBindingNavigator.SuspendLayout()
        CType(Me.DBDocumentenDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuteursBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtsSjabloonNewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuteursjabBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuteursjabDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SjablonenpadLabel
        '
        SjablonenpadLabel.AutoSize = True
        SjablonenpadLabel.Location = New System.Drawing.Point(16, 117)
        SjablonenpadLabel.Name = "SjablonenpadLabel"
        SjablonenpadLabel.Size = New System.Drawing.Size(75, 13)
        SjablonenpadLabel.TabIndex = 8
        SjablonenpadLabel.Text = "Sjablonenpad:"
        '
        'OpslagpadLabel
        '
        OpslagpadLabel.AutoSize = True
        OpslagpadLabel.Location = New System.Drawing.Point(30, 143)
        OpslagpadLabel.Name = "OpslagpadLabel"
        OpslagpadLabel.Size = New System.Drawing.Size(61, 13)
        OpslagpadLabel.TabIndex = 10
        OpslagpadLabel.Text = "Opslagpad:"
        '
        'AuteuridLabel
        '
        AuteuridLabel.AutoSize = True
        AuteuridLabel.Location = New System.Drawing.Point(42, 88)
        AuteuridLabel.Name = "AuteuridLabel"
        AuteuridLabel.Size = New System.Drawing.Size(49, 13)
        AuteuridLabel.TabIndex = 12
        AuteuridLabel.Text = "Auteurid:"
        '
        'Auteursjab_IDLabel
        '
        Auteursjab_IDLabel.AutoSize = True
        Auteursjab_IDLabel.Location = New System.Drawing.Point(17, 58)
        Auteursjab_IDLabel.Name = "Auteursjab_IDLabel"
        Auteursjab_IDLabel.Size = New System.Drawing.Size(74, 13)
        Auteursjab_IDLabel.TabIndex = 13
        Auteursjab_IDLabel.Text = "Auteursjab ID:"
        '
        'AfzenderLabel
        '
        AfzenderLabel.AutoSize = True
        AfzenderLabel.Location = New System.Drawing.Point(39, 169)
        AfzenderLabel.Name = "AfzenderLabel"
        AfzenderLabel.Size = New System.Drawing.Size(52, 13)
        AfzenderLabel.TabIndex = 22
        AfzenderLabel.Text = "Afzender:"
        '
        'Afzender_tekstLabel
        '
        Afzender_tekstLabel.AutoSize = True
        Afzender_tekstLabel.Location = New System.Drawing.Point(13, 195)
        Afzender_tekstLabel.Name = "Afzender_tekstLabel"
        Afzender_tekstLabel.Size = New System.Drawing.Size(78, 13)
        Afzender_tekstLabel.TabIndex = 23
        Afzender_tekstLabel.Text = "Afzender tekst:"
        '
        'DtsSjabloonNew
        '
        Me.DtsSjabloonNew.DataSetName = "dtsSjabloonNew"
        Me.DtsSjabloonNew.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AuteursjabBindingSource
        '
        Me.AuteursjabBindingSource.DataMember = "Auteursjab"
        Me.AuteursjabBindingSource.DataSource = Me.DtsSjabloonNew
        '
        'AuteursjabTableAdapter
        '
        Me.AuteursjabTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AuteursjabTableAdapter = Me.AuteursjabTableAdapter
        Me.TableAdapterManager.AuteursTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CodeTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = DM.dtsSjabloonNewTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AuteursjabBindingNavigator
        '
        Me.AuteursjabBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AuteursjabBindingNavigator.BindingSource = Me.AuteursjabBindingSource
        Me.AuteursjabBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AuteursjabBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.AuteursjabBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AuteursjabBindingNavigatorSaveItem, Me.SluitenButton})
        Me.AuteursjabBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AuteursjabBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AuteursjabBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AuteursjabBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AuteursjabBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AuteursjabBindingNavigator.Name = "AuteursjabBindingNavigator"
        Me.AuteursjabBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AuteursjabBindingNavigator.Size = New System.Drawing.Size(860, 25)
        Me.AuteursjabBindingNavigator.TabIndex = 0
        Me.AuteursjabBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
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
        'AuteursjabBindingNavigatorSaveItem
        '
        Me.AuteursjabBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AuteursjabBindingNavigatorSaveItem.Image = CType(resources.GetObject("AuteursjabBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AuteursjabBindingNavigatorSaveItem.Name = "AuteursjabBindingNavigatorSaveItem"
        Me.AuteursjabBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.AuteursjabBindingNavigatorSaveItem.Text = "Save Data"
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
        'SjablonenpadTextBox
        '
        Me.SjablonenpadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuteursjabBindingSource, "Sjablonenpad", True))
        Me.SjablonenpadTextBox.Location = New System.Drawing.Point(97, 114)
        Me.SjablonenpadTextBox.Name = "SjablonenpadTextBox"
        Me.SjablonenpadTextBox.Size = New System.Drawing.Size(559, 20)
        Me.SjablonenpadTextBox.TabIndex = 2
        '
        'OpslagpadTextBox
        '
        Me.OpslagpadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuteursjabBindingSource, "Opslagpad", True))
        Me.OpslagpadTextBox.Location = New System.Drawing.Point(97, 140)
        Me.OpslagpadTextBox.Name = "OpslagpadTextBox"
        Me.OpslagpadTextBox.Size = New System.Drawing.Size(559, 20)
        Me.OpslagpadTextBox.TabIndex = 3
        '
        'DBDocumentenDataSet
        '
        Me.DBDocumentenDataSet.DataSetName = "DBDocumentenDataSet"
        Me.DBDocumentenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AuteuridComboBox
        '
        Me.AuteuridComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuteursjabBindingSource, "Auteurid", True))
        Me.AuteuridComboBox.DataSource = Me.AuteursBindingSource
        Me.AuteuridComboBox.DisplayMember = "AuteurID"
        Me.AuteuridComboBox.FormattingEnabled = True
        Me.AuteuridComboBox.Location = New System.Drawing.Point(97, 85)
        Me.AuteuridComboBox.Name = "AuteuridComboBox"
        Me.AuteuridComboBox.Size = New System.Drawing.Size(211, 21)
        Me.AuteuridComboBox.TabIndex = 0
        Me.AuteuridComboBox.ValueMember = "AuteurID"
        '
        'AuteursBindingSource
        '
        Me.AuteursBindingSource.DataMember = "Auteurs"
        Me.AuteursBindingSource.DataSource = Me.DBDocumentenDataSet
        '
        'Auteursjab_IDLabel1
        '
        Me.Auteursjab_IDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuteursjabBindingSource, "Auteursjab_ID", True))
        Me.Auteursjab_IDLabel1.Location = New System.Drawing.Point(97, 58)
        Me.Auteursjab_IDLabel1.Name = "Auteursjab_IDLabel1"
        Me.Auteursjab_IDLabel1.Size = New System.Drawing.Size(112, 23)
        Me.Auteursjab_IDLabel1.TabIndex = 14
        Me.Auteursjab_IDLabel1.Text = "Label1"
        '
        'AuteursTableAdapter
        '
        Me.AuteursTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(413, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(401, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Voor iedere auteur minimum 1 afzender maken. (Automatische opslag)"
        '
        'OpslagBrowseButton
        '
        Me.OpslagBrowseButton.Location = New System.Drawing.Point(662, 139)
        Me.OpslagBrowseButton.Name = "OpslagBrowseButton"
        Me.OpslagBrowseButton.Size = New System.Drawing.Size(75, 23)
        Me.OpslagBrowseButton.TabIndex = 20
        Me.OpslagBrowseButton.Text = "Browse"
        Me.OpslagBrowseButton.UseVisualStyleBackColor = True
        '
        'SjoblonenBrowseButton
        '
        Me.SjoblonenBrowseButton.Location = New System.Drawing.Point(662, 111)
        Me.SjoblonenBrowseButton.Name = "SjoblonenBrowseButton"
        Me.SjoblonenBrowseButton.Size = New System.Drawing.Size(75, 23)
        Me.SjoblonenBrowseButton.TabIndex = 19
        Me.SjoblonenBrowseButton.Text = "Browse"
        Me.SjoblonenBrowseButton.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'DtsSjabloonNewBindingSource
        '
        Me.DtsSjabloonNewBindingSource.DataSource = Me.DtsSjabloonNew
        Me.DtsSjabloonNewBindingSource.Position = 0
        '
        'AuteursjabBindingSource1
        '
        Me.AuteursjabBindingSource1.DataMember = "Auteursjab"
        Me.AuteursjabBindingSource1.DataSource = Me.DBDocumentenDataSet
        '
        'AuteursjabTableAdapter1
        '
        Me.AuteursjabTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.AuteursjabTableAdapter = Me.AuteursjabTableAdapter1
        Me.TableAdapterManager1.AuteursTableAdapter = Me.AuteursTableAdapter
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.BestemmelingTableAdapter = Nothing
        Me.TableAdapterManager1.CodeTableAdapter = Nothing
        Me.TableAdapterManager1.DienstenTableAdapter = Nothing
        Me.TableAdapterManager1.InstellingenTableAdapter = Nothing
        Me.TableAdapterManager1.SAV_DocumentenTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = DM.DBDocumentenDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AuteursjabDataGridView
        '
        Me.AuteursjabDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AuteursjabDataGridView.AutoGenerateColumns = False
        Me.AuteursjabDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AuteursjabDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.AuteursjabDataGridView.DataSource = Me.AuteursjabBindingSource
        Me.AuteursjabDataGridView.Location = New System.Drawing.Point(20, 339)
        Me.AuteursjabDataGridView.Name = "AuteursjabDataGridView"
        Me.AuteursjabDataGridView.Size = New System.Drawing.Size(828, 269)
        Me.AuteursjabDataGridView.TabIndex = 22
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Auteursjab_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Auteursjab_ID"
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
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Sjablonenpad"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Sjablonenpad"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Opslagpad"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Opslagpad"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Afzender"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Afzender"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Afzender_tekst"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Afzender_tekst"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'AfzenderTextBox
        '
        Me.AfzenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuteursjabBindingSource, "Afzender", True))
        Me.AfzenderTextBox.Location = New System.Drawing.Point(97, 166)
        Me.AfzenderTextBox.Name = "AfzenderTextBox"
        Me.AfzenderTextBox.Size = New System.Drawing.Size(354, 20)
        Me.AfzenderTextBox.TabIndex = 23
        '
        'Afzender_tekstTextBox
        '
        Me.Afzender_tekstTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuteursjabBindingSource, "Afzender_tekst", True))
        Me.Afzender_tekstTextBox.Location = New System.Drawing.Point(97, 192)
        Me.Afzender_tekstTextBox.Multiline = True
        Me.Afzender_tekstTextBox.Name = "Afzender_tekstTextBox"
        Me.Afzender_tekstTextBox.Size = New System.Drawing.Size(354, 141)
        Me.Afzender_tekstTextBox.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(478, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(245, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Beschrijving van de afzender (te zien in de combo)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(478, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(292, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Tekst die verschijnt op de brief als hoofding van de afzender"
        '
        'AuteurSjabloon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 620)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Afzender_tekstLabel)
        Me.Controls.Add(Me.Afzender_tekstTextBox)
        Me.Controls.Add(AfzenderLabel)
        Me.Controls.Add(Me.AfzenderTextBox)
        Me.Controls.Add(Me.AuteursjabDataGridView)
        Me.Controls.Add(Me.OpslagBrowseButton)
        Me.Controls.Add(Me.SjoblonenBrowseButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Auteursjab_IDLabel)
        Me.Controls.Add(Me.Auteursjab_IDLabel1)
        Me.Controls.Add(AuteuridLabel)
        Me.Controls.Add(Me.AuteuridComboBox)
        Me.Controls.Add(OpslagpadLabel)
        Me.Controls.Add(Me.OpslagpadTextBox)
        Me.Controls.Add(SjablonenpadLabel)
        Me.Controls.Add(Me.SjablonenpadTextBox)
        Me.Controls.Add(Me.AuteursjabBindingNavigator)
        Me.Name = "AuteurSjabloon"
        Me.Text = "AuteurSjabloon"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DtsSjabloonNew, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuteursjabBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuteursjabBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AuteursjabBindingNavigator.ResumeLayout(False)
        Me.AuteursjabBindingNavigator.PerformLayout()
        CType(Me.DBDocumentenDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuteursBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtsSjabloonNewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuteursjabBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuteursjabDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DtsSjabloonNew As DM.dtsSjabloonNew
    Friend WithEvents AuteursjabBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AuteursjabTableAdapter As DM.dtsSjabloonNewTableAdapters.AuteursjabTableAdapter
    Friend WithEvents TableAdapterManager As DM.dtsSjabloonNewTableAdapters.TableAdapterManager
    Friend WithEvents AuteursjabBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents AuteursjabBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents SjablonenpadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OpslagpadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DBDocumentenDataSet As DM.DBDocumentenDataSet
    Friend WithEvents AuteuridComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Auteursjab_IDLabel1 As System.Windows.Forms.Label
    Friend WithEvents AuteursBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AuteursTableAdapter As DM.DBDocumentenDataSetTableAdapters.AuteursTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OpslagBrowseButton As System.Windows.Forms.Button
    Friend WithEvents SjoblonenBrowseButton As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents DtsSjabloonNewBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SluitenButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents AuteursjabBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents AuteursjabTableAdapter1 As DM.DBDocumentenDataSetTableAdapters.AuteursjabTableAdapter
    Friend WithEvents TableAdapterManager1 As DM.DBDocumentenDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AuteursjabDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents AfzenderTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Afzender_tekstTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
