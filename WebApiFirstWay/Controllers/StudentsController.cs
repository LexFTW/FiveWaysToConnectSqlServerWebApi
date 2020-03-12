using System.Collections.Generic;
using System.Web.Http;
using FirstWay.Business.Layer;
using FirstWay.Common.Layer;

namespace WebApiFirstWay.Controllers
{
    public class StudentsController : ApiController
    {

        [HttpPost]
        [Route("api/students/{name}/{surname}")]
        public IHttpActionResult Add([FromUri] string name, [FromUri] string surname)
        {
            IBusiness<Student> business = new StudentBusiness();
            Student student = new Student();

            student.Name = name;
            student.Surname = surname;

            var result = business.Add(student);
            return Ok(result);
        }

        [HttpGet]
        public IEnumerable<Student> Get()
        {
            IBusiness<Student> business = new StudentBusiness();
            var result = business.Get();
            return result;
        }

        [HttpGet]
        [Route("api/students/{id}")]
        public Student Get([FromUri] int id)
        {
            IBusiness<Student> business = new StudentBusiness();

            var result = business.Get(id);
            return result;
        }

        [HttpPut]
        [Route("api/students/{id}/{name}/{surname}/{age}")]
        public IHttpActionResult Update([FromUri] int id, [FromUri] string name, [FromUri] string surname, [FromUri] int age)
        {
            IBusiness<Student> business = new StudentBusiness();
            Student student = new Student();

            student.StudentId = id;
            student.Name = name;
            student.Surname = surname;
            student.Age = age;

            var result = business.Update(student);
            return Ok(result);
        }

        [HttpDelete]
        public IHttpActionResult Delete()
        {
            IBusiness<Student> business = new StudentBusiness();
            var result = business.Delete(new Student());
            return Ok(result);
        }
    }
}
