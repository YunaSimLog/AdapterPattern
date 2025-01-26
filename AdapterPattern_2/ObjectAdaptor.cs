using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern_2
{
    /// <summary>
    /// <para>Adapter : Adaptee 서비스를 클라이언트에서 사용하게 할 수 있도록 호환 처리 해주는 어댑터</para>
    /// <para>객체 어댑터 / 합성하여 사용하는 방식</para>
    /// </summary>
    class Adapter : ITarget
    {
        Service _adptee; // 합성(Composition)으로 Service 객체를 클래스 필드로 사용

        public Adapter(Service adptee)
        {
            _adptee = adptee;
        }

        // 어댑터의 메소드가 호출되면, Adaptee의 메소드를 호출하도록
        public void Method(int data)
        {
            _adptee.SpecificMethod(data); // 위임
        }
    }
}
