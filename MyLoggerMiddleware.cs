using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppFunc = System.Func<System.Collections.Generic.IDictionary<string, object>, System.Threading.Tasks.Task>;

namespace AngularNancySample
{
    public class MyLoggerMiddleware
    {
        private AppFunc _next;
        public MyLoggerMiddleware(AppFunc next)
        {
            _next = next;
        }

        public async Task Invoke(IDictionary<string, object> environment)
        {
            Console.WriteLine("Begin Request");
            await _next.Invoke(environment);
            Console.WriteLine("End Request");
        }
    }
}
