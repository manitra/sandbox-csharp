using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using NuGet;
using NUnit.Framework;

namespace Sandbox.Console
{
    [TestFixture]
    public class GetAttributeTest
    {
        [Test]
        public void GetAttributeWithInheritance_ReturnsSomething()
        {
            Assert.IsNotEmpty(typeof(Child).GetCustomAttributes(typeof(Attr), true));
        }
        
        [Test]
        public void GetAttributeWithoutInheritance_ReturnsNull()
        {
            Assert.IsEmpty(typeof(Child).GetCustomAttributes(typeof(Attr), false));
        }
        
        [Attr]
        public class Parent
        {

        }

        public class Child : Parent
        {

        }

        public class Attr : Attribute
        {

        }
    }

}
