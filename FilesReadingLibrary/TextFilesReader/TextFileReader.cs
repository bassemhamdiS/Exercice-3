using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FilesReadingLibrary.TextFilesReader
{
    public class TestFileReader : ITextFileReader
    {
        public string Read(string path)
        {
            if(string.IsNullOrEmpty(path))
            {
                throw new ArgumentNullException("File path is not provided.");
            }
            return File.ReadAllText(path);
        }
    }
}
