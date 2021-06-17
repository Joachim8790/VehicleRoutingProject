using DomainModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteModule.AddressLookup
{
    public class AddressLookupService
    {
        /// <summary>
        /// Looks up 1 address and returns the corresponding coordinates
        /// </summary>
        /// <param name="address">The address to lookup</param>
        /// <returns>returns the correct coordinates of the address</returns>
        public void Lookup(Address address)
        {

        }

        /// <summary>
        /// Looks up a range of addresses and returns the corresponding coordinates
        /// </summary>
        /// <param name="addresses">The range of addresses to lookup</param>
        /// <returns>a list of coordinates corresponding to the list of addresses</returns>
        public void LookupRange(List<Address> addresses)
        {

        }
    }
}
