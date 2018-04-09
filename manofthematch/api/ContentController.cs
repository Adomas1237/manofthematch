using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Umbraco.Web.WebApi;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Umbraco.Core.Models;
using Umbraco.Core;
using Umbraco.Web;

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
            var content = cs.GetById(1091);
            
            dynamic obj = new JObject();

            //example place

            //nesting content
            //obj.key2 = "value2";
            //obj.key1 = new JObject
            //{
            //    {"key3", "asdaddd" }
            //};
            //obj.key1.key3 = new JObject
            //{
            //    {"key4", "dddddd" }
            //};
            //result.Name = item.GetValue("imagepost");


            //getting images
            //var j = item.GetValue<Udi>("imagepost");
            //var smt = Umbraco.GetIdForUdi(j);
            //var umbHelper = new UmbracoHelper(UmbracoContext.Current);
            //var k = umbHelper.Media(smt);
            //result.Name = k.Url;
            
            //looping children of sports node
            //foreach (var item in content)
            //{   
            //    var j 
                //obj.key = j;
            
           

                
            //}


            string output = JsonConvert.SerializeObject(content);


            return output;

           
        }
      
        public class result
        {
         
         
            public object Name { get; set; }
         
        }
    }
}