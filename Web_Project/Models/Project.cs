using Microsoft.AspNetCore.Http;
using Proje.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Project.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }

        public string UserName { get; set; }
        public string UserMail { get; set; }
        [Required(ErrorMessage = "Başlık alanını doldurun.")]
        [StringLength(50)]
        public string Title { get; set; }
        [Required(ErrorMessage = "İçerik alanını doldurun.")]
        [StringLength(1000)]
        public string Content { get; set; }
        [Required(ErrorMessage = "Bir kategori seçin.")]

        public string Category { get; set; }

        public string CreateDate { get; set; }
        public string UpdateDate { get; set; }
        [Required(ErrorMessage = "Proje durumunu seçin.")]
        public int Status { get; set; }
    }
}
