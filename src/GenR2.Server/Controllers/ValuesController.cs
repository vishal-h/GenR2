using GenR2.DAL.Command;
using System.Collections.Generic;
using System.Web.Http;

namespace GenR2.Server.Controllers
{
    public class ValuesController : ApiController
    {
        TestCommand cmd;
        public ValuesController(TestCommand cmd)
        {
            this.cmd = cmd;
        }
        // GET api/values 
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2", cmd.Message };
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
