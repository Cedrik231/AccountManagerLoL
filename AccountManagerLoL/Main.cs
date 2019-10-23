using AccountManagerLoL.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.IO;
using AccountManagerLoL.Resources.Consts;
using AccountManagerLoL.Source.Library;
using AccountManagerLoL.Source.Controls;
using System.Windows;
using System.Threading;
using RiotAPIv4;
using AccountManagerLoL.Utils;
using RiotAPIv4.Ressources.Summoner;
using System.Diagnostics;

namespace AccountManagerLoL
{
    public partial class Main : Form
    {
        private static JObject accounts = JObject.Parse(File.ReadAllText(Constants.PATHTOACCOUNTS));
        ConfigForm configForm;
        AddAccountForm addAccountForm;
        static RiotStatic riotStatic = new RiotStatic(Language.German);
        RiotApi riotApi;
        Account acc;

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;


        public Main()
        {
            InitializeComponent();
            riotApi = new RiotApi(CustomHelper.GetApikey(), Regions.EUW);
        }

        private void on_load(object sender, EventArgs e)
        {
            toolBar.Renderer = new CustomRenderToolStrip();
            configForm = new ConfigForm();
            configForm.configSaved += ConfigForm_configSaved;
            addAccountForm = new AddAccountForm();
            addAccountForm.userAdded += AddAccountForm_userAdded;
            new Thread(RenderAccounts).Start();
        }

        private void ConfigForm_configSaved(object sender, EventArgs e)
        {
            RenderAccounts();
        }

        private void AddAccountForm_userAdded(object sender, EventArgs e)
        {
            Account account = (Account)sender;
            int index = AddAccount(account);
            PaintAccountInPanel(account, index);
        }

        private void Ts_button_options_Click(object sender, EventArgs e)
        {
            configForm.ShowDialog();
        }

        private void RenderAccounts()
        {


            panel_accounts.Controls.Clear();

            JArray accountsJson = JArray.Parse(accounts.SelectToken("accounts").ToString());

            for (int i = 0; i < accountsJson.Count; i++)
            {
                JToken account = accountsJson[i];

                string name = account.SelectToken("name").ToString();
                string username = account.SelectToken("username").ToString();
                string password = account.SelectToken("password").ToString();
                Account myAcc = new Account(name, username, password);

                PaintAccountInPanel(myAcc, i);

            }
        }

        private void PaintAccountInPanel(Account acc, int index)
        {

            AccountControl control = new AccountControl();
            control.RightClicked += Control_RightClicked;
            control.LeftClicked += Account_LoadDetail;
            control.Account = acc;
            control.Location = new Point(panel_accounts.Location.X - 10, panel_accounts.Location.Y - 70 + (index * (control.Height + 6)));

            Invoke((MethodInvoker)delegate
            {
                panel_accounts.Controls.Add(control);
            });

        }

        private void Control_RightClicked(object sender, EventArgs e)
        {
            object[] data = (object[])sender;
            AccountControl control = (AccountControl)data[0];
            Account acc = (Account)data[1];
            Point loc = (Point)data[2];

            ContextMenu cm = new ContextMenu();


            var itemCopyUser = cm.MenuItems.Add("Kopiere User");
            var itemCopyPassword = cm.MenuItems.Add("Kopiere Passwort");
            var itemDelete = cm.MenuItems.Add("Account entfernen");
            cm.Show(control, loc);

            itemDelete.Click += (sender1, e1) => ItemDelete_Click(sender1, e1, control, acc);
            itemCopyPassword.Click += (sender2, e2) => ItemCopyPassword_Click(acc.Password, e2);
            itemCopyUser.Click += (sender3, e3) => ItemCopyPassword_Click(acc.Username, e3);
        }

        private void ItemCopyPassword_Click(object sender2, EventArgs e2)
        {
            Clipboard.SetText(sender2.ToString());
        }

        private void ItemDelete_Click(object sender, EventArgs e, AccountControl control, Account acc)
        {
            RemoveAccount(control, acc);
        }

        private int AddAccount(Account acc)
        {
            int index = 0;
            JArray accountsJson = JArray.Parse(accounts.SelectToken("accounts").ToString());
            index = accountsJson.Count;
            accountsJson.Add(new JObject(new JProperty("name", acc.Name), new JProperty("username", acc.Username), new JProperty("password", acc.Password)));
            accounts["accounts"] = accountsJson;
            File.WriteAllText(Constants.PATHTOACCOUNTS, accounts.ToString());
            return index;
        }

        private void RemoveAccount(AccountControl control, Account acc)
        {
            panel_accounts.Controls.Remove(control);
            JArray accs = (JArray)accounts.SelectToken("accounts");
            var ac = accs.Where(x => x.SelectToken("name").ToString() == acc.Name).FirstOrDefault();
            accs.Remove(ac);
            accounts["accounts"] = accs;
            File.WriteAllText(Constants.PATHTOACCOUNTS, accounts.ToString());
        }

