using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace crudeApp
{
    public interface ILogger
    {
        void Info(string Message);
        void Error(string Message);
    }
}
