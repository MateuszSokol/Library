using System;
using System.Collections.Generic;
using System.Text;

namespace PorgramowanieObiektoweZaj3Zadanie1
{
    class Book : Position
    {
        public int numberOfPages { get; set; }
        

        public Book()
        {

        }
        public Book(string title, int id, string publisher, int productionYear,int numberOfPages, Author author1) : base(title, id, publisher, productionYear,author1)
        {
            this.numberOfPages = numberOfPages;
           
        }

        public void AddBookAuthor(Author author)
        {

            this.author1 = author;
        }
      

        override
        public void PrintInfo()
        {   
            Console.WriteLine("Autor: "+author1.name + " "+ author1.surname+" Tytul:" + title + " Id: " + ID + " Wydawnictwo: " + publisher + " Rok Wydania: " + productionYear + " Ilość stron: " + numberOfPages);
        }

    
    }
}
