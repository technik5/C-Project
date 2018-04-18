using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient; //für SQL-Connection

namespace SHPro
{
    class SQL_Connect
    {
        //create the SQL_Connecters
        private string sqlPath { get; set; }
        private string sqlUserName { get; set; }
        private string sqlPassword { get; set; }
        private bool sqlSecureConnection { get; set; }
        private string sqlDatabase { get; set; }
        private bool sqlStatus { get; set; }
        //
        SqlConnection myConnection = new SqlConnection("user id=username;" + "password=password;server=serverurl;" + "Trusted_Connection=yes;" + "database=database; " + "connection timeout=30");
        /*
         * //Check if Systemfile with Data is existing, if not create a new one
         * using SystemIO
         * public checkExistanceConfig (){
             * private bool sqlExistingConfig == false;
             * if (sqlExistigConfig==false)
             * {
             *  sqlPath, sqlUserName, ... = ""
             *  MessageBox ("No such file could be found, a new SQL-ConnectWindow has been created"; button OK")
             * } else if (sqlExistingConfig == true)
             * {
             *  load configFile-Data();
             *  fillfields();
             * }
         * }
         * 
         * //public void configFile-Data(){
         * SystemIO....loadFile
         * string = string of file;
         * return ()
         * }
         * 
         * 
         * //fill fields with data from file
         *  public void fillFields() {
         *  readConfigFile();
         *  this.sqlPath == readConfigFile;
         *  ...
         *  }
         * 
        //Create connection
        //sqlConnectionStatus is false
        /* If (sqlConnectionStatus is false)
         * {
         *      try
         *      {connect sql server sqlPath with sqlUserName and sqlPassword use sqlSecureConnection
         *      } catch (Exeption) is sqlserver connected => sqlStatus == true;
         *      return MessageBox("Ihre Verbindung war erfolgreich");
         *      {
         *      }
         * }
         * */
    }
}
