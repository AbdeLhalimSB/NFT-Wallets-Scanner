using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace NFT_Wallets_Scanner
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        List<string> wallets = new List<string>();

        private void button1_Click(object sender, EventArgs e)
        {
            wallets.Clear();
            string blockchaine = "";
            string r = "";
            foreach (string item in source.Lines)
            {
                wallets.Add(item);
            }
            wcount.Text = wallets.Count.ToString();
            for(int i = 0; i < wallets.Count; i++)
            {
                for(int c = 0 ; c < 3; c++)
                {
                    if (c == 0)
                    {
                        blockchaine = "Ethereum";
                        r = GetOwnedNFTon_Ethereum(api.Text, wallets[i]);
                    }
                    else if (c == 1)
                    {
                        blockchaine = "BNB";
                        r = GetOwnedNFTon_BNB(api.Text, wallets[i]);
                    }
                    else
                    {
                        blockchaine = "Polygon";
                        r = GetOwnedNFTon_Polygon(api.Text, wallets[i]);
                    }
                    if (r != "")
                    {
                        if (r.Length > 67)
                        {
                            result.Text += "Wallet " + wallets[i] + " is owned NFTs on " + blockchaine + " Network" + "\n_______________________________\n";
                        }
                    }
                }
                System.Threading.Thread.Sleep(300);
            }
            
        }

        public string GetOwnedNFTon_Ethereum(string API, String Wallet)
        {
            var request = WebRequest.Create("https://restapi.nftscan.com/api/v2/account/own/" + Wallet + "?erc_type=erc721");
            request.Headers.Add(API);
            request.Method = "GET";
            StreamReader responseReader = new StreamReader(request.GetResponse().GetResponseStream());
            var responseData = responseReader.ReadToEnd();
            return responseData;
        }
        public string GetOwnedNFTon_BNB(string API, String Wallet)
        {
            var request = WebRequest.Create("https://bnbapi.nftscan.com/api/v2/account/own/" + Wallet + "?erc_type=erc721");
            request.Headers.Add(API);
            request.Method = "GET";
            StreamReader responseReader = new StreamReader(request.GetResponse().GetResponseStream());
            var responseData = responseReader.ReadToEnd();
            return responseData;
        }
        public string GetOwnedNFTon_Polygon(string API, String Wallet)
        {
            var request = WebRequest.Create("https://polygonapi.nftscan.com/api/v2/account/own/" + Wallet + "?erc_type=erc721");
            request.Headers.Add(API);
            request.Method = "GET";
            StreamReader responseReader = new StreamReader(request.GetResponse().GetResponseStream());
            var responseData = responseReader.ReadToEnd();
            return responseData;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This tool is using nftscan.com api\nSo if the tool is not working or slow is better take your own API from nftcan.com Enjoy :)", "informations", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void main_Load(object sender, EventArgs e)
        {
            api.Text = "X-API-KEY: Y1HniPn6RKufQ1owBP6tbQa7";
        }
    }
}
