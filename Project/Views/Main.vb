Imports System.IO
Imports System.Data.SqlClient
Imports System.Configuration

Public Class Main
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub
    Private WithEvents TabControl As System.Windows.Forms.TabControl
    Private WithEvents TabPageNieuw As System.Windows.Forms.TabPage
    Friend WithEvents LblTitel As System.Windows.Forms.Label
    Friend WithEvents TxtTitel As System.Windows.Forms.TextBox
    Friend WithEvents LblSjabloon As System.Windows.Forms.Label
    Friend WithEvents txtSjabloonPad As System.Windows.Forms.TextBox
    Friend WithEvents LbLAuteur As System.Windows.Forms.Label
    Friend WithEvents LblCode As System.Windows.Forms.Label
    Friend WithEvents LblOpslag As System.Windows.Forms.Label
    Private WithEvents txtOpslagPad As System.Windows.Forms.TextBox
    Private WithEvents btnOpslagPadBrowse As System.Windows.Forms.Button
    Friend WithEvents LblTrefwoord As System.Windows.Forms.Label
    Friend WithEvents TxtTrefwoord As System.Windows.Forms.TextBox
    Friend WithEvents LblDatum_doc As System.Windows.Forms.Label
    Friend WithEvents DateDoc As System.Windows.Forms.DateTimePicker
    Friend WithEvents SAVDocumentenBindingSource As System.Windows.Forms.BindingSource

    Friend WithEvents DsVolgnrBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SAVTellerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SAVTellerBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents LblAfzender As System.Windows.Forms.Label
    Friend WithEvents TellerDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabPageConfiguratie As System.Windows.Forms.TabPage

    Friend WithEvents SAV_DocumentenBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ToonLijst As System.Windows.Forms.Button
    Private WithEvents dtsDocumentenDB As DM.DBDocumentenDataSet
    Friend WithEvents CodeBindingSource As System.Windows.Forms.BindingSource
    Private WithEvents CodeTableAdapter As DM.DBDocumentenDataSetTableAdapters.CodeTableAdapter
    Friend WithEvents AuteursBindingSource As System.Windows.Forms.BindingSource
    Private WithEvents tbaAuteurs As DM.DBDocumentenDataSetTableAdapters.AuteursTableAdapter
    Friend WithEvents SAV_DocumentenBindingSource1 As System.Windows.Forms.BindingSource
    Private WithEvents tbaDocumenten As DM.DBDocumentenDataSetTableAdapters.SAV_DocumentenTableAdapter
    Friend WithEvents AuteurssjablonenButton As System.Windows.Forms.Button
    Friend WithEvents AuteursButton As System.Windows.Forms.Button
    Private WithEvents DtsSjabloon As DM.dtsSjabloon
    Friend WithEvents AuteursBindingSource1 As System.Windows.Forms.BindingSource
    Private WithEvents TableAdapterManager As DM.dtsSjabloonTableAdapters.TableAdapterManager
    Friend WithEvents DtsSjabloonBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AuteursBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents DBDocumentenDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DBDocumentenDataSetBindingSource1 As System.Windows.Forms.BindingSource
    Private WithEvents DtsDocs As DM.dtsDocs
    Friend WithEvents SAV_DocumentenBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents CodeBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents AuteursBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents AuteursjabBindingSource As System.Windows.Forms.BindingSource
    Private WithEvents tbaAuteursjab As DM.dtsSjabloonTableAdapters.AuteursjabTableAdapter
    Friend WithEvents mtgccboAfzender As MTGCComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnVoorkeurOpslaan As System.Windows.Forms.Button
    Friend WithEvents DBDocumentenDataSetBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents InstellingenBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PaswoordConfiguratieDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OpslagConfiguratieDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AuteursBindingSource4 As System.Windows.Forms.BindingSource
    Friend WithEvents AuteursBindingSource5 As System.Windows.Forms.BindingSource
    Friend WithEvents DBDocumentenDataSetBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents SAVDocumentenBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DtsDocsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SAVDocumentenBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents DtsDocsBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents CodesButton As System.Windows.Forms.Button
    Friend WithEvents BestemmelingButton As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents mtgccboBestemmeling As MTGCComboBox
    Friend WithEvents BestemmelingBindingSource As System.Windows.Forms.BindingSource
    Private WithEvents tbaBestemmeling As DM.DBDocumentenDataSetTableAdapters.BestemmelingTableAdapter
    Friend WithEvents AdresLabel As System.Windows.Forms.Label
    Friend WithEvents btnMaakBrief As System.Windows.Forms.Button
    Friend WithEvents Bestemmeling_NieuwWijzig As System.Windows.Forms.Button
    Friend WithEvents CodeBindingSource2 As System.Windows.Forms.BindingSource
    Private WithEvents DtsComboSjabloon As DM.dtsComboSjabloon
    Friend WithEvents mtgccboSjabloon As MTGCComboBox
    Friend WithEvents CodeBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnSjabloonPadBrowse As System.Windows.Forms.Button
    Friend WithEvents txtKenmerk As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtBericht As System.Windows.Forms.TextBox
    Friend WithEvents btnZoeken As System.Windows.Forms.Button
    Friend WithEvents mtgccboAuteurs As MTGCComboBox
    Friend WithEvents ContactpersoonLbl As System.Windows.Forms.Label
    Friend WithEvents ContactPersoonTxt As System.Windows.Forms.TextBox
    Friend WithEvents btnBestandKoppelen As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Private WithEvents lblConfiguratiePad As System.Windows.Forms.Label
    Private WithEvents lblConfiguratiePadInfo As System.Windows.Forms.Label

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TabPageNieuw = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnBestandKoppelen = New System.Windows.Forms.Button()
        Me.ContactpersoonLbl = New System.Windows.Forms.Label()
        Me.ContactPersoonTxt = New System.Windows.Forms.TextBox()
        Me.mtgccboAuteurs = New MTGCComboBox()
        Me.btnZoeken = New System.Windows.Forms.Button()
        Me.txtKenmerk = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtBericht = New System.Windows.Forms.TextBox()
        Me.btnSjabloonPadBrowse = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.mtgccboSjabloon = New MTGCComboBox()
        Me.Bestemmeling_NieuwWijzig = New System.Windows.Forms.Button()
        Me.btnMaakBrief = New System.Windows.Forms.Button()
        Me.AdresLabel = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.mtgccboBestemmeling = New MTGCComboBox()
        Me.btnVoorkeurOpslaan = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.mtgccboAfzender = New MTGCComboBox()
        Me.LblAfzender = New System.Windows.Forms.Label()
        Me.DateDoc = New System.Windows.Forms.DateTimePicker()
        Me.LblDatum_doc = New System.Windows.Forms.Label()
        Me.LblTrefwoord = New System.Windows.Forms.Label()
        Me.TxtTrefwoord = New System.Windows.Forms.TextBox()
        Me.LblOpslag = New System.Windows.Forms.Label()
        Me.txtOpslagPad = New System.Windows.Forms.TextBox()
        Me.btnOpslagPadBrowse = New System.Windows.Forms.Button()
        Me.LblTitel = New System.Windows.Forms.Label()
        Me.TxtTitel = New System.Windows.Forms.TextBox()
        Me.LblSjabloon = New System.Windows.Forms.Label()
        Me.txtSjabloonPad = New System.Windows.Forms.TextBox()
        Me.LbLAuteur = New System.Windows.Forms.Label()
        Me.LblCode = New System.Windows.Forms.Label()
        Me.TabPageConfiguratie = New System.Windows.Forms.TabPage()
        Me.lblConfiguratiePad = New System.Windows.Forms.Label()
        Me.lblConfiguratiePadInfo = New System.Windows.Forms.Label()
        Me.BestemmelingButton = New System.Windows.Forms.Button()
        Me.CodesButton = New System.Windows.Forms.Button()
        Me.AuteurssjablonenButton = New System.Windows.Forms.Button()
        Me.AuteursButton = New System.Windows.Forms.Button()
        Me.ToonLijst = New System.Windows.Forms.Button()
        Me.DtsDocs = New DM.dtsDocs()
        Me.DtsComboSjabloon = New DM.dtsComboSjabloon()
        Me.DtsSjabloon = New DM.dtsSjabloon()
        Me.TableAdapterManager = New DM.dtsSjabloonTableAdapters.TableAdapterManager()
        Me.tbaAuteursjab = New DM.dtsSjabloonTableAdapters.AuteursjabTableAdapter()
        Me.dtsDocumentenDB = New DM.DBDocumentenDataSet()
        Me.CodeTableAdapter = New DM.DBDocumentenDataSetTableAdapters.CodeTableAdapter()
        Me.tbaAuteurs = New DM.DBDocumentenDataSetTableAdapters.AuteursTableAdapter()
        Me.tbaBestemmeling = New DM.DBDocumentenDataSetTableAdapters.BestemmelingTableAdapter()
        Me.tbaDocumenten = New DM.DBDocumentenDataSetTableAdapters.SAV_DocumentenTableAdapter()
        Me.TabControl.SuspendLayout()
        Me.TabPageNieuw.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageConfiguratie.SuspendLayout()
        CType(Me.DtsDocs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtsComboSjabloon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtsSjabloon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtsDocumentenDB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.TabPageNieuw)
        Me.TabControl.Controls.Add(Me.TabPageConfiguratie)
        Me.TabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl.Location = New System.Drawing.Point(0, 0)
        Me.TabControl.Margin = New System.Windows.Forms.Padding(0)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(971, 488)
        Me.TabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.TabControl.TabIndex = 0
        '
        'TabPageNieuw
        '
        Me.TabPageNieuw.AutoScroll = True
        Me.TabPageNieuw.Controls.Add(Me.PictureBox1)
        Me.TabPageNieuw.Controls.Add(Me.btnBestandKoppelen)
        Me.TabPageNieuw.Controls.Add(Me.ContactpersoonLbl)
        Me.TabPageNieuw.Controls.Add(Me.ContactPersoonTxt)
        Me.TabPageNieuw.Controls.Add(Me.mtgccboAuteurs)
        Me.TabPageNieuw.Controls.Add(Me.btnZoeken)
        Me.TabPageNieuw.Controls.Add(Me.txtKenmerk)
        Me.TabPageNieuw.Controls.Add(Me.Label11)
        Me.TabPageNieuw.Controls.Add(Me.Label10)
        Me.TabPageNieuw.Controls.Add(Me.txtBericht)
        Me.TabPageNieuw.Controls.Add(Me.btnSjabloonPadBrowse)
        Me.TabPageNieuw.Controls.Add(Me.Label6)
        Me.TabPageNieuw.Controls.Add(Me.mtgccboSjabloon)
        Me.TabPageNieuw.Controls.Add(Me.Bestemmeling_NieuwWijzig)
        Me.TabPageNieuw.Controls.Add(Me.btnMaakBrief)
        Me.TabPageNieuw.Controls.Add(Me.AdresLabel)
        Me.TabPageNieuw.Controls.Add(Me.Label7)
        Me.TabPageNieuw.Controls.Add(Me.mtgccboBestemmeling)
        Me.TabPageNieuw.Controls.Add(Me.btnVoorkeurOpslaan)
        Me.TabPageNieuw.Controls.Add(Me.Label9)
        Me.TabPageNieuw.Controls.Add(Me.Label8)
        Me.TabPageNieuw.Controls.Add(Me.Label5)
        Me.TabPageNieuw.Controls.Add(Me.mtgccboAfzender)
        Me.TabPageNieuw.Controls.Add(Me.LblAfzender)
        Me.TabPageNieuw.Controls.Add(Me.DateDoc)
        Me.TabPageNieuw.Controls.Add(Me.LblDatum_doc)
        Me.TabPageNieuw.Controls.Add(Me.LblTrefwoord)
        Me.TabPageNieuw.Controls.Add(Me.TxtTrefwoord)
        Me.TabPageNieuw.Controls.Add(Me.LblOpslag)
        Me.TabPageNieuw.Controls.Add(Me.txtOpslagPad)
        Me.TabPageNieuw.Controls.Add(Me.btnOpslagPadBrowse)
        Me.TabPageNieuw.Controls.Add(Me.LblTitel)
        Me.TabPageNieuw.Controls.Add(Me.TxtTitel)
        Me.TabPageNieuw.Controls.Add(Me.LblSjabloon)
        Me.TabPageNieuw.Controls.Add(Me.txtSjabloonPad)
        Me.TabPageNieuw.Controls.Add(Me.LbLAuteur)
        Me.TabPageNieuw.Controls.Add(Me.LblCode)
        Me.TabPageNieuw.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TabPageNieuw.Location = New System.Drawing.Point(4, 22)
        Me.TabPageNieuw.Margin = New System.Windows.Forms.Padding(0)
        Me.TabPageNieuw.Name = "TabPageNieuw"
        Me.TabPageNieuw.Size = New System.Drawing.Size(963, 462)
        Me.TabPageNieuw.TabIndex = 0
        Me.TabPageNieuw.Text = "Nieuw"
        Me.TabPageNieuw.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.DM.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(724, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(236, 141)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'btnBestandKoppelen
        '
        Me.btnBestandKoppelen.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBestandKoppelen.Location = New System.Drawing.Point(390, 388)
        Me.btnBestandKoppelen.Name = "btnBestandKoppelen"
        Me.btnBestandKoppelen.Size = New System.Drawing.Size(118, 49)
        Me.btnBestandKoppelen.TabIndex = 53
        Me.btnBestandKoppelen.Text = "Koppel bestand"
        Me.btnBestandKoppelen.UseVisualStyleBackColor = True
        '
        'ContactpersoonLbl
        '
        Me.ContactpersoonLbl.AutoSize = True
        Me.ContactpersoonLbl.Location = New System.Drawing.Point(11, 172)
        Me.ContactpersoonLbl.Name = "ContactpersoonLbl"
        Me.ContactpersoonLbl.Size = New System.Drawing.Size(85, 13)
        Me.ContactpersoonLbl.TabIndex = 52
        Me.ContactpersoonLbl.Text = "Contactpersoon:"
        '
        'ContactPersoonTxt
        '
        Me.ContactPersoonTxt.Location = New System.Drawing.Point(108, 171)
        Me.ContactPersoonTxt.Name = "ContactPersoonTxt"
        Me.ContactPersoonTxt.Size = New System.Drawing.Size(304, 20)
        Me.ContactPersoonTxt.TabIndex = 51
        '
        'mtgccboAuteurs
        '
        Me.mtgccboAuteurs.BorderStyle = MTGCComboBox.TipiBordi.FlatXP
        Me.mtgccboAuteurs.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.mtgccboAuteurs.ColumnNum = 3
        Me.mtgccboAuteurs.ColumnWidth = "274;0;0"
        Me.mtgccboAuteurs.DisplayMember = "Text"
        Me.mtgccboAuteurs.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.mtgccboAuteurs.DropDownArrowBackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.mtgccboAuteurs.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.mtgccboAuteurs.DropDownForeColor = System.Drawing.Color.Black
        Me.mtgccboAuteurs.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDownList
        Me.mtgccboAuteurs.DropDownWidth = 294
        Me.mtgccboAuteurs.GridLineColor = System.Drawing.Color.LightGray
        Me.mtgccboAuteurs.GridLineHorizontal = False
        Me.mtgccboAuteurs.GridLineVertical = False
        Me.mtgccboAuteurs.HighlightBorderColor = System.Drawing.Color.Blue
        Me.mtgccboAuteurs.HighlightBorderOnMouseEvents = True
        Me.mtgccboAuteurs.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.mtgccboAuteurs.Location = New System.Drawing.Point(108, 12)
        Me.mtgccboAuteurs.ManagingFastMouseMoving = True
        Me.mtgccboAuteurs.ManagingFastMouseMovingInterval = 30
        Me.mtgccboAuteurs.Name = "mtgccboAuteurs"
        Me.mtgccboAuteurs.NormalBorderColor = System.Drawing.Color.Black
        Me.mtgccboAuteurs.Size = New System.Drawing.Size(274, 21)
        Me.mtgccboAuteurs.TabIndex = 50
        '
        'btnZoeken
        '
        Me.btnZoeken.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.btnZoeken.Location = New System.Drawing.Point(242, 388)
        Me.btnZoeken.Name = "btnZoeken"
        Me.btnZoeken.Size = New System.Drawing.Size(130, 49)
        Me.btnZoeken.TabIndex = 49
        Me.btnZoeken.Text = "Opzoeken"
        Me.btnZoeken.UseVisualStyleBackColor = True
        '
        'txtKenmerk
        '
        Me.txtKenmerk.Location = New System.Drawing.Point(377, 43)
        Me.txtKenmerk.Name = "txtKenmerk"
        Me.txtKenmerk.Size = New System.Drawing.Size(164, 20)
        Me.txtKenmerk.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(299, 44)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 13)
        Me.Label11.TabIndex = 48
        Me.Label11.Text = "Uw kenmerk:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(35, 43)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 13)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Uw bericht:"
        '
        'txtBericht
        '
        Me.txtBericht.Location = New System.Drawing.Point(108, 43)
        Me.txtBericht.Name = "txtBericht"
        Me.txtBericht.Size = New System.Drawing.Size(173, 20)
        Me.txtBericht.TabIndex = 1
        '
        'btnSjabloonPadBrowse
        '
        Me.btnSjabloonPadBrowse.Location = New System.Drawing.Point(581, 298)
        Me.btnSjabloonPadBrowse.Name = "btnSjabloonPadBrowse"
        Me.btnSjabloonPadBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnSjabloonPadBrowse.TabIndex = 45
        Me.btnSjabloonPadBrowse.Text = "Browse"
        Me.btnSjabloonPadBrowse.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(558, 298)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 17)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "*"
        '
        'mtgccboSjabloon
        '
        Me.mtgccboSjabloon.BorderStyle = MTGCComboBox.TipiBordi.FlatXP
        Me.mtgccboSjabloon.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.mtgccboSjabloon.ColumnNum = 3
        Me.mtgccboSjabloon.ColumnWidth = "140;0;0"
        Me.mtgccboSjabloon.DisplayMember = "Text"
        Me.mtgccboSjabloon.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.mtgccboSjabloon.DropDownArrowBackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.mtgccboSjabloon.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.mtgccboSjabloon.DropDownForeColor = System.Drawing.Color.Black
        Me.mtgccboSjabloon.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown
        Me.mtgccboSjabloon.DropDownWidth = 180
        Me.mtgccboSjabloon.GridLineColor = System.Drawing.Color.LightGray
        Me.mtgccboSjabloon.GridLineHorizontal = False
        Me.mtgccboSjabloon.GridLineVertical = False
        Me.mtgccboSjabloon.HighlightBorderColor = System.Drawing.Color.Blue
        Me.mtgccboSjabloon.HighlightBorderOnMouseEvents = True
        Me.mtgccboSjabloon.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.mtgccboSjabloon.Location = New System.Drawing.Point(108, 111)
        Me.mtgccboSjabloon.ManagingFastMouseMoving = True
        Me.mtgccboSjabloon.ManagingFastMouseMovingInterval = 30
        Me.mtgccboSjabloon.Name = "mtgccboSjabloon"
        Me.mtgccboSjabloon.NormalBorderColor = System.Drawing.Color.Black
        Me.mtgccboSjabloon.Size = New System.Drawing.Size(304, 21)
        Me.mtgccboSjabloon.TabIndex = 4
        '
        'Bestemmeling_NieuwWijzig
        '
        Me.Bestemmeling_NieuwWijzig.Location = New System.Drawing.Point(432, 138)
        Me.Bestemmeling_NieuwWijzig.Name = "Bestemmeling_NieuwWijzig"
        Me.Bestemmeling_NieuwWijzig.Size = New System.Drawing.Size(109, 23)
        Me.Bestemmeling_NieuwWijzig.TabIndex = 42
        Me.Bestemmeling_NieuwWijzig.Text = "Nieuw/Wijzig"
        Me.Bestemmeling_NieuwWijzig.UseVisualStyleBackColor = True
        '
        'btnMaakBrief
        '
        Me.btnMaakBrief.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMaakBrief.Location = New System.Drawing.Point(106, 388)
        Me.btnMaakBrief.Name = "btnMaakBrief"
        Me.btnMaakBrief.Size = New System.Drawing.Size(118, 49)
        Me.btnMaakBrief.TabIndex = 10
        Me.btnMaakBrief.Text = "Maak Brief"
        Me.btnMaakBrief.UseVisualStyleBackColor = True
        '
        'AdresLabel
        '
        Me.AdresLabel.AutoSize = True
        Me.AdresLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdresLabel.ForeColor = System.Drawing.Color.Black
        Me.AdresLabel.Location = New System.Drawing.Point(567, 144)
        Me.AdresLabel.Name = "AdresLabel"
        Me.AdresLabel.Size = New System.Drawing.Size(50, 17)
        Me.AdresLabel.TabIndex = 38
        Me.AdresLabel.Text = "Adres"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 142)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 13)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Bestemmeling:"
        '
        'mtgccboBestemmeling
        '
        Me.mtgccboBestemmeling.BorderStyle = MTGCComboBox.TipiBordi.FlatXP
        Me.mtgccboBestemmeling.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.mtgccboBestemmeling.ColumnNum = 4
        Me.mtgccboBestemmeling.ColumnWidth = "200;150;60;100"
        Me.mtgccboBestemmeling.DisplayMember = "Text"
        Me.mtgccboBestemmeling.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.mtgccboBestemmeling.DropDownArrowBackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.mtgccboBestemmeling.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.mtgccboBestemmeling.DropDownForeColor = System.Drawing.Color.Black
        Me.mtgccboBestemmeling.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDownList
        Me.mtgccboBestemmeling.DropDownWidth = 530
        Me.mtgccboBestemmeling.GridLineColor = System.Drawing.Color.LightGray
        Me.mtgccboBestemmeling.GridLineHorizontal = False
        Me.mtgccboBestemmeling.GridLineVertical = False
        Me.mtgccboBestemmeling.HighlightBorderColor = System.Drawing.Color.Blue
        Me.mtgccboBestemmeling.HighlightBorderOnMouseEvents = True
        Me.mtgccboBestemmeling.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.mtgccboBestemmeling.Location = New System.Drawing.Point(108, 140)
        Me.mtgccboBestemmeling.ManagingFastMouseMoving = True
        Me.mtgccboBestemmeling.ManagingFastMouseMovingInterval = 30
        Me.mtgccboBestemmeling.Name = "mtgccboBestemmeling"
        Me.mtgccboBestemmeling.NormalBorderColor = System.Drawing.Color.Black
        Me.mtgccboBestemmeling.Size = New System.Drawing.Size(304, 21)
        Me.mtgccboBestemmeling.TabIndex = 5
        '
        'btnVoorkeurOpslaan
        '
        Me.btnVoorkeurOpslaan.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVoorkeurOpslaan.Location = New System.Drawing.Point(432, 77)
        Me.btnVoorkeurOpslaan.Name = "btnVoorkeurOpslaan"
        Me.btnVoorkeurOpslaan.Size = New System.Drawing.Size(109, 23)
        Me.btnVoorkeurOpslaan.TabIndex = 34
        Me.btnVoorkeurOpslaan.TabStop = False
        Me.btnVoorkeurOpslaan.Text = "Standaard opslaan"
        Me.btnVoorkeurOpslaan.UseVisualStyleBackColor = True
        Me.btnVoorkeurOpslaan.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(101, 352)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(132, 17)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "* : verplichte velden"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(558, 330)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(13, 17)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(544, 195)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 17)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "*"
        '
        'mtgccboAfzender
        '
        Me.mtgccboAfzender.BorderStyle = MTGCComboBox.TipiBordi.FlatXP
        Me.mtgccboAfzender.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.mtgccboAfzender.ColumnNum = 4
        Me.mtgccboAfzender.ColumnWidth = "80; 0;0;0"
        Me.mtgccboAfzender.DisplayMember = "Text"
        Me.mtgccboAfzender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.mtgccboAfzender.DropDownArrowBackColor = System.Drawing.Color.Blue
        Me.mtgccboAfzender.DropDownBackColor = System.Drawing.Color.White
        Me.mtgccboAfzender.DropDownForeColor = System.Drawing.Color.RoyalBlue
        Me.mtgccboAfzender.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDownList
        Me.mtgccboAfzender.DropDownWidth = 200
        Me.mtgccboAfzender.GridLineColor = System.Drawing.Color.LightGray
        Me.mtgccboAfzender.GridLineHorizontal = False
        Me.mtgccboAfzender.GridLineVertical = False
        Me.mtgccboAfzender.HighlightBorderColor = System.Drawing.Color.Blue
        Me.mtgccboAfzender.HighlightBorderOnMouseEvents = True
        Me.mtgccboAfzender.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.mtgccboAfzender.Location = New System.Drawing.Point(108, 77)
        Me.mtgccboAfzender.ManagingFastMouseMoving = True
        Me.mtgccboAfzender.ManagingFastMouseMovingInterval = 30
        Me.mtgccboAfzender.Name = "mtgccboAfzender"
        Me.mtgccboAfzender.NormalBorderColor = System.Drawing.Color.Black
        Me.mtgccboAfzender.Size = New System.Drawing.Size(304, 21)
        Me.mtgccboAfzender.TabIndex = 3
        '
        'LblAfzender
        '
        Me.LblAfzender.AutoSize = True
        Me.LblAfzender.Location = New System.Drawing.Point(42, 76)
        Me.LblAfzender.Name = "LblAfzender"
        Me.LblAfzender.Size = New System.Drawing.Size(52, 13)
        Me.LblAfzender.TabIndex = 26
        Me.LblAfzender.Text = "Afzender:"
        '
        'DateDoc
        '
        Me.DateDoc.Location = New System.Drawing.Point(107, 266)
        Me.DateDoc.Name = "DateDoc"
        Me.DateDoc.Size = New System.Drawing.Size(200, 20)
        Me.DateDoc.TabIndex = 5
        Me.DateDoc.TabStop = False
        '
        'LblDatum_doc
        '
        Me.LblDatum_doc.AutoSize = True
        Me.LblDatum_doc.Location = New System.Drawing.Point(0, 267)
        Me.LblDatum_doc.Name = "LblDatum_doc"
        Me.LblDatum_doc.Size = New System.Drawing.Size(93, 13)
        Me.LblDatum_doc.TabIndex = 24
        Me.LblDatum_doc.Text = "Datum Document:"
        '
        'LblTrefwoord
        '
        Me.LblTrefwoord.AutoSize = True
        Me.LblTrefwoord.Location = New System.Drawing.Point(35, 234)
        Me.LblTrefwoord.Name = "LblTrefwoord"
        Me.LblTrefwoord.Size = New System.Drawing.Size(58, 13)
        Me.LblTrefwoord.TabIndex = 23
        Me.LblTrefwoord.Text = "Trefwoord:"
        '
        'TxtTrefwoord
        '
        Me.TxtTrefwoord.Location = New System.Drawing.Point(107, 234)
        Me.TxtTrefwoord.Name = "TxtTrefwoord"
        Me.TxtTrefwoord.Size = New System.Drawing.Size(434, 20)
        Me.TxtTrefwoord.TabIndex = 7
        '
        'LblOpslag
        '
        Me.LblOpslag.AutoSize = True
        Me.LblOpslag.Location = New System.Drawing.Point(22, 329)
        Me.LblOpslag.Name = "LblOpslag"
        Me.LblOpslag.Size = New System.Drawing.Size(71, 13)
        Me.LblOpslag.TabIndex = 21
        Me.LblOpslag.Text = "Opslagplaats:"
        '
        'txtOpslagPad
        '
        Me.txtOpslagPad.Location = New System.Drawing.Point(107, 332)
        Me.txtOpslagPad.Name = "txtOpslagPad"
        Me.txtOpslagPad.ReadOnly = True
        Me.txtOpslagPad.Size = New System.Drawing.Size(453, 20)
        Me.txtOpslagPad.TabIndex = 9
        Me.txtOpslagPad.TabStop = False
        '
        'btnOpslagPadBrowse
        '
        Me.btnOpslagPadBrowse.Location = New System.Drawing.Point(580, 333)
        Me.btnOpslagPadBrowse.Name = "btnOpslagPadBrowse"
        Me.btnOpslagPadBrowse.Size = New System.Drawing.Size(76, 23)
        Me.btnOpslagPadBrowse.TabIndex = 19
        Me.btnOpslagPadBrowse.TabStop = False
        Me.btnOpslagPadBrowse.Text = "Browse"
        Me.btnOpslagPadBrowse.UseVisualStyleBackColor = True
        '
        'LblTitel
        '
        Me.LblTitel.AutoSize = True
        Me.LblTitel.Location = New System.Drawing.Point(63, 199)
        Me.LblTitel.Name = "LblTitel"
        Me.LblTitel.Size = New System.Drawing.Size(30, 13)
        Me.LblTitel.TabIndex = 18
        Me.LblTitel.Text = "Titel:"
        '
        'TxtTitel
        '
        Me.TxtTitel.Location = New System.Drawing.Point(107, 202)
        Me.TxtTitel.Name = "TxtTitel"
        Me.TxtTitel.Size = New System.Drawing.Size(434, 20)
        Me.TxtTitel.TabIndex = 6
        '
        'LblSjabloon
        '
        Me.LblSjabloon.AutoSize = True
        Me.LblSjabloon.Location = New System.Drawing.Point(24, 298)
        Me.LblSjabloon.Name = "LblSjabloon"
        Me.LblSjabloon.Size = New System.Drawing.Size(69, 13)
        Me.LblSjabloon.TabIndex = 16
        Me.LblSjabloon.Text = "Sjabloonpad:"
        '
        'txtSjabloonPad
        '
        Me.txtSjabloonPad.Location = New System.Drawing.Point(107, 298)
        Me.txtSjabloonPad.Name = "txtSjabloonPad"
        Me.txtSjabloonPad.ReadOnly = True
        Me.txtSjabloonPad.Size = New System.Drawing.Size(453, 20)
        Me.txtSjabloonPad.TabIndex = 8
        Me.txtSjabloonPad.TabStop = False
        '
        'LbLAuteur
        '
        Me.LbLAuteur.AutoSize = True
        Me.LbLAuteur.Location = New System.Drawing.Point(51, 9)
        Me.LbLAuteur.Name = "LbLAuteur"
        Me.LbLAuteur.Size = New System.Drawing.Size(41, 13)
        Me.LbLAuteur.TabIndex = 14
        Me.LbLAuteur.Text = "Auteur:"
        '
        'LblCode
        '
        Me.LblCode.AutoSize = True
        Me.LblCode.Location = New System.Drawing.Point(41, 108)
        Me.LblCode.Name = "LblCode"
        Me.LblCode.Size = New System.Drawing.Size(51, 13)
        Me.LblCode.TabIndex = 12
        Me.LblCode.Text = "Sjabloon:"
        '
        'TabPageConfiguratie
        '
        Me.TabPageConfiguratie.Controls.Add(Me.lblConfiguratiePad)
        Me.TabPageConfiguratie.Controls.Add(Me.lblConfiguratiePadInfo)
        Me.TabPageConfiguratie.Controls.Add(Me.BestemmelingButton)
        Me.TabPageConfiguratie.Controls.Add(Me.CodesButton)
        Me.TabPageConfiguratie.Controls.Add(Me.AuteurssjablonenButton)
        Me.TabPageConfiguratie.Controls.Add(Me.AuteursButton)
        Me.TabPageConfiguratie.Controls.Add(Me.ToonLijst)
        Me.TabPageConfiguratie.Location = New System.Drawing.Point(4, 22)
        Me.TabPageConfiguratie.Name = "TabPageConfiguratie"
        Me.TabPageConfiguratie.Size = New System.Drawing.Size(963, 462)
        Me.TabPageConfiguratie.TabIndex = 2
        Me.TabPageConfiguratie.Text = "Configuratie"
        Me.TabPageConfiguratie.UseVisualStyleBackColor = True
        '
        'lblConfiguratiePad
        '
        Me.lblConfiguratiePad.AutoSize = True
        Me.lblConfiguratiePad.Location = New System.Drawing.Point(101, 213)
        Me.lblConfiguratiePad.Name = "lblConfiguratiePad"
        Me.lblConfiguratiePad.Size = New System.Drawing.Size(36, 13)
        Me.lblConfiguratiePad.TabIndex = 7
        Me.lblConfiguratiePad.Text = "CPAD"
        '
        'lblConfiguratiePadInfo
        '
        Me.lblConfiguratiePadInfo.AutoSize = True
        Me.lblConfiguratiePadInfo.Location = New System.Drawing.Point(101, 190)
        Me.lblConfiguratiePadInfo.Name = "lblConfiguratiePadInfo"
        Me.lblConfiguratiePadInfo.Size = New System.Drawing.Size(85, 13)
        Me.lblConfiguratiePadInfo.TabIndex = 6
        Me.lblConfiguratiePadInfo.Text = "Configuratie Pad"
        '
        'BestemmelingButton
        '
        Me.BestemmelingButton.Location = New System.Drawing.Point(101, 123)
        Me.BestemmelingButton.Name = "BestemmelingButton"
        Me.BestemmelingButton.Size = New System.Drawing.Size(143, 23)
        Me.BestemmelingButton.TabIndex = 5
        Me.BestemmelingButton.Text = "Bestemmeling"
        Me.BestemmelingButton.UseVisualStyleBackColor = True
        '
        'CodesButton
        '
        Me.CodesButton.Location = New System.Drawing.Point(104, 152)
        Me.CodesButton.Name = "CodesButton"
        Me.CodesButton.Size = New System.Drawing.Size(143, 23)
        Me.CodesButton.TabIndex = 4
        Me.CodesButton.Text = "Sjablonen"
        Me.CodesButton.UseVisualStyleBackColor = True
        '
        'AuteurssjablonenButton
        '
        Me.AuteurssjablonenButton.Location = New System.Drawing.Point(101, 94)
        Me.AuteurssjablonenButton.Name = "AuteurssjablonenButton"
        Me.AuteurssjablonenButton.Size = New System.Drawing.Size(143, 23)
        Me.AuteurssjablonenButton.TabIndex = 2
        Me.AuteurssjablonenButton.Text = "Afzenders"
        Me.AuteurssjablonenButton.UseVisualStyleBackColor = True
        '
        'AuteursButton
        '
        Me.AuteursButton.Location = New System.Drawing.Point(101, 65)
        Me.AuteursButton.Name = "AuteursButton"
        Me.AuteursButton.Size = New System.Drawing.Size(143, 23)
        Me.AuteursButton.TabIndex = 1
        Me.AuteursButton.Text = "Auteurs"
        Me.AuteursButton.UseVisualStyleBackColor = True
        '
        'ToonLijst
        '
        Me.ToonLijst.Location = New System.Drawing.Point(101, 36)
        Me.ToonLijst.Name = "ToonLijst"
        Me.ToonLijst.Size = New System.Drawing.Size(143, 23)
        Me.ToonLijst.TabIndex = 0
        Me.ToonLijst.Text = "Toon Lijst"
        Me.ToonLijst.UseVisualStyleBackColor = True
        '
        'DtsDocs
        '
        Me.DtsDocs.DataSetName = "dtsDocs"
        Me.DtsDocs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DtsComboSjabloon
        '
        Me.DtsComboSjabloon.DataSetName = "dtsComboSjabloon"
        Me.DtsComboSjabloon.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DtsSjabloon
        '
        Me.DtsSjabloon.DataSetName = "dtsSjabloon"
        Me.DtsSjabloon.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AuteursjabTableAdapter = Me.tbaAuteursjab
        Me.TableAdapterManager.AuteursTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = DM.dtsSjabloonTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'tbaAuteursjab
        '
        Me.tbaAuteursjab.ClearBeforeFill = True
        '
        'dtsDocumentenDB
        '
        Me.dtsDocumentenDB.DataSetName = "DBDocumentenDataSet"
        Me.dtsDocumentenDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CodeTableAdapter
        '
        Me.CodeTableAdapter.ClearBeforeFill = True
        '
        'tbaAuteurs
        '
        Me.tbaAuteurs.ClearBeforeFill = True
        '
        'tbaBestemmeling
        '
        Me.tbaBestemmeling.ClearBeforeFill = True
        '
        'tbaDocumenten
        '
        Me.tbaDocumenten.ClearBeforeFill = True
        '
        'Main
        '
        Me.ClientSize = New System.Drawing.Size(971, 488)
        Me.Controls.Add(Me.TabControl)
        Me.Name = "Main"
        Me.Text = "Documentmanager versie 08-04-2016"
        Me.TabControl.ResumeLayout(False)
        Me.TabPageNieuw.ResumeLayout(False)
        Me.TabPageNieuw.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageConfiguratie.ResumeLayout(False)
        Me.TabPageConfiguratie.PerformLayout()
        CType(Me.DtsDocs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtsComboSjabloon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtsSjabloon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtsDocumentenDB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private _Singleton As Singleton = Singleton.Instance

    Dim Bookmarks As DocumentBookmarks = New DocumentBookmarks()

    Dim frmDbLijst As DBLijst
    Dim frmAuteurs As Auteurs
    Dim frmAuteurSjabloon As AuteurSjabloon
    Dim frmDiensten As Diensten
    Dim frmBestemmeling As Bestemmeling
    Dim frmCodes As Codes
    Dim frmBestemmelingWijzig As Bestemmeling_wijzig
    Dim frmZoeken As Zoeken

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.Ag

        'Bestemmelingen inladen + als Datasource zetten voor MTGCCombobox
        tbaBestemmeling.Fill(dtsDocumentenDB.Bestemmeling)
        mtgccboBestemmeling.LoadingType = MTGCComboBox.CaricamentoCombo.DataTable
        mtgccboBestemmeling.SourceDataString = New String(3) {"Firma", "Adres", "Postnummer", "Stad"}
        mtgccboBestemmeling.SourceDataTable = dtsDocumentenDB.Bestemmeling

        'Auteurs inladen + als datasource zetten voor MTGCCombobox
        tbaAuteurs.Fill(dtsDocumentenDB.Auteurs)

        mtgccboAuteurs.LoadingType = MTGCComboBox.CaricamentoCombo.DataTable
        mtgccboAuteurs.SourceDataString = New String(2) {"Auteur", "AuteurID", "MagAllesZien"}
        mtgccboAuteurs.SourceDataTable = dtsDocumentenDB.Auteurs

        If File.Exists(_Singleton.ConfiguratiePad) Then
            InlezenOpgeslagenAuteur()
            InlezenOpgeslagenAfzender()
        End If

        DateDoc.Value = Today
        AdresLabel.Text = ""
        lblConfiguratiePad.Text = _Singleton.ConfiguratiePad
    End Sub

    Private Sub InlezenOpgeslagenAuteur()
        If File.Exists(_Singleton.ConfiguratiePad) Then
            Try
                Dim reader As StreamReader = System.IO.File.OpenText(_Singleton.ConfiguratiePad)
                'Inlezen Auteur
                Dim OpgeslagenAuteur As String = reader.ReadLine()
                Dim i As Integer
                For i = 0 To mtgccboAuteurs.Items.Count - 1
                    Dim cboAuteurItemText As String = mtgccboAuteurs.Items.Item(i).Text
                    If cboAuteurItemText.Equals(OpgeslagenAuteur) Then
                        'Selecteer hem
                        mtgccboAuteurs.SelectedIndex = i
                        Exit For
                    End If
                Next
                reader.Dispose()
                'instellen zodat combobox vergrendeld is en je geen nieuwe config meer kan maken
                Me.mtgccboAuteurs.Enabled = False

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Onverwachte error")
            End Try
        End If
    End Sub

    Private Sub InlezenOpgeslagenAfzender()
        If File.Exists(_Singleton.ConfiguratiePad) Then
            Try
                Dim reader As StreamReader = System.IO.File.OpenText(_Singleton.ConfiguratiePad)
                '1ste lijn is de Auteur, skip deze lijn
                reader.ReadLine()
                'Inlezen Afzender
                Dim OpgeslagenAfzender As String = reader.ReadLine()
                Dim i As Integer
                For i = 0 To mtgccboAfzender.Items.Count - 1
                    Dim cboAfzenderText As String = mtgccboAfzender.Items.Item(i).Text
                    If cboAfzenderText.Equals(OpgeslagenAfzender) Then
                        mtgccboAfzender.SelectedIndex = i
                        Exit For
                    End If
                Next

                reader.Dispose()

                Me.btnVoorkeurOpslaan.Visible = False

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Onverwachte error")
            End Try
        End If
    End Sub

    Private Sub BtnMaakBrief_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMaakBrief.Click   '
        If Not ZijnAlleVerplichteVeldenIngevuld() Then
            MsgBox("Alle verplichte velden invullen", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim lngVolgnr As Long = tbaDocumenten.SelectVolgendeSleutel()
        Dim StrSjabloonCode As String = mtgccboSjabloon.SelectedItem.col2

        Dim StrFirma As String
        Try
            StrFirma = mtgccboBestemmeling.SelectedItem.col1
        Catch ex As System.NullReferenceException
            StrFirma = ""
        End Try

        'Documentnaam + Opslagplaats opbouwen
        Dim strBestandsnaam As String = WordDocumentUtil.GetDocumentNaam(mtgccboSjabloon.SelectedItem.col2, _
                    DateDoc.Value, lngVolgnr, _Singleton.Auteur.AuteurKort, TxtTitel.Text, ".docx")

        Dim strOpslagPadEnBestandsnaam As String
        If txtOpslagPad.Text.EndsWith("\") Then
            strOpslagPadEnBestandsnaam = txtOpslagPad.Text & strBestandsnaam
        Else
            strOpslagPadEnBestandsnaam = txtOpslagPad.Text & "\" & strBestandsnaam
        End If

        'Controleren of naam legaal is
        If Not PathUtil.IsValidFileName(strBestandsnaam) Then
            MsgBox("Illegale tekens!")
            Exit Sub
        End If

        'Wegschrijven in de tabel SAV_Documenten
        tbaDocumenten.Insert(_Singleton.Auteur.AuteurKort, StrSjabloonCode, lngVolgnr, txtOpslagPad.Text, txtSjabloonPad.Text, Today, DateDoc.Value, TxtTitel.Text, TxtTrefwoord.Text, mtgccboAfzender.SelectedItem.Text, strOpslagPadEnBestandsnaam, StrFirma)

        'Word Document aanmaken
        Dim wordApp As New Microsoft.Office.Interop.Word.Application()
        Dim WordDoc As New Microsoft.Office.Interop.Word.Document()

        Try
            'Creer het worddocument
            WordDoc = wordApp.Documents.Add(CType(txtSjabloonPad.Text, Object), False, 0, True)

            VulBookmarksIn(WordDoc, lngVolgnr, StrSjabloonCode, mtgccboSjabloon.SelectedItem.Text)

            'Toont het document en slaat het op 
            wordApp.Visible = True
            WordDoc.Activate()

            'Opslaan 
            wordApp.ActiveDocument.SaveAs(strOpslagPadEnBestandsnaam)
            wordApp.Documents.Save()

            LeegDocumentInformatieVelden()

            'sluit de verbinding
            WordDoc = Nothing

        Catch ex As Exception
            MsgBox("Er is een fout opgetreden. " & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub VulBookmarksIn(ByRef WordDoc As Microsoft.Office.Interop.Word.Document, ByVal lngVolgnr As Long, ByVal StrSjabloonCode As String, ByVal strDocumentsoort As String)
        Try
            If Bookmarks.BM_afzender = True Then
                WordDoc.Bookmarks.Item("afzender").Range.Text = mtgccboAfzender.SelectedItem.col4
            End If
        Catch ex As NullReferenceException
        End Try

        If Bookmarks.BM_geadresseerde = True Then
            WordDoc.Bookmarks.Item("firma").Range.Text = AdresLabel.Text
        End If

        If Bookmarks.BM_type Then
            If StrSjabloonCode <> "UN" Then
                WordDoc.Bookmarks.Item("typebrief").Range.Text = strDocumentsoort & " : " & lngVolgnr.ToString()
            ElseIf StrSjabloonCode = "UN" Then
                WordDoc.Bookmarks.Item("typebrief").Range.Text = strDocumentsoort
            End If
        End If

        If Bookmarks.BM_uwbericht = True Then
            WordDoc.Bookmarks.Item("uwbericht").Range.Text = txtBericht.Text
        End If

        If Bookmarks.BM_uwkenmerk = True Then
            WordDoc.Bookmarks.Item("uwkenmerk").Range.Text = txtKenmerk.Text
        End If

        If Bookmarks.BM_onskenmerk = True Then
            WordDoc.Bookmarks.Item("onskenmerk").Range.Text = lngVolgnr.ToString()
        End If

        If Bookmarks.BM_datum = True Then
            WordDoc.Bookmarks.Item("DatumDocument").Range.Text = CStr(DateDoc.Value)
        End If

        If Bookmarks.BM_onderwerp = True Then
            WordDoc.Bookmarks.Item("titel").Range.Text = TxtTitel.Text
        End If
    End Sub

    Private Sub BtnOpslag_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpslagPadBrowse.Click
        'Vraag gebruiker een nieuwe locatie om bestand naar te verplaatsen
        Dim dlgFolderLocatie As SaveFileDialog = New SaveFileDialog
        dlgFolderLocatie.FileName = "Selecteer je opslagmap"
        dlgFolderLocatie.InitialDirectory = txtOpslagPad.Text
        dlgFolderLocatie.RestoreDirectory = True
        dlgFolderLocatie.AddExtension = False
        dlgFolderLocatie.CheckFileExists = False
        dlgFolderLocatie.OverwritePrompt = False
        dlgFolderLocatie.CreatePrompt = False
        dlgFolderLocatie.CheckPathExists = True

        If dlgFolderLocatie.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            'Controleer of het geselecteerde pad een UNC pad is
            Dim SaveToFolder As String = Path.GetDirectoryName(dlgFolderLocatie.FileName)
            If PathUtil.IsUncPath(SaveToFolder) Then
                txtOpslagPad.Text = SaveToFolder
            Else
                Dim UncPathFromLocalPath = PathUtil.GetUNCPathFromLocal(SaveToFolder)
                If Not Nothing = UncPathFromLocalPath Then
                    txtOpslagPad.Text = UncPathFromLocalPath
                Else
                    Dim strDrive As String = Path.GetPathRoot(SaveToFolder)
                    MessageBox.Show(SaveToFolder & vbCrLf & strDrive & " is geen publieke share!", "Opslaglocatie geweigerd")
                End If
            End If

        End If
    End Sub

    Private Sub TryOpenAdminForm(ByRef admForm As Form, ByVal NewForm As Form)
        If _Singleton.IsGebruikerAdmin Then
            ToonForm(admForm, NewForm)
        Else 'Gebruiker (nog) geen admin, vraag paswoord
            If PasswordBox.ShowDialog() = Windows.Forms.DialogResult.OK Then
                If _Singleton.IsAdminPaswoordCorrect(PasswordBox.GetPassword) Then
                    ToonForm(admForm, NewForm)
                Else
                    MsgBox("Verkeerd paswoord !", MsgBoxStyle.Critical, "Paswoord")
                End If
            End If
        End If
    End Sub

    Private Sub ToonLijst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToonLijst.Click
        TryOpenAdminForm(frmDbLijst, New DBLijst)
    End Sub

    Private Sub ToonForm(ByRef oForm As Form, ByVal NewForm As Form)
        If oForm Is Nothing Then
            oForm = NewForm
            oForm.Show()
        Else
            If oForm.Disposing Or oForm.IsDisposed Then
                oForm = NewForm
                oForm.Show()
            Else
                oForm.Activate()
            End If
        End If
    End Sub

    Private Sub AuteursButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AuteursButton.Click
        TryOpenAdminForm(frmAuteurs, New Auteurs)
    End Sub

    Private Sub AuteurssjablonenButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AuteurssjablonenButton.Click
        TryOpenAdminForm(frmAuteurSjabloon, New AuteurSjabloon)
    End Sub

    Private Sub DienstenButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)   
        TryOpenAdminForm(frmDiensten, New Diensten)
    End Sub

    Private Sub CodesButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CodesButton.Click
        TryOpenAdminForm(frmCodes, New Codes)
    End Sub

    Private Sub BestemmelingButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BestemmelingButton.Click
        TryOpenAdminForm(frmBestemmeling, New Bestemmeling)
    End Sub

    Private Sub Bestemmeling_NieuwWijzig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bestemmeling_NieuwWijzig.Click
        'Moet dit geen admin console zijn?
        ToonForm(frmBestemmelingWijzig, New Bestemmeling_wijzig)
    End Sub

    ''' <summary>
    ''' Gebeurt bij de configuratie van het bestand, daarna niet meer?
    ''' </summary>
    Private Sub AuteurCombobox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mtgccboAuteurs.SelectedIndexChanged
        'opvullen van lijst Afzender na selectie van auteur
        tbaAuteursjab.FillByDienst(DtsSjabloon.Auteursjab, mtgccboAuteurs.SelectedItem.col2)

        'mtgccboAfzender DataSource zetten
        mtgccboAfzender.Items.Clear()
        mtgccboAfzender.Text = ""

        'mtgccboAfzender
        mtgccboAfzender.LoadingType = MTGCComboBox.CaricamentoCombo.DataTable
        mtgccboAfzender.SourceDataString = New String(3) {"afzender", "sjablonenpad", "opslagpad", "afzender_tekst"}
        mtgccboAfzender.SourceDataTable = DtsSjabloon.Auteursjab

        'Setting the source data of the combobox
        mtgccboSjabloon.Items.Clear()
        mtgccboSjabloon.Text = ""

        dtsDocumentenDB.EnforceConstraints = False 'Database niet in orde
        CodeTableAdapter.FillByCodeAuteur(dtsDocumentenDB.Code, mtgccboAuteurs.SelectedItem.col2)

        mtgccboSjabloon.LoadingType = MTGCComboBox.CaricamentoCombo.DataTable
        mtgccboSjabloon.SourceDataString = New String(2) {"Codetekst", "Code", "Sjablonenpad"}
        mtgccboSjabloon.SourceDataTable = dtsDocumentenDB.Code

        Dim AuteurLang As String = Me.mtgccboAuteurs.SelectedItem.col1
        Dim AuteurKort As String = Me.mtgccboAuteurs.SelectedItem.col2
        Dim MagAllesZien As Boolean = False
        Try
            MagAllesZien = Me.mtgccboAuteurs.SelectedItem.col3
        Catch ex As Exception
            'Database error > Gaf 'NULL' terug ipv True / False
        End Try

        _Singleton.Auteur = New Auteur(AuteurLang, AuteurKort, MagAllesZien)

    End Sub

    Private Sub mtgccboAfzender_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mtgccboAfzender.SelectedIndexChanged
        Try
            Me.txtOpslagPad.Text = mtgccboAfzender.SelectedItem.col3
        Catch ex As Exception
        End Try

        Me.btnVoorkeurOpslaan.Visible = True
    End Sub

    'hier sla je op waar de user zijn application paramaters staan.
    Private Sub Voorkeur_opslaanButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoorkeurOpslaan.Click
        Try
            Dim sw As StreamWriter = New System.IO.StreamWriter(_Singleton.ConfiguratiePad, False)
            'Opslaan Auteur
            Dim SelectedAuteur As String = mtgccboAuteurs.SelectedItem.Text
            sw.WriteLine(SelectedAuteur)
            'Opslaan Afzender
            Dim SelectedAfzender As String = mtgccboAfzender.SelectedItem.Text
            sw.WriteLine(SelectedAfzender)
            'Afsluiten StreamWriter
            sw.Close()
            sw.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Onverwachte fout")
        End Try

        MsgBox("Gegevens opgeslagen", MsgBoxStyle.Information, "Configuratie")

        'instellen zodat combobox vergrendeld is en je geen nieuwe config meer kan maken
        Me.btnVoorkeurOpslaan.Visible = False
        Me.mtgccboAuteurs.Enabled = False

    End Sub

    Private Sub BestemmelingComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mtgccboBestemmeling.SelectedIndexChanged
        Try
            AdresLabel.Text = mtgccboBestemmeling.SelectedItem.col1 & vbCrLf & _
                                mtgccboBestemmeling.SelectedItem.col2 & vbCrLf & _
                                mtgccboBestemmeling.SelectedItem.col3 & " " & _
                                mtgccboBestemmeling.SelectedItem.col4 & vbCrLf
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ContactPersoonTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContactPersoonTxt.TextChanged
        AdresLabel.Text = ""
    End Sub

    Private Sub LeegDocumentInformatieVelden()
        'Maak de velden : titel , trefwoord, uw bericht, uw kenmerk leeg voor een nieuw document
        Me.TxtTitel.Text = ""
        Me.TxtTrefwoord.Text = ""
        Me.txtBericht.Text = ""
        Me.txtKenmerk.Text = ""
        mtgccboBestemmeling.Text = ""
        AdresLabel.Text = ""
        ContactPersoonTxt.Text = ""
    End Sub

    Private Sub SjabloonComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mtgccboSjabloon.SelectedIndexChanged
        Me.txtSjabloonPad.Text = Me.mtgccboSjabloon.SelectedItem.col3

        Dim conn As SqlConnection = New SqlConnection(My.Settings.DBDocumentenCS)
        Dim cmd As SqlCommand = New SqlCommand("SELECT * FROM Code", conn)

        conn.Open()
        Dim reader As SqlDataReader = cmd.ExecuteReader()

        Try
            Do While reader.Read()
                If (reader(1).ToString() = mtgccboSjabloon.SelectedItem.col2) Then
                    Bookmarks.BM_afzender = CBool(reader("BM_afzender").ToString())
                    Bookmarks.BM_geadresseerde = CBool(reader("BM_geadresseerde").ToString())
                    Bookmarks.BM_type = CBool(reader("BM_type").ToString())
                    Bookmarks.BM_uwbericht = CBool(reader("BM_uwbericht").ToString())
                    Bookmarks.BM_uwkenmerk = CBool(reader("BM_uwkenmerk").ToString())
                    Bookmarks.BM_onskenmerk = CBool(reader("BM_onskenmerk").ToString())
                    Bookmarks.BM_datum = CBool(reader("BM_datum").ToString())
                    Bookmarks.BM_onderwerp = CBool(reader("BM_onderwerp").ToString())
                    Bookmarks.BM_startdocument = CBool(reader("BM_startdocument").ToString())
                    Exit Do
                End If
            Loop
        Catch ex As Exception
        End Try

        reader.Close()
        conn.Close()

    End Sub

    Private Sub SjabloonBrowseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSjabloonPadBrowse.Click
        'Use the open file dialog to choose a word dot document
        Dim dlgOpenFile As OpenFileDialog = New OpenFileDialog()
        dlgOpenFile.InitialDirectory = System.Environment.CurrentDirectory
        dlgOpenFile.Title = "Open Dot File"
        dlgOpenFile.Filter = "Text files (*.dot)|*.dot"
        dlgOpenFile.FilterIndex = 1
        dlgOpenFile.RestoreDirectory = True

        If dlgOpenFile.ShowDialog() = DialogResult.OK Then
            ' set the file name from the open file dialog
            Dim StrDotName As String = dlgOpenFile.FileName
            'zet de nieuwe waarde in txtSjabloon
            txtSjabloonPad.Text = StrDotName
        End If
    End Sub

    ''' <summary>
    ''' Toon de form Zoeken
    ''' </summary>
    Private Sub ZoekenBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZoeken.Click
        ToonForm(frmZoeken, New Zoeken)
    End Sub

    Private Sub BtnBestandKoppelen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBestandKoppelen.Click
        If Not ZijnAlleVerplichteVeldenIngevuld() Then
            MsgBox("Alle verplichte velden invullen", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim lngVolgnr As Long = tbaDocumenten.SelectVolgendeSleutel()
        Dim StrSjabloonCode As String = mtgccboSjabloon.SelectedItem.col2

        Dim StrFirma As String
        Try
            StrFirma = mtgccboBestemmeling.SelectedItem.col1
        Catch ex As System.NullReferenceException
            StrFirma = ""
        End Try

        'Documentnaam + Opslagplaats opbouwen
        'Controleren of er geen illegale tekens in zitten
        Dim strBestandsnaamTest As String = WordDocumentUtil.GetDocumentNaam(mtgccboSjabloon.SelectedItem.col2, _
                    DateDoc.Value, lngVolgnr, _Singleton.Auteur.AuteurKort, TxtTitel.Text, "")

        'Controleren of naam legaal is
        If Not PathUtil.IsValidFileName(strBestandsnaamTest) Then
            MsgBox("Illegale tekens!")
            Exit Sub
        End If

        Try
            'Opzoeken van het bestand
            Dim fldBestand As OpenFileDialog = New OpenFileDialog()
            If fldBestand.ShowDialog = DialogResult.OK Then
                Dim strTeImporterenBestandsNaamEnPad As String = fldBestand.FileName
                Dim strExtension As String = Path.GetExtension(strTeImporterenBestandsNaamEnPad)
                Dim strBestandsnaam As String = WordDocumentUtil.GetDocumentNaam(mtgccboSjabloon.SelectedItem.col2, _
                    DateDoc.Value, lngVolgnr, _Singleton.Auteur.AuteurKort, TxtTitel.Text, strExtension)
                Dim strOpslagPadEnBestandsnaam As String = txtOpslagPad.Text & "\" & strBestandsnaam

                File.Copy(strTeImporterenBestandsNaamEnPad, strOpslagPadEnBestandsnaam)

                'Wegschrijven in de tabel SAV_Documenten
                tbaDocumenten.Insert(_Singleton.Auteur.AuteurKort, StrSjabloonCode, lngVolgnr, txtOpslagPad.Text, txtSjabloonPad.Text, Today, DateDoc.Value, TxtTitel.Text, TxtTrefwoord.Text, mtgccboAfzender.SelectedItem.Text, strOpslagPadEnBestandsnaam, StrFirma)


                MsgBox("Het bestand " & Path.GetFileName(strTeImporterenBestandsNaamEnPad) & _
                       " is geimporteerd als " & strBestandsnaam & " in de document manager")

                LeegDocumentInformatieVelden()

            End If
        Catch ex As Exception
            MsgBox("Er is een fout opgetreden. " & ex.Message, MsgBoxStyle.Critical, ex.Message)
        End Try

    End Sub

    Private Function ZijnAlleVerplichteVeldenIngevuld() As Boolean
        If Not txtSjabloonPad.Text.Trim <> "" Then
            Return False
        End If

        If Not txtOpslagPad.Text.Trim <> "" Then
            Return False
        End If

        If Not TxtTitel.Text.Trim <> "" Then
            Return False
        End If

        If Not mtgccboAuteurs.Text.Trim <> "" Then
            Return False
        End If

        If Not mtgccboAfzender.Text.Trim <> "" Then
            Return False
        End If

        Return True
    End Function

    Private Sub lblConfiguratiePad_Click(sender As Object, e As EventArgs) Handles lblConfiguratiePad.Click
        Process.Start(Path.GetDirectoryName(_Singleton.ConfiguratiePad))
    End Sub

    Private Sub txtOpslagPad_TextChanged(sender As Object, e As EventArgs) Handles txtOpslagPad.TextChanged
        _Singleton.Opslagplaats = txtOpslagPad.Text
    End Sub

End Class