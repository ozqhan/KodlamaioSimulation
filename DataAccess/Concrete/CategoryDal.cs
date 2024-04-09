using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class CategoryDal : IGenericDal<Category>
    {
        List<Category> _categories;
        public CategoryDal()
        {
            _categories = new List<Category>()
            {
                new Category(){Id=1,Name="FrontEnd"},
                new Category(){Id=2,Name="BackEnd"},
                new Category(){Id=3,Name="Data"}
            };
        }
        public void Add(Category entity)
        {
            _categories.Add(entity);
            Console.WriteLine("Category Added");
        }

        public List<Category> GetAll()
        {
            return _categories;
        }

        public Category GetById(int id)
        {
            Category category = _categories.FirstOrDefault(c => c.Id == id);
            if (category != null)
            {
                return category;
            }
            else
            {
                Console.WriteLine("Category Not Found");
                return null;
            }
        }

        public void Remove(Category entity)
        {
            Category category = _categories.FirstOrDefault(category => category.Id == entity.Id);
            if (category != null)
            {
                _categories.Remove(category);
                Console.WriteLine("Category Removed");
            }
            else
            {
                Console.WriteLine("Category Not Found");
            }
        }

        public void Update(Category entity)
        {
            Category category = _categories.Where(c => c.Id == entity.Id).SingleOrDefault();
            if (category != null)
            {
                category.Name = entity.Name;
                Console.WriteLine("Category Updated");
            }
        }
    }
}
