using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05
{
    class Program
    {

        public static void Main(string[] args)
        {
            string tituloLibro = "", autorLibro = "";
            Libro[] biblioteca = new Libro[1000];
            biblioteca[0] = new Libro("George Orwell", "1984");
            biblioteca[1] = new Libro("Gabriel Gárcia Márquez", "Cien años de soledad");
            biblioteca[2] = new Libro("J.K. Rowling", "Harry Potter");

            int opcion = -1;

            while(opcion != 0)
            {
                try
                {
                    Console.WriteLine("Indique que desea hacer.");
                    Console.WriteLine("1 - Agregar un libro.");
                    Console.WriteLine("2 - Mostrar todos los libros.");
                    Console.WriteLine("3 - Buscar un libro por su título.");
                    Console.WriteLine("4 - Eliminar un libro.");
                    Console.WriteLine("0 - Salir");
                    opcion = int.Parse(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            AgregarLibro(tituloLibro, autorLibro);
                            break;
                        case 2:
                            MostrarTodos(biblioteca);
                            break;
                        case 3:
                            Libro libro = BuscarLibro(tituloLibro, biblioteca);
                            if (libro != null)
                            {

                                Console.WriteLine($"Autor: {libro.Autor} | Título: {libro.Titulo}");
                            }
                            else
                            {
                                Console.WriteLine("No hay libros con ese título");
                            }
                            break;
                        case 4:
                            EliminarLibro(tituloLibro, biblioteca);
                            break;
                        default:
                            Console.WriteLine("Saliendo...");
                            break;

                    }
                }
                catch
                {
                    Console.WriteLine("Introduzca una opción valida.");
                }
            }



            void AgregarLibro(string titulo, string autor)
            {
                Console.WriteLine("Indique el autor del libro");
                autor = Console.ReadLine();
                Console.WriteLine("Indique el título del libro");
                titulo = Console.ReadLine();
                biblioteca[4] = new Libro(autor, titulo);
            }

            void MostrarTodos(Libro[] libros)
            {
                foreach (var libro in libros)
                {
                    if(libro != null)
                    {
                        Console.WriteLine($"Autor: {libro.Autor} | Título: {libro.Titulo}");
                    }

                }
            }

            Libro BuscarLibro(string titulo, Libro[] libros)
            {
                Console.WriteLine("Introduzca un título:");
                titulo = Console.ReadLine();
                libros = libros.Where(libro => libro != null).ToArray();
                foreach (var libro in libros)
                {
                    if(libro.Titulo == titulo)
                    {
                        return libro;
                    }
                }

                return null;
            }

            void EliminarLibro(string titulo, Libro[] libros)
            {
                Libro libroAEliminar = BuscarLibro(titulo, libros);
                List<Libro> nuevaBiblioteca = new List<Libro>(libros);
                if (libroAEliminar != null)
                {
                    nuevaBiblioteca.Remove(libroAEliminar);

                    Console.WriteLine("El libro ha sido eliminado con éxito.");
                }
                else
                {
                    Console.WriteLine("No hay ningun libro con este título.");
                }
                for(int i = 0; i<nuevaBiblioteca.Count; i++)
                {
                    libros[i] = nuevaBiblioteca[i];
                }
                //libros = nuevaBiblioteca.ToArray();
                //foreach(var libro in libros)
                //{
                //    if(libro != null)
                //    {
                //        Console.WriteLine(libro.Titulo);
                //    }
                //}
            }
        }
    }
}
