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

    public void AggiungiDocumento(Documento documento)
    {
        string query = "INSERT INTO Documenti (codice, titolo, anno, settore, disponibile, scaffale, autore, tipo, durata, pagine) " +
            "VALUES (@codice, @titolo, @anno, @settore, @disponibile, @scaffale, @autore, @tipo, @durata, @pagine)";
        SqlCommand cmd = new SqlCommand(query, connection);
        cmd.Parameters.Add(new SqlParameter("@codice", documento.Id));
        cmd.Parameters.Add(new SqlParameter("@titolo", documento.Titolo));
        cmd.Parameters.Add(new SqlParameter("@anno", documento.Anno));
        cmd.Parameters.Add(new SqlParameter("@settore", documento.Settore));
        cmd.Parameters.Add(new SqlParameter("@disponibile", documento.Disponibile));
        cmd.Parameters.Add(new SqlParameter("@scaffale", documento.Scaffale));
        cmd.Parameters.Add(new SqlParameter("@autore", documento.Autore));
        
        if (documento is Libro)
        {
            Libro libro = (Libro)documento;
            cmd.Parameters.Add(new SqlParameter("@tipo", 'l'));
            cmd.Parameters.Add(new SqlParameter("@durata", DBNull.Value));
            cmd.Parameters.Add(new SqlParameter("pagine", libro.Pagine));
        }

        if (documento is Dvd)
        {
            Dvd dvd = (Dvd)documento;
            cmd.Parameters.Add(new SqlParameter("@tipo", 'd'));
            cmd.Parameters.Add(new SqlParameter("@durata", dvd.Durata));
            cmd.Parameters.Add(new SqlParameter("pagine", DBNull.Value));
        }

        cmd.ExecuteNonQuery();
    }
        
    public Documento CercaDocumento(string cod)
    {
        Documento documento = null;
        string query = "SELECT * FROM DOCUMENTI WHERE codice = @codice";
        SqlCommand cmd = new SqlCommand(query, connection);
        cmd.Parameters.Add(new SqlParameter("@codice", cod));
        SqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            string codice = reader.GetString(1);
            string titolo = reader.GetString(2);
            string anno = reader.GetString(3);
            string settore = reader.GetString(4);
            bool disponibile = reader.GetBoolean(5);
            string scaffale = reader.GetString(6);
            string autore = reader.GetString(7);
            string tipo = reader.GetString(8);
            int jollyParam = 0;
            if (tipo.Equals("l"))
            {
                jollyParam = reader.GetInt32(10);
                Libro libro = new Libro(codice, titolo, settore, Convert.ToInt32(anno), scaffale, autore, jollyParam);
                documento = libro;
            }
                
            if (tipo.Equals("d"))
            {
                jollyParam = reader.GetInt32(9);
                Dvd dvd = new Dvd(codice, titolo, settore, Convert.ToInt32(anno), scaffale, autore, jollyParam);
                documento = dvd;
            }
                

        }

        return documento;
    }
}


