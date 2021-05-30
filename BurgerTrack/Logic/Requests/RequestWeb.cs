using Newtonsoft.Json;
using System;

namespace Logic.Requests
{
    [Serializable]
    public class RequestWeb
    {
        [JsonProperty("tag")]
        public string Tag { get; set; }
        [JsonProperty("status")]
        public RequestStatus Status = RequestStatus.SUCCESS;
        public RequestWeb(string tag)
        {
            Tag = tag;
        }
    }
}
