﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto31.Entities
{
    internal class Department
    {
        public string Name { get; set; }

        public Department()
        {
            Name = string.Empty;
        }

        public Department(string name)
        {
            Name = name;
        }
    }
}
