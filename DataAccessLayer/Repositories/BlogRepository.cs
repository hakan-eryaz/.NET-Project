using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class BlogRepository : IBlogDal
    {
        Context c = new Context();
        public void AddBlog(Blog blog)
        {
            c.Add(blog);
        }

        public Blog GetBlog(int id)
        {
           return c.Blogs.Find(id);
        }

        public List<Blog> GetBlogs()
        {
            return c.Blogs.ToList();
        }

        public void RemoveBlog(Blog blog)
        {
            c.Remove(blog);
            c.SaveChanges();

        }

        public void UpdateBlog(Blog blog)
        {
            c.Update(blog);
            c.SaveChanges();
        }
    }
}
