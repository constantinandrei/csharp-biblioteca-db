// See https://aka.ms/new-console-template for more information
public class Libro : Documento
{
    public Libro(string id, string titolo, string settore, int anno, string scafalle, string autore, int pagine) : base(id, titolo, settore, anno, scafalle, autore)
    {
        Pagine = pagine;
    }
    public override void StampaDocumento()
    {
        StampaDati(this);
        Console.Write("Pagine: ");
        Console.WriteLine(this.Pagine);
        Console.WriteLine();
    }

    public int Pagine { get; set; }
}