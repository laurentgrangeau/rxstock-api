namespace Api
{
    using Owin;
    using System;

    public class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            appBuilder.Run(async context =>
            {
                context.Response.ContentType = "text/plain";

                await context.Response.WriteAsync("Assemblies in AppDomain:" + Environment.NewLine);
                foreach (var asm in AppDomain.CurrentDomain.GetAssemblies())
                {
                    await context.Response.WriteAsync(asm.FullName + Environment.NewLine);
                }
                await context.Response.WriteAsync(Environment.NewLine);

                await context.Response.WriteAsync("Stack trace:" + Environment.NewLine);
                await context.Response.WriteAsync(Environment.StackTrace);
            });
        }
    }
}