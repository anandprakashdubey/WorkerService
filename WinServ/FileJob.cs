using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinServ;

namespace WinServ
{
    public static class FileJob
    {
        public static void Start()
        {
            Logger.Register(); // Logging

            Logger.Write("Application Start", LogConstant.Info);

            string fileData = FileProcessor.ReadFile(@"D:\GIT\WinServ\DropLocation", "Test.txt");

            Console.WriteLine(fileData);

        }
    }
}
