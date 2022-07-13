using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBlogService
    {
        void AddBlog(Blog blog);
        void RemoveBlog(Blog blog);
        void UpdateCategory(Blog blog);
        List<Blog> GetAllBlogs();
        Blog GetBlog(int id);
    }
}
