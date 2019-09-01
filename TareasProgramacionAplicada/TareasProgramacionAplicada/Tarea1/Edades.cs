using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareasProgramacionAplicada.Tarea1
{
    class Edades
    {
        public Edades() { }

       public void calcular()
        {
            string valor;
            int cant, edad,prom=0, may = 0, menor = 1000, sum=0; //sum para ir sumando las edades

            Console.WriteLine("Digite la cantidad de personas");
            valor = Console.ReadLine();
            cant = Convert.ToInt32(valor);

            for(int i=1; i<=cant; i++)
            {
                Console.WriteLine("Digite la edad {0}", i);
                valor = Console.ReadLine();
                edad = Convert.ToInt32(valor);

                sum += edad;
                if (edad > may)
                    may = edad;
                
                if (edad < menor)
                    menor = edad;
            }

            prom = sum / cant;

            Console.WriteLine("El promedio de edad es: {0}", prom);
            Console.WriteLine("La edad mas grande es: {0}", may);
            Console.WriteLine("La edad mas joven es: {0}", menor);
        }
    }
}
