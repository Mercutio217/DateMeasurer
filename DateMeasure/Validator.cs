using System;
using System.Globalization;

namespace DateMeasure
{
    public class Validator
    {
        private string _input;

        public Validator(string input)
        {
            _input = input;
        }

        public bool Validate()
        {
            var isValid = DateTime.TryParse(_input, CultureInfo.CurrentCulture,
                DateTimeStyles.None, out var nullDate);

            return isValid;
        }
    }
}