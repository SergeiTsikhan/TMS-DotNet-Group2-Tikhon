﻿using System.Collections.Generic;

namespace CalendarApiApplicationCore.Models
{

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
    }

}
