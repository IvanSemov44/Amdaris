using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionAndDebug
{
    public class DemoException : Exception
    {
        public DemoException(string message): base(message)
        {

        }
    }
}
