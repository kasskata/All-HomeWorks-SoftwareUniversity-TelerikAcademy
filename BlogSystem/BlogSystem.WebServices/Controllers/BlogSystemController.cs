using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using BlogSystem.Data;
using BlogSystem.WebServices.Models;
using ApplicationDbContext = BlogSystem.Data.ApplicationDbContext;

namespace BlogSystem.WebServices.Controllers
{
    public class BlogSystemController : ApiController
    {
        private IBlogSystemData data;

        public BlogSystemController()
            : this(new BlogSystemData(new ApplicationDbContext()))
        {
        }

        public BlogSystemController(IBlogSystemData data)
        {
            this.data = data;
        }

        public IHttpActionResult GetUsersCount()
        {
            var count = this.data.Users.All().Count();
            return this.Ok(count);
        }
    }
}