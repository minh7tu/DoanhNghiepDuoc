using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CongKhaiYTe.Core.Helper
{
    public static class Until
    {
        public static async Task<string> EvaluateJavaScriptSync(string jsScript, ChromiumWebBrowser browser)
        {
            string jsonFromJS = null;
            if (browser.CanExecuteJavascriptInMainFrame && !String.IsNullOrEmpty(jsScript))
            {
                JavascriptResponse result = await browser.EvaluateScriptAsync(jsScript);

                if (result.Success)
                {
                    jsonFromJS = "";

                    if (result.Result != null)
                    {
                        jsonFromJS = result.Result.ToString();
                    }
                }
            }
            return jsonFromJS;
        }
    } 
}
