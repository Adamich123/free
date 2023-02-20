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
    public partial class ViewCoach : Form
    {
        public ViewCoach()
        {
            InitializeComponent();
            DB.OutputCoach(tabCoach);
        }
        public string Lastname_coach { get => this.r_lastname_tr.Text; set => this.r_lastname_tr.Text = value; }
        public string Firstname { get => this.r_firstname_tr.Text; set => this.r_firstname_tr.Text = value; }
        public string Year_BD_coach { get => this.r_year_of_birth_tr.Text; set => this.r_year_of_birth_tr.Text = value; }
        public string Rank { get => this.r_rank.Text; set => this.r_rank.Text = value; }
        public int ID_Coach { get => Convert.ToInt32(this.id_coach.Text); set => this.id_coach.Text = value.ToString(); }
        private void id_coach_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(Convert.ToChar(number)))
            {
                e.Handled = true;
            }
        }

        private void AddCoach_Click_Click(object sender, EventArgs e)
        {
            if(Lastname_coach==string.Empty||Firstname==string.Empty||Year_BD_coach==string.Empty|| Rank == string.Empty)
            {
                MessageBox.Show("Поля пустые", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Control coach = new Control(this);
                coach.AddCoach_Click();
                DB.OutputCoach(tabCoach);
            }
        }

        private void RenewCoach_Click_Click(object sender, EventArgs e)
        {
            if (Lastname_coach == string.Empty || Firstname == string.Empty || Year_BD_coach == string.Empty || Rank == string.Empty|| id_coach.Text == string.Empty)
            {
                MessageBox.Show("Поля пустые", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Control coach = new Control(this);
                coach.RenewCoach_Click();
                DB.OutputCoach(tabCoach);
            }
        }

        private void DeleteCoach_Click_Click(object sender, EventArgs e)
        {
            if (id_coach.Text == string.Empty)
            {
                MessageBox.Show("Полe ID пустое", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Control coach = new Control(this);
                coach.DeleteCoach_Click();
                DB.OutputCoach(tabCoach);
            }
        }
    }
}
