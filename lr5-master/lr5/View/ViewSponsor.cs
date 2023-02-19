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
    public partial class ViewSponsor : Form
    {
        public ViewSponsor()
        {
            InitializeComponent();
            DB.OutputSponsor(tabSponsor);
        }
        public string Name_spon { get => this.r_name_sponsor.Text; set => this.r_name_sponsor.Text = value; }
        public int ID_Spon { get => Convert.ToInt32(this.id_spons.Text); set => this.id_spons.Text = value.ToString(); }
        private void id_spons_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(Convert.ToChar(number)))
            {
                e.Handled = true;
            }
        }

        private void AddSponsor_Click_Click(object sender, EventArgs e)
        {
            if (Name_spon == string.Empty)
            {
                MessageBox.Show("Поля пустые", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Control_Sponsor spon = new Control_Sponsor(this);
                spon.AddSponsor_Click();
                DB.OutputSponsor(tabSponsor);
            }
        }

        private void RenewSponsor_Click_Click(object sender, EventArgs e)
        {
            if (Name_spon == string.Empty || id_spons.Text == string.Empty)
            {
                MessageBox.Show("Поля пустые", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Control_Sponsor spon = new Control_Sponsor(this);
                spon.RenewSponsor_Click();
                DB.OutputSponsor(tabSponsor);
            }
        }

        private void DeleteSponsor_Click_Click(object sender, EventArgs e)
        {
            if (id_spons.Text == string.Empty)
            {
                MessageBox.Show("Поле ID пустое", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Control_Sponsor spon = new Control_Sponsor(this);
                spon.DeleteSonsor_Click();
                DB.OutputSponsor(tabSponsor);
            }
        }
    }
}
