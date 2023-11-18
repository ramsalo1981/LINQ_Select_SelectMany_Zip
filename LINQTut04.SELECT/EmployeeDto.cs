﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQTut04.SELECT
{
    internal class EmployeeDto
    {
        public string? Name { get; set; }
        public int TotalSkills { get; set; }


        public override string ToString()
        {
            return $"{Name} ({TotalSkills})";
        }
    }
}
