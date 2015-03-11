using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COProjectDll
{
    public class Class1
    {
    }


    class testProgramm
    {
        static void Main()
        {
            testClass example1 = new testClass(10, 5);
            example1.Summ();
            example1.Divided();
            example1.Print();
        }
    }

    class testClass
    {
        private int num1;
        private int num2;
        public int summ;
        public int divid;

        public testClass(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public void Summ()
        {
            summ = num1+num2;
        }

        public void Divided()
        {
            divid=num1/num2;
        }

        public void Print()
        {
            Console.WriteLine("Сложение через метод:   {0} + {1} = {2}", num1, num2, summ);
            Console.WriteLine("Деление через метод:   {0} / {1} = {2}", num1, num2, divid);
            Console.WriteLine("Сложение через оператор:   {0} + {1} = {2}", num1, num2, num1 + num2);
            Console.WriteLine("Деление через оператор:   {0} / {1} = {2}", num1, num2, num1 / num2);
        }
    }
}
