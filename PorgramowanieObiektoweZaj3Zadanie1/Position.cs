using System;
using System.Collections.Generic;

namespace PorgramowanieObiektoweZaj3Zadanie1
{
    public abstract class Position 
    {
        public string title { get; set; }
        public int ID { get; set; }
        public string publisher { get; set; }
        public int productionYear { get; set; }
        public Author author1 { get; set; }

        public Position()
        {

        }
        public Position(string title, int id, string publisher, int productionYear,Author author1)
        {
            this.title = title;
            this.ID = id;
            this.publisher = publisher;
            this.productionYear = productionYear;

            
        }

        public abstract void PrintInfo();


      
    }
}