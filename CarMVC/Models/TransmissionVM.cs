﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarMVC.Models
{
    public class TransmissionVM:Service
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        [StringLength(12, MinimumLength = 5)]
        public string Name { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }

    }
}
