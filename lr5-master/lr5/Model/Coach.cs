using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr5
{
    public class Coach
    {
        public string Lastname_tr
        {
            set; 
            get; 
        }
        public string Firstname_tr
        {
            set; 
            get; 
        }
        public string Year_of_birth_tr
        {
            set; 
            get; 
        }
        public string Rank
        {
            set; 
            get;
        }
        public int idCoach
        {
            set;
            get;
        }
        public Coach() { }
        public Coach(string last_tr, string firs_tr, string year_tr, string rk, int id_coach)
        {
            Lastname_tr = last_tr;
            Firstname_tr = firs_tr;
            Year_of_birth_tr = year_tr;
            Rank = rk;
            idCoach = id_coach;
        }
    }
}
