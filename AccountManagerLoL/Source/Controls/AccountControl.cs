using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccountManagerLoL.Source.Library;
using RiotAPIv4;
using AccountManagerLoL.Utils;
using RiotAPIv4.Ressources.Summoner;
using AccountManagerLoL.Resources.Consts;
using System.Threading;

namespace AccountManagerLoL.Source.Controls
{
    public partial class AccountControl : UserControl
    {

        public event EventHandler RightClicked;
        public event EventHandler LeftClicked;

        private Account account;

        public Account Account { get => account; set => account = value; }

        private static RiotApi riotApi;
        private static RiotStatic riotStatic = new RiotStatic(Language.German);
        private static Summoner summoner;

        public AccountControl()
        {
            InitializeComponent();
            riotApi = new RiotApi(CustomHelper.GetApikey(), Regions.EUW);
        }

        private void on_load(object sender, EventArgs e)
        {
            load_date(sender);
        }

        private void load_date(object sender)
        {
            try
            {

                lbl_name.Text = account.Name;
                summoner = riotApi.GetSummonerByName(account.Name);
                pb_icon.Load(riotStatic.GetProfileIcon(summoner.ProfileIconId.ToString()));
                pb_ranked_elo.Image = new Bitmap(Constants.PATHTORANKEDICONS + "/Emblem_" + summoner.SoloDuoRank.Tier + ".png");
                lbl_elo.Text = summoner.SoloDuoRank.Tier + " " + summoner.SoloDuoRank.Rank;
                lbl_elo.ForeColor = GetRankedFontColor(summoner.SoloDuoRank.Tier);
                double winrate = Math.Round((double)summoner.SoloDuoRank.Wins / ((double)summoner.SoloDuoRank.Wins + (double)summoner.SoloDuoRank.Losses), 2);
                winrate = winrate * 100;
                lbl_winrate.Text = winrate.ToString() + "%";
                if (winrate < 50)
                {
                    lbl_winrate.ForeColor = Color.FromArgb(169, 50, 38);
                }
                else
                {
                    if (winrate > 70)
                    {
                        lbl_winrate.ForeColor = Color.FromArgb(241, 196, 15);
                    }
                    else if (winrate > 60)
                    {
                        lbl_winrate.ForeColor = Color.FromArgb(84, 153, 199);
                    }
                    else
                    {
                        lbl_winrate.ForeColor = Color.FromArgb(82, 190, 128);
                    }
                }

            }
            catch
            {

            }
        }

        private void center_control(Control control)
        {
            control.Top = (this.ClientSize.Height - control.Height) / 2;
        }

        private void on_size_changed(object sender, EventArgs e)
        {
            center_control(pb_icon);
            center_control(lbl_name);
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
                default:
                    return Color.White;
            }
        }

        private void on_mouse_click(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Right == e.Button)
            {
                RightClicked(new object[] { this, account, e.Location }, e);
            }
        }

        private void on_detail(object sender, EventArgs e)
        {
            LeftClicked(account,e);
        }
    }
}
