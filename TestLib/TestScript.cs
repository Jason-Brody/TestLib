using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLib
{
    public class TestScript
    {
        public int TotalSteps { get; private set; }

        private List<TestStep> Steps { get; private set; }

        public TestScript(int StepsCount)
        {
            this.TotalSteps = StepsCount;
            Steps = new List<TestStep>();
        }

        public string WorkFolder { get; set; }

        public string ResultSavePath { get; set; }
    }
}
