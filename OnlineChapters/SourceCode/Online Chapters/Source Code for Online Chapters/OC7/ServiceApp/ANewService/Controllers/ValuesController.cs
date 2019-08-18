using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ANewService.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        //// GET api/values
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/values/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return id.ToString();
        //}

        [HttpGet("{values}")]
        public string Get(string values)
        {
            // Split the input values for parsing.
            string[] inputs = values.Split('&');

            // Verify that the input contains the right
            // number of values.
            if (inputs.Length != 2)
                return values;

            // Parse the input values into numbers.
            int value1 = 0;
            int value2 = 0;

            try
            {
                value1 = Int32.Parse(inputs[0]);
                value2 = Int32.Parse(inputs[1]);
            }
            catch (System.FormatException ex)
            {
                return values;
            }

            // Add the values together and return a result.
            string result = (value1 + value2).ToString();
            return result;
        }

        //// POST api/values
        //[HttpPost]
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
