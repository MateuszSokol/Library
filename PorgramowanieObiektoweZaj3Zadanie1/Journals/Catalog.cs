
using System;
using System.Collections.Generic;

namespace PorgramowanieObiektoweZaj3Zadanie1
{
    class Catalog : Position , ManagePosition
    {
        public string catalogSubject { get; set; }

        public List<Position> list { get; set; }

        public Catalog()
        {

        }
        public Catalog(string catalogSubject)
        {
            this.catalogSubject = catalogSubject;
            list = new List<Position>();
        }

        public void AddPosition(Position position)
        {
            
            list.Add(position);
        }

        

        public override void PrintInfo()
        {
            Console.WriteLine("Katalog o: " + catalogSubject);
        }

        public void FindPositionBasedOnTitle(string title)
        {
            bool found = false;
            foreach (var item in list)
            {
                if (item.title.Equals(title))
                {
                    found = true;
                    Console.WriteLine("Znaleziono pozycje");
                    Console.WriteLine("tytul: " + item.title + " id: " + item.ID + " rok wydania: " + item.productionYear + "Wydawnictwo: " + item.publisher);
                }
            }
            if (!found)
            {
                Console.WriteLine("Nie znaleziono pozycji");
            }
            
        }

        public void FindPositionBasedOnID(int ID)
        {
            bool found = false;
            foreach (var item in list)
            {
                if (item.ID.Equals(ID))
                {
                    found = true;
                    Console.WriteLine("Znaleziono pozycje");
                    Console.WriteLine("tytul: " + item.title + " id: " + item.ID + " rok wydania: " + item.productionYear + " Wydawnictwo: " + item.publisher);
                }
            }
            if (!found)
            {
                Console.WriteLine("Nie znaleziono pozycji");
            }
          
        }

        public void PrintAllPosition()
        {
            foreach (var item in list)
            {

                if (item.author1 != null)
                    Console.WriteLine("autor: " + item.author1.name + " " + item.author1.surname + " tytul: " + item.title + " id: " + item.ID + " rok wydania: " + item.productionYear + " Wydawnictwo: " + item.publisher);

            }
        }
    }
}
