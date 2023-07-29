﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_HW
{
    internal class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public  double? Price { get; set; }

        public override string ToString()
        {
            return $"{Id} {Title} {Description} {Price}";
        }
    }
}
