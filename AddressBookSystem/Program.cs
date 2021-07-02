using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    /// <summary>
    /// UC1-Address Book System
    /// </summary>

    class Addr
    {

        static void Main(string[] args)
        {
            Sample.AddrBook.GetCustomer();
            Sample.AddrBook.Modify();
            Sample.AddrBook.ListingPeople();


        }
    }
}
