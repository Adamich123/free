using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr5
{
    public class Club
    {
        public string NameClub
        {
            set; 
            get; 
        }
        public string Year_create
        {
            set; 
            get; 
        }
        public string City
        {
            set; 
            get;
        }
        public int  Name_sponsor
        {
            set;
            get;
        }
        public int Type_car
        {
            set;
            get;
        }
        public int Nm_sport
        {
            set;
            get;
        }
        public int Nm_Coach
        {
            set;
            get;
        }
        public int Nm_Gum
        {
            set;
            get;
        }
        public int ID_club
        {
            set;
            get;
        }
        public Club() { }
        public Club(string nm_cl, string year, string ct, int sp, int tr, int co, int sport, int gm, int id_cl)
        {
            NameClub = nm_cl;
            Year_create = year;
            City = ct;
            Name_sponsor = sp;
            Type_car = tr;
            Nm_Coach = co;
            Nm_sport = sport;
            Nm_Gum = gm;
            ID_club = id_cl;
        }
    }
}
