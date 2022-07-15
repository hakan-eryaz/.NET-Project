using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDal _blogDal;
public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public void AddBlog(Blog blog)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetAllBlogs()
        {
            return _blogDal.GetAll();
        }

        public Blog GetBlog(int id)
        {
            throw new NotImplementedException();
        }
        public List<Blog>GetBlogByID(int id)
        {
            return _blogDal.List(x=>x.BlogID == id);
        }
        public List<Blog> GetBlogListWithCategory()
        {
            return _blogDal.GetListWithCategory();
        }

        public void RemoveBlog(Blog blog)
        {
            throw new NotImplementedException();
        }

        public void UpdateCategory(Blog blog)
        {
            throw new NotImplementedException();
        }
    }
}
