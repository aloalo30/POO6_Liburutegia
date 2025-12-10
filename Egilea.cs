using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3POO_6
{
     class Egilea
    {
        private string idE, izena, nazionalitatea;

        public string IdE { get => idE; set => idE = value; }
        public string Izena { get => izena; set => izena = value; }
        public string Nazionalitatea { get => nazionalitatea; set => nazionalitatea = value; }
        public Egilea() { } 
       public Egilea(string ideg, string iz, string naz)
        {
            idE = ideg.ToUpper();
            izena = iz;
            Nazionalitatea = naz;
        }
        public string ToString()
        {
            //Fitxategiko egitura berdinarekin bueltatuko duena objetuko datuekin osatutako stringa, aztertu bakoitzak fitxategia
            return "--";
        }
    }
}
