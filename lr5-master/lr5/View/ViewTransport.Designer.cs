
namespace lr5.View
{
    partial class ViewTransport
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
            this.DeleteTransport_Click = new System.Windows.Forms.Button();
            this.RenewTransport_Click = new System.Windows.Forms.Button();
            this.AddTransport_Click = new System.Windows.Forms.Button();
            this.tabTransport = new System.Windows.Forms.DataGridView();
            this.r_capacity_tr = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.r_type_transport = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.id_transport = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabTransport)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteTransport_Click
            // 
            this.DeleteTransport_Click.Location = new System.Drawing.Point(7, 197);
            this.DeleteTransport_Click.Name = "DeleteTransport_Click";
            this.DeleteTransport_Click.Size = new System.Drawing.Size(75, 23);
            this.DeleteTransport_Click.TabIndex = 7;
            this.DeleteTransport_Click.Text = "Delete";
            this.DeleteTransport_Click.UseVisualStyleBackColor = true;
            this.DeleteTransport_Click.Click += new System.EventHandler(this.DeleteTransport_Click_Click);
            // 
            // RenewTransport_Click
            // 
            this.RenewTransport_Click.Location = new System.Drawing.Point(7, 167);
            this.RenewTransport_Click.Name = "RenewTransport_Click";
            this.RenewTransport_Click.Size = new System.Drawing.Size(75, 23);
            this.RenewTransport_Click.TabIndex = 6;
            this.RenewTransport_Click.Text = "Renew";
            this.RenewTransport_Click.UseVisualStyleBackColor = true;
            this.RenewTransport_Click.Click += new System.EventHandler(this.RenewTransport_Click_Click);
            // 
            // AddTransport_Click
            // 
            this.AddTransport_Click.Location = new System.Drawing.Point(7, 137);
            this.AddTransport_Click.Name = "AddTransport_Click";
            this.AddTransport_Click.Size = new System.Drawing.Size(75, 23);
            this.AddTransport_Click.TabIndex = 5;
            this.AddTransport_Click.Text = "ADD";
            this.AddTransport_Click.UseVisualStyleBackColor = true;
            this.AddTransport_Click.Click += new System.EventHandler(this.AddTransport_Click_Click);
            // 
            // tabTransport
            // 
            this.tabTransport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabTransport.Location = new System.Drawing.Point(111, 4);
            this.tabTransport.Name = "tabTransport";
            this.tabTransport.Size = new System.Drawing.Size(660, 392);
            this.tabTransport.TabIndex = 4;
            // 
            // r_capacity_tr
            // 
            this.r_capacity_tr.Location = new System.Drawing.Point(4, 65);
            this.r_capacity_tr.Name = "r_capacity_tr";
            this.r_capacity_tr.Size = new System.Drawing.Size(100, 20);
            this.r_capacity_tr.TabIndex = 3;
            this.r_capacity_tr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id_transport_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Capacity";
            // 
            // r_type_transport
            // 
            this.r_type_transport.Location = new System.Drawing.Point(4, 21);
            this.r_type_transport.Name = "r_type_transport";
            this.r_type_transport.Size = new System.Drawing.Size(100, 20);
            this.r_type_transport.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Type";
            // 
            // id_transport
            // 
            this.id_transport.Location = new System.Drawing.Point(4, 109);
            this.id_transport.Name = "id_transport";
            this.id_transport.Size = new System.Drawing.Size(100, 20);
            this.id_transport.TabIndex = 9;
            this.id_transport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id_transport_KeyPress);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(4, 92);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(15, 13);
            this.label32.TabIndex = 8;
            this.label32.Text = "id";
            // 
            // ViewTransport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.id_transport);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.DeleteTransport_Click);
            this.Controls.Add(this.RenewTransport_Click);
            this.Controls.Add(this.AddTransport_Click);
            this.Controls.Add(this.tabTransport);
            this.Controls.Add(this.r_capacity_tr);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.r_type_transport);
            this.Controls.Add(this.label10);
            this.Location = new System.Drawing.Point(4, 22);
            this.Name = "ViewTransport";
            this.Text = "ViewTransport";
            ((System.ComponentModel.ISupportInitialize)(this.tabTransport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView tabTransport;
        private System.Windows.Forms.TextBox r_capacity_tr;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox r_type_transport;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox id_transport;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Button DeleteTransport_Click;
        private System.Windows.Forms.Button RenewTransport_Click;
        private System.Windows.Forms.Button AddTransport_Click;
    }
}