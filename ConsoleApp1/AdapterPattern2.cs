using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // 기존 오리 클래스
    public class OringinDuck
    {
        public void Move()
        {
            Console.WriteLine("뒤뚱!");
        }

        public void Eat()
        {
            Console.WriteLine("쪕쪕!");
        }

        public void Quack()
        {
            Console.WriteLine("꽥꽥!");
        }
    }

    // 신규료 투입된 오리 클래스
    public class NewDuck
    {
        public void NewMove()
        {
            Console.WriteLine("슈슉!");
        }

        public void NewEat()
        {
            Console.WriteLine("호로록");
        }

        public void NewQuack()
        {
            Console.WriteLine("빼애액!");
        }
    }

    // 기존 오리들을 신규 오리의 메서들로 감싸기 위한 인터페이스
    public interface INewDuck
    {
        void NewMove();
        void NewEat();
        void NewQuack();
    }

    // 기존 오리를신규 오리 인터페이스 형태로 감싸기
    public class AdapterDock : INewDuck
    {
        private readonly OringinDuck m_AdapteeOriginalDuck;

        public AdapterDock(OringinDuck adapteeOriginalDuck)
        {
            m_AdapteeOriginalDuck = adapteeOriginalDuck;
        }

        public void NewEat()
        {
            m_AdapteeOriginalDuck.Eat();
        }

        public void NewMove()
        {
            m_AdapteeOriginalDuck.Move();
        }

        public void NewQuack()
        {
            m_AdapteeOriginalDuck.Quack();
        }
    }
}
