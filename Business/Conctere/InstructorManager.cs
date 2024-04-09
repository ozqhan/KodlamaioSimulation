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
    public class InstructorManager : IGenericService<Instructor>
    {
        private IGenericDal<Instructor> _genericDal;
        public InstructorManager(IGenericDal<Instructor> genericDal)
        {
            _genericDal = genericDal; ;
        }
        public void Add(Instructor item)
        {
            _genericDal.Add(item);
        }

        public List<Instructor> GetAll()
        {
            return _genericDal.GetAll();
        }

        public Instructor GetById(int id)
        {
            return _genericDal.GetById(id);
        }

        public void Remove(Instructor item)
        {
            _genericDal.Remove(item);
        }

        public void Update(Instructor item)
        {
            _genericDal.Update(item);
        }
    }
}
