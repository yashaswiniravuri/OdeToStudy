using OdeToStudy.Data.Models;
using OdeToStudy.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OdeToStudy.Api
{
    public class BooksController : ApiController
    {
        private readonly IBooksData db;

        public BooksController(IBooksData db)
        {
            this.db = db;
        }
        public IEnumerable<Books> Get() {
            var data = db.GetAll();
            return data;
        }
    }
}
