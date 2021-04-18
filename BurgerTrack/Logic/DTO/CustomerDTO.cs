using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.DTO
{
    public class CustomerDTO
    {
        public string name { get; set;  }
        public string address { get; set; }
        public string email { get; set;  }
        public string phone { get; set; }
        public int orders { get; set; }
    }
}
