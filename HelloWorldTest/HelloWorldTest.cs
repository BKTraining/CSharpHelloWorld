using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpHelloWorld;
using System.IO;

namespace HelloWorldTest
{
    [TestClass]
    public class HelloWorldTest
    {
        [TestInitialize]
        public void InitializeTest()
        {
            // put back console output to default state
            StreamWriter standardOut = new StreamWriter(Console.OpenStandardOutput());
            standardOut.AutoFlush = true;
            Console.SetOut(standardOut);
        }

        [TestMethod]
        public void shouldSayHelloWriteHelloWorldInConsole()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                HelloWorld hello = new HelloWorld();
                hello.sayHello();

                string expected = "Hello World";
                string result = sw.ToString();
                Assert.AreEqual<string>(expected, result);

            }
        }
    }
}
