using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace AccountManager
{
    internal static class AccountController
    {
        public static JObject file = JObject.Parse(File.ReadAllText(Constants.AccountFile));


        public static void CheckUser()
        {
            string newUser = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            string oldUser = file.SelectToken(Constants.USER).ToString();
            if (newUser != oldUser)
            {
                JArray array = (JArray) file.SelectToken(Constants.ACCOUNTS);
                array.Clear();
                file[Constants.ACCOUNTS] = array;
            }
            file[Constants.USER] = newUser;
            save();
        }

        public static List<Account> GetAccounts()
        {
            List<Account> accounts = new List<Account>();

            JArray accs = (JArray)file.SelectToken(Constants.ACCOUNTS);

            foreach (var item in accs)
            {
                Account acc = new Account();

                var props = acc.GetType().GetProperties();

                foreach (var prop in props)
                {
                    prop.SetValue(acc,item.SelectToken(prop.Name).ToString());
                }

                accounts.Add(acc);
            }
            return accounts;
        }

        public static bool AddAccount(Account acc)
        {
            if (!userExist(acc.Username))
            {
                addAccountToArray(acc);

                save();

                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool DeleteAccount(Account acc)
        {
            if (userExist(acc))
            {
                JArray accounts = (JArray)file.SelectToken(Constants.ACCOUNTS);

                JToken token = accounts.Where(x => x.SelectToken("Id").ToString() == acc.Id).FirstOrDefault();

                accounts.Remove(token);

                file[Constants.ACCOUNTS] = accounts;

                save();

                return true;

            }
            else
            {
                return false;
            }
        }

        private static bool userExist(Account acc)
        {
            return userExist(acc.Username);
        }

        private static bool userExist(string username)
        {
            JArray accounts = (JArray) file.SelectToken(Constants.ACCOUNTS);
            bool answer = (accounts.Where(x => x.SelectToken("Username").ToString() == username).Count() > 0) ? true : false;
            return answer;
        }

        private static void addAccountToArray<T>(T item)
        {
            JArray array = (JArray) file.SelectToken(Constants.ACCOUNTS);
            JObject obj = new JObject();

            foreach (var prop in item.GetType().GetProperties())
            {
                JProperty property = new JProperty(prop.Name, prop.GetValue(item));
                obj.Add(property);
            }

            array.Add(obj);
            file[Constants.ACCOUNTS] = array;
        }
                
        private static void save()
        {
            File.WriteAllText(Constants.AccountFile, file.ToString());
        }
    }
}
