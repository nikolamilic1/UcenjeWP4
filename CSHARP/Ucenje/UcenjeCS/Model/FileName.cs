﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.Model
{
    internal class FileName:Entitet
    {
        public  string? Naziv { get; set; }
        public int? Trajanje  { get; set; }
        public float? Cijena { get; set; }
        public DateTime? IzvodiSeOd { get; set; }
        public bool? Verificiran { get; set; }


    }
}