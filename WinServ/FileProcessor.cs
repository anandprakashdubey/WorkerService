using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinServ
{
    internal class FileProcessor
    {
        public static string ReadFile(string folderPath, string fileName)
        {
            string data = string.Empty;

            Logger.Write("Method FileProcessor.ReadFile Started ", LogConstant.Info);

            string filePath = Path.Combine(folderPath, fileName);

            if (!File.Exists(filePath))
            {
                Logger.Write($"Method FileProcessor.ReadFile - File Not Found at {filePath}", LogConstant.Error);
            }
            else
            {

                try
                {
                    data = File.ReadAllText(filePath);
                    Logger.Write($"Method FileProcessor.ReadFile - File Found at {filePath}", LogConstant.Info);

                    FileProcessor.MoveFile(filePath, @$"D:\GIT\WinServ\ProcessedFile\{fileName}");
                }
                catch (Exception ex)
                {
                    Logger.Write($"Method FileProcessor.ReadFile - Exception Occured - {ex} ", LogConstant.Error);
                }
            }

            return data;
        }

        public static void MoveFile(string sourcePath, string destinationPath)
        {
            try
            {
                File.Move(sourcePath, destinationPath);
            }
            catch (Exception ex)
            {
                Logger.Write($"Method FileProcessor.MoveFile - Exception Occured - {sourcePath} to {destinationPath} and Detail Exception - {ex} ", LogConstant.Error);
            }
        }

    }
}
