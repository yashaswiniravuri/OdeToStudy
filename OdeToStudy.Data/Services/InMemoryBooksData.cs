﻿using OdeToStudy.Data.Models;
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
                new Books{ID=1, Name="Newton Laws", Subject=SubjectType.Physics},
            };
        }
        public IEnumerable<Books> GetAll()
        {
            return MyBooks.OrderBy(r => r.ID);
        }
    }
}