namespace medical
{
    partial class mainmenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainmenu));
            this.mainpanel = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.sidebar = new Bunifu.UI.WinForms.BunifuPanel();
            this.logoutpanel = new System.Windows.Forms.Panel();
            this.logoutbtn = new FontAwesome.Sharp.IconButton();
            this.currentuser = new System.Windows.Forms.Label();
            this.bottomside_label = new System.Windows.Forms.Label();
            this.iconButton7 = new FontAwesome.Sharp.IconButton();
            this.searchbtn = new FontAwesome.Sharp.IconButton();
            this.statsbtn = new FontAwesome.Sharp.IconButton();
            this.appointmentbtn = new FontAwesome.Sharp.IconButton();
            this.medicalbtn = new FontAwesome.Sharp.IconButton();
            this.homepagebtn = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sidebar.SuspendLayout();
            this.logoutpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainpanel
            // 
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(135, 0);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(1117, 521);
            this.mainpanel.TabIndex = 2;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 6;
            this.bunifuElipse1.TargetControl = this;
            // 
            // sidebar
            // 
            this.sidebar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(39)))), ((int)(((byte)(61)))));
            this.sidebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sidebar.BackgroundImage")));
            this.sidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sidebar.BorderColor = System.Drawing.Color.Transparent;
            this.sidebar.BorderRadius = 3;
            this.sidebar.BorderThickness = 1;
            this.sidebar.Controls.Add(this.logoutpanel);
            this.sidebar.Controls.Add(this.iconButton7);
            this.sidebar.Controls.Add(this.searchbtn);
            this.sidebar.Controls.Add(this.statsbtn);
            this.sidebar.Controls.Add(this.appointmentbtn);
            this.sidebar.Controls.Add(this.medicalbtn);
            this.sidebar.Controls.Add(this.homepagebtn);
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.ShowBorders = true;
            this.sidebar.Size = new System.Drawing.Size(135, 521);
            this.sidebar.TabIndex = 1;
            // 
            // logoutpanel
            // 
            this.logoutpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(39)))), ((int)(((byte)(61)))));
            this.logoutpanel.Controls.Add(this.logoutbtn);
            this.logoutpanel.Controls.Add(this.currentuser);
            this.logoutpanel.Controls.Add(this.bottomside_label);
            this.logoutpanel.Location = new System.Drawing.Point(3, 422);
            this.logoutpanel.Name = "logoutpanel";
            this.logoutpanel.Size = new System.Drawing.Size(129, 96);
            this.logoutpanel.TabIndex = 8;
            // 
            // logoutbtn
            // 
            this.logoutbtn.FlatAppearance.BorderSize = 0;
            this.logoutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutbtn.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.logoutbtn.IconColor = System.Drawing.Color.White;
            this.logoutbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.logoutbtn.IconSize = 20;
            this.logoutbtn.Location = new System.Drawing.Point(104, 76);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(22, 17);
            this.logoutbtn.TabIndex = 2;
            this.logoutbtn.UseVisualStyleBackColor = true;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // currentuser
            // 
            this.currentuser.AutoSize = true;
            this.currentuser.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentuser.ForeColor = System.Drawing.Color.White;
            this.currentuser.Location = new System.Drawing.Point(50, 76);
            this.currentuser.Name = "currentuser";
            this.currentuser.Size = new System.Drawing.Size(48, 14);
            this.currentuser.TabIndex = 1;
            this.currentuser.Text = "ADMIN";
            // 
            // bottomside_label
            // 
            this.bottomside_label.AutoSize = true;
            this.bottomside_label.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottomside_label.ForeColor = System.Drawing.Color.White;
            this.bottomside_label.Location = new System.Drawing.Point(9, 76);
            this.bottomside_label.Name = "bottomside_label";
            this.bottomside_label.Size = new System.Drawing.Size(41, 14);
            this.bottomside_label.TabIndex = 0;
            this.bottomside_label.Text = "User:";
            // 
            // iconButton7
            // 
            this.iconButton7.BackColor = System.Drawing.Color.Transparent;
            this.iconButton7.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton7.FlatAppearance.BorderSize = 0;
            this.iconButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconButton7.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButton7.IconColor = System.Drawing.Color.White;
            this.iconButton7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton7.IconSize = 20;
            this.iconButton7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton7.Location = new System.Drawing.Point(0, 252);
            this.iconButton7.Name = "iconButton7";
            this.iconButton7.Size = new System.Drawing.Size(135, 35);
            this.iconButton7.TabIndex = 7;
            this.iconButton7.Text = "a";
            this.iconButton7.UseVisualStyleBackColor = false;
            this.iconButton7.Click += new System.EventHandler(this.iconButton7_Click);
            // 
            // searchbtn
            // 
            this.searchbtn.BackColor = System.Drawing.Color.Transparent;
            this.searchbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchbtn.FlatAppearance.BorderSize = 0;
            this.searchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchbtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchbtn.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.searchbtn.IconColor = System.Drawing.Color.White;
            this.searchbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.searchbtn.IconSize = 20;
            this.searchbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchbtn.Location = new System.Drawing.Point(0, 217);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(135, 35);
            this.searchbtn.TabIndex = 6;
            this.searchbtn.Text = "Search";
            this.searchbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.searchbtn.UseVisualStyleBackColor = false;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click_1);
            // 
            // statsbtn
            // 
            this.statsbtn.BackColor = System.Drawing.Color.Transparent;
            this.statsbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.statsbtn.FlatAppearance.BorderSize = 0;
            this.statsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statsbtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.statsbtn.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.statsbtn.IconColor = System.Drawing.Color.White;
            this.statsbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.statsbtn.IconSize = 20;
            this.statsbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.statsbtn.Location = new System.Drawing.Point(0, 182);
            this.statsbtn.Name = "statsbtn";
            this.statsbtn.Size = new System.Drawing.Size(135, 35);
            this.statsbtn.TabIndex = 4;
            this.statsbtn.Text = "Statistics";
            this.statsbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.statsbtn.UseVisualStyleBackColor = false;
            this.statsbtn.Click += new System.EventHandler(this.statsbtn_Click);
            // 
            // appointmentbtn
            // 
            this.appointmentbtn.BackColor = System.Drawing.Color.Transparent;
            this.appointmentbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.appointmentbtn.FlatAppearance.BorderSize = 0;
            this.appointmentbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.appointmentbtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.appointmentbtn.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            this.appointmentbtn.IconColor = System.Drawing.Color.White;
            this.appointmentbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.appointmentbtn.IconSize = 20;
            this.appointmentbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.appointmentbtn.Location = new System.Drawing.Point(0, 147);
            this.appointmentbtn.Name = "appointmentbtn";
            this.appointmentbtn.Size = new System.Drawing.Size(135, 35);
            this.appointmentbtn.TabIndex = 3;
            this.appointmentbtn.Text = "Appointment";
            this.appointmentbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.appointmentbtn.UseVisualStyleBackColor = false;
            this.appointmentbtn.Click += new System.EventHandler(this.appointmentbtn_Click);
            // 
            // medicalbtn
            // 
            this.medicalbtn.BackColor = System.Drawing.Color.Transparent;
            this.medicalbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.medicalbtn.FlatAppearance.BorderSize = 0;
            this.medicalbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.medicalbtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicalbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.medicalbtn.IconChar = FontAwesome.Sharp.IconChar.FileMedical;
            this.medicalbtn.IconColor = System.Drawing.Color.White;
            this.medicalbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.medicalbtn.IconSize = 20;
            this.medicalbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.medicalbtn.Location = new System.Drawing.Point(0, 112);
            this.medicalbtn.Name = "medicalbtn";
            this.medicalbtn.Size = new System.Drawing.Size(135, 35);
            this.medicalbtn.TabIndex = 2;
            this.medicalbtn.Text = "Medical File";
            this.medicalbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.medicalbtn.UseVisualStyleBackColor = false;
            this.medicalbtn.Click += new System.EventHandler(this.medicalbtn_Click);
            // 
            // homepagebtn
            // 
            this.homepagebtn.BackColor = System.Drawing.Color.Transparent;
            this.homepagebtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.homepagebtn.FlatAppearance.BorderSize = 0;
            this.homepagebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homepagebtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homepagebtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.homepagebtn.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.homepagebtn.IconColor = System.Drawing.Color.White;
            this.homepagebtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.homepagebtn.IconSize = 20;
            this.homepagebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homepagebtn.Location = new System.Drawing.Point(0, 77);
            this.homepagebtn.Name = "homepagebtn";
            this.homepagebtn.Size = new System.Drawing.Size(135, 35);
            this.homepagebtn.TabIndex = 1;
            this.homepagebtn.Text = "Home";
            this.homepagebtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.homepagebtn.UseVisualStyleBackColor = false;
            this.homepagebtn.Click += new System.EventHandler(this.homepagebtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(135, 77);
            this.panel1.TabIndex = 0;
            // 
            // mainmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 521);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainmenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainmenu";
            this.sidebar.ResumeLayout(false);
            this.logoutpanel.ResumeLayout(false);
            this.logoutpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel sidebar;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton7;
        private FontAwesome.Sharp.IconButton searchbtn;
        private FontAwesome.Sharp.IconButton statsbtn;
        private FontAwesome.Sharp.IconButton appointmentbtn;
        private FontAwesome.Sharp.IconButton medicalbtn;
        private FontAwesome.Sharp.IconButton homepagebtn;
        private System.Windows.Forms.Panel logoutpanel;
        private FontAwesome.Sharp.IconButton logoutbtn;
        private System.Windows.Forms.Label currentuser;
        private System.Windows.Forms.Label bottomside_label;
        private System.Windows.Forms.Panel mainpanel;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}