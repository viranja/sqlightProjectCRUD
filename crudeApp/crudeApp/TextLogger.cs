using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace crudeApp
{
    public class TextLogger:ILogger
    {
        private string FileName = "{0}.txt";
        private string FilePath = "../../Log";
        private string FullPath = "";
       
        public TextLogger()
        {
           
            init();
            string fileDate = DateTime.Now.ToString("ddMMMyyyy");
            FileName = string.Format(FileName, fileDate);
            FullPath = FilePath + "/" + FileName;
        }

        private void init()
        {
          

            if (!System.IO.File.Exists(FilePath))
            {
                System.IO.Directory.CreateDirectory(FilePath);
            }

            
            
        }

        private void Write(string Message, string LogType)
        {
           

            string date = DateTime.Now.ToString("ddMMMyyyy:hh:mm");
            System.IO.StreamWriter sw = new System.IO.StreamWriter(FullPath,true);
            sw.WriteLine(date + "|" + LogType + "->" + Message);
            sw.WriteLine("--------------------------------------------------------");
            sw.Close();
        }

        #region ILogger Members

        public void Info(string Message)
        {
            Write(Message, "Info");
        }

        public void Error(string Message)
        {
            Write(Message, "Error");
        }

        #endregion
    }
}
