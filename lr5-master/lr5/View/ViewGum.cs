using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr5.View
{
    public partial class ViewGum : Form
    {
        public ViewGum()
        {
            InitializeComponent();
            DB.OutputGum(tabGum);
        }
        public string Name_gum { get => this.r_name_gum.Text; set => this.r_name_gum.Text = value; }
        public string Address { get => this.r_address.Text; set => this.r_address.Text = value; }
        public int Capacity_gm { get => Convert.ToInt32(this.r_capacity.Text); set => this.r_capacity.Text = value.ToString(); }
        public int Phone_num { get => Convert.ToInt32(this.r_phone_number.Text); set => this.r_phone_number.Text = value.ToString(); }
        public string Category_gm { get => this.r_category.Text; set => this.r_category.Text = value; }
        public int ID_gum { get => Convert.ToInt32(this.id_gum.Text); set => this.id_gum.Text = value.ToString(); }
        private void r_capacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(Convert.ToChar(number)))
            {
                e.Handled = true;
            }
        }

        private void AddGum_Click_Click(object sender, EventArgs e)
        {
            if (Name_gum == string.Empty || Address == string.Empty || r_capacity.Text == string.Empty || r_phone_number.Text == string.Empty || Category_gm == string.Empty)
            {
                MessageBox.Show("Поля пустые", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Control_Gum gum = new Control_Gum(this);
                gum.AddGum_Click();
                DB.OutputGum(tabGum);
            }
        }

        private void RenewGum_Click_Click(object sender, EventArgs e)
        {
            if (Name_gum == string.Empty || Address == string.Empty || r_capacity.Text == string.Empty || r_phone_number.Text == string.Empty || Category_gm == string.Empty|| id_gum.Text == string.Empty)
            {
                MessageBox.Show("Поля пустые", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Control_Gum gum = new Control_Gum(this);
                gum.RenewGum_Click();
                DB.OutputGum(tabGum);
            }
        }

        private void DeleteGum_Click_Click(object sender, EventArgs e)
        {
            if (id_gum.Text == string.Empty)
            {
                MessageBox.Show("Полe ID пустое", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Control_Gum gum = new Control_Gum(this);
                gum.DeleteGum_Click();
                DB.OutputGum(tabGum);
            }
        }
    }
}
