using CefSharp;
using CefSharp.WinForms;
using CongKhaiYTe.Core.BUS;
using CongKhaiYTe.Core.DAO;
using CongKhaiYTe.Core.DTO;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Script.Serialization;


namespace CongKhaiYTe.WinForm
{
    public partial class Main : Form
    {
        private const string _jsClick = @"document.getElementsByClassName('next')[0].click()";
        private string url = @"https://congkhaiyte.moh.gov.vn/?page=Project.MedicalPrice.Home.MedicalPrice.AdsConfirmation.list#module9";
        public ChromiumWebBrowser _browser;

        public Main()
        {
            InitializeComponent();
            InitBrowser();
        }

        public void InitBrowser()
        {
            //CefSettings cefSettings = new CefSettings();
            //Cef.Initialize(cefSettings);

            _browser = new ChromiumWebBrowser(url);
            pnlChorme.Controls.Add(_browser);
            _browser.Dock = DockStyle.Fill;
        }

        private async void btnCrawler_Click(object sender, EventArgs e)
        {
            CompanyDTO dto = new CompanyDTO();
            CompanyBUS bus = new CompanyBUS();

            //////c2
            HtmlAgilityPack.HtmlDocument htmlDocument = new HtmlAgilityPack.HtmlDocument();
            //JavascriptResponse response = await _browser.EvaluateScriptAsync("document.getElementsByTagName('html')[0].innerHTML");
            //string html = response.Result.ToString();
            //htmlDocument.LoadHtml(html);

            //var items = htmlDocument.DocumentNode.SelectNodes("//table[@class='table table-data table-striped']/tbody/tr").ToList();

            //foreach (var item in items)
            //{
            //    dto.Id = Convert.ToInt32(item.SelectSingleNode("./td").InnerText);
            //    dto.CompanyName = item.SelectSingleNode("./td[@class='tb-text text-bold']").InnerText;
            //    dto.RegisterProductName = item.SelectSingleNode("./td[@class='tb-text text-bold']/a").InnerText;
            //    dto.AdComfirmNumber = item.SelectSingleNode("./td[4]").InnerText;

            //    bus.Insert(dto);
            //}

            while (true)
            {
                
                JavascriptResponse response2 = await _browser.EvaluateScriptAsync("document.getElementsByTagName('html')[0].innerHTML");
                string html1 = response2.Result.ToString();

                if(html1 == null)
                {
                    return;
                }    

                htmlDocument.LoadHtml(html1);

                var itemss = htmlDocument.DocumentNode.SelectNodes("//table[@class='table table-data table-striped']/tbody/tr").ToList();

                foreach (var item in itemss)
                {
                    dto.Id = Convert.ToInt32(item.SelectSingleNode("./td").InnerText);
                    dto.CompanyName = item.SelectSingleNode("./td[@class='tb-text text-bold']").InnerText;
                    dto.RegisterProductName = item.SelectSingleNode("./td[@class='tb-text text-bold']/a").InnerText;
                    dto.AdComfirmNumber = item.SelectSingleNode("./td[4]").InnerText;

                    bus.Insert(dto);
                }

                Thread.Sleep(10000);

                JavascriptResponse response1 = await _browser.EvaluateScriptAsync(_jsClick);
            }    
        }       
    }      
}
