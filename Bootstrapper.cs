using System;
using Nancy;
using Nancy.Bootstrapper;
using Nancy.TinyIoc;

namespace AngularNancySample
{
    public class Bootstrapper : DefaultNancyBootstrapper
    {
        // The bootstrapper enables you to reconfigure the composition of the framework,
        // by overriding the various methods and properties.
        // For more information https://github.com/NancyFx/Nancy/wiki/Bootstrapper


        protected override void ApplicationStartup(TinyIoCContainer container, IPipelines pipelines)
        {
            pipelines.BeforeRequest += async (ctx, token) =>
            {
                Console.WriteLine("Before request.");
                return null;
            };

            pipelines.AfterRequest += (ctx) =>
            {
                Console.WriteLine("After request.");
                //return ctx.Response;
            };
        }

        protected override void RequestStartup(TinyIoCContainer requestContainer, IPipelines pipelines, NancyContext context) { }
    }
}