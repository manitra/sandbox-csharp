using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Sandbox.Console
{
    [TestFixture]
    public class NugetDependencyTasks
    {
        [Test]
        [TestCase("Rx-Core", "2.2.4")]
        public void FindUsage(string name, string version)
        {
            
        }
    }
}
