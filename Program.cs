// See https://aka.ms/new-console-template for more information

LinqQueries queries = new LinqQueries();

//imprimirValor(queries.librosMas250Paginas());
imprimirValor(queries.librosRecientesOrdenadosFecha());


void imprimirValor(IEnumerable<Book> listaDeLibros)
{

    Console.WriteLine("----------------------------------------------------------------------");
    Console.WriteLine("{0,-60} {1,7} {2,11}", "Titulo", "|  N. Pagina  |  ", "Fecha Publicacion");
    Console.WriteLine("----------------------------------------------------------------------");

    foreach (var item in listaDeLibros)
    {
        Console.WriteLine("{0,-60} {1,7} {2,11}", item.Title, item.PageCount, item.PublishedDate.ToShortDateString());

    }
}
