using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gruppövning_InternationalFoodAB.Classes
{
    public static class FileDirectory
    {
        public static string GetJsonAdminFilePath()
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string solutionFolder = Path.Combine(basePath, @"..\..\..\JSONfiles");
            string jsonAdminFilePath = Path.Combine(solutionFolder, "admin_users.json");

            return jsonAdminFilePath;
        }
        public static string GetJsonReceptPath()
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string solutionFolder = Path.Combine(basePath, @"..\..\..\JSONfiles");
            string jsonReceptFilePath = Path.Combine(solutionFolder, "master_recepts.json");

            return jsonReceptFilePath;
        }
        public static string GetErrorPath()
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string solutionFolder = Path.Combine(basePath, @"..\..\..\Errorlog");
            string errorFilePath = Path.Combine(solutionFolder, "errorLog.txt");

            return errorFilePath;
        }
    }
}
