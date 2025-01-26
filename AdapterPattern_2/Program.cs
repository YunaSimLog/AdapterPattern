using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // -----------------------------------------------------------------------
            // * 합성(Composition) 적용 Sample
            // * 객체 어댑터 (Object Adaptor)
            Service service = new Service();
            Adapter adapter1 = new Adapter(service);
            adapter1.Method(2025);
            // -----------------------------------------------------------------------
        }
    }
}