        private void Tsm_add_account_Click(object sender, EventArgs e)
        {
            addAccountForm.ShowDialog();
        }

        private async void Account_LoadDetail(object sender, EventArgs e)
        {
            acc = (Account)sender;

            lbl_ingame.Text = acc.Name;



            var data = await LoadDataAsync(acc.Name);

            panel_detail.Visible = true;



        }


        private async Task<Summoner> LoadDataAsync(string ingame)
        {
            var w = await Task.Run(() =>
            {
                Summoner summoner = null;
                try
                {
                    summoner = riotApi.GetSummonerByName(ingame);
                }
                catch (RiotAPIv4.Exceptions.APIKeyNotValidException err)
                {
                    summoner = null;
                    MessageBox.Show(err.Message);
                }
                catch (Exception err1)
                {
                    MessageBox.Show(err1.Message);
                }
                try
                {
                    pb_duoq.Image = new Bitmap(Constants.PATHTORANKEDICONS + "/Emblem_" + summoner.SoloDuoRank.Tier + ".png");
                    Invoke((MethodInvoker)delegate
                    {
                        lbl_duo_elo.Text = summoner.SoloDuoRank.Tier + " " + summoner.SoloDuoRank.Rank;
                        lbl_duo_elo.ForeColor = GetRankedFontColor(summoner.SoloDuoRank.Tier);
                    });
                }
                catch
                {
                    pb_duoq.Image = new Bitmap(Constants.PATHTORANKEDICONS + "/Emblem_" + "IRON" + ".png");
                    Invoke((MethodInvoker)delegate
                    {
                        lbl_duo_elo.Text = "Unranked";
                        lbl_duo_elo.ForeColor = Color.White;
                    });
                }
                try
                {
                    pb_flex.Image = new Bitmap(Constants.PATHTORANKEDICONS + "/Emblem_" + summoner.FlexRank.Tier + ".png");
                    Invoke((MethodInvoker)delegate
                    {
                        lbl_flex_elo.Text = summoner.FlexRank.Tier + " " + summoner.FlexRank.Rank;
                        lbl_flex_elo.ForeColor = GetRankedFontColor(summoner.FlexRank.Tier);
                    });
                }
                catch
                {
                    pb_flex.Image = new Bitmap(Constants.PATHTORANKEDICONS + "/Emblem_" + "IRON" + ".png");
                    Invoke((MethodInvoker)delegate
                    {
                        lbl_flex_elo.Text = "Unranked";
                        lbl_flex_elo.ForeColor = Color.White;

                    });
                }
                try
                {
                    pb_tft.Image = new Bitmap(Constants.PATHTORANKEDICONS + "/Emblem_" + summoner.TftRank.Tier + ".png");
                    Invoke((MethodInvoker)delegate
                    {
                        lbl_tft_elo.Text = summoner.TftRank.Tier + " " + summoner.TftRank.Rank;
                        lbl_tft_elo.ForeColor = GetRankedFontColor(summoner.TftRank.Tier);

                    });
                }
                catch
                {
                    pb_tft.Image = new Bitmap(Constants.PATHTORANKEDICONS + "/Emblem_" + "IRON" + ".png");
                    Invoke((MethodInvoker)delegate
                    {
                        lbl_tft_elo.Text = "Unranked";
                        lbl_tft_elo.ForeColor = Color.White;
                    });
                }

                return summoner;
            });

            return w;
        }

        private Color GetRankedFontColor(string tier)
        {
            switch (tier)
            {
                case "DIAMOND":
                    return Color.FromArgb(54, 153, 199);
                case "PLATINUM":
                    return Color.FromArgb(22, 160, 133);
                case "GOLD":
                    return Color.FromArgb(241, 196, 15);
                case "SILVER":
                    return Color.FromArgb(171, 178, 185);
                case "BRONZE":
                    return Color.FromArgb(211, 84, 0);
                case "IRON":
                    return Color.FromArgb(95, 106, 106);
                case "MASTER":
                    return Color.FromArgb(155, 89, 182);
                default:
                    return Color.White;
            }
        }

        private void Btn_acc_start_Click(object sender, EventArgs e)
        {
            //Process.GetProcessesByName("").Where(x => x.ProcessName == "").Single().Kill();

            Cursor.Position = CustomHelper.GetUserKords();
            ConfigForm.mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, (long)Cursor.Position.X, (long)Cursor.Position.Y, 0, 0);

            SendKeys.Send(acc.Username);

            Thread.Sleep(2000);

            Cursor.Position = CustomHelper.GetPasswordKords();
            ConfigForm.mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, (long)Cursor.Position.X, (long)Cursor.Position.Y, 0, 0);

            SendKeys.Send(acc.Password);
        }
    }


    public class CustomRenderToolStrip : ToolStripRenderer
    {
        public CustomRenderToolStrip()
        {

        }
        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
        {

        }
    }

}
