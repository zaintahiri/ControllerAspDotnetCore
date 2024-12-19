using Microsoft.AspNetCore.Mvc;

namespace ControllerAspDotnetCore.Controller
{
    public class HomeController
    {
        [Route("Home")]
        [Route("/")]
        public string Index()
        {
            return "Welcome to ASP .NET CORE";
        }


        [Route("About")]
        public string About()
        {
            return "Hi, You are in About page";
        }


        [Route("Contact-us")]
        public string Contact()
        {
            return "Hi, You are in Contact page";
        }



        [Route("Product/{id:int:min(100):max(9999)}")]
        public string Product()
        {
            return "Hi, You are in Product page";
        }

    }
}
