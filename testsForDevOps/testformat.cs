using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testsForDevOps
{
    class BrokenClass
    {
        void MyMethod()
        {
        }
    }
    public class BrokenClass2
    {
        private void MyMethod()
        {
        }
    }

    public class FormatBreak
    {
        public void Test()
        {
            Console.WriteLine("Hi");
        }
    }
}
