using ConnectionDependencies.DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ConnectionDependencies.Requests
{
    [Serializable]
    public class RequestBurgerOrder : RequestWeb
    {
        [JsonProperty("burgers")]
        public List<BurgerDTO> burgers;
        [JsonProperty("customer")]
        public CustomerDTO customer;

        public RequestBurgerOrder(string tag, CustomerDTO customer, List<BurgerDTO> burgers) : base(tag)
        {
            this.burgers = burgers;
            this.customer = customer;
        }
    }
}
