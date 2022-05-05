namespace medical
{
    partial class Form2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mALADES4DataSet = new medical.MALADES4DataSet();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientsTableAdapter = new medical.MALADES4DataSetTableAdapters.PatientsTableAdapter();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mALADES4DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(788, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
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
            this.dataGridView1.Location = new System.Drawing.Point(13, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(787, 404);
            this.dataGridView1.TabIndex = 1;
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 455);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mALADES4DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MALADES4DataSet mALADES4DataSet;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private MALADES4DataSetTableAdapters.PatientsTableAdapter patientsTableAdapter;
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