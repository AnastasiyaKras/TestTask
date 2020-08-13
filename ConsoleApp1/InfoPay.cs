using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class InfoPay
    {
        public string NumberPay { get; set; }
        public string DatePay { get; set; }
        public List<string> NumberDocum { get; set; } = new List<string>();
        public List<string> Summa { get; set; } = new List<string>(); 
    }
}
