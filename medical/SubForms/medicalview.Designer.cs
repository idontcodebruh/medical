namespace medical
{
    partial class medicalview
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
            this.menupanel = new System.Windows.Forms.Panel();
            this.graphbtn = new FontAwesome.Sharp.IconButton();
            this.exambtn = new FontAwesome.Sharp.IconButton();
            this.anamnesebtn = new FontAwesome.Sharp.IconButton();
            this.patientbtn = new FontAwesome.Sharp.IconButton();
            this.viewpanel = new System.Windows.Forms.Panel();
            this.menupanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menupanel
            // 
            this.menupanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(39)))), ((int)(((byte)(61)))));
            this.menupanel.Controls.Add(this.graphbtn);
            this.menupanel.Controls.Add(this.exambtn);
            this.menupanel.Controls.Add(this.anamnesebtn);
            this.menupanel.Controls.Add(this.patientbtn);
            this.menupanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menupanel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menupanel.Location = new System.Drawing.Point(0, 0);
            this.menupanel.Name = "menupanel";
            this.menupanel.Size = new System.Drawing.Size(1117, 67);
            this.menupanel.TabIndex = 0;
            // 
            // graphbtn
            // 
            this.graphbtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.graphbtn.FlatAppearance.BorderSize = 0;
            this.graphbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.graphbtn.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.graphbtn.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.graphbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.graphbtn.Location = new System.Drawing.Point(921, 0);
            this.graphbtn.Name = "graphbtn";
            this.graphbtn.Size = new System.Drawing.Size(196, 67);
            this.graphbtn.TabIndex = 3;
            this.graphbtn.Text = "Graph(?)";
            this.graphbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.graphbtn.UseVisualStyleBackColor = true;
            // 
            // exambtn
            // 
            this.exambtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.exambtn.FlatAppearance.BorderSize = 0;
            this.exambtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exambtn.IconChar = FontAwesome.Sharp.IconChar.FileMedical;
            this.exambtn.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.exambtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.exambtn.Location = new System.Drawing.Point(614, 0);
            this.exambtn.Name = "exambtn";
            this.exambtn.Size = new System.Drawing.Size(307, 67);
            this.exambtn.TabIndex = 2;
            this.exambtn.Text = "Examen";
            this.exambtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.exambtn.UseVisualStyleBackColor = true;
            this.exambtn.Click += new System.EventHandler(this.exambtn_Click);
            // 
            // anamnesebtn
            // 
            this.anamnesebtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.anamnesebtn.FlatAppearance.BorderSize = 0;
            this.anamnesebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anamnesebtn.IconChar = FontAwesome.Sharp.IconChar.Syringe;
            this.anamnesebtn.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.anamnesebtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.anamnesebtn.Location = new System.Drawing.Point(307, 0);
            this.anamnesebtn.Name = "anamnesebtn";
            this.anamnesebtn.Size = new System.Drawing.Size(307, 67);
            this.anamnesebtn.TabIndex = 1;
            this.anamnesebtn.Text = "Anamnese";
            this.anamnesebtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.anamnesebtn.UseVisualStyleBackColor = true;
            this.anamnesebtn.Click += new System.EventHandler(this.anamnesebtn_Click);
            // 
            // patientbtn
            // 
            this.patientbtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.patientbtn.FlatAppearance.BorderSize = 0;
            this.patientbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.patientbtn.IconChar = FontAwesome.Sharp.IconChar.User;
            this.patientbtn.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.patientbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.patientbtn.Location = new System.Drawing.Point(0, 0);
            this.patientbtn.Name = "patientbtn";
            this.patientbtn.Size = new System.Drawing.Size(307, 67);
            this.patientbtn.TabIndex = 0;
            this.patientbtn.Text = "Patient info";
            this.patientbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.patientbtn.UseVisualStyleBackColor = true;
            this.patientbtn.Click += new System.EventHandler(this.patientbtn_Click);
            // 
            // viewpanel
            // 
            this.viewpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewpanel.Location = new System.Drawing.Point(0, 67);
            this.viewpanel.Name = "viewpanel";
            this.viewpanel.Size = new System.Drawing.Size(1117, 454);
            this.viewpanel.TabIndex = 1;
            // 
            // medicalview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 521);
            this.Controls.Add(this.viewpanel);
            this.Controls.Add(this.menupanel);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "medicalview";
            this.Text = "medicalview";
            this.menupanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menupanel;
        private FontAwesome.Sharp.IconButton graphbtn;
        private FontAwesome.Sharp.IconButton exambtn;
        private FontAwesome.Sharp.IconButton anamnesebtn;
        private FontAwesome.Sharp.IconButton patientbtn;
        private System.Windows.Forms.Panel viewpanel;
    }
}