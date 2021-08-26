using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Aplicacion2
{
    class Program
    {
        static void Main(string[] args)
        {
            char op = 's';
            string archivo;
            int OP;

            while (op == 's')
            {
                Console.WriteLine("Que desea hacer: \n1. Crear Archivo \n1. Escribir Archivo \n2. Salir");
                OP = int.Parse(Console.ReadLine());
                
                Console.Clear();

                
                if (OP == 1)
                {
                    StreamWriter ar;
                    
                    archivo = Console.ReadLine();
                    Console.WriteLine("Que nombre le gustaría poner: ");
                    ar = File.CreateText(Console.ReadLine() + ".txt");


                    ar.Close();
                }

                Console.ReadKey();
                if (OP == 2)
                {
                    Console.WriteLine("Usted a deseado Salir");

                }
                Console.Clear();
                Console.WriteLine("Desea Continuar ['s/n']");
                op = char.Parse(Console.ReadLine());

            }
        }
        static void EscribirArchivo(string ruta, string dato)
        {
            StreamWriter ar;
            ar = File.AppendText(ruta);
            ar.WriteLine(dato);
            ar.Close();
        }
        
    }
}
