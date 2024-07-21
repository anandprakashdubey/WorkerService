using Serilog;
using System.Reflection;

namespace WinServ
{
    public static class Logger
    {
        static string assemblyName = Assembly.GetExecutingAssembly().GetName().Name;
        static string logPath = @"D:\GIT\WinServ\Logs\log.txt";

        public static void Register()
        {
            Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Information()
            .WriteTo.Console()
            .WriteTo.File(logPath,
                rollingInterval: RollingInterval.Day,
                rollOnFileSizeLimit: true)
            .CreateLogger();

        }

        public static void Write(string message, string type)
        {
            string _msg = $"{assemblyName}: At - {message}";


            if (type != null && type == "Error")
            {
                Log.Error(_msg);
            }
            else
            {
                Log.Information(_msg);
            }

        }
    }

    public static class LogConstant { public static readonly string Info = "Info"; public static readonly string Error = "Error"; }
}
