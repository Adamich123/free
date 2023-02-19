using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr5
{
    public class Games
    {
        public string Match
        {
            set;
            get;
        }
        public int ID_Match
        {
            set;
            get;
        }
        public string N_cl
        {
            set;
            get;
        }
        public Games() { }
        public Games( string ma, int id_ma, string cl)
        {
            Match = ma;
            ID_Match = id_ma;
            N_cl=cl;
        }
    }
}
