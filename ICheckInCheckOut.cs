using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Terminal
{
    interface CheckInCheckOut
    {
        public void CheckInAndOut(LibraryItems item)
        {

            if (item.CheckedOut=="yes")
            {
                Console.WriteLine("Checked out."); 
            }
            else
            {
                Console.WriteLine("Sorry, I did not recognize that input. Please try again");
            }
        }
        
    }
}
