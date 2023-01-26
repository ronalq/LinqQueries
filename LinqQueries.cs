public class LinqQueries
{

    private List<Book> libroCollections = new List<Book>();

    public LinqQueries()
    {
        using (StreamReader reader = new StreamReader("books.json"))
        {

            string json = reader.ReadToEnd();

            this.libroCollections = System.Text.Json.JsonSerializer.Deserialize<List<Book>>(json, new System.Text.Json.JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

        };
    }

    public IEnumerable<Book> todaLaColeccion()
    {

        return libroCollections;

    }

    public IEnumerable<Book> librosDespues200()
    {

        //extension metodos
        //return libroCollections.Where(x =>x.PublishedDate.Year > 2000);

        //query expresions
        var query = from l in libroCollections
                    where l.PublishedDate.Year > 2000
                    select l;

        return query;
    }

    public IEnumerable<Book> librosMas250Paginas()
    {

        return libroCollections.Where(x => x.PageCount > 250 && x.Title.Contains("in Action"));
    }

    public IEnumerable<Book> librosRecientesOrdenadosFecha()
    {

        var query = libroCollections.Where(x => x.Categories.Contains("Java")).OrderByDescending(x => x.PublishedDate).Take(3);

        return query;
    }

}