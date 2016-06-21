using System;
using System.Runtime.InteropServices.ComTypes;
using Nancy;

namespace AngularNancySample.Modules
{
    public class IndexModule : NancyModule
    {
        public IndexModule()
        {
            Before += ctx =>
            {
                Console.WriteLine("Inside indexmodule before pipeline.");
                return null;
            };

            After += ctx =>
            {
                Console.WriteLine("Inside indexmodule after pipeline.");
                //return null;
            };

            Get["/"] = parameters =>
            {
                return View["index"];
            };

        }
    }
}