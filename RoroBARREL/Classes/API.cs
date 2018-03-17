using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace RoroBARREL
{
    public class API
    {
        private RESTConnection restConnection;
        public string host;
        public API(string host)
        {
            this.host = host;
            this.restConnection = new RESTConnection(host);   
        }
        public Dictionary<string, string> getTable()
        {
            return JsonConvert.DeserializeObject<Dictionary<string, string>>(restConnection.Request("GET","table",null));
        }
        public Dictionary<string, string> getSettings()
        {
            return JsonConvert.DeserializeObject<Dictionary<string, string>>(restConnection.Request("GET", "config", null));
        }
        public bool setSettings()
        {
            return JObject.Parse(restConnection.Request("POST", "table", null)).SelectToken("status").Value<bool>();
        }
        public bool setTable()
        {
            return JObject.Parse(restConnection.Request("POST", "config", null)).SelectToken("status").Value<bool>();
        }
    }
}
