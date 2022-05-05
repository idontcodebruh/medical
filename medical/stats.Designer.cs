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
            this.optionSel = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.databaseDrop = new Bunifu.UI.WinForms.BunifuDropdown();
            this.label2 = new System.Windows.Forms.Label();
            this.optionToRender = new Bunifu.UI.WinForms.BunifuDropdown();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuDropdown2 = new Bunifu.UI.WinForms.BunifuDropdown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.bunifuDatavizBasic1 = new Bunifu.Dataviz.WinForms.BunifuDatavizBasic();
            this.optionSel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // optionSel
            // 
            this.optionSel.Controls.Add(this.bunifuDropdown2);
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
            // bunifuDropdown2
            // 
            this.bunifuDropdown2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdown2.BackgroundColor = System.Drawing.Color.White;
            this.bunifuDropdown2.BorderColor = System.Drawing.Color.Silver;
            this.bunifuDropdown2.BorderRadius = 1;
            this.bunifuDropdown2.Color = System.Drawing.Color.Silver;
            this.bunifuDropdown2.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.bunifuDropdown2.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.bunifuDropdown2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuDropdown2.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.bunifuDropdown2.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.bunifuDropdown2.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.bunifuDropdown2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.bunifuDropdown2.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.bunifuDropdown2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bunifuDropdown2.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.bunifuDropdown2.FillDropDown = true;
            this.bunifuDropdown2.FillIndicator = false;
            this.bunifuDropdown2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuDropdown2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuDropdown2.ForeColor = System.Drawing.Color.Black;
            this.bunifuDropdown2.FormattingEnabled = true;
            this.bunifuDropdown2.Icon = null;
            this.bunifuDropdown2.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.bunifuDropdown2.IndicatorColor = System.Drawing.Color.DarkGray;
            this.bunifuDropdown2.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.bunifuDropdown2.IndicatorThickness = 2;
            this.bunifuDropdown2.IsDropdownOpened = false;
            this.bunifuDropdown2.ItemBackColor = System.Drawing.Color.White;
            this.bunifuDropdown2.ItemBorderColor = System.Drawing.Color.White;
            this.bunifuDropdown2.ItemForeColor = System.Drawing.Color.Black;
            this.bunifuDropdown2.ItemHeight = 26;
            this.bunifuDropdown2.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.bunifuDropdown2.ItemHighLightForeColor = System.Drawing.Color.White;
            this.bunifuDropdown2.Items.AddRange(new object[] {
            "PieChart",
            "Line",
            "Bar"});
            this.bunifuDropdown2.ItemTopMargin = 3;
            this.bunifuDropdown2.Location = new System.Drawing.Point(833, 21);
            this.bunifuDropdown2.Name = "bunifuDropdown2";
            this.bunifuDropdown2.Size = new System.Drawing.Size(254, 32);
            this.bunifuDropdown2.TabIndex = 5;
            this.bunifuDropdown2.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.bunifuDropdown2.TextLeftMargin = 5;
            // 
            // panel1
            // 
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox optionSel;
        private Bunifu.UI.WinForms.BunifuDropdown bunifuDropdown2;
        private System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForms.BunifuDropdown optionToRender;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuDropdown databaseDrop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private Bunifu.Dataviz.WinForms.BunifuDatavizBasic bunifuDatavizBasic1;
    }
}