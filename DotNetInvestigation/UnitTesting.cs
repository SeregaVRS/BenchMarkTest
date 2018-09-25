namespace DotNetInvestigation
{
    using System;
    using System.Net.Mime;
    using System.Reflection;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    public class UnitTesting
    {
        public string PublicAddHelloToString(string text)
        {
            return "Public Hello " + text;
        }

        public string PublicCallPrivateMethod(string text)
        {
            return this.PrivatedHelloToString(text);
        }

        private string PrivatedHelloToString(string text)
        {
            return "Try to get Me from Private " + text;
        }
    }

    [TestClass]
    public class UnitTestingTests
    {
        [TestMethod]
        public void CheckPublicMethod()
        {
            const string ExpectedString = "Public Hello";
            const string InputData = "any string";
            var ut = new UnitTesting();
            var result = ut.PublicAddHelloToString(InputData);
            Assert.IsTrue(result.Contains(InputData));
            Assert.IsTrue(result.Contains(ExpectedString));
        }

        [TestMethod]
        public void CheckPrivateMethod()
        {
            const string InputData = "any string";

            var ut = new UnitTesting();
            
            // Reflection
            Type type = typeof(UnitTesting);
            var privateMethod = type.GetMethod("PrivatedHelloToString", BindingFlags.NonPublic | BindingFlags.Instance);
            var result = privateMethod.Invoke(ut, new object[] { InputData }).ToString();

            Assert.IsTrue(result.Contains(InputData));
            Assert.IsTrue(result.Contains("Try to get Me from Private any string"));
        }

        [TestMethod]
        public void CheckPrivateMethodViaObject()
        {
            const string InputData = "any string";

            // Private Object
            PrivateObject target = new PrivateObject(typeof(UnitTesting));

            var result = target.Invoke("PrivatedHelloToString", InputData).ToString();

            Assert.IsTrue(result.Contains(InputData));
            Assert.IsTrue(result.Contains("Try to get Me from Private any string"));
        }

        [TestMethod]
        public void CheckPrivateMethodAsDynamic()
        {
            const string InputData = "any string";

            // Dynamic
            var target = new UnitTesting();

            //var result = target.AsDynamic().PrivatedHelloToString(InputData);

            //Assert.IsTrue(result.Contains(InputData));
            //Assert.IsTrue(result.Contains("Try to get Me from Private any string"));
        }
    }
}
