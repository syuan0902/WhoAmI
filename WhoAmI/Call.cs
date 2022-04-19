using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhoAmI
{
    class Call
    {
        public string m_name;
        public int m_age;

        public void WhoAmI()
        {
            Console.WriteLine("我是" + m_name);
            Console.WriteLine("我今年" + m_age + "歲");
        }

        public void HearMessage(string message, Call whoSaidIt)
        {
            Console.WriteLine(m_name + " 收到一個訊息");
            Console.WriteLine(whoSaidIt.m_name + " 說：" + message);
        }

        public void SpeakTo(Call whoToTalkTo, string message) 
        {
            whoToTalkTo.HearMessage(message, this);
        }
    }
}
