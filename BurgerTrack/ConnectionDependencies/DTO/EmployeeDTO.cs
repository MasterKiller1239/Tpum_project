using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
namespace ConnectionDependencies.DTO
{
    [DataContract]
    public class EmployeeDTO
    {
        [DataMember]
        public string name { get; set; }
    }
}
