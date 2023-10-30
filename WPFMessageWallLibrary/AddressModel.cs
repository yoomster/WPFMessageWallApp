using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFMessageWallLibrary
{
    public class AddressModel
    {
        public string StreetName { get; set; }
        public string HouseNr { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string AddressDisplayValue => $"{StreetName}, {HouseNr}, {PostCode}, {City}, {Country}";

    }
}
