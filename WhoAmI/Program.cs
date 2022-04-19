using System;

namespace WhoAmI
{
    class Program
    {
        static void Main(string[] args)
        {
            Call Mary = new Call() { m_name = "Mary", m_age = 18 };
            Call Cindy = new Call() { m_name = "Cindy", m_age = 28 };

           

            Console.WriteLine("想認識Mary請輸入1，想認識Cindy請輸入2，交換兩人身分請輸入3");

            while(true)
            {
                char m_customInput = Console.ReadKey(true).KeyChar;

                Console.WriteLine("你輸入的是" + m_customInput);

                if (m_customInput == '1')
                {
                    Console.WriteLine("呼叫Mary");
                    Console.WriteLine();
                    Mary.WhoAmI();
                }

                else if (m_customInput == '2')
                {
                    Console.WriteLine("呼叫Cindy");
                    Console.WriteLine();
                    Cindy.WhoAmI();
                }

                else if (m_customInput == '3')
                {
                    Call m_holder = Mary;
                    Mary = Cindy;
                    Cindy = m_holder;

                    Console.WriteLine("天靈靈，地靈靈，交換兩人身分!!");
                }

                else return;
                Console.WriteLine();
            }

            
        }
    }
}
