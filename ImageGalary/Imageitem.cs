﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageGalary
{
    class Imageitem
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public byte[] Base64 { get; set; }
        public string Format { get; set; }
    }
}
