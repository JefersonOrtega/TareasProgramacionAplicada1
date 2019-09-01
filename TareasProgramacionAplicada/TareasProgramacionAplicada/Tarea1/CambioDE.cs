using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareasProgramacionAplicada.Tarea1
{
    class CambioDE
    {
        public CambioDE() { }

        public void Transformar()
        {
            string valor;
            float tasa, dolar, euro;
            int op;

            Console.WriteLine("Digite el tipo de cambio 1-Dolar a Euro, 2-Euro a Dolar");
            valor = Console.ReadLine();
            op = Convert.ToInt32(valor);

            if (op == 1)
            {
                Console.WriteLine("Digite la tasa de dolar a Euro");
                valor = Console.ReadLine();
                tasa = Convert.ToInt32(valor);

                Console.WriteLine("Digite la cantidad de dolar a convertir");
                valor = Console.ReadLine();
                dolar = Convert.ToInt32(valor);

                euro = dolar * tasa;

                Console.WriteLine("{0} dolar equivale a {1} euro", dolar, euro);

            }
            else
            {
                if (op == 2)
                {
                    Console.WriteLine("Digite la tasa de Euro a Dolar");
                    valor = Console.ReadLine();
                    tasa = Convert.ToInt32(valor);

                    Console.WriteLine("Digite la cantidad de euro a convertir");
                    valor = Console.ReadLine();
                    euro = Convert.ToInt32(valor);

                    dolar = euro * tasa;

                    Console.WriteLine("{0} euro equivale a {1} dolar",euro,dolar);
                }
            }

        }
    }
}
