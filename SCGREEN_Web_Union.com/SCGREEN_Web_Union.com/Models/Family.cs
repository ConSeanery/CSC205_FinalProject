﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace SCGREEN_Web_Union.com.Models
{

    public class Family
    {
        public int id { get; set; }
        public string familyname { get; set; }
        public string address1 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string homephone { get; set; }

    }
}