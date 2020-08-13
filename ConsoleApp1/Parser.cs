using AngleSharp;
using AngleSharp.Html.Parser;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Parser
    {
        public async Task<InfoPay> GetInfo(string path)
        {
            WebClient web = new WebClient();
            String html = web.DownloadString(path);
            var parser = new HtmlParser();
            var document = parser.ParseDocument(html);

            InfoPay result = new InfoPay();
            
            var cellNum = document.QuerySelector("body>table.c27>tbody>tr:nth-child(1)>td.c26>p>span");
            result.NumberPay = cellNum.TextContent;

            var cellDate = document.QuerySelector("body>table.c27>tbody>tr:nth-child(2)>td.c26>p>span");
            result.DatePay = cellDate.TextContent;
            
            var count = document.QuerySelectorAll("body>table.c49>tbody>tr").Length;
            for (int i = 3; i < count; i++)
            {
                result.NumberDocum.Add(document.QuerySelector("body>table.c49>tbody>tr:nth-child("+ i +")>td.c38>p>span").TextContent);
                result.Summa.Add(document.QuerySelector("body>table.c49>tbody>tr:nth-child("+ i +")>td.c44>p>span").TextContent);
            }

            return result;
        }
    }
}
