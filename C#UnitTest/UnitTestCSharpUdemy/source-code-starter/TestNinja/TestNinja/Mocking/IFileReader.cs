namespace TestNinja.Mocking
{
    public interface IFileReader
    {
        string Read(string path);
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
