﻿using Logic.DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Logic.Requests
{
    [Serializable]
    public class ResponseBurgerList : RequestWeb
    {
        [JsonProperty("burgers")]
        public List<BurgerDTO> burgers { get; set; }
        public ResponseBurgerList(string tag, List<BurgerDTO> burgers) : base(tag)
        {
            this.burgers = burgers;
        }
    }
}
