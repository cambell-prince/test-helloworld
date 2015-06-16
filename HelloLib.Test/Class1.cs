using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;

namespace HelloLib.Test
{
    [TestFixture]
    public class TestClass1
    {
        [Test]
        public void TestSayHello_ReturnsHello()
        {
            string result = Class1.SayHello();
            Assert.AreEqual("Hello World", result);
        }

        [Test]
        public void TestSagHallo_ReturnsHallo()
        {
            string result = Class1.SagHallo();
            Assert.AreEqual("Hallo Welt!", result);
        }

    }
}
