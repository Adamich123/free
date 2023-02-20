using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr5
{
    public class Sportsmen
    {
        public int id_Sportsmen
        {
            set; 
            get; 
        }
        public string Lastname_sp
        {
            set; 
            get; 
        }
        public string Firstname_sp
        {
            set; 
            get; 
        }
        
        public string Role
        {
            set; 
            get; 
        }
        public string Year_of_birth_sp
        {
            set; 
            get; 
        }
        public int Height
        {
            set; 
            get; 
        }
        public int Weight
        {
            set;
            get;
        }
        public string Data_hw
        {
            set; 
            get; 
        }
        public int Number
        {
            set; 
            get; 
        }
        public int Club
        {
            set;
            get;
        }
        public Sportsmen() { }
        public Sportsmen(int id_sport, string last_sp, string first_sp, string rl, string year_bd, int ht, int wt, string dt_hw, int num, int cl)
        {
            id_Sportsmen = id_sport;
            Lastname_sp = last_sp;
            Firstname_sp = first_sp;
            Role = rl;
            Year_of_birth_sp = year_bd;
            Height = ht;
            Weight = wt;
            Data_hw = dt_hw;
            Number = num;
            Club = cl;
        }
    }
}
