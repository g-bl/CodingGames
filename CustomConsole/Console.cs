using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CodingGames
{
    public static class Console
    {
        public static TextWriter Error { get; set; }

        private static string[] _loadedFile;
        private static int _currentIndex;

        public static void LoadTestcase(string fileName)
        {
            string filePath = Path.Combine("Testcases", fileName);
            if (File.Exists(filePath))
            {
                _loadedFile = File.ReadAllLines(filePath);
            }

            _currentIndex = -1;
        }

        public static string ReadLine()
        {
            _currentIndex++;
            return _loadedFile[_currentIndex];
        }

        public static void WriteLine(string value)
        {
            System.Console.WriteLine(value);
        }

        public static void End()
        {
            System.Console.ReadKey();
        }

        public static void DebugLoadedFile()
        {
            foreach (string line in _loadedFile)
            {
                System.Console.WriteLine(line);
            }
            System.Console.ReadKey();
        }
    }

    public class TextWriter
    {
        public void WriteLine(string value)
        {
            System.Console.Error.WriteLine(value);
        }
    }
}