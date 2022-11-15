// See https://aka.ms/new-console-template for more information
Biblioteca biblioteca = new Biblioteca();

// inserisco dei libri e dvd

// inserisco dei utenti

biblioteca.utenti.Add(new Utente("Todirascu", "Andrei", "andrei@gmail.it", "34628839303"));
biblioteca.utenti.Add(new Utente("Bulleri", "Daniele", "andrei@gmail.it", "34628833833"));
biblioteca.utenti.Add(new Utente("Varramista", "Giulia", "giulia@gmail.it", "382903489303"));


// inserisco dei prestiti


//biblioteca.AggiungiListaAlDatabase();

BibliotecaDB test = new BibliotecaDB();

Documento documento1 = test.CercaDocumento("183");
Documento documento2 = test.CercaDocumento("393");
Documento documento3 = test.CercaDocumento("726");

documento1.StampaDocumento();
documento2.StampaDocumento();
documento3.StampaDocumento();
