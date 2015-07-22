using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLib
{
    public class TestScenario
    {
        public int TotalScripts { get; set; }

        public TestScenario()
        {
            Scripts = new List<TestScript>();
        }

        public List<TestScript> Scripts { get; private set; }
    }
}
