using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void AddCategory(Category category)
        {
            Console.Write("Add");
        }

        public List<Category> GetAllCategories()
        {

            return _categoryDal.GetAll().ToList();
        }

        public Category GetCategory(int id)
        {
            return _categoryDal.Get(id);
        }

        public void RemoveCategory(Category category)
        {
            Console.Write("Add");
        }

        public void UpdateCategory(Category category)
        {
            Console.Write("Add");
        }
    }
}
