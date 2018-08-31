using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesReadingLibrary.TextFilesReader
{
    public class TextFileReaderFactory 
    {
       
       public IFileReader CreateReader()
        {
            if (AppConfigFacade.IsTextEncreptionEnabled() == false)
            {
                return new ClearTestFileReader();
            }
            else
            {
                return new EncryptedFileReader();
            }
        }
    }
}
