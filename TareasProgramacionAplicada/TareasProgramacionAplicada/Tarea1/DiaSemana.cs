using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareasProgramacionAplicada.Tarea1
{
    class DiaSemana
    {
        public DiaSemana() { }

        public void comprobar()
        {
            string valor;
            int dia;

            Console.WriteLine("Digite un numero del 1 al 7");
            valor = Console.ReadLine();
            dia = Convert.ToInt32(valor);

            if (dia == 1)
            {
                Console.WriteLine("Lunes");
            }
            else
            {
                if (dia == 2)
                {
                    Console.WriteLine("Martes");
                }
                else
                {
                    if (dia == 3)
                    {
                        Console.WriteLine("Miercoles");
                    }
                    else
                    {
                        if (dia == 4)
                        {
                            Console.WriteLine("Jueves");
                        }
                        else
                        {
                            if (dia == 5)
                            {
                                Console.WriteLine("Viernes");
                            }
                            else
                            {
                                if (dia == 6)
                                {
                                    Console.WriteLine("Sabado");
                                }
                                else
                                {
                                    if (dia == 7)
                                    {
                                        Console.WriteLine("Domingo");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Opcion no valida");
                                    }
                                }
                            }
                        }
                    }

                }
            }
        }
    }
}
