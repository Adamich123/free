
namespace lr5.View
{
    partial class ViewClub
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
            this.r_year_create = new System.Windows.Forms.MaskedTextBox();
            this.id_club = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.tabClub = new System.Windows.Forms.DataGridView();
            this.DeleteClub_Click = new System.Windows.Forms.Button();
            this.RenewClub_Click = new System.Windows.Forms.Button();
            this.AddClub_Click = new System.Windows.Forms.Button();
            this.r_id_gum = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.r_id_coach = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.r_type_car = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.r_name_spon = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.r_city = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.r_nameClub = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.coachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sportsmenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sponsorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.tabClub)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // r_year_create
            // 
            this.r_year_create.Location = new System.Drawing.Point(3, 94);
            this.r_year_create.Mask = "0000/00/00";
            this.r_year_create.Name = "r_year_create";
            this.r_year_create.Size = new System.Drawing.Size(100, 20);
            this.r_year_create.TabIndex = 22;
            this.r_year_create.ValidatingType = typeof(System.DateTime);
            // 
            // id_club
            // 
            this.id_club.Location = new System.Drawing.Point(2, 353);
            this.id_club.Name = "id_club";
            this.id_club.Size = new System.Drawing.Size(100, 20);
            this.id_club.TabIndex = 21;
            this.id_club.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.r_name_spon_KeyPress);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(0, 337);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(15, 13);
            this.label35.TabIndex = 20;
            this.label35.Text = "id";
            // 
            // tabClub
            // 
            this.tabClub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabClub.Location = new System.Drawing.Point(110, 32);
            this.tabClub.Name = "tabClub";
            this.tabClub.Size = new System.Drawing.Size(668, 435);
            this.tabClub.TabIndex = 19;
            // 
            // DeleteClub_Click
            // 
            this.DeleteClub_Click.Location = new System.Drawing.Point(3, 437);
            this.DeleteClub_Click.Name = "DeleteClub_Click";
            this.DeleteClub_Click.Size = new System.Drawing.Size(75, 23);
            this.DeleteClub_Click.TabIndex = 18;
            this.DeleteClub_Click.Text = "Delete";
            this.DeleteClub_Click.UseVisualStyleBackColor = true;
            this.DeleteClub_Click.Click += new System.EventHandler(this.DeleteClub_Click_Click);
            // 
            // RenewClub_Click
            // 
            this.RenewClub_Click.Location = new System.Drawing.Point(2, 408);
            this.RenewClub_Click.Name = "RenewClub_Click";
            this.RenewClub_Click.Size = new System.Drawing.Size(75, 23);
            this.RenewClub_Click.TabIndex = 17;
            this.RenewClub_Click.Text = "Renew";
            this.RenewClub_Click.UseVisualStyleBackColor = true;
            this.RenewClub_Click.Click += new System.EventHandler(this.RenewClub_Click_Click);
            // 
            // AddClub_Click
            // 
            this.AddClub_Click.Location = new System.Drawing.Point(2, 379);
            this.AddClub_Click.Name = "AddClub_Click";
            this.AddClub_Click.Size = new System.Drawing.Size(75, 23);
            this.AddClub_Click.TabIndex = 16;
            this.AddClub_Click.Text = "ADD";
            this.AddClub_Click.UseVisualStyleBackColor = true;
            this.AddClub_Click.Click += new System.EventHandler(this.AddClub_Click_Click);
            // 
            // r_id_gum
            // 
            this.r_id_gum.Location = new System.Drawing.Point(0, 310);
            this.r_id_gum.Name = "r_id_gum";
            this.r_id_gum.Size = new System.Drawing.Size(100, 20);
            this.r_id_gum.TabIndex = 15;
            this.r_id_gum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.r_name_spon_KeyPress);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(0, 293);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(29, 13);
            this.label28.TabIndex = 14;
            this.label28.Text = "Gum";
            // 
            // r_id_coach
            // 
            this.r_id_coach.Location = new System.Drawing.Point(1, 269);
            this.r_id_coach.Name = "r_id_coach";
            this.r_id_coach.Size = new System.Drawing.Size(100, 20);
            this.r_id_coach.TabIndex = 11;
            this.r_id_coach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.r_name_spon_KeyPress);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(-2, 253);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(38, 13);
            this.label26.TabIndex = 10;
            this.label26.Text = "Coach";
            // 
            // r_type_car
            // 
            this.r_type_car.Location = new System.Drawing.Point(1, 225);
            this.r_type_car.Name = "r_type_car";
            this.r_type_car.Size = new System.Drawing.Size(100, 20);
            this.r_type_car.TabIndex = 9;
            this.r_type_car.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.r_name_spon_KeyPress);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(1, 208);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(52, 13);
            this.label25.TabIndex = 8;
            this.label25.Text = "Transoprt";
            // 
            // r_name_spon
            // 
            this.r_name_spon.Location = new System.Drawing.Point(1, 181);
            this.r_name_spon.Name = "r_name_spon";
            this.r_name_spon.Size = new System.Drawing.Size(100, 20);
            this.r_name_spon.TabIndex = 7;
            this.r_name_spon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.r_name_spon_KeyPress);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(1, 165);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(46, 13);
            this.label24.TabIndex = 6;
            this.label24.Text = "Sponsor";
            // 
            // r_city
            // 
            this.r_city.Location = new System.Drawing.Point(1, 137);
            this.r_city.Name = "r_city";
            this.r_city.Size = new System.Drawing.Size(100, 20);
            this.r_city.TabIndex = 5;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(0, 121);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(24, 13);
            this.label23.TabIndex = 4;
            this.label23.Text = "City";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(0, 77);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(62, 13);
            this.label22.TabIndex = 2;
            this.label22.Text = "Year create";
            // 
            // r_nameClub
            // 
            this.r_nameClub.Location = new System.Drawing.Point(3, 49);
            this.r_nameClub.Name = "r_nameClub";
            this.r_nameClub.Size = new System.Drawing.Size(100, 20);
            this.r_nameClub.TabIndex = 1;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(1, 32);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(35, 13);
            this.label21.TabIndex = 0;
            this.label21.Text = "Name";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coachToolStripMenuItem,
            this.gamesToolStripMenuItem,
            this.sportsmenToolStripMenuItem,
            this.sponsorToolStripMenuItem,
            this.gumToolStripMenuItem,
            this.transportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(805, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // coachToolStripMenuItem
            // 
            this.coachToolStripMenuItem.Name = "coachToolStripMenuItem";
            this.coachToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.coachToolStripMenuItem.Text = "Coach";
            this.coachToolStripMenuItem.Click += new System.EventHandler(this.coachToolStripMenuItem_Click);
            // 
            // gamesToolStripMenuItem
            // 
            this.gamesToolStripMenuItem.Name = "gamesToolStripMenuItem";
            this.gamesToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.gamesToolStripMenuItem.Text = "Games";
            this.gamesToolStripMenuItem.Click += new System.EventHandler(this.gamesToolStripMenuItem_Click);
            // 
            // sportsmenToolStripMenuItem
            // 
            this.sportsmenToolStripMenuItem.Name = "sportsmenToolStripMenuItem";
            this.sportsmenToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.sportsmenToolStripMenuItem.Text = "Sportsmen";
            this.sportsmenToolStripMenuItem.Click += new System.EventHandler(this.sportsmenToolStripMenuItem_Click);
            // 
            // sponsorToolStripMenuItem
            // 
            this.sponsorToolStripMenuItem.Name = "sponsorToolStripMenuItem";
            this.sponsorToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.sponsorToolStripMenuItem.Text = "Sponsor";
            this.sponsorToolStripMenuItem.Click += new System.EventHandler(this.sponsorToolStripMenuItem_Click);
            // 
            // gumToolStripMenuItem
            // 
            this.gumToolStripMenuItem.Name = "gumToolStripMenuItem";
            this.gumToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.gumToolStripMenuItem.Text = "Gum";
            this.gumToolStripMenuItem.Click += new System.EventHandler(this.gumToolStripMenuItem_Click);
            // 
            // transportToolStripMenuItem
            // 
            this.transportToolStripMenuItem.Name = "transportToolStripMenuItem";
            this.transportToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.transportToolStripMenuItem.Text = "Transport";
            this.transportToolStripMenuItem.Click += new System.EventHandler(this.transportToolStripMenuItem_Click);
            // 
            // ViewClub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 514);
            this.Controls.Add(this.r_year_create);
            this.Controls.Add(this.id_club);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.tabClub);
            this.Controls.Add(this.DeleteClub_Click);
            this.Controls.Add(this.RenewClub_Click);
            this.Controls.Add(this.AddClub_Click);
            this.Controls.Add(this.r_id_gum);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.r_id_coach);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.r_type_car);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.r_name_spon);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.r_city);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.r_nameClub);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.menuStrip1);
            this.Location = new System.Drawing.Point(4, 22);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ViewClub";
            this.Text = "ViewClub";
            ((System.ComponentModel.ISupportInitialize)(this.tabClub)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button DeleteClub_Click;
        private System.Windows.Forms.Button RenewClub_Click;
        private System.Windows.Forms.Button AddClub_Click;
        private System.Windows.Forms.TextBox r_id_gum;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox r_id_coach;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox r_type_car;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox r_name_spon;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox r_city;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox r_nameClub;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataGridView tabClub;
        private System.Windows.Forms.MaskedTextBox r_year_create;
        private System.Windows.Forms.TextBox id_club;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem coachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sportsmenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sponsorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transportToolStripMenuItem;
    }
}