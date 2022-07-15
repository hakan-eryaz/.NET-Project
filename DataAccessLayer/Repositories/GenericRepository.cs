﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        Context c = new Context();
        public void Delete(T item)
        {
            c.Remove(item);
            c.SaveChanges();

        }

        public T Get(int id)
        {
            return c.Set<T>().Find(id);
        }

        public List<T> GetAll()
        {
            return c.Set<T>().ToList();
        }

        public void Insert(T item)
        {
            c.Add(item);
            c.SaveChanges();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return c.Set<T>().Where(filter).ToList();
        }

        public void Update(T item)
        {
            c.Update(item);
            c.SaveChanges();
        }
    }
}
