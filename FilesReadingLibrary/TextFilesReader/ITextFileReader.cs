using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesReadingLibrary.TextFilesReader
{
    public interface ITextFileReader
    {
         string Read(string path);
    }
}
