using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
namespace ConnectionDependencies.DTO
{
    [DataContract]
    public class BurgerDTO
    {
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public float price { get; set; }
        [DataMember]
        public string description { get; set; }
        [DataMember]
        public float discount { get; set; }
        [DataMember]
        public string image { get; set; }
    }
}
