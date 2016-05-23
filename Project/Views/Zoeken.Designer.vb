<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Zoeken
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DtsZoeken = New DM.dtsZoeken()
        Me.SAV_DocumentenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SAV_DocumentenTableAdapter = New DM.dtsZoekenTableAdapters.SAV_DocumentenTableAdapter()
        Me.TableAdapterManager = New DM.dtsZoekenTableAdapters.TableAdapterManager()
        Me.AuteursTableAdapter = New DM.dtsZoekenTableAdapters.AuteursTableAdapter()
        Me.CodeTableAdapter = New DM.dtsZoekenTableAdapters.CodeTableAdapter()
        Me.dgvZoeken = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AuteursBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboAuteurs = New System.Windows.Forms.ComboBox()
        Me.AuteursSAVDocumentenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CodeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboDocumentTypeCode = New System.Windows.Forms.ComboBox()
        Me.txtZoekterm = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnZoek = New System.Windows.Forms.Button()
        Me.DatumVanDTP = New System.Windows.Forms.DateTimePicker()
        Me.DatumTotDTP = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ZoekenLbl = New System.Windows.Forms.Label()
        Me.btnWijzigTitel = New System.Windows.Forms.Button()
        Me.btnVerplaatsen = New System.Windows.Forms.Button()
        Me.btnVerwijderen = New System.Windows.Forms.Button()
        CType(Me.DtsZoeken, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SAV_DocumentenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvZoeken, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuteursBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuteursSAVDocumentenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DtsZoeken
        '
        Me.DtsZoeken.DataSetName = "dtsZoeken"
        Me.DtsZoeken.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SAV_DocumentenBindingSource
        '
        Me.SAV_DocumentenBindingSource.DataMember = "SAV_Documenten"
        Me.SAV_DocumentenBindingSource.DataSource = Me.DtsZoeken
        '
        'SAV_DocumentenTableAdapter
        '
        Me.SAV_DocumentenTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AuteursTableAdapter = Me.AuteursTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CodeTableAdapter = Me.CodeTableAdapter
        Me.TableAdapterManager.SAV_DocumentenTableAdapter = Me.SAV_DocumentenTableAdapter
        Me.TableAdapterManager.UpdateOrder = DM.dtsZoekenTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AuteursTableAdapter
        '
        Me.AuteursTableAdapter.ClearBeforeFill = True
        '
        'CodeTableAdapter
        '
        Me.CodeTableAdapter.ClearBeforeFill = True
        '
        'dgvZoeken
        '
        Me.dgvZoeken.AllowUserToAddRows = False
        Me.dgvZoeken.AllowUserToDeleteRows = False
        Me.dgvZoeken.AutoGenerateColumns = False
        Me.dgvZoeken.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvZoeken.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvZoeken.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn11, Me.Column1})
        Me.dgvZoeken.DataSource = Me.SAV_DocumentenBindingSource
        Me.dgvZoeken.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvZoeken.Location = New System.Drawing.Point(0, 245)
        Me.dgvZoeken.Name = "dgvZoeken"
        Me.dgvZoeken.ReadOnly = True
        Me.dgvZoeken.Size = New System.Drawing.Size(1096, 357)
        Me.dgvZoeken.TabIndex = 1
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Bestandsnaam"
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn12.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn12.HeaderText = "Bestandsnaam"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Width = 102
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Titel"
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn9.HeaderText = "Titel"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 52
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Trefwoord"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Trefwoord"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 80
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Auteurid"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Auteurid"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 71
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Code"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Code"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 57
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Firma"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Firma"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Datum_create"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Datum Opmaak"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 97
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Datum_doc"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Datum Doc"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 79
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Afzender"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Afzender"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 74
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "Sleutel"
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'AuteursBindingSource
        '
        Me.AuteursBindingSource.DataMember = "Auteurs"
        Me.AuteursBindingSource.DataSource = Me.DtsZoeken
        '
        'cboAuteurs
        '
        Me.cboAuteurs.DataSource = Me.AuteursBindingSource
        Me.cboAuteurs.DisplayMember = "Auteur"
        Me.cboAuteurs.Enabled = False
        Me.cboAuteurs.FormattingEnabled = True
        Me.cboAuteurs.Location = New System.Drawing.Point(127, 57)
        Me.cboAuteurs.Name = "cboAuteurs"
        Me.cboAuteurs.Size = New System.Drawing.Size(223, 21)
        Me.cboAuteurs.TabIndex = 1
        Me.cboAuteurs.ValueMember = "AuteurID"
        '
        'AuteursSAVDocumentenBindingSource
        '
        Me.AuteursSAVDocumentenBindingSource.DataMember = "Auteurs_SAV_Documenten"
        Me.AuteursSAVDocumentenBindingSource.DataSource = Me.AuteursBindingSource
        '
        'CodeBindingSource
        '
        Me.CodeBindingSource.DataMember = "Code"
        Me.CodeBindingSource.DataSource = Me.DtsZoeken
        '
        'cboDocumentTypeCode
        '
        Me.cboDocumentTypeCode.DataSource = Me.CodeBindingSource
        Me.cboDocumentTypeCode.DisplayMember = "Codetekst"
        Me.cboDocumentTypeCode.FormattingEnabled = True
        Me.cboDocumentTypeCode.Location = New System.Drawing.Point(127, 92)
        Me.cboDocumentTypeCode.Name = "cboDocumentTypeCode"
        Me.cboDocumentTypeCode.Size = New System.Drawing.Size(223, 21)
        Me.cboDocumentTypeCode.TabIndex = 2
        Me.cboDocumentTypeCode.ValueMember = "Code"
        '
        'txtZoekterm
        '
        Me.txtZoekterm.Location = New System.Drawing.Point(127, 128)
        Me.txtZoekterm.Name = "txtZoekterm"
        Me.txtZoekterm.Size = New System.Drawing.Size(129, 20)
        Me.txtZoekterm.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(69, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Zoekterm:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(59, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Datum van:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(343, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "tot en met:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(80, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Auteur:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Document Type:"
        '
        'btnZoek
        '
        Me.btnZoek.Location = New System.Drawing.Point(127, 185)
        Me.btnZoek.Name = "btnZoek"
        Me.btnZoek.Size = New System.Drawing.Size(135, 32)
        Me.btnZoek.TabIndex = 11
        Me.btnZoek.Text = "ZOEKEN"
        Me.btnZoek.UseVisualStyleBackColor = True
        Me.btnZoek.Visible = False
        '
        'DatumVanDTP
        '
        Me.DatumVanDTP.CustomFormat = "dd-MM-yyyy"
        Me.DatumVanDTP.Location = New System.Drawing.Point(127, 159)
        Me.DatumVanDTP.Name = "DatumVanDTP"
        Me.DatumVanDTP.Size = New System.Drawing.Size(200, 20)
        Me.DatumVanDTP.TabIndex = 12
        '
        'DatumTotDTP
        '
        Me.DatumTotDTP.CustomFormat = "dd-MM-yyyy"
        Me.DatumTotDTP.Location = New System.Drawing.Point(406, 159)
        Me.DatumTotDTP.Name = "DatumTotDTP"
        Me.DatumTotDTP.Size = New System.Drawing.Size(200, 20)
        Me.DatumTotDTP.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(275, 134)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(220, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "(Zoeken in titel, trefwoord, documentnr, firma)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label7.Location = New System.Drawing.Point(50, 220)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(472, 13)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Dubbelklik op de bestandsnaam om het bestand te openen + Klik op een roostertitel" & _
    " om te sorteren"
        '
        'ZoekenLbl
        '
        Me.ZoekenLbl.AutoSize = True
        Me.ZoekenLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ZoekenLbl.Location = New System.Drawing.Point(123, 25)
        Me.ZoekenLbl.Name = "ZoekenLbl"
        Me.ZoekenLbl.Size = New System.Drawing.Size(89, 24)
        Me.ZoekenLbl.TabIndex = 47
        Me.ZoekenLbl.Text = "ZOEKEN"
        '
        'btnWijzigTitel
        '
        Me.btnWijzigTitel.Location = New System.Drawing.Point(518, 185)
        Me.btnWijzigTitel.Name = "btnWijzigTitel"
        Me.btnWijzigTitel.Size = New System.Drawing.Size(119, 32)
        Me.btnWijzigTitel.TabIndex = 48
        Me.btnWijzigTitel.Text = "WIJZIG TITEL"
        Me.btnWijzigTitel.UseVisualStyleBackColor = True
        Me.btnWijzigTitel.Visible = False
        '
        'btnVerplaatsen
        '
        Me.btnVerplaatsen.AutoSize = True
        Me.btnVerplaatsen.Location = New System.Drawing.Point(268, 185)
        Me.btnVerplaatsen.Name = "btnVerplaatsen"
        Me.btnVerplaatsen.Size = New System.Drawing.Size(119, 32)
        Me.btnVerplaatsen.TabIndex = 51
        Me.btnVerplaatsen.Text = "VERPLAATSEN"
        Me.btnVerplaatsen.UseVisualStyleBackColor = True
        Me.btnVerplaatsen.Visible = False
        '
        'btnVerwijderen
        '
        Me.btnVerwijderen.AutoSize = True
        Me.btnVerwijderen.Location = New System.Drawing.Point(393, 185)
        Me.btnVerwijderen.Name = "btnVerwijderen"
        Me.btnVerwijderen.Size = New System.Drawing.Size(119, 32)
        Me.btnVerwijderen.TabIndex = 52
        Me.btnVerwijderen.Text = "VERWIJDEREN"
        Me.btnVerwijderen.UseVisualStyleBackColor = True
        Me.btnVerwijderen.Visible = False
        '
        'Zoeken
        '
        Me.AcceptButton = Me.btnZoek
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1096, 602)
        Me.Controls.Add(Me.btnVerwijderen)
        Me.Controls.Add(Me.btnVerplaatsen)
        Me.Controls.Add(Me.btnWijzigTitel)
        Me.Controls.Add(Me.ZoekenLbl)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DatumTotDTP)
        Me.Controls.Add(Me.DatumVanDTP)
        Me.Controls.Add(Me.btnZoek)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtZoekterm)
        Me.Controls.Add(Me.cboDocumentTypeCode)
        Me.Controls.Add(Me.cboAuteurs)
        Me.Controls.Add(Me.dgvZoeken)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Name = "Zoeken"
        Me.Text = "Zoeken versie 08-04-2016"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DtsZoeken, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SAV_DocumentenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvZoeken, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuteursBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuteursSAVDocumentenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AuteursBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents cboAuteurs As System.Windows.Forms.ComboBox
    Friend WithEvents cboDocumentTypeCode As System.Windows.Forms.ComboBox
    Friend WithEvents txtZoekterm As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnZoek As System.Windows.Forms.Button
    Friend WithEvents DatumVanDTP As System.Windows.Forms.DateTimePicker
    Friend WithEvents DatumTotDTP As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ZoekenLbl As System.Windows.Forms.Label
    Friend WithEvents btnWijzigTitel As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnVerplaatsen As System.Windows.Forms.Button
    Friend WithEvents btnVerwijderen As System.Windows.Forms.Button
    Private WithEvents DtsZoeken As DM.dtsZoeken
    Private WithEvents SAV_DocumentenBindingSource As System.Windows.Forms.BindingSource
    Private WithEvents SAV_DocumentenTableAdapter As DM.dtsZoekenTableAdapters.SAV_DocumentenTableAdapter
    Private WithEvents TableAdapterManager As DM.dtsZoekenTableAdapters.TableAdapterManager
    Private WithEvents AuteursTableAdapter As DM.dtsZoekenTableAdapters.AuteursTableAdapter
    Private WithEvents CodeTableAdapter As DM.dtsZoekenTableAdapters.CodeTableAdapter
    Private WithEvents CodeBindingSource As System.Windows.Forms.BindingSource
    Private WithEvents AuteursSAVDocumentenBindingSource As System.Windows.Forms.BindingSource
    Private WithEvents dgvZoeken As System.Windows.Forms.DataGridView
End Class
