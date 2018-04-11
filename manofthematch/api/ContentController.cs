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
            var content = cs.GetChildren(1076);
            
            dynamic obj = new JObject();
            int i = 0;
           foreach( var item in content)
            {
                var j = item.GetValue<Udi>("imagepost");
                var smt = Umbraco.GetIdForUdi(j);
                var umbHelper = new UmbracoHelper(UmbracoContext.Current);
                var k = umbHelper.Media(smt);
                obj["sport"+i] = new JObject
                {
                    { "SportName", item.GetValue<string>("namesport")  },
                    { "SportPic", k.Url },

                };
                i++;
            }

            var output = JsonConvert.SerializeObject(obj);

           

            return output;

           
        }
      
        public class result
        {
            public int Id { get; set; }
            public string key { get; set; }

            public object Name { get; set; }
         
        }
    }
}
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

//get the players from player picker
//make the selected players neat, egzample "8676e6d1b9134bc3823ea5242f5d63e3"
//var j = content.GetValue<string>("playerpicker");

//string[] tokens = j.Split(',');
//var token = tokens[1].Replace("umb://document/","");


////get all players
//var temp = cs.GetChildren(1088);

//foreach (var item in temp)
//{
//    var id = item.Id;
//    var key = item.Key.ToString();
//    key = key.Replace("-", "");
//    result.Id = id;
//    result.key = key;
//}

//var hij = 0;           
//var root = token;
//var root2 = result.key;

//bool result1 = root.Equals(root2);
//int comparison = root.CompareTo(root2);
//result1 = root.Equals(root2, StringComparison.Ordinal);
//if (result1 == true)
//{
//    hij = result.Id;
//}

//var smt = cs.GetById(hij);
