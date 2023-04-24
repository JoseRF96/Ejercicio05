using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Libro
{
    public string Autor { get; set; }

    public string Titulo { get; set; }


    public Libro(string autor, string titulo)
    {
        this.Autor = autor;
        this.Titulo = titulo;
    }

}
