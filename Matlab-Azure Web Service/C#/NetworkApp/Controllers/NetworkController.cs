
using System.Web.Http;
using System.Web.Http.Cors;

namespace NetworksApp.Controllers
{
    public class NetworkController : ApiController
    {
        [HttpGet]
        [EnableCors(origins: "*", headers: "*", methods: "*" )]
        public IHttpActionResult Simple(double num1, double num2, double num3, double num4){
            double X = num1;
            double Y = num2;
            double pY = num3;
            double pXY = num4;
            double newY = pXY * X + pY * Y;
            return Ok(newY);
        }
    }
}
