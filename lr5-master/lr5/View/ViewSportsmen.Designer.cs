
namespace lr5.View
{
    partial class ViewSportsmen
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
            this.r_id_club = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.r_date_hw = new System.Windows.Forms.MaskedTextBox();
            this.r_ID_sp = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.r_year_of_birth_sp = new System.Windows.Forms.MaskedTextBox();
            this.DeleteSp_Click = new System.Windows.Forms.Button();
            this.RenewSp_Click = new System.Windows.Forms.Button();
            this.AddSp_Click = new System.Windows.Forms.Button();
            this.tabSportsmen = new System.Windows.Forms.DataGridView();
            this.r_number = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.r_weight = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.r_heigth = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.r_role = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.r_firstname_sp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.r_lastname_sp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabSportsmen)).BeginInit();
            this.SuspendLayout();
            // 
            // r_id_club
            // 
            this.r_id_club.Location = new System.Drawing.Point(3, 411);
            this.r_id_club.Name = "r_id_club";
            this.r_id_club.Size = new System.Drawing.Size(100, 20);
            this.r_id_club.TabIndex = 25;
            this.r_id_club.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.r_ID_sp_KeyPress);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(3, 395);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(38, 13);
            this.label36.TabIndex = 24;
            this.label36.Text = "id club";
            // 
            // r_date_hw
            // 
            this.r_date_hw.Location = new System.Drawing.Point(4, 328);
            this.r_date_hw.Mask = "0000/00/00";
            this.r_date_hw.Name = "r_date_hw";
            this.r_date_hw.Size = new System.Drawing.Size(100, 20);
            this.r_date_hw.TabIndex = 23;
            this.r_date_hw.ValidatingType = typeof(System.DateTime);
            // 
            // r_ID_sp
            // 
            this.r_ID_sp.Location = new System.Drawing.Point(4, 21);
            this.r_ID_sp.Name = "r_ID_sp";
            this.r_ID_sp.Size = new System.Drawing.Size(100, 20);
            this.r_ID_sp.TabIndex = 22;
            this.r_ID_sp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.r_ID_sp_KeyPress);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(6, 4);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(15, 13);
            this.label30.TabIndex = 21;
            this.label30.Text = "id";
            // 
            // r_year_of_birth_sp
            // 
            this.r_year_of_birth_sp.Location = new System.Drawing.Point(3, 192);
            this.r_year_of_birth_sp.Mask = "0000/00/00";
            this.r_year_of_birth_sp.Name = "r_year_of_birth_sp";
            this.r_year_of_birth_sp.Size = new System.Drawing.Size(100, 20);
            this.r_year_of_birth_sp.TabIndex = 20;
            // 
            // DeleteSp_Click
            // 
            this.DeleteSp_Click.Location = new System.Drawing.Point(111, 457);
            this.DeleteSp_Click.Name = "DeleteSp_Click";
            this.DeleteSp_Click.Size = new System.Drawing.Size(75, 23);
            this.DeleteSp_Click.TabIndex = 19;
            this.DeleteSp_Click.Text = "Delete";
            this.DeleteSp_Click.UseVisualStyleBackColor = true;
            this.DeleteSp_Click.Click += new System.EventHandler(this.DeleteSp_Click_Click);
            // 
            // RenewSp_Click
            // 
            this.RenewSp_Click.Location = new System.Drawing.Point(111, 425);
            this.RenewSp_Click.Name = "RenewSp_Click";
            this.RenewSp_Click.Size = new System.Drawing.Size(75, 23);
            this.RenewSp_Click.TabIndex = 18;
            this.RenewSp_Click.Text = "Renew";
            this.RenewSp_Click.UseVisualStyleBackColor = true;
            this.RenewSp_Click.Click += new System.EventHandler(this.RenewSp_Click_Click);
            // 
            // AddSp_Click
            // 
            this.AddSp_Click.Location = new System.Drawing.Point(111, 395);
            this.AddSp_Click.Name = "AddSp_Click";
            this.AddSp_Click.Size = new System.Drawing.Size(75, 23);
            this.AddSp_Click.TabIndex = 17;
            this.AddSp_Click.Text = "ADD";
            this.AddSp_Click.UseVisualStyleBackColor = true;
            this.AddSp_Click.Click += new System.EventHandler(this.AddSp_Click_Click);
            // 
            // tabSportsmen
            // 
            this.tabSportsmen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabSportsmen.Location = new System.Drawing.Point(110, 3);
            this.tabSportsmen.Name = "tabSportsmen";
            this.tabSportsmen.Size = new System.Drawing.Size(659, 386);
            this.tabSportsmen.TabIndex = 16;
            // 
            // r_number
            // 
            this.r_number.Location = new System.Drawing.Point(3, 368);
            this.r_number.Name = "r_number";
            this.r_number.Size = new System.Drawing.Size(100, 20);
            this.r_number.TabIndex = 15;
            this.r_number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.r_ID_sp_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 351);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Data hw";
            // 
            // r_weight
            // 
            this.r_weight.Location = new System.Drawing.Point(3, 280);
            this.r_weight.Name = "r_weight";
            this.r_weight.Size = new System.Drawing.Size(100, 20);
            this.r_weight.TabIndex = 11;
            this.r_weight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.r_ID_sp_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "weight";
            // 
            // r_heigth
            // 
            this.r_heigth.Location = new System.Drawing.Point(3, 236);
            this.r_heigth.Name = "r_heigth";
            this.r_heigth.Size = new System.Drawing.Size(100, 20);
            this.r_heigth.TabIndex = 9;
            this.r_heigth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.r_ID_sp_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "height";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Year of birth";
            // 
            // r_role
            // 
            this.r_role.Location = new System.Drawing.Point(3, 148);
            this.r_role.Name = "r_role";
            this.r_role.Size = new System.Drawing.Size(100, 20);
            this.r_role.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Role";
            // 
            // r_firstname_sp
            // 
            this.r_firstname_sp.Location = new System.Drawing.Point(3, 104);
            this.r_firstname_sp.Name = "r_firstname_sp";
            this.r_firstname_sp.Size = new System.Drawing.Size(100, 20);
            this.r_firstname_sp.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Firstname";
            // 
            // r_lastname_sp
            // 
            this.r_lastname_sp.Location = new System.Drawing.Point(3, 60);
            this.r_lastname_sp.Name = "r_lastname_sp";
            this.r_lastname_sp.Size = new System.Drawing.Size(100, 20);
            this.r_lastname_sp.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lastname";
            // 
            // ViewSportsmen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 498);
            this.Controls.Add(this.r_id_club);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.r_date_hw);
            this.Controls.Add(this.r_ID_sp);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.r_year_of_birth_sp);
            this.Controls.Add(this.DeleteSp_Click);
            this.Controls.Add(this.RenewSp_Click);
            this.Controls.Add(this.AddSp_Click);
            this.Controls.Add(this.tabSportsmen);
            this.Controls.Add(this.r_number);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.r_weight);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.r_heigth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.r_role);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.r_firstname_sp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.r_lastname_sp);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(4, 22);
            this.Name = "ViewSportsmen";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "Sportsmen";
            ((System.ComponentModel.ISupportInitialize)(this.tabSportsmen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox r_role;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox r_firstname_sp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox r_lastname_sp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tabSportsmen;
        private System.Windows.Forms.TextBox r_number;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox r_weight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox r_heigth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button DeleteSp_Click;
        private System.Windows.Forms.Button RenewSp_Click;
        private System.Windows.Forms.Button AddSp_Click;
        private System.Windows.Forms.TextBox r_id_club;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox r_ID_sp;
        private System.Windows.Forms.MaskedTextBox r_year_of_birth_sp;
        private System.Windows.Forms.MaskedTextBox r_date_hw;
    }
}