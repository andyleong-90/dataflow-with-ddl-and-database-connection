using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// please note that this class is not used. replaced by Nlog

namespace FormMiniProject
{
    public class LoggingClass
    {
        public void LogMsgToFile(String msg)
        {
            System.IO.StreamWriter sw = System.IO.File.AppendText("C:\\Users\\andy\\source\\repos\\FormMiniProject\\FormMiniProject\\LogFile.txt");

            try
            {
                String logLine = System.String.Format("{0:G}: {1}.", System.DateTime.Now, msg);
                sw.WriteLine(logLine);
            }
            finally {
                sw.Close();
            }
        }
    }
}
