using PorgramowanieObiektoweZaj3Zadanie1.humanResources;
using System;
using System.Collections.Generic;

namespace PorgramowanieObiektoweZaj3Zadanie1
{
    class Library : ManagePosition
    {
        private string adress;
        private List<LibraryMan> libraryMenList;
        private List<Catalog> catalogList;

        public Library()
        {

        }

        public Library(string adress)
        {
            libraryMenList = new List<LibraryMan>();
            catalogList = new List<Catalog>();
            this.adress = adress;
        }

        public void AddLibraryMan(LibraryMan libraryMan)
        {
            libraryMenList.Add(libraryMan);
        }

        public void RemoveLibraryMenToList(LibraryMan libraryMan)
        {
            libraryMenList.Remove(libraryMan);
        }

        public void PrintLibraryInfo()
        {
            foreach (var item in libraryMenList)
            {
                Console.WriteLine("Bibliotekarz: " + item.name + " " + item.surname + " Data zatrudnienie: " + item.employmentDate + " Wynagrodzenie: " + item.salary);
            }

            foreach (var item in catalogList)
            {
                Console.WriteLine("Katalog: " + item.catalogSubject);
            }

           
        }

        public void PrintAllLibraryMan()
        {
            foreach (var item in libraryMenList)
            {
                Console.WriteLine("Bibliotekarz: " + item.name + " " + item.surname + " " + item.employmentDate + " " + item.salary);
            }
        }

        public void AddCatalog(Catalog catalog)
        {
 
            catalogList.Add(catalog);
        }
     
        public void AddPosition(Position position,string subjectSection)
        {
            catalogList.Add(new Catalog(subjectSection));


        }

    

        public void FindPositionBasedOnTitle(string title)
        {
            bool found = false;
            for (int i = 0; i <catalogList.Count; i++)
            {

                for (int j = 0; j <catalogList[i].list.Count; j++)
                {
                    if (catalogList[i].list[j].title.Equals(title))
                    {
                        found = true;
                        Console.WriteLine("Pozycja znaleziona: ");

                        Console.WriteLine(catalogList[i].list[j].author1.name + " " + catalogList[i].list[j].author1.surname + " " +
                            catalogList[i].list[j].title + " " + catalogList[i].list[j].productionYear + " " + catalogList[i].list[j].publisher);
                    }
                }
                
            }

            if (!found)
            {
                Console.WriteLine("Pozycji nie znaleziono");
            }
         
        }

        public void FindPositionBasedOnID(int ID)
        {
            bool found = false ;
            for (int i = 0; i < catalogList.Count; i++)
            {

                for (int j = 0; j < catalogList[i].list.Count; j++)
                {
                    if (catalogList[i].list[j].ID.Equals(ID))
                    {
                        found = true;
                        Console.WriteLine("Pozycja znaleziona: ");

                        Console.WriteLine(catalogList[i].list[j].ID+ " " + catalogList[i].list[j].author1.name + " " + catalogList[i].list[j].author1.surname + " " +
                            catalogList[i].list[j].title + " " + catalogList[i].list[j].productionYear + " " + catalogList[i].list[j].publisher);
                    }
                }

            }
            if (!found)
            {
                Console.WriteLine("Pozycji nie znaleziono");

            }
          

        }

        public void PrintAllPosition()
        {

            for (int i = 0; i < catalogList.Count; i++)
            {
                for (int j = 0; j < catalogList[i].list.Count; j++)
                {
                    Console.WriteLine("Katalog " + catalogList[i].catalogSubject + " Autor: " + catalogList[i].list[j].author1.name + " " + catalogList[i].list[j].author1.surname
                        + " " + catalogList[i].list[j].title + " " + catalogList[i].list[j].publisher + " " + catalogList[i].list[j].productionYear);


                }
            }


          
        }
    }
}
