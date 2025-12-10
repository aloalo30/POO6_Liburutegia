using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3POO_6
{
    class Liburua
    {
        private string isbn, titulua;
        private int orriak;
        private Egilea liburuEgile;
        private bool alokauta;
        public string Isbn { get => isbn; set => isbn = value; }
        public string Titulua { get => titulua; set => titulua = value; }
        public int Orriak { get => orriak; set => orriak = value; }
        public bool Alokatua { get => alokauta; set => alokauta = value; }
        public Egilea LiburuEgile { get => liburuEgile; set => liburuEgile = value; }
      
        public Liburua(string isbna, string tit, Egilea egile, int orri, bool alok)
        {
            //Fitxategi irakurketan datu denak daude, beraz konstruktore honekin sortuko da liburua
            isbn = isbna.ToUpper();
            titulua = tit.ToUpper();
            liburuEgile = egile;
            orriak = orri;
            alokauta = alok;

        }
        public void OrriaEguneratu(int kop)
        {
            orriak = kop;
        }
        public void Alokatu()
        {
            alokauta=true;
        }
        public void Bueltatu()
        {
            alokauta = false;
        }
        public string ToString()
        {
            //Fitxategiko egitura berdinarekin bueltatuko duena objetuko datuekin osatutako stringa, aztertu bakoitzak fitxategia
            return "--";
        }
    }
}
