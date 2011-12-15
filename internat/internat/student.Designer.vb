<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class student
    Inherits System.Windows.Forms.Form

    'Formulář přepisuje metodu Dispose, aby vyčistil seznam součástí.
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

    'Vyžadováno Návrhářem formulářů
    Private components As System.ComponentModel.IContainer

    'POZNÁMKA: Následující procedura je vyžadována Návrhářem formulářů
    'Může být upraveno pomocí Návrháře formulářů.  
    'Neupravovat pomocí editoru kódu.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(student))
        Dim PriezviskoLabel As System.Windows.Forms.Label
        Dim MenoLabel As System.Windows.Forms.Label
        Dim DatumNarodeniaLabel As System.Windows.Forms.Label
        Dim RodneCisloLabel As System.Windows.Forms.Label
        Dim MiestoNarodeniaLabel As System.Windows.Forms.Label
        Dim UlicaLabel As System.Windows.Forms.Label
        Dim MestoLabel As System.Windows.Forms.Label
        Dim PscLabel As System.Windows.Forms.Label
        Dim CisloOpLabel As System.Windows.Forms.Label
        Dim TelefonLabel As System.Windows.Forms.Label
        Dim DatumNastupLabel As System.Windows.Forms.Label
        Dim DatumVystupLabel As System.Windows.Forms.Label
        Dim NazovSkupinaLabel As System.Windows.Forms.Label
        Dim NazovSkolaLabel As System.Windows.Forms.Label
        Me.InternatDataSet = New internat.internatDataSet()
        Me.StudentKompletBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentKompletTableAdapter = New internat.internatDataSetTableAdapters.studentKompletTableAdapter()
        Me.TableAdapterManager = New internat.internatDataSetTableAdapters.TableAdapterManager()
        Me.StudentKompletBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.StudentKompletBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.StudentKompletDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriezviskoTextBox = New System.Windows.Forms.TextBox()
        Me.MenoTextBox = New System.Windows.Forms.TextBox()
        Me.DatumNarodeniaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.RodneCisloTextBox = New System.Windows.Forms.TextBox()
        Me.MiestoNarodeniaTextBox = New System.Windows.Forms.TextBox()
        Me.UlicaTextBox = New System.Windows.Forms.TextBox()
        Me.MestoTextBox = New System.Windows.Forms.TextBox()
        Me.PscTextBox = New System.Windows.Forms.TextBox()
        Me.CisloOpTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonTextBox = New System.Windows.Forms.TextBox()
        Me.DatumNastupDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DatumVystupDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.skupinaComboBox = New System.Windows.Forms.ComboBox()
        Me.skolaComboBox = New System.Windows.Forms.ComboBox()
        Me.ulozButton = New System.Windows.Forms.Button()
        Me.SkupinaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SkupinaTableAdapter = New internat.internatDataSetTableAdapters.skupinaTableAdapter()
        Me.SkolaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SkolaTableAdapter = New internat.internatDataSetTableAdapters.skolaTableAdapter()
        PriezviskoLabel = New System.Windows.Forms.Label()
        MenoLabel = New System.Windows.Forms.Label()
        DatumNarodeniaLabel = New System.Windows.Forms.Label()
        RodneCisloLabel = New System.Windows.Forms.Label()
        MiestoNarodeniaLabel = New System.Windows.Forms.Label()
        UlicaLabel = New System.Windows.Forms.Label()
        MestoLabel = New System.Windows.Forms.Label()
        PscLabel = New System.Windows.Forms.Label()
        CisloOpLabel = New System.Windows.Forms.Label()
        TelefonLabel = New System.Windows.Forms.Label()
        DatumNastupLabel = New System.Windows.Forms.Label()
        DatumVystupLabel = New System.Windows.Forms.Label()
        NazovSkupinaLabel = New System.Windows.Forms.Label()
        NazovSkolaLabel = New System.Windows.Forms.Label()
        CType(Me.InternatDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentKompletBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentKompletBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StudentKompletBindingNavigator.SuspendLayout()
        CType(Me.StudentKompletDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SkupinaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SkolaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InternatDataSet
        '
        Me.InternatDataSet.DataSetName = "internatDataSet"
        Me.InternatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentKompletBindingSource
        '
        Me.StudentKompletBindingSource.DataMember = "studentKomplet"
        Me.StudentKompletBindingSource.DataSource = Me.InternatDataSet
        '
        'StudentKompletTableAdapter
        '
        Me.StudentKompletTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.skolaTableAdapter = Nothing
        Me.TableAdapterManager.skupinaTableAdapter = Nothing
        Me.TableAdapterManager.studentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = internat.internatDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.vychovavatelTableAdapter = Nothing
        '
        'StudentKompletBindingNavigator
        '
        Me.StudentKompletBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.StudentKompletBindingNavigator.BindingSource = Me.StudentKompletBindingSource
        Me.StudentKompletBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.StudentKompletBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.StudentKompletBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.StudentKompletBindingNavigatorSaveItem})
        Me.StudentKompletBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.StudentKompletBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.StudentKompletBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.StudentKompletBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.StudentKompletBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.StudentKompletBindingNavigator.Name = "StudentKompletBindingNavigator"
        Me.StudentKompletBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.StudentKompletBindingNavigator.Size = New System.Drawing.Size(883, 25)
        Me.StudentKompletBindingNavigator.TabIndex = 0
        Me.StudentKompletBindingNavigator.Text = "BindingNavigator1"
        Me.StudentKompletBindingNavigator.Visible = False
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
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
        'StudentKompletBindingNavigatorSaveItem
        '
        Me.StudentKompletBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.StudentKompletBindingNavigatorSaveItem.Enabled = False
        Me.StudentKompletBindingNavigatorSaveItem.Image = CType(resources.GetObject("StudentKompletBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.StudentKompletBindingNavigatorSaveItem.Name = "StudentKompletBindingNavigatorSaveItem"
        Me.StudentKompletBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.StudentKompletBindingNavigatorSaveItem.Text = "Uložit data"
        '
        'StudentKompletDataGridView
        '
        Me.StudentKompletDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StudentKompletDataGridView.AutoGenerateColumns = False
        Me.StudentKompletDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StudentKompletDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16})
        Me.StudentKompletDataGridView.DataSource = Me.StudentKompletBindingSource
        Me.StudentKompletDataGridView.Location = New System.Drawing.Point(10, 264)
        Me.StudentKompletDataGridView.Name = "StudentKompletDataGridView"
        Me.StudentKompletDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.StudentKompletDataGridView.Size = New System.Drawing.Size(859, 228)
        Me.StudentKompletDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "priezvisko"
        Me.DataGridViewTextBoxColumn1.HeaderText = "priezvisko"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "meno"
        Me.DataGridViewTextBoxColumn2.HeaderText = "meno"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "datumNarodenia"
        Me.DataGridViewTextBoxColumn3.HeaderText = "datumNarodenia"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "rodneCislo"
        Me.DataGridViewTextBoxColumn4.HeaderText = "rodneCislo"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "miestoNarodenia"
        Me.DataGridViewTextBoxColumn5.HeaderText = "miestoNarodenia"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "ulica"
        Me.DataGridViewTextBoxColumn6.HeaderText = "ulica"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "mesto"
        Me.DataGridViewTextBoxColumn7.HeaderText = "mesto"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "psc"
        Me.DataGridViewTextBoxColumn8.HeaderText = "psc"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "cisloOp"
        Me.DataGridViewTextBoxColumn9.HeaderText = "cisloOp"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "telefon"
        Me.DataGridViewTextBoxColumn10.HeaderText = "telefon"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "datumNastup"
        Me.DataGridViewTextBoxColumn11.HeaderText = "datumNastup"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "datumVystup"
        Me.DataGridViewTextBoxColumn12.HeaderText = "datumVystup"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "nazovSkupina"
        Me.DataGridViewTextBoxColumn15.HeaderText = "nazovSkupina"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "nazovSkola"
        Me.DataGridViewTextBoxColumn16.HeaderText = "nazovSkola"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'PriezviskoLabel
        '
        PriezviskoLabel.AutoSize = True
        PriezviskoLabel.Location = New System.Drawing.Point(7, 45)
        PriezviskoLabel.Name = "PriezviskoLabel"
        PriezviskoLabel.Size = New System.Drawing.Size(57, 13)
        PriezviskoLabel.TabIndex = 2
        PriezviskoLabel.Text = "priezvisko:"
        '
        'PriezviskoTextBox
        '
        Me.PriezviskoTextBox.Location = New System.Drawing.Point(70, 42)
        Me.PriezviskoTextBox.Name = "PriezviskoTextBox"
        Me.PriezviskoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PriezviskoTextBox.TabIndex = 3
        '
        'MenoLabel
        '
        MenoLabel.AutoSize = True
        MenoLabel.Location = New System.Drawing.Point(278, 45)
        MenoLabel.Name = "MenoLabel"
        MenoLabel.Size = New System.Drawing.Size(36, 13)
        MenoLabel.TabIndex = 4
        MenoLabel.Text = "meno:"
        '
        'MenoTextBox
        '
        Me.MenoTextBox.Location = New System.Drawing.Point(320, 42)
        Me.MenoTextBox.Name = "MenoTextBox"
        Me.MenoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.MenoTextBox.TabIndex = 5
        '
        'DatumNarodeniaLabel
        '
        DatumNarodeniaLabel.AutoSize = True
        DatumNarodeniaLabel.Location = New System.Drawing.Point(4, 92)
        DatumNarodeniaLabel.Name = "DatumNarodeniaLabel"
        DatumNarodeniaLabel.Size = New System.Drawing.Size(91, 13)
        DatumNarodeniaLabel.TabIndex = 6
        DatumNarodeniaLabel.Text = "datum Narodenia:"
        '
        'DatumNarodeniaDateTimePicker
        '
        Me.DatumNarodeniaDateTimePicker.Location = New System.Drawing.Point(102, 88)
        Me.DatumNarodeniaDateTimePicker.Name = "DatumNarodeniaDateTimePicker"
        Me.DatumNarodeniaDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DatumNarodeniaDateTimePicker.TabIndex = 7
        '
        'RodneCisloLabel
        '
        RodneCisloLabel.AutoSize = True
        RodneCisloLabel.Location = New System.Drawing.Point(462, 88)
        RodneCisloLabel.Name = "RodneCisloLabel"
        RodneCisloLabel.Size = New System.Drawing.Size(62, 13)
        RodneCisloLabel.TabIndex = 8
        RodneCisloLabel.Text = "rodne Cislo:"
        '
        'RodneCisloTextBox
        '
        Me.RodneCisloTextBox.Location = New System.Drawing.Point(560, 85)
        Me.RodneCisloTextBox.Name = "RodneCisloTextBox"
        Me.RodneCisloTextBox.Size = New System.Drawing.Size(200, 20)
        Me.RodneCisloTextBox.TabIndex = 9
        '
        'MiestoNarodeniaLabel
        '
        MiestoNarodeniaLabel.AutoSize = True
        MiestoNarodeniaLabel.Location = New System.Drawing.Point(4, 117)
        MiestoNarodeniaLabel.Name = "MiestoNarodeniaLabel"
        MiestoNarodeniaLabel.Size = New System.Drawing.Size(92, 13)
        MiestoNarodeniaLabel.TabIndex = 10
        MiestoNarodeniaLabel.Text = "miesto Narodenia:"
        '
        'MiestoNarodeniaTextBox
        '
        Me.MiestoNarodeniaTextBox.Location = New System.Drawing.Point(102, 114)
        Me.MiestoNarodeniaTextBox.Name = "MiestoNarodeniaTextBox"
        Me.MiestoNarodeniaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.MiestoNarodeniaTextBox.TabIndex = 11
        '
        'UlicaLabel
        '
        UlicaLabel.AutoSize = True
        UlicaLabel.Location = New System.Drawing.Point(4, 152)
        UlicaLabel.Name = "UlicaLabel"
        UlicaLabel.Size = New System.Drawing.Size(32, 13)
        UlicaLabel.TabIndex = 12
        UlicaLabel.Text = "ulica:"
        '
        'UlicaTextBox
        '
        Me.UlicaTextBox.Location = New System.Drawing.Point(102, 149)
        Me.UlicaTextBox.Name = "UlicaTextBox"
        Me.UlicaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.UlicaTextBox.TabIndex = 13
        '
        'MestoLabel
        '
        MestoLabel.AutoSize = True
        MestoLabel.Location = New System.Drawing.Point(4, 178)
        MestoLabel.Name = "MestoLabel"
        MestoLabel.Size = New System.Drawing.Size(38, 13)
        MestoLabel.TabIndex = 14
        MestoLabel.Text = "mesto:"
        '
        'MestoTextBox
        '
        Me.MestoTextBox.Location = New System.Drawing.Point(102, 175)
        Me.MestoTextBox.Name = "MestoTextBox"
        Me.MestoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.MestoTextBox.TabIndex = 15
        '
        'PscLabel
        '
        PscLabel.AutoSize = True
        PscLabel.Location = New System.Drawing.Point(4, 204)
        PscLabel.Name = "PscLabel"
        PscLabel.Size = New System.Drawing.Size(27, 13)
        PscLabel.TabIndex = 16
        PscLabel.Text = "psc:"
        '
        'PscTextBox
        '
        Me.PscTextBox.Location = New System.Drawing.Point(102, 201)
        Me.PscTextBox.Name = "PscTextBox"
        Me.PscTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PscTextBox.TabIndex = 17
        '
        'CisloOpLabel
        '
        CisloOpLabel.AutoSize = True
        CisloOpLabel.Location = New System.Drawing.Point(462, 120)
        CisloOpLabel.Name = "CisloOpLabel"
        CisloOpLabel.Size = New System.Drawing.Size(48, 13)
        CisloOpLabel.TabIndex = 18
        CisloOpLabel.Text = "cislo Op:"
        '
        'CisloOpTextBox
        '
        Me.CisloOpTextBox.Location = New System.Drawing.Point(560, 117)
        Me.CisloOpTextBox.Name = "CisloOpTextBox"
        Me.CisloOpTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CisloOpTextBox.TabIndex = 19
        '
        'TelefonLabel
        '
        TelefonLabel.AutoSize = True
        TelefonLabel.Location = New System.Drawing.Point(4, 230)
        TelefonLabel.Name = "TelefonLabel"
        TelefonLabel.Size = New System.Drawing.Size(42, 13)
        TelefonLabel.TabIndex = 20
        TelefonLabel.Text = "telefon:"
        '
        'TelefonTextBox
        '
        Me.TelefonTextBox.Location = New System.Drawing.Point(102, 227)
        Me.TelefonTextBox.Name = "TelefonTextBox"
        Me.TelefonTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TelefonTextBox.TabIndex = 21
        '
        'DatumNastupLabel
        '
        DatumNastupLabel.AutoSize = True
        DatumNastupLabel.Location = New System.Drawing.Point(462, 153)
        DatumNastupLabel.Name = "DatumNastupLabel"
        DatumNastupLabel.Size = New System.Drawing.Size(76, 13)
        DatumNastupLabel.TabIndex = 22
        DatumNastupLabel.Text = "datum Nastup:"
        '
        'DatumNastupDateTimePicker
        '
        Me.DatumNastupDateTimePicker.Location = New System.Drawing.Point(560, 149)
        Me.DatumNastupDateTimePicker.Name = "DatumNastupDateTimePicker"
        Me.DatumNastupDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DatumNastupDateTimePicker.TabIndex = 23
        '
        'DatumVystupLabel
        '
        DatumVystupLabel.AutoSize = True
        DatumVystupLabel.Location = New System.Drawing.Point(462, 175)
        DatumVystupLabel.Name = "DatumVystupLabel"
        DatumVystupLabel.Size = New System.Drawing.Size(74, 13)
        DatumVystupLabel.TabIndex = 24
        DatumVystupLabel.Text = "datum Vystup:"
        '
        'DatumVystupDateTimePicker
        '
        Me.DatumVystupDateTimePicker.Location = New System.Drawing.Point(560, 171)
        Me.DatumVystupDateTimePicker.Name = "DatumVystupDateTimePicker"
        Me.DatumVystupDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DatumVystupDateTimePicker.TabIndex = 25
        '
        'NazovSkupinaLabel
        '
        NazovSkupinaLabel.AutoSize = True
        NazovSkupinaLabel.Location = New System.Drawing.Point(462, 200)
        NazovSkupinaLabel.Name = "NazovSkupinaLabel"
        NazovSkupinaLabel.Size = New System.Drawing.Size(81, 13)
        NazovSkupinaLabel.TabIndex = 30
        NazovSkupinaLabel.Text = "nazov Skupina:"
        '
        'NazovSkolaLabel
        '
        NazovSkolaLabel.AutoSize = True
        NazovSkolaLabel.Location = New System.Drawing.Point(462, 226)
        NazovSkolaLabel.Name = "NazovSkolaLabel"
        NazovSkolaLabel.Size = New System.Drawing.Size(69, 13)
        NazovSkolaLabel.TabIndex = 32
        NazovSkolaLabel.Text = "nazov Skola:"
        '
        'skupinaComboBox
        '
        Me.skupinaComboBox.DataSource = Me.SkupinaBindingSource
        Me.skupinaComboBox.DisplayMember = "nazov"
        Me.skupinaComboBox.FormattingEnabled = True
        Me.skupinaComboBox.Location = New System.Drawing.Point(560, 198)
        Me.skupinaComboBox.Name = "skupinaComboBox"
        Me.skupinaComboBox.Size = New System.Drawing.Size(200, 21)
        Me.skupinaComboBox.TabIndex = 33
        Me.skupinaComboBox.ValueMember = "id"
        '
        'skolaComboBox
        '
        Me.skolaComboBox.DataSource = Me.SkolaBindingSource
        Me.skolaComboBox.DisplayMember = "nazov"
        Me.skolaComboBox.FormattingEnabled = True
        Me.skolaComboBox.Location = New System.Drawing.Point(560, 222)
        Me.skolaComboBox.Name = "skolaComboBox"
        Me.skolaComboBox.Size = New System.Drawing.Size(200, 21)
        Me.skolaComboBox.TabIndex = 34
        Me.skolaComboBox.ValueMember = "id"
        '
        'ulozButton
        '
        Me.ulozButton.Location = New System.Drawing.Point(652, 22)
        Me.ulozButton.Name = "ulozButton"
        Me.ulozButton.Size = New System.Drawing.Size(139, 23)
        Me.ulozButton.TabIndex = 35
        Me.ulozButton.Text = "ulož"
        Me.ulozButton.UseVisualStyleBackColor = True
        '
        'SkupinaBindingSource
        '
        Me.SkupinaBindingSource.DataMember = "skupina"
        Me.SkupinaBindingSource.DataSource = Me.InternatDataSet
        '
        'SkupinaTableAdapter
        '
        Me.SkupinaTableAdapter.ClearBeforeFill = True
        '
        'SkolaBindingSource
        '
        Me.SkolaBindingSource.DataMember = "skola"
        Me.SkolaBindingSource.DataSource = Me.InternatDataSet
        '
        'SkolaTableAdapter
        '
        Me.SkolaTableAdapter.ClearBeforeFill = True
        '
        'student
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(883, 504)
        Me.Controls.Add(Me.ulozButton)
        Me.Controls.Add(Me.skolaComboBox)
        Me.Controls.Add(Me.skupinaComboBox)
        Me.Controls.Add(PriezviskoLabel)
        Me.Controls.Add(Me.PriezviskoTextBox)
        Me.Controls.Add(MenoLabel)
        Me.Controls.Add(Me.MenoTextBox)
        Me.Controls.Add(DatumNarodeniaLabel)
        Me.Controls.Add(Me.DatumNarodeniaDateTimePicker)
        Me.Controls.Add(RodneCisloLabel)
        Me.Controls.Add(Me.RodneCisloTextBox)
        Me.Controls.Add(MiestoNarodeniaLabel)
        Me.Controls.Add(Me.MiestoNarodeniaTextBox)
        Me.Controls.Add(UlicaLabel)
        Me.Controls.Add(Me.UlicaTextBox)
        Me.Controls.Add(MestoLabel)
        Me.Controls.Add(Me.MestoTextBox)
        Me.Controls.Add(PscLabel)
        Me.Controls.Add(Me.PscTextBox)
        Me.Controls.Add(CisloOpLabel)
        Me.Controls.Add(Me.CisloOpTextBox)
        Me.Controls.Add(TelefonLabel)
        Me.Controls.Add(Me.TelefonTextBox)
        Me.Controls.Add(DatumNastupLabel)
        Me.Controls.Add(Me.DatumNastupDateTimePicker)
        Me.Controls.Add(DatumVystupLabel)
        Me.Controls.Add(Me.DatumVystupDateTimePicker)
        Me.Controls.Add(NazovSkupinaLabel)
        Me.Controls.Add(NazovSkolaLabel)
        Me.Controls.Add(Me.StudentKompletDataGridView)
        Me.Controls.Add(Me.StudentKompletBindingNavigator)
        Me.Name = "student"
        Me.Text = "student"
        CType(Me.InternatDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentKompletBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentKompletBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StudentKompletBindingNavigator.ResumeLayout(False)
        Me.StudentKompletBindingNavigator.PerformLayout()
        CType(Me.StudentKompletDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SkupinaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SkolaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents InternatDataSet As internat.internatDataSet
    Friend WithEvents StudentKompletBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StudentKompletTableAdapter As internat.internatDataSetTableAdapters.studentKompletTableAdapter
    Friend WithEvents TableAdapterManager As internat.internatDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StudentKompletBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents StudentKompletBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents StudentKompletDataGridView As System.Windows.Forms.DataGridView
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
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriezviskoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MenoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DatumNarodeniaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents RodneCisloTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MiestoNarodeniaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UlicaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MestoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PscTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CisloOpTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefonTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DatumNastupDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents DatumVystupDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents skupinaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents skolaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ulozButton As System.Windows.Forms.Button
    Friend WithEvents SkupinaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SkupinaTableAdapter As internat.internatDataSetTableAdapters.skupinaTableAdapter
    Friend WithEvents SkolaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SkolaTableAdapter As internat.internatDataSetTableAdapters.skolaTableAdapter
End Class
