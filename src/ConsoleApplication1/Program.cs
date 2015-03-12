using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// делаем вот такое шаманство, чтобы использовать нашу библиотеку
using COProjectDll;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // сразу говорю - ConsoleApplication1 плохое название, как и класс 1, и т.д.
            // называем все своими имеами

            // создаем 2 экземпляра дроби с ужасными названиями
            var fraction1 = new Fraction(3, 7); // =3/7

            var fraction2 = new Fraction(4, 7); // = 4/7

            // два пути:
            // 1) fraction1 изменится, и станет равным 49 / 49
            // потому что класс у нас не производит нормализацию дроби после сложения!
            // попробуй потом дописать нормализацию
            // fraction2 не изменится
            fraction1.Summ(fraction2);

            //2) создаем дробь по умолчанию = 0 ( = 0/1 )
            var res = new Fraction();

            // вуаля, прям как с числами))
            // ни певая ни вторая дробь не изменятся!
            res = fraction1 + fraction2;
            // результат не удивителен)) будет 2891 / 343
            // потому что после 1 сложения дробь изменинлась!

            // про формат строки лучше почитать
            Console.WriteLine("{0} / {1}", res.Numerator, res.Denominator);

            //ctrl + f5 - посмотреть результат))
        }
    }
}
