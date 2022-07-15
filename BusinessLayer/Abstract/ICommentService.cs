using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICommentService
    {
        void AddComment(Comment comment);
       // void RemoveBlog(Blog blog);
        //void UpdateCategory(Blog blog);
        List<Comment> GetAllComments(int id);
        //Blog GetBlog(int id);
        //List<Blog> GetBlogListWithCategory();
    }
}
