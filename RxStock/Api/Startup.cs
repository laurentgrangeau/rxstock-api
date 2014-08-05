namespace Api
{
    using Owin;
    using System.Web.Http;

    public class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            var httpConfiguration = new HttpConfiguration();

            httpConfiguration.Routes.MapHttpRoute("DefaultApi", "api/{controller}/{id}", new { id = RouteParameter.Optional });
            httpConfiguration.Formatters.XmlFormatter.SupportedMediaTypes.Clear();

            appBuilder.UseWebApi(httpConfiguration);
        }
    }
}