using System.Runtime.Serialization;

namespace LogicClient.OTD
{
    [DataContract]
    public class CustomerOTD
    {
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string address { get; set; }
        [DataMember]
        public string email { get; set; }
        [DataMember]
        public string phone { get; set; }
        [DataMember]
        public int orders { get; set; }
    }
}
