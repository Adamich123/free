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
    public partial class ViewTransport : Form
    {
        public ViewTransport()
        {
            InitializeComponent();
            DB.OutputTransport(tabTransport);
        }
        public int ID_tr { get => Convert.ToInt32(this.id_transport.Text); set => this.id_transport.Text = value.ToString(); }
        public int Capacity_tr { get => Convert.ToInt32(this.r_capacity_tr.Text); set => this.r_capacity_tr.Text = value.ToString(); }
        public string Type_tr { get => this.r_type_transport.Text; set => this.r_type_transport.Text = value; }
        private void id_transport_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(Convert.ToChar(number)))
            {
                e.Handled = true;
            }
        }

        private void AddTransport_Click_Click(object sender, EventArgs e)
        {
            if (r_capacity_tr.Text == string.Empty || Type_tr == string.Empty)
            {
                MessageBox.Show("Поля пустые", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Control_Transport tr = new Control_Transport(this);
                tr.AddTransport_Click();
                DB.OutputTransport(tabTransport);
            }
        }

        private void RenewTransport_Click_Click(object sender, EventArgs e)
        {
            if (r_capacity_tr.Text == string.Empty || Type_tr == string.Empty||id_transport.Text==string.Empty)
            {
                MessageBox.Show("Поля пустые", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Control_Transport tr = new Control_Transport(this);
                tr.RenewTransport_Click();
                DB.OutputTransport(tabTransport);
            }
        }

        private void DeleteTransport_Click_Click(object sender, EventArgs e)
        {
            if (id_transport.Text == string.Empty)
            {
                MessageBox.Show("Поле ID пустое", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Control_Transport tr = new Control_Transport(this);
                tr.DeleteTransport_Click();
                DB.OutputTransport(tabTransport);
            }
        }
    }
}
