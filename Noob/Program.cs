using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noob
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenhgt = 10;
            int[] arr = new int[lenhgt];

            for (int i = 0; i < 10; i++) {
                arr[i] = i;
                Console.Write(arr[i]);
                
            }


                Console.ReadKey();
        }
    }
}
