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

    }
}
