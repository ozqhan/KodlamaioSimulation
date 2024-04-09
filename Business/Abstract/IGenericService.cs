﻿using DataAccess.Abstract;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IGenericService<T> where T : class, IEntity, new()
    {
        List<T> GetAll();
        void Add(T item);
        void Remove(T item);
        void Update(T item);
        T GetById(int id);
    }
}