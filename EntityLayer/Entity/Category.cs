﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entity
{
    public class Category
    {
       
            [Key]
            public int CategoryId { get; set; }
            public string Name { get; set; }
            public bool Status { get; set; }


        
    }
}
