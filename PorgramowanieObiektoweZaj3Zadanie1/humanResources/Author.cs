using PorgramowanieObiektoweZaj3Zadanie1.humanResources;
using System;
using System.Collections.Generic;
using System.Text;

namespace PorgramowanieObiektoweZaj3Zadanie1
{
    public class Author : Person
    {
    

        public string nationality { get; set; }
        public Author()
        {

        }
        public Author(string name, string surname,string nationality) :base(name,surname)
        {
            this.nationality = nationality;
        }
    }
}
