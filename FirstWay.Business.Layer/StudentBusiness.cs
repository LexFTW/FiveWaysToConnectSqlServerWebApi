using System;
using System.Collections.Generic;
using FirstWay.Business.Layer.AM;
using FirstWay.Common.Layer;
using FirstWay.DataAccess.Layer.Interfaces;

namespace FirstWay.Business.Layer
{
    public class StudentBusiness : IoCSupported<AutofacModule>, IBusiness<Student>
    {
        private readonly IRepository<Student> repository;

        public StudentBusiness()
        {
            repository = Resolve<IRepository<Student>>();
        }

        public Student Add(Student model)
        {
            model.StudentGuid = Guid.NewGuid();
            return repository.Create(model);
        }

        public bool Delete(Student model)
        {
            return repository.Delete(model);
        }

        public IEnumerable<Student> Get()
        {
            return repository.GetAll();
        }

        public Student Get(int id)
        {
            return repository.GetById(id);
        }

        public Student Update(Student model)
        {
            return repository.Update(1, model);
        }
    }
}
