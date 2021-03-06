﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SubProject
{
    public class TitleBasics
    {

        public string Id { get; set; }
        public string TitleType { get; set; }
        public string PrimaryTitle { get; set; }
        public string OriginalTitle { get; set; }
        public bool IsAdult { get; set; }
        public string StartYear { get; set; }
        public string EndYear { get; set; }
        public int RuntimeMinutes { get; set; }
        public string Genres { get; set; }

        public override string ToString()
        {
            return $"Id = {Id}, PrimaryTitle = {PrimaryTitle}";
        }
    }
}
