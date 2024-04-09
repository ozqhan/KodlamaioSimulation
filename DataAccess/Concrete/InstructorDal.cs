using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class InstructorDal : IGenericDal<Instructor>
    {
        List<Instructor> _instructors;
        public InstructorDal()
        {
            _instructors = new List<Instructor>()
            {
                new Instructor() {Id=1,Name="Engin",LastName="Demirog"},
                new Instructor() {Id=2,Name="Halit Enes",LastName="Kalaycı"}
            };
        }
        public void Add(Instructor entity)
        {
            _instructors.Add(entity);
            Console.WriteLine("Instructor Added");
        }

        public List<Instructor> GetAll()
        {
            return _instructors;
        }

        public Instructor GetById(int id)
        {
            Instructor instructor = _instructors.FirstOrDefault(x => x.Id == id);
            if (instructor != null)
            {
                return instructor;
            }
            else
            {
                Console.WriteLine("Instructor Not Found");
                return null;
            }
        }

        public void Remove(Instructor entity)
        {
            Instructor instructor = _instructors.Where(c => c.Id == entity.Id).SingleOrDefault();
            if (instructor != null)
            {
                _instructors.Remove(instructor);
                Console.WriteLine("Instructor Removed");
            }
        }

        public void Update(Instructor entity)
        {
            Instructor instructor = _instructors.Where(c => c.Id == entity.Id).SingleOrDefault();
            if (instructor != null)
            {
                instructor.Name = entity.Name;
                instructor.LastName = entity.LastName;
                Console.WriteLine("Instructor Updated");
            }
        }
    }
}
