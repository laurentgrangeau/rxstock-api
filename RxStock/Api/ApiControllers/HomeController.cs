namespace Api.ApiControllers
{
    using System.Collections.Generic;
    using System.Web.Http;

    public class HomeController : ApiController
    {
        public IList<string> Get()
        {
            return new List<string>
            {
                "1",
                "2",
                "3"
            };
        }
    }
}
