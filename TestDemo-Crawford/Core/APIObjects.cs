using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDemo_Crawford.Core
{
    class APIObjects
    {
        //public List<main_object> objectList { get; set; }
        public class MainObject
        {
            public data data { get; set; }
            public support support { get; set; }
        }
        public class data
        {
            public string id { get; set; }
            public string email { get; set; }
            public string first_name { get; set; }
            public string last_name { get; set; }
        }
        public class support
        {
            public string url { get; set; }
            public string text { get; set; }
            
        }


    }
}
