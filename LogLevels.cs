using System;

static class LogLine
{
    public static string Message(string logLine)
    {
        int first = logLine.IndexOf(":") + ":".Length;
        String message = logLine.Substring(first).Trim();
        return message;
    }

    public static string LogLevel(string logLine)
    {
        int last = logLine.LastIndexOf("]");
        String loglevel = logLine.Substring(1, last - 1).Trim().ToLower();
        return loglevel;
        
    }

    public static string Reformat(string logLine)
    {
        String reformatedMessage = $"{Message(logLine)} ({LogLevel(logLine)})"; 
        return reformatedMessage;
        
    }
}
