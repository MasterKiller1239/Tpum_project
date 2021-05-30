using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
namespace DataClient.DTO
{
    [DataContract]
    public class CustomerDTO
    {
        [DataMember]
        public string name { get; set;  }
        [DataMember]
        public string address { get; set; }
        [DataMember]
        public string email { get; set;  }
        [DataMember]
        public string phone { get; set; }
        [DataMember]
        public int orders { get; set; }
    }
}
