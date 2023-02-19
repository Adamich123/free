using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr5
{
    public class Gum
    {
        public string Name_gum
        {
            set; 
            get;
        }
        public string Address
        {
            set; 
            get;
        }
        public int Capacity
        {
            set; 
            get; 
        }
        public int Phone_number
        {
            set; 
            get; 
        }
        public string Category
        {
            set; 
            get; 
        }
        public int idGum
        {
            set; 
            get; 
        }
        public Gum() { }
        public Gum (string name, string addr, int capa, int ph_num, string cat, int id_gum)
        {
            Name_gum = name;
            Address = addr;
            Capacity = capa;
            Phone_number = ph_num;
            Category = cat;
            idGum = id_gum;
        }
    }
}
