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
    public class EfCategoryRepository : ICategoryDal
    {
        Context c = new Context();
        public void AddCategory(Category category)
        {
            c.Add(category);
            c.SaveChanges();
        }

        public void Delete(Category item)
        {
            throw new NotImplementedException();
        }

        public Category Get(int id)
        {
            return c.Categories.Find(id);
        }

        public List<Category> GetAll()
        {
            return c.Categories.ToList();
        }

        public List<Category> GetCategories()
        {
            return  c.Categories.ToList();
        }

        public Category GetCategory(int id)
        {
            return c.Categories.Find(id);
        }

        public void Insert(Category item)
        {
            c.Add(item);
            c.SaveChanges();
        }

        public void RemoveCategory(Category category)
        {
            c.Remove(category);
            c.SaveChanges();
        }

        public void Update(Category item)
        {
            c.Update(item);
            c.SaveChanges();
        }

        public void UpdateCategory(Category category)
        {
            c.Update(category);
            c.SaveChanges();
        }
    }
}
