﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClienteDotNet.Models.DTO
{
    public class Note
    {
        public int id { get; set; }
        public string title { get; set; }
        public string body { get; set; }
    }
}