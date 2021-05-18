using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
namespace ConnectionDependencies.DTO
{
    [DataContract]
    public class OrderDTO
    {
        [DataMember]
        public Guid id { get; set;  }
        [DataMember]
        public EmployeeDTO supplier { get; set; }
        [DataMember]
        public List<BurgerDTO> burgers { get; set; }
        [DataMember]
        public CustomerDTO customer { get; set; }
        [DataMember]
        public DateTime orderTime { get; set; }
        [DataMember]
        public int realizationTime { get; set; }
    }
}
