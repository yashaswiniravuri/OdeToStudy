using OdeToStudy.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OdeToStudy.Data.Services
{
    
    public class InMemoryBooksData : IBooksData
    {
        List<Books> MyBooks;
        public InMemoryBooksData()
        {
            MyBooks=new List<Books>()
            {
                new Books{ID=1, Name="Algebra", Subject=SubjectType.Maths},
                new Books{ID=2, Name="Respiration", Subject=SubjectType.Biology},
                new Books{ID=3, Name="Organic chemistry", Subject=SubjectType.Chemistry},
                new Books{ID=4, Name="Calculus", Subject=SubjectType.Maths},
                new Books{ID=5, Name="Verb forms", Subject=SubjectType.English},
                new Books{ID=6, Name="Newton Laws", Subject=SubjectType.Physics},
            };
        }

        public Books Get(int id)
        {
            return MyBooks.FirstOrDefault((r => r.ID == id));
        }

        public IEnumerable<Books> GetAll()
        {
            return MyBooks.OrderBy(r => r.ID);
        }
        public void Add(Books b)
        {
            MyBooks.Add(b);
            b.ID = MyBooks.Max(r => r.ID)+1;
        }
        public void Update(Books b)
        {
            var data = Get(b.ID);
            if(data != null)
            {
                data.Name = b.Name;
                data.Subject = b.Subject;
            }
        }

        public void Delete(int id)
        {
            var b = Get(id);
            if (b != null)
            {
                MyBooks.Remove(b);
            }
        }
    }
}