using System;
using System.Collections.Generic;
using FirstWay.Common.Layer;
using FirstWay.DataAccess.Layer.Interfaces;

namespace FirstWay.DataAccess.Layer
{
    public class StudentDAO : IRepository<Student>
    {
        public Student Create(Student model)
        {
            return model;
        }

        public bool Delete(Student model)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetAll(Student model)
        {
            throw new NotImplementedException();
        }

        public Student GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Student Update(int id, Student model)
        {
            throw new NotImplementedException();
        }
    }
}
