﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Model
{
    public class Token
    {
        [PrimaryKey]
        public int Id { get; set; }
        public string access_token { get; set; }
        public string error_description { get; set; }
        public DateTime dateTime { get; set; }
        public Token() { }

    }
}
