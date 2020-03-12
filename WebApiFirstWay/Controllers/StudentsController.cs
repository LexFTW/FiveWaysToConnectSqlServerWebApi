using System.Collections.Generic;
using System.Web.Http;
using FirstWay.Business.Layer;
using FirstWay.Common;
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
            var result = business.Get(new Student());
            return result;
        }

        [HttpGet]
        [Route("api/students/{id}")]
        public IEnumerable<Student> Get([FromUri] int id)
        {
            IBusiness<Student> business = new StudentBusiness();
            Student student = new Student();

            student.StudentId = id;

            var result = business.Get(student);
            return result;
        }

        [HttpPut]
        public IHttpActionResult Update()
        {
            IBusiness<Student> business = new StudentBusiness();
            var result = business.Update(new Student());
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
