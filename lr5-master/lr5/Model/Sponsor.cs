using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr5
{
    public class Sponsor
    {
        public string Name_sponsor
        {
            set;
            get; 
        }
        public int ID_spon
        {
            set;
            get;
        }
        public Sponsor() { }
        public Sponsor(string name_spon, int id_spon)
        {
            Name_sponsor = name_spon;
            ID_spon = id_spon;
            
        }
    }
}
