using System;

namespace DateMeasure
{
    public class ControlFacade
    {
        private string _firstInput;
        private string _secondInput;
        private DatePattern _pattern;

        public ControlFacade(string firstInput, string secondInput)
        {
            _firstInput = firstInput;
            _secondInput = secondInput;
        }

        public void SetPattern()
        {
            var firstSign = new DateSign(_firstInput);
            var secondSign = new DateSign(_secondInput);
            if (!firstSign.SetConvertedDate() | !secondSign.SetConvertedDate())
                throw new ArgumentException();
            firstSign.SetSeparator();
            secondSign.SetSeparator();
            _pattern = new DatePattern(firstSign, secondSign);
        }

        private string GetDateRange()
        {
            if (!_pattern.CheckIfStartLesserThanEnd())
                throw new ArgumentException();
            return _pattern.GetRange();
        }

        public void Run()
        {
            try
            {
                SetPattern();
                var result = GetDateRange();
                Console.WriteLine(result);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Your input has to be two dates in your local time, second one should be greater.");
            }
        }
    }
}