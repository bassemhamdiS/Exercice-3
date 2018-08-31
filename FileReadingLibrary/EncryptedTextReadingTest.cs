using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using FilesReadingLibrary.TextFilesReader;

namespace FileReadingLibrary
{
    [TestClass]
    public class EncryptedTextReadingTest
    {
        [TestMethod]
        public void Test_TextFileWhen_Encryption_IsEnabled()
        {
            var path = @"C:\Users\bassem\Desktop\SourceCode\Exercice 3\FileReadingLibrary\Ressources\TestCryptedtxt.txt";
            var factory = new TextFileReaderFactory();
            var reader = factory.CreateReader();
            var result = reader.Read(path);
          
            Assert.IsTrue(result.StartsWith("This"));

        }
    }
}
