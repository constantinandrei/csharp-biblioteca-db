// See https://aka.ms/new-console-template for more information
Biblioteca biblioteca = new Biblioteca();

// inserisco dei libri e dvd

biblioteca.documenti.Add(new Libro("873", "La ricerca", "Narrativa", 1956, "B54", "Biondi Fabio", 234));
biblioteca.documenti.Add(new Libro("726", "La poetessa", "Narrativa", 1989, "A24", "Prince Mattia", 456));
biblioteca.documenti.Add(new Libro("123", "Il tempo brutto", "Storia", 2022, "C03", "Biestra Edoardo", 234));
biblioteca.documenti.Add(new Libro("821", "Cinque terre", "Geografia", 1956, "A14", "Innocenti Claudia", 340));
biblioteca.documenti.Add(new Dvd("183", "Film lungo", "Avventura", 2009, "F54", "Kackson Pietro", 234));
biblioteca.documenti.Add(new Dvd("293", "Film Corto", "Cortometraggio", 1956, "F54", "Little Mike", 14));
biblioteca.documenti.Add(new Dvd("393", "La ricerca", "Investigativo", 2013, "G54", "Bruni Brunio", 110));
biblioteca.documenti.Add(new Dvd("262", "La mummia", "Horror", 1924, "H54", "Ultimo Michele", 434));

// inserisco dei utenti

biblioteca.utenti.Add(new Utente("Todirascu", "Andrei", "andrei@gmail.it", "34628839303"));
biblioteca.utenti.Add(new Utente("Bulleri", "Daniele", "andrei@gmail.it", "34628833833"));
biblioteca.utenti.Add(new Utente("Varramista", "Giulia", "giulia@gmail.it", "382903489303"));


// inserisco dei prestiti

biblioteca.prestiti.Add(new Prestito(biblioteca.utenti[0], biblioteca.documenti[2], "04/11/22", "24/11/22"));
biblioteca.documenti[2].Disponibile = false;

biblioteca.prestiti.Add(new Prestito(biblioteca.utenti[2], biblioteca.documenti[5], "04/11/22", "24/11/22"));
biblioteca.documenti[5].Disponibile = false;

biblioteca.prestiti.Add(new Prestito(biblioteca.utenti[1], biblioteca.documenti[1], "04/11/22", "24/11/22"));
biblioteca.documenti[1].Disponibile = false;

biblioteca.AggiungiListaAlDatabase();


