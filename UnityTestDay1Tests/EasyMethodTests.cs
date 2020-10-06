using UnityTestDay1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnityTestDay1.Tests
{
    [TestClass()]
    public class EasyMethodTests
    {
        [TestMethod()]
        public void Method1Test_乎較時應回傳結果維7()
        {
            var Sut = new EasyMethod();
            var expected = 7;

            var actual = Sut.Method1();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Method2Test_乎較時應回傳結果維10()
        {
            var Sut = new EasyMethod();
            var expected = 10;

            var actual = Sut.Method2();

            Assert.AreEqual(expected, actual);
        }
    }
}