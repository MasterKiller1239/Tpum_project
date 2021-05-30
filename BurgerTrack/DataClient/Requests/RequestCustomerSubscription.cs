﻿using DataClient.DTO;
using Newtonsoft.Json;
using System;

namespace DataClient.Requests
{
    [Serializable]
    public class RequestCustomerSubscription : RequestWeb
    {
        [JsonProperty("customer")]
        public CustomerDTO customer { get; set; }
        public RequestCustomerSubscription(string tag, CustomerDTO customer) : base(tag)
        {
            this.customer = customer;
        }
    }
}
