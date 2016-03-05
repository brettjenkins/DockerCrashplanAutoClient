using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashplanRenamer
{
    class Program
    {
        static void Main(string[] args)
        {

            var stringBuilder = new StringBuilder();

            foreach(var line in File.ReadAllText(@"c:\Scripts\crashplanOutput.txt")){
                stringBuilder.Append(line);
            }

            var str = stringBuilder.ToString();
            str = str.Trim();

            var write = $"4243,{str},IP";

            File.WriteAllText(@"C:\ProgramData\CrashPlan\.ui_info", write);

        }
    }
}
