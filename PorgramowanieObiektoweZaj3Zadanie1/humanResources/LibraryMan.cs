using System;
using System.Collections.Generic;
using System.Text;

namespace PorgramowanieObiektoweZaj3Zadanie1.humanResources
{
    class LibraryMan :Person
    {
        public string employmentDate { get; set; }
        public double salary { get; set; }

        public LibraryMan()
        {

        }
        public LibraryMan(string name,string surname,string employmentDate,double salary) : base(name, surname)
        {
            this.employmentDate = employmentDate;
            this.salary = salary;
        }
    }

}
