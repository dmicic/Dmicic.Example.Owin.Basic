using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Dmicic.Example.Owin.Basic.Web
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            /*app.UseHandlerAsync((request, response) => 
            {
                response.ContentType = "text/plain";
                return response.WriteAsync("Hello world " + DateTime.Now.ToString()  + " !");
            });
            */

            var config = new HttpConfiguration();
            config.Routes.MapHttpRoute(name: "Default API", routeTemplate: "{controller}");
            app.UseWebApi(config);
        }
    }

    public class HelloWorldController : ApiController
    {
        public string[] Get()
        { 
            return new string[] { "Hello", "World", DateTime.Now.ToString() };
        }
    }
}