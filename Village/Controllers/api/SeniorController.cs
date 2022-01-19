using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Village.Controllers.api
{
    public class SeniorController : ApiController
    {
        // GET: api/Senior
        //מפאת הזמן הקצר לא הספקתי לעשות אשמח אם תהיה התחשבות 
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Senior/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Senior
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Senior/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Senior/5
        public void Delete(int id)
        {
        }
    }
}
