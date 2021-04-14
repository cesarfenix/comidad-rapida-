using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciofinal
{
    class Program
    {
        static void Main(string[] args)
        {
            /*desarrollar un ejercicio con las siguientes condiciones
                Variables mínimo 5
                Condiciones simples y compuestas 
                Operadores lógicos
                Condiciones repetitivas for y while dónde 
                coloquemos en práctica los conocimientos adquiridos en el 
                trimestre resumidos en  una aplicación*/

           /*Este ejercicio consiste en un negocio de comidad rapida en la cual
            * se tienen precios fijos que se describen mas abajo, si se paga 
            * con tarjeta se obtiene un descuento del 5% , ademas si la compra 
            * es mayor a 50000 participa en un sorteo*/

            /*gaseosa = 2000,
             * pizza = 6000
             * papas = 3000
             * hamburgueza = 7000
             * limonada = 5000
             * credito 5% dto*/


            int x, precio, pago, gaseosas, pizza, papas, hamburguesa, limonada;
            String Linea;
            double dto1, pfinal;
            Byte sorteo;


            x = 1;
            precio = 0;
            pfinal = 0;




            Console.WriteLine("Hamburguesas super Ricas ");
            Console.WriteLine();



            Console.WriteLine("Escriba la cantidad deseada al frente de cada uno si no escriba o ");
            Console.WriteLine();

            Console.Write("gaseosas : ");
            Linea = Console.ReadLine();
            gaseosas = int.Parse(Linea);


            Console.Write("pizza : ");
            Linea = Console.ReadLine();
            pizza = int.Parse(Linea);

            Console.Write("papas : ");
            Linea = Console.ReadLine();
            papas = int.Parse(Linea);

            Console.Write("hamburguesa : ");
            Linea = Console.ReadLine();
            hamburguesa = int.Parse(Linea);

            Console.Write("papas : ");
            Linea = Console.ReadLine();
            papas = int.Parse(Linea);

            Console.Write("limonada : ");
            Linea = Console.ReadLine();
            limonada = int.Parse(Linea);




            gaseosas = gaseosas * 2000;
            pizza = pizza * 6000;
            papas = papas * 3000;
            hamburguesa = hamburguesa * 7000;
            limonada = limonada * 5000;
            precio = gaseosas + pizza + papas + hamburguesa + limonada;
            dto1 = Convert.ToDouble(precio * 0.05);
            pfinal = precio - dto1;


            Console.WriteLine("El valor a cancelar es : " + precio);


            Console.Write("Si el pago es en efectivo marque 1 si no marque 2 : ");
            Linea = Console.ReadLine();
            pago = int.Parse(Linea);

            if (pago <= 0 || pago > 2)
            {
                Console.Write("numero errado ingrese otro");
                Console.ReadLine();
            }
            if (precio < 50000)
            {
                Console.WriteLine("El valor a cancelar es : " + precio);
                Console.ReadLine();
            }
            else
            if (pfinal > 50000)
                {

                    Console.WriteLine("escoja un numero de la lista para el sorteo ");
                    while (x <= 5)
                    {

                        Console.WriteLine(x);
                        x = x + 1;
                    }
                    {
                        Console.WriteLine("escriba el numero : ");
                        Linea = Console.ReadLine();
                        sorteo = Byte.Parse(Linea);
                    }
                    if
                        (sorteo <= 2 || sorteo >= 4)
                    {
                        Console.WriteLine("Reclama una hamburguesa gratis ");
                        Console.ReadLine();
                    }
                    else
                    if (sorteo == 3)
                    {
                        Console.WriteLine("Gracias por su compra");
                        Console.ReadLine();

                    }
                if (pago == 1)
                {
                    Console.Write("El valor a cancelar es : " + precio);
                    Console.ReadLine();
                }
                else

            if (pago == 2)
                {
                    Console.Write("El valor a cancelar es " + pfinal + " Usted ahorro : " + dto1);
                    Console.ReadLine();
                }
                                   
                    Console.ReadKey();
                }
            }
        }

    }
