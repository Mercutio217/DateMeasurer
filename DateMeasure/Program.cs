using System;
using System.Collections.Generic;

namespace DateMeasure
{
    internal class Program
    {
        private const string ErrorMessage =
            "Your input has to be two dates in Your local time, end has to be greater than start!";

        private static bool ArgsCheck(string[] args)
        {
            if (args.Length == 2) return true;
            Console.WriteLine(ErrorMessage);
            return false;
        }


        public static void Main(string[] args)
        {
            if (!ArgsCheck(args)) return;
            var program = new ControlFacade(args[0], args[1]);
            program.Run();
        }
    }
}