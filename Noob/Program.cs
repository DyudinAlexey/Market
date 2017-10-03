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
            Console.ForegroundColor = ConsoleColor.Green;
            #region
            //1. Составить программу вывода на экран в одну строку трех любых чисел с двумя пробелами между ними.
            
            //int oneDigit = 1;
            //int twoDigit = 2;
            //int threeDigit = 3;
            //Console.Write(oneDigit+ "  " + twoDigit + "  " + threeDigit);
            
            //2. Вывести на экран числа 5, 10 и 21 одно под другим.
            
            //int[] arr = { 5, 10, 21 };
            //for (int i = 0; i < 3; i++)
            //    Console.WriteLine(arr[i]);
            
            //3. Дано расстояние в сантиметрах. Найти число полных метров в нем.
           
            //float a = int.Parse(Console.ReadLine());
            //a = a /1000;
            //Console.WriteLine(a); 

            //4. С некоторого момента прошло 234 дня. Сколько полных недель прошло за этот период?
            
            //int a = 234 / 7;
            //Console.Write(a);

            //5. Дано двузначное число. Найти:
            //a. число десятков в нем;
            //b. число единиц в нем;
            //c. сумму его цифр;
            //d. произведение его цифр   

            /*int x = int.Parse(Console.ReadLine());
            int des = x / 10;
            int ed = x % 10;
            int sum = des + ed;
            int mult = des * ed;
            Console.WriteLine(des + " десятков");
            Console.WriteLine(ed + " единиц");
            Console.WriteLine(sum + " summa");
            Console.WriteLine(mult + " multiplication");
            */

            //6. Вычислить значение логического выражения при следующих значениях логических величин А, В и С: А = Истина, В = Ложь, С = Ложь:
            //a. А или В;
            //b. А и В;
            //c. В или С.

            /*bool A= true;
            bool B = false;
            bool C = false;

            bool a, b, c;
            a = A || B;
            b = A || B;
            c = B || C;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            */

            #endregion
            Console.ReadKey();
        }
    }
}
