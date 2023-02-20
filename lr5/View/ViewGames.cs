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
    public partial class ViewGames : Form
    {
        public ViewGames()
        {
            InitializeComponent();
            DB.OutputGames(tabGames);
            DB.OutputGms_clb(dataGridView1);
            DB.ComboboxClub(comboBox1);
        }


        private void AddGames_Click_Click(object sender, EventArgs e)
        {
            if (r_match.Text == string.Empty || id_match.Text == string.Empty)
            {
                MessageBox.Show("Поля пустые", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Control games = new Control(this);
                games.AddGames_Click();
                DB.OutputGms_clb(dataGridView1);
                DB.OutputGames(tabGames);
            }
        }

        private void RenewGames_Click_Click(object sender, EventArgs e)
        {
            if (r_match.Text == string.Empty || id_match.Text == string.Empty)
            {
                MessageBox.Show("Поля пустые", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Control games = new Control(this);
                games.RenewGames_Click();
                DB.OutputGms_clb(dataGridView1);
                DB.OutputGames(tabGames);
            }
        }

        private void DeleteGames_Click_Click(object sender, EventArgs e)
        {
            if (id_match.Text == string.Empty)
            {
                MessageBox.Show("Поле пустое", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Control games = new Control(this);
                games.DeleteGames_Click();
                DB.OutputGms_clb(dataGridView1);
                DB.OutputGames(tabGames);
            }

        }
        public int ID_Match { get => Convert.ToInt32(id_match.Text); set => id_match.Text=value.ToString(); }
        public string Match { get => r_match.Text; set => r_match.Text = value; }
        public string Clb { get => comboBox1.Text; set => comboBox1.Text = value; }

        private void button3_Click(object sender, EventArgs e)
        {
            if (id_match.Text == string.Empty || comboBox1.Text == string.Empty)
            {
                MessageBox.Show("Поля пустые", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Control games = new Control(this);
                games.Add_M_has_cl();
                DB.OutputGms_clb(dataGridView1);
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (id_match.Text == string.Empty || comboBox1.Text == string.Empty)
            {
                MessageBox.Show("Поля пустые", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Control games = new Control(this);
                games.Ren_M_has_cl();
                DB.OutputGms_clb(dataGridView1);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (id_match.Text == string.Empty)
            {
                MessageBox.Show("Поле пустое", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Control games = new Control(this);
                games.Del_M_has_cl();
                DB.OutputGms_clb(dataGridView1);
            }
            
        }
    }
}
