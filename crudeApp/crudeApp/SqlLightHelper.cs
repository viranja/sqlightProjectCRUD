using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
namespace crudeApp
{
    public class SqlLightHelper:IDBHelper
    {
        private string DBName = "MX005.db";
        private string FilePath = "../../DB";
        private string FullPath = "";
        ILogger log = new TextLogger();
        public SqlLightHelper()
        {
            FullPath = FilePath + "/" + DBName;
        }



        private void CreateDB()
        {
            if (!System.IO.File.Exists(FilePath))
            {
                log.Info("create directory db location");
                System.IO.Directory.CreateDirectory(FilePath);
            }

            if (!System.IO.File.Exists(FullPath))
            {
                log.Info("create database");
                SQLiteConnection.CreateFile(FullPath);
            }
        }
        #region IDBHelper Members

        public void Init()
        {
            log.Info("Init");
            CreateDB();
        }

        #endregion
    }
}
