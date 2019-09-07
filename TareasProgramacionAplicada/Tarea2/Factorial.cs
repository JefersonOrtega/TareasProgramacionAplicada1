using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareasProgramacionAplicada.Tarea2
{
    class Factorial
    {
        public Factorial() { }

        public void obtener()
        {
            string valor;
            int numero, factorial;
            Console.WriteLine("Digite un numero");

            valor = Console.ReadLine();
            numero = Convert.ToInt32(valor);
            factorial = numero;
            for(int i=numero-1; i>1; i--)
            {
                factorial = factorial * i;
            }
            Console.WriteLine("EL factorial de {0} es {1}", numero, factorial);
           
        }
    }
}
