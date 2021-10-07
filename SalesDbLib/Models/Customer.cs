﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDbLib.Models
{
    public class Customer
    {
        public int Id { get; set; }
        //attributes are surrounded by []... always affects property below it
        [StringLength(30)]
        [Required]
        public string Code { get; set; }
        //another way to insert multi attributes
        [StringLength(30), Required]
        public string Name { get; set; }
        [Column(TypeName = "decimal(11,2)")]
        public decimal Sales { get; set; }
        public DateTime Created { get; set; }
        public bool Active { get; set; }

        public Customer() { }
    }
}
