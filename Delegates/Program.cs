using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        delegate int P(string str);      // 1. Объявляем делегат

        static void Main(string[] args)
        {
            P A;                      // 2. Создаем переменную делегата    
            string s = "Ok";
            //A = MyMethod1;                         // 3. Присваиваем этой переменной адрес метода
            //P s = new P(MyMethod1);
            int z = 0;
            //M(z, str1);


            //1
            //M((s) => { Console.WriteLine(s); return 0; }, "Geek");

            //2
            //int A(string str) { Console.WriteLine(str); return str.Length; }
            //M(A, "Geek");

            //3 
            //M(delegate(string s) { Console.WriteLine(s); return 0; }, "Geek");

            //4
            //M((string)=>{ Console.WriteLine(string);return 0; }, "Geek");

            //5
            //int A(string str) { Console.WriteLine(str); return str.Length; }
            //Func D = new Func(A);
            //M(D, "Geek");
        }

        void  M(int x, string str)
        {
            Console.WriteLine(str);
        }

       static int MyMethod1(string str)
        {

            return str.Length;
        }

       
    }
}
