using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace FilesReadingLibrary.XMLFileReader
{
    public class XMLFileReader :IFileReader
    {
         
        public string Read(string path)
        {

            if (string.IsNullOrEmpty(path))
            {
                throw new ArgumentNullException("File path is not provided.");
            }
            try
            {
                var doc = new XmlDocument();
                doc.Load(path);

                return doc.InnerXml;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
  }
}
