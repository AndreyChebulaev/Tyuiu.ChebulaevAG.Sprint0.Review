using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ChebulaevAG.Sprint0.Review.V0.Lib;

namespace Tyuiu.ChebulaevAG.Sprint0.Review.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalc()
        {
            DataService dataService = new DataService();

            int x = 1;
            int y = 2;
            int z = 3;

            int result = dataService.Calc(x, y, z);

            int expected = (x + y + z) * 5;

            if (result == expected)
            {
                Console.WriteLine("Метод Calc работает корректно: " + result);
            }
            else
            {
                Console.WriteLine("Метод Calc работает некорректно" + expected);
            }
        }
    }
}
