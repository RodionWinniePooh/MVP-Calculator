using System;

namespace Domain
{
    public interface ICalculatorView
    {
        string Input { get; set; }
        event EventHandler Calculate;
        void ShowResult(string result);
        void ShowError(string message);
    }
}
