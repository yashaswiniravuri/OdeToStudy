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
        Books Get(int id);

        void Add(Books MyBooks);
        void Update(Books b);
        void Delete(int id);
    }
}
