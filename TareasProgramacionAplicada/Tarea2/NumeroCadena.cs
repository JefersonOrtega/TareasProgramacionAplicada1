using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareasProgramacionAplicada.Tarea2
{
    class NumeroCadena
    {
        public NumeroCadena() { }

        public void transformar()
        {
            string valor;
            

            Console.WriteLine("Digite un numero");
            valor = Console.ReadLine();

            if(valor == "1")
            {
                Console.WriteLine("Uno");
            }
            else
            {
                if (valor == "2")
                    Console.WriteLine("Dos");
                else
                    if (valor == "3")
                    Console.WriteLine("Tres");
                else
                        if (valor == "4")
                    Console.WriteLine("Cuatro");
                else
                            if (valor == "5")
                    Console.WriteLine("Cinco");
                else
                                if (valor == "6")
                    Console.WriteLine("Seis");
                else
                                    if (valor == "7")
                    Console.WriteLine("Siete");
                else
                                    if (valor == "8")
                    Console.WriteLine("Ocho");
                else
                                        if (valor == "9")
                    Console.WriteLine("Nueve");
                else
                    Console.WriteLine("No ha escrito un numero del 1 al 9");





            }

        }
    }
}
