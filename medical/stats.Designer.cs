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
            this.optionSel = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.databaseDrop = new Bunifu.UI.WinForms.BunifuDropdown();
            this.label2 = new System.Windows.Forms.Label();
            this.optionToRender = new Bunifu.UI.WinForms.BunifuDropdown();
            this.label3 = new System.Windows.Forms.Label();
            this.graphType = new Bunifu.UI.WinForms.BunifuDropdown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.bunifuDatavizBasic1 = new Bunifu.Dataviz.WinForms.BunifuDatavizBasic();
            this.mALADES4DataSet = new medical.MALADES4DataSet();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientsTableAdapter = new medical.MALADES4DataSetTableAdapters.PatientsTableAdapter();
            this.premdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datenaissDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbenfgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbenffDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matriculeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wilayaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.communeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fonctmèreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fonctpèreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nommèreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nompèreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prénomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.optionSel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mALADES4DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Database :";
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
            "Anamnese"});
            this.databaseDrop.ItemTopMargin = 3;
            this.databaseDrop.Location = new System.Drawing.Point(89, 21);
            this.databaseDrop.Name = "databaseDrop";
            this.databaseDrop.Size = new System.Drawing.Size(260, 32);
            this.databaseDrop.TabIndex = 1;
            this.databaseDrop.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.databaseDrop.TextLeftMargin = 5;
            this.databaseDrop.SelectedIndexChanged += new System.EventHandler(this.databaseDrop_SelectedIndexChanged);
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
            this.optionToRender.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.optionToRender.TextLeftMargin = 5;
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
            this.graphType.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.graphType.TextLeftMargin = 5;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.bunifuDatavizBasic1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1117, 421);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
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
            // bunifuDatavizBasic1
            // 
            this.bunifuDatavizBasic1.animationEnabled = false;
            this.bunifuDatavizBasic1.AxisLineColor = System.Drawing.Color.LightGray;
            this.bunifuDatavizBasic1.AxisXFontColor = System.Drawing.Color.Gray;
            this.bunifuDatavizBasic1.AxisXGridColor = System.Drawing.Color.Gray;
            this.bunifuDatavizBasic1.AxisXGridThickness = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bunifuDatavizBasic1.AxisYFontColor = System.Drawing.Color.Gray;
            this.bunifuDatavizBasic1.AxisYGridColor = System.Drawing.Color.Gray;
            this.bunifuDatavizBasic1.AxisYGridThickness = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bunifuDatavizBasic1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuDatavizBasic1.Location = new System.Drawing.Point(12, 6);
            this.bunifuDatavizBasic1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bunifuDatavizBasic1.Name = "bunifuDatavizBasic1";
            this.bunifuDatavizBasic1.Size = new System.Drawing.Size(1092, 403);
            this.bunifuDatavizBasic1.TabIndex = 0;
            this.bunifuDatavizBasic1.Theme = Bunifu.Dataviz.WinForms.BunifuDatavizBasic._theme.theme1;
            this.bunifuDatavizBasic1.Title = "";
            // 
            // mALADES4DataSet
            // 
            this.mALADES4DataSet.DataSetName = "MALADES4DataSet";
            this.mALADES4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientsBindingSource
            // 
            this.patientsBindingSource.DataMember = "Patients";
            this.patientsBindingSource.DataSource = this.mALADES4DataSet;
            // 
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
            // 
            // premdateDataGridViewTextBoxColumn
            // 
            this.premdateDataGridViewTextBoxColumn.DataPropertyName = "prem_date";
            this.premdateDataGridViewTextBoxColumn.HeaderText = "prem_date";
            this.premdateDataGridViewTextBoxColumn.Name = "premdateDataGridViewTextBoxColumn";
            // 
            // datenaissDataGridViewTextBoxColumn
            // 
            this.datenaissDataGridViewTextBoxColumn.DataPropertyName = "date_naiss";
            this.datenaissDataGridViewTextBoxColumn.HeaderText = "date_naiss";
            this.datenaissDataGridViewTextBoxColumn.Name = "datenaissDataGridViewTextBoxColumn";
            // 
            // nbenfgDataGridViewTextBoxColumn
            // 
            this.nbenfgDataGridViewTextBoxColumn.DataPropertyName = "nb_enf_g";
            this.nbenfgDataGridViewTextBoxColumn.HeaderText = "nb_enf_g";
            this.nbenfgDataGridViewTextBoxColumn.Name = "nbenfgDataGridViewTextBoxColumn";
            // 
            // nbenffDataGridViewTextBoxColumn
            // 
            this.nbenffDataGridViewTextBoxColumn.DataPropertyName = "nb_enf_f";
            this.nbenffDataGridViewTextBoxColumn.HeaderText = "nb_enf_f";
            this.nbenffDataGridViewTextBoxColumn.Name = "nbenffDataGridViewTextBoxColumn";
            // 
            // matriculeDataGridViewTextBoxColumn
            // 
            this.matriculeDataGridViewTextBoxColumn.DataPropertyName = "matricule";
            this.matriculeDataGridViewTextBoxColumn.HeaderText = "matricule";
            this.matriculeDataGridViewTextBoxColumn.Name = "matriculeDataGridViewTextBoxColumn";
            // 
            // wilayaDataGridViewTextBoxColumn
            // 
            this.wilayaDataGridViewTextBoxColumn.DataPropertyName = "wilaya";
            this.wilayaDataGridViewTextBoxColumn.HeaderText = "wilaya";
            this.wilayaDataGridViewTextBoxColumn.Name = "wilayaDataGridViewTextBoxColumn";
            // 
            // sexeDataGridViewTextBoxColumn
            // 
            this.sexeDataGridViewTextBoxColumn.DataPropertyName = "sexe";
            this.sexeDataGridViewTextBoxColumn.HeaderText = "sexe";
            this.sexeDataGridViewTextBoxColumn.Name = "sexeDataGridViewTextBoxColumn";
            // 
            // communeDataGridViewTextBoxColumn
            // 
            this.communeDataGridViewTextBoxColumn.DataPropertyName = "commune";
            this.communeDataGridViewTextBoxColumn.HeaderText = "commune";
            this.communeDataGridViewTextBoxColumn.Name = "communeDataGridViewTextBoxColumn";
            // 
            // fonctmèreDataGridViewTextBoxColumn
            // 
            this.fonctmèreDataGridViewTextBoxColumn.DataPropertyName = "fonct_mère";
            this.fonctmèreDataGridViewTextBoxColumn.HeaderText = "fonct_mère";
            this.fonctmèreDataGridViewTextBoxColumn.Name = "fonctmèreDataGridViewTextBoxColumn";
            // 
            // fonctpèreDataGridViewTextBoxColumn
            // 
            this.fonctpèreDataGridViewTextBoxColumn.DataPropertyName = "fonct_père";
            this.fonctpèreDataGridViewTextBoxColumn.HeaderText = "fonct_père";
            this.fonctpèreDataGridViewTextBoxColumn.Name = "fonctpèreDataGridViewTextBoxColumn";
            // 
            // nommèreDataGridViewTextBoxColumn
            // 
            this.nommèreDataGridViewTextBoxColumn.DataPropertyName = "nom_mère";
            this.nommèreDataGridViewTextBoxColumn.HeaderText = "nom_mère";
            this.nommèreDataGridViewTextBoxColumn.Name = "nommèreDataGridViewTextBoxColumn";
            // 
            // nompèreDataGridViewTextBoxColumn
            // 
            this.nompèreDataGridViewTextBoxColumn.DataPropertyName = "nom_père";
            this.nompèreDataGridViewTextBoxColumn.HeaderText = "nom_père";
            this.nompèreDataGridViewTextBoxColumn.Name = "nompèreDataGridViewTextBoxColumn";
            // 
            // telDataGridViewTextBoxColumn
            // 
            this.telDataGridViewTextBoxColumn.DataPropertyName = "tel";
            this.telDataGridViewTextBoxColumn.HeaderText = "tel";
            this.telDataGridViewTextBoxColumn.Name = "telDataGridViewTextBoxColumn";
            // 
            // addresseDataGridViewTextBoxColumn
            // 
            this.addresseDataGridViewTextBoxColumn.DataPropertyName = "addresse";
            this.addresseDataGridViewTextBoxColumn.HeaderText = "addresse";
            this.addresseDataGridViewTextBoxColumn.Name = "addresseDataGridViewTextBoxColumn";
            // 
            // prénomDataGridViewTextBoxColumn
            // 
            this.prénomDataGridViewTextBoxColumn.DataPropertyName = "prénom";
            this.prénomDataGridViewTextBoxColumn.HeaderText = "prénom";
            this.prénomDataGridViewTextBoxColumn.Name = "prénomDataGridViewTextBoxColumn";
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
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
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mALADES4DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private Bunifu.Dataviz.WinForms.BunifuDatavizBasic bunifuDatavizBasic1;
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
    }
}