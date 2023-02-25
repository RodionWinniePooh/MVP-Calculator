using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_Project
{
    internal interface ICalculatorView
    {
        string Input { get; set; }
        event EventHandler Calculate;
        void ShowResult(string result);
        void ShowError(string message);
    }
}
