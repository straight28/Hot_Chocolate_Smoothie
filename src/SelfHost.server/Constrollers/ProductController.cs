using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace SelfHost.server.Constrollers
{
    public class ProductController : ApiController
    {
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2", "value4", "value3" };

        }
    }
}
