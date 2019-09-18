using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_and_Events
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] _ArrayList = new int[4];
            ArrayList list = new ArrayList();

            _ArrayList[0] = 1;
            _ArrayList[1] = 2;
            _ArrayList[2] = 3;
            _ArrayList[3] = 4;

            
            for (int i = 0; i < _ArrayList.Length; i++)
            {
                Console.WriteLine(_ArrayList[i]);
            }

            Console.WriteLine(" ");
            list.Add(_ArrayList, 5);
            Console.ReadKey();
            Console.WriteLine(" ");
            list.Add(_ArrayList, 6);
            Console.ReadKey();
            Console.WriteLine(" ");
            list.Add(_ArrayList, 7);
            Console.ReadKey();
        }
    }
}
