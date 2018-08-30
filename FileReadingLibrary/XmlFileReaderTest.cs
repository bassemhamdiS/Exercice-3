using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FilesReadingLibrary.XMLFileReader;
namespace FileReadingLibrary
{
    [TestClass]
    public class XmlFileReaderTest 
    {
        [TestMethod]
        public void TestReadingXmlFile_WhenFilePath_isValid_FileIsReaded()
        {

            var xmlFileReader = new XMLFileReader();
            var result = xmlFileReader.Read(@"C:\Users\bassem\Desktop\SourceCode\Exercice 3\FileReadingLibrary\testxML.xml");
            Assert.IsNotNull(result.Contains("note"));

        }
    }
}
