using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaAlimentos
{
    public class Program
    {
        static void Main(string[] args)
        {
            string Nombre, Producto;
            int Precio, Total, Moneda, Cambio, TotalCambio;
            Console.WriteLine("INGRESA TU NOMBRE");
            Nombre = Console.ReadLine();
            Console.WriteLine("SELECCIONA UN PRODUCTO " +
                "\nA.PRODUCTO A TIENE UN PRECIO DE $270" +
                "\nB.PRODUCTO B TIENE UN PRECIO DE $340  " +
                "\nC.PRODUCTO C TIENE UN PRECIO DE $390");
            Producto = Console.ReadLine();

            if (Producto == "A" || Producto == "B" || Producto == "C" )
            {
                if (Producto == "A" )
                {
                    Precio = 270;
                }
                else
                {
                    if (Producto == "B" )
                    {
                        Precio = 340;
                    }
                    else 
                    {
                        Precio = 390 ;
                    }
                }
                Total = 0;
                while (Total < Precio)
                {
                    Console.WriteLine("SELECCIONA UNA MONEDA " +
                        "\n1.Moneda de $10" +
                        "\n2.Moneda de $50 " +
                        "\n3.Moneda de $100");
                    Moneda = int.Parse(Console.ReadLine());
                    if (Moneda  == 1 || Moneda == 2 || Moneda == 3)
                    {
                        if (Moneda == 1)
                        {
                            Total = Total + 10;
                        }
                        else
                        {
                            if (Moneda == 2)
                            {
                                Total = Total + 50;
                            }
                            else
                            {
                                Total = Total + 100;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("INTRODUCE OTRA MONEDA, SOLO SE ACEPTAN MONEDAS DE $10 $50 O $100");
                    }
                }
                Console.WriteLine("NOMBRE CLIENTE "+Nombre);
                Console.WriteLine("PRECIO DE PRODUCTO "+Producto+" $" + Precio);
                Console.WriteLine("MONTO INGRESADO $" + Total);
                TotalCambio = 0;
                if (Total == Precio)
                {
                    Console.WriteLine("MONTO CORRECTO");
                }
                else
                {
                    Cambio = Total - Precio;
                    while (Cambio > 0)
                    {
                        if (Cambio >= 50 )
                        {
                            Console.WriteLine("CAMBIO $50");
                            Cambio = Cambio- 50;
                            TotalCambio = TotalCambio + 50;
                        }
                        if (Cambio <= 50)
                        {
                            Console.WriteLine("CAMBIO $10");
                            Cambio = Cambio - 10;
                            TotalCambio = TotalCambio + 10;
                        }
                    }
                }
                Console.WriteLine("TOTAL CAMBIO $" + TotalCambio);
            }
            else
            {
                Console.WriteLine("INGRESA UN PRODUCTO EXISTENTE ");
            }
            Console.WriteLine("SU COMPRA A FINALIZADO ");
            Console.ReadKey();
        }
    }
}
