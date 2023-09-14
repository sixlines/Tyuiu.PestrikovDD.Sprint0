using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PestrikovDD.Task2.V0.Lib;

namespace Tyuiu.PestrikovDD.Task2.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вызов класса DataService и метода GetMessage 
            //Из библиотеки Tyuiu.PestrikovDD.Sprint0.V0.Lib
            Console.WriteLine(DataService.GetMessage("Игрь"));
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
