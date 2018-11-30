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
                Stream receiveStream = response.GetResponseStream();
                StreamReader readStream = null;

                if (response.CharacterSet == null)
                {
                    readStream = new StreamReader(receiveStream);
                }
                else
                {
                    readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
                }

                string data = readStream.ReadToEnd();
                Console.WriteLine(data);
                response.Close();
                readStream.Close();


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
