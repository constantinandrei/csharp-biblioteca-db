// See https://aka.ms/new-console-template for more information

public class Biblioteca
{
    public List<Documento> documenti = new List<Documento>();
    public List<Utente> utenti = new List<Utente>();
    public List<Prestito> prestiti = new List<Prestito>();

    public Documento TrovaDocumento(string id)
    {
        foreach (Documento documento in documenti)
        {
            if (documento.Id.Equals(id))
            {
                return documento;
            }
        }

        return null;
    }

    public Utente TrovaUtente(string cognome, string nome)
    {
        foreach (Utente utente in utenti)
        {
            if (utente.Cognome.Equals(cognome) && utente.Nome.Equals(nome))
            {
                return utente;
            }
        }

        return null;
    }

    public Persona ChiediDatiUtente()
    {


        Console.WriteLine("Inserisci il cognome dell'utente");
        string cognome = Console.ReadLine();
        Console.WriteLine("Inserisci il nome dell'utente");
        string nome = Console.ReadLine();

        return new Persona(cognome, nome);
    }

    public Utente UtenteRegistrato()
    {
        Persona daCercare = ChiediDatiUtente();

        Utente utente = TrovaUtente(daCercare.Cognome, daCercare.Nome);
        if (utente != null)
        {
            Console.WriteLine($"{utente.Cognome} {utente.Nome} è registrato");
            Console.WriteLine("I suoi dati sono: ");
            Console.WriteLine($"telefono : {utente.Telefono}");
            Console.WriteLine($"email    : {utente.Email}");
            return utente;
        }
        else
        {
            Console.WriteLine("L'utente NON è registrato");
            return null;
        }
    }

    public void InserisciPrestito()
    {
        Utente utente = UtenteRegistrato();
        if (utente != null)
        {
            Console.WriteLine("Inserire il codice del documento");
            Documento documento = TrovaDocumento(Console.ReadLine());
            if (documento != null)
            {
                if (!documento.Disponibile)
                {
                    Console.WriteLine($"Il libro attualmente è preso in prestito");
                    return;
                }
                Console.WriteLine("Inserire la data d'inizio del prestito");
                string dataInizio = Console.ReadLine();
                Console.WriteLine("Inserire la data d'inizio del prestito");
                string dataFine = Console.ReadLine();

                prestiti.Add(new Prestito(utente, documento, dataInizio, dataFine));
                documento.Disponibile = false;
                Console.WriteLine($"Il prestito è stato inserito corettamene");
                return;
            }
            Console.WriteLine("Documento non trovato");
        }
    }

    public List<Prestito> RicercaPrestito()
    {
        Persona utente = ChiediDatiUtente();
        List<Prestito> ret = new List<Prestito>();

        foreach (Prestito prestito in prestiti)
        {
            if (prestito.Utente.Cognome.Equals(utente.Cognome) && prestito.Utente.Nome.Equals(utente.Nome))
            {
                ret.Add(prestito);
            }
        }

        StampaPrestiti(ret);

        return ret;
    }

    public void StampaPrestiti(List<Prestito> prestiti)
    {
        foreach (Prestito prestito in prestiti)
        {
            Console.WriteLine("------------------");
            Console.WriteLine($"Titolo: {prestito.Documento.Titolo}");
        }
    }

    public void AggiungiListaAlDatabase()
    {
        BibliotecaDB bibli = new BibliotecaDB();
        foreach (Documento documento in documenti)
        {
            bibli.AggiungiDocumento(documento);
        }
    }
}