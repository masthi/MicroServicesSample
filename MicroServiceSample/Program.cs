using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MicroService4Net;
using System.Web.Http;
using MicroService4Net.ServiceInternals;
namespace MicroServiceSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var microservice = new MicroService();
            microservice.Run(args);
        }

    }
    public class ExampleController:ApiController
    {
        [Route("Example")]
        public string GetExample()
        {
            return "Example";
        }
    }
    public class MicroServiceInstaller : ProjectInstaller { }
    public class MicroSerivceService : InternalService { }
}
