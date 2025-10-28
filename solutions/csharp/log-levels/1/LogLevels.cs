static class LogLine
{
    public static string Message(string logLine)
    {
       string[] parts= logLine.Split(new[] { ':' }, 2);
        return parts[1].Trim();
        throw new NotImplementedException("Please implement the (static) LogLine.Message() method");
    }

    public static string LogLevel(string logLine)
    {
        string level=logLine.Split(']')[0];
        return level.Replace("[","").ToLower();
        throw new NotImplementedException("Please implement the (static) LogLine.LogLevel() method");
    }

    public static string Reformat(string logLine)
    {
        string message=Message(logLine);
        string level=LogLevel(logLine);
        return $"{message} ({level})";
        throw new NotImplementedException("Please implement the (static) LogLine.Reformat() method");
    }
}
