using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TareasProgramacionAplicada.Tarea1;



namespace TareasProgramacionAplicada
{
    class Program
    {
        static void Main(string[] args)
        {
            int op1,op2;
            string opcion;
                
            Console.WriteLine("\t\tMenu de Tareas\n");

            //todo: aqui van las opciones a seleccionar;
            Console.WriteLine("1.Tarea 1");
            Console.WriteLine("2.Salir");
            opcion = Console.ReadLine();
            op1 = Convert.ToInt32(opcion);


            switch(op1)
            {
                case 1:
                    {
                        Console.Clear();
                        Console.WriteLine("1. Imprimir Nombre y Otros mensajes");
                        Console.WriteLine("2. Calcular perimetro de un poligono regular");
                        Console.WriteLine("3. Transformar de grados a radianes");
                        Console.WriteLine("4. Transformar de Centigrados a Fahrenheit");
                        Console.WriteLine("5. Tranformar entre dolar y euro");
                        Console.WriteLine("6. Decir si un numero es par o impar");
                        Console.WriteLine("7. Dia de Semana");
                        Console.WriteLine("8. Area y Perimetro de un Poligono Regular");
                        Console.WriteLine("9. Tabla del 1 al 10 de cualquier numero");
                        Console.WriteLine("10. Elevar Numero");
                        Console.WriteLine("11. Promedio de edades, mayor y menor");

                        // Console.WriteLine("2. ")

                        opcion = Console.ReadLine();
                        op2 = Convert.ToInt32(opcion);

                        switch(op2)
                        {
                            case 1:
                                {
                                    Console.Clear();
                                    ImprimeNombre nombre = new ImprimeNombre();
                                    nombre.imprime();
                                    nombre.otrosMensajes();
                                    Console.ReadKey();
                                    break;
                                }

                            case 2:
                                {
                                    Console.Clear();
                                    PPoligonoRegular poligono = new PPoligonoRegular();
                                    poligono.perimetro();

                                    break;
                                }

                            case 3:
                                {
                                    Console.Clear();
                                    Transformacion transformar = new Transformacion();
                                    transformar.gradoRadian();

                                    break;
                                }

                            case 4:
                                {
                                    Console.Clear();
                                    TransformarCF transformar = new TransformarCF();
                                    transformar.centiFahr();

                                    break;
                                }

                            case 5:
                                {
                                    Console.Clear();
                                    CambioDE cambio = new CambioDE();
                                    cambio.Transformar();

                                    break;
                                }

                            case 6:
                                {
                                    Console.Clear();
                                    ParImpar pi = new ParImpar();
                                    pi.verificar();

                                    break;
                                }

                            case 7:
                                {
                                    Console.Clear();
                                    DiaSemana dia = new DiaSemana();
                                    dia.comprobar();

                                    break;
                                }

                            case 8:
                                {
                                    Console.Clear();
                                    APPoligono poligono = new APPoligono();
                                    poligono.calcular();

                                    break;
                                }

                            case 9:
                                {
                                    Console.Clear();
                                    Tabla tb = new Tabla();
                                    tb.calcular();

                                    break;
                                }

                            case 10:
                                {
                                    Console.Clear();
                                    Potencia pt = new Potencia();
                                    pt.calcular();

                                    break;
                                }

                            case 11:
                                {
                                    Console.Clear();
                                    Edades ed = new Edades();
                                    ed.calcular();


                                    break;
                                }
                                

                        }

                        break;
                    }

                case 2:
                    {

                        break;
                    }

            }



           
            Console.ReadKey();
        }
    }
}
