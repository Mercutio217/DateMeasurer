using System.Text.RegularExpressions;

namespace DateMeasure
{
    public class DateSign : AbstractDateSign
    {
        public DateSign(string inputDate) : base(inputDate)
        {
        }

        public override void SetSeparator()
        {
            var regex = new Regex(@"[^a-zA-Z0-9]");
            var match = regex.Match(_inputDate);
            Separator = match.Value;
        }
    }
}