namespace Api.ApiControllers
{
    using System;
    using System.Collections.Generic;
    using System.Web.Http;

    public class HomeController : ApiController
    {
        public IList<int> Get()
        {
            var result = new List<int>();
            var random = new Random();
            var array = random.Next();

            for (int i = 0; i < array; i++)
            {
                result.Add(random.Next());
            }

            return result;
        }
    }
}
