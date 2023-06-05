﻿using ApplicationService.DTOs;
using ApplicationService.Implementations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarMVC.Models
{

    public class UserVM:Service
    {
        public int Id { get; set; }
        [StringLength(50)]
        [Required(ErrorMessage = "This field is required!")]
        public string Username { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        [StringLength(100)]
        public string Email { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        [StringLength(100)]
        public string Password { get; set; }
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        [StringLength(10)]
        [Required(ErrorMessage = "This field is required!")]
        public string Phone { get; set; }

        public int Town_id { get; set; }
        public IEnumerable<TownDTO> Town { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int UpdatedBy { get; set; }

     
    }
}
