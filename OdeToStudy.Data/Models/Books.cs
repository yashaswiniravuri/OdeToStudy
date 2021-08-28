using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToStudy.Data.Models
{
    public class Books
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public SubjectType Subject { get; set; }
    }
}
