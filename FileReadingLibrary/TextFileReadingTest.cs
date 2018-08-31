using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FilesReadingLibrary.TextFilesReader;

namespace FileReadingLibraryTest
{
    [TestClass]
    public class TextFileReadingText
    {
        [TestMethod]
        
        public void TestReadingFile_WhenFilePath_isNull_exceptionIsThrown()
        {
            try
            {
                var textFileReader = new ClearTestFileReader();
                textFileReader.Read(null);
            }
            catch(ArgumentNullException ex)
            {
                Assert.IsNotNull(ex.Message);
            }
        }

        [TestMethod]
        public void TestReadingFile_WhenFilePath_isValid_FileIsReaded()
        {
           
                var textFileReader = new ClearTestFileReader();
                var result = textFileReader.Read(@"C:\Users\bassem\Desktop\SourceCode\Exercice 3\FileReadingLibrary\Ressources\testtxt.txt");
               Assert.IsNotNull(result);
            
        }
    }
}
