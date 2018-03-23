using System;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace RoroBARREL
{
	public class RESTConnection
    {
        public RESTConnection(string host)
        {
            this.host = host;
        }

        private readonly string host;
	    protected HttpWebRequest WebRequest;

        public String Request(String method, String url, String Json) {
            Setup(method, url);
            if (Json != null && !WebRequest.Method.Contains("GET")) Serializing(Json);
            return Connect();
        }

        public String Request(String method, String url, object Json)
        {
            Setup(method, url);
            if (Json != null && !WebRequest.Method.Contains("GET")) Serializing(Json);
            return Connect();
        }

        protected void Setup(String method, String url)
        {
            WebRequest = (HttpWebRequest)System.Net.WebRequest.Create("http://"+host + ":3000/" + url);
            WebRequest.Method = method;
            WebRequest.ContentType = "application/json";
            WebRequest.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;
        }

        public string Connect()
        {
		    try
            {
		        if (WebRequest != null)
                {
		            string content;
		            HttpWebResponse response = (HttpWebResponse)WebRequest.GetResponse();
		    	    using (Stream stream = response.GetResponseStream())
		    	    {
			            using (StreamReader sr = new StreamReader(stream))
			            {
			                content = sr.ReadToEnd();
			            }
			        }
			        return content;
		        }
		    }
            catch(WebException)
            {
		    	Console.WriteLine("Error meanwhile access to Server\n");
		    	throw;
		    }
		    return null;
	    }

	    private void Serializing(String json)
        {
		    using (var streamWriter = new StreamWriter(WebRequest.GetRequestStream()))
		    {
			    streamWriter.Write(json);
		    	streamWriter.Flush();
	    		streamWriter.Close();
		    }
	    }

	    private void Serializing(Object obj)
        {
	    	using (var streamWriter = new StreamWriter(WebRequest.GetRequestStream()))
			{
	    		streamWriter.Write(JsonConvert.SerializeObject(obj, Formatting.Indented));
	    		streamWriter.Flush();
	    		streamWriter.Close();
	    	}
	    }
	}
}

