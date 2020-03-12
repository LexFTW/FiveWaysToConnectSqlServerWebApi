using System.Collections.Generic;
using FirstWay.Common.Layer;
using FirstWay.DataAccess.Layer;
using FirstWay.DataAccess.Layer.Interfaces;

namespace FirstWay.Business.Layer
{
    public class StudentBusiness : IBusiness<Student>
    {
        public Student Add(Student model)
        {
            IRepository<Student> repository = new StudentDao();
            return repository.Create(model);
        }

        public bool Delete(Student model)
        {
            IRepository<Student> repository = new StudentDao();
            return repository.Delete(model);
        }

        public IEnumerable<Student> Get(Student model)
        {
            IRepository<Student> repository = new StudentDao();
            return repository.GetAll(model);
        }

        public Student Update(Student model)
        {
            IRepository<Student> repository = new StudentDao();
            return repository.Update(1, model);
        }
    }
}
