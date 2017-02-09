﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TripXpert.Models
{
    public class DestinationViewModel
    {
        public int DestinationID { get; set; }
        public string DefaultImage { get; set; }
        public int LowestPrice { get; set; }
        public int TestimonialID { get; set; }
        public bool IsSpecial { get; set; }
        public string Title { get; set; }
        public string[] ShortDescription { get; set; }
        public string FullDescription { get; set; }
        public short? Duration { get; set; }
        public string VideoURL { get; set; }

    }
}