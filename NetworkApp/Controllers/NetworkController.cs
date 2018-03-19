
using System.Web.Http;
using System.Web.Http.Cors;

namespace NetworksApp.Controllers
{
    public class NetworkController : ApiController
    {
        [HttpGet]
        [EnableCors(origins: "*", headers: "*", methods: "*" )]
        public IHttpActionResult Add(double xpro, double ypro, double pxy, double py){
            double sum = xpro + ypro + pxy + py;
            return Ok(sum);
        }
    }
}
