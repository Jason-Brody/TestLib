using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLib
{
    public delegate void OnProcessHandler(object sender,ProcessArgs e);
    public interface ITestRun
    {
        void Run();
    }

    public interface ITestProcess
    {
        event OnProcessHandler OnProcess;
    }

    public class ProcessArgs:EventArgs
    {
        public int Current { get; set; }

        public int Maximum { get; set; }
    }
}
