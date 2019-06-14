using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AccountManager
{
    internal static class Constants
    {
        public static string WorkingDirectory = Environment.CurrentDirectory;      
        public static string ProjectDirectory = Directory.GetParent(WorkingDirectory).Parent.FullName;
        public static string AccountFile = ProjectDirectory + "/Accounts/accounts.json";
        public static string PicturePath = ProjectDirectory + "/Ressources/";


        /// JSON Strings


        public const string USER = "last_user";
        public const string ACCOUNTS = "accounts";




    }
}
