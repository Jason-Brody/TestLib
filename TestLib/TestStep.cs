using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLib
{
    public class TestStep
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public bool IsPass { get; set; }

        public object ExpectedResult { get; set; }

        public object ActualResult { get; set; }

        
    }
}
