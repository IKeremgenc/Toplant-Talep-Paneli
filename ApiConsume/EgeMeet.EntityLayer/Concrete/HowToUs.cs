﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgeMeet.EntityLayer.Concrete
{
    public class HowToUs
    {
        [Key]
        public int HowToUsid { get; set; }
        public string Title { get; set; }
        public string İcon { get; set; }
        public string smailltitle { get; set; }
        public string Description { get; set; }
    }
}
