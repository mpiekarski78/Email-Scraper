using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Simple email scraper from an URL. 
/// - GET URL (USER POST)
/// - CREATE SITEMAP 
/// - SCRAPE EMAIL ADDRESSES FROM ALL URLs in the SITEMAP
/// </summary>
namespace Email_Scraper
{
    public partial class App : Form
    {

        HtmlWeb hw = new HtmlWeb(); ///<remarks> HTML Agility Pack</remarks>
        List<string> hrefTags = new List<string>(); //Sitemap from URL List
        List<string> emailAddresses = new List<string>(); //Email Addresss List




        public App()
        {
            InitializeComponent();
        }


        private void buttonStartScraping_Click(object sender, EventArgs e)
        {
            ///<remarks>
            ///1. get url from "textBoxURLforScraping" textBox 
            ///2. check if URL reponds
            ///</remarks>
            ///
            string urlAddress = textBoxURLforScraping.Text;

            try
            {
                getHTML(urlAddress);
            }
            catch (Exception)
            {
                //handle exception
            }


        }

        private void getHTML(string urlAddress)
        {

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlAddress);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                HtmlAgilityPack.HtmlDocument doc = hw.Load(urlAddress);

                //Add links from URL posted by the user
                foreach (HtmlNode link in doc.DocumentNode.SelectNodes("//a[@href]"))
                {
                    HtmlAttribute att = link.Attributes["href"];

                    //richTextBoxSitemap.Text = att.Value;
                    //richTextBoxSitemap.AppendText(att.Value +"\r\n");
                    hrefTags.Add(att.Value);
                }


                //
                foreach (HtmlNode email in doc.DocumentNode.SelectNodes("//a[@href]"))
                {
                    HtmlAttribute att = email.Attributes["href"];

                    if (att.Value.StartsWith("mailto:"))
                    {
                        //richTextBoxEmailAddresses.AppendText(att.Value.Split(':')[1] + "\r\n");
                        emailAddresses.Add(att.Value.Split(':')[1]);
                    }
                }



            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
