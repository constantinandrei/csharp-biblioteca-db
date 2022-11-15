// See https://aka.ms/new-console-template for more information
public abstract class Documento
{
    public Documento(string id, string titolo, string settore, int anno, string scaffale, string autore)
    {
        Id = id;
        Titolo = titolo;
        Settore = settore;
        Anno = anno;
        Scaffale = scaffale;
        Autore = autore;
        Disponibile = true;
    }

    public string Id { get; set; }
    public string Titolo { get; set; }
    public string Settore { get; set; }
    public int Anno { get; set; }
    public bool Disponibile { get; set; }
    public string Scaffale { get; set; }
    public string Autore { get; set; }
    public abstract void StampaDocumento();

    public static void StampaDati(Documento documento)
    {
        Console.WriteLine();
        Console.Write("Codice: ");
        Console.WriteLine(documento.Id);
        Console.Write("Titolo: ");
        Console.WriteLine(documento.Titolo);
        Console.Write("Settore: ");
        Console.WriteLine(documento.Settore);
        Console.Write("Anno: ");
        Console.WriteLine(documento.Anno);
        Console.Write("Scaffale: ");
        Console.WriteLine(documento.Scaffale);
        Console.Write("Autore: ");
        Console.WriteLine(documento.Autore);
    }

}