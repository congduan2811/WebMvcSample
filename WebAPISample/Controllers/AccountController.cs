using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Script.Serialization;
using WebAPISample.Repository;

namespace WebAPISample.Controllers
{
    [RoutePrefix("api/Account")]
    public class AccountController : ApiController
    {
        [Route("Search")]
        [HttpGet]
        public System.Web.Http.Results.JsonResult<WebAPISample.Utils.DataModel> Search(string name="", int orderStart = 0, int orderfinish = 10)
        {
            var data = AccountRepository.Search(name, orderStart, orderfinish);
            JavaScriptSerializer serialize = new JavaScriptSerializer();
            return Json<WebAPISample.Utils.DataModel>(data);
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
