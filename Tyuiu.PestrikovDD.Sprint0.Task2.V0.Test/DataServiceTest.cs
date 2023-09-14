using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PestrikovDD.Task2.V0.Lib;
namespace Tyuiu.PestrikovDD.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            // Область создания методов тестирования, методов из библиотеки
            var name = "Игорь";
            var res = DataService.GetMessage(name);

            //Вызываем класс Assert и метод AreEqual
            Assert.AreEqual("Привет..., Игорь", res);
        }
    }
}
