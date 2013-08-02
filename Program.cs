using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CLR_Profiler_Test
{
    struct Node
    {
        int data;
        static Node node;
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100000; i++)
            {
                MySimpleType obj = new MySimpleType();
            }

            List<MySimpleType> ints = new List<MySimpleType>();
            for (int i = 0; i < 100000; i++)
            {
                ints.Add(new MySimpleType());
            }

            int count = ints.Count;


            Thread.Sleep(1000);

            for (int i = 0; i < count; i++)
            {
                ints[i] = ints[i];
            }
        }
    }

    class MySimpleType
    {
        public MySimpleType()
        {
            for (int i = 0; i < 100; i++)
            {
                object obj = new object();
            }
        }
    }
}
