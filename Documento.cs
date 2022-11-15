// See https://aka.ms/new-console-template for more information
public class Documento
{
    public Documento(string id, string titolo, string settore, int anno, string scafalle, Persona autore)
    {
        Id = id;
        Titolo = titolo;
        Settore = settore;
        Anno = anno;
        Scaffale = scafalle;
        Autore = autore;
        Disponibile = true;
    }

    public string Id { get; }
    public string Titolo { get; set; }
    public string Settore { get; set; }
    public int Anno { get; set; }
    public bool Disponibile { get; set; }
    public string Scaffale { get; set; }
    public Persona Autore { get; set; }

}