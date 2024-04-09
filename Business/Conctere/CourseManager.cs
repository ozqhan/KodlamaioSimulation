using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Conctere
{
    public class CourseManager : IGenericService<Course>
    {
        private IGenericDal<Course> _genericDal;
        public CourseManager(IGenericDal<Course> genericDal)
        {
            _genericDal = genericDal; ;
        }
        public void Add(Course item)
        {
            _genericDal.Add(item);
        }

        public List<Course> GetAll()
        {
            return _genericDal.GetAll();
        }

        public Course GetById(int id)
        {
            return _genericDal.GetById(id);
        }

        public void Remove(Course item)
        {
            _genericDal.Remove(item);
        }

        public void Update(Course item)
        {
            _genericDal.Update(item);
        }
    }
}
