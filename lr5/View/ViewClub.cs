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
    public partial class ViewClub : Form
    {
        public ViewClub()
        {
            InitializeComponent();
            DB.OutputClub(tabClub);
        }

        private void coachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewCoach frm = new ViewCoach();
            frm.ShowDialog();
        }

        private void gamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewGames frm = new ViewGames();
            frm.ShowDialog();
        }

        private void sportsmenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewSportsmen frm = new ViewSportsmen();
            frm.ShowDialog();
        }

        private void sponsorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewSponsor frm = new ViewSponsor();
            frm.ShowDialog();
        }

        private void gumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewGum frm = new ViewGum();
            frm.ShowDialog();
        }

        private void transportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewTransport frm = new ViewTransport();
            frm.ShowDialog();
        }
        public string Name_cl { get => this.r_nameClub.Text; set => this.r_nameClub.Text = value; }
        public string Year_cr { get => this.r_year_create.Text; set => this.r_year_create.Text = value; }
        public string City { get => this.r_city.Text; set => this.r_city.Text = value; }
        public int Spon { get => Convert.ToInt32(this.r_name_spon.Text); set => this.r_name_spon.Text = value.ToString(); }
        public int Trans { get => Convert.ToInt32(this.r_type_car.Text); set => this.r_type_car.Text = value.ToString(); }
        public int Coach { get => Convert.ToInt32(this.r_id_coach.Text); set => this.r_id_coach.Text = value.ToString(); }
        public int Gum { get => Convert.ToInt32(this.r_id_gum.Text); set => this.r_id_gum.Text = value.ToString(); }
        public int ID_club { get => Convert.ToInt32(this.id_club.Text); set => this.id_club.Text = value.ToString(); }

        private void r_name_spon_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(Convert.ToChar(number)))
            {
                e.Handled = true;
            }
        }

        private void AddClub_Click_Click(object sender, EventArgs e)
        {
            if (Name_cl==string.Empty|| Year_cr==string.Empty|| City==string.Empty|| r_name_spon.Text ==string.Empty|| r_type_car.Text==string.Empty || r_id_coach.Text==string.Empty)
            {
                MessageBox.Show("Поля пустые", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Control club = new Control(this);
                club.AddClub_Click();
                DB.OutputClub(tabClub);
            }
        }

        private void RenewClub_Click_Click(object sender, EventArgs e)
        {
            if (Name_cl == string.Empty || Year_cr == string.Empty || City == string.Empty || r_name_spon.Text == string.Empty || r_type_car.Text == string.Empty || r_id_coach.Text == string.Empty ||id_club.Text == string.Empty)
            {
                MessageBox.Show("Поля пустые", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Control club = new Control(this);
                club.RenewClub_Click();
                DB.OutputClub(tabClub);
            }
        }

        private void DeleteClub_Click_Click(object sender, EventArgs e)
        {
            if (id_club.Text == string.Empty)
            {
                
                    MessageBox.Show("Полe ID пустое", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                
            }
            else
            {
                Control club = new Control(this);
                club.AddClub_Click();
                DB.OutputClub(tabClub);
            }
        }
    }
}
