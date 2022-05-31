using System;
using System.Collections.Generic;
using System.Text;

namespace PorgramowanieObiektoweZaj3Zadanie1.humanResources
{
    public abstract class Person
    {
        public string name { get; set; }
        public string surname { get; set; }
        
        public Person()
        {

        }
        public Person(string name,string surname) 
        {
            this.name = name;
            this.surname = surname;
        }
    }
}
