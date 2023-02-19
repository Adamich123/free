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
    public partial class ViewSportsmen : Form
    {
        public ViewSportsmen()
        {
            InitializeComponent();
            DB.OutputSportsmen(tabSportsmen);
        }

        private void r_ID_sp_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(Convert.ToChar(number)))
            {
                e.Handled = true;
            }
        }
        public int ID_sport { get => Convert.ToInt32(this.r_ID_sp.Text); set => this.r_ID_sp.Text = value.ToString(); }
        public string Lastname_sp { get => this.r_lastname_sp.Text; set => this.r_lastname_sp.Text = value; }
        public string Firstname_sp { get => this.r_firstname_sp.Text; set => this.r_firstname_sp.Text = value; }
        public string Role { get => this.r_role.Text; set => this.r_role.Text = value.ToString(); }
        public string Year_BD_sp { get => this.r_year_of_birth_sp.Text; set => this.r_year_of_birth_sp.Text = value; }
        public int Hght { get => Convert.ToInt32(this.r_heigth.Text); set => this.r_heigth.Text = value.ToString(); }
        public int Weight { get => Convert.ToInt32(this.r_weight.Text); set => this.r_weight.Text = value.ToString(); }
        public string Data_hw { get => this.r_year_of_birth_sp.Text; set => this.r_year_of_birth_sp.Text = value; }
        public int Number { get => Convert.ToInt32(this.r_number.Text); set => this.r_number.Text = value.ToString(); }
        public int Club { get => Convert.ToInt32(this.r_id_club.Text); set => this.r_id_club.Text = value.ToString(); }

        private void AddSp_Click_Click(object sender, EventArgs e)
        {
            if (r_id_club.Text==string.Empty ||Lastname_sp==string.Empty || Firstname_sp == string.Empty || Role == string.Empty || Year_BD_sp == string.Empty || r_heigth.Text == string.Empty || r_weight.Text == string.Empty || Data_hw == string.Empty || r_number.Text == string.Empty)
            {
                MessageBox.Show("Поля пустые", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Control_Sportsmen sp = new Control_Sportsmen(this);
                sp.AddSportsmen_Click();
                DB.OutputSportsmen(tabSportsmen);
            }
        }

        private void RenewSp_Click_Click(object sender, EventArgs e)
        {
            if (r_id_club.Text == string.Empty || Lastname_sp == string.Empty || Firstname_sp == string.Empty || Role == string.Empty || Year_BD_sp == string.Empty || r_heigth.Text == string.Empty || r_weight.Text == string.Empty || Data_hw == string.Empty || r_number.Text == string.Empty||r_ID_sp.Text==string.Empty)
            {
                MessageBox.Show("Поля пустые", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Control_Sportsmen sp = new Control_Sportsmen(this);
                sp.RenewSportsmen_Click();
                DB.OutputSportsmen(tabSportsmen);
            }
        }

        private void DeleteSp_Click_Click(object sender, EventArgs e)
        {
            if (r_ID_sp.Text == string.Empty)
            {
                MessageBox.Show("Поле ID пустое", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Control_Sportsmen sp = new Control_Sportsmen(this);
                sp.DeleteSportsmen_Click();
                DB.OutputSportsmen(tabSportsmen);
            }
        }
    }
}
