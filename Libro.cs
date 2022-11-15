// See https://aka.ms/new-console-template for more information
public class Libro : Documento
{
    public Libro(string id, string titolo, string settore, int anno, string scafalle, Persona autore, int pagine) : base(id, titolo, settore, anno, scafalle, autore)
    {
        Pagine = pagine;
    }

    public int Pagine { get; set; }
}