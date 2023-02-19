
namespace lr5.View
{
    partial class ViewGum
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
            this.id_gum = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.DeleteGum_Click = new System.Windows.Forms.Button();
            this.RenewGum_Click = new System.Windows.Forms.Button();
            this.AddGum_Click = new System.Windows.Forms.Button();
            this.tabGum = new System.Windows.Forms.DataGridView();
            this.r_category = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.r_phone_number = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.r_capacity = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.r_address = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.r_name_gum = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabGum)).BeginInit();
            this.SuspendLayout();
            // 
            // id_gum
            // 
            this.id_gum.Location = new System.Drawing.Point(7, 240);
            this.id_gum.Name = "id_gum";
            this.id_gum.Size = new System.Drawing.Size(100, 20);
            this.id_gum.TabIndex = 15;
            this.id_gum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.r_capacity_KeyPress);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(7, 224);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(15, 13);
            this.label33.TabIndex = 14;
            this.label33.Text = "id";
            // 
            // DeleteGum_Click
            // 
            this.DeleteGum_Click.Location = new System.Drawing.Point(7, 329);
            this.DeleteGum_Click.Name = "DeleteGum_Click";
            this.DeleteGum_Click.Size = new System.Drawing.Size(75, 23);
            this.DeleteGum_Click.TabIndex = 13;
            this.DeleteGum_Click.Text = "Delete";
            this.DeleteGum_Click.UseVisualStyleBackColor = true;
            this.DeleteGum_Click.Click += new System.EventHandler(this.DeleteGum_Click_Click);
            // 
            // RenewGum_Click
            // 
            this.RenewGum_Click.Location = new System.Drawing.Point(7, 299);
            this.RenewGum_Click.Name = "RenewGum_Click";
            this.RenewGum_Click.Size = new System.Drawing.Size(75, 23);
            this.RenewGum_Click.TabIndex = 12;
            this.RenewGum_Click.Text = "Renew";
            this.RenewGum_Click.UseVisualStyleBackColor = true;
            this.RenewGum_Click.Click += new System.EventHandler(this.RenewGum_Click_Click);
            // 
            // AddGum_Click
            // 
            this.AddGum_Click.Location = new System.Drawing.Point(7, 269);
            this.AddGum_Click.Name = "AddGum_Click";
            this.AddGum_Click.Size = new System.Drawing.Size(75, 23);
            this.AddGum_Click.TabIndex = 11;
            this.AddGum_Click.Text = "ADD";
            this.AddGum_Click.UseVisualStyleBackColor = true;
            this.AddGum_Click.Click += new System.EventHandler(this.AddGum_Click_Click);
            // 
            // tabGum
            // 
            this.tabGum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabGum.Location = new System.Drawing.Point(114, 5);
            this.tabGum.Name = "tabGum";
            this.tabGum.Size = new System.Drawing.Size(667, 418);
            this.tabGum.TabIndex = 10;
            // 
            // r_category
            // 
            this.r_category.Location = new System.Drawing.Point(7, 197);
            this.r_category.Name = "r_category";
            this.r_category.Size = new System.Drawing.Size(100, 20);
            this.r_category.TabIndex = 9;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 180);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 13);
            this.label16.TabIndex = 8;
            this.label16.Text = "Category";
            // 
            // r_phone_number
            // 
            this.r_phone_number.Location = new System.Drawing.Point(7, 153);
            this.r_phone_number.Name = "r_phone_number";
            this.r_phone_number.Size = new System.Drawing.Size(100, 20);
            this.r_phone_number.TabIndex = 7;
            this.r_phone_number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.r_capacity_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 136);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "Phone number";
            // 
            // r_capacity
            // 
            this.r_capacity.Location = new System.Drawing.Point(7, 109);
            this.r_capacity.Name = "r_capacity";
            this.r_capacity.Size = new System.Drawing.Size(100, 20);
            this.r_capacity.TabIndex = 5;
            this.r_capacity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.r_capacity_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 92);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Capacity";
            // 
            // r_address
            // 
            this.r_address.Location = new System.Drawing.Point(7, 65);
            this.r_address.Name = "r_address";
            this.r_address.Size = new System.Drawing.Size(100, 20);
            this.r_address.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 44);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Address";
            // 
            // r_name_gum
            // 
            this.r_name_gum.Location = new System.Drawing.Point(7, 21);
            this.r_name_gum.Name = "r_name_gum";
            this.r_name_gum.Size = new System.Drawing.Size(100, 20);
            this.r_name_gum.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Name";
            // 
            // ViewGum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.id_gum);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.DeleteGum_Click);
            this.Controls.Add(this.RenewGum_Click);
            this.Controls.Add(this.AddGum_Click);
            this.Controls.Add(this.tabGum);
            this.Controls.Add(this.r_category);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.r_phone_number);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.r_capacity);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.r_address);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.r_name_gum);
            this.Controls.Add(this.label12);
            this.Location = new System.Drawing.Point(4, 22);
            this.Name = "ViewGum";
            this.Text = "ViewGum";
            ((System.ComponentModel.ISupportInitialize)(this.tabGum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox r_category;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox r_phone_number;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox r_capacity;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox r_address;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox r_name_gum;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button DeleteGum_Click;
        private System.Windows.Forms.Button RenewGum_Click;
        private System.Windows.Forms.Button AddGum_Click;
        private System.Windows.Forms.DataGridView tabGum;
        private System.Windows.Forms.TextBox id_gum;
        private System.Windows.Forms.Label label33;
    }
}