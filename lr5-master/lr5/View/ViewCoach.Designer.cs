
namespace lr5.View
{
    partial class ViewCoach
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
            this.id_coach = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.r_year_of_birth_tr = new System.Windows.Forms.MaskedTextBox();
            this.tabCoach = new System.Windows.Forms.DataGridView();
            this.DeleteCoach_Click = new System.Windows.Forms.Button();
            this.RenewCoach_Click = new System.Windows.Forms.Button();
            this.AddCoach_Click = new System.Windows.Forms.Button();
            this.r_lastname_tr = new System.Windows.Forms.TextBox();
            this.r_rank = new System.Windows.Forms.TextBox();
            this.r_firstname_tr = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabCoach)).BeginInit();
            this.SuspendLayout();
            // 
            // id_coach
            // 
            this.id_coach.Location = new System.Drawing.Point(6, 184);
            this.id_coach.Name = "id_coach";
            this.id_coach.Size = new System.Drawing.Size(100, 20);
            this.id_coach.TabIndex = 14;
            this.id_coach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id_coach_KeyPress);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(6, 164);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(15, 13);
            this.label34.TabIndex = 13;
            this.label34.Text = "id";
            // 
            // r_year_of_birth_tr
            // 
            this.r_year_of_birth_tr.Location = new System.Drawing.Point(6, 98);
            this.r_year_of_birth_tr.Mask = "0000/00/00";
            this.r_year_of_birth_tr.Name = "r_year_of_birth_tr";
            this.r_year_of_birth_tr.Size = new System.Drawing.Size(100, 20);
            this.r_year_of_birth_tr.TabIndex = 12;
            this.r_year_of_birth_tr.ValidatingType = typeof(System.DateTime);
            // 
            // tabCoach
            // 
            this.tabCoach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabCoach.Location = new System.Drawing.Point(114, 4);
            this.tabCoach.Name = "tabCoach";
            this.tabCoach.Size = new System.Drawing.Size(667, 430);
            this.tabCoach.TabIndex = 11;
            // 
            // DeleteCoach_Click
            // 
            this.DeleteCoach_Click.Location = new System.Drawing.Point(6, 270);
            this.DeleteCoach_Click.Name = "DeleteCoach_Click";
            this.DeleteCoach_Click.Size = new System.Drawing.Size(75, 23);
            this.DeleteCoach_Click.TabIndex = 10;
            this.DeleteCoach_Click.Text = "Delete";
            this.DeleteCoach_Click.UseVisualStyleBackColor = true;
            this.DeleteCoach_Click.Click += new System.EventHandler(this.DeleteCoach_Click_Click);
            // 
            // RenewCoach_Click
            // 
            this.RenewCoach_Click.Location = new System.Drawing.Point(6, 240);
            this.RenewCoach_Click.Name = "RenewCoach_Click";
            this.RenewCoach_Click.Size = new System.Drawing.Size(75, 23);
            this.RenewCoach_Click.TabIndex = 9;
            this.RenewCoach_Click.Text = "Renew";
            this.RenewCoach_Click.UseVisualStyleBackColor = true;
            this.RenewCoach_Click.Click += new System.EventHandler(this.RenewCoach_Click_Click);
            // 
            // AddCoach_Click
            // 
            this.AddCoach_Click.Location = new System.Drawing.Point(6, 210);
            this.AddCoach_Click.Name = "AddCoach_Click";
            this.AddCoach_Click.Size = new System.Drawing.Size(75, 23);
            this.AddCoach_Click.TabIndex = 8;
            this.AddCoach_Click.Text = "ADD";
            this.AddCoach_Click.UseVisualStyleBackColor = true;
            this.AddCoach_Click.Click += new System.EventHandler(this.AddCoach_Click_Click);
            // 
            // r_lastname_tr
            // 
            this.r_lastname_tr.Location = new System.Drawing.Point(6, 20);
            this.r_lastname_tr.Name = "r_lastname_tr";
            this.r_lastname_tr.Size = new System.Drawing.Size(100, 20);
            this.r_lastname_tr.TabIndex = 7;
            // 
            // r_rank
            // 
            this.r_rank.Location = new System.Drawing.Point(6, 137);
            this.r_rank.Name = "r_rank";
            this.r_rank.Size = new System.Drawing.Size(100, 20);
            this.r_rank.TabIndex = 6;
            // 
            // r_firstname_tr
            // 
            this.r_firstname_tr.Location = new System.Drawing.Point(6, 59);
            this.r_firstname_tr.Name = "r_firstname_tr";
            this.r_firstname_tr.Size = new System.Drawing.Size(100, 20);
            this.r_firstname_tr.TabIndex = 4;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(3, 121);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(33, 13);
            this.label20.TabIndex = 3;
            this.label20.Text = "Rank";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 82);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(47, 13);
            this.label19.TabIndex = 2;
            this.label19.Text = "Year BD";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 43);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 13);
            this.label18.TabIndex = 1;
            this.label18.Text = "Firstname";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 4);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Lastname";
            // 
            // ViewCoach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.id_coach);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.r_year_of_birth_tr);
            this.Controls.Add(this.tabCoach);
            this.Controls.Add(this.DeleteCoach_Click);
            this.Controls.Add(this.RenewCoach_Click);
            this.Controls.Add(this.AddCoach_Click);
            this.Controls.Add(this.r_lastname_tr);
            this.Controls.Add(this.r_rank);
            this.Controls.Add(this.r_firstname_tr);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Location = new System.Drawing.Point(4, 22);
            this.Name = "ViewCoach";
            this.Text = "ViewCoach";
            ((System.ComponentModel.ISupportInitialize)(this.tabCoach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox id_coach;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox r_lastname_tr;
        private System.Windows.Forms.TextBox r_rank;
        private System.Windows.Forms.TextBox r_firstname_tr;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView tabCoach;
        private System.Windows.Forms.Button DeleteCoach_Click;
        private System.Windows.Forms.Button RenewCoach_Click;
        private System.Windows.Forms.Button AddCoach_Click;
        private System.Windows.Forms.MaskedTextBox r_year_of_birth_tr;
        //private System.Windows.Forms.Label label30;

    }
}