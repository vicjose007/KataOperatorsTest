using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata2Test
{
    public class TestOp
    {
        public bool TestOperators()
        {
           bool a = true;
           bool b = true;
           bool c = true;

                if (a && b)
                {
                    Console.WriteLine(" 1 ");
                    c = false;
                }

                if (a || b)
                {
                    Console.WriteLine(" 1 ");
                    c = true;
                }
                a = false;
                b = true;

                if (a && b)
                {
                    Console.WriteLine(" 0 ");
                    c = false;
                }
                else
                {
                    Console.WriteLine(" 0 ");
                    c = false;
                }

                if (!(a && b))
                {
                    Console.WriteLine(" 1 ");
                    c = true;
                }
                  return c;
        }
    }
}