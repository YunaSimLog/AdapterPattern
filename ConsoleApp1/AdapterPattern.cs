using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface ITarget
    {
        string GetRequest();
    }

    class Adaptee
    {
        public string GetSpecificRequest()
        {
            return "Specific Request";
        }
    }

    class Adapter : ITarget
    {
        private readonly Adaptee m_adaptee;

        public Adapter(Adaptee adaptee) 
        { 
            m_adaptee = adaptee;  
        }

        public string GetRequest()
        {
            return $"This is '{this.m_adaptee.GetSpecificRequest()}'";
        }
    }
}
