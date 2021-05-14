using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Currency_Converter
{
    public class Root    //Root class is a Main Class. API Return rates in a rates, it Return All Currency Name with value. 
    {
        public Rate rates { get; set; }   //get all Record in rates and Set in Rate class as Currency name wise
        public long timestamp;
        public string license;
    }
}
