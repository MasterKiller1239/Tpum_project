using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.DTO
{
    public class OrderDTO
    {
        public Guid id { get; set;  }
        public EmployeeDTO supplier { get; set; }
        public List<BurgerDTO> burgers { get; set; }
        public CustomerDTO customer { get; set; }
        public DateTime orderTime { get; set; }
        public int realizationTime { get; set; }
    }
}
