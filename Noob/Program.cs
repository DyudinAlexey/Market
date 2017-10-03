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
           
            //7. Даны радиус круга и сторона квадрата. У какой фигуры площадь больше?

            /*Console.WriteLine("Введите радиус окружности");
            int R = int.Parse(Console.ReadLine());
            double S = Math.PI * (R * R);
            Console.WriteLine(S + " Радиус окружности");
            Console.WriteLine("Введите сторону квадрата");
            int A = int.Parse(Console.ReadLine());
            int S_square = A * A;
            Console.WriteLine(S_square + " Площадь квадрата");
            if (S > S_square)
                Console.WriteLine("Площадь круга больше");
            else if(S == S_square)
                Console.WriteLine("Площадь одинаковая");
             else
                Console.WriteLine("Площадь квадрата больше");
            */

            //8. Даны объемы и массы двух тел из разных материалов. Материал какого из тел имеет большую плотность?

            /*Console.WriteLine("Введите массу и объем первого тела");
            int M_one = int.Parse(Console.ReadLine());
            int V_one = int.Parse(Console.ReadLine());
            int P_one = M_one / V_one;
            Console.WriteLine(P_one + "кг/м^3 Плотность первого");

            Console.WriteLine("Введите массу и объем второго тела");
            int M_two = int.Parse(Console.ReadLine());
            int V_two = int.Parse(Console.ReadLine());
            int P_two = M_two / V_two;
            Console.WriteLine(P_two + "кг/м^3 Плотность второго");

            if (P_one > P_two)
                Console.WriteLine(" Плотность первого больше");
            else if (P_one == P_two)
                Console.WriteLine("Плотность одинаковая");
            else
                Console.WriteLine("Плотность второго больше");
            */
            //9. Известны сопротивления двух несоединенных друг с другом участков электрической 
            //цепи и напряжение на каждом из них. По какому участку протекает меньший ток?

            /*
            Console.WriteLine("Введите сопротивление и напряжение первого участка");
            int R_one = int.Parse(Console.ReadLine());
            int U_one = int.Parse(Console.ReadLine());
            int I_one = U_one / R_one;
            Console.WriteLine("Введите сопротивление и напряжение второго участка");
            int R_two = int.Parse(Console.ReadLine());
            int U_two = int.Parse(Console.ReadLine());         
            int I_two = U_two / R_two;

            if (I_one < I_two)
                Console.WriteLine(" По первому участку протекает меньший ток");
            else if (I_one > I_two)
                Console.WriteLine(" По второму участку протекает меньший ток");
            else
                Console.WriteLine("Ток одинаковый");
            */
            
            
            //10. Напечатать "столбиком":
            //a. все целые числа от 20 до 35;
            //b. квадраты всех целых чисел от 10 до b (значение b вводится с клавиатуры; b > 10);
            //c. третьи степени всех целых чисел от a до 50 (значение a вводится с клавиатуры; a < 50);
            //d. все целые числа от a до b (значения a и b вводятся с клавиатуры; b > a).
            
            
            //Моя логика присваивать названия переменным подошла к концу так что сорри

            
           /* int a = 20, b = 35; 
            int x = 10;
            int y = 50;
            //a. все целые числа от 20 до 35
            Console.WriteLine("Все числа  20 до 35");
            for (; a <= b; a++)          
               Console.WriteLine(a);
            Console.WriteLine("------------");
            //b. квадраты всех целых чисел от 10 до b (значение b вводится с клавиатуры; b > 10);
            Console.WriteLine("Ввидете  от b до больше 10");
            int c = int.Parse(Console.ReadLine());
            for (; x <= c;x++)
                 Console.WriteLine(x*x);
            Console.WriteLine("------------");
            
            //c. третьи степени всех целых чисел от a до 50 (значение a вводится с клавиатуры; a < 50);
            Console.WriteLine("Ввидете от а до меньше 50 ");
            int n = int.Parse(Console.ReadLine());
            for (; n <= y; n++)
                Console.WriteLine(n * n * n);
            Console.WriteLine("------------");
            //d. все целые числа от a до b (значения a и b вводятся с клавиатуры; b > a).
            Console.WriteLine("Ввидете а and b");
            int q, w;
            q= int.Parse(Console.ReadLine());
            w = int.Parse(Console.ReadLine());
            for (; q <= w; q++)
                Console.WriteLine(q);
            */
            #endregion
                Console.ReadKey();
        }
    }
}

