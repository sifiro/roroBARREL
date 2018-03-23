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
        private readonly RESTConnection restConnection;
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

        public bool SetLocalIPAddress(string host) {
            return setSettings(new JObject() { new JProperty("ipaddress", host) });
        }

        private bool setSettings(object settings)
        {
            return JObject.Parse(restConnection.Request("POST", "config", settings)).SelectToken("status").Value<bool>();
        }

        public bool setTable(object table)
        {
            return JObject.Parse(restConnection.Request("POST", "table", table)).SelectToken("status").Value<bool>();
        }
    }
}
