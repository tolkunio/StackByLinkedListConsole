using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork_000
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<double> source = new Stack<double>();//источник
            //Stack target = new Stack();//приемник
            source.Push(3.5);  //=>3.5      
            source.Push(12.5); //=>12.5
            source.Push(1.1);  //=>1.1
            source.Push(4.3);  //=>4.3
            source.Push(4.1);  //=>4.1
            source.Push(3.1);  //=>3.1
            source.Push(5.4);  //=>5.4
            source.Push(9.8);  //=>9.8
            using (var fileStream = new FileStream("File.txt", FileMode.OpenOrCreate))
            using (var writer = new StreamWriter(fileStream))
            {
                for (int i = 1; i < 9; i++)
                {
                    writer.WriteLine($"{i} element => {source.Pop()}");
                }
                Console.WriteLine("Успешно был записан в файл!");
            }
            Console.ReadKey();
        }
    }
}
