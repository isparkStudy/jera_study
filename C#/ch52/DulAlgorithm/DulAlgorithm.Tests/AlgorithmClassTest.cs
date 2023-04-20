using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulAlgorithm.Tests
{
    [TestClass]
    public class AlgorithmClassTest
    {
        [TestMethod]
        public void MyTestMethod()
        {
            Assert.AreEqual(10, 10);
        }

        [TestMethod]
        public void SelectionSortTest()
        {
            // [1] Arrange(정렬), Setup
            int[] array = { 33, 22, 44 };

            // [2] Act(동작), Excute
            int[] results = DulAlgorithm.Algorithm.SelectionSort(array);

            // [3] Assert(어설션), Verify
            Assert.AreEqual(22, results[0]);
            Assert.AreEqual(44, results[results.Length - 1]);
        }
    }
}
