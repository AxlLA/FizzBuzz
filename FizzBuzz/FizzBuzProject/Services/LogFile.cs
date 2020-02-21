using Microsoft.AspNetCore.Hosting.Internal;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;

namespace FizzBuzProject.Services
{
    public class LogFileService
    {
        public static void LogFile(string numeros)
        {

            DateTime time = DateTime.Now;
            string fecha = time.ToString();
            fecha = fecha.Replace('/', '_');
            fecha = fecha.Replace(':', '_');
            fecha = fecha.Trim(' ');

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "Log_"+fecha+".txt"), true))
            {
                outputFile.WriteLine(String.Format("{0}  {1}", fecha, numeros));
            }
        }
    }
}

