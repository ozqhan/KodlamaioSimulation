using Business.Abstract;
using Business.Conctere;
using DataAccess.Concrete;
using Entities.Abstract;
using Entities.Concrete;

namespace KodlamaioSimulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CategoryCrud();
            Console.WriteLine("***");
            CourseCrud();
            Console.WriteLine("***");
            IntructorCrud();
        }

        static void CategoryCrud()
        {
            IGenericService<Category> genericService = new CategoryManager(new CategoryDal());
            foreach (var item in genericService.GetAll())
            {
                Console.WriteLine(item.Id + " " + item.Name);
            }
            Console.WriteLine("***");
            Category category1 = genericService.GetById(3);
            Console.WriteLine(category1.Id + " " + category1.Name);
            Console.WriteLine("***");
            Category category2 = new Category() { Id = 4, Name = "AI" };
            genericService.Add(category2);
            foreach (var item in genericService.GetAll())
            {
                Console.WriteLine(item.Id + " " + item.Name);
            }
            Console.WriteLine("***");
            Category category3 = new Category() { Id = 2, Name = "Cloud" };
            genericService.Update(category3);
            foreach (var item in genericService.GetAll())
            {
                Console.WriteLine(item.Id + " " + item.Name);
            }
            Console.WriteLine("***");
            Category category4 = new Category() { Id = 1 };
            genericService.Remove(category4);
            foreach (var item in genericService.GetAll())
            {
                Console.WriteLine(item.Id + " " + item.Name);
            }
        }

        static void CourseCrud()
        {
            IGenericService<Course> genericService = new CourseManager(new CourseDal());
            foreach (var item in genericService.GetAll())
            {
                Console.WriteLine(item.Id + " " + item.Name + " " + item.InstructorId + " " + item.Description + " " + item.ImageUrl);
            }
            Console.WriteLine("***");
            Course course1 = genericService.GetById(3);
            Console.WriteLine(course1.Id + " " + course1.Name + " " + course1.InstructorId + " " + course1.Description + " " + course1.ImageUrl);
            Console.WriteLine("***");
            Course course2 = new Course() { Id = 9, Name = "Python", Description = "Pyhton 3.1", InstructorId = 2, ImageUrl = "py.jpg" };
            genericService.Add(course2);
            foreach (var item in genericService.GetAll())
            {
                Console.WriteLine(item.Id + " " + item.Name + " " + item.InstructorId + " " + item.Description + " " + item.ImageUrl);
            }
            Console.WriteLine("***");
            Course course3 = new Course() { Id = 2, Name = "C++", InstructorId = 4, Description = "POSIX Threads", ImageUrl = "c++.jpg" };
            genericService.Update(course3);
            foreach (var item in genericService.GetAll())
            {
                Console.WriteLine(item.Id + " " + item.Name + " " + item.InstructorId + " " + item.Description + " " + item.ImageUrl);
            }
            Console.WriteLine("***");
            Course course4 = genericService.GetById(1);
            genericService.Remove(course4);
            foreach (var item in genericService.GetAll())
            {
                Console.WriteLine(item.Id + " " + item.Name + " " + item.InstructorId + " " + item.Description + " " + item.ImageUrl);
            }
        }

        private static void IntructorCrud()
        {
            IGenericService<Instructor> genericService = new InstructorManager(new InstructorDal());
            foreach (var item in genericService.GetAll())
            {
                Console.WriteLine(item.Id + " " + item.Name + " " + item.LastName);
            }
            Console.WriteLine("***");
            Instructor instructor1 = genericService.GetById(1);
            Console.WriteLine(instructor1.Id + " " + instructor1.Name + " " + instructor1.LastName);
            Console.WriteLine("***");
            Instructor instructor2 = new Instructor() { Id = 3, Name = "Mehmet", LastName = "Özkan" };
            genericService.Add(instructor2);
            foreach (var item in genericService.GetAll())
            {
                Console.WriteLine(item.Id + " " + item.Name + " " + item.LastName);
            }
            Console.WriteLine("***");
            Instructor instructor3 = new Instructor() { Id = 2, Name = "Alan", LastName = "Turing" };
            genericService.Update(instructor3);
            foreach (var item in genericService.GetAll())
            {
                Console.WriteLine(item.Id + " " + item.Name + " " + item.LastName);
            }
            Console.WriteLine("***");
            Instructor instructor4 = genericService.GetById(1);
            genericService.Remove(instructor4);
            foreach (var item in genericService.GetAll())
            {
                Console.WriteLine(item.Id + " " + item.Name + " " + item.LastName);
            }
        }
    }
}
