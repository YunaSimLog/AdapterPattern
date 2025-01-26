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

    /// <summary>
    /// Adaptee : 클라이언트에서 사용하고 싶은 기존의 서비스 (하지만 호한이 안되서 바로 사용 불가능)
    /// </summary>
    class Service
    {
        // 서비스에 사용할 메소드
        public void SpecificMethod(int specialData)
        {
            Console.WriteLine($"기존 서비스 기능 호출 {specialData}");
        }
    }
}
