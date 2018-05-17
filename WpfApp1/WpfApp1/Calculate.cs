using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Calculate
    {
        public float a { get; set; }
        public float b { get; set; }
        public char ch { get; set; }
        public float c { get; set; }
      public float Return_Res()
        {
            switch(ch)
            {
                case '+':
                    c = a + b;
                    break;
                case '-':
                    c = a - b;
                    break;
                case '*':
                    c = a * b;
                    break;
                case '/':
                    c = a / b;
                    break;
                case '=':
                    return c;
                    break;
                   
            }
            return 0;
        }
    }
}
