using System;
using Data;
using Domain;


namespace Presentation
{
    public class CalculatorPresenter
    {
        private readonly ICalculatorView _view;
        private readonly CalculatorModel _model;


        public CalculatorPresenter(ICalculatorView view, CalculatorModel model)
        {
            _view = view;
            _model = model;

            _view.Calculate += OnCalculate;
        }

        private void OnCalculate(object sender, EventArgs e)
        {
            string input = _view.Input;
            string[] numbers = input.Split('+');

            if (numbers.Length != 2 || !int.TryParse(numbers[0], out int num1) || !int.TryParse(numbers[1], out int num2))
            {
                _view.ShowError("Error, Invalid input format.");
            }
            else
            {
                int result = _model.Add(num1, num2);
                _view.ShowResult(result.ToString());
            }
        }
    }
}
