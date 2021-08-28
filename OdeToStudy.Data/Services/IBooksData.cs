using OdeToStudy.Data.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToStudy.Data.Services
{
    public interface IBooksData
    {
        IEnumerable<Books> GetAll();
    }
}
