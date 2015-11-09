using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable {

    public class MySchema
    {
        public List<WebSchema> data { get; set; }
    }
    public class WebSchema
    {
        [JsonProperty("method")]
        public string Method { get; set; }
        [JsonProperty("path")]
        public string Path { get; set; }
        [JsonProperty("script")]
        public string Script { get; set; }
    }
}
