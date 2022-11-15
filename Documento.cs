// See https://aka.ms/new-console-template for more information
public class Documento
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

    public static void StampaDocumento(Documento documento)
    {
        Console.WriteLine(documento.Autore);
    }

}