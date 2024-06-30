using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    internal class Class1
    {
        Random random = new Random();
        string[] oblect = { "к", "н", "б" };
        static Class1 instance;
        string str;
        public string Str { get; private set; }

        public static Class1 getInstance()
        {
            if (instance == null)
                instance = new Class1();
            return instance;
        }
        public string rnd()
        {
            str = oblect[random.Next(oblect.Length)];
            return str;
        }
        int i=0,pc=0;
        public string Schet(string str1)
        {
            if (str == str1)
                return $"{i}:{pc}";
            else
            {
                if (str == "к")
                    if (str1 == "б") i++;
                    else pc++;
                else if (str == "н")
                    if (str1 != "б") i++;
                    else pc++;
                else
                    if (str1 != "н") i++;
                else pc++;
            }
            return $"{i}:{pc}";
        }
    }
}
