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
        public Table getTable()
        {
            return JsonConvert.DeserializeObject<Table>(restConnection.Request("GET","table",null));
        }
        public Dictionary<string, string> getSettings()
        {
            return JsonConvert.DeserializeObject<Dictionary<string, string>>(restConnection.Request("GET", "config", null));
        }
        public bool setSettings(Dictionary<string, string> settings)
        {
            return JObject.Parse(restConnection.Request("POST", "config", settings)).SelectToken("status").Value<bool>();
        }
        public bool setTable(object table)
        {
            return JObject.Parse(restConnection.Request("POST", "table", table)).SelectToken("status").Value<bool>();
        }
    }
}
