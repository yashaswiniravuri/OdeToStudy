using OdeToStudy.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToStudy.Data.Services
{
    public class SqlBooksData : IBooksData
    {
        private readonly OdeToStudyDbContext db;
        public SqlBooksData(OdeToStudyDbContext db)
        {
            this.db = db;
        }
        public void Add(Books b)
        {
            db.MyBooks.Add(b);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var b = db.MyBooks.Find(id);
            db.MyBooks.Remove(b);
            db.SaveChanges();
        }

        public Books Get(int id)
        {
            return db.MyBooks.FirstOrDefault(r=>r.ID==id);
        }
        public IEnumerable<Books> GetAll()
        {
            return db.MyBooks;
        }

        public void Update(Books b)
        {
            var entry = db.Entry(b);
            entry.State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
