using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareasProgramacionAplicada.Tarea1
{
    class ParImpar
    {
        public ParImpar() { }


        public void verificar()
        {

            string valor;
            int num;

            Console.WriteLine("Digite un numero");
            valor = Console.ReadLine();
            num = Convert.ToInt32(valor);

            if (num % 2 == 0)
                Console.WriteLine("{0} Es Par", num);
            else
                Console.WriteLine("{0} Es Impar", num);

            
        }
    }
}
