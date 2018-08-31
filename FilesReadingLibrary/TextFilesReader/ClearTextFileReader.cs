using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FilesReadingLibrary.TextFilesReader
{
    public class ClearTestFileReader : TextFileReaderFactory, IFileReader
    {
        public string Read(string path)
        {
            if(string.IsNullOrEmpty(path))
            {
                throw new ArgumentNullException("File path is not provided.");
            }
            try
            {
                return File.ReadAllText(path);
            }
            catch(FileNotFoundException ex)
            {
                throw ex;
            }
        }
    }
}
