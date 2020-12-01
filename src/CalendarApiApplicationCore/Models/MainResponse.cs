using Google.Rpc;
using System.Collections.Generic;

namespace CalendarApiApplicationCore.Models
{
    public class Dates
    {
        public int day { get; set; }
        public int month { get; set; }
    }

    public class Namedays
    {
        public string at { get; set; }
        public string bg { get; set; }
        public string cz { get; set; }
        public string de { get; set; }
        public string dk { get; set; }
        public string ee { get; set; }
        public string es { get; set; }
        public string fi { get; set; }
        public string fr { get; set; }
        public string gr { get; set; }
        public string hr { get; set; }
        public string hu { get; set; }
        public string it { get; set; }
        public string lt { get; set; }
        public string lv { get; set; }
        public string pl { get; set; }
        public string ru { get; set; }
        public string se { get; set; }
        public string sk { get; set; }
        public string us { get; set; }
    }

    public class Data
    {
        public Dates dates { get; set; }
        public Namedays namedays { get; set; }
    }
    public class Result
    {
        public int day { get; set; }
        public int month { get; set; }
        public string name { get; set; }
    }

    public class MainResponse
    {
        public string Code { get; set; }
        public IList<Result> results { get; set; }
        public Data data { get; set; }
    }

}
