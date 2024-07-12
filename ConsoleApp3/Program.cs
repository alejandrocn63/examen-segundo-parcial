using System;

public class MaterialBibliografico
{
    public string Titulo { get; set; }
    public string Autor { get; set; }

    public MaterialBibliografico(string titulo, string autor)
    {
        Titulo = titulo;
        Autor = autor;
    }

    public virtual void MostrarInformacion()
    {
        Console.WriteLine("Título: " + Titulo + ", Autor: " + Autor)
    }
}


public class Libro : MaterialBibliografico
{
    public int NumeroDePaginas { get; set; }

    public Libro(string titulo, string autor, int numeroDePaginas)
        : base(titulo, autor)
    {
        NumeroDePaginas = numeroDePaginas
    }

    public override void MostrarInformacion()
    {
        Console.WriteLine("Título: " + Titulo + ", Autor: " + Autor + ", Número de Páginas: " + NumeroDePaginas)
    }
}


public class Revista : MaterialBibliografico
{
    public int NumeroDeEdicion { get; set; }

    public Revista(string titulo, string autor, int numeroDeEdicion)
        : base(titulo, autor)
    {
        NumeroDeEdicion = numeroDeEdicion;
    }

    public override void MostrarInformacion()
    {
        Console.WriteLine("Título: " + Titulo + ", Autor: " + Autor + ", Número de Edición: " + NumeroDeEdicion)
    }
}


public class Biblioteca
{
    private List<MaterialBibliografico> materiales;

    public Biblioteca()
    {
        materiales = new List<MaterialBibliografico>()
    }

    public void AgregarMaterial(MaterialBibliografico material)
    {
        materiales.Add(material);
    }

    public void MostrarMateriales()
    {
        foreach (var material in materiales)
        {
            material.MostrarInformacion();
        }
    }
}


class Program
{
    static void Main()
    {
        Biblioteca biblioteca = new Biblioteca();

        Libro libro = new Libro("chupa el perro", "brooo", 697056);
        Revista revista = new Revista("no se xD", "yo porque no", 125);

        biblioteca.AgregarMaterial(libro);
        biblioteca.AgregarMaterial(revista);

        biblioteca.MostrarMateriales()
    }
}
