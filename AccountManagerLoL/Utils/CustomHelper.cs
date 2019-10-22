using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountManagerLoL.Resources.Consts;
using Newtonsoft.Json.Linq;

namespace AccountManagerLoL.Utils
{
    public class CustomHelper
    {
        public static string GetApikey()
        {
            JObject json = JObject.Parse(System.IO.File.ReadAllText(Constants.PATHTOCONFIG));
            return json.SelectToken("apikey").ToString();
        }

    }
}
