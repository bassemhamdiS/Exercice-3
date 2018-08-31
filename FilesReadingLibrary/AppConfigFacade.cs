using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesReadingLibrary
{
    public static class AppConfigFacade
    {
        public static bool IsTextEncreptionEnabled()
        {
            return Boolean.Parse(ConfigurationManager.AppSettings["IsTextEncreptionEnabled"]); 
        }
    }
}
