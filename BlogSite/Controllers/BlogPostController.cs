using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogSite.Models;

namespace BlogSite.Controllers
{
    public class BlogPostController : Controller
    {
        // GET: BlogPost
        public ActionResult AddPost ()
        {
            var blogPost = new BlogPost() { Title = "Test Title", DatePosted = DateTime.Now, Id = 1, Content = "Test Content" };

            return View(blogPost);
        }

        public ActionResult EditPost (int id)
        {
            return Content("id=" + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }
    }
}