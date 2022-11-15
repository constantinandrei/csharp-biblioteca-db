// See https://aka.ms/new-console-template for more information
public class Persona
{
    public string Cognome { get; }
    public string Nome { get; }
    public Persona(string cognome, string nome)
    {
        Cognome = cognome;
        Nome = nome;
    }
}