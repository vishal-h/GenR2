using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenR2.DAL.Command
{
    public class TestCommand
    {
        public string Message { get; set; }
        public TestCommand()
        {
            this.Message = "Hello";
        }
    }
}
