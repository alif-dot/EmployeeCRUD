﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace EmployeeCRUD.Models
{
    public partial class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Employee Name")]
        public string? Name { get; set; }
        public string? Designation { get; set; }

        [DataType(DataType.MultilineText)]
        public string? Address { get; set; }
        public DateTime? RecordCreatedOn { get; set; }
    }
}
