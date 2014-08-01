namespace Api
{
    using Owin;
    using System.Web.Http;

    public class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            var HttpConfiguration = new HttpConfiguration();

            appBuilder.UseWebApi(HttpConfiguration);
        }
    }
}