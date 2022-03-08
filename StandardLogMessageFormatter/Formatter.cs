using System;

namespace StandardLogMessageFormatter
{
    public class Formatter
    {

        public string FormatDebug(string message)
        {
            return $"DEBUG|{message}";
        }

        public string FormatInfo(string message)
        {
            return $"INFO|{message}";
        }
    }
}
