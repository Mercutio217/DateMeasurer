using System;

namespace DateMeasure
{
    public abstract class AbstractDateSign
    {
        private Validator _validator;
        protected string _inputDate;
        internal DateTime ConvertedDate;
        public string Separator;

        protected AbstractDateSign(string inputDate)
        {
            _inputDate = inputDate;
        }

        public virtual bool SetConvertedDate()
        {
            _validator = new Validator(_inputDate);
            var ifWorked = _validator.Validate();
            if (ifWorked)
                ConvertedDate = DateTime.Parse(_inputDate);
            return ifWorked;
        }

        public abstract void SetSeparator();
    }
}