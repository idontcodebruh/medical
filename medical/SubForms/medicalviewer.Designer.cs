namespace medical
{
    partial class medicalviewer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.loadtaille = new System.Windows.Forms.TextBox();
            this.loadpoids = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prénomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matriculeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datenaissDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datecouranteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnosticDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.analysesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tailleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poidsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maladieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examensBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mALADES4DataSet = new medical.MALADES4DataSet();
            this.loadnaissance = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuDropdown1 = new Bunifu.UI.WinForms.BunifuDropdown();
            this.label2 = new System.Windows.Forms.Label();
            this.loadname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.examensTableAdapter = new medical.MALADES4DataSetTableAdapters.ExamensTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examensBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mALADES4DataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.loadtaille);
            this.groupBox1.Controls.Add(this.loadpoids);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.loadnaissance);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.bunifuDropdown1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.loadname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 169);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Global Information";
            // 
            // loadtaille
            // 
            this.loadtaille.Location = new System.Drawing.Point(58, 98);
            this.loadtaille.Name = "loadtaille";
            this.loadtaille.Size = new System.Drawing.Size(262, 22);
            this.loadtaille.TabIndex = 11;
            // 
            // loadpoids
            // 
            this.loadpoids.Location = new System.Drawing.Point(58, 65);
            this.loadpoids.Name = "loadpoids";
            this.loadpoids.Size = new System.Drawing.Size(262, 22);
            this.loadpoids.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomDataGridViewTextBoxColumn,
            this.prénomDataGridViewTextBoxColumn,
            this.matriculeDataGridViewTextBoxColumn,
            this.datenaissDataGridViewTextBoxColumn,
            this.datecouranteDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.objetDataGridViewTextBoxColumn,
            this.diagnosticDataGridViewTextBoxColumn,
            this.analysesDataGridViewTextBoxColumn,
            this.tailleDataGridViewTextBoxColumn,
            this.pCDataGridViewTextBoxColumn,
            this.poidsDataGridViewTextBoxColumn,
            this.maladieDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.examensBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(310, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(10, 10);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.Visible = false;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prénomDataGridViewTextBoxColumn
            // 
            this.prénomDataGridViewTextBoxColumn.DataPropertyName = "prénom";
            this.prénomDataGridViewTextBoxColumn.HeaderText = "prénom";
            this.prénomDataGridViewTextBoxColumn.Name = "prénomDataGridViewTextBoxColumn";
            this.prénomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // matriculeDataGridViewTextBoxColumn
            // 
            this.matriculeDataGridViewTextBoxColumn.DataPropertyName = "matricule";
            this.matriculeDataGridViewTextBoxColumn.HeaderText = "matricule";
            this.matriculeDataGridViewTextBoxColumn.Name = "matriculeDataGridViewTextBoxColumn";
            this.matriculeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datenaissDataGridViewTextBoxColumn
            // 
            this.datenaissDataGridViewTextBoxColumn.DataPropertyName = "date_naiss";
            this.datenaissDataGridViewTextBoxColumn.HeaderText = "date_naiss";
            this.datenaissDataGridViewTextBoxColumn.Name = "datenaissDataGridViewTextBoxColumn";
            this.datenaissDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datecouranteDataGridViewTextBoxColumn
            // 
            this.datecouranteDataGridViewTextBoxColumn.DataPropertyName = "date_courante";
            this.datecouranteDataGridViewTextBoxColumn.HeaderText = "date_courante";
            this.datecouranteDataGridViewTextBoxColumn.Name = "datecouranteDataGridViewTextBoxColumn";
            this.datecouranteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // objetDataGridViewTextBoxColumn
            // 
            this.objetDataGridViewTextBoxColumn.DataPropertyName = "objet";
            this.objetDataGridViewTextBoxColumn.HeaderText = "objet";
            this.objetDataGridViewTextBoxColumn.Name = "objetDataGridViewTextBoxColumn";
            this.objetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diagnosticDataGridViewTextBoxColumn
            // 
            this.diagnosticDataGridViewTextBoxColumn.DataPropertyName = "diagnostic";
            this.diagnosticDataGridViewTextBoxColumn.HeaderText = "diagnostic";
            this.diagnosticDataGridViewTextBoxColumn.Name = "diagnosticDataGridViewTextBoxColumn";
            this.diagnosticDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // analysesDataGridViewTextBoxColumn
            // 
            this.analysesDataGridViewTextBoxColumn.DataPropertyName = "Analyses";
            this.analysesDataGridViewTextBoxColumn.HeaderText = "Analyses";
            this.analysesDataGridViewTextBoxColumn.Name = "analysesDataGridViewTextBoxColumn";
            this.analysesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tailleDataGridViewTextBoxColumn
            // 
            this.tailleDataGridViewTextBoxColumn.DataPropertyName = "taille";
            this.tailleDataGridViewTextBoxColumn.HeaderText = "taille";
            this.tailleDataGridViewTextBoxColumn.Name = "tailleDataGridViewTextBoxColumn";
            this.tailleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pCDataGridViewTextBoxColumn
            // 
            this.pCDataGridViewTextBoxColumn.DataPropertyName = "P_C";
            this.pCDataGridViewTextBoxColumn.HeaderText = "P_C";
            this.pCDataGridViewTextBoxColumn.Name = "pCDataGridViewTextBoxColumn";
            this.pCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // poidsDataGridViewTextBoxColumn
            // 
            this.poidsDataGridViewTextBoxColumn.DataPropertyName = "poids";
            this.poidsDataGridViewTextBoxColumn.HeaderText = "poids";
            this.poidsDataGridViewTextBoxColumn.Name = "poidsDataGridViewTextBoxColumn";
            this.poidsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maladieDataGridViewTextBoxColumn
            // 
            this.maladieDataGridViewTextBoxColumn.DataPropertyName = "maladie";
            this.maladieDataGridViewTextBoxColumn.HeaderText = "maladie";
            this.maladieDataGridViewTextBoxColumn.Name = "maladieDataGridViewTextBoxColumn";
            this.maladieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // examensBindingSource
            // 
            this.examensBindingSource.DataMember = "Examens";
            this.examensBindingSource.DataSource = this.mALADES4DataSet;
            // 
            // mALADES4DataSet
            // 
            this.mALADES4DataSet.DataSetName = "MALADES4DataSet";
            this.mALADES4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loadnaissance
            // 
            this.loadnaissance.AutoSize = true;
            this.loadnaissance.Location = new System.Drawing.Point(121, 42);
            this.loadnaissance.Name = "loadnaissance";
            this.loadnaissance.Size = new System.Drawing.Size(0, 14);
            this.loadnaissance.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 14);
            this.label5.TabIndex = 6;
            this.label5.Text = "Taille:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 14);
            this.label4.TabIndex = 5;
            this.label4.Text = "Poids:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date naissance:";
            // 
            // bunifuDropdown1
            // 
            this.bunifuDropdown1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdown1.BackgroundColor = System.Drawing.Color.White;
            this.bunifuDropdown1.BorderColor = System.Drawing.Color.Silver;
            this.bunifuDropdown1.BorderRadius = 1;
            this.bunifuDropdown1.Color = System.Drawing.Color.Silver;
            this.bunifuDropdown1.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.bunifuDropdown1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.bunifuDropdown1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuDropdown1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.bunifuDropdown1.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.bunifuDropdown1.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.bunifuDropdown1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.bunifuDropdown1.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.bunifuDropdown1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bunifuDropdown1.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.bunifuDropdown1.FillDropDown = true;
            this.bunifuDropdown1.FillIndicator = false;
            this.bunifuDropdown1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuDropdown1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuDropdown1.ForeColor = System.Drawing.Color.Black;
            this.bunifuDropdown1.FormattingEnabled = true;
            this.bunifuDropdown1.Icon = null;
            this.bunifuDropdown1.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.bunifuDropdown1.IndicatorColor = System.Drawing.Color.DarkGray;
            this.bunifuDropdown1.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.bunifuDropdown1.IndicatorThickness = 2;
            this.bunifuDropdown1.IsDropdownOpened = false;
            this.bunifuDropdown1.ItemBackColor = System.Drawing.Color.White;
            this.bunifuDropdown1.ItemBorderColor = System.Drawing.Color.White;
            this.bunifuDropdown1.ItemForeColor = System.Drawing.Color.Black;
            this.bunifuDropdown1.ItemHeight = 26;
            this.bunifuDropdown1.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.bunifuDropdown1.ItemHighLightForeColor = System.Drawing.Color.White;
            this.bunifuDropdown1.ItemTopMargin = 3;
            this.bunifuDropdown1.Location = new System.Drawing.Point(117, 131);
            this.bunifuDropdown1.Name = "bunifuDropdown1";
            this.bunifuDropdown1.Size = new System.Drawing.Size(203, 32);
            this.bunifuDropdown1.TabIndex = 3;
            this.bunifuDropdown1.Text = null;
            this.bunifuDropdown1.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.bunifuDropdown1.TextLeftMargin = 5;
            this.bunifuDropdown1.SelectedIndexChanged += new System.EventHandler(this.bunifuDropdown1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date courante:";
            // 
            // loadname
            // 
            this.loadname.AutoSize = true;
            this.loadname.Location = new System.Drawing.Point(138, 18);
            this.loadname.Name = "loadname";
            this.loadname.Size = new System.Drawing.Size(0, 14);
            this.loadname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient Full Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(905, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 151);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Toolbox";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // examensTableAdapter
            // 
            this.examensTableAdapter.ClearBeforeFill = true;
            // 
            // medicalviewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 521);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "medicalviewer";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.medicalviewer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examensBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mALADES4DataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuDropdown bunifuDropdown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label loadname;
        private System.Windows.Forms.Label loadnaissance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MALADES4DataSet mALADES4DataSet;
        private System.Windows.Forms.BindingSource examensBindingSource;
        private MALADES4DataSetTableAdapters.ExamensTableAdapter examensTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prénomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matriculeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datenaissDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datecouranteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn objetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnosticDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn analysesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tailleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn poidsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maladieDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox loadtaille;
        private System.Windows.Forms.TextBox loadpoids;
        private System.Windows.Forms.Button button1;
    }
}