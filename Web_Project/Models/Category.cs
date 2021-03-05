﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Project.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; } 
        [Required(ErrorMessage = "Kategori alanını doldurun.")]
        [StringLength(50, ErrorMessage = "Maksimum 50 karakter girebilirsiniz.")]
        public string Name { get; set; }
        public string CreateDate { get; set; }

    }
}
