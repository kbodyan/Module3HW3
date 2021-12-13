using System;

namespace ThreeClasses
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const int x = 5, y = 7, z = 5;
            var program = new Program();
            var class1 = new Class1();
            var class2 = new Class2();
            Class1.ShowHandler showHandler = program.Show;
            showHandler(class2.Calc(class1.Pow, x, y)(z));
        }

        public void Show(bool flag)
        {
            Console.WriteLine(flag.ToString());
            Console.ReadLine();
        }
    }
}
