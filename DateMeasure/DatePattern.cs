using System;
using System.Linq;
using System.Text;

namespace DateMeasure
{
    public class DatePattern
    {
        private DateSign _startDate;
        private DateSign _endDate;

        public DatePattern(DateSign startDate, DateSign endDate)
        {
            _startDate = startDate;
            _endDate = endDate;
        }

        public bool CheckIfStartLesserThanEnd()
        {
            return _startDate.ConvertedDate.Date <= _endDate.ConvertedDate.Date;
        }

        public string GetRange()
        {
            var builder = new StringBuilder(" - ");
            DateTime end = _endDate.ConvertedDate;
            string sep = _startDate.Separator;
            var separatedEndDate = end.ToShortDateString().Replace(".", sep);
            builder.Append(separatedEndDate);
            var startFormatted = Compare();
            if (startFormatted.Length == 0)
            {
                builder.Remove(0, 3);
            }
            else
            {
                builder.Insert(0, startFormatted);
            }

            return builder.ToString();
        }

        private string Compare()
        {
            var start = _startDate.ConvertedDate.ToShortDateString();
            var end = _endDate.ConvertedDate.ToShortDateString();

            var startArray = start.Split('.');
            var endArray = end.Split('.');
            for (var i = startArray.Length -1; i >= 0; i--)
            {
                if (!startArray[i].Equals(endArray[i]))
                    break;
                startArray = startArray.Where(j => !j.Equals(endArray[i])).ToArray();
            }
            return string.Join(_startDate.Separator, startArray);
        }
    }
}