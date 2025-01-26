using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern_2
{
    /// <summary>
    /// <para>Adapter : Adaptee 서비스를 클라이언트에서 사용하게 할 수 있도록 호환 처리 해주는 어댑터</para>
    /// <para>클래스 어댑터 / 상속 받아서 사용하는 방식</para>
    /// </summary>
    class Adapter2 : Service, ITarget
    {
        // 어댑터의 메소드가 호출되면, 부모 클래스 Adaptee의 메소드를 호출
        public void Method(int data)
        {
            SpecificMethod(data);
        }
    }
}
