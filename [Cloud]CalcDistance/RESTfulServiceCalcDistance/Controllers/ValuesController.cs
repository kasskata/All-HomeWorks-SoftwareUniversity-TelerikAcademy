using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CalcDistance;

namespace RESTfulServiceCalcDistance.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public float Get(int aX, int aY, int bX, int bY)
        {
            Point a = new Point { X = aX, Y = aY };
            Point b = new Point { X = bX, Y = bY };

            float deltaX = a.X - b.X;
            float deltaY = a.Y - b.Y;

            return (float)Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
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
