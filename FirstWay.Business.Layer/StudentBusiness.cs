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
            IRepository<Student> repository = new StudentDAO();
            return repository.Create(model);
        }

        public List<Student> Get(Student model)
        {
            IRepository<Student> repository = new StudentDAO();
            return repository.GetAll(model);
        }
    }
}
