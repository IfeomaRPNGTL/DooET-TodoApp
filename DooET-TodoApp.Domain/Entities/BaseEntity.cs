﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DooET_TodoApp.Domain.Entities
{
    public class BaseEntity
    {
        public DateTime CreateDate { get; set; } 
        public DateTime UpdateDate { get; set; }  
    }
}
