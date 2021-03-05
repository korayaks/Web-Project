using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Project.Models
{
    public class Question
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        [Required(ErrorMessage = "Başlık alanını doldurun.")]
        [StringLength(50)]
        public string Title { get; set; }
        [Required(ErrorMessage = "İçerik alanını doldurun.")]
        [StringLength(1000)]
        public string Content { get; set; }
        public string SendingDate { get; set; }
    }
}
