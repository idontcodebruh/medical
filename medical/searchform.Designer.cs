﻿namespace medical
{
    partial class searchform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(searchform));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuTextBox1 = new Bunifu.UI.WinForms.BunifuTextBox();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mALADES4DataSet = new medical.MALADES4DataSet();
            this.patientsTableAdapter = new medical.MALADES4DataSetTableAdapters.PatientsTableAdapter();
            this.bunifuDropdown1 = new Bunifu.UI.WinForms.BunifuDropdown();
            this.viewuser = new FontAwesome.Sharp.IconButton();
            this.edituser = new FontAwesome.Sharp.IconButton();
            this.deleteuser = new FontAwesome.Sharp.IconButton();
            this.SearchLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.SearchNumberLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.addbtn = new FontAwesome.Sharp.IconButton();
            this.examensBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.examensTableAdapter = new medical.MALADES4DataSetTableAdapters.ExamensTableAdapter();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
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
            this.patientsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.finalGrid = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mALADES4DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examensBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuTextBox1
            // 
            this.bunifuTextBox1.AcceptsReturn = false;
            this.bunifuTextBox1.AcceptsTab = false;
            this.bunifuTextBox1.AnimationSpeed = 200;
            this.bunifuTextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuTextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuTextBox1.AutoSizeHeight = true;
            this.bunifuTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTextBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextBox1.BackgroundImage")));
            this.bunifuTextBox1.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.bunifuTextBox1.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuTextBox1.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuTextBox1.BorderColorIdle = System.Drawing.Color.Silver;
            this.bunifuTextBox1.BorderRadius = 1;
            this.bunifuTextBox1.BorderThickness = 1;
            this.bunifuTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBox1.DefaultFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTextBox1.DefaultText = "";
            this.bunifuTextBox1.FillColor = System.Drawing.Color.White;
            this.bunifuTextBox1.HideSelection = true;
            this.bunifuTextBox1.IconLeft = null;
            this.bunifuTextBox1.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBox1.IconPadding = 10;
            this.bunifuTextBox1.IconRight = null;
            this.bunifuTextBox1.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBox1.Lines = new string[0];
            this.bunifuTextBox1.Location = new System.Drawing.Point(12, 29);
            this.bunifuTextBox1.MaxLength = 32767;
            this.bunifuTextBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.bunifuTextBox1.Modified = false;
            this.bunifuTextBox1.Multiline = false;
            this.bunifuTextBox1.Name = "bunifuTextBox1";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBox1.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.bunifuTextBox1.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBox1.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBox1.OnIdleState = stateProperties4;
            this.bunifuTextBox1.Padding = new System.Windows.Forms.Padding(3);
            this.bunifuTextBox1.PasswordChar = '\0';
            this.bunifuTextBox1.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.bunifuTextBox1.PlaceholderText = "Query";
            this.bunifuTextBox1.ReadOnly = false;
            this.bunifuTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.bunifuTextBox1.SelectedText = "";
            this.bunifuTextBox1.SelectionLength = 0;
            this.bunifuTextBox1.SelectionStart = 0;
            this.bunifuTextBox1.ShortcutsEnabled = true;
            this.bunifuTextBox1.Size = new System.Drawing.Size(671, 32);
            this.bunifuTextBox1.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.bunifuTextBox1.TabIndex = 0;
            this.bunifuTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuTextBox1.TextMarginBottom = 0;
            this.bunifuTextBox1.TextMarginLeft = 3;
            this.bunifuTextBox1.TextMarginTop = 1;
            this.bunifuTextBox1.TextPlaceholder = "Query";
            this.bunifuTextBox1.UseSystemPasswordChar = false;
            this.bunifuTextBox1.WordWrap = true;
            this.bunifuTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bunifuTextBox1_KeyPress);
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
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
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
            this.bunifuDropdown1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.bunifuDropdown1.Items.AddRange(new object[] {
            "Nom",
            "Prenom",
            "Matricule",
            "Date Naissance"});
            this.bunifuDropdown1.ItemTopMargin = 3;
            this.bunifuDropdown1.Location = new System.Drawing.Point(689, 29);
            this.bunifuDropdown1.Name = "bunifuDropdown1";
            this.bunifuDropdown1.Size = new System.Drawing.Size(260, 32);
            this.bunifuDropdown1.TabIndex = 2;
            this.bunifuDropdown1.Text = null;
            this.bunifuDropdown1.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.bunifuDropdown1.TextLeftMargin = 5;
            // 
            // viewuser
            // 
            this.viewuser.FlatAppearance.BorderSize = 0;
            this.viewuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewuser.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.viewuser.IconColor = System.Drawing.Color.LightSlateGray;
            this.viewuser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.viewuser.IconSize = 30;
            this.viewuser.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.viewuser.Location = new System.Drawing.Point(955, 29);
            this.viewuser.Name = "viewuser";
            this.viewuser.Size = new System.Drawing.Size(33, 32);
            this.viewuser.TabIndex = 3;
            this.viewuser.UseVisualStyleBackColor = true;
            this.viewuser.Click += new System.EventHandler(this.viewuser_Click);
            // 
            // edituser
            // 
            this.edituser.FlatAppearance.BorderSize = 0;
            this.edituser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edituser.IconChar = FontAwesome.Sharp.IconChar.PenSquare;
            this.edituser.IconColor = System.Drawing.Color.LightSlateGray;
            this.edituser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.edituser.IconSize = 30;
            this.edituser.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.edituser.Location = new System.Drawing.Point(994, 29);
            this.edituser.Name = "edituser";
            this.edituser.Size = new System.Drawing.Size(33, 32);
            this.edituser.TabIndex = 4;
            this.edituser.UseVisualStyleBackColor = true;
            this.edituser.Click += new System.EventHandler(this.edituser_Click);
            // 
            // deleteuser
            // 
            this.deleteuser.FlatAppearance.BorderSize = 0;
            this.deleteuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteuser.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.deleteuser.IconColor = System.Drawing.Color.LightSlateGray;
            this.deleteuser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.deleteuser.IconSize = 30;
            this.deleteuser.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.deleteuser.Location = new System.Drawing.Point(1033, 29);
            this.deleteuser.Name = "deleteuser";
            this.deleteuser.Size = new System.Drawing.Size(33, 32);
            this.deleteuser.TabIndex = 5;
            this.deleteuser.UseVisualStyleBackColor = true;
            this.deleteuser.Click += new System.EventHandler(this.deleteuser_Click);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AllowParentOverrides = false;
            this.SearchLabel.AutoEllipsis = false;
            this.SearchLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.SearchLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.SearchLabel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchLabel.Location = new System.Drawing.Point(12, 67);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SearchLabel.Size = new System.Drawing.Size(107, 14);
            this.SearchLabel.TabIndex = 6;
            this.SearchLabel.Text = "Search returned:";
            this.SearchLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.SearchLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // SearchNumberLabel
            // 
            this.SearchNumberLabel.AllowParentOverrides = false;
            this.SearchNumberLabel.AutoEllipsis = false;
            this.SearchNumberLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.SearchNumberLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.SearchNumberLabel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchNumberLabel.Location = new System.Drawing.Point(125, 67);
            this.SearchNumberLabel.Name = "SearchNumberLabel";
            this.SearchNumberLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SearchNumberLabel.Size = new System.Drawing.Size(8, 14);
            this.SearchNumberLabel.TabIndex = 7;
            this.SearchNumberLabel.Text = "0";
            this.SearchNumberLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.SearchNumberLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // addbtn
            // 
            this.addbtn.FlatAppearance.BorderSize = 0;
            this.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbtn.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.addbtn.IconColor = System.Drawing.Color.LightSlateGray;
            this.addbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addbtn.IconSize = 30;
            this.addbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addbtn.Location = new System.Drawing.Point(1072, 29);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(33, 32);
            this.addbtn.TabIndex = 8;
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // examensBindingSource
            // 
            this.examensBindingSource.DataMember = "Examens";
            this.examensBindingSource.DataSource = this.mALADES4DataSet;
            // 
            // examensTableAdapter
            // 
            this.examensTableAdapter.ClearBeforeFill = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 7;
            this.bunifuElipse1.TargetControl = this;
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
            this.dataGridView1.DataSource = this.patientsBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(758, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(10, 10);
            this.dataGridView1.TabIndex = 11;
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
            // addresseDataGridViewTextBoxColumn
            // 
            this.addresseDataGridViewTextBoxColumn.DataPropertyName = "addresse";
            this.addresseDataGridViewTextBoxColumn.HeaderText = "addresse";
            this.addresseDataGridViewTextBoxColumn.Name = "addresseDataGridViewTextBoxColumn";
            this.addresseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telDataGridViewTextBoxColumn
            // 
            this.telDataGridViewTextBoxColumn.DataPropertyName = "tel";
            this.telDataGridViewTextBoxColumn.HeaderText = "tel";
            this.telDataGridViewTextBoxColumn.Name = "telDataGridViewTextBoxColumn";
            this.telDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nompèreDataGridViewTextBoxColumn
            // 
            this.nompèreDataGridViewTextBoxColumn.DataPropertyName = "nom_père";
            this.nompèreDataGridViewTextBoxColumn.HeaderText = "nom_père";
            this.nompèreDataGridViewTextBoxColumn.Name = "nompèreDataGridViewTextBoxColumn";
            this.nompèreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nommèreDataGridViewTextBoxColumn
            // 
            this.nommèreDataGridViewTextBoxColumn.DataPropertyName = "nom_mère";
            this.nommèreDataGridViewTextBoxColumn.HeaderText = "nom_mère";
            this.nommèreDataGridViewTextBoxColumn.Name = "nommèreDataGridViewTextBoxColumn";
            this.nommèreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fonctpèreDataGridViewTextBoxColumn
            // 
            this.fonctpèreDataGridViewTextBoxColumn.DataPropertyName = "fonct_père";
            this.fonctpèreDataGridViewTextBoxColumn.HeaderText = "fonct_père";
            this.fonctpèreDataGridViewTextBoxColumn.Name = "fonctpèreDataGridViewTextBoxColumn";
            this.fonctpèreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fonctmèreDataGridViewTextBoxColumn
            // 
            this.fonctmèreDataGridViewTextBoxColumn.DataPropertyName = "fonct_mère";
            this.fonctmèreDataGridViewTextBoxColumn.HeaderText = "fonct_mère";
            this.fonctmèreDataGridViewTextBoxColumn.Name = "fonctmèreDataGridViewTextBoxColumn";
            this.fonctmèreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // communeDataGridViewTextBoxColumn
            // 
            this.communeDataGridViewTextBoxColumn.DataPropertyName = "commune";
            this.communeDataGridViewTextBoxColumn.HeaderText = "commune";
            this.communeDataGridViewTextBoxColumn.Name = "communeDataGridViewTextBoxColumn";
            this.communeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sexeDataGridViewTextBoxColumn
            // 
            this.sexeDataGridViewTextBoxColumn.DataPropertyName = "sexe";
            this.sexeDataGridViewTextBoxColumn.HeaderText = "sexe";
            this.sexeDataGridViewTextBoxColumn.Name = "sexeDataGridViewTextBoxColumn";
            this.sexeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wilayaDataGridViewTextBoxColumn
            // 
            this.wilayaDataGridViewTextBoxColumn.DataPropertyName = "wilaya";
            this.wilayaDataGridViewTextBoxColumn.HeaderText = "wilaya";
            this.wilayaDataGridViewTextBoxColumn.Name = "wilayaDataGridViewTextBoxColumn";
            this.wilayaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // matriculeDataGridViewTextBoxColumn
            // 
            this.matriculeDataGridViewTextBoxColumn.DataPropertyName = "matricule";
            this.matriculeDataGridViewTextBoxColumn.HeaderText = "matricule";
            this.matriculeDataGridViewTextBoxColumn.Name = "matriculeDataGridViewTextBoxColumn";
            this.matriculeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nbenffDataGridViewTextBoxColumn
            // 
            this.nbenffDataGridViewTextBoxColumn.DataPropertyName = "nb_enf_f";
            this.nbenffDataGridViewTextBoxColumn.HeaderText = "nb_enf_f";
            this.nbenffDataGridViewTextBoxColumn.Name = "nbenffDataGridViewTextBoxColumn";
            this.nbenffDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nbenfgDataGridViewTextBoxColumn
            // 
            this.nbenfgDataGridViewTextBoxColumn.DataPropertyName = "nb_enf_g";
            this.nbenfgDataGridViewTextBoxColumn.HeaderText = "nb_enf_g";
            this.nbenfgDataGridViewTextBoxColumn.Name = "nbenfgDataGridViewTextBoxColumn";
            this.nbenfgDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datenaissDataGridViewTextBoxColumn
            // 
            this.datenaissDataGridViewTextBoxColumn.DataPropertyName = "date_naiss";
            this.datenaissDataGridViewTextBoxColumn.HeaderText = "date_naiss";
            this.datenaissDataGridViewTextBoxColumn.Name = "datenaissDataGridViewTextBoxColumn";
            this.datenaissDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // premdateDataGridViewTextBoxColumn
            // 
            this.premdateDataGridViewTextBoxColumn.DataPropertyName = "prem_date";
            this.premdateDataGridViewTextBoxColumn.HeaderText = "prem_date";
            this.premdateDataGridViewTextBoxColumn.Name = "premdateDataGridViewTextBoxColumn";
            this.premdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patientsBindingSource1
            // 
            this.patientsBindingSource1.DataMember = "Patients";
            this.patientsBindingSource1.DataSource = this.mALADES4DataSet;
            // 
            // finalGrid
            // 
            this.finalGrid.AllowCustomTheming = false;
            this.finalGrid.AllowUserToAddRows = false;
            this.finalGrid.AllowUserToDeleteRows = false;
            this.finalGrid.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.finalGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.finalGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.finalGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.finalGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.finalGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.finalGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.finalGrid.ColumnHeadersHeight = 40;
            this.finalGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.finalGrid.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.finalGrid.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.finalGrid.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.finalGrid.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.finalGrid.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.finalGrid.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.finalGrid.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.finalGrid.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.finalGrid.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.finalGrid.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.finalGrid.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.finalGrid.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.finalGrid.CurrentTheme.Name = null;
            this.finalGrid.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.finalGrid.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.finalGrid.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.finalGrid.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.finalGrid.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.finalGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.finalGrid.EnableHeadersVisualStyles = false;
            this.finalGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.finalGrid.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.finalGrid.HeaderBgColor = System.Drawing.Color.Empty;
            this.finalGrid.HeaderForeColor = System.Drawing.Color.White;
            this.finalGrid.Location = new System.Drawing.Point(12, 87);
            this.finalGrid.Name = "finalGrid";
            this.finalGrid.ReadOnly = true;
            this.finalGrid.RowHeadersVisible = false;
            this.finalGrid.RowTemplate.Height = 40;
            this.finalGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.finalGrid.Size = new System.Drawing.Size(1093, 422);
            this.finalGrid.TabIndex = 12;
            this.finalGrid.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.finalGrid.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.finalGrid_ColumnHeaderMouseClick);
            this.finalGrid.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.finalGrid_RowHeaderMouseClick_1);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Matricule";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nom";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Prénom";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Date naissance";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // searchform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 521);
            this.Controls.Add(this.finalGrid);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.SearchNumberLabel);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.deleteuser);
            this.Controls.Add(this.edituser);
            this.Controls.Add(this.viewuser);
            this.Controls.Add(this.bunifuDropdown1);
            this.Controls.Add(this.bunifuTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "searchform";
            this.Text = "searchform";
            this.Load += new System.EventHandler(this.searchform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mALADES4DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examensBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuTextBox bunifuTextBox1;
        private MALADES4DataSet mALADES4DataSet;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private MALADES4DataSetTableAdapters.PatientsTableAdapter patientsTableAdapter;
        private Bunifu.UI.WinForms.BunifuDropdown bunifuDropdown1;
        private FontAwesome.Sharp.IconButton viewuser;
        private FontAwesome.Sharp.IconButton edituser;
        private FontAwesome.Sharp.IconButton deleteuser;
        private Bunifu.UI.WinForms.BunifuLabel SearchLabel;
        private Bunifu.UI.WinForms.BunifuLabel SearchNumberLabel;
        private FontAwesome.Sharp.IconButton addbtn;
        private System.Windows.Forms.BindingSource examensBindingSource;
        private MALADES4DataSetTableAdapters.ExamensTableAdapter examensTableAdapter;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
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
        private System.Windows.Forms.BindingSource patientsBindingSource1;
        private Bunifu.UI.WinForms.BunifuDataGridView finalGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}