using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lr5.View;


namespace lr5
{
    public partial class Form2 : Form
    {
        public Form2()
        {

            InitializeComponent();
        }

        string Name_cl { get => this.r_nameClub.Text; set => this.r_nameClub.Text=value; }
        string Year_cr { get => this.r_year_create.Text; set => this.r_year_create.Text=value; }
        string City { get => this.r_city.Text; set => this.r_city.Text=value; }
        int Spon { get => Convert.ToInt32(this.r_name_spon.Text); set => this.r_name_spon.Text=value.ToString(); }
        int Trans { get => Convert.ToInt32(this.r_type_car.Text); set => this.r_type_car.Text=value.ToString(); }
        int Coach { get => Convert.ToInt32(this.r_id_coach.Text); set => this.r_id_coach.Text=value.ToString(); }
        int Sport { get => Convert.ToInt32(this.r_id_sportsmen.Text); set => this.r_id_sportsmen.Text=value.ToString(); }
        int Gum { get => Convert.ToInt32(this.r_id_gum.Text); set => this.r_id_gum.Text=value.ToString(); }
        int ID_club { get => Convert.ToInt32(this.id_club.Text); set => this.id_club.Text=value.ToString(); }
        string Lastname_coach { get => this.r_lastname_tr.Text; set => this.r_lastname_tr.Text=value; }
        string Firstname { get => this.r_firstname_tr.Text; set => this.r_firstname_tr.Text=value; }
        string Year_BD_coach { get => this.r_year_of_birth_tr.Text; set => this.r_year_of_birth_tr.Text=value; }
        string Rank { get => this.r_rank.Text; set => this.r_rank.Text=value; }
        int ID_Coach { get => Convert.ToInt32(this.id_coach.Text); set => this.id_coach.Text=value.ToString(); }
        int ID_match { get => Convert.ToInt32(this.id_match.Text); set => this.id_match.Text=value.ToString(); }
        string Match { get => this.r_match.Text; set => this.r_match.Text=value; }
        string Name_gum { get => this.r_name_gum.Text; set => this.r_name_gum.Text=value; }
        string Address { get => this.r_address.Text; set => this.r_address.Text=value; }
        int Capacity_gm { get => Convert.ToInt32(this.r_capacity.Text); set => this.r_capacity.Text=value.ToString(); }
        int Phone_num { get => Convert.ToInt32(this.r_phone_number.Text); set => this.r_phone_number.Text=value.ToString(); }
        string Category_gm { get => this.r_category.Text; set => this.r_category.Text=value; }
        int ID_gum { get => Convert.ToInt32(this.id_gum.Text); set => this.id_gum.Text=value.ToString(); }
        string Name_spon { get => this.r_name_sponsor.Text; set => this.r_name_sponsor.Text=value; }
        int ID_Spon { get => Convert.ToInt32(this.id_spons.Text); set => this.id_spons.Text=value.ToString(); }
        int ID_sport { get => Convert.ToInt32(this.r_ID_sp.Text); set => this.r_ID_sp.Text=value.ToString(); }
        string Lastname_sp { get => this.r_lastname_sp.Text; set => this.r_lastname_sp.Text=value; }
        string Firstname_sp { get => this.r_firstname_sp.Text; set => this.r_firstname_sp.Text=value; }
        string Role { get => this.r_role.Text; set => this.r_role.Text=value.ToString(); }
        string Year_BD_sp { get => this.r_year_of_birth_sp.Text; set => this.r_year_of_birth_sp.Text=value; }
        double height { get => Convert.ToDouble(this.r_heigth.Text); set => this.r_heigth.Text=value.ToString(); }
        int Weight { get => Convert.ToInt32(this.r_weight.Text); set => this.r_weight.Text=value.ToString(); }
        string Data_hw { get => this.r_year_of_birth_sp.Text; set => this.r_year_of_birth_sp.Text=value; }
        int Number { get => Convert.ToInt32(this.r_number.Text); set => this.r_number.Text=value.ToString(); }
        int Club { get => Convert.ToInt32(this.r_id_club.Text); set => this.r_id_club.Text=value.ToString(); }
        int ID_tr { get => Convert.ToInt32(this.id_transport.Text); set => this.id_transport.Text=value.ToString(); }
        int Capacity_tr { get => Convert.ToInt32(this.r_capacity_tr.Text); set => this.r_capacity_tr.Text=value.ToString(); }
        string Type_tr { get => this.r_type_transport.Text; set => this.r_type_transport.Text=value; }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }
       

        
    }

}
