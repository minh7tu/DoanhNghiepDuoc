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
        private const string _jsClickClose = @"document.getElementsByClassName('btn btn-primary')[0].click()";
        //private string _jsClickItem = @"document.getElementsByTagName('a')["+i+"].click()";
        private string url = @"https://congkhaiyte.moh.gov.vn/?page=Project.MedicalPrice.Home.MedicalPrice.AdsConfirmation.list#module9";
        public string url1 = @"https://congkhaiyte.moh.gov.vn/?&module=Content.Form&moduleId=22009&backdrop=static&itemId=5fb66666a63e2138a955eef8&=&service=Project.MedicalPrice.Home.MedicalPrice.AdsConfirmation.select&modalClass=modal-lg&gridModuleParentId=9&layout=Project.MedicalPrice.Home.MedicalPrice.AdsConfirmation.detail&site=2001869";
        public ChromiumWebBrowser _browser;
        public ChromiumWebBrowser _browser1;
        public static List<CompanyDTO> _lisLink = new List<CompanyDTO>();


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
            int i = 29, j = 1009;
            

            //////c2
            HtmlAgilityPack.HtmlDocument htmlDocument = new HtmlAgilityPack.HtmlDocument();            
          
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

                    //JavascriptResponse response3 = await _browser.EvaluateScriptAsync(@"document.getElementsByTagName('a')[" + i + "].click()");
                    //JavascriptResponse response4 = await _browser.EvaluateScriptAsync(_jsClickClose);

                    var dataId = item.SelectSingleNode("./td[@class='tb-text text-bold']/a").Attributes["data-item-id"].Value;
                    dto.Link = @"https://congkhaiyte.moh.gov.vn/?&module=Content.Form&moduleId="+j+"&backdrop=static&itemId=" + dataId + "&=&service=Project.MedicalPrice.Home.MedicalPrice.AdsConfirmation.select&modalClass=modal-lg&gridModuleParentId=9&layout=Project.MedicalPrice.Home.MedicalPrice.AdsConfirmation.detail&site=2001869";

                    HtmlWeb htmlWeb = new HtmlWeb()
                    {
                        AutoDetectEncoding = false,
                        OverrideEncoding = Encoding.UTF8  //Set UTF8 để hiển thị tiếng Việt
                    };

                    htmlDocument = htmlWeb.Load(dto.Link);
                    //Thread.Sleep(6000);

                    dto.TaxCode = htmlDocument.DocumentNode.SelectSingleNode("//div[@class='box-medicine-detail']/div[3]/div[@class='bx-deaitl-val']").InnerText;

                    i += 2;
                    j += 1000;
                    
                    bus.Insert(dto);
                }

                //Thread.Sleep(3000);

                JavascriptResponse response1 = await _browser.EvaluateScriptAsync(_jsClick);
            }

           
        }

        

     
    }      
}
