// See https://aka.ms/new-console-template for more information
public class Utente : Persona
{
    public Utente(string cognome, string nome, string email, string telefono) : base(cognome, nome)
    {
        Email = email;
        Telefono = telefono;
    }

    public string Email { get; }
    public string Telefono { get; }

}