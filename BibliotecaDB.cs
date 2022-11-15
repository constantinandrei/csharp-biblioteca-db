using System.Data.SqlClient;



public class BibliotecaDB {
    private string connectionString = "Data Source=localhost;Initial Catalog=biblioteca-db;Integrated Security=True";
    private SqlConnection connection;
    public BibliotecaDB() {
        connection = new SqlConnection(connectionString);
        try
        {
            connection.Open();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        } 
    }

    public void CloseConnection()
    {
        connection.Close();
    }

    public void AggiungiLibro(Libro libro)
    {
        string query = "INSERT INTO Documenti (codice, titolo, anno, settore, disponibile, scaffale, autore, tipo, durata, pagine) " +
            "VALUES (@codice, @titolo, @anno, @settore, @disponibile, @scaffale, @autore, @tipo, null, @pagine)";
        SqlCommand cmd = new SqlCommand(query, connection);
        cmd.Parameters.Add(new SqlParameter("@codice", libro.Id));
        cmd.Parameters.Add(new SqlParameter("@titolo", libro.Titolo));
        cmd.Parameters.Add(new SqlParameter("@anno", libro.Anno));
        cmd.Parameters.Add(new SqlParameter("@settore", libro.Settore));
        cmd.Parameters.Add(new SqlParameter("@disponibile", libro.Disponibile));
        cmd.Parameters.Add(new SqlParameter("@scaffale", libro.Scaffale));
        cmd.Parameters.Add(new SqlParameter("@autore", libro.Autore));
        cmd.Parameters.Add(new SqlParameter("@tipo", 'l'));
        cmd.Parameters.Add(new SqlParameter("@pagine", libro.Pagine));
        cmd.ExecuteNonQuery();
    }
}


