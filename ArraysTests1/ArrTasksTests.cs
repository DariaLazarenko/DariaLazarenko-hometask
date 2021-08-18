using Microsoft.VisualStudio.TestTools.UnitTesting;
using Arrays;
using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays.Tests
{
    [TestClass()]
    public class ArrTasksTests
    {
        [TestMethod()]
        public void Test34arrTest()
        {
            //Arrange
            int[] arr1 = { 0, 3, -5, 7, -8 };

            ArrTasks task = new ArrTasks();

            int expPos = 2;
            //int expNeg = 2;
            //int expZ = 1;

            //Act
            int actPos = task.Test34arr(arr1);

            //Assert
            Assert.AreEqual(expPos, actPos);
        }
    }
}