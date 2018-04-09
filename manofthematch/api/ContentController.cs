using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Umbraco.Web.WebApi;
using Newtonsoft.Json;

namespace manofthematch.Core.Controllers.WebAPI
{
    [Route("api/[controller]")]
    public class PostsApiController : UmbracoApiController
    {
        [HttpGet]
        public string Test()
        {
            //creating an object from result class
            result result = new result();
            var cs = Services.ContentService;
            // getting children of sports
            var content = cs.GetDescendants(1076);
          
            
            //foreach (object item in content)
            //{
            //    result.Name = item;
            //}

           
            string output = JsonConvert.SerializeObject(content);


            return output;

           
        }
        public class result
        {
            public int Id { get; set; }
            public object Name { get; set; }
         
        }
    }
}