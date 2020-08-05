using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPISample.Utils
{
    public class DataModel
    {
        public string Count { get; set; }
        public List<Object> List { get; set; }
        public Object Data { get; set; }
        public string ErrMessage { get; set; }
        public int ErrNumber { get; set; }

        public DataModel()
        {
            Count = "0";
            List = new List<object>();
            Data = new object();
            ErrMessage = "";
            ErrNumber = 0;
        }
    }
}