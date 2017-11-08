using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca1
{
    class Program
    {
        static byte a;
        static void Main(string[] args)
        {
            
            string c = "";
            string nom = "";
            string edit = "";
            string aut = "";
            Console.WriteLine("ingrese el nombre de la primer biblioteca");
            c = Console.ReadLine();
            Biblioteca b1 = new Biblioteca(c);
            Console.WriteLine("ingrese el nombre de la segunda biblioteca");
            c = Console.ReadLine();
            Biblioteca b2 = new Biblioteca(c);
            Console.WriteLine("ingrese el nombre de la tercera biblioteca");
            c = Console.ReadLine();
            Biblioteca b3 = new Biblioteca(c);

            do
            {
                Menu();
                switch (a)
                {
                    case 1:
                        Console.WriteLine(" en cual biblioteca quiere agregar");
                        c = Console.ReadLine();
                        if (c == b1.Nombre)
                        {
                            Console.WriteLine("ingrese el nombre del libro");
                            nom = Console.ReadLine();
                            Console.WriteLine("ingrese la editorial");
                            edit = Console.ReadLine();
                            Console.WriteLine("ingrese el autor");
                            aut = Console.ReadLine();

                            b1.Agregar(nom, edit, aut);
                        }
                        if (c == b2.Nombre)
                        {
                            Console.WriteLine("ingrese el nombre del libro");
                            nom = Console.ReadLine();
                            Console.WriteLine("ingrese la editorial");
                            edit = Console.ReadLine();
                            Console.WriteLine("ingrese el autor");
                            aut = Console.ReadLine();

                            b2.Agregar(nom, edit, aut);
                        }
                        if (c == b3.Nombre)
                        {
                            Console.WriteLine("ingrese el nombre del libro");
                            nom = Console.ReadLine();
                            Console.WriteLine("ingrese la editorial");
                            edit = Console.ReadLine();
                            Console.WriteLine("ingrese el autor");
                            aut = Console.ReadLine();

                            b3.Agregar(nom, edit, aut);
                        }
                        break;
                    case 2:
                        Console.WriteLine("cual biblioteca quiere consultar");
                        c = Console.ReadLine();
                        if (c == b1.Nombre)
                        {
                            Console.WriteLine("ingrese el nombre del libro");
                            nom = Console.ReadLine();
                            b1.Consultar(nom);
                        }
                        if (c == b2.Nombre)
                        {
                            Console.WriteLine("ingrese el nombre del libro");
                            nom = Console.ReadLine();
                            b2.Consultar(nom);
                        }
                        if (c == b3.Nombre)
                        {
                            Console.WriteLine("ingrese el nombre del libro");
                            nom = Console.ReadLine();
                            b2.Consultar(nom);
                        }
                        break;
                   

                }

            }
            while (a != 0);

        }

        static void Menu()
        {

            Console.WriteLine("elija una opcion");
            Console.WriteLine(" 1-agregar \n 2-consultar");
            a = byte.Parse(Console.ReadLine());

        }
    }
}