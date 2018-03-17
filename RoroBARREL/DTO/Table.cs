using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

namespace RoroBARREL
{
    [JsonObject]
    public class Table 
    {
        [JsonProperty()]
       public Dictionary<string, string> table { set; get; }
    }
}
