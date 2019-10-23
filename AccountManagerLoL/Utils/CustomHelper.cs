using System;
using System.Collections.Generic;
using System.Drawing;
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
        public static Point GetUserKords()
        {
            JObject json = JObject.Parse(System.IO.File.ReadAllText(Constants.PATHTOCONFIG));
            return new Point((int)json.SelectToken("kordsUser.X"), (int)json.SelectToken("kordsUser.Y"));
        }
        public static Point GetPasswordKords()
        {
            JObject json = JObject.Parse(System.IO.File.ReadAllText(Constants.PATHTOCONFIG));
            return new Point((int)json.SelectToken("kordsPassword.X"), (int)json.SelectToken("kordsPassword.Y"));
        }
    }
}
