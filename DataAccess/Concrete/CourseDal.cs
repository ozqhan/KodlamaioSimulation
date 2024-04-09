using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class CourseDal : IGenericDal<Course>
    {
        List<Course> _courses;
        public CourseDal()
        {
            _courses = new List<Course>()
            {
                new Course()
                {
                    Id = 1,
                    CategoryId = 1,
                    InstructorId = 1,
                    Name="C# + Angular",
                    ImageUrl="ang.jpg",
                    Description="Yazilim Gelistirme"
                },
                new Course()
                {
                    Id= 2,
                    CategoryId = 2,
                    InstructorId = 2,
                    Name="Java + React ",
                    ImageUrl="rct.jpg",
                    Description="Yazilim Gelistirme"
                },
                new Course()
                {
                    Id=3,
                    CategoryId = 3,
                    InstructorId = 3,
                    Name="C#",
                    ImageUrl="c.jpg",
                    Description="Yazilim Gelistirme"
                },
                new Course()
                {
                    Id=4,
                    CategoryId = 4,
                    InstructorId = 4,
                    Name="JavaScript",
                    ImageUrl="js.jpg",
                    Description="Yazilim Gelistirme"
                },
                new Course()
                {
                    Id=5,
                    CategoryId = 5,
                    InstructorId = 5,
                    Name="Python",
                    ImageUrl="py.jpg",
                    Description="Yazilim Gelistirme"
                },
                new Course()
                {
                    Id=6,
                    CategoryId = 6,
                    InstructorId = 6,
                    Name="Senior .Net",
                    ImageUrl="net.jpg",
                    Description="Yazilim Gelistirme"
                },
                new Course()
                {
                    Id =7,
                    CategoryId = 7,
                    InstructorId = 7,
                    Name="Java ",
                    ImageUrl="java.png",
                    Description="Yazilim Gelistirme"
                },
                new Course()
                {
                    Id=8,
                    CategoryId = 8,
                    InstructorId = 8,
                    Name="Programlamaya Giris",
                    ImageUrl="prog.jpg",
                    Description="Yazilim Gelistirme"
                }

            };
        }

        public void Add(Course entity)
        {
            _courses.Add(entity);
            Console.WriteLine("Course Added");
        }

        public List<Course> GetAll()
        {
            return _courses;
        }

        public Course GetById(int id)
        {
            Course course = _courses.FirstOrDefault(c => c.Id == id);
            if (course != null)
            {
                return course;
            }
            else
            {
                Console.WriteLine("Course Not Found");
                return null;
            }
        }

        public void Remove(Course entity)
        {
            Course course = _courses.Where(c => c.Id == entity.Id).FirstOrDefault();
            if (course != null)
            {
                _courses.Remove(entity);
                Console.WriteLine("Course Removed");
            }
        }

        public void Update(Course entity)
        {
            Course course = _courses.Where(c => c.Id == entity.Id).SingleOrDefault();
            if (course != null)
            {
                course.Name = entity.Name;
                course.CategoryId = entity.CategoryId;
                course.Id = entity.Id;
                course.InstructorId = entity.InstructorId;
                course.Description = entity.Description;
                course.ImageUrl = entity.ImageUrl;
                Console.WriteLine("Course Updated");
            }
        }
    }
}
