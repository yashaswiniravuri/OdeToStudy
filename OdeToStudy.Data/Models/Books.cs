using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToStudy.Data.Models
{
    public class Books
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Display(Name ="subject")]
        public SubjectType Subject { get; set; }
    }
}
