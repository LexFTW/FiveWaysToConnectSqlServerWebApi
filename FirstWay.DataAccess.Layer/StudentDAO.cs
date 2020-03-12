using System;
using System.Collections.Generic;
using FirstWay.Common.Layer;
using FirstWay.DataAccess.Layer.Interfaces;

namespace FirstWay.DataAccess.Layer
{
    public class StudentDao : IRepository<Student>
    {
        public Student Create(Student model)
        {
            return model;
        }

        public bool Delete(Student model)
        {
            return true;
        }

        public IEnumerable<Student> GetAll(Student model)
        {
            var students = new List<Student>();
            students.Add(model);
            return students;
        }

        public Student GetById(int id)
        {
            return new Student();
        }

        public Student Update(int id, Student model)
        {
            return model;
        }
    }
}
