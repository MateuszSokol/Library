using System;
using System.Collections.Generic;
using System.Text;

namespace PorgramowanieObiektoweZaj3Zadanie1
{
    interface ManagePosition
    {
        public void FindPositionBasedOnTitle(string title);
        public void FindPositionBasedOnID(int ID);
        public void PrintAllPosition();
    }
}
