using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesReadingLibrary.TextFilesReader
{
    public class EncryptedFileReader : IFileReader
    {
        
        public  string Read(string path)
        {
            var text = File.ReadAllText(path);
            
            if(string.IsNullOrEmpty(text))
            {
                throw new InvalidOperationException("File content error");
            }
            return new string(Enumerable.Range(1, text.Length)
                                        .Select(i => text[text.Length - i])
                                        .ToArray());

        }
    }
}
