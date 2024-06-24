using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markijan_NP_T1.Logging
{
    public class Logger
    {
        private static Logger instance = new Logger();
        private string filePath = @"C:\OLeg\programs\csharps projects\Markijan_NP_T1\Markijan_NP_T1\Data\Error_List.txt";
        public static Logger Instance => instance;
        private Logger() { }
        public void LogError(string error)
        {
            using (var writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine($"{DateTime.Now} : {error}");
            }
        }
    }
}
