using Owin;

namespace AngularNancySample
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseNancy();
            //app.Use(typeof (MyLoggerMiddleware));
        }
    }
}