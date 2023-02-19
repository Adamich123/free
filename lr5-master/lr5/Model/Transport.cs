using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr5
{
    public class Transport
    {
        public string Type
        {
            set; 
            get; 
        }
        public int Capacity_tr
        {
            set; 
            get;
        }
        public int ID_transport
        {
            set;
            get;
        }
        public Transport() { }
        public Transport(string tp, int cap, int id_tr)
        {
            Type = tp;
            Capacity_tr = cap;
            ID_transport = id_tr;
        }
    }
}
