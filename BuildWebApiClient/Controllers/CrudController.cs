using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BuildWebApiClient.Controllers
{
    public class CrudController : ApiController
    {
        // GET api/values
        [HttpGet]
        public string Get()
        {

            //code here to write get api
            return null;
        }

        // GET api/values/5
        [HttpGet]
        public string Get(int id)
        {
            //code here to write get api by id
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
            //code here for post api 
        }

        // PUT api/values/5
        [HttpPut]
        public void Put(int id, [FromBody]string value)
        {
            //code here for put api
        }

        // DELETE api/values/5
        [HttpDelete]
        public void Delete(int id)
        {
           //Code here to delete
        }

        [HttpPatch]
        public void Patch(int id,[FromBody]string value)
        {

            //code here to patch api
        }

    }
}
