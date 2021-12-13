using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.Mocking
{

    class FileReader:IFileReader
    {
        
        public string Read(string path)
        {
            return File.ReadAllText(path);
        }
    }
    //public class FakeFileReader : IFileReader
    //{
    //    public string Read(string path)
    //    {
    //        return "";
    //    }
    //}
    //After installing Moq, we no longer need to use FakeFileReader
}
