namespace medical
{
    partial class stats
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stats));
            this.optionSel = new System.Windows.Forms.GroupBox();
            this.graphType = new Bunifu.UI.WinForms.BunifuDropdown();
            this.label3 = new System.Windows.Forms.Label();
            this.optionToRender = new Bunifu.UI.WinForms.BunifuDropdown();
            this.label2 = new System.Windows.Forms.Label();
            this.databaseDrop = new Bunifu.UI.WinForms.BunifuDropdown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prénomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nompèreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nommèreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fonctpèreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fonctmèreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.communeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wilayaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matriculeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbenffDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbenfgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datenaissDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.premdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mALADES4DataSet = new medical.MALADES4DataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuChartCanvas3 = new Bunifu.Charts.WinForms.BunifuChartCanvas();
            this.bunifuChartCanvas2 = new Bunifu.Charts.WinForms.BunifuChartCanvas();
            this.bunifuChartCanvas1 = new Bunifu.Charts.WinForms.BunifuChartCanvas();
            this.button2 = new System.Windows.Forms.Button();
            this.nav_left = new FontAwesome.Sharp.IconButton();
            this.nav_right = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.patientsTableAdapter = new medical.MALADES4DataSetTableAdapters.PatientsTableAdapter();
            this.bunifuPieChart1 = new Bunifu.Charts.WinForms.ChartTypes.BunifuPieChart(this.components);
            this.bunifuLineChart1 = new Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart(this.components);
            this.bunifuBarChart1 = new Bunifu.Charts.WinForms.ChartTypes.BunifuBarChart(this.components);
            this.optionSel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mALADES4DataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // optionSel
            // 
            this.optionSel.Controls.Add(this.graphType);
            this.optionSel.Controls.Add(this.label3);
            this.optionSel.Controls.Add(this.optionToRender);
            this.optionSel.Controls.Add(this.label2);
            this.optionSel.Controls.Add(this.databaseDrop);
            this.optionSel.Controls.Add(this.label1);
            this.optionSel.Location = new System.Drawing.Point(12, 12);
            this.optionSel.Name = "optionSel";
            this.optionSel.Size = new System.Drawing.Size(1093, 59);
            this.optionSel.TabIndex = 0;
            this.optionSel.TabStop = false;
            this.optionSel.Text = "Option select";
            // 
            // graphType
            // 
            this.graphType.BackColor = System.Drawing.Color.Transparent;
            this.graphType.BackgroundColor = System.Drawing.Color.White;
            this.graphType.BorderColor = System.Drawing.Color.Silver;
            this.graphType.BorderRadius = 1;
            this.graphType.Color = System.Drawing.Color.Silver;
            this.graphType.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.graphType.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.graphType.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.graphType.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.graphType.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.graphType.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.graphType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.graphType.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.graphType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.graphType.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.graphType.FillDropDown = true;
            this.graphType.FillIndicator = false;
            this.graphType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.graphType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.graphType.ForeColor = System.Drawing.Color.Black;
            this.graphType.FormattingEnabled = true;
            this.graphType.Icon = null;
            this.graphType.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.graphType.IndicatorColor = System.Drawing.Color.DarkGray;
            this.graphType.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.graphType.IndicatorThickness = 2;
            this.graphType.IsDropdownOpened = false;
            this.graphType.ItemBackColor = System.Drawing.Color.White;
            this.graphType.ItemBorderColor = System.Drawing.Color.White;
            this.graphType.ItemForeColor = System.Drawing.Color.Black;
            this.graphType.ItemHeight = 26;
            this.graphType.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.graphType.ItemHighLightForeColor = System.Drawing.Color.White;
            this.graphType.Items.AddRange(new object[] {
            "PieChart",
            "Line",
            "Bar"});
            this.graphType.ItemTopMargin = 3;
            this.graphType.Location = new System.Drawing.Point(833, 21);
            this.graphType.Name = "graphType";
            this.graphType.Size = new System.Drawing.Size(254, 32);
            this.graphType.TabIndex = 5;
            this.graphType.Text = null;
            this.graphType.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.graphType.TextLeftMargin = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(748, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Graph type :";
            // 
            // optionToRender
            // 
            this.optionToRender.BackColor = System.Drawing.Color.Transparent;
            this.optionToRender.BackgroundColor = System.Drawing.Color.White;
            this.optionToRender.BorderColor = System.Drawing.Color.Silver;
            this.optionToRender.BorderRadius = 1;
            this.optionToRender.Color = System.Drawing.Color.Silver;
            this.optionToRender.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.optionToRender.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.optionToRender.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.optionToRender.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.optionToRender.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.optionToRender.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.optionToRender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.optionToRender.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.optionToRender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.optionToRender.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.optionToRender.FillDropDown = true;
            this.optionToRender.FillIndicator = false;
            this.optionToRender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optionToRender.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.optionToRender.ForeColor = System.Drawing.Color.Black;
            this.optionToRender.FormattingEnabled = true;
            this.optionToRender.Icon = null;
            this.optionToRender.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.optionToRender.IndicatorColor = System.Drawing.Color.DarkGray;
            this.optionToRender.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.optionToRender.IndicatorThickness = 2;
            this.optionToRender.IsDropdownOpened = false;
            this.optionToRender.ItemBackColor = System.Drawing.Color.White;
            this.optionToRender.ItemBorderColor = System.Drawing.Color.White;
            this.optionToRender.ItemForeColor = System.Drawing.Color.Black;
            this.optionToRender.ItemHeight = 26;
            this.optionToRender.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.optionToRender.ItemHighLightForeColor = System.Drawing.Color.White;
            this.optionToRender.ItemTopMargin = 3;
            this.optionToRender.Location = new System.Drawing.Point(482, 21);
            this.optionToRender.Name = "optionToRender";
            this.optionToRender.Size = new System.Drawing.Size(260, 32);
            this.optionToRender.TabIndex = 3;
            this.optionToRender.Text = null;
            this.optionToRender.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.optionToRender.TextLeftMargin = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(355, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Option to render :";
            // 
            // databaseDrop
            // 
            this.databaseDrop.BackColor = System.Drawing.Color.Transparent;
            this.databaseDrop.BackgroundColor = System.Drawing.Color.White;
            this.databaseDrop.BorderColor = System.Drawing.Color.Silver;
            this.databaseDrop.BorderRadius = 1;
            this.databaseDrop.Color = System.Drawing.Color.Silver;
            this.databaseDrop.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.databaseDrop.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.databaseDrop.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.databaseDrop.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.databaseDrop.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.databaseDrop.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.databaseDrop.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.databaseDrop.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.databaseDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.databaseDrop.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.databaseDrop.FillDropDown = true;
            this.databaseDrop.FillIndicator = false;
            this.databaseDrop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.databaseDrop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.databaseDrop.ForeColor = System.Drawing.Color.Black;
            this.databaseDrop.FormattingEnabled = true;
            this.databaseDrop.Icon = null;
            this.databaseDrop.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.databaseDrop.IndicatorColor = System.Drawing.Color.DarkGray;
            this.databaseDrop.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.databaseDrop.IndicatorThickness = 2;
            this.databaseDrop.IsDropdownOpened = false;
            this.databaseDrop.ItemBackColor = System.Drawing.Color.White;
            this.databaseDrop.ItemBorderColor = System.Drawing.Color.White;
            this.databaseDrop.ItemForeColor = System.Drawing.Color.Black;
            this.databaseDrop.ItemHeight = 26;
            this.databaseDrop.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.databaseDrop.ItemHighLightForeColor = System.Drawing.Color.White;
            this.databaseDrop.Items.AddRange(new object[] {
            "Patient",
            "Examen",
            "Anamnese",
            "Patient Follow"});
            this.databaseDrop.ItemTopMargin = 3;
            this.databaseDrop.Location = new System.Drawing.Point(89, 21);
            this.databaseDrop.Name = "databaseDrop";
            this.databaseDrop.Size = new System.Drawing.Size(260, 32);
            this.databaseDrop.TabIndex = 1;
            this.databaseDrop.Text = null;
            this.databaseDrop.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.databaseDrop.TextLeftMargin = 5;
            this.databaseDrop.SelectedIndexChanged += new System.EventHandler(this.databaseDrop_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Database :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1117, 100);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomDataGridViewTextBoxColumn,
            this.prénomDataGridViewTextBoxColumn,
            this.addresseDataGridViewTextBoxColumn,
            this.telDataGridViewTextBoxColumn,
            this.nompèreDataGridViewTextBoxColumn,
            this.nommèreDataGridViewTextBoxColumn,
            this.fonctpèreDataGridViewTextBoxColumn,
            this.fonctmèreDataGridViewTextBoxColumn,
            this.communeDataGridViewTextBoxColumn,
            this.sexeDataGridViewTextBoxColumn,
            this.wilayaDataGridViewTextBoxColumn,
            this.matriculeDataGridViewTextBoxColumn,
            this.nbenffDataGridViewTextBoxColumn,
            this.nbenfgDataGridViewTextBoxColumn,
            this.datenaissDataGridViewTextBoxColumn,
            this.premdateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.patientsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(8, 8);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.Visible = false;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            // 
            // prénomDataGridViewTextBoxColumn
            // 
            this.prénomDataGridViewTextBoxColumn.DataPropertyName = "prénom";
            this.prénomDataGridViewTextBoxColumn.HeaderText = "prénom";
            this.prénomDataGridViewTextBoxColumn.Name = "prénomDataGridViewTextBoxColumn";
            // 
            // addresseDataGridViewTextBoxColumn
            // 
            this.addresseDataGridViewTextBoxColumn.DataPropertyName = "addresse";
            this.addresseDataGridViewTextBoxColumn.HeaderText = "addresse";
            this.addresseDataGridViewTextBoxColumn.Name = "addresseDataGridViewTextBoxColumn";
            // 
            // telDataGridViewTextBoxColumn
            // 
            this.telDataGridViewTextBoxColumn.DataPropertyName = "tel";
            this.telDataGridViewTextBoxColumn.HeaderText = "tel";
            this.telDataGridViewTextBoxColumn.Name = "telDataGridViewTextBoxColumn";
            // 
            // nompèreDataGridViewTextBoxColumn
            // 
            this.nompèreDataGridViewTextBoxColumn.DataPropertyName = "nom_père";
            this.nompèreDataGridViewTextBoxColumn.HeaderText = "nom_père";
            this.nompèreDataGridViewTextBoxColumn.Name = "nompèreDataGridViewTextBoxColumn";
            // 
            // nommèreDataGridViewTextBoxColumn
            // 
            this.nommèreDataGridViewTextBoxColumn.DataPropertyName = "nom_mère";
            this.nommèreDataGridViewTextBoxColumn.HeaderText = "nom_mère";
            this.nommèreDataGridViewTextBoxColumn.Name = "nommèreDataGridViewTextBoxColumn";
            // 
            // fonctpèreDataGridViewTextBoxColumn
            // 
            this.fonctpèreDataGridViewTextBoxColumn.DataPropertyName = "fonct_père";
            this.fonctpèreDataGridViewTextBoxColumn.HeaderText = "fonct_père";
            this.fonctpèreDataGridViewTextBoxColumn.Name = "fonctpèreDataGridViewTextBoxColumn";
            // 
            // fonctmèreDataGridViewTextBoxColumn
            // 
            this.fonctmèreDataGridViewTextBoxColumn.DataPropertyName = "fonct_mère";
            this.fonctmèreDataGridViewTextBoxColumn.HeaderText = "fonct_mère";
            this.fonctmèreDataGridViewTextBoxColumn.Name = "fonctmèreDataGridViewTextBoxColumn";
            // 
            // communeDataGridViewTextBoxColumn
            // 
            this.communeDataGridViewTextBoxColumn.DataPropertyName = "commune";
            this.communeDataGridViewTextBoxColumn.HeaderText = "commune";
            this.communeDataGridViewTextBoxColumn.Name = "communeDataGridViewTextBoxColumn";
            // 
            // sexeDataGridViewTextBoxColumn
            // 
            this.sexeDataGridViewTextBoxColumn.DataPropertyName = "sexe";
            this.sexeDataGridViewTextBoxColumn.HeaderText = "sexe";
            this.sexeDataGridViewTextBoxColumn.Name = "sexeDataGridViewTextBoxColumn";
            // 
            // wilayaDataGridViewTextBoxColumn
            // 
            this.wilayaDataGridViewTextBoxColumn.DataPropertyName = "wilaya";
            this.wilayaDataGridViewTextBoxColumn.HeaderText = "wilaya";
            this.wilayaDataGridViewTextBoxColumn.Name = "wilayaDataGridViewTextBoxColumn";
            // 
            // matriculeDataGridViewTextBoxColumn
            // 
            this.matriculeDataGridViewTextBoxColumn.DataPropertyName = "matricule";
            this.matriculeDataGridViewTextBoxColumn.HeaderText = "matricule";
            this.matriculeDataGridViewTextBoxColumn.Name = "matriculeDataGridViewTextBoxColumn";
            // 
            // nbenffDataGridViewTextBoxColumn
            // 
            this.nbenffDataGridViewTextBoxColumn.DataPropertyName = "nb_enf_f";
            this.nbenffDataGridViewTextBoxColumn.HeaderText = "nb_enf_f";
            this.nbenffDataGridViewTextBoxColumn.Name = "nbenffDataGridViewTextBoxColumn";
            // 
            // nbenfgDataGridViewTextBoxColumn
            // 
            this.nbenfgDataGridViewTextBoxColumn.DataPropertyName = "nb_enf_g";
            this.nbenfgDataGridViewTextBoxColumn.HeaderText = "nb_enf_g";
            this.nbenfgDataGridViewTextBoxColumn.Name = "nbenfgDataGridViewTextBoxColumn";
            // 
            // datenaissDataGridViewTextBoxColumn
            // 
            this.datenaissDataGridViewTextBoxColumn.DataPropertyName = "date_naiss";
            this.datenaissDataGridViewTextBoxColumn.HeaderText = "date_naiss";
            this.datenaissDataGridViewTextBoxColumn.Name = "datenaissDataGridViewTextBoxColumn";
            // 
            // premdateDataGridViewTextBoxColumn
            // 
            this.premdateDataGridViewTextBoxColumn.DataPropertyName = "prem_date";
            this.premdateDataGridViewTextBoxColumn.HeaderText = "prem_date";
            this.premdateDataGridViewTextBoxColumn.Name = "premdateDataGridViewTextBoxColumn";
            // 
            // patientsBindingSource
            // 
            this.patientsBindingSource.DataMember = "Patients";
            this.patientsBindingSource.DataSource = this.mALADES4DataSet;
            // 
            // mALADES4DataSet
            // 
            this.mALADES4DataSet.DataSetName = "MALADES4DataSet";
            this.mALADES4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1029, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Render";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bunifuChartCanvas3);
            this.panel2.Controls.Add(this.bunifuChartCanvas2);
            this.panel2.Controls.Add(this.bunifuChartCanvas1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.nav_left);
            this.panel2.Controls.Add(this.nav_right);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1117, 421);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // bunifuChartCanvas3
            // 
            this.bunifuChartCanvas3.AnimationDuration = 1000;
            this.bunifuChartCanvas3.AnimationType = Bunifu.Charts.WinForms.BunifuChartCanvas.AnimationOptions.easeOutQuart;
            this.bunifuChartCanvas3.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuChartCanvas3.CanvasPadding = new System.Windows.Forms.Padding(0);
            this.bunifuChartCanvas3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuChartCanvas3.Labels = null;
            this.bunifuChartCanvas3.LegendAlignment = Bunifu.Charts.WinForms.BunifuChartCanvas.LegendAlignmentOptions.center;
            this.bunifuChartCanvas3.LegendDisplay = true;
            this.bunifuChartCanvas3.LegendFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuChartCanvas3.LegendForeColor = System.Drawing.Color.DarkGray;
            this.bunifuChartCanvas3.LegendFullWidth = true;
            this.bunifuChartCanvas3.LegendPosition = Bunifu.Charts.WinForms.BunifuChartCanvas.PositionOptions.top;
            this.bunifuChartCanvas3.LegendRevese = false;
            this.bunifuChartCanvas3.LegendRTL = false;
            this.bunifuChartCanvas3.Location = new System.Drawing.Point(0, 0);
            this.bunifuChartCanvas3.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.bunifuChartCanvas3.Name = "bunifuChartCanvas3";
            this.bunifuChartCanvas3.ShowXAxis = true;
            this.bunifuChartCanvas3.ShowYAxis = true;
            this.bunifuChartCanvas3.Size = new System.Drawing.Size(1117, 321);
            this.bunifuChartCanvas3.TabIndex = 7;
            this.bunifuChartCanvas3.Title = "";
            this.bunifuChartCanvas3.TitleLineHeight = 1.2D;
            this.bunifuChartCanvas3.TitlePadding = 10;
            this.bunifuChartCanvas3.TitlePosition = Bunifu.Charts.WinForms.BunifuChartCanvas.PositionOptions.top;
            this.bunifuChartCanvas3.TooltipBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuChartCanvas3.TooltipFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuChartCanvas3.TooltipForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuChartCanvas3.TooltipMode = Bunifu.Charts.WinForms.BunifuChartCanvas.TooltipModeOptions.nearest;
            this.bunifuChartCanvas3.TooltipsEnabled = true;
            this.bunifuChartCanvas3.XAxesBeginAtZero = true;
            this.bunifuChartCanvas3.XAxesDrawTicks = true;
            this.bunifuChartCanvas3.XAxesFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuChartCanvas3.XAxesForeColor = System.Drawing.SystemColors.ControlText;
            this.bunifuChartCanvas3.XAxesGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuChartCanvas3.XAxesGridLines = true;
            this.bunifuChartCanvas3.XAxesLabel = "";
            this.bunifuChartCanvas3.XAxesLabelFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuChartCanvas3.XAxesLabelForeColor = System.Drawing.SystemColors.ControlText;
            this.bunifuChartCanvas3.XAxesLineWidth = 1;
            this.bunifuChartCanvas3.XAxesStacked = false;
            this.bunifuChartCanvas3.XAxesZeroLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuChartCanvas3.XAxesZeroLineWidth = 1;
            this.bunifuChartCanvas3.YAxesBeginAtZero = true;
            this.bunifuChartCanvas3.YAxesDrawTicks = true;
            this.bunifuChartCanvas3.YAxesFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuChartCanvas3.YAxesForeColor = System.Drawing.SystemColors.ControlText;
            this.bunifuChartCanvas3.YAxesGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuChartCanvas3.YAxesGridLines = true;
            this.bunifuChartCanvas3.YAxesLabel = "";
            this.bunifuChartCanvas3.YAxesLabelFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuChartCanvas3.YAxesLabelForeColor = System.Drawing.SystemColors.ControlText;
            this.bunifuChartCanvas3.YAxesLineWidth = 1;
            this.bunifuChartCanvas3.YAxesStacked = false;
            this.bunifuChartCanvas3.YAxesZeroLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuChartCanvas3.YAxesZeroLineWidth = 1;
            // 
            // bunifuChartCanvas2
            // 
            this.bunifuChartCanvas2.AnimationDuration = 1000;
            this.bunifuChartCanvas2.AnimationType = Bunifu.Charts.WinForms.BunifuChartCanvas.AnimationOptions.easeOutQuart;
            this.bunifuChartCanvas2.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuChartCanvas2.CanvasPadding = new System.Windows.Forms.Padding(0);
            this.bunifuChartCanvas2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuChartCanvas2.Labels = null;
            this.bunifuChartCanvas2.LegendAlignment = Bunifu.Charts.WinForms.BunifuChartCanvas.LegendAlignmentOptions.center;
            this.bunifuChartCanvas2.LegendDisplay = true;
            this.bunifuChartCanvas2.LegendFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuChartCanvas2.LegendForeColor = System.Drawing.Color.DarkGray;
            this.bunifuChartCanvas2.LegendFullWidth = true;
            this.bunifuChartCanvas2.LegendPosition = Bunifu.Charts.WinForms.BunifuChartCanvas.PositionOptions.top;
            this.bunifuChartCanvas2.LegendRevese = false;
            this.bunifuChartCanvas2.LegendRTL = false;
            this.bunifuChartCanvas2.Location = new System.Drawing.Point(0, 0);
            this.bunifuChartCanvas2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.bunifuChartCanvas2.Name = "bunifuChartCanvas2";
            this.bunifuChartCanvas2.ShowXAxis = true;
            this.bunifuChartCanvas2.ShowYAxis = true;
            this.bunifuChartCanvas2.Size = new System.Drawing.Size(1117, 321);
            this.bunifuChartCanvas2.TabIndex = 6;
            this.bunifuChartCanvas2.Title = "";
            this.bunifuChartCanvas2.TitleLineHeight = 1.2D;
            this.bunifuChartCanvas2.TitlePadding = 10;
            this.bunifuChartCanvas2.TitlePosition = Bunifu.Charts.WinForms.BunifuChartCanvas.PositionOptions.top;
            this.bunifuChartCanvas2.TooltipBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuChartCanvas2.TooltipFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuChartCanvas2.TooltipForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuChartCanvas2.TooltipMode = Bunifu.Charts.WinForms.BunifuChartCanvas.TooltipModeOptions.nearest;
            this.bunifuChartCanvas2.TooltipsEnabled = true;
            this.bunifuChartCanvas2.XAxesBeginAtZero = true;
            this.bunifuChartCanvas2.XAxesDrawTicks = true;
            this.bunifuChartCanvas2.XAxesFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuChartCanvas2.XAxesForeColor = System.Drawing.SystemColors.ControlText;
            this.bunifuChartCanvas2.XAxesGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuChartCanvas2.XAxesGridLines = true;
            this.bunifuChartCanvas2.XAxesLabel = "";
            this.bunifuChartCanvas2.XAxesLabelFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuChartCanvas2.XAxesLabelForeColor = System.Drawing.SystemColors.ControlText;
            this.bunifuChartCanvas2.XAxesLineWidth = 1;
            this.bunifuChartCanvas2.XAxesStacked = false;
            this.bunifuChartCanvas2.XAxesZeroLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuChartCanvas2.XAxesZeroLineWidth = 1;
            this.bunifuChartCanvas2.YAxesBeginAtZero = true;
            this.bunifuChartCanvas2.YAxesDrawTicks = true;
            this.bunifuChartCanvas2.YAxesFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuChartCanvas2.YAxesForeColor = System.Drawing.SystemColors.ControlText;
            this.bunifuChartCanvas2.YAxesGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuChartCanvas2.YAxesGridLines = true;
            this.bunifuChartCanvas2.YAxesLabel = "";
            this.bunifuChartCanvas2.YAxesLabelFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuChartCanvas2.YAxesLabelForeColor = System.Drawing.SystemColors.ControlText;
            this.bunifuChartCanvas2.YAxesLineWidth = 1;
            this.bunifuChartCanvas2.YAxesStacked = false;
            this.bunifuChartCanvas2.YAxesZeroLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuChartCanvas2.YAxesZeroLineWidth = 1;
            // 
            // bunifuChartCanvas1
            // 
            this.bunifuChartCanvas1.AnimationDuration = 1000;
            this.bunifuChartCanvas1.AnimationType = Bunifu.Charts.WinForms.BunifuChartCanvas.AnimationOptions.easeOutQuart;
            this.bunifuChartCanvas1.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuChartCanvas1.CanvasPadding = new System.Windows.Forms.Padding(0);
            this.bunifuChartCanvas1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuChartCanvas1.Labels = null;
            this.bunifuChartCanvas1.LegendAlignment = Bunifu.Charts.WinForms.BunifuChartCanvas.LegendAlignmentOptions.center;
            this.bunifuChartCanvas1.LegendDisplay = true;
            this.bunifuChartCanvas1.LegendFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuChartCanvas1.LegendForeColor = System.Drawing.Color.DarkGray;
            this.bunifuChartCanvas1.LegendFullWidth = true;
            this.bunifuChartCanvas1.LegendPosition = Bunifu.Charts.WinForms.BunifuChartCanvas.PositionOptions.top;
            this.bunifuChartCanvas1.LegendRevese = false;
            this.bunifuChartCanvas1.LegendRTL = false;
            this.bunifuChartCanvas1.Location = new System.Drawing.Point(0, 0);
            this.bunifuChartCanvas1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bunifuChartCanvas1.Name = "bunifuChartCanvas1";
            this.bunifuChartCanvas1.ShowXAxis = true;
            this.bunifuChartCanvas1.ShowYAxis = true;
            this.bunifuChartCanvas1.Size = new System.Drawing.Size(1117, 321);
            this.bunifuChartCanvas1.TabIndex = 4;
            this.bunifuChartCanvas1.Title = "";
            this.bunifuChartCanvas1.TitleLineHeight = 1.2D;
            this.bunifuChartCanvas1.TitlePadding = 10;
            this.bunifuChartCanvas1.TitlePosition = Bunifu.Charts.WinForms.BunifuChartCanvas.PositionOptions.top;
            this.bunifuChartCanvas1.TooltipBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuChartCanvas1.TooltipFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuChartCanvas1.TooltipForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuChartCanvas1.TooltipMode = Bunifu.Charts.WinForms.BunifuChartCanvas.TooltipModeOptions.nearest;
            this.bunifuChartCanvas1.TooltipsEnabled = true;
            this.bunifuChartCanvas1.XAxesBeginAtZero = true;
            this.bunifuChartCanvas1.XAxesDrawTicks = true;
            this.bunifuChartCanvas1.XAxesFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuChartCanvas1.XAxesForeColor = System.Drawing.SystemColors.ControlText;
            this.bunifuChartCanvas1.XAxesGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuChartCanvas1.XAxesGridLines = true;
            this.bunifuChartCanvas1.XAxesLabel = "";
            this.bunifuChartCanvas1.XAxesLabelFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuChartCanvas1.XAxesLabelForeColor = System.Drawing.SystemColors.ControlText;
            this.bunifuChartCanvas1.XAxesLineWidth = 1;
            this.bunifuChartCanvas1.XAxesStacked = false;
            this.bunifuChartCanvas1.XAxesZeroLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuChartCanvas1.XAxesZeroLineWidth = 1;
            this.bunifuChartCanvas1.YAxesBeginAtZero = true;
            this.bunifuChartCanvas1.YAxesDrawTicks = true;
            this.bunifuChartCanvas1.YAxesFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuChartCanvas1.YAxesForeColor = System.Drawing.SystemColors.ControlText;
            this.bunifuChartCanvas1.YAxesGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuChartCanvas1.YAxesGridLines = true;
            this.bunifuChartCanvas1.YAxesLabel = "";
            this.bunifuChartCanvas1.YAxesLabelFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuChartCanvas1.YAxesLabelForeColor = System.Drawing.SystemColors.ControlText;
            this.bunifuChartCanvas1.YAxesLineWidth = 1;
            this.bunifuChartCanvas1.YAxesStacked = false;
            this.bunifuChartCanvas1.YAxesZeroLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuChartCanvas1.YAxesZeroLineWidth = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(943, 381);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // nav_left
            // 
            this.nav_left.FlatAppearance.BorderSize = 0;
            this.nav_left.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nav_left.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft;
            this.nav_left.IconColor = System.Drawing.Color.LightSlateGray;
            this.nav_left.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.nav_left.IconSize = 30;
            this.nav_left.Location = new System.Drawing.Point(12, 376);
            this.nav_left.Name = "nav_left";
            this.nav_left.Size = new System.Drawing.Size(75, 33);
            this.nav_left.TabIndex = 2;
            this.nav_left.UseVisualStyleBackColor = true;
            this.nav_left.Click += new System.EventHandler(this.nav_left_Click);
            // 
            // nav_right
            // 
            this.nav_right.FlatAppearance.BorderSize = 0;
            this.nav_right.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nav_right.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleRight;
            this.nav_right.IconColor = System.Drawing.Color.LightSlateGray;
            this.nav_right.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.nav_right.IconSize = 30;
            this.nav_right.Location = new System.Drawing.Point(1024, 376);
            this.nav_right.Name = "nav_right";
            this.nav_right.Size = new System.Drawing.Size(75, 33);
            this.nav_right.TabIndex = 1;
            this.nav_right.UseVisualStyleBackColor = true;
            this.nav_right.Click += new System.EventHandler(this.nav_right_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 321);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1117, 100);
            this.panel3.TabIndex = 5;
            // 
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
            // 
            // bunifuPieChart1
            // 
            this.bunifuPieChart1.BackgroundColor = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("bunifuPieChart1.BackgroundColor")));
            this.bunifuPieChart1.BorderColor = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("bunifuPieChart1.BorderColor")));
            this.bunifuPieChart1.BorderWidth = 0;
            this.bunifuPieChart1.Data = ((System.Collections.Generic.List<double>)(resources.GetObject("bunifuPieChart1.Data")));
            this.bunifuPieChart1.HoverBackgroundColor = System.Drawing.Color.Empty;
            this.bunifuPieChart1.HoverBorderColor = System.Drawing.Color.Empty;
            this.bunifuPieChart1.HoverBorderWidth = 0;
            this.bunifuPieChart1.Label = "Label here";
            this.bunifuPieChart1.TargetCanvas = this.bunifuChartCanvas1;
            // 
            // bunifuLineChart1
            // 
            this.bunifuLineChart1.BackgroundColor = System.Drawing.Color.Indigo;
            this.bunifuLineChart1.BorderCapStyle = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.LineCaps.Butt;
            this.bunifuLineChart1.BorderColor = System.Drawing.Color.Purple;
            this.bunifuLineChart1.BorderDash = null;
            this.bunifuLineChart1.BorderDashOffset = 0D;
            this.bunifuLineChart1.BorderJoin = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.BorderJoinStyles.Miter;
            this.bunifuLineChart1.BorderWidth = 3;
            this.bunifuLineChart1.CubicInterpolationMode = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.CubicInterpolationModes.Default;
            this.bunifuLineChart1.Data = ((System.Collections.Generic.List<double>)(resources.GetObject("bunifuLineChart1.Data")));
            this.bunifuLineChart1.Fill = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.FillOptions.Blank;
            this.bunifuLineChart1.Label = "Line Chart";
            this.bunifuLineChart1.LineTension = 0.4D;
            this.bunifuLineChart1.Order = 0;
            this.bunifuLineChart1.PointBackgroundColor = System.Drawing.Color.Empty;
            this.bunifuLineChart1.PointBorderColor = System.Drawing.Color.Empty;
            this.bunifuLineChart1.PointBorderWidth = 1;
            this.bunifuLineChart1.PointHitRadius = 1;
            this.bunifuLineChart1.PointHoverBackgroundColor = System.Drawing.Color.Empty;
            this.bunifuLineChart1.PointHoverBorderColor = System.Drawing.Color.Empty;
            this.bunifuLineChart1.PointHoverBorderWidth = 4;
            this.bunifuLineChart1.PointHoverRadius = 1;
            this.bunifuLineChart1.PointRadius = 3;
            this.bunifuLineChart1.PointRotation = 0;
            this.bunifuLineChart1.PointStyle = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.PointStyles.Circle;
            this.bunifuLineChart1.ShowLine = true;
            this.bunifuLineChart1.SpanGaps = false;
            this.bunifuLineChart1.SteppedLine = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.SteppedLineStyles.False;
            this.bunifuLineChart1.TargetCanvas = this.bunifuChartCanvas2;
            // 
            // bunifuBarChart1
            // 
            this.bunifuBarChart1.BackgroundColor = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("bunifuBarChart1.BackgroundColor")));
            this.bunifuBarChart1.BorderColor = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("bunifuBarChart1.BorderColor")));
            this.bunifuBarChart1.BorderSkipped = null;
            this.bunifuBarChart1.BorderWidth = 0;
            this.bunifuBarChart1.Data = ((System.Collections.Generic.List<double>)(resources.GetObject("bunifuBarChart1.Data")));
            this.bunifuBarChart1.HoverBackgroundColor = System.Drawing.Color.Empty;
            this.bunifuBarChart1.HoverBorderColor = System.Drawing.Color.Empty;
            this.bunifuBarChart1.HoverBorderWidth = 0;
            this.bunifuBarChart1.Label = "Label here";
            this.bunifuBarChart1.TargetCanvas = this.bunifuChartCanvas3;
            // 
            // stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 521);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.optionSel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "stats";
            this.Text = "stats";
            this.Load += new System.EventHandler(this.stats_Load);
            this.optionSel.ResumeLayout(false);
            this.optionSel.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mALADES4DataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox optionSel;
        private Bunifu.UI.WinForms.BunifuDropdown graphType;
        private System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForms.BunifuDropdown optionToRender;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuDropdown databaseDrop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private MALADES4DataSet mALADES4DataSet;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private MALADES4DataSetTableAdapters.PatientsTableAdapter patientsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prénomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nompèreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nommèreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fonctpèreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fonctmèreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn communeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wilayaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matriculeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbenffDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbenfgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datenaissDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn premdateDataGridViewTextBoxColumn;
        private FontAwesome.Sharp.IconButton nav_left;
        private FontAwesome.Sharp.IconButton nav_right;
        private System.Windows.Forms.Button button2;
        private Bunifu.Charts.WinForms.BunifuChartCanvas bunifuChartCanvas1;
        private Bunifu.Charts.WinForms.ChartTypes.BunifuPieChart bunifuPieChart1;
        private Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart bunifuLineChart1;
        private Bunifu.Charts.WinForms.ChartTypes.BunifuBarChart bunifuBarChart1;
        private Bunifu.Charts.WinForms.BunifuChartCanvas bunifuChartCanvas3;
        private Bunifu.Charts.WinForms.BunifuChartCanvas bunifuChartCanvas2;
        private System.Windows.Forms.Panel panel3;
    }
}