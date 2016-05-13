<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Codes
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
        Dim Code_idLabel As System.Windows.Forms.Label
        Dim CodeLabel As System.Windows.Forms.Label
        Dim CodetekstLabel As System.Windows.Forms.Label
        Dim SjablonenpadLabel As System.Windows.Forms.Label
        Dim AuteurLabel As System.Windows.Forms.Label
        Dim BM_afzenderLabel As System.Windows.Forms.Label
        Dim BM_geadresseerdeLabel As System.Windows.Forms.Label
        Dim BM_typeLabel As System.Windows.Forms.Label
        Dim BM_uwberichtLabel As System.Windows.Forms.Label
        Dim BM_uwkenmerkLabel As System.Windows.Forms.Label
        Dim BM_onskenmerkLabel As System.Windows.Forms.Label
        Dim BM_datumLabel As System.Windows.Forms.Label
        Dim BM_onderwerpLabel As System.Windows.Forms.Label
        Dim BM_startdocumentLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Codes))
        Me.DtsSjabloonNew = New DM.dtsSjabloonNew()
        Me.CodeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CodeTableAdapter = New DM.dtsSjabloonNewTableAdapters.CodeTableAdapter()
        Me.TableAdapterManager = New DM.dtsSjabloonNewTableAdapters.TableAdapterManager()
        Me.AuteursTableAdapter = New DM.dtsSjabloonNewTableAdapters.AuteursTableAdapter()
        Me.CodeBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
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
        Me.CodeBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.Code_idLabel1 = New System.Windows.Forms.Label()
        Me.CodeTextBox = New System.Windows.Forms.TextBox()
        Me.CodetekstTextBox = New System.Windows.Forms.TextBox()
        Me.SjablonenpadTextBox = New System.Windows.Forms.TextBox()
        Me.AuteursBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SjabloonpadBtn = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CodeBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AuteurComboBox = New System.Windows.Forms.ComboBox()
        Me.BM_afzenderCheckBox = New System.Windows.Forms.CheckBox()
        Me.BM_geadresseerdeCheckBox = New System.Windows.Forms.CheckBox()
        Me.BM_typeCheckBox = New System.Windows.Forms.CheckBox()
        Me.BM_uwberichtCheckBox = New System.Windows.Forms.CheckBox()
        Me.BM_uwkenmerkCheckBox = New System.Windows.Forms.CheckBox()
        Me.BM_onskenmerkCheckBox = New System.Windows.Forms.CheckBox()
        Me.BM_datumCheckBox = New System.Windows.Forms.CheckBox()
        Me.BM_onderwerpCheckBox = New System.Windows.Forms.CheckBox()
        Me.BM_startdocumentCheckBox = New System.Windows.Forms.CheckBox()
        Me.CodeDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn3 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn4 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn5 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn6 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn7 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn8 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn9 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Bookmark_lbl = New System.Windows.Forms.Label()
        Code_idLabel = New System.Windows.Forms.Label()
        CodeLabel = New System.Windows.Forms.Label()
        CodetekstLabel = New System.Windows.Forms.Label()
        SjablonenpadLabel = New System.Windows.Forms.Label()
        AuteurLabel = New System.Windows.Forms.Label()
        BM_afzenderLabel = New System.Windows.Forms.Label()
        BM_geadresseerdeLabel = New System.Windows.Forms.Label()
        BM_typeLabel = New System.Windows.Forms.Label()
        BM_uwberichtLabel = New System.Windows.Forms.Label()
        BM_uwkenmerkLabel = New System.Windows.Forms.Label()
        BM_onskenmerkLabel = New System.Windows.Forms.Label()
        BM_datumLabel = New System.Windows.Forms.Label()
        BM_onderwerpLabel = New System.Windows.Forms.Label()
        BM_startdocumentLabel = New System.Windows.Forms.Label()
        CType(Me.DtsSjabloonNew, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodeBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CodeBindingNavigator.SuspendLayout()
        CType(Me.AuteursBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodeBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Code_idLabel
        '
        Code_idLabel.AutoSize = True
        Code_idLabel.Location = New System.Drawing.Point(34, 49)
        Code_idLabel.Name = "Code_idLabel"
        Code_idLabel.Size = New System.Drawing.Size(46, 13)
        Code_idLabel.TabIndex = 2
        Code_idLabel.Text = "Code id:"
        '
        'CodeLabel
        '
        CodeLabel.AutoSize = True
        CodeLabel.Location = New System.Drawing.Point(48, 78)
        CodeLabel.Name = "CodeLabel"
        CodeLabel.Size = New System.Drawing.Size(35, 13)
        CodeLabel.TabIndex = 4
        CodeLabel.Text = "Code:"
        '
        'CodetekstLabel
        '
        CodetekstLabel.AutoSize = True
        CodetekstLabel.Location = New System.Drawing.Point(25, 104)
        CodetekstLabel.Name = "CodetekstLabel"
        CodetekstLabel.Size = New System.Drawing.Size(58, 13)
        CodetekstLabel.TabIndex = 6
        CodetekstLabel.Text = "Codetekst:"
        '
        'SjablonenpadLabel
        '
        SjablonenpadLabel.AutoSize = True
        SjablonenpadLabel.Location = New System.Drawing.Point(8, 130)
        SjablonenpadLabel.Name = "SjablonenpadLabel"
        SjablonenpadLabel.Size = New System.Drawing.Size(75, 13)
        SjablonenpadLabel.TabIndex = 8
        SjablonenpadLabel.Text = "Sjablonenpad:"
        '
        'AuteurLabel
        '
        AuteurLabel.AutoSize = True
        AuteurLabel.Location = New System.Drawing.Point(42, 158)
        AuteurLabel.Name = "AuteurLabel"
        AuteurLabel.Size = New System.Drawing.Size(41, 13)
        AuteurLabel.TabIndex = 13
        AuteurLabel.Text = "Auteur:"
        '
        'BM_afzenderLabel
        '
        BM_afzenderLabel.AutoSize = True
        BM_afzenderLabel.Location = New System.Drawing.Point(25, 218)
        BM_afzenderLabel.Name = "BM_afzenderLabel"
        BM_afzenderLabel.Size = New System.Drawing.Size(70, 13)
        BM_afzenderLabel.TabIndex = 14
        BM_afzenderLabel.Text = "BM afzender:"
        '
        'BM_geadresseerdeLabel
        '
        BM_geadresseerdeLabel.AutoSize = True
        BM_geadresseerdeLabel.Location = New System.Drawing.Point(150, 218)
        BM_geadresseerdeLabel.Name = "BM_geadresseerdeLabel"
        BM_geadresseerdeLabel.Size = New System.Drawing.Size(99, 13)
        BM_geadresseerdeLabel.TabIndex = 15
        BM_geadresseerdeLabel.Text = "BM geadresseerde:"
        '
        'BM_typeLabel
        '
        BM_typeLabel.AutoSize = True
        BM_typeLabel.Location = New System.Drawing.Point(318, 218)
        BM_typeLabel.Name = "BM_typeLabel"
        BM_typeLabel.Size = New System.Drawing.Size(49, 13)
        BM_typeLabel.TabIndex = 17
        BM_typeLabel.Text = "BM type:"
        '
        'BM_uwberichtLabel
        '
        BM_uwberichtLabel.AutoSize = True
        BM_uwberichtLabel.Location = New System.Drawing.Point(419, 218)
        BM_uwberichtLabel.Name = "BM_uwberichtLabel"
        BM_uwberichtLabel.Size = New System.Drawing.Size(75, 13)
        BM_uwberichtLabel.TabIndex = 19
        BM_uwberichtLabel.Text = "BM uwbericht:"
        '
        'BM_uwkenmerkLabel
        '
        BM_uwkenmerkLabel.AutoSize = True
        BM_uwkenmerkLabel.Location = New System.Drawing.Point(559, 218)
        BM_uwkenmerkLabel.Name = "BM_uwkenmerkLabel"
        BM_uwkenmerkLabel.Size = New System.Drawing.Size(84, 13)
        BM_uwkenmerkLabel.TabIndex = 21
        BM_uwkenmerkLabel.Text = "BM uwkenmerk:"
        '
        'BM_onskenmerkLabel
        '
        BM_onskenmerkLabel.AutoSize = True
        BM_onskenmerkLabel.Location = New System.Drawing.Point(11, 248)
        BM_onskenmerkLabel.Name = "BM_onskenmerkLabel"
        BM_onskenmerkLabel.Size = New System.Drawing.Size(87, 13)
        BM_onskenmerkLabel.TabIndex = 23
        BM_onskenmerkLabel.Text = "BM onskenmerk:"
        '
        'BM_datumLabel
        '
        BM_datumLabel.AutoSize = True
        BM_datumLabel.Location = New System.Drawing.Point(192, 248)
        BM_datumLabel.Name = "BM_datumLabel"
        BM_datumLabel.Size = New System.Drawing.Size(58, 13)
        BM_datumLabel.TabIndex = 25
        BM_datumLabel.Text = "BM datum:"
        '
        'BM_onderwerpLabel
        '
        BM_onderwerpLabel.AutoSize = True
        BM_onderwerpLabel.Location = New System.Drawing.Point(288, 248)
        BM_onderwerpLabel.Name = "BM_onderwerpLabel"
        BM_onderwerpLabel.Size = New System.Drawing.Size(79, 13)
        BM_onderwerpLabel.TabIndex = 27
        BM_onderwerpLabel.Text = "BM onderwerp:"
        '
        'BM_startdocumentLabel
        '
        BM_startdocumentLabel.AutoSize = True
        BM_startdocumentLabel.Location = New System.Drawing.Point(398, 248)
        BM_startdocumentLabel.Name = "BM_startdocumentLabel"
        BM_startdocumentLabel.Size = New System.Drawing.Size(96, 13)
        BM_startdocumentLabel.TabIndex = 29
        BM_startdocumentLabel.Text = "BM startdocument:"
        '
        'DtsSjabloonNew
        '
        Me.DtsSjabloonNew.DataSetName = "dtsSjabloonNew"
        Me.DtsSjabloonNew.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CodeBindingSource
        '
        Me.CodeBindingSource.DataMember = "Code"
        Me.CodeBindingSource.DataSource = Me.DtsSjabloonNew
        '
        'CodeTableAdapter
        '
        Me.CodeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AuteursjabTableAdapter = Nothing
        Me.TableAdapterManager.AuteursTableAdapter = Me.AuteursTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CodeTableAdapter = Me.CodeTableAdapter
        Me.TableAdapterManager.UpdateOrder = DM.dtsSjabloonNewTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AuteursTableAdapter
        '
        Me.AuteursTableAdapter.ClearBeforeFill = True
        '
        'CodeBindingNavigator
        '
        Me.CodeBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CodeBindingNavigator.BindingSource = Me.CodeBindingSource
        Me.CodeBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CodeBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CodeBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CodeBindingNavigatorSaveItem, Me.ToolStripButton1})
        Me.CodeBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CodeBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CodeBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CodeBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CodeBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CodeBindingNavigator.Name = "CodeBindingNavigator"
        Me.CodeBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CodeBindingNavigator.Size = New System.Drawing.Size(928, 25)
        Me.CodeBindingNavigator.TabIndex = 0
        Me.CodeBindingNavigator.Text = "BindingNavigator1"
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
        'CodeBindingNavigatorSaveItem
        '
        Me.CodeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CodeBindingNavigatorSaveItem.Image = CType(resources.GetObject("CodeBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CodeBindingNavigatorSaveItem.Name = "CodeBindingNavigatorSaveItem"
        Me.CodeBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CodeBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(47, 22)
        Me.ToolStripButton1.Text = "Sluiten"
        '
        'Code_idLabel1
        '
        Me.Code_idLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CodeBindingSource, "Code_id", True))
        Me.Code_idLabel1.Location = New System.Drawing.Point(86, 49)
        Me.Code_idLabel1.Name = "Code_idLabel1"
        Me.Code_idLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Code_idLabel1.TabIndex = 3
        Me.Code_idLabel1.Text = "Label1"
        '
        'CodeTextBox
        '
        Me.CodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CodeBindingSource, "Code", True))
        Me.CodeTextBox.Location = New System.Drawing.Point(89, 75)
        Me.CodeTextBox.Name = "CodeTextBox"
        Me.CodeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CodeTextBox.TabIndex = 5
        '
        'CodetekstTextBox
        '
        Me.CodetekstTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CodeBindingSource, "Codetekst", True))
        Me.CodetekstTextBox.Location = New System.Drawing.Point(89, 101)
        Me.CodetekstTextBox.Name = "CodetekstTextBox"
        Me.CodetekstTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CodetekstTextBox.TabIndex = 7
        '
        'SjablonenpadTextBox
        '
        Me.SjablonenpadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CodeBindingSource, "Sjablonenpad", True))
        Me.SjablonenpadTextBox.Location = New System.Drawing.Point(89, 127)
        Me.SjablonenpadTextBox.Name = "SjablonenpadTextBox"
        Me.SjablonenpadTextBox.Size = New System.Drawing.Size(492, 20)
        Me.SjablonenpadTextBox.TabIndex = 9
        '
        'AuteursBindingSource
        '
        Me.AuteursBindingSource.DataMember = "Auteurs"
        Me.AuteursBindingSource.DataSource = Me.DtsSjabloonNew
        '
        'SjabloonpadBtn
        '
        Me.SjabloonpadBtn.Location = New System.Drawing.Point(587, 125)
        Me.SjabloonpadBtn.Name = "SjabloonpadBtn"
        Me.SjabloonpadBtn.Size = New System.Drawing.Size(75, 23)
        Me.SjabloonpadBtn.TabIndex = 11
        Me.SjabloonpadBtn.Text = "Browse"
        Me.SjabloonpadBtn.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(225, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(302, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Voor welke auteur is dit ook zichtbaar (kies ALL voor iedereen)"
        '
        'CodeBindingSource1
        '
        Me.CodeBindingSource1.DataMember = "Auteurs_Code"
        Me.CodeBindingSource1.DataSource = Me.AuteursBindingSource
        '
        'AuteurComboBox
        '
        Me.AuteurComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CodeBindingSource, "Auteur_id", True))
        Me.AuteurComboBox.DataSource = Me.AuteursBindingSource
        Me.AuteurComboBox.DisplayMember = "AuteurID"
        Me.AuteurComboBox.FormattingEnabled = True
        Me.AuteurComboBox.Location = New System.Drawing.Point(89, 155)
        Me.AuteurComboBox.Name = "AuteurComboBox"
        Me.AuteurComboBox.Size = New System.Drawing.Size(121, 21)
        Me.AuteurComboBox.TabIndex = 14
        Me.AuteurComboBox.ValueMember = "AuteurID"
        '
        'BM_afzenderCheckBox
        '
        Me.BM_afzenderCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CodeBindingSource, "BM_afzender", True))
        Me.BM_afzenderCheckBox.Location = New System.Drawing.Point(104, 213)
        Me.BM_afzenderCheckBox.Name = "BM_afzenderCheckBox"
        Me.BM_afzenderCheckBox.Size = New System.Drawing.Size(35, 24)
        Me.BM_afzenderCheckBox.TabIndex = 15
        Me.BM_afzenderCheckBox.UseVisualStyleBackColor = True
        '
        'BM_geadresseerdeCheckBox
        '
        Me.BM_geadresseerdeCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CodeBindingSource, "BM_geadresseerde", True))
        Me.BM_geadresseerdeCheckBox.Location = New System.Drawing.Point(255, 213)
        Me.BM_geadresseerdeCheckBox.Name = "BM_geadresseerdeCheckBox"
        Me.BM_geadresseerdeCheckBox.Size = New System.Drawing.Size(27, 24)
        Me.BM_geadresseerdeCheckBox.TabIndex = 16
        Me.BM_geadresseerdeCheckBox.UseVisualStyleBackColor = True
        '
        'BM_typeCheckBox
        '
        Me.BM_typeCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CodeBindingSource, "BM_type", True))
        Me.BM_typeCheckBox.Location = New System.Drawing.Point(373, 213)
        Me.BM_typeCheckBox.Name = "BM_typeCheckBox"
        Me.BM_typeCheckBox.Size = New System.Drawing.Size(29, 24)
        Me.BM_typeCheckBox.TabIndex = 18
        Me.BM_typeCheckBox.UseVisualStyleBackColor = True
        '
        'BM_uwberichtCheckBox
        '
        Me.BM_uwberichtCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CodeBindingSource, "BM_uwbericht", True))
        Me.BM_uwberichtCheckBox.Location = New System.Drawing.Point(500, 213)
        Me.BM_uwberichtCheckBox.Name = "BM_uwberichtCheckBox"
        Me.BM_uwberichtCheckBox.Size = New System.Drawing.Size(27, 24)
        Me.BM_uwberichtCheckBox.TabIndex = 20
        Me.BM_uwberichtCheckBox.UseVisualStyleBackColor = True
        '
        'BM_uwkenmerkCheckBox
        '
        Me.BM_uwkenmerkCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CodeBindingSource, "BM_uwkenmerk", True))
        Me.BM_uwkenmerkCheckBox.Location = New System.Drawing.Point(649, 213)
        Me.BM_uwkenmerkCheckBox.Name = "BM_uwkenmerkCheckBox"
        Me.BM_uwkenmerkCheckBox.Size = New System.Drawing.Size(39, 24)
        Me.BM_uwkenmerkCheckBox.TabIndex = 22
        Me.BM_uwkenmerkCheckBox.UseVisualStyleBackColor = True
        '
        'BM_onskenmerkCheckBox
        '
        Me.BM_onskenmerkCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CodeBindingSource, "BM_onskenmerk", True))
        Me.BM_onskenmerkCheckBox.Location = New System.Drawing.Point(104, 243)
        Me.BM_onskenmerkCheckBox.Name = "BM_onskenmerkCheckBox"
        Me.BM_onskenmerkCheckBox.Size = New System.Drawing.Size(27, 24)
        Me.BM_onskenmerkCheckBox.TabIndex = 24
        Me.BM_onskenmerkCheckBox.UseVisualStyleBackColor = True
        '
        'BM_datumCheckBox
        '
        Me.BM_datumCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CodeBindingSource, "BM_datum", True))
        Me.BM_datumCheckBox.Location = New System.Drawing.Point(256, 243)
        Me.BM_datumCheckBox.Name = "BM_datumCheckBox"
        Me.BM_datumCheckBox.Size = New System.Drawing.Size(26, 24)
        Me.BM_datumCheckBox.TabIndex = 26
        Me.BM_datumCheckBox.UseVisualStyleBackColor = True
        '
        'BM_onderwerpCheckBox
        '
        Me.BM_onderwerpCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CodeBindingSource, "BM_onderwerp", True))
        Me.BM_onderwerpCheckBox.Location = New System.Drawing.Point(373, 243)
        Me.BM_onderwerpCheckBox.Name = "BM_onderwerpCheckBox"
        Me.BM_onderwerpCheckBox.Size = New System.Drawing.Size(40, 24)
        Me.BM_onderwerpCheckBox.TabIndex = 28
        Me.BM_onderwerpCheckBox.UseVisualStyleBackColor = True
        '
        'BM_startdocumentCheckBox
        '
        Me.BM_startdocumentCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CodeBindingSource, "BM_startdocument", True))
        Me.BM_startdocumentCheckBox.Location = New System.Drawing.Point(500, 243)
        Me.BM_startdocumentCheckBox.Name = "BM_startdocumentCheckBox"
        Me.BM_startdocumentCheckBox.Size = New System.Drawing.Size(27, 24)
        Me.BM_startdocumentCheckBox.TabIndex = 30
        Me.BM_startdocumentCheckBox.UseVisualStyleBackColor = True
        '
        'CodeDataGridView
        '
        Me.CodeDataGridView.AutoGenerateColumns = False
        Me.CodeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CodeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewCheckBoxColumn2, Me.DataGridViewCheckBoxColumn3, Me.DataGridViewCheckBoxColumn4, Me.DataGridViewCheckBoxColumn5, Me.DataGridViewCheckBoxColumn6, Me.DataGridViewCheckBoxColumn7, Me.DataGridViewCheckBoxColumn8, Me.DataGridViewCheckBoxColumn9})
        Me.CodeDataGridView.DataSource = Me.CodeBindingSource
        Me.CodeDataGridView.Location = New System.Drawing.Point(11, 289)
        Me.CodeDataGridView.Name = "CodeDataGridView"
        Me.CodeDataGridView.Size = New System.Drawing.Size(905, 274)
        Me.CodeDataGridView.TabIndex = 31
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Code_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Code_id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 71
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Code"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Code"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 57
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Codetekst"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Codetekst"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Sjablonenpad"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Sjablonenpad"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 97
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Auteur_id"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Auteur_id"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "BM_afzender"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "BM_afzender"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Width = 76
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "BM_geadresseerde"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "BM_geadresseerde"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.Width = 105
        '
        'DataGridViewCheckBoxColumn3
        '
        Me.DataGridViewCheckBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewCheckBoxColumn3.DataPropertyName = "BM_type"
        Me.DataGridViewCheckBoxColumn3.HeaderText = "BM_type"
        Me.DataGridViewCheckBoxColumn3.Name = "DataGridViewCheckBoxColumn3"
        Me.DataGridViewCheckBoxColumn3.Width = 55
        '
        'DataGridViewCheckBoxColumn4
        '
        Me.DataGridViewCheckBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewCheckBoxColumn4.DataPropertyName = "BM_uwbericht"
        Me.DataGridViewCheckBoxColumn4.HeaderText = "BM_uwbericht"
        Me.DataGridViewCheckBoxColumn4.Name = "DataGridViewCheckBoxColumn4"
        Me.DataGridViewCheckBoxColumn4.Width = 81
        '
        'DataGridViewCheckBoxColumn5
        '
        Me.DataGridViewCheckBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewCheckBoxColumn5.DataPropertyName = "BM_uwkenmerk"
        Me.DataGridViewCheckBoxColumn5.HeaderText = "BM_uwkenmerk"
        Me.DataGridViewCheckBoxColumn5.Name = "DataGridViewCheckBoxColumn5"
        Me.DataGridViewCheckBoxColumn5.Width = 90
        '
        'DataGridViewCheckBoxColumn6
        '
        Me.DataGridViewCheckBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewCheckBoxColumn6.DataPropertyName = "BM_onskenmerk"
        Me.DataGridViewCheckBoxColumn6.HeaderText = "BM_onskenmerk"
        Me.DataGridViewCheckBoxColumn6.Name = "DataGridViewCheckBoxColumn6"
        Me.DataGridViewCheckBoxColumn6.Width = 93
        '
        'DataGridViewCheckBoxColumn7
        '
        Me.DataGridViewCheckBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewCheckBoxColumn7.DataPropertyName = "BM_datum"
        Me.DataGridViewCheckBoxColumn7.HeaderText = "BM_datum"
        Me.DataGridViewCheckBoxColumn7.Name = "DataGridViewCheckBoxColumn7"
        Me.DataGridViewCheckBoxColumn7.Width = 64
        '
        'DataGridViewCheckBoxColumn8
        '
        Me.DataGridViewCheckBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewCheckBoxColumn8.DataPropertyName = "BM_onderwerp"
        Me.DataGridViewCheckBoxColumn8.HeaderText = "BM_onderwerp"
        Me.DataGridViewCheckBoxColumn8.Name = "DataGridViewCheckBoxColumn8"
        Me.DataGridViewCheckBoxColumn8.Width = 85
        '
        'DataGridViewCheckBoxColumn9
        '
        Me.DataGridViewCheckBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewCheckBoxColumn9.DataPropertyName = "BM_startdocument"
        Me.DataGridViewCheckBoxColumn9.HeaderText = "BM_startdocument"
        Me.DataGridViewCheckBoxColumn9.Name = "DataGridViewCheckBoxColumn9"
        Me.DataGridViewCheckBoxColumn9.Width = 102
        '
        'Bookmark_lbl
        '
        Me.Bookmark_lbl.AutoSize = True
        Me.Bookmark_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bookmark_lbl.Location = New System.Drawing.Point(25, 197)
        Me.Bookmark_lbl.Name = "Bookmark_lbl"
        Me.Bookmark_lbl.Size = New System.Drawing.Size(293, 13)
        Me.Bookmark_lbl.TabIndex = 32
        Me.Bookmark_lbl.Text = "Bookmark's op document activeren/desactiveren :"
        '
        'Codes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(928, 575)
        Me.Controls.Add(Me.Bookmark_lbl)
        Me.Controls.Add(Me.CodeDataGridView)
        Me.Controls.Add(BM_startdocumentLabel)
        Me.Controls.Add(Me.BM_startdocumentCheckBox)
        Me.Controls.Add(BM_onderwerpLabel)
        Me.Controls.Add(Me.BM_onderwerpCheckBox)
        Me.Controls.Add(BM_datumLabel)
        Me.Controls.Add(Me.BM_datumCheckBox)
        Me.Controls.Add(BM_onskenmerkLabel)
        Me.Controls.Add(Me.BM_onskenmerkCheckBox)
        Me.Controls.Add(BM_uwkenmerkLabel)
        Me.Controls.Add(Me.BM_uwkenmerkCheckBox)
        Me.Controls.Add(BM_uwberichtLabel)
        Me.Controls.Add(Me.BM_uwberichtCheckBox)
        Me.Controls.Add(BM_typeLabel)
        Me.Controls.Add(Me.BM_typeCheckBox)
        Me.Controls.Add(BM_geadresseerdeLabel)
        Me.Controls.Add(Me.BM_geadresseerdeCheckBox)
        Me.Controls.Add(BM_afzenderLabel)
        Me.Controls.Add(Me.BM_afzenderCheckBox)
        Me.Controls.Add(AuteurLabel)
        Me.Controls.Add(Me.AuteurComboBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SjabloonpadBtn)
        Me.Controls.Add(SjablonenpadLabel)
        Me.Controls.Add(Me.SjablonenpadTextBox)
        Me.Controls.Add(CodetekstLabel)
        Me.Controls.Add(Me.CodetekstTextBox)
        Me.Controls.Add(CodeLabel)
        Me.Controls.Add(Me.CodeTextBox)
        Me.Controls.Add(Code_idLabel)
        Me.Controls.Add(Me.Code_idLabel1)
        Me.Controls.Add(Me.CodeBindingNavigator)
        Me.Name = "Codes"
        Me.Text = "Codes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DtsSjabloonNew, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodeBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CodeBindingNavigator.ResumeLayout(False)
        Me.CodeBindingNavigator.PerformLayout()
        CType(Me.AuteursBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodeBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DtsSjabloonNew As DM.dtsSjabloonNew
    Friend WithEvents CodeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CodeTableAdapter As DM.dtsSjabloonNewTableAdapters.CodeTableAdapter
    Friend WithEvents TableAdapterManager As DM.dtsSjabloonNewTableAdapters.TableAdapterManager
    Friend WithEvents CodeBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents CodeBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents AuteursTableAdapter As DM.dtsSjabloonNewTableAdapters.AuteursTableAdapter
    Friend WithEvents Code_idLabel1 As System.Windows.Forms.Label
    Friend WithEvents CodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CodetekstTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SjablonenpadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AuteursBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SjabloonpadBtn As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CodeBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents AuteurComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BM_afzenderCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents BM_geadresseerdeCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents BM_typeCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents BM_uwberichtCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents BM_uwkenmerkCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents BM_onskenmerkCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents BM_datumCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents BM_onderwerpCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents BM_startdocumentCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents CodeDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Bookmark_lbl As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn3 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn4 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn5 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn6 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn7 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn8 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn9 As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
