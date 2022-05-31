using System;
using System.Collections.Generic;
using System.Text;

namespace PorgramowanieObiektoweZaj3Zadanie1
{
    class Magazine : Position
    {
        public int number { get; set; }

        public Magazine()
        {

        }

        public Magazine(string title, int id, string publisher, int productionYear, int number,Author author1) : base(title,id,publisher,productionYear,author1)
        {
            this.number = number;
        }

        override
       public void PrintInfo()
        {
            Console.WriteLine("Tytul: " + title + " Id: " + ID + " Wydawnictwo: " + publisher + " Rok Wydania: " + productionYear + " Numer magazynu: " + number);
        }
    }
}
