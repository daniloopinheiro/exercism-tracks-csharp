namespace Practices.Exercises;

public class LogLine
{
    public static string Message(string logLine)
    {
        // Implement the (static) LogLine.Message() method to return a log line's message:
        var parts = logLine.Split(": ", 2);
        return parts.Length > 1 ? parts[1].Trim() : string.Empty;
        throw new NotImplementedException("Please implement the (static) LogLine.Message() method");
    }

    public static string LogLevel(string logLine)
    {
        // Implement the (static) LogLine.LogLevel() method to return a log line's log level, which should be returned in lowercase:
        int start = logLine.IndexOf('[') + 1;
        int end = logLine.IndexOf(']');
        if (start >= 0 && end > start)
        {
            return logLine.Substring(start, end - start).ToLower();
        }
        return string.Empty;
        throw new NotImplementedException("Please implement the (static) LogLine.LogLevel() method");
    }

    public static string Reformat(string logLine)
    {
        // Implement the (static) LogLine.Reformat() method that reformats the log line, putting the message first and the log level after it in parentheses:
        return $"{Message(logLine)} ({LogLevel(logLine)})";
        throw new NotImplementedException("Please implement the (static) LogLine.Reformat() method");
    }
}