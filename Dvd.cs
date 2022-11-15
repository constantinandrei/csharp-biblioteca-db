// See https://aka.ms/new-console-template for more information
public class Dvd : Documento
{


    public Dvd(string id, string titolo, string settore, int anno, string scafalle, string autore, int durata) : base(id, titolo, settore, anno, scafalle, autore)
    {
        Durata = durata;
    }
    public override void StampaDocumento()
    {
        StampaDati(this);
        Console.Write("Lunghezza: ");
        Console.WriteLine(this.Durata + " min");
        Console.WriteLine();
    }
    public int Durata { get; set; }
}