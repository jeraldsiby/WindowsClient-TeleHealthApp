﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsClient_TeleHealthApp.Models
{
    public class Customer
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public DateTime Date { get; set; }
        public string Response { get; set; }
    }
}
