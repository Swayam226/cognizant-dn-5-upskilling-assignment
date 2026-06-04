using System;
using System.Diagnostics;
using System.IO;

class Logger
{
    private static readonly string logFilePath = "app_log.txt";

    static Logger()
    {
        TextWriterTraceListener fileListener = new TextWriterTraceListener(new StreamWriter(logFilePath, append: true));
        TextWriterTraceListener consoleListener = new TextWriterTraceListener(Console.Out);
        Trace.Listeners.Add(fileListener);
        Trace.Listeners.Add(consoleListener);
        Trace.AutoFlush = true;
    }

    public static void Log(string message)
    {
        Trace.WriteLine("[" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "] INFO: " + message);
    }

    public static void LogWarning(string message)
    {
        Trace.WriteLine("[" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "] WARNING: " + message);
    }

    public static void LogError(string message)
    {
        Trace.WriteLine("[" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "] ERROR: " + message);
    }
}

class Program
{
    static void Main()
    {
        Logger.Log("Application started.");
        Logger.Log("Processing user request.");
        Logger.LogWarning("Low memory detected.");
        Logger.LogError("Failed to connect to database.");
        Logger.Log("Application shutting down.");
        Console.WriteLine("\nLog also saved to: app_log.txt");
    }
}
