using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using Taxjar;

namespace TaxAPI
{
    public  sealed class APIClient
    {       
       // public TaxjarApi client;
        static string api_Key = ConfigurationManager.AppSettings["TaxjarApiKey"];      
        private static TaxjarApi client = null;
        public static TaxjarApi Client
        {
            get
            {
                if (client == null)
                {
                    client = new TaxjarApi(api_Key);
                }
                return client;
            }
        }
    }
}