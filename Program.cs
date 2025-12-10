using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3POO_6
{
    public class Program
   {
        static void Main()
        {                       
            while (true)
            {
                Liburutegia.Karga();
                Console.WriteLine("");
                Console.WriteLine("***** LIBURUTEGIA ***********");
                Console.WriteLine("1.- Liburuak ikusi");
                Console.WriteLine("2.- Liburua gehitu");                
                Console.WriteLine("3.- Orria eguneratu");
                Console.WriteLine("4.- Liburua alokatu");
                Console.WriteLine("5.- Liburua bueltatu");
                Console.WriteLine("6.- IRTEN");
                Console.Write("Ze ariketa nahi duzun egin? Sartu bere zenbakia: ");
                try
                {
                    int eragiketa = int.Parse(Console.ReadLine());
                    if ((eragiketa >= 1) && (eragiketa <= 6))
                    {
                        //fitxategitik zerrendak kartzeko metodoa
                        
                        switch (eragiketa)
                        {
                            case 1:
                                Liburutegia.ErakutsiLiburutegia();
                                break;
                            case 2:
                                Liburutegia.LiburuaGehitu();                              
                                break;
                            case 3:
                                Liburutegia.OrriakEguneratu();
                                break;
                            case 4:
                                Liburutegia.Alokatu();
                                break;
                            case 5:
                                Liburutegia.Desalokatu();
                                break;
                            case 6:
                                return; // hemen egin beharko luke zerrendak fitxategira? Aztertu non egin, irtetzean edo zerbait eguneratzean datutan
                            default:
                                Console.WriteLine(" *****ERAGIKETA EZ ONARTUA *****");
                                break;
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("Erantzun okerra");
                }
            }

        }
    }
}
