
namespace lr5.View
{
    partial class ViewSponsor
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
            this.id_spons = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.DeleteSponsor_Click = new System.Windows.Forms.Button();
            this.RenewSponsor_Click = new System.Windows.Forms.Button();
            this.AddSponsor_Click = new System.Windows.Forms.Button();
            this.tabSponsor = new System.Windows.Forms.DataGridView();
            this.r_name_sponsor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabSponsor)).BeginInit();
            this.SuspendLayout();
            // 
            // id_spons
            // 
            this.id_spons.Location = new System.Drawing.Point(10, 70);
            this.id_spons.Name = "id_spons";
            this.id_spons.Size = new System.Drawing.Size(100, 20);
            this.id_spons.TabIndex = 7;
            this.id_spons.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id_spons_KeyPress);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(10, 51);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(15, 13);
            this.label31.TabIndex = 6;
            this.label31.Text = "id";
            // 
            // DeleteSponsor_Click
            // 
            this.DeleteSponsor_Click.Location = new System.Drawing.Point(10, 156);
            this.DeleteSponsor_Click.Name = "DeleteSponsor_Click";
            this.DeleteSponsor_Click.Size = new System.Drawing.Size(75, 23);
            this.DeleteSponsor_Click.TabIndex = 5;
            this.DeleteSponsor_Click.Text = "Delete";
            this.DeleteSponsor_Click.UseVisualStyleBackColor = true;
            this.DeleteSponsor_Click.Click += new System.EventHandler(this.DeleteSponsor_Click_Click);
            // 
            // RenewSponsor_Click
            // 
            this.RenewSponsor_Click.Location = new System.Drawing.Point(10, 126);
            this.RenewSponsor_Click.Name = "RenewSponsor_Click";
            this.RenewSponsor_Click.Size = new System.Drawing.Size(75, 23);
            this.RenewSponsor_Click.TabIndex = 4;
            this.RenewSponsor_Click.Text = "Renew";
            this.RenewSponsor_Click.UseVisualStyleBackColor = true;
            this.RenewSponsor_Click.Click += new System.EventHandler(this.RenewSponsor_Click_Click);
            // 
            // AddSponsor_Click
            // 
            this.AddSponsor_Click.Location = new System.Drawing.Point(10, 96);
            this.AddSponsor_Click.Name = "AddSponsor_Click";
            this.AddSponsor_Click.Size = new System.Drawing.Size(75, 23);
            this.AddSponsor_Click.TabIndex = 3;
            this.AddSponsor_Click.Text = "ADD";
            this.AddSponsor_Click.UseVisualStyleBackColor = true;
            this.AddSponsor_Click.Click += new System.EventHandler(this.AddSponsor_Click_Click);
            // 
            // tabSponsor
            // 
            this.tabSponsor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabSponsor.Location = new System.Drawing.Point(117, 7);
            this.tabSponsor.Name = "tabSponsor";
            this.tabSponsor.Size = new System.Drawing.Size(653, 386);
            this.tabSponsor.TabIndex = 2;
            // 
            // r_name_sponsor
            // 
            this.r_name_sponsor.Location = new System.Drawing.Point(10, 24);
            this.r_name_sponsor.Name = "r_name_sponsor";
            this.r_name_sponsor.Size = new System.Drawing.Size(100, 20);
            this.r_name_sponsor.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Name sponsor";
            // 
            // ViewSponsor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 447);
            this.Controls.Add(this.id_spons);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.DeleteSponsor_Click);
            this.Controls.Add(this.RenewSponsor_Click);
            this.Controls.Add(this.AddSponsor_Click);
            this.Controls.Add(this.tabSponsor);
            this.Controls.Add(this.r_name_sponsor);
            this.Controls.Add(this.label9);
            this.Location = new System.Drawing.Point(4, 22);
            this.Name = "ViewSponsor";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "Sponsor";
            ((System.ComponentModel.ISupportInitialize)(this.tabSponsor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button DeleteSponsor_Click;
        private System.Windows.Forms.Button RenewSponsor_Click;
        private System.Windows.Forms.Button AddSponsor_Click;
        private System.Windows.Forms.DataGridView tabSponsor;
        private System.Windows.Forms.TextBox r_name_sponsor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox id_spons;
        private System.Windows.Forms.Label label31;

    }
}