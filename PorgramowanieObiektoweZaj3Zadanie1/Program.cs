using PorgramowanieObiektoweZaj3Zadanie1.humanResources;
using System;

namespace PorgramowanieObiektoweZaj3Zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            Book k1 = new Book("Niedźwiedzie", 123, "Nowy Świt", 2000, 234,null);
            Book k2 = new Book("Koty", 234, "Wydawnictwo Sowa", 2010, 120, null);
            Book k3 = new Book("Motocykle", 123, "Nowy Świt", 2000, 234,null);
            Magazine cz1 = new Magazine("Polska przyroda", 234, "Wydawnictwo Sowa", 2010, 120,null);
       
            Author a1 = new Author("Alan", "Coel", "Amerykanin");
            Author a2 = new Author("Dawid", "Jung", "Polak");
            //---
            Author a3 = new Author("Nieznany", "Nieznany", "Nieznana");
            k1.AddBookAuthor(a3);
            k2.AddBookAuthor(a3);
            k3.AddBookAuthor(a3);
            cz1.author1 = a3;

            //---
            k1.AddBookAuthor(a1);
            k2.AddBookAuthor(a2);
            k1.PrintInfo();
            k2.PrintInfo();
            Catalog kat1 = new Catalog("Przyroda");
            kat1.AddPosition(k1);
            kat1.AddPosition(k2);
            kat1.AddPosition(cz1);

            
            Console.WriteLine("Zawartość katalogu Przyroda");
            kat1.PrintAllPosition();
            Catalog kat2 = new Catalog("Motoryzacja");
            kat2.AddPosition(k3);
            Console.WriteLine("Zawartość katalogu Motoryzacja");
            kat2.PrintAllPosition();

            Library biblioteka1 = new Library("Bolszewo");
            biblioteka1.AddCatalog(kat1);
            biblioteka1.AddCatalog(kat2);
            Console.WriteLine("Wszystkie zasoby biblioteki");
            biblioteka1.PrintAllPosition();
            LibraryMan b1 = new LibraryMan("Jan", "Bor", "21.03.2000", 2300.00);
            LibraryMan b2 = new LibraryMan("Ewa", "Kowalska", "28.05.2008",
            2300.00);
            biblioteka1.AddLibraryMan(b1);
            biblioteka1.AddLibraryMan(b2);
            Console.WriteLine("Bibliotekarze: ");
            biblioteka1.PrintAllLibraryMan();

            //------------


            kat1.FindPositionBasedOnTitle("Koty");
            kat1.FindPositionBasedOnTitle("Motocykle");
            biblioteka1.FindPositionBasedOnTitle("Motocykle");
            biblioteka1.FindPositionBasedOnID(123);

        }
    }
}
