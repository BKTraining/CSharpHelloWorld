using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHelloWorld
{
    public class HelloWorld
    {
        private const string message = "Hello World";

        public void sayHello()
        {
            Console.WriteLine(message);
        }

        public void sayHelloFrom(String Name)
        {
            Console.WriteLine(message + " from " + Name);
        }
    }
}
