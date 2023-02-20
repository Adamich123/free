using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace lr5
{
    class DB
    {
        public static MySqlConnection GetConnection()
        {
            string sql = @"server=192.168.1.107;port=3306; database=db;uid=root;pwd=123456;";
            MySqlConnection mycon = new MySqlConnection(sql);
            try
            {
                mycon.Open();
            }
            catch (Exception er)
            {
                MessageBox.Show("Ошибка подключения ! " + er.Message, "Information");
            }
            return mycon;
        }
        //sportsmen
        public static void AddSportsmen(Sportsmen std)
        {
            string sql = "INSERT INTO Sportsmen (id_Sportsmen, lastname_sp, firstname_sp, role, year_of_birth_sp, height, weight, data_hw, number, Club_idClub) VALUES (NULL, @lastname_sp, @firstname_sp, @role, @year_of_birth_sp, @height, @weight, @data_hw, @number, @Club_idClub);";
            MySqlConnection mycon = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, mycon);
            cmd.CommandType = System.Data.CommandType.Text;
            // cmd.Parameters.Add("@id_Sportsmen", MySqlDbType.Int32).Value = std.id_Sportsmen;
            cmd.Parameters.Add("@lastname_sp", MySqlDbType.String).Value = std.Lastname_sp;
            cmd.Parameters.Add("@firstname_sp", MySqlDbType.String).Value = std.Firstname_sp;
            cmd.Parameters.Add("@role", MySqlDbType.String).Value = std.Role;
            cmd.Parameters.Add("@year_of_birth_sp", MySqlDbType.Date).Value = std.Year_of_birth_sp;
            cmd.Parameters.Add("@height", MySqlDbType.Int32).Value = std.Height;
            cmd.Parameters.Add("@weight", MySqlDbType.Int32).Value = std.Weight;
            cmd.Parameters.Add("@data_hw", MySqlDbType.Date).Value = std.Data_hw;
            cmd.Parameters.Add("@number", MySqlDbType.Int32).Value = std.Number;
            cmd.Parameters.Add("@Club_idClub", MySqlDbType.Int32).Value = std.Club;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mycon.Close();
        }
        public static void OutputSportsmen(DataGridView dgv)
        {
            
            MySqlConnection mycon = GetConnection();
            
            MySqlDataAdapter ad = new MySqlDataAdapter("select * from Sportsmen", mycon);
            DataTable tbl = new DataTable();
            ad.Fill(tbl);
            dgv.DataSource = tbl;
            mycon.Close();
            
        }
        public static void DeleteSportsmen(Sportsmen std)
        {
            string sql = "DELETE FROM Sportsmen WHERE id_Sportsmen=@id_Sportsmen";
            MySqlConnection mycon = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, mycon);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@id_Sportsmen", MySqlDbType.Int32).Value = std.id_Sportsmen;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mycon.Close();
        }
        public static void RenewSportsmen(Sportsmen std)
        {
            string sql = "UPDATE Sportsmen SET  lastname_sp=@lastname_sp, firstname_sp=@firstname_sp, role=@role, year_of_birth_sp=@year_of_birth_sp, height=@height, weight=@weight, data_hw=@data_hw, number=@number, Club_idClub=@Club_idClub WHERE  id_Sportsmen=@id_Sportsmen";
            MySqlConnection mycon = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, mycon);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@id_Sportsmen", MySqlDbType.Int32).Value = std.id_Sportsmen;
            cmd.Parameters.Add("@lastname_sp", MySqlDbType.String).Value = std.Lastname_sp;
            cmd.Parameters.Add("@firstname_sp", MySqlDbType.String).Value = std.Firstname_sp;
            cmd.Parameters.Add("@role", MySqlDbType.String).Value = std.Role;
            cmd.Parameters.Add("@year_of_birth_sp", MySqlDbType.Date).Value = std.Year_of_birth_sp;
            cmd.Parameters.Add("@height", MySqlDbType.Double).Value = std.Height;
            cmd.Parameters.Add("@weight", MySqlDbType.Int32).Value = std.Weight;
            cmd.Parameters.Add("@data_hw", MySqlDbType.Date).Value = std.Data_hw;
            cmd.Parameters.Add("@number", MySqlDbType.Int32).Value = std.Number;
            cmd.Parameters.Add("@Club_idClub", MySqlDbType.Int32).Value=std.Club;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mycon.Close();
        }
        //sponsor
        public static void AddSponsor(Sponsor std)
        {
            string sql = "INSERT INTO Sponsor (id_Sponsor, name_sponsor) VALUES (NULL, @name_sponsor)";
            MySqlConnection mycon = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, mycon);
            cmd.CommandType = System.Data.CommandType.Text;
            // cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = std.ID_spon;
            cmd.Parameters.Add("@name_sponsor", MySqlDbType.String).Value = std.Name_sponsor;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mycon.Close();
        }
        public static void OutputSponsor(DataGridView dgv)
        {
            MySqlConnection mycon = GetConnection();
            MySqlDataAdapter ad = new MySqlDataAdapter("select * from Sponsor", mycon);
            DataTable tbl = new DataTable();
            ad.Fill(tbl);
            
            dgv.DataSource = tbl;
            mycon.Close();
        }
        public static void DeleteSponsor(Sponsor std)
        {
            string sql = "DELETE FROM Sponsor WHERE id_Sponsor=@id_Sponsor";
            MySqlConnection mycon = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, mycon);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@id_Sponsor", MySqlDbType.Int32).Value = std.ID_spon;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mycon.Close();
        }
        public static void RenewSponsor(Sponsor std)
        {
            string sql = "UPDATE Sponsor SET name_sponsor=@name_sponsor WHERE  id_Sponsor=@id_Sponsor";
            MySqlConnection mycon = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, mycon);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@id_Sponsor", MySqlDbType.Int32).Value = std.ID_spon;
            cmd.Parameters.Add("@name_sponsor", MySqlDbType.String).Value = std.Name_sponsor;
     
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mycon.Close();
        }
        //transporn
        public static void AddTransport(Transport std)
        {
            string sql = "INSERT INTO Transport (idTransport, type, capacity_tr) VALUES (NULL, @type, @capacity_tr)";
            MySqlConnection mycon = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, mycon);
            cmd.CommandType = System.Data.CommandType.Text;
            // cmd.Parameters.Add("@idTransport", MySqlDbType.Int32).Value = std.ID_transport;
            cmd.Parameters.Add("@type", MySqlDbType.String).Value = std.Type;
            cmd.Parameters.Add("@capacity_tr", MySqlDbType.Int32).Value = std.Capacity_tr;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mycon.Close();
        }
        public static void OutputTransport(DataGridView dgv)
        {
            MySqlConnection mycon = GetConnection();
            MySqlDataAdapter ad = new MySqlDataAdapter("SELECT * FROM Transport", mycon);
            DataTable tbl = new DataTable();
            ad.Fill(tbl);
            dgv.DataSource = tbl;
            mycon.Close();
        }
        public static void DeleteTransport(Transport std)
        {
            string sql = "DELETE FROM Transport WHERE idTransport=@idTransport";
            MySqlConnection mycon = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, mycon);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@idTransport", MySqlDbType.Int32).Value =std.ID_transport;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mycon.Close();
        }
        public static void RenewTransport(Transport std)
        {
            string sql = "UPDATE Transport SET  type=@type, capacity_tr=@capacity_tr WHERE  idTransport=@idTransport";
            MySqlConnection mycon = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, mycon);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@idTransport", MySqlDbType.Int32).Value = std.ID_transport;
            cmd.Parameters.Add("@type", MySqlDbType.String).Value = std.Type;
            cmd.Parameters.Add("@capacity_tr", MySqlDbType.Int32).Value = std.Capacity_tr;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mycon.Close();
        }
        //gum
        public static void AddGum(Gum std)
        {
            string sql = "INSERT INTO Gum (idGum, name_gum, address, capacity, phone_number, category) VALUES (NULL, @name_gum, @address, @capacity, @phone_number, @category)";
            MySqlConnection mycon = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, mycon);
            cmd.CommandType = System.Data.CommandType.Text;
            // cmd.Parameters.Add("@idGum", MySqlDbType.Int32).Value = std.idGum;
            cmd.Parameters.Add("@name_gum", MySqlDbType.String).Value = std.Name_gum;
            cmd.Parameters.Add("@address", MySqlDbType.String).Value = std.Address;
            cmd.Parameters.Add("@capacity", MySqlDbType.Int32).Value = std.Capacity;
            cmd.Parameters.Add("@phone_number", MySqlDbType.Int32).Value = std.Phone_number;
            cmd.Parameters.Add("@category", MySqlDbType.String).Value = std.Category;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mycon.Close();
        }
        public static void OutputGum(DataGridView dgv)
        {
            MySqlConnection mycon = GetConnection();
            MySqlDataAdapter ad = new MySqlDataAdapter("SELECT * FROM Gum", mycon);
            DataTable tbl = new DataTable();
            ad.Fill(tbl);
            dgv.DataSource = tbl;
            mycon.Close();
        }
        public static void DeleteGum(Gum std)
        {
            string sql = "DELETE FROM Gum WHERE idGum=@idGum";
            MySqlConnection mycon = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, mycon);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@idGum", MySqlDbType.Int32).Value = std.idGum;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mycon.Close();
        }
        public static void RenewGum(Gum std)
        {
            string sql = "UPDATE Gum SET  name_gum=@name_gum, address=@address, capacity=@capacity, phone_number=@phone_number, category=@category WHERE  idGum=@idGum";
            MySqlConnection mycon = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, mycon);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@idGum", MySqlDbType.Int32).Value = std.idGum;
            cmd.Parameters.Add("@name_gum", MySqlDbType.String).Value = std.Name_gum;
            cmd.Parameters.Add("@address", MySqlDbType.String).Value = std.Address;
            cmd.Parameters.Add("@capacity", MySqlDbType.Int32).Value = std.Capacity;
            cmd.Parameters.Add("@phone_number", MySqlDbType.Int32).Value = std.Phone_number;
            cmd.Parameters.Add("@category", MySqlDbType.Int32).Value = std.Category;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mycon.Close();
        }
        //games
        public static void AddGames(Games std)
        {
            string sql = "INSERT INTO Games (idMatch, Mtch) VALUES (@idMatch, @Match)";
            
            MySqlConnection mycon = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, mycon);

            cmd.CommandType = System.Data.CommandType.Text;
            // cmd.Parameters.Add("@idGum", MySqlDbType.Int32).Value = std.idGum;
            cmd.Parameters.Add("@idMatch", MySqlDbType.Int32).Value = std.ID_Match;
            cmd.Parameters.Add("@Match", MySqlDbType.String).Value = std.Match;
            

            try
            {
                cmd.ExecuteNonQuery();
                
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mycon.Close();
        }
        public static void OutputGames(DataGridView dgv)
        {
            MySqlConnection mycon = GetConnection();
            MySqlDataAdapter ad = new MySqlDataAdapter("SELECT * FROM Games", mycon);
            DataTable tbl = new DataTable();
            ad.Fill(tbl);
            dgv.DataSource = tbl;
            mycon.Close();
        }
        public static void DeleteGames(Games std)
        {
            string sql = "DELETE FROM Games WHERE idMatch=@idMatch";
            MySqlConnection mycon = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, mycon);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@idMatch", MySqlDbType.Int32).Value = std.ID_Match;
            try
            {
                cmd.ExecuteNonQuery();
                
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mycon.Close();
        }
        public static void RenewGames(Games std)
        {
            string sql = "UPDATE Games SET  Mtch=@Match WHERE  idMatch=@idMatch";
            MySqlConnection mycon = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, mycon);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@idMatch", MySqlDbType.Int32).Value = std.ID_Match;
            cmd.Parameters.Add("@Match", MySqlDbType.String).Value = std.Match;
            
            try
            {
                cmd.ExecuteNonQuery();
                
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mycon.Close();
        }
        public static void AddGms_clb(Games std)
        {
            string sql = "INSERT INTO Games_has_Club (Games_idMatch, Club_idClub) VALUES (@Games_idMatch, @Club_idClub)";
            MySqlConnection mycon = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, mycon);

            cmd.CommandType = System.Data.CommandType.Text;
            // cmd.Parameters.Add("@idGum", MySqlDbType.Int32).Value = std.idGum;
            cmd.Parameters.Add("@Games_idMatch", MySqlDbType.Int32).Value = std.ID_Match;
            cmd.Parameters.Add("@Club_idClub", MySqlDbType.String).Value = std.N_cl;


            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mycon.Close();
        }
        public static void OutputGms_clb(DataGridView dgv)
        {
            MySqlConnection mycon = GetConnection();
            MySqlDataAdapter ad = new MySqlDataAdapter("SELECT * FROM Games_has_club", mycon);
            DataTable tbl = new DataTable();
            ad.Fill(tbl);
            dgv.DataSource = tbl;
            mycon.Close();
        }
        public static void DeleteGms_clb(Games std)
        {
            string sql = "DELETE FROM Games_has_club WHERE games_idMatch=@games_idMatch";
            MySqlConnection mycon = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, mycon);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@games_idMatch", MySqlDbType.Int32).Value = std.ID_Match;
            try
            {
                cmd.ExecuteNonQuery();
                
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mycon.Close();
        }
        public static void RenewGms_clb(Games std)
        {
            string sql = "UPDATE Gum SET  name_gum=@name_gum, address=@address, capacity=@capacity, phone_number=@phone_number, category@=category WHERE  idGum=@idGum";
            MySqlConnection mycon = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, mycon);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@Games_idMatch", MySqlDbType.Int32).Value = std.ID_Match;
            cmd.Parameters.Add("@Club_idClub", MySqlDbType.String).Value = std.N_cl;

            try
            {
                cmd.ExecuteNonQuery();
                
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mycon.Close();
        }
        
        public static void ComboboxClub(ComboBox cmb)
        {
            try
            {
                
                MySqlConnection mycon = GetConnection();
                string sql = "SELECT idclub FROM Club";
            
                MySqlCommand cmd = new MySqlCommand(sql, mycon);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    
                    cmb.Items.Add(reader.GetValue(0).ToString());
                    
                }
                mycon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //coach
        public static void AddCoach(Coach std)
        {
            string sql = "INSERT INTO Coach (idCoach, lastname_tr, firstname_tr, year_of_birth_tr, rank) VALUES (NULL, @lastname_tr, @firstname_tr, @year_of_birth_tr, @rank)";
            MySqlConnection mycon = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, mycon);
            cmd.CommandType = System.Data.CommandType.Text;
            // cmd.Parameters.Add("@idCoach", MySqlDbType.Int32).Value = std.idCoach;
            cmd.Parameters.Add("@lastname_tr", MySqlDbType.String).Value = std.Lastname_tr;
            cmd.Parameters.Add("@firstname_tr", MySqlDbType.String).Value = std.Firstname_tr;
            cmd.Parameters.Add("@year_of_birth_tr", MySqlDbType.Date).Value = std.Year_of_birth_tr;
            cmd.Parameters.Add("@rank", MySqlDbType.Int32).Value = std.Rank;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mycon.Close();
        }
        public static void OutputCoach(DataGridView dgv)
        {
            MySqlConnection mycon = GetConnection();
            MySqlDataAdapter ad = new MySqlDataAdapter("SELECT * FROM Coach", mycon);
            DataTable tbl = new DataTable();
            ad.Fill(tbl);
            dgv.DataSource = tbl;
            mycon.Close();
        }
        public static void DeleteCoach(Coach std)
        {
            string sql = "DELETE FROM Coach WHERE idCoach=@idCoach";
            MySqlConnection mycon = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, mycon);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@idCoach", MySqlDbType.Int32).Value = std.idCoach;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mycon.Close();
        }
        public static void RenewCoach(Coach std)
        {
            string sql = "UPDATE Coach SET  lastname_tr=@lastname_tr, firstname_tr=@firstname_tr, year_of_birth_tr=@year_of_birth_tr, rank=@rank WHERE  idCoach=@idCoach";
            MySqlConnection mycon = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, mycon);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@idCoach", MySqlDbType.Int32).Value = std.idCoach;
            cmd.Parameters.Add("@lastname_tr", MySqlDbType.String).Value = std.Lastname_tr;
            cmd.Parameters.Add("@firstname_tr", MySqlDbType.String).Value = std.Firstname_tr;
            cmd.Parameters.Add("@year_of_birth_tr", MySqlDbType.Date).Value = std.Year_of_birth_tr;
            cmd.Parameters.Add("@rank", MySqlDbType.Int32).Value = std.Rank;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mycon.Close();
        }
        //club
        public static void AddClub(Club std)
        {
            string sql = "INSERT INTO Club (idClub, nameClub, year_create, city, idSponsor, idTransport, idCoach, idGum) VALUES (NULL, @nameClub, @year_create, @city, @idSponsor, @idTransport, @idCoach,  @idGum)";
            MySqlConnection mycon = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, mycon);
            cmd.CommandType = System.Data.CommandType.Text;
            // cmd.Parameters.Add("@idClub", MySqlDbType.Int32).Value = std.ID_club;
            cmd.Parameters.Add("@nameClub", MySqlDbType.String).Value = std.NameClub;
            cmd.Parameters.Add("@city", MySqlDbType.String).Value = std.City;
            cmd.Parameters.Add("@year_create", MySqlDbType.Date).Value = std.Year_create;
            cmd.Parameters.Add("@idSponsor", MySqlDbType.Int32).Value = std.Name_sponsor;
            cmd.Parameters.Add("@idTransport", MySqlDbType.Int32).Value = std.Type_car;
            cmd.Parameters.Add("@idCoach", MySqlDbType.Int32).Value = std.Nm_Coach;
            
            cmd.Parameters.Add("@idGum", MySqlDbType.Int32).Value = std.Nm_Gum;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mycon.Close();
        }
        public static void OutputClub(DataGridView dgv)
        {
            MySqlConnection mycon = GetConnection();
            MySqlDataAdapter ad = new MySqlDataAdapter("SELECT * FROM Club", mycon);
            DataTable tbl = new DataTable();
            ad.Fill(tbl);
            dgv.DataSource = tbl;
            mycon.Close();
        }
        public static void DeleteClub(Club std)
        {
            string sql = "DELETE FROM Club WHERE idClub=@idClub";
            MySqlConnection mycon = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, mycon);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@idClub", MySqlDbType.Int32).Value = std.ID_club;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mycon.Close();
        }
        public static void RenewClub(Club std)
        {
            string sql = "UPDATE Club SET  nameClub=@nameClub, city=@city, year_create=@year_create, idSponsor=@idSponsor, idTransport=@idTransport, idCoach=@idCoach,  idGum=@idGum WHERE  idClub=@idClub";
            MySqlConnection mycon = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, mycon);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@idClub", MySqlDbType.Int32).Value = std.ID_club;
            cmd.Parameters.Add("@nameClub", MySqlDbType.String).Value = std.NameClub;
            cmd.Parameters.Add("@city", MySqlDbType.String).Value = std.City;
            cmd.Parameters.Add("@year_create", MySqlDbType.Date).Value = std.Year_create;
            cmd.Parameters.Add("@idSponsor", MySqlDbType.Int32).Value = std.Name_sponsor;
            cmd.Parameters.Add("@idTransport", MySqlDbType.Int32).Value = std.Type_car;
            cmd.Parameters.Add("@idCoach", MySqlDbType.Int32).Value = std.Nm_Coach;

            cmd.Parameters.Add("@idGum", MySqlDbType.Int32).Value = std.Nm_Gum;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mycon.Close();
        }
        
    }
}
