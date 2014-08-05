namespace Api.ApiControllers
{
    using System.Collections.Generic;
    using System.Web.Http;

    public class HomeController : ApiController
    {
        public IList<int> Get()
        {
            return new List<int>
            {
                1,
                2,
                3
            };
        }
    }
}
