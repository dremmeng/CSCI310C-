using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW16Async
{
    class HW16Async
    {
        public async void notasync()
        {
            await Task.Delay(1000);
            await Task.Delay(1000);
            await Task.Delay(1000);
            await Task.Delay(1000);
            await Task.Delay(1000);
        }
        public async void asynctask()
        {
            var a = Task.Delay(1000);
            var b = Task.Delay(1000);
            var c = Task.Delay(1000);
            var d = Task.Delay(1000);
            var e = Task.Delay(1000);

            await a;
            await b;
            await c;
            await d;
            await e;
        }
        public static void Main()
        {
            DateTime x = DateTime.Now;
            
            new HW16Async().notasync();
            DateTime y = DateTime.Now;
            Console.WriteLine(y.Subtract(x));
            new HW16Async().asynctask();
            DateTime z = DateTime.Now;
            Console.WriteLine(z.Subtract(y));
        }
    }
}
