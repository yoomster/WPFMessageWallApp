﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFMessageWallLibrary
{
    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName{ get; set; }
        public bool IsActive { get; set; }
        public AddressModel Address { get; set; }
    }
}
