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
        public IHttpActionResult Add()
        {
            IBusiness<Student> business = new StudentBusiness();
            var result = business.Add(new Student());
            return Ok(result);
        }

        [HttpGet]
        public IEnumerable<Student> Get()
        {
            IBusiness<Student> business = new StudentBusiness();
            var result = business.Get(new Student());
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
