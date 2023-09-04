using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mni
{
    class SqlConnectionString
    {
        /// <summary>
        /// Извлечение строки подключения по её названию из файла App.config. 
        /// В качестве аргумента принимает название строки подключения.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public string GetConnectionStringByName(string name)
        {
            string? returnValue = null;

            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[name];

            if (settings != null)
                returnValue = settings.ConnectionString;

            return returnValue ?? "Connection string not found";
        }
    }
}
