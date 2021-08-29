using OdeToStudy.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToStudy.Data.Services
{
    public class OdeToStudyDbContext: DbContext
    {
        public DbSet<Books> MyBooks { get; set; }
    }
}
